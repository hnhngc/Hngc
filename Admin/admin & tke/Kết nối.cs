using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace admin___tke
{
    public class Kết_nối
    {
        private static SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder
        {
            DataSource = "awsse2004.cjm26kg663sc.ap-southeast-2.rds.amazonaws.com",
            InitialCatalog = "game_databaseA",
            UserID = "admin",
            Password = "LopSE2004", 
            TrustServerCertificate = true
        };
        public static SqlConnection getConnection()
        {
            return new SqlConnection(builder.ConnectionString);
        }
    }
}
