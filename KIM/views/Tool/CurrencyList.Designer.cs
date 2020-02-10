namespace KIM.views.Tool
{
	partial class CurrencyList
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.pnlCmd = new System.Windows.Forms.Panel();
            this.btnExchange = new System.Windows.Forms.Button();
            this.btnblank = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.pnlTop.SuspendLayout();
            this.pnlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.pnlCmd.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnlTop.Controls.Add(this.lbTitle);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Padding = new System.Windows.Forms.Padding(2);
            this.pnlTop.Size = new System.Drawing.Size(739, 56);
            this.pnlTop.TabIndex = 0;
            // 
            // lbTitle
            // 
            this.lbTitle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbTitle.Font = new System.Drawing.Font("Leelawadee UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbTitle.ForeColor = System.Drawing.Color.White;
            this.lbTitle.Location = new System.Drawing.Point(2, 11);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(735, 43);
            this.lbTitle.TabIndex = 0;
            this.lbTitle.Text = "Currency List";
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // pnlBody
            // 
            this.pnlBody.Controls.Add(this.dgv);
            this.pnlBody.Controls.Add(this.pnlCmd);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 56);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Padding = new System.Windows.Forms.Padding(2);
            this.pnlBody.Size = new System.Drawing.Size(739, 389);
            this.pnlBody.TabIndex = 1;
            // 
            // dgv
            // 
            this.dgv.BackgroundColor = System.Drawing.Color.White;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv.Location = new System.Drawing.Point(2, 2);
            this.dgv.Name = "dgv";
            this.dgv.RowHeadersWidth = 51;
            this.dgv.RowTemplate.Height = 24;
            this.dgv.Size = new System.Drawing.Size(585, 385);
            this.dgv.TabIndex = 1;
            this.dgv.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellEnter);
            this.dgv.DoubleClick += new System.EventHandler(this.dgv_DoubleClick);
            // 
            // pnlCmd
            // 
            this.pnlCmd.Controls.Add(this.btnExchange);
            this.pnlCmd.Controls.Add(this.btnblank);
            this.pnlCmd.Controls.Add(this.btnClose);
            this.pnlCmd.Controls.Add(this.btnRefresh);
            this.pnlCmd.Controls.Add(this.btnDelete);
            this.pnlCmd.Controls.Add(this.btnEdit);
            this.pnlCmd.Controls.Add(this.btnAdd);
            this.pnlCmd.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlCmd.Location = new System.Drawing.Point(587, 2);
            this.pnlCmd.Name = "pnlCmd";
            this.pnlCmd.Padding = new System.Windows.Forms.Padding(2);
            this.pnlCmd.Size = new System.Drawing.Size(150, 385);
            this.pnlCmd.TabIndex = 0;
            // 
            // btnExchange
            // 
            this.btnExchange.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExchange.Location = new System.Drawing.Point(2, 144);
            this.btnExchange.Name = "btnExchange";
            this.btnExchange.Size = new System.Drawing.Size(146, 32);
            this.btnExchange.TabIndex = 7;
            this.btnExchange.Text = "Exchange";
            this.btnExchange.UseVisualStyleBackColor = true;
            this.btnExchange.Click += new System.EventHandler(this.btnExchange_Click);
            // 
            // btnblank
            // 
            this.btnblank.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnblank.Enabled = false;
            this.btnblank.FlatAppearance.BorderSize = 0;
            this.btnblank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnblank.Location = new System.Drawing.Point(2, 130);
            this.btnblank.Name = "btnblank";
            this.btnblank.Size = new System.Drawing.Size(146, 14);
            this.btnblank.TabIndex = 6;
            this.btnblank.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnClose.Location = new System.Drawing.Point(2, 351);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(146, 32);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRefresh.Location = new System.Drawing.Point(2, 98);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(146, 32);
            this.btnRefresh.TabIndex = 3;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDelete.Enabled = false;
            this.btnDelete.Location = new System.Drawing.Point(2, 66);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(146, 32);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEdit.Location = new System.Drawing.Point(2, 34);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(146, 32);
            this.btnEdit.TabIndex = 1;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdd.Location = new System.Drawing.Point(2, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(146, 32);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // CurrencyList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 445);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlTop);
            this.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "CurrencyList";
            this.Text = "Currency Box";
            this.Load += new System.EventHandler(this.CurrencyListcs_Load);
            this.pnlTop.ResumeLayout(false);
            this.pnlBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.pnlCmd.ResumeLayout(false);
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlTop;
		private System.Windows.Forms.Label lbTitle;
		private System.Windows.Forms.Panel pnlBody;
		private System.Windows.Forms.DataGridView dgv;
		private System.Windows.Forms.Panel pnlCmd;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnRefresh;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnEdit;
		private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExchange;
        private System.Windows.Forms.Button btnblank;
    }
}