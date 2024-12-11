using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ASSIGNMENT1_VUONG_NGOC_ANH
{
    public partial class PRODUCTMANAGE : Form
    {
        private int productID;
        private string authorityLevel;
        private int userID;
        int employeeId;

        public PRODUCTMANAGE(string authorityLevel, int employeeId)
        {
            
            this.authorityLevel = authorityLevel;
            this.userID = userID;
            productID = 0;
            InitializeComponent();
        
        }

        private void PRODUCTMANAGE_Load(object sender, EventArgs e)
        {
            LoadCategoryCombobox();
            LoadProductData();
           
        }
        
        private void btnupdate_Click(object sender, EventArgs e)
        {
            UpdateProduct();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteProduct();
        }

        private void btnadd_Click(object sender, EventArgs e)
        {
            AddProduct();
        }
        private void LoadCategoryCombobox()
        {
            SqlConnection connection = DatabaseConnection.GetConnection();
            if (connection != null)
            {
                connection.Open();
                string query = "SELECT CategoryID, CategoryName FROM Category";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                cbCategory.DataSource = dataTable;
                cbCategory.DisplayMember = "CategoryName";
                cbCategory.ValueMember = "CategoryID";
                connection.Close();
            }
        }

        private bool ValidateData(string productCode, string productName, string productPrice, string productQuantity, string perfumeImg)
        {
            double temp;
            int temp2;
            if (string.IsNullOrEmpty(productName)) { return false; }
            if (string.IsNullOrEmpty(productPrice)) { return false; }
            if (!double.TryParse(productPrice, out temp)) { return false; }
           if (string.IsNullOrEmpty(productQuantity)) { return false; }
           if (string.IsNullOrEmpty(perfumeImg)) { return false; }

            return int.TryParse(productQuantity, out temp2);
        }

        private void UploadFile(string filter, string path)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = filter;
            openFileDialog.Title = "SELECT a file to upload ";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string sourceFilePath = openFileDialog.FileName;

                // Use the provided 'path' instead of the default path
                string targetDirectory = path;

                // Create the directory if it doesn't exist
                if (!Directory.Exists(targetDirectory))
                {
                    Directory.CreateDirectory(targetDirectory);
                }

                // Correct the target file path
                string targetFilePath = Path.Combine(targetDirectory, Path.GetFileName(sourceFilePath));

                try
                {
                    // Copy the file to the target directory
                    File.Copy(sourceFilePath, targetFilePath, overwrite: true);

                    // Update the text box with the file path
                   // txtProductImg.Text = targetFilePath;
                    MessageBox.Show("File uploaded successfully!", "Success", MessageBoxButtons.OK);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error uploading file: " + ex.Message, "Error", MessageBoxButtons.OK);
                }
            }
        }


        private void LoadProductData()
        {
            SqlConnection connection = DatabaseConnection.GetConnection();
            if (connection != null)
            {
                connection.Open();
                string query = "SELECT * FROM PERFUME LEFT JOIN Category ON PERFUME.CategoryID = Category.CategoryID ";
                SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                DataTable dataTable = new DataTable();
                adapter.Fill(dataTable);
                dtgProductt.DataSource = dataTable;
                connection.Close();
            }
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            ClearData();
        }

        private void ClearData()
        {
          
            txtproductcodee.Text = string.Empty;
            txtproductNamee.Text = string.Empty;
          //  txtProductImg.Text = string.Empty;
            txtproductpricee.Text = string.Empty;
            txtProductQuantityy.Text = string.Empty;
            txtSearch.Text = string.Empty;
        }
        private void AddProduct()
        {
            SqlConnection connection = DatabaseConnection.GetConnection();
            if (connection != null)
            {
                connection.Open();
                string productCode = txtproductcodee.Text;
                string productName = txtproductNamee.Text;
                string perfumeImg = "UPDATING";

                //  string productimg = txtproductimg.text;
                string price = txtproductpricee.Text;
                string quantity = txtProductQuantityy.Text;
                int  CategoryID = Int32.Parse( cbCategory.SelectedValue.ToString());

                if (ValidateData(productCode, productName, price, quantity,perfumeImg))
                {

                    string sql = "INSERT INTO PERFUME (PerfumeCode, PerfumeName, PerfumePrice,  PerfumeImage,CategoryID,ProductQuantity) " +
                        "VALUES (@perfumeCode, @perfumeName, @perfumePrice,@perfumeImg,@CategoryID,@productQuantity)";
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("perfumeCode", productCode);
                    command.Parameters.AddWithValue("perfumeName", productName);
                    command.Parameters.AddWithValue("perfumePrice", Convert.ToDouble(price));
                    command.Parameters.AddWithValue("perfumeImg", perfumeImg);

                    command.Parameters.AddWithValue("productQuantity", quantity);
                        command.Parameters.AddWithValue("CategoryID", CategoryID);
                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Successfully added new product", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearData();
                        LoadProductData();
                    }
                    else
                    {
                        MessageBox.Show("Cannot add new product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else
                {
                    MessageBox.Show("iNPUT iNVALID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                connection.Close();
            }
        }

        private void UpdateProduct()
        {
            SqlConnection connection = DatabaseConnection.GetConnection();
            if (connection != null)
            {
                connection.Open();
                string productCode = txtproductcodee.Text;
                string productName = txtproductNamee.Text;
                string perfumeImg = "UPDATING";
                string price = txtproductpricee.Text;
                string quantity = txtProductQuantityy.Text;
               int CategoryID = Convert.ToInt32(cbCategory.SelectedValue);
                if (ValidateData(productCode, productName, price, quantity,perfumeImg))
                {
                    string sql = "UPDATE PERFUME SET PerfumeCode = @PerfumeCode, PerfumeName = @PerfumeName, PerfumePrice = @PerfumePrice, " +
                                 " CategoryID = @CategoryID, " + "ProductQuantity= @ProductQuantity " +
                                 "WHERE PerfumeID = @productID";
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("PerfumeCode", productCode);
                    command.Parameters.AddWithValue("PerfumeName", productName);
                    command.Parameters.AddWithValue("PerfumePrice", Convert.ToDouble(price));
                    command.Parameters.AddWithValue("ProductQuantity", quantity);
                    command.Parameters.AddWithValue("CategoryID", CategoryID);
                    command.Parameters.AddWithValue("productID", this.productID);
                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Successfully updated product", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearData();
                        LoadProductData();
                    }
                    else
                    {
                        MessageBox.Show("Cannot update product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("iNPUT iNVALID", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                connection.Close();
            }
        }

        private void DeleteProduct()
        {
            DialogResult dialogResult = MessageBox.Show("Do you want to delete the product?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                if (IsProductInOrder(this.productID))
                {
                    MessageBox.Show("Product is in another order. Cannot delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                SqlConnection connection = DatabaseConnection.GetConnection();
                if (connection != null)
                {
                    connection.Open();
                    string sql = "DELETE FROM PERFUME WHERE PerfumeID = @perfumeID";
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.AddWithValue("perfumeID", this.productID);
                    int result = command.ExecuteNonQuery();
                    if (result > 0)
                    {
                        MessageBox.Show("Successfully deleted product", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearData();
                        LoadProductData();
                    }
                    else
                    {
                        MessageBox.Show("Cannot delete product", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    connection.Close();
                }
            }
        }

        private bool IsProductInOrder(int productID)
        {
            SqlConnection connection = DatabaseConnection.GetConnection();
            if (connection != null)
            {
                connection.Open();
                string sql = "SELECT COUNT(*) FROM SaleDetail WHERE PerfumeID = @perfumeID";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("perfumeID", productID);
                int result = (int)command.ExecuteScalar();  // Use ExecuteScalar for count
                connection.Close();
                return result > 0;
            }
            return false;
        }

        private void SearchProduct(string search)
        {
            if (string.IsNullOrEmpty(search))
            {
                LoadProductData();
            }
            else
            {
                SqlConnection connection = DatabaseConnection.GetConnection();
                if (connection != null)
                {
                    connection.Open();
                    string sql = "SELECT p.PerfumeID, p.PerfumeCode, p.PerfumeName, p.PerfumePrice" + " p.perfumeStock, p.PerfumeImage, c.CategoryName " +
                                 "FROM PERFUME p" +
                                 "INNER JOIN Category c" +
                                 "ON p.CategoryID = c.CategoryID " +
                                 "WHERE p.PerfumeCode LIKE @search " +
                                 "OR p.PerfumeName LIKE @search" +
                                 "OR c.CategoryName LIKE @search";
                    SqlDataAdapter adapter = new SqlDataAdapter(sql, connection);
                    adapter.SelectCommand.Parameters.AddWithValue("search", "%" + search + "%");
                    DataTable data = new DataTable();
                    adapter.Fill(data);
                    dtgProductt.DataSource = data;
                    connection.Close();
                }
            }
        }
        private void btnUpload_Click(object sender, EventArgs e)
        {
           
        }

        private void cbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void btnBACKK_Click(object sender, EventArgs e)
        {
            switch (authorityLevel)
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

        private void txtSearchh_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            SearchProduct(search);
        }
        private void btnCategory_Click(object sender, EventArgs e)
        {
            ManageCategory manageCategory = new ManageCategory(this.authorityLevel, this.employeeId);
            this.Hide();
            manageCategory.Show();
        }
        private void dtgProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dtgProductt.CurrentCell.RowIndex;
            if (index != -1 && !dtgProductt.Rows[index].IsNewRow)
            {
                productID = Convert.ToInt32(dtgProductt.Rows[index].Cells[0].Value);
                
                txtproductcodee.Text = dtgProductt.Rows[index].Cells[1].Value.ToString();
                txtproductNamee.Text = dtgProductt.Rows[index].Cells[2].Value.ToString();
                txtproductpricee.Text = dtgProductt.Rows[index].Cells[3].Value.ToString();
                txtProductQuantityy.Text = dtgProductt.Rows[index].Cells[4].Value.ToString();
            //    txtProductImg.Text = dtgProduct.Rows[index].Cells[5].Value.ToString();
                string categoryName = dtgProductt.Rows[index].Cells[6].Value.ToString();
                for (int i = 0; i < cbCategory.Items.Count; i++)
                {
                    if (cbCategory.SelectedText == categoryName)
                    {
                        cbCategory.SelectedIndex = i;
                        break;
                    }
                }
            }
        }

        private void PRODUCT_MANAGEMENT_Load_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtproductNamee_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProductQuantityy_TextChanged(object sender, EventArgs e)
        {

        }
      
        private void dtgProductt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = dtgProductt.CurrentCell.RowIndex;
            if (index != -1 && !dtgProductt.Rows[index].IsNewRow)
            {
                productID = Convert.ToInt32(dtgProductt.Rows[index].Cells[0].Value);

                txtproductcodee.Text = dtgProductt.Rows[index].Cells[1].Value.ToString();
                txtproductNamee.Text = dtgProductt.Rows[index].Cells[2].Value.ToString();
                txtproductpricee.Text = dtgProductt.Rows[index].Cells[3].Value.ToString();
                txtProductQuantityy.Text = dtgProductt.Rows[index].Cells[9].Value.ToString();
                string categoryName = dtgProductt.Rows[index].Cells[8].Value.ToString();
                cbCategory.SelectedValue = categoryName;
            }
        }

        private void btnDeletee_Click(object sender, EventArgs e)
        {
            DeleteProduct();
        }

        private void btnclearr_Click(object sender, EventArgs e)
        {
            ClearData();
        }
    }
}


    
