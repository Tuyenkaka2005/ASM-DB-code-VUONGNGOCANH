using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASSIGNMENT1_VUONG_NGOC_ANH
{
    public partial class Order_and_Order_Detail : Form
    {
        string authorityLevel;
        int  userID;
        public Order_and_Order_Detail(string authority,int userID)
        {
            this.authorityLevel = authority;
            this.userID = userID;
            InitializeComponent();
           
        }

        private void LoadOrderHistory()
        {
            SqlConnection connection = DatabaseConnection.GetConnection();
            if (connection != null)
            {
                connection.Open();
                string query = "SELECT SALEE.SaleID," +
                    "EMPLOYEE.EmployeeName, " +
                    "CUSTOMER.CustomerName " +
                    "FROM SALEE " +
                    "INNER JOIN EMPLOYEE ON  SALEE.EmployeeID = EMPLOYEE.EmployeeID " +
                    "INNER JOIN CUSTOMER  ON CUSTOMER.CustomerID = SALEE.CustomerID " +
                    "WHERE EMPLOYEE.EmployeeID = @employeeID " +
                    "GROUP BY SALEE.SaleID, EMPLOYEE.EmployeeName, CUSTOMER.CustomerName";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("employeeID", this.userID );
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable datatable = new DataTable();
                adapter.Fill(datatable);
                dataGridViewOrder.DataSource = datatable;

            }
        }

            private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
            {
            LoadOrderHistory();
            }
        private void Order_and_Order_Detail_Load(object sender, EventArgs e)
        {
            LoadOrderHistory();
        }
        private void btnBackk_Click(object sender, EventArgs e)
        {
            RedirectPage();
        }
        private void RedirectPage()
        {
            switch (this.authorityLevel)
            {
                case "Admin":
                    {
                        Admin admin = new Admin(this.authorityLevel, this.userID);
                        this.Hide();
                        admin.Show();
                        break;
                    }
                case "Warehouse Manager":
                    {
                        Warehouse_Manager warehouse = new Warehouse_Manager(this.authorityLevel, this.userID);
                        this.Hide();
                        warehouse.Show();
                        break;
                    }
                case "Sale":
                    {
                        SALEFORM sale = new SALEFORM(this.userID, this.authorityLevel);
                        this.Hide();
                        sale.Show();
                        break;
                    }
                default:
                    {
                        break;
                    }
            }
            

        }
       
        }
    }


