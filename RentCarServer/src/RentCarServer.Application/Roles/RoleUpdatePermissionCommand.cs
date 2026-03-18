using GenericRepository;
using RentCarServer.Domain.Roles;
using TS.MediatR;
using TS.Result;

namespace RentCarServer.Application.Roles;

public sealed record RoleUpdatePermissionCommand(Guid RoleId, List<string> Permissions) : IRequest<Result<string>>;

internal sealed class RoleUpdatePermissionCommandHandler(IRoleRepository roleRepository, IUnitOfWork unitOfWork) : IRequestHandler<RoleUpdatePermissionCommand, Result<string>>
{
    public async Task<Result<string>> Handle(RoleUpdatePermissionCommand request, CancellationToken cancellationToken)
    {
        var role = await roleRepository.FirstOrDefaultAsync(x => x.Id == request.RoleId, cancellationToken);
        if (role is null) return Result<string>.Failure("Böyle bir rol yok.");

        List<Permission> permissions = request.Permissions.Select(s => new Permission(s)).ToList();
        role.SetPermission(permissions);
        roleRepository.Update(role);
        _ = await unitOfWork.SaveChangesAsync(cancellationToken);

        return "Role gerekli izinler eklendi.";
    }
}