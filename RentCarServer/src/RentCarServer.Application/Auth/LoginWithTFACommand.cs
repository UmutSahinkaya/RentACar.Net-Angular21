using GenericRepository;
using RentCarServer.Application.Services;
using RentCarServer.Domain.Users;
using TS.MediatR;
using TS.Result;

namespace RentCarServer.Application.Auth;

public sealed record LoginWithTFACommand(string EmailOrUserName, string TFACode, string TFAConfirmCode) : IRequest<Result<LoginCommandResponse>>;

internal sealed class LoginWithTFACommandHandler(IUserRepository userRepository, IJwtProvider jwtProvider, IUnitOfWork unitOfWork) : IRequestHandler<LoginWithTFACommand, Result<LoginCommandResponse>>
{
    public async Task<Result<LoginCommandResponse>> Handle(LoginWithTFACommand request, CancellationToken cancellationToken)
    {
        var user = await userRepository.FirstOrDefaultAsync(x => x.UserName.Value == request.EmailOrUserName || x.Email.Value == request.EmailOrUserName);

        if (user is null)
            return Result<LoginCommandResponse>.Failure("Kullanıcı veya şifre hatalı.");

        if (user.TFACode is null || user.TFAConfirmCode is null || user.TFAExpiresDate is null || user.TFAIsCompleted is null)
            return Result<LoginCommandResponse>.Failure("2FA doğrulama süreci başlatılmamış.");

        if (user.TFAIsCompleted.Value == true)
            return Result<LoginCommandResponse>.Failure("2FA doğrulaması zaten tamamlanmış.");

        if (user.TFAExpiresDate.Value < DateTimeOffset.Now)
            return Result<LoginCommandResponse>.Failure("2FA doğrulama kodunun süresi dolmuş.");

        if (user.TFACode.Value != request.TFACode || user.TFAConfirmCode.Value != request.TFAConfirmCode)
            return Result<LoginCommandResponse>.Failure("2FA doğrulama kodu hatalı.");

        user.SetTFACompleted();
        userRepository.Update(user);
        _ = await unitOfWork.SaveChangesAsync(cancellationToken);


        var token = await jwtProvider.CreateTokenAsync(user);

        return new LoginCommandResponse { Token = token };
    }
}