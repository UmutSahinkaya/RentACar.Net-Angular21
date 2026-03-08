using RentCarServer.Domain.Users;
using TS.MediatR;
using TS.Result;

namespace RentCarServer.Application.Auth;

public sealed record CheckForgotPasswordCodeCommand(Guid ForgotPasswordCode) : IRequest<Result<bool>>;

internal sealed class CheckForgotPasswordCodeCommandHandler(IUserRepository userRepository) : IRequestHandler<CheckForgotPasswordCodeCommand, Result<bool>>
{
    public async Task<Result<bool>> Handle(CheckForgotPasswordCodeCommand request, CancellationToken cancellationToken)
    {
        var user = await userRepository.FirstOrDefaultAsync(x =>
        x.ForgotPasswordCode != null &&
        x.ForgotPasswordCode.Value == request.ForgotPasswordCode &&
        x.IsForgotPasswordCompleted.Value == false, cancellationToken);

        if (user == null) return Result<bool>.Failure("Geçersiz veya süresi dolmuş şifre sıfırlama isteği.");

        var fpDate = user.ForgotPasswordDate!.Value.AddDays(1);
        var now = DateTimeOffset.Now;
        if (fpDate < now) return Result<bool>.Failure("Geçersiz veya süresi dolmuş şifre sıfırlama isteği.");

        return true;
    }
}