using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASSIGNMENT1_VUONG_NGOC_ANH
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            InitializeCombobox();
        }
        public void InitializeCombobox()
        {
            cbRole.Items.Add("Admin");
            cbRole.Items.Add("Warehouse Manager");
            cbRole.Items.Add("Sale");
            cbRole.SelectedIndex = 0;
        }
        private bool ValidateData(string username, string password, string role)
        {
            bool isValid = true;
            if (username == null || username == string.Empty)
            {
                MessageBox.Show(
                    "Username cannot be blank",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                isValid = false;
                txtUsername.Focus();
            }
            else if (password == null || password == string.Empty)
            {
                MessageBox.Show(
                    "Username cannot be blank",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                isValid = false;
                txtPassword.Focus();
            }
            else if (role == null || role == string.Empty)
            {
                MessageBox.Show
                    (
                    "Username cannot be blank",
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
                isValid = false;
                cbRole.Focus();
            }
            return isValid;
        }

        private void RedirectPage(string selectRole, int employeeId, bool isChangePassword)
        {
            if (isChangePassword)
            {
                if (selectRole == "Admin")
                {
                    Admin nyc = new Admin(selectRole, employeeId);
                    this.Hide();
                    nyc.Show();
                }
                else if (selectRole == "Warehouse Manager")
                {
                    Warehouse_Manager warehouseManagerForm = new Warehouse_Manager(selectRole, employeeId);
                    this.Hide();
                    warehouseManagerForm.Show();
                }
                else if (selectRole == "Sale")
                {
                    SALEFORM saleForm = new SALEFORM(employeeId, selectRole);
                    this.Hide();
                    saleForm.Show();
                }
            }
            else
            {
                Change_Password changePassword = new Change_Password(selectRole, employeeId);
                changePassword.Show();
                this.Hide();
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtUsername.Focus();
            cbRole.SelectedIndex = 0;
        }
        private void ClearData()
        {
            txtPassword.Text = string.Empty;
            txtUsername.Text = string.Empty;
            cbRole.SelectedIndex = 0;
            txtPassword.Focus();
        }
        
    
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string role = cbRole.SelectedItem.ToString();
            bool isValid = ValidateData(username,password,role);
            if (isValid)
            {
                SqlConnection connection = DatabaseConnection.GetConnection();
                if (connection != null)
                {
                    string query = "SELECT EmployeeID,PasswordChanged FROM Employee WHERE Username = @username " + "AND Password = @password AND AuthorityLevel = @role ";
                    connection.Open();
                    SqlCommand command = new SqlCommand(query,connection);
                    command.Parameters.AddWithValue("username", username);  
                    command.Parameters.AddWithValue("password", password);
                    command.Parameters.AddWithValue("role",role);
                    SqlDataReader reader = command.ExecuteReader();
                    int EmployeeID = 0;
                    bool PasswordChanged = false;
                    while (reader.Read())
                    {
                        EmployeeID = reader.GetInt32(reader.GetOrdinal("EmployeeID"));
                        PasswordChanged = reader.GetBoolean(reader.GetOrdinal("PasswordChanged"));
                    }
                    if (EmployeeID > 0)
                    {
                        MessageBox.Show(
                            "Login success",
                            "Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                        RedirectPage(role, EmployeeID, PasswordChanged);
                    }
                    else
                    {
                        MessageBox.Show(
                            "Invaild login credential",
                            "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error );
                        ClearData();
                    }
                    connection.Close();
                    
                }
            }

        }

        private void cbRole_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    }

