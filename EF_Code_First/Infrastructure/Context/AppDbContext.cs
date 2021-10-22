using EF_Code_First.Model.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EF_Code_First.Infrastructure.Context
{
    public class AppDbContext:DbContext
    {
        public AppDbContext()
        {
            Database.Connection.ConnectionString = @"Server=.;Database=CodeFirstExample;Integrated Security=True"; //If there is not a database named "CodeFirstExample", it will be created.
        }

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }
    }
}
