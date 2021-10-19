using Dapper_CRUD_NW.Entities.Concrete;
using Dapper_CRUD_NW.Entities.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Dapper_CRUD_NW.Repositories.Concrete
{
    public class ProductRepository : IBaseRepository<Product>
    {
        public void Delete(int productId)
        {
            using (IDbConnection db = new SqlConnection(DbConnection.ConnectionString))
            {
                //We never should do the exact "deletion process" from our Database.
                //So I updated this Product's Discontinued field as true.
                //It will not be listed in datagridview anymore because I'm listing the active ones with my GetProducts() method.
                db.Open();
                db.Execute("update Products set  Discontinued = 1 where ProductID=@productID", new { productID = productId });
                db.Close();
            }
        }

        public IEnumerable<Product> GetProducts()
        {
            using (IDbConnection db = new SqlConnection(DbConnection.ConnectionString))
            {
                db.Open();
                var list = db.Query<Product>("select ProductID, ProductName, UnitPrice from Products where Discontinued = 0", commandType: CommandType.Text);
                db.Close();
                return list;
            }
        }

        public void Insert(Product item)
        {
            using (IDbConnection db = new SqlConnection(DbConnection.ConnectionString))
            {
                db.Open();
                db.Execute("insert into Products (ProductName, UnitPrice) values (@ProductName, @UnitPrice)", new { ProductName = item.ProductName, UnitPrice = item.UnitPrice });
                db.Close();
            }
        }

        public void Update(Product item)
        {
            using (IDbConnection db = new SqlConnection(DbConnection.ConnectionString))
            {
                db.Open();
                db.Execute("update Products set ProductName = @productName, UnitPrice = @unitPrice where ProductID=@productID", new { productName = item.ProductName, unitPrice = item.UnitPrice, productID = item.ProductID });
                db.Close();
            }
        }
    }
}
