using FluentValidation;
using GenericRepository;
using RentCarServer.Domain.Roles;
using RentCarServer.Domain.Shared;
using TS.MediatR;
using TS.Result;

namespace RentCarServer.Application.Roles;

public sealed record RoleUpdateCommand(Guid Id, string Name, bool IsActive) : IRequest<Result<string>>;

public sealed class RoleUpdateCommandValidator : AbstractValidator<RoleUpdateCommand>
{
    public RoleUpdateCommandValidator()
    {
        _ = RuleFor(x => x.Name).NotEmpty().WithMessage("Role adı girmelisiniz");
    }
}
internal sealed class RoleUptadeCommandHandler(IRoleRepository roleRepository, IUnitOfWork unitOfWork) : IRequestHandler<RoleUpdateCommand, Result<string>>
{
    public async Task<Result<string>> Handle(RoleUpdateCommand request, CancellationToken cancellationToken)
    {
        var role = await roleRepository.FirstOrDefaultAsync(r => r.Id == request.Id, cancellationToken);
        if (role is null) return Result<string>.Failure("Böyle bir rol bulunmamakta");

        Name name = new(request.Name);
        role.SetName(name);
        role.SetStatus(request.IsActive);
        roleRepository.Update(role);
        _ = await unitOfWork.SaveChangesAsync();

        return "Rol başarıyla güncellendi.";

    }
}