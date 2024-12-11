namespace ASSIGNMENT1_VUONG_NGOC_ANH
{
    partial class Warehouse_Manager
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
            this.btnManageproduct = new System.Windows.Forms.Button();
            this.gbmanageproduct = new System.Windows.Forms.GroupBox();
            this.btnBACK = new System.Windows.Forms.Button();
            this.gbmanageproduct.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnManageproduct
            // 
            this.btnManageproduct.Location = new System.Drawing.Point(70, 98);
            this.btnManageproduct.Margin = new System.Windows.Forms.Padding(6);
            this.btnManageproduct.Name = "btnManageproduct";
            this.btnManageproduct.Size = new System.Drawing.Size(344, 102);
            this.btnManageproduct.TabIndex = 0;
            this.btnManageproduct.Text = "ManageProduct ";
            this.btnManageproduct.UseVisualStyleBackColor = true;
            // 
            // gbmanageproduct
            // 
            this.gbmanageproduct.Controls.Add(this.btnBACK);
            this.gbmanageproduct.Controls.Add(this.btnManageproduct);
            this.gbmanageproduct.Location = new System.Drawing.Point(26, 23);
            this.gbmanageproduct.Margin = new System.Windows.Forms.Padding(6);
            this.gbmanageproduct.Name = "gbmanageproduct";
            this.gbmanageproduct.Padding = new System.Windows.Forms.Padding(6);
            this.gbmanageproduct.Size = new System.Drawing.Size(720, 487);
            this.gbmanageproduct.TabIndex = 1;
            this.gbmanageproduct.TabStop = false;
            this.gbmanageproduct.Text = "ManageProduct";
            this.gbmanageproduct.Enter += new System.EventHandler(this.gbmanageproduct_Enter);
            // 
            // btnBACK
            // 
            this.btnBACK.Location = new System.Drawing.Point(442, 358);
            this.btnBACK.Margin = new System.Windows.Forms.Padding(6);
            this.btnBACK.Name = "btnBACK";
            this.btnBACK.Size = new System.Drawing.Size(162, 54);
            this.btnBACK.TabIndex = 3;
            this.btnBACK.Text = "BACK ";
            this.btnBACK.UseVisualStyleBackColor = true;
            this.btnBACK.Click += new System.EventHandler(this.btnBACK_Click);
            // 
            // Warehouse_Manager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(662, 461);
            this.Controls.Add(this.gbmanageproduct);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Warehouse_Manager";
            this.Text = "Warehouse_Manager";
            this.Load += new System.EventHandler(this.Warehouse_Manager_Load);
            this.gbmanageproduct.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnManageproduct;
        private System.Windows.Forms.GroupBox gbmanageproduct;
        private System.Windows.Forms.Button btnBACK;
    }
}