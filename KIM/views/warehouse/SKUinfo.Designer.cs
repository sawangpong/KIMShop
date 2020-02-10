namespace KIM.views.warehouse
{
    partial class SKUinfo
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
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbMode = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtSKUCode = new System.Windows.Forms.TextBox();
            this.lbSKUCode = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtSKUDetail = new System.Windows.Forms.TextBox();
            this.lbSKUDetail = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtConvertFactor = new System.Windows.Forms.TextBox();
            this.lbConvertFactor = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 166);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(532, 55);
            this.panel1.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSave.Location = new System.Drawing.Point(312, 10);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(105, 35);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.Location = new System.Drawing.Point(417, 10);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(105, 35);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.lbMode);
            this.panel2.Controls.Add(this.lbTitle);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(2);
            this.panel2.Size = new System.Drawing.Size(532, 55);
            this.panel2.TabIndex = 1;
            // 
            // lbMode
            // 
            this.lbMode.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbMode.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbMode.ForeColor = System.Drawing.Color.Yellow;
            this.lbMode.Location = new System.Drawing.Point(2, 2);
            this.lbMode.Name = "lbMode";
            this.lbMode.Size = new System.Drawing.Size(192, 51);
            this.lbMode.TabIndex = 1;
            this.lbMode.Text = "Add";
            this.lbMode.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lbTitle
            // 
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbTitle.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(374, 2);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(156, 51);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Stock Unit Info.";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtSKUCode);
            this.panel3.Controls.Add(this.lbSKUCode);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 55);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(2);
            this.panel3.Size = new System.Drawing.Size(532, 30);
            this.panel3.TabIndex = 2;
            // 
            // txtSKUCode
            // 
            this.txtSKUCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSKUCode.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtSKUCode.Location = new System.Drawing.Point(168, 2);
            this.txtSKUCode.MaxLength = 10;
            this.txtSKUCode.Name = "txtSKUCode";
            this.txtSKUCode.Size = new System.Drawing.Size(111, 25);
            this.txtSKUCode.TabIndex = 1;
            this.txtSKUCode.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // lbSKUCode
            // 
            this.lbSKUCode.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbSKUCode.Location = new System.Drawing.Point(2, 2);
            this.lbSKUCode.Name = "lbSKUCode";
            this.lbSKUCode.Size = new System.Drawing.Size(166, 26);
            this.lbSKUCode.TabIndex = 0;
            this.lbSKUCode.Text = "SKU Code";
            this.lbSKUCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtSKUDetail);
            this.panel4.Controls.Add(this.lbSKUDetail);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 85);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(2);
            this.panel4.Size = new System.Drawing.Size(532, 30);
            this.panel4.TabIndex = 3;
            // 
            // txtSKUDetail
            // 
            this.txtSKUDetail.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtSKUDetail.Location = new System.Drawing.Point(168, 2);
            this.txtSKUDetail.MaxLength = 150;
            this.txtSKUDetail.Name = "txtSKUDetail";
            this.txtSKUDetail.Size = new System.Drawing.Size(332, 25);
            this.txtSKUDetail.TabIndex = 2;
            this.txtSKUDetail.TextChanged += new System.EventHandler(this.txt_TextChanged);
            // 
            // lbSKUDetail
            // 
            this.lbSKUDetail.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbSKUDetail.Location = new System.Drawing.Point(2, 2);
            this.lbSKUDetail.Name = "lbSKUDetail";
            this.lbSKUDetail.Size = new System.Drawing.Size(166, 26);
            this.lbSKUDetail.TabIndex = 1;
            this.lbSKUDetail.Text = "Description:";
            this.lbSKUDetail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtConvertFactor);
            this.panel5.Controls.Add(this.lbConvertFactor);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 115);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(2);
            this.panel5.Size = new System.Drawing.Size(532, 30);
            this.panel5.TabIndex = 4;
            // 
            // txtConvertFactor
            // 
            this.txtConvertFactor.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtConvertFactor.Location = new System.Drawing.Point(168, 2);
            this.txtConvertFactor.MaxLength = 10;
            this.txtConvertFactor.Name = "txtConvertFactor";
            this.txtConvertFactor.Size = new System.Drawing.Size(111, 25);
            this.txtConvertFactor.TabIndex = 2;
            this.txtConvertFactor.TextChanged += new System.EventHandler(this.txt_TextChanged);
            this.txtConvertFactor.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating);
            // 
            // lbConvertFactor
            // 
            this.lbConvertFactor.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbConvertFactor.Location = new System.Drawing.Point(2, 2);
            this.lbConvertFactor.Name = "lbConvertFactor";
            this.lbConvertFactor.Size = new System.Drawing.Size(166, 26);
            this.lbConvertFactor.TabIndex = 1;
            this.lbConvertFactor.Text = "Convert factor:";
            this.lbConvertFactor.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // SKUinfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(532, 221);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "SKUinfo";
            this.Text = "Stock unit info.";
            this.Load += new System.EventHandler(this.SKUinfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtSKUCode;
        private System.Windows.Forms.Label lbSKUCode;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbSKUDetail;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lbConvertFactor;
        private System.Windows.Forms.TextBox txtSKUDetail;
        private System.Windows.Forms.TextBox txtConvertFactor;
        private System.Windows.Forms.Label lbMode;
    }
}