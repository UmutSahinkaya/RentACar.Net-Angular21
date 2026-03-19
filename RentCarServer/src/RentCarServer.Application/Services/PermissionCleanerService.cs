using GenericRepository;
using Microsoft.EntityFrameworkCore;
using RentCarServer.Domain.Roles;

namespace RentCarServer.Application.Services;

public sealed class PermissionCleanerService(IRoleRepository roleRepository, PermissionService permissionService, IUnitOfWork unitOfWork)
{
    public async Task CleanRemovedPermissionFromRolesAsync(CancellationToken cancellationToken = default)
    {
        var currentPermissions = permissionService.GetAll();
        var roles = await roleRepository.GetAllWithTracking().ToListAsync(cancellationToken);
        foreach (var role in roles)
        {
            var currentPermissionForRole = role.Permissions.Select(x => x.Value).ToList();
            var filteredPermissions = currentPermissionForRole.Where(x => currentPermissions.Contains(x)).ToList();
            var permissions = filteredPermissions.Select(s => new Permission(s)).ToList();
            role.SetPermission(permissions);
        }
        roleRepository.UpdateRange(roles);
        _ = await unitOfWork.SaveChangesAsync(cancellationToken);
    }
}
