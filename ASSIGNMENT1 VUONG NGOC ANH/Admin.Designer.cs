namespace ASSIGNMENT1_VUONG_NGOC_ANH
{
    partial class Admin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnProduct = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnCustomerr = new System.Windows.Forms.Button();
            this.btnOrder = new System.Windows.Forms.Button();
            this.btnImportt = new System.Windows.Forms.Button();
            this.btnCategory = new System.Windows.Forms.Button();
            this.btnViewStatic = new System.Windows.Forms.Button();
            this.btnSupplier = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.gbAdminFeature = new System.Windows.Forms.GroupBox();
            this.gbAdminFeature.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnProduct
            // 
            this.btnProduct.Location = new System.Drawing.Point(26, 40);
            this.btnProduct.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(294, 88);
            this.btnProduct.TabIndex = 0;
            this.btnProduct.Tag = "";
            this.btnProduct.Text = "PRODUCT ";
            this.btnProduct.UseVisualStyleBackColor = true;
            this.btnProduct.Click += new System.EventHandler(this.btnProduct_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.Location = new System.Drawing.Point(26, 169);
            this.btnEmployee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(294, 88);
            this.btnEmployee.TabIndex = 1;
            this.btnEmployee.Text = "EMPLOYEE";
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.btnEmployee_Click);
            // 
            // btnCustomerr
            // 
            this.btnCustomerr.Location = new System.Drawing.Point(26, 298);
            this.btnCustomerr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCustomerr.Name = "btnCustomerr";
            this.btnCustomerr.Size = new System.Drawing.Size(294, 88);
            this.btnCustomerr.TabIndex = 2;
            this.btnCustomerr.Text = "CUSTOMER ";
            this.btnCustomerr.UseVisualStyleBackColor = true;
            this.btnCustomerr.Click += new System.EventHandler(this.btnCustomerr_Click);
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(26, 435);
            this.btnOrder.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(294, 88);
            this.btnOrder.TabIndex = 3;
            this.btnOrder.Text = "ORDER ";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // btnImportt
            // 
            this.btnImportt.Location = new System.Drawing.Point(494, 40);
            this.btnImportt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnImportt.Name = "btnImportt";
            this.btnImportt.Size = new System.Drawing.Size(294, 88);
            this.btnImportt.TabIndex = 4;
            this.btnImportt.Text = "IMPORT ";
            this.btnImportt.UseVisualStyleBackColor = true;
            // 
            // btnCategory
            // 
            this.btnCategory.Location = new System.Drawing.Point(494, 169);
            this.btnCategory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCategory.Name = "btnCategory";
            this.btnCategory.Size = new System.Drawing.Size(294, 88);
            this.btnCategory.TabIndex = 5;
            this.btnCategory.Text = "CATEGORY ";
            this.btnCategory.UseVisualStyleBackColor = true;
            this.btnCategory.Click += new System.EventHandler(this.btnCategory_Click);
            // 
            // btnViewStatic
            // 
            this.btnViewStatic.Location = new System.Drawing.Point(494, 298);
            this.btnViewStatic.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnViewStatic.Name = "btnViewStatic";
            this.btnViewStatic.Size = new System.Drawing.Size(294, 88);
            this.btnViewStatic.TabIndex = 6;
            this.btnViewStatic.Text = "VIEW STATIC ";
            this.btnViewStatic.UseVisualStyleBackColor = true;
            // 
            // btnSupplier
            // 
            this.btnSupplier.Location = new System.Drawing.Point(494, 435);
            this.btnSupplier.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSupplier.Name = "btnSupplier";
            this.btnSupplier.Size = new System.Drawing.Size(294, 88);
            this.btnSupplier.TabIndex = 7;
            this.btnSupplier.Text = "SUPPLIER ";
            this.btnSupplier.UseVisualStyleBackColor = true;
            this.btnSupplier.Click += new System.EventHandler(this.button8_Click);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(788, 589);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(140, 44);
            this.btnExit.TabIndex = 9;
            this.btnExit.Text = "EXIT ";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gbAdminFeature
            // 
            this.gbAdminFeature.Controls.Add(this.btnSupplier);
            this.gbAdminFeature.Controls.Add(this.btnViewStatic);
            this.gbAdminFeature.Controls.Add(this.btnCategory);
            this.gbAdminFeature.Controls.Add(this.btnImportt);
            this.gbAdminFeature.Controls.Add(this.btnOrder);
            this.gbAdminFeature.Controls.Add(this.btnCustomerr);
            this.gbAdminFeature.Controls.Add(this.btnEmployee);
            this.gbAdminFeature.Controls.Add(this.btnProduct);
            this.gbAdminFeature.Location = new System.Drawing.Point(38, 23);
            this.gbAdminFeature.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbAdminFeature.Name = "gbAdminFeature";
            this.gbAdminFeature.Padding = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.gbAdminFeature.Size = new System.Drawing.Size(910, 556);
            this.gbAdminFeature.TabIndex = 10;
            this.gbAdminFeature.TabStop = false;
            this.gbAdminFeature.Text = "Admin feature groupbox\t";
            this.gbAdminFeature.Enter += new System.EventHandler(this.gbAdminFeature_Enter);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(941, 644);
            this.Controls.Add(this.gbAdminFeature);
            this.Controls.Add(this.btnExit);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.gbAdminFeature.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Button btnCustomerr;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button btnImportt;
        private System.Windows.Forms.Button btnCategory;
        private System.Windows.Forms.Button btnViewStatic;
        private System.Windows.Forms.Button btnSupplier;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox gbAdminFeature;
    }
}