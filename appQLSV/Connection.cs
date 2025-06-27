using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appQLSV
{
    internal class Connection
    {
        public static string connectionString = @"Data Source=DESKTOP-75SKCA4;Initial Catalog=QLSinhVien;Integrated Security=True";
        public static SqlConnection getSqlConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
