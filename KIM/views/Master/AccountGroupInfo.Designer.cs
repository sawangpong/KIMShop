namespace KIM.views.Master
{
    partial class AccountGroupInfo
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.lbMode = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtAccountName = new System.Windows.Forms.TextBox();
            this.lbCatName = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtAccCode = new System.Windows.Forms.TextBox();
            this.lbAccountCode = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlHeader.Controls.Add(this.lbMode);
            this.pnlHeader.Controls.Add(this.lbTitle);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(2);
            this.pnlHeader.Size = new System.Drawing.Size(508, 55);
            this.pnlHeader.TabIndex = 2;
            // 
            // lbMode
            // 
            this.lbMode.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbMode.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbMode.ForeColor = System.Drawing.Color.Yellow;
            this.lbMode.Location = new System.Drawing.Point(2, 2);
            this.lbMode.Name = "lbMode";
            this.lbMode.Size = new System.Drawing.Size(139, 51);
            this.lbMode.TabIndex = 2;
            this.lbMode.Text = "Add";
            this.lbMode.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lbTitle
            // 
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbTitle.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(367, 2);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(139, 51);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Account set";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 150);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(508, 54);
            this.panel1.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSave.Location = new System.Drawing.Point(320, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(89, 34);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.Location = new System.Drawing.Point(409, 10);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 34);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtAccountName);
            this.panel3.Controls.Add(this.lbCatName);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 85);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(2);
            this.panel3.Size = new System.Drawing.Size(508, 30);
            this.panel3.TabIndex = 6;
            // 
            // txtAccountName
            // 
            this.txtAccountName.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtAccountName.Location = new System.Drawing.Point(141, 2);
            this.txtAccountName.MaxLength = 80;
            this.txtAccountName.Name = "txtAccountName";
            this.txtAccountName.Size = new System.Drawing.Size(360, 25);
            this.txtAccountName.TabIndex = 2;
            this.txtAccountName.Tag = "CatName";
            this.txtAccountName.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // lbCatName
            // 
            this.lbCatName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbCatName.Location = new System.Drawing.Point(2, 2);
            this.lbCatName.Name = "lbCatName";
            this.lbCatName.Size = new System.Drawing.Size(139, 26);
            this.lbCatName.TabIndex = 1;
            this.lbCatName.Text = "Account detail:";
            this.lbCatName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtAccCode);
            this.panel2.Controls.Add(this.lbAccountCode);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 55);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(2);
            this.panel2.Size = new System.Drawing.Size(508, 30);
            this.panel2.TabIndex = 5;
            // 
            // txtAccCode
            // 
            this.txtAccCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtAccCode.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtAccCode.Location = new System.Drawing.Point(141, 2);
            this.txtAccCode.MaxLength = 10;
            this.txtAccCode.Name = "txtAccCode";
            this.txtAccCode.Size = new System.Drawing.Size(136, 25);
            this.txtAccCode.TabIndex = 1;
            this.txtAccCode.Tag = "CatCode";
            this.txtAccCode.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // lbAccountCode
            // 
            this.lbAccountCode.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbAccountCode.Location = new System.Drawing.Point(2, 2);
            this.lbAccountCode.Name = "lbAccountCode";
            this.lbAccountCode.Size = new System.Drawing.Size(139, 26);
            this.lbAccountCode.TabIndex = 0;
            this.lbAccountCode.Text = "Account code:";
            this.lbAccountCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AccountGroupInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(508, 204);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AccountGroupInfo";
            this.Text = "Accout Set Info";
            this.Load += new System.EventHandler(this.AccoutGroupInfo_Load);
            this.pnlHeader.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lbMode;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtAccountName;
        private System.Windows.Forms.Label lbCatName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtAccCode;
        private System.Windows.Forms.Label lbAccountCode;
    }
}