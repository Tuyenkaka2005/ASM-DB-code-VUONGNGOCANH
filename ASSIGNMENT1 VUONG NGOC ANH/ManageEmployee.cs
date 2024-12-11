using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IdentityModel.Claims;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;

namespace ASSIGNMENT1_VUONG_NGOC_ANH
{
    public partial class ManageEmployee : Form
    {
        int employeeID;
        string employeePosision;
        int userId;
        public ManageEmployee( int employeeID,string employeePosision )
        {
            InitializeComponent();
            this.userId = 0;
            this.employeeID = employeeID;
            this.employeePosision = employeePosision;
            dtgEmployee.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }
        private void ManageEmployee_Load(object sender, EventArgs e)
        {
            LoadEmployeeData();
            ChangeButtonStatus(false);
            InitializeCombobox();
            Combobox();
        }
        private bool ValidateData(string employeeName,
                                  string employeeCode,
                                  string EmployeeEmial,
                                  string employeePosision,
                                  string employeeAuthorityLevel,
                                  string Username,
                                  string Password)
        {
            bool isValid = true;
            if (employeeCode == null || employeeCode == string.Empty)
            {
                MessageBox.Show(
                    "Employee Code cannot be blank",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtEmployeeCode.Focus();
                return false;
            }
            else if (employeeName == null || employeeName == string.Empty)
            {
                MessageBox.Show(
                   "Employee Name cannot be blank ",
                   "Error.",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Error);
                txtFullName.Focus();
                isValid = false;

            }
            else if (employeePosision == null || employeePosision == string.Empty)
            {
                MessageBox.Show(
                "Employee posision cannot be blank",
                "Error",
                 MessageBoxButtons.OK,
                 MessageBoxIcon.Error);
                cbAuthorityLevel.Focus();
                isValid = false;

            }
            else if (employeeAuthorityLevel == null || employeeAuthorityLevel == string.Empty)
            {
                MessageBox.Show(
                "employee code cannot be blank",
                "error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                cbAuthorityLevel.Focus();
                isValid = false;
            }
            else if (Username == null || Username == string.Empty)
            {
                MessageBox.Show(
                "User name cannot be blank ",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                txtusername.Focus();
                isValid = false;
            }
            else if (Password == null || Password == string.Empty)
            {
                MessageBox.Show(
                "Password cannot be blank",
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error);
                txtpassword.Focus();
                isValid = false;
            }
            return isValid;
        }
        private void ChangeButtonStatus(bool buttonStatus)
        {
            btnupdate.Enabled = buttonStatus;
            btnadd.Enabled = !buttonStatus;
            btndelete.Enabled = buttonStatus;
            btnclearrr.Enabled = buttonStatus;
        }
        private void FlushEmployee() {
            this.employeeID = 0;
            ChangeButtonStatus(true);
        }
        private void FlushEmployeeID()
        {
            this.userId = 0;
            ChangeButtonStatus(false);

        }
        private void LoadEmployeeData()
        {
            SqlConnection connection = DatabaseConnection.GetConnection();
            if (connection != null)
            {
                connection.Open();
                string sql = "SELECT * FROM EMPLOYEE";
                SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dtgEmployee.DataSource = dataTable;
                connection.Close();
            }
        }
        private void ClearData()
        {
            FlushEmployeeID();
            txtEmployeeCode.Text = string.Empty;
            txtFullName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            cbPosision.SelectedIndex = 0;
            cbAuthorityLevel.SelectedIndex = 0;
            txtusername.Text = string.Empty;
            txtpassword.Text = string.Empty;
            txtEmployeeCode.Focus();
        }
        private void InitializeCombobox()
        {
            cbAuthorityLevel.Items.Add("Admin");
            cbAuthorityLevel.Items.Add("Warehouse");
            cbAuthorityLevel.Items.Add("Sale");
            cbAuthorityLevel.SelectedIndex = 0;
        }
        private void Combobox()
        {
            cbPosision.Items.Add("Staff");
            cbPosision.Items.Add("Manager");
            cbPosision.SelectedIndex = 0;
        }
        private bool CheckUserExistence(int employeeID)
        {
            bool isExist = false;
            SqlConnection connection = DatabaseConnection.GetConnection();
            if (connection != null)
            {
                connection.Open();
                string checkCustomerQuery = "SELECT * FROM EMPLOYEE WHERE EmployeeID = @employeeID";
                SqlCommand command = new SqlCommand(checkCustomerQuery, connection);
                command.Parameters.AddWithValue("EmployeeID", employeeID);
                SqlDataReader reader = command.ExecuteReader();
                isExist = reader.HasRows;
                connection.Close();
            }
                return isExist;
        }
        private void AddUser(string EmployeeCode ,
                             string EmployeeName,
                             string EmployeeEmail,
                             string EmployeePosition,
                             string AuthorityLevel,
                             string Username,
                             string Password)
                        
        {
            SqlConnection connection = DatabaseConnection.GetConnection();
            if (connection != null)
            {
                try
                {
                    connection.Open();
                    string sql = "INSERT INTO EMPLOYEE (EmployeeCode, EmployeeName, EmployeeEmail, EmployeePosition, AuthorityLevel, Username, Password) " +
                                 "VALUES (@EmployeeCode, @EmployeeName, @EmployeeEmail, @EmployeePosition, @AuthorityLevel, @Username, @Password)";
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@EmployeeCode", EmployeeCode);
                    command.Parameters.AddWithValue("@EmployeeName", EmployeeName);
                    command.Parameters.AddWithValue("@EmployeeEmail", EmployeeEmail);
                    command.Parameters.AddWithValue("@EmployeePosition", EmployeePosition);
                    command.Parameters.AddWithValue("@AuthorityLevel", AuthorityLevel);
                    command.Parameters.AddWithValue("@Username", Username);
                    command.Parameters.AddWithValue("@Password", Password);
                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Successfully added new user", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearData();
                        LoadEmployeeData();
                    }
                    else
                    {
                        MessageBox.Show("Cannot add new user", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    connection.Close();
                }
            }
            else
            {
                MessageBox.Show("Database connection failed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void UpdateUser(
                             string EmployeeCode,
                             string EmployeeName,
                             string EmployeeEmail,
                             string EmployeePosition,
                             string AuthorityLevel,
                             string Username,
                             string Password)
        {
            SqlConnection connection = DatabaseConnection.GetConnection();
            if (connection != null) { 
                connection.Open();
                string sql = "UPDATE EMPLOYEE SET " +
            "EmployeeCode = @employeeCode, " +
            "EmployeeName = @employeeName, " +
            "EmployeeEmail = @employeeEmail, " +
            "EmployeePosition = @employeePosition, " +
            "AuthorityLevel = @authorityLevel, " +
            "Username = @username, " +
            "Password = @password " +
            "WHERE EmployeeID = @employeeID";
                SqlCommand command = new SqlCommand(sql, connection);

                command.Parameters.AddWithValue("@employeeCode", EmployeeCode);
                command.Parameters.AddWithValue("@employeeName", EmployeeName);
                command.Parameters.AddWithValue("@employeeEmail", EmployeeEmail);
                command.Parameters.AddWithValue("@employeePosition", EmployeePosition);
                command.Parameters.AddWithValue("@authorityLevel", AuthorityLevel);
                command.Parameters.AddWithValue("@username", Username);
                command.Parameters.AddWithValue("@password", Password);
                command.Parameters.AddWithValue("@employeeID", this.employeeID);

                //  command.Parameters.AddWithValue("employeeID", EmployeeID);
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show(
                        "Successfully update user",
                        "Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    ClearData();
                    LoadEmployeeData();
                }
                else { 
                    MessageBox.Show(
                        "Cannot update user",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                connection.Close();
            }

        }
        private void DeleteUser(int EmployeeID)
        {
            SqlConnection connection = DatabaseConnection.GetConnection();
            if (connection != null)
            {
                connection.Open();
                string sql = "DELETE Employee WHERE EmployeeID = @employeeID";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("employeeID", EmployeeID);
                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show(
                        "Successfully delete user",
                        "Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    ClearData();
                    LoadEmployeeData();
                }
                else
                {
                    MessageBox.Show(
                        "Cannot delete user",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                connection.Close ();
            }
        }
        private void SearchUser(string search)
        {
            if (string.IsNullOrEmpty(search))
            {
                LoadEmployeeData();
            }
            else
            {
                SqlConnection connection = DatabaseConnection.GetConnection();
                if (connection != null)
                {
                    connection.Open();
                    string query = "SELECT * FROM Employee WHERE EmployeeCode Like @search  " +
                        "OR EmployeeName LIKE @search" +
                        "OR EmployeeEmail LIKE @search "+
                        "OR Posision LIKE @search " +
                        "OR AuthorityLevel LIKE @search " +
                        "OR Username LIKE @search " +
                        "OR Password LIKE @search ";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection); 
                    adapter.SelectCommand.Parameters.AddWithValue("search","%"+ search + "%");
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dtgEmployee.DataSource = table;
                    connection.Close();
                }

            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Do you want to delete this user",
                "Warning",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DeleteUser(employeeID);
            }
        }
        
        private void btnadd_Click(object sender, EventArgs e)
        {
            string EmployeeCode = txtEmployeeCode.Text;
            string EmployeeName = txtFullName.Text;
            string EmployeeEmail = txtEmail.Text;
            string EmployeePosision = cbPosision.SelectedItem.ToString();
            string AuthorityLevel = cbAuthorityLevel.SelectedItem.ToString();
            string Username = txtusername.Text;
            string Password = txtpassword.Text;
            bool isValid = ValidateData(EmployeeCode,
                                        EmployeeName, 
                                        EmployeeEmail,
                                        EmployeePosision,
                                        AuthorityLevel,
                                        Username,
                                        Password);
            if (isValid) 
            { 
                AddUser(EmployeeCode, EmployeeName,EmployeeEmail, EmployeePosision,AuthorityLevel,Username,Password);
            }
            
            
        }

        private void btnupdate_Click(object sender, EventArgs e)
        {
            string EmployeeCode = txtEmployeeCode.Text;
            string EmployeeName = txtFullName.Text;
            string EmployeeEmail = txtEmail.Text;
            string EmployeePosision = cbPosision.SelectedItem.ToString() ;
            string AuthorityLevel = cbAuthorityLevel.SelectedItem.ToString().ToLower();
            string Username = txtusername.Text;
            string Password = txtpassword.Text;
            bool isVaid = ValidateData(
                                       EmployeeCode,
                                       EmployeeName,
                                       EmployeeEmail,
                                       EmployeePosision,
                                       AuthorityLevel,
                                       Username,
                                       Password);
            if (isVaid)
            { 
                UpdateUser( EmployeeCode, EmployeeName,EmployeeEmail, EmployeePosision, AuthorityLevel, Username, Password);
            }
        }

        private void btnBackk_Click(object sender, EventArgs e)
        {
            switch (employeePosision)
            {
                case "Admin":
                {
                        Admin admin = new Admin(employeePosision,employeeID );  
                        this.Hide();
                        admin.Show();
                        break;
                   }
                case "Warehouse Manager":
                   {
                        Warehouse_Manager warehouse = new Warehouse_Manager(employeePosision, employeeID);
                        this.Hide();
                        warehouse.Show();
                        break;
                    }
                case "Sale":
                    {
                        SALEFORM sale = new SALEFORM(employeeID, employeePosision);
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

        private void btnclearrr_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            SearchUser( search );
        }

        private void dtgEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dtgEmployee.CurrentCell.RowIndex;
            if (index != -1)
            {
                employeeID = Convert.ToInt32(dtgEmployee.Rows[index].Cells[0].Value);

                ChangeButtonStatus(true);
                txtEmployeeCode.Text = dtgEmployee.Rows[index].Cells[1].Value.ToString();
                txtFullName.Text = dtgEmployee.Rows[index ].Cells[2].Value.ToString();
                txtEmail.Text = dtgEmployee.Rows[index].Cells[3].Value.ToString();
                
                string authorityLevel = dtgEmployee.Rows[index].Cells[5].Value.ToString();
                if (authorityLevel == "Admin")
                {
                    cbAuthorityLevel.SelectedIndex = 0; 
                }
                else if (authorityLevel == "Warehouse")
                {
                    cbAuthorityLevel.SelectedIndex = 1;
                }
                else if (authorityLevel =="Sale")
                {
                    cbAuthorityLevel.SelectedIndex = 2;
                }
                txtusername.Text = dtgEmployee.Rows[index].Cells[6].Value.ToString();   
                txtpassword.Text = dtgEmployee.Rows[index].Cells[7].Value.ToString();
                cbPosision.Text = dtgEmployee.Rows[index].Cells[4].Value.ToString();

            }
        }
        private void cbPosision_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cbPosision.Items.Add("Manager");
            //cbPosision.Items.Add("Staff");
            //cbPosision.SelectedIndex = 0;
        }

        private void cbAuthorityLevel_SelectedIndexChanged(object sender, EventArgs e)
        {
            //cbAuthorityLevel.Items.Add("Admin");
            //cbAuthorityLevel.Items.Add("Sale");
            //cbAuthorityLevel.Items.Add("Warehouse");
            //cbAuthorityLevel.SelectedIndex = 0;
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            string search = txtSearch.Text;
            SearchUser(search);
        }
    }
}
