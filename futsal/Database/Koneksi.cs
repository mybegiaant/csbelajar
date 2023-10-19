using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace futsal.Database
{
    
    class Koneksi
    {
        public SqlConnection Connection()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"data source= DESKTOP-EM321DP; initial catalog = futsal; integrated security = true;";
            return conn;


        }

    }
}
