using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBClass
{
    class NorthwindDB
    {
        public static SqlConnection GetConnection()
        {
            string connectionString = @"Data Source=localhost\Sqlexpress;Initial Catalog=Northwind;Integrated Security=True";
            return new SqlConnection(connectionString);
        }
    }
}
