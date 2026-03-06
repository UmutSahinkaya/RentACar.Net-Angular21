using FluentValidation;
using RentCarServer.Domain.Users;
using TS.MediatR;
using TS.Result;

namespace RentCarServer.Application.Auth;

public sealed record ForgotPasswordCommand(string Email) : IRequest<Result<string>>;

public sealed class ForgotPasswordCommandValidator : AbstractValidator<ForgotPasswordCommand>
{
    public ForgotPasswordCommandValidator()
    {
        _ = RuleFor(x => x.Email)
            .NotEmpty().WithMessage("Geçerli bir E-Mail hesabı giriniz.")
            .EmailAddress().WithMessage("Geçerli bir E-Mail hesabı giriniz.");
    }
}

public sealed class ForgotPasswordCommandHandler(IUserRepository userRepository) : IRequestHandler<ForgotPasswordCommand, Result<string>>
{
    public async Task<Result<string>> Handle(ForgotPasswordCommand request, CancellationToken cancellationToken)
    {
        var user = await userRepository.FirstOrDefaultAsync(x => x.Email.Value == request.Email, cancellationToken);
        if (user is null)
            return Result<string>.Failure("Bu E-Mail adresine sahip bir kullanıcı bulunamadı.");
        //şifre sıfırlama işlemi burada yapılacak. Örneğin, kullanıcıya bir e-posta gönderilebilir veya geçici bir şifre oluşturulabilir.
        return Result<string>.Succeed("Şifre sıfırlama talimatları E-Mail adresinize gönderildi.");
    }
}