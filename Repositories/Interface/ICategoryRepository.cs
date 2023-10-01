using CodePlus.API.Models.Domain;

namespace CodePlus.API.Repositories.Interface
{
    public interface ICategoryRepository
    {
        Task<Category> CreateAsync(Category category);
    }
}
