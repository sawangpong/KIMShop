namespace KIM.views.Master
{
    partial class ExchangeInfo
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
            this.lbTitle = new System.Windows.Forms.Label();
            this.lbMode = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtCurCode = new System.Windows.Forms.TextBox();
            this.lbCode = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.dtpExchDate = new System.Windows.Forms.DateTimePicker();
            this.lbExchDate = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.txtExchangeRate = new System.Windows.Forms.TextBox();
            this.lbExchangeRate = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dtpExpire = new System.Windows.Forms.DateTimePicker();
            this.lbExpire = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtDayValid = new System.Windows.Forms.TextBox();
            this.lbValid = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel10.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 261);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(15, 5, 15, 15);
            this.panel1.Size = new System.Drawing.Size(476, 55);
            this.panel1.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSave.Location = new System.Drawing.Point(255, 5);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(103, 35);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.Location = new System.Drawing.Point(358, 5);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(103, 35);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.lbTitle);
            this.panel2.Controls.Add(this.lbMode);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(2);
            this.panel2.Size = new System.Drawing.Size(476, 52);
            this.panel2.TabIndex = 1;
            // 
            // lbTitle
            // 
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbTitle.Font = new System.Drawing.Font("Leelawadee UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(2, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(370, 41);
            this.lbTitle.TabIndex = 2;
            this.lbTitle.Text = "Exchange rate Information";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lbMode
            // 
            this.lbMode.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbMode.Font = new System.Drawing.Font("Leelawadee UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMode.ForeColor = System.Drawing.Color.Yellow;
            this.lbMode.Location = new System.Drawing.Point(372, 2);
            this.lbMode.Name = "lbMode";
            this.lbMode.Size = new System.Drawing.Size(102, 48);
            this.lbMode.TabIndex = 1;
            this.lbMode.Text = "mode";
            this.lbMode.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 52);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(476, 36);
            this.panel3.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtCurCode);
            this.panel5.Controls.Add(this.lbCode);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 88);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(2);
            this.panel5.Size = new System.Drawing.Size(476, 32);
            this.panel5.TabIndex = 3;
            // 
            // txtCurCode
            // 
            this.txtCurCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCurCode.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtCurCode.Location = new System.Drawing.Point(173, 2);
            this.txtCurCode.MaxLength = 10;
            this.txtCurCode.Name = "txtCurCode";
            this.txtCurCode.ReadOnly = true;
            this.txtCurCode.Size = new System.Drawing.Size(67, 25);
            this.txtCurCode.TabIndex = 1;
            // 
            // lbCode
            // 
            this.lbCode.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbCode.Location = new System.Drawing.Point(2, 2);
            this.lbCode.Name = "lbCode";
            this.lbCode.Size = new System.Drawing.Size(171, 28);
            this.lbCode.TabIndex = 0;
            this.lbCode.Text = "Currency code:";
            this.lbCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.dtpExchDate);
            this.panel10.Controls.Add(this.lbExchDate);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 120);
            this.panel10.Name = "panel10";
            this.panel10.Padding = new System.Windows.Forms.Padding(2);
            this.panel10.Size = new System.Drawing.Size(476, 32);
            this.panel10.TabIndex = 8;
            // 
            // dtpExchDate
            // 
            this.dtpExchDate.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtpExchDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExchDate.Location = new System.Drawing.Point(173, 2);
            this.dtpExchDate.Name = "dtpExchDate";
            this.dtpExchDate.Size = new System.Drawing.Size(143, 25);
            this.dtpExchDate.TabIndex = 2;
            // 
            // lbExchDate
            // 
            this.lbExchDate.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbExchDate.Location = new System.Drawing.Point(2, 2);
            this.lbExchDate.Name = "lbExchDate";
            this.lbExchDate.Size = new System.Drawing.Size(171, 28);
            this.lbExchDate.TabIndex = 1;
            this.lbExchDate.Text = "Exchange date :";
            this.lbExchDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.txtExchangeRate);
            this.panel7.Controls.Add(this.lbExchangeRate);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(0, 152);
            this.panel7.Name = "panel7";
            this.panel7.Padding = new System.Windows.Forms.Padding(2);
            this.panel7.Size = new System.Drawing.Size(476, 32);
            this.panel7.TabIndex = 11;
            // 
            // txtExchangeRate
            // 
            this.txtExchangeRate.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtExchangeRate.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtExchangeRate.Location = new System.Drawing.Point(173, 2);
            this.txtExchangeRate.MaxLength = 10;
            this.txtExchangeRate.Name = "txtExchangeRate";
            this.txtExchangeRate.Size = new System.Drawing.Size(97, 25);
            this.txtExchangeRate.TabIndex = 1;
            this.txtExchangeRate.TabStop = false;
            this.txtExchangeRate.WordWrap = false;
            this.txtExchangeRate.TextChanged += new System.EventHandler(this.txtExchangeRate_TextChanged);
            this.txtExchangeRate.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating);
            // 
            // lbExchangeRate
            // 
            this.lbExchangeRate.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbExchangeRate.Location = new System.Drawing.Point(2, 2);
            this.lbExchangeRate.Name = "lbExchangeRate";
            this.lbExchangeRate.Size = new System.Drawing.Size(171, 28);
            this.lbExchangeRate.TabIndex = 0;
            this.lbExchangeRate.Text = "Rate (KMR):";
            this.lbExchangeRate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dtpExpire);
            this.panel6.Controls.Add(this.lbExpire);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel6.Location = new System.Drawing.Point(0, 216);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(2);
            this.panel6.Size = new System.Drawing.Size(476, 32);
            this.panel6.TabIndex = 13;
            // 
            // dtpExpire
            // 
            this.dtpExpire.Dock = System.Windows.Forms.DockStyle.Left;
            this.dtpExpire.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpExpire.Location = new System.Drawing.Point(173, 2);
            this.dtpExpire.Name = "dtpExpire";
            this.dtpExpire.Size = new System.Drawing.Size(143, 25);
            this.dtpExpire.TabIndex = 2;
            // 
            // lbExpire
            // 
            this.lbExpire.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbExpire.Location = new System.Drawing.Point(2, 2);
            this.lbExpire.Name = "lbExpire";
            this.lbExpire.Size = new System.Drawing.Size(171, 28);
            this.lbExpire.TabIndex = 1;
            this.lbExpire.Text = "Expire date :";
            this.lbExpire.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtDayValid);
            this.panel4.Controls.Add(this.lbValid);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 184);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(2);
            this.panel4.Size = new System.Drawing.Size(476, 32);
            this.panel4.TabIndex = 12;
            // 
            // txtDayValid
            // 
            this.txtDayValid.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDayValid.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtDayValid.Location = new System.Drawing.Point(173, 2);
            this.txtDayValid.MaxLength = 3;
            this.txtDayValid.Name = "txtDayValid";
            this.txtDayValid.Size = new System.Drawing.Size(67, 25);
            this.txtDayValid.TabIndex = 1;
            this.txtDayValid.WordWrap = false;
            this.txtDayValid.TextChanged += new System.EventHandler(this.txtDayValid_TextChanged);
            this.txtDayValid.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating);
            // 
            // lbValid
            // 
            this.lbValid.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbValid.Location = new System.Drawing.Point(2, 2);
            this.lbValid.Name = "lbValid";
            this.lbValid.Size = new System.Drawing.Size(171, 28);
            this.lbValid.TabIndex = 0;
            this.lbValid.Text = "Valid day(s):";
            this.lbValid.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // ExchangeInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(476, 316);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ExchangeInfo";
            this.Text = "Exchange rate Information";
            this.Load += new System.EventHandler(this.ExchangeInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Label lbMode;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox txtCurCode;
        private System.Windows.Forms.Label lbCode;
        private System.Windows.Forms.DateTimePicker dtpExchDate;
        private System.Windows.Forms.Label lbExchDate;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.TextBox txtExchangeRate;
        private System.Windows.Forms.Label lbExchangeRate;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DateTimePicker dtpExpire;
        private System.Windows.Forms.Label lbExpire;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtDayValid;
        private System.Windows.Forms.Label lbValid;
    }
}