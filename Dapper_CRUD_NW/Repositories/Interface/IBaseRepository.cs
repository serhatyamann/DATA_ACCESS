using Dapper_CRUD_NW.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper_CRUD_NW.Entities.Interface
{
    public interface IBaseRepository<T>
    {
        IEnumerable<T> GetProducts();
        void Insert(T item);
        void Update(T item);
        void Delete(int productId);
    }
}
