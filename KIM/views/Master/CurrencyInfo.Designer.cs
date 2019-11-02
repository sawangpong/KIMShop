namespace KIM.views.Master
{
	partial class CurrencyInfo
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
            this.txtCurCode = new System.Windows.Forms.TextBox();
            this.lbCurCode = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtdetail = new System.Windows.Forms.TextBox();
            this.lbCurDetail = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSave);
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 137);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(18);
            this.panel1.Size = new System.Drawing.Size(707, 77);
            this.panel1.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSave.Location = new System.Drawing.Point(413, 18);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(138, 41);
            this.btnSave.TabIndex = 1;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.Location = new System.Drawing.Point(551, 18);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(138, 41);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "&Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
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
            this.panel2.Size = new System.Drawing.Size(707, 60);
            this.panel2.TabIndex = 1;
            // 
            // lbTitle
            // 
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbTitle.Font = new System.Drawing.Font("Leelawadee UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbTitle.ForeColor = System.Drawing.Color.Yellow;
            this.lbTitle.Location = new System.Drawing.Point(2, 9);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(599, 49);
            this.lbTitle.TabIndex = 1;
            this.lbTitle.Text = "Currency  information";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // lbMode
            // 
            this.lbMode.Dock = System.Windows.Forms.DockStyle.Right;
            this.lbMode.Font = new System.Drawing.Font("Leelawadee UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbMode.ForeColor = System.Drawing.Color.White;
            this.lbMode.Location = new System.Drawing.Point(601, 2);
            this.lbMode.Name = "lbMode";
            this.lbMode.Size = new System.Drawing.Size(104, 56);
            this.lbMode.TabIndex = 0;
            this.lbMode.Text = "xx";
            this.lbMode.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtCurCode);
            this.panel3.Controls.Add(this.lbCurCode);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 60);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(2);
            this.panel3.Size = new System.Drawing.Size(707, 32);
            this.panel3.TabIndex = 2;
            // 
            // txtCurCode
            // 
            this.txtCurCode.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCurCode.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtCurCode.Location = new System.Drawing.Point(185, 2);
            this.txtCurCode.MaxLength = 10;
            this.txtCurCode.Name = "txtCurCode";
            this.txtCurCode.Size = new System.Drawing.Size(123, 25);
            this.txtCurCode.TabIndex = 1;
            this.txtCurCode.TextChanged += new System.EventHandler(this.txtCurCode_TextChanged);
            // 
            // lbCurCode
            // 
            this.lbCurCode.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbCurCode.Location = new System.Drawing.Point(2, 2);
            this.lbCurCode.Name = "lbCurCode";
            this.lbCurCode.Size = new System.Drawing.Size(183, 28);
            this.lbCurCode.TabIndex = 0;
            this.lbCurCode.Text = "Code :";
            this.lbCurCode.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtdetail);
            this.panel4.Controls.Add(this.lbCurDetail);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 92);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(2);
            this.panel4.Size = new System.Drawing.Size(707, 32);
            this.panel4.TabIndex = 3;
            // 
            // txtdetail
            // 
            this.txtdetail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtdetail.Dock = System.Windows.Forms.DockStyle.Left;
            this.txtdetail.Location = new System.Drawing.Point(185, 2);
            this.txtdetail.MaxLength = 150;
            this.txtdetail.Name = "txtdetail";
            this.txtdetail.Size = new System.Drawing.Size(456, 25);
            this.txtdetail.TabIndex = 1;
            // 
            // lbCurDetail
            // 
            this.lbCurDetail.Dock = System.Windows.Forms.DockStyle.Left;
            this.lbCurDetail.Location = new System.Drawing.Point(2, 2);
            this.lbCurDetail.Name = "lbCurDetail";
            this.lbCurDetail.Size = new System.Drawing.Size(183, 28);
            this.lbCurDetail.TabIndex = 0;
            this.lbCurDetail.Text = "Description :";
            this.lbCurDetail.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CurrencyInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(707, 214);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CurrencyInfo";
            this.Text = "Currency Info";
            this.Load += new System.EventHandler(this.CurrencyInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
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
		private System.Windows.Forms.TextBox txtCurCode;
		private System.Windows.Forms.Label lbCurCode;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.TextBox txtdetail;
		private System.Windows.Forms.Label lbCurDetail;
	}
}