using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ASSIGNMENT1_VUONG_NGOC_ANH
{
    public partial class Customer_Management : Form
    {
        int CustomerID;
        string authorityLevel;
       

        public Customer_Management(int customerID, string authorityLevel)
        {
            this.CustomerID = customerID;
            this.authorityLevel = authorityLevel;
            InitializeComponent();
        }

        private bool ValidateData(string customerName, string customerPhoneNumber, string customerEmail, string customerAddress)
        {
            if (string.IsNullOrEmpty(customerName))
            {
                MessageBox.Show("Customer Name cannot be blank", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtnamecustomer.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(customerPhoneNumber))
            {
                MessageBox.Show("Customer Phone number cannot be blank", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtphonenumber.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(customerEmail))
            {
                MessageBox.Show("Customer Email cannot be blank", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtemailcustomer.Focus();
                return false;
            }
            else if (string.IsNullOrEmpty(customerAddress))
            {
                MessageBox.Show("Customer Address cannot be blank", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtaddress.Focus();
                return false;
            }
            return true;
        }

        private void Customer_Management_Load(object sender, EventArgs e)
        {
            LoadCUSTOMER();
            ChangeButtonStatus(false);
        }

        private void ChangeButtonStatus(bool buttonStatus)
        {
            btnUpdate.Enabled = buttonStatus;
            btnadd.Enabled = !buttonStatus;
            btnDelete.Enabled = buttonStatus;
            btnclearrr.Enabled = buttonStatus;
        }

        private void LoadCUSTOMER()
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                if (connection != null)
                {
                    try
                    {
                        connection.Open();
                        string sql = "SELECT * FROM CUSTOMER";
                        SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dtgCustomer.DataSource = dataTable;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error loading customer data: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Failed to connect to the database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        private void ClearData()
        {
            FlushCustomer();
            txtnamecustomer.Text = string.Empty;
            txtphonenumber.Text = string.Empty;
            txtemailcustomer.Text = string.Empty;
            txtaddress.Text = string.Empty;
        }
        private void FlushCustomer()
        {
            this.CustomerID = 0;
            ChangeButtonStatus(true);
        }

        private void btnclearrr_Click(object sender, EventArgs e)
        {
            FlushCustomer();
            txtnamecustomer.Text = string.Empty;
            txtphonenumber.Text = string.Empty;
            txtemailcustomer.Text = string.Empty;
            txtaddress.Text = string.Empty;
        }
        private bool CheckUserExistence(int employeeID)
        {
            bool isExist = false;
            SqlConnection connection = DatabaseConnection.GetConnection();
            if (connection != null)
            {
                connection.Open();
                string checkCustomerQuery = "SELECT * FROM CUSTOMER WHERE CustomerID = @customerID";
                SqlCommand command = new SqlCommand(checkCustomerQuery, connection);
                command.Parameters.AddWithValue("CustomerID", employeeID);
                SqlDataReader reader = command.ExecuteReader();
                isExist = reader.HasRows;
                connection.Close();
            }
            return isExist;
        }
        private void AddCustomer(string customerName,
                         string customerPhoneNumber,
                         string customerEmail,
                         string customerAddress)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                if (connection != null)
                {
                    try
                    {
                        connection.Open();
                        string sql = "INSERT INTO CUSTOMER (CustomerName, CustomerPhoneNumber, CustomerEmail, CustomerAddress) " +
                                     "VALUES (@CustomerName, @CustomerPhoneNumber, @CustomerEmail, @CustomerAddress)";
                        SqlCommand command = new SqlCommand(sql, connection);

                        // Add parameters for the customer
                        command.Parameters.AddWithValue("@CustomerName", customerName);
                        command.Parameters.AddWithValue("@CustomerPhoneNumber", customerPhoneNumber);
                        command.Parameters.AddWithValue("@CustomerEmail", customerEmail);
                        command.Parameters.AddWithValue("@CustomerAddress", customerAddress);

                        // Execute the command and check if it was successful
                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Successfully added new customer.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearData();  // Optional: Clears the data fields after successful insert.
                            LoadCUSTOMER();  // Refresh the customer list after adding.
                        }
                        else
                        {
                            MessageBox.Show("Cannot add new customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error adding customer: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Failed to connect to the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
        private void UpdateCustomer(string customerName, string customerPhoneNumber, string customerEmail, string customerAddress)
        {
            using (SqlConnection connection = DatabaseConnection.GetConnection())
            {
                if (connection != null)
                {
                    try
                    {
                        connection.Open();
                        string sql = "UPDATE CUSTOMER SET " +
                                     "CustomerName = @customerName, " +
                                     "CustomerPhoneNumber = @customerPhoneNumber, " +
                                     "CustomerEmail = @customerEmail, " +
                                     "CustomerAddress = @customerAddress " +
                                     "WHERE CustomerID = @customerID";

                        SqlCommand command = new SqlCommand(sql, connection);

                        // Add parameters for the customer
                        command.Parameters.AddWithValue("@customerName", customerName);
                        command.Parameters.AddWithValue("@customerPhoneNumber", customerPhoneNumber);
                        command.Parameters.AddWithValue("@customerEmail", customerEmail);
                        command.Parameters.AddWithValue("@customerAddress", customerAddress);
                        command.Parameters.AddWithValue("@customerID", this.CustomerID);  // Assuming CustomerID is set somewhere in the form.

                        // Execute the command and check if the update was successful
                        int result = command.ExecuteNonQuery();
                        if (result > 0)
                        {
                            MessageBox.Show("Successfully updated customer.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ClearData();  // Optional: Clears the data fields after successful update.
                            LoadCUSTOMER();  // Refresh the customer list after updating.
                        }
                        else
                        {
                            MessageBox.Show("Cannot update customer.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error updating customer: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connection.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Failed to connect to the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void DeleteCustomer(int CustomerID)
        {
            SqlConnection connection = DatabaseConnection.GetConnection();
            if (connection != null)
            {
                connection.Open();
                string sql = "DELETE FROM CUSTOMER WHERE CustomerID = @customerID";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@customerID", CustomerID);

                int result = command.ExecuteNonQuery();
                if (result > 0)
                {
                    MessageBox.Show(
                        "Successfully deleted customer.",
                        "Information",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    ClearData();
                    LoadCUSTOMER();  // Refresh the customer list after deleting
                }
                else
                {
                    MessageBox.Show(
                        "Cannot delete customer.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                connection.Close();
            }
            else
            {
                MessageBox.Show("Failed to connect to the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void SearchCustomer(string search)
        {
            if (string.IsNullOrEmpty(search))
            {
                LoadCUSTOMER();  // Load all customers if no search term is provided
            }
            else
            {
                SqlConnection connection = DatabaseConnection.GetConnection();
                if (connection != null)
                {
                    connection.Open();
                    string query = "SELECT * FROM CUSTOMER WHERE CustomerName LIKE @search " +
                                   "OR CustomerPhoneNumber LIKE @search " +
                                   "OR CustomerEmail LIKE @search " +
                                   "OR CustomerAddress LIKE @search";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("@search", "%" + search + "%");
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dtgCustomer.DataSource = table;
                    connection.Close();
                }
                else
                {
                    MessageBox.Show("Failed to connect to the database.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Do you want to delete this user",
                "Warning",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                DeleteCustomer(CustomerID);
            }
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            {
                // Retrieve customer data from input controls
                string CustomerName = txtnamecustomer.Text;
                string CustomerPhoneNumber = txtphonenumber.Text;
                string CustomerEmail = txtemailcustomer.Text;
                string CustomerAddress = txtaddress.Text;

                // Validate the data before adding
                bool isValid = ValidateData(CustomerName, CustomerPhoneNumber, CustomerEmail, CustomerAddress);

                if (isValid)
                {
                    // Add the customer to the database
                    AddCustomer(CustomerName, CustomerPhoneNumber, CustomerEmail, CustomerAddress);
                }

                // Event handler for adding a new customer
                this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Retrieve customer data from input controls
            string CustomerName = txtnamecustomer.Text;
            string CustomerPhoneNumber = txtphonenumber.Text;
            string CustomerEmail = txtemailcustomer.Text;
            string CustomerAddress = txtaddress.Text;

            // Validate customer data
            bool isValid = ValidateData(CustomerName, CustomerPhoneNumber, CustomerEmail, CustomerAddress);

            // If data is valid, proceed to update customer details
            if (isValid)
            {
                UpdateCustomer(CustomerName, CustomerPhoneNumber, CustomerEmail, CustomerAddress);
            }

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            RedirectPage();
            
        }
        private void RedirectPage()
        {
            switch (authorityLevel)
            {
                case "Admin":
                    {
                        Admin admin = new Admin(this.authorityLevel, this.CustomerID);
                        this.Hide();
                        admin.Show();
                        break;
                    }
                case "Warehouse Manager":
                    {
                        Warehouse_Manager warehouse = new Warehouse_Manager(this.authorityLevel, this.CustomerID);
                        this.Hide();
                        warehouse.Show();
                        break;
                    }
                case "Sale":
                    {
                        SALEFORM sale = new SALEFORM(this.CustomerID, this.authorityLevel);
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
        private void dtgCustomer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            {
                int index = dtgCustomer.CurrentCell.RowIndex;
                if (index != -1)
                {
                    // Get the customer ID from the DataGridView row
                    CustomerID = Convert.ToInt32(dtgCustomer.Rows[index].Cells[0].Value);

                    // Enable buttons related to editing/deleting customer
                    ChangeButtonStatus(true);

                    // Populate the textboxes and other controls with the selected customer data
                    txtnamecustomer.Text = dtgCustomer.Rows[index].Cells[1].Value.ToString(); // CustomerName
                    txtphonenumber.Text = dtgCustomer.Rows[index].Cells[2].Value.ToString();  // CustomerPhoneNumber
                    txtemailcustomer.Text = dtgCustomer.Rows[index].Cells[3].Value.ToString(); // CustomerEmail
                    txtaddress.Text = dtgCustomer.Rows[index].Cells[4].Value.ToString(); // CustomerAddress
                }
            }
    }
       
        
    }
}
