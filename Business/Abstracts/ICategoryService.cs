using Entities.Concrete;

namespace Business.Abstracts
{
    public interface ICategoryService
    {
        List<Category> GetAll();
        Category GetById(int categoryId);
    }
}
