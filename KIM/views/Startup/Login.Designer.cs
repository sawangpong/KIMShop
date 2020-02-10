namespace KIM.views.Startup
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbConnectionString = new System.Windows.Forms.Label();
            this.lbLogin = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnLogin = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbkConfig = new System.Windows.Forms.LinkLabel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lbConnectionString);
            this.panel1.Controls.Add(this.lbLogin);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(411, 74);
            this.panel1.TabIndex = 0;
            // 
            // lbConnectionString
            // 
            this.lbConnectionString.BackColor = System.Drawing.Color.Transparent;
            this.lbConnectionString.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbConnectionString.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbConnectionString.ForeColor = System.Drawing.Color.Yellow;
            this.lbConnectionString.Location = new System.Drawing.Point(0, 54);
            this.lbConnectionString.Name = "lbConnectionString";
            this.lbConnectionString.Size = new System.Drawing.Size(411, 20);
            this.lbConnectionString.TabIndex = 1;
            this.lbConnectionString.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // lbLogin
            // 
            this.lbLogin.BackColor = System.Drawing.Color.Transparent;
            this.lbLogin.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbLogin.Font = new System.Drawing.Font("Leelawadee UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbLogin.ForeColor = System.Drawing.Color.White;
            this.lbLogin.Location = new System.Drawing.Point(0, 0);
            this.lbLogin.Name = "lbLogin";
            this.lbLogin.Size = new System.Drawing.Size(411, 47);
            this.lbLogin.TabIndex = 0;
            this.lbLogin.Text = "Login";
            this.lbLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.btnLogin);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(10, 203);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(50, 10, 50, 20);
            this.panel2.Size = new System.Drawing.Size(411, 65);
            this.panel2.TabIndex = 1;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.Location = new System.Drawing.Point(242, 10);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(119, 35);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnLogin
            // 
            this.btnLogin.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnLogin.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLogin.Location = new System.Drawing.Point(50, 10);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(119, 35);
            this.btnLogin.TabIndex = 0;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtPassword);
            this.panel4.Controls.Add(this.lbPassword);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(10, 124);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(2, 2, 50, 2);
            this.panel4.Size = new System.Drawing.Size(411, 40);
            this.panel4.TabIndex = 5;
            // 
            // txtPassword
            // 
            this.txtPassword.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtPassword.Location = new System.Drawing.Point(169, 11);
            this.txtPassword.MaxLength = 15;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(192, 27);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // lbPassword
            // 
            this.lbPassword.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbPassword.ForeColor = System.Drawing.Color.White;
            this.lbPassword.Location = new System.Drawing.Point(2, 2);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(167, 36);
            this.lbPassword.TabIndex = 1;
            this.lbPassword.Text = "Password";
            this.lbPassword.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtUserName);
            this.panel3.Controls.Add(this.lbUsername);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(10, 84);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(2, 2, 50, 2);
            this.panel3.Size = new System.Drawing.Size(411, 40);
            this.panel3.TabIndex = 4;
            // 
            // txtUserName
            // 
            this.txtUserName.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.txtUserName.Location = new System.Drawing.Point(169, 11);
            this.txtUserName.MaxLength = 50;
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(192, 27);
            this.txtUserName.TabIndex = 1;
            this.txtUserName.TextChanged += new System.EventHandler(this.txtUserName_TextChanged);
            // 
            // lbUsername
            // 
            this.lbUsername.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbUsername.ForeColor = System.Drawing.Color.White;
            this.lbUsername.Location = new System.Drawing.Point(2, 2);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(167, 36);
            this.lbUsername.TabIndex = 0;
            this.lbUsername.Text = "User name:";
            this.lbUsername.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lbkConfig
            // 
            this.lbkConfig.BackColor = System.Drawing.Color.Transparent;
            this.lbkConfig.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbkConfig.ForeColor = System.Drawing.Color.LemonChiffon;
            this.lbkConfig.LinkColor = System.Drawing.Color.NavajoWhite;
            this.lbkConfig.Location = new System.Drawing.Point(10, 168);
            this.lbkConfig.Name = "lbkConfig";
            this.lbkConfig.Size = new System.Drawing.Size(411, 35);
            this.lbkConfig.TabIndex = 6;
            this.lbkConfig.TabStop = true;
            this.lbkConfig.Text = "Change system configuration";
            this.lbkConfig.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lbkConfig.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbkConfig_LinkClicked);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(42)))), ((int)(((byte)(42)))));
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(431, 278);
            this.Controls.Add(this.lbkConfig);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Login";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.Label lbLogin;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.LinkLabel lbkConfig;
        private System.Windows.Forms.Label lbConnectionString;
    }
}