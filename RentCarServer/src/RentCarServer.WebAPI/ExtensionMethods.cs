using GenericRepository;
using RentCarServer.Application.Services;
using RentCarServer.Domain.Abstractions;
using RentCarServer.Domain.Branches;
using RentCarServer.Domain.Roles;
using RentCarServer.Domain.Shared;
using RentCarServer.Domain.Users;
using RentCarServer.Domain.Users.ValueObjects;

namespace RentCarServer.WebAPI;

public static class ExtensionMethods
{
    public static async Task CreateFirstUserAsync(this WebApplication app)
    {
        using var scope = app.Services.CreateScope();
        var srv = scope.ServiceProvider;
        var userRepository = srv.GetRequiredService<IUserRepository>();
        var roleRepository = srv.GetRequiredService<IRoleRepository>();
        var branchRepository = srv.GetRequiredService<IBranchRepository>();
        var unitOfWork = srv.GetRequiredService<IUnitOfWork>();

        Branch? branch = await branchRepository.FirstOrDefaultAsync(x => x.Name.Value == "Merkez Şube");
        Role? role = await roleRepository.FirstOrDefaultAsync(x => x.Name.Value == "sys_admin");
        if (branch is null)
        {
            Name name = new("Merkez Şube");
            Address address = new("Elazığ", "MERKEZ", "ELAZIĞ MERKEZ");
            Contact contact = new("4244442323", "4244442324", "elazigmerkezsube@info.com.tr");
            branch = new(name, address, contact, true);
            await branchRepository.AddAsync(branch);
        }
        if (role is null)
        {
            Name name = new("sys_admin");
            role = new(name, true);
            await roleRepository.AddAsync(role);
        }
        if (!await userRepository.AnyAsync(p => p.UserName.Value == "admin"))
        {
            FirstName firstName = new("Umut");
            LastName lastName = new("Sahinkaya");
            Email email = new("umutsahinkaya1@gmail.com");
            UserName userName = new("admin");
            Password password = new("1");
            IdentityId branchId = branch.Id;
            IdentityId roleId = role.Id;
            var user = new User(firstName, lastName, email, userName, password, branchId, roleId, true);
            userRepository.Add(user);
            _ = await unitOfWork.SaveChangesAsync();
        }
    }
    public static async Task ClearRemovedPermissionFromRoleAsync(this WebApplication app)
    {
        using var scoped = app.Services.CreateScope();
        var srv = scoped.ServiceProvider;
        var permissionCleanerService = srv.GetRequiredService<PermissionCleanerService>();
        await permissionCleanerService.CleanRemovedPermissionFromRolesAsync();
    }
}
