using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASSIGNMENT1_VUONG_NGOC_ANH
{
    public class DatabaseConnection
    {
        // Tạo kết nối giữa giao diện 
        private static string _connectionString = "Data Source=DESKTOP-17MK1UR;" +
                                                  "Initial Catalog=ASM1. VƯƠNG NGỌC ÁNH;" +
                                                  "Integrated Security=True;" +
                                                  "TrustServerCertificate=True";
        public static SqlConnection GetConnection()
        {
            // Khởi tạo biến SqlConnection
            SqlConnection connection = null;
            try
            {
                connection = new SqlConnection(_connectionString);
            }
            catch (SqlException ex)
            {
                MessageBox.Show(
                    "Error while connecting to the database",
                    "Warning ",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
            return connection;
        }
    }
}




            
