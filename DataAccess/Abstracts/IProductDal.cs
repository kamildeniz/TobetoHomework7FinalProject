using Core.DataAccess;
using Entities.Concrete;
using Entities.DTOs;

namespace DataAccess.Abstracts
{
    public interface IProductDal : IEntityRepository<Product>
    {
        List<ProductDetailDTO> GetProductDetails();
    }
}
