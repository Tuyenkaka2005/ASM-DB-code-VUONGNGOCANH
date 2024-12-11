namespace ASSIGNMENT1_VUONG_NGOC_ANH
{
    partial class StaffForm
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
            this.btnOrderr = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnCategoryy = new System.Windows.Forms.Button();
            this.btnBackk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProduct
            // 
            this.btnProduct.Location = new System.Drawing.Point(46, 65);
            this.btnProduct.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnProduct.Name = "btnProduct";
            this.btnProduct.Size = new System.Drawing.Size(170, 47);
            this.btnProduct.TabIndex = 0;
            this.btnProduct.Text = "PRODUCT";
            this.btnProduct.UseVisualStyleBackColor = true;
            // 
            // btnOrderr
            // 
            this.btnOrderr.Location = new System.Drawing.Point(46, 149);
            this.btnOrderr.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOrderr.Name = "btnOrderr";
            this.btnOrderr.Size = new System.Drawing.Size(170, 47);
            this.btnOrderr.TabIndex = 1;
            this.btnOrderr.Text = "ORDER";
            this.btnOrderr.UseVisualStyleBackColor = true;
            // 
            // btnCustomer
            // 
            this.btnCustomer.Location = new System.Drawing.Point(246, 65);
            this.btnCustomer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(170, 47);
            this.btnCustomer.TabIndex = 2;
            this.btnCustomer.Text = "CUSTOMER ";
            this.btnCustomer.UseVisualStyleBackColor = true;
            // 
            // btnCategoryy
            // 
            this.btnCategoryy.Location = new System.Drawing.Point(246, 149);
            this.btnCategoryy.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnCategoryy.Name = "btnCategoryy";
            this.btnCategoryy.Size = new System.Drawing.Size(170, 47);
            this.btnCategoryy.TabIndex = 3;
            this.btnCategoryy.Text = "CATEGORY";
            this.btnCategoryy.UseVisualStyleBackColor = true;
            // 
            // btnBackk
            // 
            this.btnBackk.Location = new System.Drawing.Point(386, 240);
            this.btnBackk.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnBackk.Name = "btnBackk";
            this.btnBackk.Size = new System.Drawing.Size(64, 18);
            this.btnBackk.TabIndex = 4;
            this.btnBackk.Text = "Back ";
            this.btnBackk.UseVisualStyleBackColor = true;
            // 
            // StaffForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 264);
            this.Controls.Add(this.btnBackk);
            this.Controls.Add(this.btnCategoryy);
            this.Controls.Add(this.btnCustomer);
            this.Controls.Add(this.btnOrderr);
            this.Controls.Add(this.btnProduct);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "StaffForm";
            this.Text = "StaffForm";
            this.Load += new System.EventHandler(this.StaffForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnProduct;
        private System.Windows.Forms.Button btnOrderr;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnCategoryy;
        private System.Windows.Forms.Button btnBackk;
    }
}