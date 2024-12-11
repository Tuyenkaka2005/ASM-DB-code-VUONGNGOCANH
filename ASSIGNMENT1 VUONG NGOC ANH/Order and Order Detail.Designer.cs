namespace ASSIGNMENT1_VUONG_NGOC_ANH
{
    partial class Order_and_Order_Detail
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
            this.dataGridViewOrder = new System.Windows.Forms.DataGridView();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btnsearch = new System.Windows.Forms.Button();
            this.btnBackk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewOrder
            // 
            this.dataGridViewOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrder.Location = new System.Drawing.Point(2, 76);
            this.dataGridViewOrder.Name = "dataGridViewOrder";
            this.dataGridViewOrder.RowHeadersWidth = 82;
            this.dataGridViewOrder.Size = new System.Drawing.Size(898, 488);
            this.dataGridViewOrder.TabIndex = 0;
            this.dataGridViewOrder.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(369, 12);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(209, 31);
            this.txtsearch.TabIndex = 2;
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(584, 9);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(141, 34);
            this.btnsearch.TabIndex = 3;
            this.btnsearch.Text = "SEARCH ";
            this.btnsearch.UseVisualStyleBackColor = true;
            // 
            // btnBackk
            // 
            this.btnBackk.Location = new System.Drawing.Point(725, 530);
            this.btnBackk.Name = "btnBackk";
            this.btnBackk.Size = new System.Drawing.Size(110, 33);
            this.btnBackk.TabIndex = 4;
            this.btnBackk.Text = "BACK ";
            this.btnBackk.UseVisualStyleBackColor = true;
            this.btnBackk.Click += new System.EventHandler(this.btnBackk_Click);
            // 
            // Order_and_Order_Detail
            // 
            this.ClientSize = new System.Drawing.Size(839, 568);
            this.Controls.Add(this.btnBackk);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.dataGridViewOrder);
            this.Name = "Order_and_Order_Detail";
            this.Load += new System.EventHandler(this.Order_and_Order_Detail_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgOrderHistory;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridView dataGridViewOrder;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button btnsearch;
        private System.Windows.Forms.Button btnBackk;
    }
}