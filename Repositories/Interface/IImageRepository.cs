using CodePlus.API.Models.Domain;
using System.Threading.Tasks;

namespace CodePlus.API.Repositories.Interface
{
    public interface IImageRepository
    {
        Task<BlogImage> Upload(IFormFile file, BlogImage blogImage);

        Task<IEnumerable<BlogImage>> GetAll();
    }
}
