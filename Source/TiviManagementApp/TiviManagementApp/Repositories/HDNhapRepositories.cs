using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using TiviManagementApp.Data;

namespace TiviManagementApp.Repositories
{
    internal class HDNhapRepositories
    {
        public int GetTotalHDNs()
        {
            string sql = "SELECT COUNT(SoHDN) FROM HoaDonNhap;";

            using (SqlConnection conn = DBConnection.GetConnection())
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(sql, conn))
                {
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }
    }
}
