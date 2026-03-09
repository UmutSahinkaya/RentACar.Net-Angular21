using FluentValidation;
using GenericRepository;
using RentCarServer.Domain.Branchs;
using RentCarServer.Domain.Branchs.ValueObjects;
using TS.MediatR;
using TS.Result;

namespace RentCarServer.Application.Branches;

public sealed record BranchUpdateCommand(Guid Id, string Name, Address Address, bool IsActive) : IRequest<Result<string>>;
public sealed class BranchUpdateCommandValidator : AbstractValidator<BranchUpdateCommand>
{
    public BranchUpdateCommandValidator()
    {
        _ = RuleFor(x => x.Name).NotEmpty().WithMessage("Geçerli bir şube adı giriniz.");
        _ = RuleFor(x => x.Address.City).NotEmpty().WithMessage("Geçerli bir şehir giriniz.");
        _ = RuleFor(x => x.Address.District).NotEmpty().WithMessage("Geçerli bir ilçe giriniz.");
        _ = RuleFor(x => x.Address.FullAdress).NotEmpty().WithMessage("Geçerli bir tam adress giriniz.");
        _ = RuleFor(x => x.Address.PhoneNumber1).NotEmpty().WithMessage("Geçerli bir telefon numarası giriniz.");
    }
}

internal sealed class BranchUpdateCommandHandler(IBranchRepository branchRepository, IUnitOfWork unitOfWork) : IRequestHandler<BranchUpdateCommand, Result<string>>
{
    public async Task<Result<string>> Handle(BranchUpdateCommand request, CancellationToken cancellationToken)
    {
        var branch = await branchRepository.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
        if (branch is null) return Result<string>.Failure("Şube bulunamadı.");

        branch.SetName(new(request.Name));
        branch.SetAdress(request.Address);
        branch.SetStatus(request.IsActive);

        _ = await unitOfWork.SaveChangesAsync(cancellationToken);
        return Result<string>.Succeed("Şube başarıyla güncellendi.");
    }
}