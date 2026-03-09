using FluentValidation;
using GenericRepository;
using RentCarServer.Application.Services;
using RentCarServer.Domain.Users;
using TS.MediatR;
using TS.Result;

namespace RentCarServer.Application.Auth;

public sealed record LoginCommand(string EmailOrUserName, string Password) : IRequest<Result<LoginCommandResponse>>
{
}
public sealed record LoginCommandResponse
{
    public string? Token { get; set; }
    public string? TFACode { get; set; }
}
public sealed class LoginCommandValidator : AbstractValidator<LoginCommand>
{
    public LoginCommandValidator()
    {
        _ = RuleFor(x => x.EmailOrUserName)
            .NotEmpty().WithMessage("Email or username is required.");
        _ = RuleFor(x => x.Password)
            .NotEmpty().WithMessage("Password is required.");
    }
}

public sealed class LoginCommandHandler
    (IUserRepository userRepository, IJwtProvider jwtProvider, IMailService mailService, IUnitOfWork unitOfWork) : IRequestHandler<LoginCommand, Result<LoginCommandResponse>>
{
    public async Task<Result<LoginCommandResponse>> Handle(LoginCommand request, CancellationToken cancellationToken)
    {
        var user = await userRepository.FirstOrDefaultAsync
            (x => x.UserName.Value == request.EmailOrUserName || x.Email.Value == request.EmailOrUserName);
        if (user is null)
            return Result<LoginCommandResponse>.Failure("Kullanıcı adı veya şifre hatalı.");
        var checkPassword = user.VerifyPasswordHash(request.Password);
        if (!checkPassword)
            return Result<LoginCommandResponse>.Failure("Kullanıcı adı veya şifre hatalı.");
        if (!user.TFAStatus.Value)
        {
            var token = await jwtProvider.CreateTokenAsync(user, cancellationToken);
            var res = new LoginCommandResponse() { Token = token };
            return res;
        }
        else
        {
            user.CreateTFACode();
            userRepository.Update(user);
            _ = await unitOfWork.SaveChangesAsync(cancellationToken);
            string to = user.Email.Value;
            string subject = "Two Factor Authorization Code";
            string body = $"Your two factor authorization code is: <p><h4>{user.TFAConfirmCode!.Value}</h4></p>";
            await mailService.SendEmailAsync(to, subject, body, cancellationToken);
            var res = new LoginCommandResponse() { TFACode = user.TFACode!.Value };
            return res;
        }
    }
}