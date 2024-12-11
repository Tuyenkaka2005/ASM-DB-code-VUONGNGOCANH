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
    public partial class Change_Password : Form
    {
        string role;
        int employeeID;

        public Change_Password(string selectRole, int employeeID)
        {
            this.role = selectRole;
            this.employeeID = employeeID;
            InitializeComponent();
        }
        private void ClearData()
        {
            txtConfirmPassword.Text = string.Empty;
            txtNewpassword.Text = string.Empty;
            txtNewpassword.Focus();
        }


        private void Change_Password_Load(object sender, EventArgs e)
        {

        }
        private void RedirectPage(int employeeID, string authorityLevel)
        {
            if (authorityLevel == "Admin ")
            {
                Admin adminForm = new Admin(authorityLevel, employeeID);
                this.Hide();
                adminForm.Show();
            }
            else if (authorityLevel == "Warehouse Manager")
            {
                Warehouse_Manager warehouseManagerForm = new Warehouse_Manager(authorityLevel, employeeID);
                this.Hide();
                warehouseManagerForm.Show();
            }
            else if (authorityLevel == "Sale")
            {
                SALEFORM saleForm = new SALEFORM(employeeID,authorityLevel);
                this.Hide();
                saleForm.Show();
            }
        }
        private void UpdateEmployee(int employeeID, string newPassword)
        {
            SqlConnection connection = DatabaseConnection.GetConnection();
            if (connection != null)
            {
                connection.Open();
                string sql = " UPDATE Employee SET Password = @newPassword ," +
                    "PasswordChange = 1 " + "WHERE EmployeeID = @employeeID ";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("newPassword ", newPassword);
                command.Parameters.AddWithValue("employeeID", employeeID);
                int isChange = command.ExecuteNonQuery();
                if (isChange > 0)
                {
                    MessageBox.Show(
                        "Successfully change password ",
                        "Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    RedirectPage(employeeID, role);
                }
                else
                {
                    MessageBox.Show(
                        "An error occur while chsnge password ",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                    ClearData();
                }
                connection.Close();
            }
        }
        private bool ValidateData(string newPassword, string confirmPassword)
        {
            bool isValid = true;
            if (string.IsNullOrEmpty(newPassword))
            {
                MessageBox.Show(
                    "New password cannot be blank ",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtNewpassword.Focus();
                return isValid;
            }
            else if (string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show (
                    "New and confirm passwords are not similar",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                ClearData();
                isValid = false;
            }
            return isValid;
        }

        private void btnClearr_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void btnChangee_Click(object sender, EventArgs e )
        {
            string newPassword = txtNewpassword.Text;
            string confirmPassword = txtConfirmPassword.Text;
            bool isValid = ValidateData(newPassword,confirmPassword);
            if (isValid)
            {
                UpdateEmployee(employeeID, newPassword);
            }
        }
    }
}



