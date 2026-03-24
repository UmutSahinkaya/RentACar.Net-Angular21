using FluentValidation;
using GenericRepository;
using RentCarServer.Application.Behaviors;
using RentCarServer.Domain.Categories;
using RentCarServer.Domain.Shared;
using TS.MediatR;
using TS.Result;

namespace RentCarServer.Application.Categories;

[Permission("category:edit")]

public sealed record CategoryUpdateCommand(Guid Id, string Name, bool IsActive) : IRequest<Result<string>>;

public sealed class CategoryUpdateCommandValidator : AbstractValidator<CategoryUpdateCommand>
{
    public CategoryUpdateCommandValidator()
    {
        _ = RuleFor(x => x.Name).NotEmpty().WithMessage("Kategori adı girmelisiniz");
    }
}
internal sealed class CategoryUpdateCommandHandler(ICategoryRepository categoryRepository, IUnitOfWork unitOfWork) : IRequestHandler<CategoryUpdateCommand, Result<string>>
{
    public async Task<Result<string>> Handle(CategoryUpdateCommand request, CancellationToken cancellationToken)
    {
        var category = await categoryRepository.FirstOrDefaultAsync(r => r.Id == request.Id, cancellationToken);
        if (category is null) return Result<string>.Failure("Böyle bir kategori bulunmamakta");

        if (category.Name.Value != request.Name)
        {
            var nameExists = await categoryRepository.AnyAsync(x => x.Name.Value == request.Name, cancellationToken);
            if (nameExists) return Result<string>.Failure("Bu kategori adı daha önce kullanılmış");
        }

        Name name = new(request.Name);
        category.SetName(name);
        category.SetStatus(request.IsActive);
        categoryRepository.Update(category);
        _ = await unitOfWork.SaveChangesAsync();

        return "Kategori başarıyla güncellendi.";

    }
}
