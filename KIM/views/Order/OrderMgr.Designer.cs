namespace KIM.views.Order
{
	partial class OrderMgr
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderMgr));
			this.pnlTop = new System.Windows.Forms.Panel();
			this.lbTitle = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pnlBody = new System.Windows.Forms.Panel();
			this.ts = new System.Windows.Forms.ToolStrip();
			this.dgv = new System.Windows.Forms.DataGridView();
			this.tsbtnAdd = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.tsbtnEdit = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.tsbtnDelete = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.tsbtnRefresh = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.tsbtnClose = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
			this.pnlTop.SuspendLayout();
			this.pnlBody.SuspendLayout();
			this.ts.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
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
			this.pnlTop.Size = new System.Drawing.Size(933, 55);
			this.pnlTop.TabIndex = 0;
			// 
			// lbTitle
			// 
			this.lbTitle.Dock = System.Windows.Forms.DockStyle.Right;
			this.lbTitle.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.lbTitle.ForeColor = System.Drawing.Color.White;
			this.lbTitle.Location = new System.Drawing.Point(747, 2);
			this.lbTitle.Name = "lbTitle";
			this.lbTitle.Size = new System.Drawing.Size(184, 51);
			this.lbTitle.TabIndex = 0;
			this.lbTitle.Text = "Order Manager";
			this.lbTitle.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// panel2
			// 
			this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel2.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.panel2.Location = new System.Drawing.Point(0, 568);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(933, 20);
			this.panel2.TabIndex = 1;
			// 
			// pnlBody
			// 
			this.pnlBody.Controls.Add(this.dgv);
			this.pnlBody.Controls.Add(this.ts);
			this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlBody.Location = new System.Drawing.Point(0, 55);
			this.pnlBody.Name = "pnlBody";
			this.pnlBody.Padding = new System.Windows.Forms.Padding(2);
			this.pnlBody.Size = new System.Drawing.Size(933, 513);
			this.pnlBody.TabIndex = 2;
			// 
			// ts
			// 
			this.ts.AutoSize = false;
			this.ts.Font = new System.Drawing.Font("Leelawadee", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ts.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.ts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnAdd,
            this.toolStripSeparator1,
            this.tsbtnEdit,
            this.toolStripSeparator2,
            this.tsbtnDelete,
            this.toolStripSeparator3,
            this.tsbtnRefresh,
            this.toolStripSeparator4,
            this.tsbtnClose,
            this.toolStripSeparator5});
			this.ts.Location = new System.Drawing.Point(2, 2);
			this.ts.Name = "ts";
			this.ts.Size = new System.Drawing.Size(929, 50);
			this.ts.TabIndex = 0;
			this.ts.Text = "toolStrip1";
			// 
			// dgv
			// 
			this.dgv.BackgroundColor = System.Drawing.Color.White;
			this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgv.Location = new System.Drawing.Point(2, 52);
			this.dgv.Name = "dgv";
			this.dgv.Size = new System.Drawing.Size(929, 459);
			this.dgv.TabIndex = 1;
			this.dgv.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellEnter);
			this.dgv.DoubleClick += new System.EventHandler(this.dgv_DoubleClick);
			// 
			// tsbtnAdd
			// 
			this.tsbtnAdd.AutoSize = false;
			this.tsbtnAdd.Image = global::KIM.Properties.Resources.Add;
			this.tsbtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbtnAdd.Name = "tsbtnAdd";
			this.tsbtnAdd.Size = new System.Drawing.Size(75, 47);
			this.tsbtnAdd.Text = "&Add";
			this.tsbtnAdd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.tsbtnAdd.Click += new System.EventHandler(this.tsbtnAdd_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 50);
			// 
			// tsbtnEdit
			// 
			this.tsbtnEdit.AutoSize = false;
			this.tsbtnEdit.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnEdit.Image")));
			this.tsbtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbtnEdit.Name = "tsbtnEdit";
			this.tsbtnEdit.Size = new System.Drawing.Size(75, 47);
			this.tsbtnEdit.Text = "E&dit";
			this.tsbtnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.tsbtnEdit.Click += new System.EventHandler(this.tsbtnEdit_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 50);
			// 
			// tsbtnDelete
			// 
			this.tsbtnDelete.AutoSize = false;
			this.tsbtnDelete.Image = global::KIM.Properties.Resources.DeleteHS;
			this.tsbtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbtnDelete.Name = "tsbtnDelete";
			this.tsbtnDelete.Size = new System.Drawing.Size(75, 47);
			this.tsbtnDelete.Text = "&Delete";
			this.tsbtnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.tsbtnDelete.Click += new System.EventHandler(this.tsbtnDelete_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 50);
			// 
			// tsbtnRefresh
			// 
			this.tsbtnRefresh.AutoSize = false;
			this.tsbtnRefresh.Image = global::KIM.Properties.Resources.REFRESH;
			this.tsbtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbtnRefresh.Name = "tsbtnRefresh";
			this.tsbtnRefresh.Size = new System.Drawing.Size(75, 47);
			this.tsbtnRefresh.Text = "&Refresh";
			this.tsbtnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(6, 50);
			// 
			// tsbtnClose
			// 
			this.tsbtnClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.tsbtnClose.AutoSize = false;
			this.tsbtnClose.Image = global::KIM.Properties.Resources.CLOSE;
			this.tsbtnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbtnClose.Name = "tsbtnClose";
			this.tsbtnClose.Size = new System.Drawing.Size(75, 47);
			this.tsbtnClose.Text = "&Close";
			this.tsbtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.tsbtnClose.Click += new System.EventHandler(this.tsbtnClose_Click);
			// 
			// toolStripSeparator5
			// 
			this.toolStripSeparator5.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.toolStripSeparator5.Name = "toolStripSeparator5";
			this.toolStripSeparator5.Size = new System.Drawing.Size(6, 50);
			// 
			// OrderMgr
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(933, 588);
			this.Controls.Add(this.pnlBody);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.pnlTop);
			this.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "OrderMgr";
			this.Text = "Order Manager";
			this.Load += new System.EventHandler(this.OrderMgr_Load);
			this.pnlTop.ResumeLayout(false);
			this.pnlBody.ResumeLayout(false);
			this.ts.ResumeLayout(false);
			this.ts.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pnlTop;
		private System.Windows.Forms.Label lbTitle;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel pnlBody;
		private System.Windows.Forms.ToolStrip ts;
		private System.Windows.Forms.DataGridView dgv;
		private System.Windows.Forms.ToolStripButton tsbtnAdd;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
		private System.Windows.Forms.ToolStripButton tsbtnEdit;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
		private System.Windows.Forms.ToolStripButton tsbtnDelete;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
		private System.Windows.Forms.ToolStripButton tsbtnRefresh;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
		private System.Windows.Forms.ToolStripButton tsbtnClose;
		private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
	}
}