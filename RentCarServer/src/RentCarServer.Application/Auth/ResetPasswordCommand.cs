using FluentValidation;
using GenericRepository;
using RentCarServer.Domain.Users;
using TS.MediatR;
using TS.Result;

namespace RentCarServer.Application.Auth;

public sealed record ResetPasswordCommand(Guid ForgotPasswordCode, string newPassword) : IRequest<Result<string>>;

public sealed class ResetPasswordValidator : AbstractValidator<ResetPasswordCommand>
{
    public ResetPasswordValidator()
    {
        _ = RuleFor(x => x.newPassword).NotEmpty().WithMessage("Geçerli bir yeni şifre girin.");
    }
}

public sealed class ResetPasswordCommandHandler(IUserRepository userRepository, IUnitOfWork unitOfWork) : IRequestHandler<ResetPasswordCommand, Result<string>>
{
    public async Task<Result<string>> Handle(ResetPasswordCommand request, CancellationToken cancellationToken)
    {
        var user = await userRepository.FirstOrDefaultAsync(x =>
        x.ForgotPasswordCode != null &&
        x.ForgotPasswordCode.Value == request.ForgotPasswordCode &&
        x.IsForgotPasswordCompleted.Value == false, cancellationToken);

        if (user == null) return Result<string>.Failure("Geçersiz veya süresi dolmuş şifre sıfırlama isteği.");

        var fpDate = user.ForgotPasswordDate!.Value.AddDays(1);
        var now = DateTimeOffset.Now;
        if (fpDate < now) return Result<string>.Failure("Geçersiz veya süresi dolmuş şifre sıfırlama isteği.");

        user.ReSetPassword(request.newPassword);
        userRepository.Update(user);
        _ = await unitOfWork.SaveChangesAsync();

        return Result<string>.Succeed("Şifreniz başarıyla sıfırlandı.");
    }
}