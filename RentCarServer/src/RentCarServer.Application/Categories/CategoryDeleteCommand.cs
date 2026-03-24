using GenericRepository;
using RentCarServer.Application.Behaviors;
using RentCarServer.Domain.Categories;
using TS.MediatR;
using TS.Result;

namespace RentCarServer.Application.Categories;

[Permission("category:delete")]

public sealed record CategoryDeleteCommand(Guid Id) : IRequest<Result<string>>;

internal sealed class CategoryDeleteCommandHandler(ICategoryRepository categoryRepository, IUnitOfWork unitOfWork) : IRequestHandler<CategoryDeleteCommand, Result<string>>
{
    public async Task<Result<string>> Handle(CategoryDeleteCommand request, CancellationToken cancellationToken)
    {
        var category = await categoryRepository.FirstOrDefaultAsync(x => x.Id == request.Id, cancellationToken);
        if (category is null) return Result<string>.Failure("Silinecek kategori bulunamadı.");

        category.Delete();
        categoryRepository.Update(category);
        _ = await unitOfWork.SaveChangesAsync();

        return "Kategori başarıyla silindi.";
    }
}
