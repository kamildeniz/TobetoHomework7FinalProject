using Core.DataAccess;
using Entities.Concrete;

namespace DataAccess.Abstracts
{
    public interface IOrderDal : IEntityRepository<Order>
    {
    }
}
