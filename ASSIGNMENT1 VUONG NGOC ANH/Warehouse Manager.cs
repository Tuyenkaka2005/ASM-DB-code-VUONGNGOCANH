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
    public partial class Warehouse_Manager : Form
    {
       int employeeID;
       string authirityLevel;
        public Warehouse_Manager(string authirityLevel, int employeeID)
        {
           this.authirityLevel = authirityLevel;
           this.employeeID = employeeID;   
           InitializeComponent();
        }

        private void Warehouse_Manager_Load(object sender, EventArgs e)
        {

        }

        private void gbmanageproduct_Enter(object sender, EventArgs e)
        {

        }

        private void btnBACK_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
