using System;
using System.Collections.Generic;
using System.Text;

namespace TiviManagementApp.Data
{
    internal class DBConnection
    {
        private static readonly string connectionString =
        @"Server=localhost\SQLEXPRESS;
          Database=[NAME HERE];
          Trusted_Connection=True;
          TrustServerCertificate=True;";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
