namespace KIM.views.warehouse
{
    partial class ItemCatInfo
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
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtCatCode = new System.Windows.Forms.TextBox();
            this.lbCatCode = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtCatName = new System.Windows.Forms.TextBox();
            this.lbCatName = new System.Windows.Forms.Label();
            this.pnlHeader.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlHeader.Controls.Add(this.lbMode);
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(2);
            this.pnlHeader.Size = new System.Drawing.Size(538, 55);
            this.pnlHeader.TabIndex = 1;
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
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(397, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 51);
            this.label1.TabIndex = 1;
            this.label1.Text = "Item Category";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 139);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(538, 54);
            this.panel1.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSave.Location = new System.Drawing.Point(350, 10);
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
            this.btnCancel.Location = new System.Drawing.Point(439, 10);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(89, 34);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txtCatCode);
            this.panel2.Controls.Add(this.lbCatCode);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 55);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(2);
            this.panel2.Size = new System.Drawing.Size(538, 30);
            this.panel2.TabIndex = 3;
            // 
            // txtCatCode
            // 
            this.txtCatCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCatCode.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtCatCode.Location = new System.Drawing.Point(141, 2);
            this.txtCatCode.MaxLength = 10;
            this.txtCatCode.Name = "txtCatCode";
            this.txtCatCode.Size = new System.Drawing.Size(103, 25);
            this.txtCatCode.TabIndex = 1;
            this.txtCatCode.Tag = "CatCode";
            this.txtCatCode.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // lbCatCode
            // 
            this.lbCatCode.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbCatCode.Location = new System.Drawing.Point(2, 2);
            this.lbCatCode.Name = "lbCatCode";
            this.lbCatCode.Size = new System.Drawing.Size(139, 26);
            this.lbCatCode.TabIndex = 0;
            this.lbCatCode.Text = "Category code:";
            this.lbCatCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtCatName);
            this.panel3.Controls.Add(this.lbCatName);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 85);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(2);
            this.panel3.Size = new System.Drawing.Size(538, 30);
            this.panel3.TabIndex = 4;
            // 
            // txtCatName
            // 
            this.txtCatName.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtCatName.Location = new System.Drawing.Point(141, 2);
            this.txtCatName.MaxLength = 80;
            this.txtCatName.Name = "txtCatName";
            this.txtCatName.Size = new System.Drawing.Size(360, 25);
            this.txtCatName.TabIndex = 2;
            this.txtCatName.Tag = "CatName";
            this.txtCatName.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // lbCatName
            // 
            this.lbCatName.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbCatName.Location = new System.Drawing.Point(2, 2);
            this.lbCatName.Name = "lbCatName";
            this.lbCatName.Size = new System.Drawing.Size(139, 26);
            this.lbCatName.TabIndex = 1;
            this.lbCatName.Text = "Category detail:";
            this.lbCatName.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ItemCatInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(538, 193);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlHeader);
            this.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ItemCatInfo";
            this.Text = "ItemCatInfo";
            this.Load += new System.EventHandler(this.ItemCatInfo_Load);
            this.pnlHeader.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label lbMode;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbCatCode;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbCatName;
        private System.Windows.Forms.TextBox txtCatCode;
        private System.Windows.Forms.TextBox txtCatName;
    }
}