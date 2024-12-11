using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASSIGNMENT1_VUONG_NGOC_ANH
{
    public partial class Admin : Form
    {
        private int employeeId;
        private string authorityLevel;

        public Admin(string authorityLevel, int employeeId)
        {
            this.authorityLevel = authorityLevel;
            this.employeeId = employeeId;
            InitializeComponent();
        }

        private void Admin_Load(object sender, EventArgs E)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }
        private ManageEmployee manageEmployee;
        private void btnEmployee_Click(object sender, EventArgs e)
        {
            manageEmployee = new ManageEmployee(this.employeeId ,this.authorityLevel);
            this.Hide();
            manageEmployee.Show();
        }
        private Customer_Management CustomerManagement;
        private string customerAddress;

        public int CustomerID { get; private set; }

        private void btnCustomerr_Click(object sender, EventArgs e)
        {
          CustomerManagement  = new Customer_Management(this.employeeId, this.authorityLevel);
         this.Hide();
         CustomerManagement.Show();
        }

        private void btnProduct_Click(object sender, EventArgs e)
        {
            PRODUCTMANAGE manageProduct = new PRODUCTMANAGE(authorityLevel, employeeId);
            this.Hide();
            manageProduct.Show();
        }

        private void btnCategory_Click(object sender, EventArgs e)
        {
            
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            Order_and_Order_Detail order_And_Order_Detail = new Order_and_Order_Detail(this.authorityLevel, this.employeeId);
            this.Hide();
            order_And_Order_Detail.Show();
        }

        private void btnBackk_Click(object sender, EventArgs e)
        {

        }

        private void gbAdminFeature_Enter(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            
                // Đóng form hiện tại
                this.Close();
            

        }
    }
}
