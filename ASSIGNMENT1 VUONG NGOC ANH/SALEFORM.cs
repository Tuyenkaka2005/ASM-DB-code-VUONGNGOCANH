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
    public partial class SALEFORM : Form
    {
        private int employeeID;
        private string authorityLevel;
        string authority;
        


        public SALEFORM(int employeeID, string authorityLevel)
        {
            this.employeeID = employeeID;
            this.authorityLevel = authorityLevel;

            InitializeComponent();
           
        }

        private void btnManageOrder_Click(object sender, EventArgs e)
        {
            Order_and_Order_Detail order_And_Order_Detail = new Order_and_Order_Detail(this.authority, this.employeeID);
            this.Hide();
            order_And_Order_Detail.Show();
        }

        private void SALEFORM_Load(object sender, EventArgs e)
        {

        }
    }
}
