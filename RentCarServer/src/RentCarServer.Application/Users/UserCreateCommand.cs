using FluentValidation;
using GenericRepository;
using RentCarServer.Application.Behaviors;
using RentCarServer.Application.Services;
using RentCarServer.Domain.Abstractions;
using RentCarServer.Domain.Shared;
using RentCarServer.Domain.Users;
using RentCarServer.Domain.Users.ValueObjects;
using TS.MediatR;
using TS.Result;

namespace RentCarServer.Application.Users;

[Permission("user:create")]
public sealed record UserCreateCommand(string FirstName, string LastName, string Email, string UserName, Guid? BranchId, Guid RoleId, bool IsActive) : IRequest<Result<string>>;
public sealed class UserCreateCommandValidator : AbstractValidator<UserCreateCommand>
{
    public UserCreateCommandValidator()
    {
        _ = RuleFor(u => u.FirstName).NotEmpty().WithMessage("Lütfen geçerli bir isim girin.");
        _ = RuleFor(u => u.LastName).NotEmpty().WithMessage("Lütfen geçerli bir soyad girin.");
        _ = RuleFor(u => u.UserName).NotEmpty().WithMessage("Lütfen geçerli bir kullanıcı adı girin.");
        _ = RuleFor(u => u.Email).NotEmpty().EmailAddress().WithMessage("Lütfen geçerli bir email girin.");
    }
}
internal sealed class UserCreateCommandHandler(IClaimContext claimContext, IUserRepository userRepository, IUnitOfWork unitOfWork) : IRequestHandler<UserCreateCommand, Result<string>>
{
    public async Task<Result<string>> Handle(UserCreateCommand request, CancellationToken cancellationToken)
    {
        var emailExist = await userRepository.AnyAsync(x => x.Email.Value == request.Email, cancellationToken);
        if (emailExist) return Result<string>.Failure("Farklı bir email adresi deneyiniz.");
        var userNameExist = await userRepository.AnyAsync(x => x.UserName.Value == request.UserName, cancellationToken);
        if (userNameExist) return Result<string>.Failure("Farklı bir kullanıcı adı deneyiniz.");

        var branchId = claimContext.GetBranchId();
        if (request.BranchId is not null)
            branchId = request.BranchId.Value;
        FirstName firstName = new(request.FirstName);
        LastName lastName = new(request.LastName);
        Email email = new(request.Email);
        UserName userName = new(request.UserName);
        Password password = new("1234");
        IdentityId branchIdRecord = new(branchId);
        IdentityId roleId = new(request.RoleId);
        User user = new(firstName, lastName, email, userName, password, branchIdRecord, roleId, request.IsActive);
        await userRepository.AddAsync(user);
        _ = await unitOfWork.SaveChangesAsync(cancellationToken);

        return "Kullanıcı başarıyla oluşturuldu.";

    }
}