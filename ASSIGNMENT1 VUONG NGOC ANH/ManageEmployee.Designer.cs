namespace ASSIGNMENT1_VUONG_NGOC_ANH
{
    partial class ManageEmployee
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
            this.cbAuthorityLevel = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnclearrr = new System.Windows.Forms.Button();
            this.btnback = new System.Windows.Forms.Button();
            this.btndelete = new System.Windows.Forms.Button();
            this.btnadd = new System.Windows.Forms.Button();
            this.btnupdate = new System.Windows.Forms.Button();
            this.lbAuthorityLevel = new System.Windows.Forms.Label();
            this.dtgEmployee = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.cbPosision = new System.Windows.Forms.ComboBox();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.txtEmployeeCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnadmin = new System.Windows.Forms.Button();
            this.btnBackk = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // cbAuthorityLevel
            // 
            this.cbAuthorityLevel.FormattingEnabled = true;
            this.cbAuthorityLevel.Location = new System.Drawing.Point(986, 177);
            this.cbAuthorityLevel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbAuthorityLevel.Name = "cbAuthorityLevel";
            this.cbAuthorityLevel.Size = new System.Drawing.Size(388, 33);
            this.cbAuthorityLevel.TabIndex = 77;
            this.cbAuthorityLevel.SelectedIndexChanged += new System.EventHandler(this.cbAuthorityLevel_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(-2, 429);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(147, 25);
            this.label4.TabIndex = 75;
            this.label4.Text = "Employee List";
            // 
            // btnclearrr
            // 
            this.btnclearrr.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnclearrr.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnclearrr.Location = new System.Drawing.Point(1288, 392);
            this.btnclearrr.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnclearrr.Name = "btnclearrr";
            this.btnclearrr.Size = new System.Drawing.Size(160, 58);
            this.btnclearrr.TabIndex = 74;
            this.btnclearrr.Text = "CLEAR";
            this.btnclearrr.UseVisualStyleBackColor = false;
            this.btnclearrr.Click += new System.EventHandler(this.btnclearrr_Click);
            // 
            // btnback
            // 
            this.btnback.Location = new System.Drawing.Point(1356, 852);
            this.btnback.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnback.Name = "btnback";
            this.btnback.Size = new System.Drawing.Size(134, 40);
            this.btnback.TabIndex = 73;
            this.btnback.Text = "Back";
            this.btnback.UseVisualStyleBackColor = true;
            // 
            // btndelete
            // 
            this.btndelete.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btndelete.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btndelete.Location = new System.Drawing.Point(1108, 392);
            this.btndelete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(174, 58);
            this.btndelete.TabIndex = 72;
            this.btndelete.Text = "DELETE";
            this.btndelete.UseVisualStyleBackColor = false;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnadd
            // 
            this.btnadd.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnadd.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnadd.Location = new System.Drawing.Point(928, 392);
            this.btnadd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(174, 58);
            this.btnadd.TabIndex = 71;
            this.btnadd.Text = "ADD ";
            this.btnadd.UseVisualStyleBackColor = false;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.AccessibleRole = System.Windows.Forms.AccessibleRole.Chart;
            this.btnupdate.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnupdate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnupdate.Location = new System.Drawing.Point(748, 392);
            this.btnupdate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.Size = new System.Drawing.Size(174, 58);
            this.btnupdate.TabIndex = 70;
            this.btnupdate.Text = "UPDATE ";
            this.btnupdate.UseVisualStyleBackColor = false;
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // lbAuthorityLevel
            // 
            this.lbAuthorityLevel.AutoSize = true;
            this.lbAuthorityLevel.Location = new System.Drawing.Point(780, 185);
            this.lbAuthorityLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAuthorityLevel.Name = "lbAuthorityLevel";
            this.lbAuthorityLevel.Size = new System.Drawing.Size(155, 25);
            this.lbAuthorityLevel.TabIndex = 76;
            this.lbAuthorityLevel.Text = "Authority Level";
            // 
            // dtgEmployee
            // 
            this.dtgEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEmployee.Location = new System.Drawing.Point(0, 458);
            this.dtgEmployee.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtgEmployee.Name = "dtgEmployee";
            this.dtgEmployee.RowHeadersWidth = 82;
            this.dtgEmployee.RowTemplate.Height = 33;
            this.dtgEmployee.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgEmployee.Size = new System.Drawing.Size(1488, 440);
            this.dtgEmployee.TabIndex = 69;
            this.dtgEmployee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgEmployee_CellContentClick);
            this.dtgEmployee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgEmployee_CellContentClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(928, 321);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(286, 31);
            this.txtSearch.TabIndex = 68;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
            // 
            // txtpassword
            // 
            this.txtpassword.Location = new System.Drawing.Point(986, 113);
            this.txtpassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(386, 31);
            this.txtpassword.TabIndex = 66;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(308, 317);
            this.txtusername.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(436, 31);
            this.txtusername.TabIndex = 65;
            // 
            // cbPosision
            // 
            this.cbPosision.FormattingEnabled = true;
            this.cbPosision.Location = new System.Drawing.Point(308, 246);
            this.cbPosision.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbPosision.Name = "cbPosision";
            this.cbPosision.Size = new System.Drawing.Size(432, 33);
            this.cbPosision.TabIndex = 64;
            this.cbPosision.SelectedIndexChanged += new System.EventHandler(this.cbPosision_SelectedIndexChanged);
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(308, 179);
            this.txtFullName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(432, 31);
            this.txtFullName.TabIndex = 63;
            // 
            // txtEmployeeCode
            // 
            this.txtEmployeeCode.Location = new System.Drawing.Point(308, 113);
            this.txtEmployeeCode.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmployeeCode.Name = "txtEmployeeCode";
            this.txtEmployeeCode.Size = new System.Drawing.Size(432, 31);
            this.txtEmployeeCode.TabIndex = 62;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(822, 331);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 25);
            this.label7.TabIndex = 61;
            this.label7.Text = "Search ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(784, 119);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(106, 25);
            this.label6.TabIndex = 60;
            this.label6.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(86, 321);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 25);
            this.label5.TabIndex = 59;
            this.label5.Text = "User Name ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(86, 256);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 25);
            this.label3.TabIndex = 58;
            this.label3.Text = "Posision";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(86, 185);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 25);
            this.label2.TabIndex = 57;
            this.label2.Text = "Employee Full Name ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 113);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 25);
            this.label1.TabIndex = 56;
            this.label1.Text = "Employee Code ";
            // 
            // btnadmin
            // 
            this.btnadmin.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnadmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnadmin.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnadmin.Location = new System.Drawing.Point(-4, -10);
            this.btnadmin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnadmin.Name = "btnadmin";
            this.btnadmin.Size = new System.Drawing.Size(1492, 90);
            this.btnadmin.TabIndex = 55;
            this.btnadmin.Text = "MANAGEMENT EMPLOYEE";
            this.btnadmin.UseVisualStyleBackColor = false;
            // 
            // btnBackk
            // 
            this.btnBackk.Location = new System.Drawing.Point(1344, 804);
            this.btnBackk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBackk.Name = "btnBackk";
            this.btnBackk.Size = new System.Drawing.Size(144, 38);
            this.btnBackk.TabIndex = 78;
            this.btnBackk.Text = "BACK";
            this.btnBackk.UseVisualStyleBackColor = true;
            this.btnBackk.Click += new System.EventHandler(this.btnBackk_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(786, 246);
            this.label8.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 25);
            this.label8.TabIndex = 79;
            this.label8.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(986, 240);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(386, 31);
            this.txtEmail.TabIndex = 80;
            // 
            // ManageEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1486, 844);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnBackk);
            this.Controls.Add(this.cbAuthorityLevel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnclearrr);
            this.Controls.Add(this.btnback);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.lbAuthorityLevel);
            this.Controls.Add(this.dtgEmployee);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.cbPosision);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtEmployeeCode);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnadmin);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ManageEmployee";
            this.Text = "ManageEmployee";
            this.Load += new System.EventHandler(this.ManageEmployee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbAuthorityLevel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnclearrr;
        private System.Windows.Forms.Button btnback;
        private System.Windows.Forms.Button btndelete;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.Button btnupdate;
        private System.Windows.Forms.Label lbAuthorityLevel;
        private System.Windows.Forms.DataGridView dtgEmployee;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.ComboBox cbPosision;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtEmployeeCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnadmin;
        private System.Windows.Forms.Button btnBackk;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtEmail;
    }
}