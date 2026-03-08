using FluentValidation;
using RentCarServer.Application.Services;
using RentCarServer.Domain.Users;
using TS.MediatR;
using TS.Result;

namespace RentCarServer.Application.Auth;

public sealed record LoginCommand(string EmailOrUserName, string Password) : IRequest<Result<string>>
{
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
    (IUserRepository userRepository, IJwtProvider jwtProvider) : IRequestHandler<LoginCommand, Result<string>>
{
    public async Task<Result<string>> Handle(LoginCommand request, CancellationToken cancellationToken)
    {
        var user = await userRepository.FirstOrDefaultAsync
            (x => x.UserName.Value == request.EmailOrUserName || x.Email.Value == request.EmailOrUserName);
        if (user is null)
            return Result<string>.Failure("Kullanıcı adı veya şifre hatalı.");
        var checkPassword = user.VerifyPasswordHash(request.Password);
        if (!checkPassword)
            return Result<string>.Failure("Kullanıcı adı veya şifre hatalı.");
        var token = await jwtProvider.CreateTokenAsync(user, cancellationToken);

        return token;
    }
}