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

[Permission("user:edit")]

public sealed record UserUpdateCommand(Guid Id, string FirstName, string LastName, string Email, string UserName, Guid? BranchId, Guid RoleId, bool IsActive) : IRequest<Result<string>>;
public sealed class UserUpdateCommandValidator : AbstractValidator<UserUpdateCommand>
{
    public UserUpdateCommandValidator()
    {
        _ = RuleFor(u => u.FirstName).NotEmpty().WithMessage("Lütfen geçerli bir isim girin.");
        _ = RuleFor(u => u.LastName).NotEmpty().WithMessage("Lütfen geçerli bir soyad girin.");
        _ = RuleFor(u => u.UserName).NotEmpty().WithMessage("Lütfen geçerli bir kullanıcı adı girin.");
        _ = RuleFor(u => u.Email).NotEmpty().EmailAddress().WithMessage("Lütfen geçerli bir email girin.");
    }
}
internal sealed class UserUpdateCommandHandler(IClaimContext claimContext, IUserRepository userRepository, IUnitOfWork unitOfWork) : IRequestHandler<UserUpdateCommand, Result<string>>
{
    public async Task<Result<string>> Handle(UserUpdateCommand request, CancellationToken cancellationToken)
    {
        var user = await userRepository.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
        if (user is null) return Result<string>.Failure("Böyle bir kullanıcı yok.");

        if (user.Email.Value != request.Email)
        {
            var emailExist = await userRepository.AnyAsync(x => x.Email.Value == request.Email, cancellationToken);
            if (emailExist)
                return Result<string>.Failure("Farklı bir email adresi deneyiniz.");
        }
        if (user.UserName.Value != request.UserName)
        {
            var userNameExist = await userRepository.AnyAsync(x => x.UserName.Value == request.UserName, cancellationToken);
            if (userNameExist)
                return Result<string>.Failure("Farklı bir kullanıcı adı deneyiniz.");
        }

        var branchId = claimContext.GetBranchId();
        if (request.BranchId is not null)
            branchId = request.BranchId.Value;
        FirstName firstName = new(request.FirstName);
        LastName lastName = new(request.LastName);
        Email email = new(request.Email);
        UserName userName = new(request.UserName);
        IdentityId branchIdRecord = new(branchId);
        IdentityId roleId = new(request.RoleId);
        user.SetFirstName(firstName);
        user.SetLastName(lastName);
        user.SetFullName();
        user.SetEmail(email);
        user.SetUserName(userName);
        user.SetBranchId(branchIdRecord);
        user.SetRoleId(roleId);
        user.SetStatus(request.IsActive);
        userRepository.Update(user);
        _ = await unitOfWork.SaveChangesAsync(cancellationToken);

        return "Kullanıcı başarıyla güncellendi.";

    }
}