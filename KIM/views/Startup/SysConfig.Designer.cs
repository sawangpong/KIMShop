namespace KIM.views.Startup
{
    partial class SysConfig
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
            this.components = new System.ComponentModel.Container();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnShowPassword = new System.Windows.Forms.Button();
            this.txtCompanyCode = new System.Windows.Forms.TextBox();
            this.txtServerName = new System.Windows.Forms.TextBox();
            this.lbServer = new System.Windows.Forms.Label();
            this.txtDatabaseName = new System.Windows.Forms.TextBox();
            this.lbDatabase = new System.Windows.Forms.Label();
            this.txtDbAdmin = new System.Windows.Forms.TextBox();
            this.lbDbAdmin = new System.Windows.Forms.Label();
            this.panel9 = new System.Windows.Forms.Panel();
            this.txtDbPassword = new System.Windows.Forms.TextBox();
            this.lbDBPassword = new System.Windows.Forms.Label();
            this.lbCompanyCode = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbMode = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.lbLangCode = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cbxLang = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel9.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel10.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShowPassword
            // 
            this.btnShowPassword.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnShowPassword.FlatAppearance.BorderSize = 0;
            this.btnShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShowPassword.Location = new System.Drawing.Point(482, 2);
            this.btnShowPassword.Name = "btnShowPassword";
            this.btnShowPassword.Size = new System.Drawing.Size(30, 26);
            this.btnShowPassword.TabIndex = 3;
            this.toolTip1.SetToolTip(this.btnShowPassword, "display password");
            this.btnShowPassword.UseVisualStyleBackColor = true;
            // 
            // txtCompanyCode
            // 
            this.txtCompanyCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCompanyCode.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtCompanyCode.Location = new System.Drawing.Point(272, 2);
            this.txtCompanyCode.MaxLength = 15;
            this.txtCompanyCode.Name = "txtCompanyCode";
            this.txtCompanyCode.Size = new System.Drawing.Size(210, 25);
            this.txtCompanyCode.TabIndex = 1;
            this.txtCompanyCode.TextChanged += new System.EventHandler(this.textChanged);
            // 
            // txtServerName
            // 
            this.txtServerName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtServerName.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtServerName.Location = new System.Drawing.Point(272, 2);
            this.txtServerName.MaxLength = 35;
            this.txtServerName.Name = "txtServerName";
            this.txtServerName.Size = new System.Drawing.Size(210, 25);
            this.txtServerName.TabIndex = 2;
            this.txtServerName.TextChanged += new System.EventHandler(this.textChanged);
            // 
            // lbServer
            // 
            this.lbServer.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbServer.Location = new System.Drawing.Point(2, 2);
            this.lbServer.Name = "lbServer";
            this.lbServer.Size = new System.Drawing.Size(270, 26);
            this.lbServer.TabIndex = 0;
            this.lbServer.Text = "Server name:";
            this.lbServer.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // txtDatabaseName
            // 
            this.txtDatabaseName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDatabaseName.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtDatabaseName.Location = new System.Drawing.Point(272, 2);
            this.txtDatabaseName.MaxLength = 35;
            this.txtDatabaseName.Name = "txtDatabaseName";
            this.txtDatabaseName.Size = new System.Drawing.Size(210, 25);
            this.txtDatabaseName.TabIndex = 2;
            this.txtDatabaseName.TextChanged += new System.EventHandler(this.textChanged);
            // 
            // lbDatabase
            // 
            this.lbDatabase.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbDatabase.Location = new System.Drawing.Point(2, 2);
            this.lbDatabase.Name = "lbDatabase";
            this.lbDatabase.Size = new System.Drawing.Size(270, 26);
            this.lbDatabase.TabIndex = 0;
            this.lbDatabase.Text = "Database name:";
            this.lbDatabase.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // txtDbAdmin
            // 
            this.txtDbAdmin.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtDbAdmin.Location = new System.Drawing.Point(272, 2);
            this.txtDbAdmin.MaxLength = 25;
            this.txtDbAdmin.Name = "txtDbAdmin";
            this.txtDbAdmin.Size = new System.Drawing.Size(210, 25);
            this.txtDbAdmin.TabIndex = 2;
            this.txtDbAdmin.TextChanged += new System.EventHandler(this.textChanged);
            // 
            // lbDbAdmin
            // 
            this.lbDbAdmin.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbDbAdmin.Location = new System.Drawing.Point(2, 2);
            this.lbDbAdmin.Name = "lbDbAdmin";
            this.lbDbAdmin.Size = new System.Drawing.Size(270, 26);
            this.lbDbAdmin.TabIndex = 0;
            this.lbDbAdmin.Text = "Database administrator:";
            this.lbDbAdmin.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.btnShowPassword);
            this.panel9.Controls.Add(this.txtDbPassword);
            this.panel9.Controls.Add(this.lbDBPassword);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(4, 124);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(2);
            this.panel9.Size = new System.Drawing.Size(546, 30);
            this.panel9.TabIndex = 4;
            // 
            // txtDbPassword
            // 
            this.txtDbPassword.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtDbPassword.Location = new System.Drawing.Point(272, 2);
            this.txtDbPassword.MaxLength = 15;
            this.txtDbPassword.Name = "txtDbPassword";
            this.txtDbPassword.Size = new System.Drawing.Size(210, 25);
            this.txtDbPassword.TabIndex = 2;
            this.txtDbPassword.UseSystemPasswordChar = true;
            // 
            // lbDBPassword
            // 
            this.lbDBPassword.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbDBPassword.Location = new System.Drawing.Point(2, 2);
            this.lbDBPassword.Name = "lbDBPassword";
            this.lbDBPassword.Size = new System.Drawing.Size(270, 26);
            this.lbDBPassword.TabIndex = 0;
            this.lbDBPassword.Text = "Database password:";
            this.lbDBPassword.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // lbCompanyCode
            // 
            this.lbCompanyCode.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbCompanyCode.Location = new System.Drawing.Point(2, 2);
            this.lbCompanyCode.Name = "lbCompanyCode";
            this.lbCompanyCode.Size = new System.Drawing.Size(270, 26);
            this.lbCompanyCode.TabIndex = 0;
            this.lbCompanyCode.Text = "Company code:";
            this.lbCompanyCode.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.txtDbAdmin);
            this.panel8.Controls.Add(this.lbDbAdmin);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel8.Location = new System.Drawing.Point(4, 94);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(2);
            this.panel8.Size = new System.Drawing.Size(546, 30);
            this.panel8.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel10);
            this.panel4.Controls.Add(this.panel9);
            this.panel4.Controls.Add(this.panel8);
            this.panel4.Controls.Add(this.panel7);
            this.panel4.Controls.Add(this.panel6);
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 55);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(4);
            this.panel4.Size = new System.Drawing.Size(554, 218);
            this.panel4.TabIndex = 5;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txtDatabaseName);
            this.panel7.Controls.Add(this.lbDatabase);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(4, 64);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(2);
            this.panel7.Size = new System.Drawing.Size(546, 30);
            this.panel7.TabIndex = 2;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.txtServerName);
            this.panel6.Controls.Add(this.lbServer);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(4, 34);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(2);
            this.panel6.Size = new System.Drawing.Size(546, 30);
            this.panel6.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtCompanyCode);
            this.panel5.Controls.Add(this.lbCompanyCode);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(4, 4);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(2);
            this.panel5.Size = new System.Drawing.Size(546, 30);
            this.panel5.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.Location = new System.Drawing.Point(350, 10);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(116, 34);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSave.Location = new System.Drawing.Point(88, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(116, 34);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSave);
            this.panel3.Controls.Add(this.btnCancel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 273);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(88, 10, 88, 10);
            this.panel3.Size = new System.Drawing.Size(554, 54);
            this.panel3.TabIndex = 4;
            // 
            // lbMode
            // 
            this.lbMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbMode.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMode.ForeColor = System.Drawing.Color.Red;
            this.lbMode.Location = new System.Drawing.Point(2, 2);
            this.lbMode.Name = "lbMode";
            this.lbMode.Size = new System.Drawing.Size(126, 47);
            this.lbMode.TabIndex = 0;
            this.lbMode.Text = "Create";
            this.lbMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lbMode);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(422, 2);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(2);
            this.panel2.Size = new System.Drawing.Size(130, 51);
            this.panel2.TabIndex = 0;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(2, 28);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(192, 25);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "System Configuration";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.lbTitle);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(2);
            this.panel1.Size = new System.Drawing.Size(554, 55);
            this.panel1.TabIndex = 3;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.lbLangCode);
            this.panel10.Controls.Add(this.label16);
            this.panel10.Controls.Add(this.cbxLang);
            this.panel10.Controls.Add(this.label5);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(4, 154);
            this.panel10.Name = "panel10";
            this.panel10.Padding = new System.Windows.Forms.Padding(2);
            this.panel10.Size = new System.Drawing.Size(546, 30);
            this.panel10.TabIndex = 5;
            // 
            // lbLangCode
            // 
            this.lbLangCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbLangCode.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbLangCode.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbLangCode.Location = new System.Drawing.Point(433, 2);
            this.lbLangCode.Name = "lbLangCode";
            this.lbLangCode.Size = new System.Drawing.Size(49, 26);
            this.lbLangCode.TabIndex = 15;
            this.lbLangCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.Dock = System.Windows.Forms.DockStyle.Left;
            this.label16.Location = new System.Drawing.Point(423, 2);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(10, 26);
            this.label16.TabIndex = 14;
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cbxLang
            // 
            this.cbxLang.Dock = System.Windows.Forms.DockStyle.Left;
            this.cbxLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxLang.FormattingEnabled = true;
            this.cbxLang.Location = new System.Drawing.Point(272, 2);
            this.cbxLang.Name = "cbxLang";
            this.cbxLang.Size = new System.Drawing.Size(151, 25);
            this.cbxLang.TabIndex = 1;
            this.cbxLang.SelectedValueChanged += new System.EventHandler(this.cbxLang_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.Dock = System.Windows.Forms.DockStyle.Left;
            this.label5.Location = new System.Drawing.Point(2, 2);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(270, 26);
            this.label5.TabIndex = 0;
            this.label5.Text = "Default language:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SysConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(554, 327);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SysConfig";
            this.Text = "System Configuration";
            this.Load += new System.EventHandler(this.SysConfig_Load);
            this.panel9.ResumeLayout(false);
            this.panel9.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnShowPassword;
        private System.Windows.Forms.TextBox txtCompanyCode;
        private System.Windows.Forms.TextBox txtServerName;
        private System.Windows.Forms.Label lbServer;
        private System.Windows.Forms.TextBox txtDatabaseName;
        private System.Windows.Forms.Label lbDatabase;
        private System.Windows.Forms.TextBox txtDbAdmin;
        private System.Windows.Forms.Label lbDbAdmin;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.TextBox txtDbPassword;
        private System.Windows.Forms.Label lbDBPassword;
        private System.Windows.Forms.Label lbCompanyCode;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbMode;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.Label lbLangCode;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.ComboBox cbxLang;
        private System.Windows.Forms.Label label5;
    }
}