using FluentValidation;
using GenericRepository;
using RentCarServer.Application.Behaviors;
using RentCarServer.Domain.Roles;
using RentCarServer.Domain.Shared;
using TS.MediatR;
using TS.Result;

namespace RentCarServer.Application.Roles;

[Permission("role:create")]

public sealed record RoleCreateCommand(string Name, bool isActive) : IRequest<Result<string>>;

public sealed class RoleCreateCommandValidator : AbstractValidator<RoleCreateCommand>
{
    public RoleCreateCommandValidator()
    {
        _ = RuleFor(x => x.Name).NotEmpty().WithMessage("Role adı girmelisiniz");
    }
}
internal sealed class RoleCreateCommandHandler(IRoleRepository roleRepository, IUnitOfWork unitOfWork) : IRequestHandler<RoleCreateCommand, Result<string>>
{
    public async Task<Result<string>> Handle(RoleCreateCommand request, CancellationToken cancellationToken)
    {
        var nameExists = await roleRepository.AnyAsync(x => x.Name.Value == request.Name, cancellationToken);
        if (nameExists) return Result<string>.Failure("Bu Role adı daha önce kullanılmış");

        Name name = new(request.Name);
        Role role = new(name, request.isActive);
        await roleRepository.AddAsync(role, cancellationToken);
        _ = await unitOfWork.SaveChangesAsync();

        return "Role başarıyla oluşturuldu.";
    }
}