namespace ASSIGNMENT1_VUONG_NGOC_ANH
{
    partial class Change_Password
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
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNewpassword = new System.Windows.Forms.TextBox();
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.btnChangee = new System.Windows.Forms.Button();
            this.btnClearr = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LavenderBlush;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Indigo;
            this.button1.Location = new System.Drawing.Point(-7, -2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(809, 66);
            this.button1.TabIndex = 0;
            this.button1.Text = "CHANGE  PASSWORD ";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "New Password ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 240);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Confirm Password ";
            // 
            // txtNewpassword
            // 
            this.txtNewpassword.Location = new System.Drawing.Point(382, 153);
            this.txtNewpassword.Name = "txtNewpassword";
            this.txtNewpassword.Size = new System.Drawing.Size(358, 31);
            this.txtNewpassword.TabIndex = 7;
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(382, 234);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(358, 31);
            this.txtConfirmPassword.TabIndex = 8;
            // 
            // btnChangee
            // 
            this.btnChangee.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnChangee.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnChangee.Location = new System.Drawing.Point(216, 365);
            this.btnChangee.Name = "btnChangee";
            this.btnChangee.Size = new System.Drawing.Size(107, 37);
            this.btnChangee.TabIndex = 9;
            this.btnChangee.Text = "Change ";
            this.btnChangee.UseVisualStyleBackColor = false;
            this.btnChangee.Click += new System.EventHandler(this.btnChangee_Click);
            // 
            // btnClearr
            // 
            this.btnClearr.BackColor = System.Drawing.Color.Red;
            this.btnClearr.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClearr.Location = new System.Drawing.Point(436, 365);
            this.btnClearr.Name = "btnClearr";
            this.btnClearr.Size = new System.Drawing.Size(107, 37);
            this.btnClearr.TabIndex = 10;
            this.btnClearr.Text = "Clear ";
            this.btnClearr.UseVisualStyleBackColor = false;
            this.btnClearr.Click += new System.EventHandler(this.btnClearr_Click);
            // 
            // Change_Password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.BackgroundImage = global::ASSIGNMENT1_VUONG_NGOC_ANH.Properties.Resources.Mau_chai_nuoc_hoa_dep_1;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClearr);
            this.Controls.Add(this.btnChangee);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.txtNewpassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Name = "Change_Password";
            this.Text = "Change_Password";
            this.Load += new System.EventHandler(this.Change_Password_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNewpassword;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Button btnChangee;
        private System.Windows.Forms.Button btnClearr;
    }
}