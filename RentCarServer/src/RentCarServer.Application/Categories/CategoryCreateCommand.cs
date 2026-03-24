using FluentValidation;
using GenericRepository;
using RentCarServer.Application.Behaviors;
using RentCarServer.Domain.Categories;
using RentCarServer.Domain.Shared;
using TS.MediatR;
using TS.Result;

namespace RentCarServer.Application.Categories;

[Permission("category:create")]

public sealed record CategoryCreateCommand(string Name, bool isActive) : IRequest<Result<string>>;

public sealed class CategoryCreateCommandValidator : AbstractValidator<CategoryCreateCommand>
{
    public CategoryCreateCommandValidator()
    {
        _ = RuleFor(x => x.Name).NotEmpty().WithMessage("Kategori adı girmelisiniz");
    }
}
internal sealed class CategoryCreateCommandHandler(ICategoryRepository categoryRepository, IUnitOfWork unitOfWork) : IRequestHandler<CategoryCreateCommand, Result<string>>
{
    public async Task<Result<string>> Handle(CategoryCreateCommand request, CancellationToken cancellationToken)
    {
        var nameExists = await categoryRepository.AnyAsync(x => x.Name.Value == request.Name, cancellationToken);
        if (nameExists) return Result<string>.Failure("Bu kategori adı daha önce kullanılmış");

        Name name = new(request.Name);
        Category category = new(name, request.isActive);
        await categoryRepository.AddAsync(category, cancellationToken);
        _ = await unitOfWork.SaveChangesAsync();

        return "Kategori başarıyla oluşturuldu.";
    }
}
