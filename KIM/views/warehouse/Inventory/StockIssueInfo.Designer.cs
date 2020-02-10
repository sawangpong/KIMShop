namespace KIM.views.warehouse.Inventory
{
    partial class StockIssueInfo
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
			this.lbTitle = new System.Windows.Forms.Label();
			this.lbMode = new System.Windows.Forms.Label();
			this.lbCode = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnPostSave = new System.Windows.Forms.Button();
			this.grpHeader = new System.Windows.Forms.GroupBox();
			this.panel4 = new System.Windows.Forms.Panel();
			this.txtRemark = new System.Windows.Forms.TextBox();
			this.lbRemark = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.txtIssuedBy = new System.Windows.Forms.TextBox();
			this.lbIssuedBy = new System.Windows.Forms.Label();
			this.cbxReason = new System.Windows.Forms.ComboBox();
			this.lbDescription = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.chkIsPosted = new System.Windows.Forms.CheckBox();
			this.dtpIssueDate = new System.Windows.Forms.DateTimePicker();
			this.lbIssueDate = new System.Windows.Forms.Label();
			this.txtIssueNo = new System.Windows.Forms.TextBox();
			this.lbIssueNo = new System.Windows.Forms.Label();
			this.grpCost = new System.Windows.Forms.GroupBox();
			this.panel5 = new System.Windows.Forms.Panel();
			this.panel7 = new System.Windows.Forms.Panel();
			this.txtTotalPrice = new System.Windows.Forms.TextBox();
			this.lbTotalAmt = new System.Windows.Forms.Label();
			this.cbxCurrency = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.pnlStockItems = new System.Windows.Forms.Panel();
			this.dgv = new System.Windows.Forms.DataGridView();
			this.ts = new System.Windows.Forms.ToolStrip();
			this.tsbtnAdd = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.tsbtnEdit = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.tsbtnDelete = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.tsbtnRefresh = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.tslbItemId = new System.Windows.Forms.ToolStripLabel();
			this.pnlHeader.SuspendLayout();
			this.panel1.SuspendLayout();
			this.grpHeader.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			this.grpCost.SuspendLayout();
			this.panel7.SuspendLayout();
			this.pnlStockItems.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
			this.ts.SuspendLayout();
			this.SuspendLayout();
			// 
			// pnlHeader
			// 
			this.pnlHeader.BackColor = System.Drawing.SystemColors.ControlDark;
			this.pnlHeader.Controls.Add(this.lbTitle);
			this.pnlHeader.Controls.Add(this.lbMode);
			this.pnlHeader.Controls.Add(this.lbCode);
			this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlHeader.Location = new System.Drawing.Point(0, 0);
			this.pnlHeader.Name = "pnlHeader";
			this.pnlHeader.Padding = new System.Windows.Forms.Padding(2);
			this.pnlHeader.Size = new System.Drawing.Size(960, 55);
			this.pnlHeader.TabIndex = 2;
			// 
			// lbTitle
			// 
			this.lbTitle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbTitle.Font = new System.Drawing.Font("Leelawadee UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTitle.ForeColor = System.Drawing.Color.White;
			this.lbTitle.Location = new System.Drawing.Point(91, 2);
			this.lbTitle.Name = "lbTitle";
			this.lbTitle.Size = new System.Drawing.Size(798, 51);
			this.lbTitle.TabIndex = 2;
			this.lbTitle.Text = "Stock Issue";
			this.lbTitle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
			// 
			// lbMode
			// 
			this.lbMode.Dock = System.Windows.Forms.DockStyle.Left;
			this.lbMode.Font = new System.Drawing.Font("Leelawadee UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbMode.ForeColor = System.Drawing.Color.DarkBlue;
			this.lbMode.Location = new System.Drawing.Point(2, 2);
			this.lbMode.Name = "lbMode";
			this.lbMode.Size = new System.Drawing.Size(89, 51);
			this.lbMode.TabIndex = 1;
			this.lbMode.Text = "Add";
			this.lbMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbCode
			// 
			this.lbCode.Dock = System.Windows.Forms.DockStyle.Right;
			this.lbCode.Font = new System.Drawing.Font("Leelawadee UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbCode.ForeColor = System.Drawing.Color.Yellow;
			this.lbCode.Location = new System.Drawing.Point(889, 2);
			this.lbCode.Name = "lbCode";
			this.lbCode.Size = new System.Drawing.Size(69, 51);
			this.lbCode.TabIndex = 0;
			this.lbCode.Text = "IC";
			this.lbCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnSave);
			this.panel1.Controls.Add(this.btnCancel);
			this.panel1.Controls.Add(this.btnPostSave);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 537);
			this.panel1.Name = "panel1";
			this.panel1.Padding = new System.Windows.Forms.Padding(10);
			this.panel1.Size = new System.Drawing.Size(960, 53);
			this.panel1.TabIndex = 5;
			// 
			// btnSave
			// 
			this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnSave.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnSave.Location = new System.Drawing.Point(752, 10);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(99, 33);
			this.btnSave.TabIndex = 2;
			this.btnSave.Text = "&Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnCancel.Location = new System.Drawing.Point(851, 10);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(99, 33);
			this.btnCancel.TabIndex = 1;
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// btnPostSave
			// 
			this.btnPostSave.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnPostSave.Dock = System.Windows.Forms.DockStyle.Left;
			this.btnPostSave.Location = new System.Drawing.Point(10, 10);
			this.btnPostSave.Name = "btnPostSave";
			this.btnPostSave.Size = new System.Drawing.Size(99, 33);
			this.btnPostSave.TabIndex = 0;
			this.btnPostSave.Text = "Post";
			this.btnPostSave.UseVisualStyleBackColor = true;
			this.btnPostSave.Click += new System.EventHandler(this.btnPostSave_Click);
			// 
			// grpHeader
			// 
			this.grpHeader.Controls.Add(this.panel4);
			this.grpHeader.Controls.Add(this.panel3);
			this.grpHeader.Controls.Add(this.panel2);
			this.grpHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.grpHeader.Location = new System.Drawing.Point(0, 55);
			this.grpHeader.Name = "grpHeader";
			this.grpHeader.Padding = new System.Windows.Forms.Padding(10);
			this.grpHeader.Size = new System.Drawing.Size(960, 134);
			this.grpHeader.TabIndex = 7;
			this.grpHeader.TabStop = false;
			this.grpHeader.Text = "Header Information";
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.txtRemark);
			this.panel4.Controls.Add(this.lbRemark);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(10, 92);
			this.panel4.Name = "panel4";
			this.panel4.Padding = new System.Windows.Forms.Padding(2);
			this.panel4.Size = new System.Drawing.Size(940, 30);
			this.panel4.TabIndex = 2;
			// 
			// txtRemark
			// 
			this.txtRemark.Dock = System.Windows.Forms.DockStyle.Left;
			this.txtRemark.Location = new System.Drawing.Point(131, 2);
			this.txtRemark.MaxLength = 150;
			this.txtRemark.Name = "txtRemark";
			this.txtRemark.Size = new System.Drawing.Size(739, 29);
			this.txtRemark.TabIndex = 4;
			// 
			// lbRemark
			// 
			this.lbRemark.Dock = System.Windows.Forms.DockStyle.Left;
			this.lbRemark.Location = new System.Drawing.Point(2, 2);
			this.lbRemark.Name = "lbRemark";
			this.lbRemark.Size = new System.Drawing.Size(129, 26);
			this.lbRemark.TabIndex = 0;
			this.lbRemark.Text = "Remark:";
			this.lbRemark.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.txtIssuedBy);
			this.panel3.Controls.Add(this.lbIssuedBy);
			this.panel3.Controls.Add(this.cbxReason);
			this.panel3.Controls.Add(this.lbDescription);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(10, 62);
			this.panel3.Name = "panel3";
			this.panel3.Padding = new System.Windows.Forms.Padding(2);
			this.panel3.Size = new System.Drawing.Size(940, 30);
			this.panel3.TabIndex = 1;
			// 
			// txtIssuedBy
			// 
			this.txtIssuedBy.Dock = System.Windows.Forms.DockStyle.Left;
			this.txtIssuedBy.Location = new System.Drawing.Point(664, 2);
			this.txtIssuedBy.MaxLength = 50;
			this.txtIssuedBy.Name = "txtIssuedBy";
			this.txtIssuedBy.Size = new System.Drawing.Size(206, 29);
			this.txtIssuedBy.TabIndex = 4;
			this.txtIssuedBy.TextChanged += new System.EventHandler(this.txt_TextChanged);
			// 
			// lbIssuedBy
			// 
			this.lbIssuedBy.Dock = System.Windows.Forms.DockStyle.Left;
			this.lbIssuedBy.Location = new System.Drawing.Point(550, 2);
			this.lbIssuedBy.Name = "lbIssuedBy";
			this.lbIssuedBy.Size = new System.Drawing.Size(114, 26);
			this.lbIssuedBy.TabIndex = 3;
			this.lbIssuedBy.Text = "Issued by:";
			this.lbIssuedBy.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cbxReason
			// 
			this.cbxReason.Dock = System.Windows.Forms.DockStyle.Left;
			this.cbxReason.FormattingEnabled = true;
			this.cbxReason.Location = new System.Drawing.Point(131, 2);
			this.cbxReason.Name = "cbxReason";
			this.cbxReason.Size = new System.Drawing.Size(419, 29);
			this.cbxReason.TabIndex = 1;
			this.cbxReason.TextChanged += new System.EventHandler(this.txt_TextChanged);
			// 
			// lbDescription
			// 
			this.lbDescription.Dock = System.Windows.Forms.DockStyle.Left;
			this.lbDescription.Location = new System.Drawing.Point(2, 2);
			this.lbDescription.Name = "lbDescription";
			this.lbDescription.Size = new System.Drawing.Size(129, 26);
			this.lbDescription.TabIndex = 0;
			this.lbDescription.Text = "Description:";
			this.lbDescription.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.chkIsPosted);
			this.panel2.Controls.Add(this.dtpIssueDate);
			this.panel2.Controls.Add(this.lbIssueDate);
			this.panel2.Controls.Add(this.txtIssueNo);
			this.panel2.Controls.Add(this.lbIssueNo);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(10, 32);
			this.panel2.Name = "panel2";
			this.panel2.Padding = new System.Windows.Forms.Padding(2);
			this.panel2.Size = new System.Drawing.Size(940, 30);
			this.panel2.TabIndex = 0;
			// 
			// chkIsPosted
			// 
			this.chkIsPosted.Dock = System.Windows.Forms.DockStyle.Right;
			this.chkIsPosted.Enabled = false;
			this.chkIsPosted.Location = new System.Drawing.Point(856, 2);
			this.chkIsPosted.Name = "chkIsPosted";
			this.chkIsPosted.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
			this.chkIsPosted.Size = new System.Drawing.Size(82, 26);
			this.chkIsPosted.TabIndex = 4;
			this.chkIsPosted.Text = "Posted";
			this.chkIsPosted.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.chkIsPosted.UseVisualStyleBackColor = true;
			// 
			// dtpIssueDate
			// 
			this.dtpIssueDate.Dock = System.Windows.Forms.DockStyle.Left;
			this.dtpIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpIssueDate.Location = new System.Drawing.Point(419, 2);
			this.dtpIssueDate.Name = "dtpIssueDate";
			this.dtpIssueDate.Size = new System.Drawing.Size(131, 29);
			this.dtpIssueDate.TabIndex = 3;
			this.dtpIssueDate.ValueChanged += new System.EventHandler(this.dtpIssueDate_ValueChanged);
			// 
			// lbIssueDate
			// 
			this.lbIssueDate.Dock = System.Windows.Forms.DockStyle.Left;
			this.lbIssueDate.Location = new System.Drawing.Point(337, 2);
			this.lbIssueDate.Name = "lbIssueDate";
			this.lbIssueDate.Size = new System.Drawing.Size(82, 26);
			this.lbIssueDate.TabIndex = 2;
			this.lbIssueDate.Text = "Date:";
			this.lbIssueDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtIssueNo
			// 
			this.txtIssueNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtIssueNo.Dock = System.Windows.Forms.DockStyle.Left;
			this.txtIssueNo.Location = new System.Drawing.Point(131, 2);
			this.txtIssueNo.MaxLength = 20;
			this.txtIssueNo.Name = "txtIssueNo";
			this.txtIssueNo.Size = new System.Drawing.Size(206, 29);
			this.txtIssueNo.TabIndex = 1;
			this.txtIssueNo.TextChanged += new System.EventHandler(this.txt_TextChanged);
			// 
			// lbIssueNo
			// 
			this.lbIssueNo.Dock = System.Windows.Forms.DockStyle.Left;
			this.lbIssueNo.Location = new System.Drawing.Point(2, 2);
			this.lbIssueNo.Name = "lbIssueNo";
			this.lbIssueNo.Size = new System.Drawing.Size(129, 26);
			this.lbIssueNo.TabIndex = 0;
			this.lbIssueNo.Text = "Issue No.:";
			this.lbIssueNo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// grpCost
			// 
			this.grpCost.Controls.Add(this.panel5);
			this.grpCost.Controls.Add(this.panel7);
			this.grpCost.Dock = System.Windows.Forms.DockStyle.Top;
			this.grpCost.Location = new System.Drawing.Point(0, 189);
			this.grpCost.Name = "grpCost";
			this.grpCost.Padding = new System.Windows.Forms.Padding(10);
			this.grpCost.Size = new System.Drawing.Size(960, 106);
			this.grpCost.TabIndex = 8;
			this.grpCost.TabStop = false;
			this.grpCost.Text = "Cost and Expenditure";
			// 
			// panel5
			// 
			this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel5.Location = new System.Drawing.Point(10, 62);
			this.panel5.Name = "panel5";
			this.panel5.Padding = new System.Windows.Forms.Padding(2);
			this.panel5.Size = new System.Drawing.Size(940, 30);
			this.panel5.TabIndex = 2;
			// 
			// panel7
			// 
			this.panel7.Controls.Add(this.txtTotalPrice);
			this.panel7.Controls.Add(this.lbTotalAmt);
			this.panel7.Controls.Add(this.cbxCurrency);
			this.panel7.Controls.Add(this.label10);
			this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel7.Location = new System.Drawing.Point(10, 32);
			this.panel7.Name = "panel7";
			this.panel7.Padding = new System.Windows.Forms.Padding(2);
			this.panel7.Size = new System.Drawing.Size(940, 30);
			this.panel7.TabIndex = 0;
			// 
			// txtTotalPrice
			// 
			this.txtTotalPrice.Dock = System.Windows.Forms.DockStyle.Left;
			this.txtTotalPrice.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTotalPrice.Location = new System.Drawing.Point(664, 2);
			this.txtTotalPrice.MaxLength = 150;
			this.txtTotalPrice.Name = "txtTotalPrice";
			this.txtTotalPrice.ReadOnly = true;
			this.txtTotalPrice.Size = new System.Drawing.Size(150, 29);
			this.txtTotalPrice.TabIndex = 14;
			this.txtTotalPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// lbTotalAmt
			// 
			this.lbTotalAmt.Dock = System.Windows.Forms.DockStyle.Left;
			this.lbTotalAmt.Location = new System.Drawing.Point(245, 2);
			this.lbTotalAmt.Name = "lbTotalAmt";
			this.lbTotalAmt.Size = new System.Drawing.Size(419, 26);
			this.lbTotalAmt.TabIndex = 13;
			this.lbTotalAmt.Text = "Total Shipment amount:";
			this.lbTotalAmt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cbxCurrency
			// 
			this.cbxCurrency.Dock = System.Windows.Forms.DockStyle.Left;
			this.cbxCurrency.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxCurrency.FormattingEnabled = true;
			this.cbxCurrency.Location = new System.Drawing.Point(131, 2);
			this.cbxCurrency.Name = "cbxCurrency";
			this.cbxCurrency.Size = new System.Drawing.Size(114, 29);
			this.cbxCurrency.TabIndex = 2;
			this.cbxCurrency.SelectedValueChanged += new System.EventHandler(this.cbxCurrency_SelectedValueChanged);
			// 
			// label10
			// 
			this.label10.Dock = System.Windows.Forms.DockStyle.Left;
			this.label10.Location = new System.Drawing.Point(2, 2);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(129, 26);
			this.label10.TabIndex = 0;
			this.label10.Text = "Currency:";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// pnlStockItems
			// 
			this.pnlStockItems.Controls.Add(this.dgv);
			this.pnlStockItems.Controls.Add(this.ts);
			this.pnlStockItems.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlStockItems.Location = new System.Drawing.Point(0, 295);
			this.pnlStockItems.Name = "pnlStockItems";
			this.pnlStockItems.Padding = new System.Windows.Forms.Padding(10);
			this.pnlStockItems.Size = new System.Drawing.Size(960, 242);
			this.pnlStockItems.TabIndex = 9;
			// 
			// dgv
			// 
			this.dgv.BackgroundColor = System.Drawing.Color.White;
			this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgv.Location = new System.Drawing.Point(10, 35);
			this.dgv.Name = "dgv";
			this.dgv.RowHeadersWidth = 51;
			this.dgv.Size = new System.Drawing.Size(940, 197);
			this.dgv.TabIndex = 1;
			this.dgv.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellEnter);
			this.dgv.DoubleClick += new System.EventHandler(this.dgv_DoubleClick);
			// 
			// ts
			// 
			this.ts.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.ts.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.ts.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.ts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnAdd,
            this.toolStripSeparator1,
            this.tsbtnEdit,
            this.toolStripSeparator2,
            this.tsbtnDelete,
            this.toolStripSeparator3,
            this.tsbtnRefresh,
            this.toolStripSeparator4,
            this.tslbItemId});
			this.ts.Location = new System.Drawing.Point(10, 10);
			this.ts.Name = "ts";
			this.ts.Size = new System.Drawing.Size(940, 25);
			this.ts.TabIndex = 0;
			// 
			// tsbtnAdd
			// 
			this.tsbtnAdd.AutoSize = false;
			this.tsbtnAdd.Image = global::KIM.Properties.Resources.Add;
			this.tsbtnAdd.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbtnAdd.Name = "tsbtnAdd";
			this.tsbtnAdd.Size = new System.Drawing.Size(75, 22);
			this.tsbtnAdd.Text = "&Add";
			this.tsbtnAdd.Click += new System.EventHandler(this.tsbtnAdd_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
			// 
			// tsbtnEdit
			// 
			this.tsbtnEdit.AutoSize = false;
			this.tsbtnEdit.Image = global::KIM.Properties.Resources.Edit;
			this.tsbtnEdit.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbtnEdit.Name = "tsbtnEdit";
			this.tsbtnEdit.Size = new System.Drawing.Size(75, 22);
			this.tsbtnEdit.Text = "&Edit";
			this.tsbtnEdit.Click += new System.EventHandler(this.tsbtnEdit_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
			// 
			// tsbtnDelete
			// 
			this.tsbtnDelete.AutoSize = false;
			this.tsbtnDelete.Image = global::KIM.Properties.Resources.DeleteHS;
			this.tsbtnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbtnDelete.Name = "tsbtnDelete";
			this.tsbtnDelete.Size = new System.Drawing.Size(75, 22);
			this.tsbtnDelete.Text = "&Delete";
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
			// 
			// tsbtnRefresh
			// 
			this.tsbtnRefresh.AutoSize = false;
			this.tsbtnRefresh.Image = global::KIM.Properties.Resources.REFRESH;
			this.tsbtnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbtnRefresh.Name = "tsbtnRefresh";
			this.tsbtnRefresh.Size = new System.Drawing.Size(75, 22);
			this.tsbtnRefresh.Text = "&Refresh";
			this.tsbtnRefresh.Click += new System.EventHandler(this.tsbtnRefresh_Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
			// 
			// tslbItemId
			// 
			this.tslbItemId.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.tslbItemId.Enabled = false;
			this.tslbItemId.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
			this.tslbItemId.Name = "tslbItemId";
			this.tslbItemId.Size = new System.Drawing.Size(0, 22);
			this.tslbItemId.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// StockIssueInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(960, 590);
			this.Controls.Add(this.pnlStockItems);
			this.Controls.Add(this.grpCost);
			this.Controls.Add(this.grpHeader);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pnlHeader);
			this.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "StockIssueInfo";
			this.Text = "Stock Issue";
			this.Load += new System.EventHandler(this.StockIssueInfo_Load);
			this.pnlHeader.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.grpHeader.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.grpCost.ResumeLayout(false);
			this.panel7.ResumeLayout(false);
			this.panel7.PerformLayout();
			this.pnlStockItems.ResumeLayout(false);
			this.pnlStockItems.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
			this.ts.ResumeLayout(false);
			this.ts.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lbMode;
        private System.Windows.Forms.Label lbCode;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPostSave;
        private System.Windows.Forms.GroupBox grpHeader;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label lbRemark;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtIssuedBy;
        private System.Windows.Forms.Label lbIssuedBy;
        private System.Windows.Forms.ComboBox cbxReason;
        private System.Windows.Forms.Label lbDescription;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox chkIsPosted;
        private System.Windows.Forms.DateTimePicker dtpIssueDate;
        private System.Windows.Forms.Label lbIssueDate;
        private System.Windows.Forms.TextBox txtIssueNo;
        private System.Windows.Forms.Label lbIssueNo;
        private System.Windows.Forms.GroupBox grpCost;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ComboBox cbxCurrency;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel pnlStockItems;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.ToolStrip ts;
        private System.Windows.Forms.ToolStripButton tsbtnAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtnEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbtnDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbtnRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel tslbItemId;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.TextBox txtTotalPrice;
        private System.Windows.Forms.Label lbTotalAmt;
    }
}