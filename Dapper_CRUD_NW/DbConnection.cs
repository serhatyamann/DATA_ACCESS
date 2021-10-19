using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dapper_CRUD_NW
{
    public static class DbConnection
    {
        public static string ConnectionString => ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
    }
}
