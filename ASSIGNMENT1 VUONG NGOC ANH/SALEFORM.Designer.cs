namespace ASSIGNMENT1_VUONG_NGOC_ANH
{
    partial class SALEFORM
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
            this.btnManageOrder = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnBACK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnManageOrder
            // 
            this.btnManageOrder.Location = new System.Drawing.Point(12, 92);
            this.btnManageOrder.Name = "btnManageOrder";
            this.btnManageOrder.Size = new System.Drawing.Size(192, 50);
            this.btnManageOrder.TabIndex = 0;
            this.btnManageOrder.Text = "ManageOrder";
            this.btnManageOrder.UseVisualStyleBackColor = true;
            this.btnManageOrder.Click += new System.EventHandler(this.btnManageOrder_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Location = new System.Drawing.Point(234, 92);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(192, 50);
            this.btnCustomer.TabIndex = 1;
            this.btnCustomer.Text = "ManageCustomer ";
            this.btnCustomer.UseVisualStyleBackColor = true;
            // 
            // btnBACK
            // 
            this.btnBACK.Location = new System.Drawing.Point(345, 207);
            this.btnBACK.Name = "btnBACK";
            this.btnBACK.Size = new System.Drawing.Size(81, 28);
            this.btnBACK.TabIndex = 2;
            this.btnBACK.Text = "BACK ";
            this.btnBACK.UseVisualStyleBackColor = true;
            // 
            // SALEFORM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 247);
            this.Controls.Add(this.btnBACK);
            this.Controls.Add(this.btnCustomer);
            this.Controls.Add(this.btnManageOrder);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SALEFORM";
            this.Text = "SALEFORM";
            this.Load += new System.EventHandler(this.SALEFORM_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnManageOrder;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnBACK;
    }
}