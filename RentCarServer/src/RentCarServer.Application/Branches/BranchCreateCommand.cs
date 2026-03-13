using FluentValidation;
using GenericRepository;
using RentCarServer.Domain.Branches;
using RentCarServer.Domain.Branchs.ValueObjects;
using TS.MediatR;
using TS.Result;

namespace RentCarServer.Application.Branches;

public sealed record BranchCreateCommand(string Name, Address Address, bool IsActive) : IRequest<Result<string>>;
public sealed class BranchCreateCommandValidator : AbstractValidator<BranchCreateCommand>
{
    public BranchCreateCommandValidator()
    {
        _ = RuleFor(x => x.Name).NotEmpty().WithMessage("Geçerli bir şube adı giriniz.");
        _ = RuleFor(x => x.Address.City).NotEmpty().WithMessage("Geçerli bir şehir giriniz.");
        _ = RuleFor(x => x.Address.District).NotEmpty().WithMessage("Geçerli bir ilçe giriniz.");
        _ = RuleFor(x => x.Address.FullAdress).NotEmpty().WithMessage("Geçerli bir tam adress giriniz.");
        _ = RuleFor(x => x.Address.PhoneNumber1).NotEmpty().WithMessage("Geçerli bir telefon numarası giriniz.");
    }
}

public sealed class BranchCreateCommandHandler(IBranchRepository branchRepository, IUnitOfWork unitOfWork) : IRequestHandler<BranchCreateCommand, Result<string>>
{
    public async Task<Result<string>> Handle(BranchCreateCommand request, CancellationToken cancellationToken)
    {
        var nameIsExist = await branchRepository.AnyAsync(x => x.Name.Value == request.Name, cancellationToken);
        if (nameIsExist) return Result<string>.Failure("Bu şube adı daha önce kullanılmış.");

        Name name = new(request.Name);
        Address address = request.Address;
        Branch branch = new(name, address, request.IsActive);
        await branchRepository.AddAsync(branch, cancellationToken);
        _ = await unitOfWork.SaveChangesAsync(cancellationToken);
        return "Şube başarıyla oluşturuldu.";
    }
}