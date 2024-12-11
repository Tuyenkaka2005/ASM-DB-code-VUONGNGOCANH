namespace ASSIGNMENT1_VUONG_NGOC_ANH
{
    partial class PRODUCTMANAGE
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
            this.dtgProductt = new System.Windows.Forms.DataGridView();
            this.btnBACKK = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnclearr = new System.Windows.Forms.Button();
            this.btnDeletee = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.txtProductQuantityy = new System.Windows.Forms.TextBox();
            this.txtproductpricee = new System.Windows.Forms.TextBox();
            this.txtproductNamee = new System.Windows.Forms.TextBox();
            this.txtproductcodee = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtimg = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductt)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgProductt
            // 
            this.dtgProductt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProductt.Location = new System.Drawing.Point(693, 156);
            this.dtgProductt.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.dtgProductt.Name = "dtgProductt";
            this.dtgProductt.RowHeadersWidth = 82;
            this.dtgProductt.Size = new System.Drawing.Size(666, 610);
            this.dtgProductt.TabIndex = 37;
            this.dtgProductt.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProductt_CellClick);
            this.dtgProductt.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProductt_CellClick);
            // 
            // btnBACKK
            // 
            this.btnBACKK.Location = new System.Drawing.Point(28, 740);
            this.btnBACKK.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnBACKK.Name = "btnBACKK";
            this.btnBACKK.Size = new System.Drawing.Size(150, 44);
            this.btnBACKK.TabIndex = 36;
            this.btnBACKK.Text = "BACK";
            this.btnBACKK.UseVisualStyleBackColor = true;
            this.btnBACKK.Click += new System.EventHandler(this.btnBACKK_Click);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(924, 81);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(294, 31);
            this.txtSearch.TabIndex = 35;
            // 
            // btnclearr
            // 
            this.btnclearr.Location = new System.Drawing.Point(376, 608);
            this.btnclearr.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnclearr.Name = "btnclearr";
            this.btnclearr.Size = new System.Drawing.Size(150, 44);
            this.btnclearr.TabIndex = 34;
            this.btnclearr.Text = "CLEAR ";
            this.btnclearr.UseVisualStyleBackColor = true;
            this.btnclearr.Click += new System.EventHandler(this.btnclearr_Click);
            // 
            // btnDeletee
            // 
            this.btnDeletee.Location = new System.Drawing.Point(120, 608);
            this.btnDeletee.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnDeletee.Name = "btnDeletee";
            this.btnDeletee.Size = new System.Drawing.Size(150, 44);
            this.btnDeletee.TabIndex = 33;
            this.btnDeletee.Text = "DELETE";
            this.btnDeletee.UseVisualStyleBackColor = true;
            this.btnDeletee.Click += new System.EventHandler(this.btnDeletee_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.Location = new System.Drawing.Point(376, 521);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(150, 44);
            this.btnupdate.TabIndex = 32;
            this.btnupdate.Text = "UPDATE ";
            this.btnupdate.UseVisualStyleBackColor = true;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(120, 521);
            this.btnadd.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(150, 44);
            this.btnadd.TabIndex = 31;
            this.btnadd.Text = "ADD";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(276, 387);
            this.cbCategory.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(294, 33);
            this.cbCategory.TabIndex = 30;
            // 
            // txtProductQuantityy
            // 
            this.txtProductQuantityy.Location = new System.Drawing.Point(276, 263);
            this.txtProductQuantityy.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtProductQuantityy.Name = "txtProductQuantityy";
            this.txtProductQuantityy.Size = new System.Drawing.Size(294, 31);
            this.txtProductQuantityy.TabIndex = 28;
            // 
            // txtproductpricee
            // 
            this.txtproductpricee.Location = new System.Drawing.Point(276, 206);
            this.txtproductpricee.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtproductpricee.Name = "txtproductpricee";
            this.txtproductpricee.Size = new System.Drawing.Size(294, 31);
            this.txtproductpricee.TabIndex = 27;
            // 
            // txtproductNamee
            // 
            this.txtproductNamee.Location = new System.Drawing.Point(276, 142);
            this.txtproductNamee.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtproductNamee.Name = "txtproductNamee";
            this.txtproductNamee.Size = new System.Drawing.Size(294, 31);
            this.txtproductNamee.TabIndex = 26;
            // 
            // txtproductcodee
            // 
            this.txtproductcodee.Location = new System.Drawing.Point(276, 81);
            this.txtproductcodee.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtproductcodee.Name = "txtproductcodee";
            this.txtproductcodee.Size = new System.Drawing.Size(294, 31);
            this.txtproductcodee.TabIndex = 25;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(90, 404);
            this.label13.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(99, 25);
            this.label13.TabIndex = 24;
            this.label13.Text = "Category";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(90, 267);
            this.label11.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(172, 25);
            this.label11.TabIndex = 22;
            this.label11.Text = "Product Quantity";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(90, 212);
            this.label10.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(147, 25);
            this.label10.TabIndex = 21;
            this.label10.Text = "Product Price ";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(90, 156);
            this.label9.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(154, 25);
            this.label9.TabIndex = 20;
            this.label9.Text = "Product Name ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(90, 94);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(149, 25);
            this.label4.TabIndex = 19;
            this.label4.Text = "Product Code ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 25);
            this.label1.TabIndex = 38;
            this.label1.Text = "Product information ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 337);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 25);
            this.label2.TabIndex = 39;
            this.label2.Text = "Product image  ";
            // 
            // txtimg
            // 
            this.txtimg.Location = new System.Drawing.Point(276, 331);
            this.txtimg.Margin = new System.Windows.Forms.Padding(6);
            this.txtimg.Name = "txtimg";
            this.txtimg.Size = new System.Drawing.Size(294, 31);
            this.txtimg.TabIndex = 40;
            // 
            // PRODUCTMANAGE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1360, 801);
            this.Controls.Add(this.txtimg);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtgProductt);
            this.Controls.Add(this.btnBACKK);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnclearr);
            this.Controls.Add(this.btnDeletee);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.cbCategory);
            this.Controls.Add(this.txtProductQuantityy);
            this.Controls.Add(this.txtproductpricee);
            this.Controls.Add(this.txtproductNamee);
            this.Controls.Add(this.txtproductcodee);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label4);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "PRODUCTMANAGE";
            this.Text = "PRODUCTMANAGE";
            this.Load += new System.EventHandler(this.PRODUCTMANAGE_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgProductt;
        private System.Windows.Forms.Button btnBACKK;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnclearr;
        private System.Windows.Forms.Button btnDeletee;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.TextBox txtProductQuantityy;
        private System.Windows.Forms.TextBox txtproductpricee;
        private System.Windows.Forms.TextBox txtproductNamee;
        private System.Windows.Forms.TextBox txtproductcodee;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtimg;
    }
}