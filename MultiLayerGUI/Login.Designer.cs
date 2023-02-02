
namespace MultiLayerGUI
{
    partial class Login
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
            this.SrvrLbl = new System.Windows.Forms.Label();
            this.databaseLbl = new System.Windows.Forms.Label();
            this.usernameLbl = new System.Windows.Forms.Label();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.loginBtn = new System.Windows.Forms.Button();
            this.SrvrTxtBox = new System.Windows.Forms.TextBox();
            this.databaseTxtBox = new System.Windows.Forms.TextBox();
            this.userTxtBox = new System.Windows.Forms.TextBox();
            this.passTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // SrvrLbl
            // 
            this.SrvrLbl.AutoSize = true;
            this.SrvrLbl.Location = new System.Drawing.Point(45, 30);
            this.SrvrLbl.Name = "SrvrLbl";
            this.SrvrLbl.Size = new System.Drawing.Size(38, 13);
            this.SrvrLbl.TabIndex = 0;
            this.SrvrLbl.Text = "Server";
            // 
            // databaseLbl
            // 
            this.databaseLbl.AutoSize = true;
            this.databaseLbl.Location = new System.Drawing.Point(30, 57);
            this.databaseLbl.Name = "databaseLbl";
            this.databaseLbl.Size = new System.Drawing.Size(53, 13);
            this.databaseLbl.TabIndex = 1;
            this.databaseLbl.Text = "Database";
            // 
            // usernameLbl
            // 
            this.usernameLbl.AutoSize = true;
            this.usernameLbl.Location = new System.Drawing.Point(28, 81);
            this.usernameLbl.Name = "usernameLbl";
            this.usernameLbl.Size = new System.Drawing.Size(55, 13);
            this.usernameLbl.TabIndex = 2;
            this.usernameLbl.Text = "Username";
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Location = new System.Drawing.Point(30, 106);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(53, 13);
            this.passwordLbl.TabIndex = 3;
            this.passwordLbl.Text = "Password";
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(78, 138);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 23);
            this.loginBtn.TabIndex = 4;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // SrvrTxtBox
            // 
            this.SrvrTxtBox.Location = new System.Drawing.Point(96, 27);
            this.SrvrTxtBox.Name = "SrvrTxtBox";
            this.SrvrTxtBox.Size = new System.Drawing.Size(100, 20);
            this.SrvrTxtBox.TabIndex = 5;
            // 
            // databaseTxtBox
            // 
            this.databaseTxtBox.Location = new System.Drawing.Point(96, 53);
            this.databaseTxtBox.Name = "databaseTxtBox";
            this.databaseTxtBox.Size = new System.Drawing.Size(100, 20);
            this.databaseTxtBox.TabIndex = 6;
            // 
            // userTxtBox
            // 
            this.userTxtBox.Location = new System.Drawing.Point(96, 78);
            this.userTxtBox.Name = "userTxtBox";
            this.userTxtBox.Size = new System.Drawing.Size(100, 20);
            this.userTxtBox.TabIndex = 7;
            // 
            // passTxtBox
            // 
            this.passTxtBox.Location = new System.Drawing.Point(96, 103);
            this.passTxtBox.Name = "passTxtBox";
            this.passTxtBox.PasswordChar = '*';
            this.passTxtBox.Size = new System.Drawing.Size(100, 20);
            this.passTxtBox.TabIndex = 8;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(225, 172);
            this.Controls.Add(this.passTxtBox);
            this.Controls.Add(this.userTxtBox);
            this.Controls.Add(this.databaseTxtBox);
            this.Controls.Add(this.SrvrTxtBox);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.usernameLbl);
            this.Controls.Add(this.databaseLbl);
            this.Controls.Add(this.SrvrLbl);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SrvrLbl;
        private System.Windows.Forms.Label databaseLbl;
        private System.Windows.Forms.Label usernameLbl;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.TextBox SrvrTxtBox;
        private System.Windows.Forms.TextBox databaseTxtBox;
        private System.Windows.Forms.TextBox userTxtBox;
        private System.Windows.Forms.TextBox passTxtBox;
    }
}