using GenericRepository;
using RentCarServer.Domain.Roles;
using TS.MediatR;
using TS.Result;

namespace RentCarServer.Application.Roles;

public sealed record RoleDeleteCommand(Guid Id) : IRequest<Result<string>>;

internal sealed class RoleDeleteCommandHandler(IRoleRepository roleRepository, IUnitOfWork unitOfWork) : IRequestHandler<RoleDeleteCommand, Result<string>>
{
    public async Task<Result<string>> Handle(RoleDeleteCommand request, CancellationToken cancellationToken)
    {
        var role = await roleRepository.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
        if (role is null) return Result<string>.Failure("Silineccek Rol bulunamadı.");

        role.Delete();
        roleRepository.Update(role);
        _ = await unitOfWork.SaveChangesAsync();

        return "Role Başarıyla Silindi.";
    }
}