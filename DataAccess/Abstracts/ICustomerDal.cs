using Core.DataAccess;
using Entities.Concrete;

namespace DataAccess.Abstracts
{
    public interface ICustomerDal : IEntityRepository<Customer>
    {
    }
}
