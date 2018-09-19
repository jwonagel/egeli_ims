using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class ConnectionFactory
    {
        public static SqlConnection GetConnection()
        {
            var connectionString =
                "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Example;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

            return new SqlConnection(connectionString);
        }
    }
}
