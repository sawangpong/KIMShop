namespace KIM.views.warehouse.Inventory
{
    partial class StockReceiveInfo
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
			this.btnPostSave = new System.Windows.Forms.Button();
			this.pnlHeader = new System.Windows.Forms.Panel();
			this.lbTitle = new System.Windows.Forms.Label();
			this.lbMode = new System.Windows.Forms.Label();
			this.lbCode = new System.Windows.Forms.Label();
			this.pnlBodyTop = new System.Windows.Forms.Panel();
			this.grpCost = new System.Windows.Forms.GroupBox();
			this.panel5 = new System.Windows.Forms.Panel();
			this.txtTotalAmount = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtItemCost = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.panel6 = new System.Windows.Forms.Panel();
			this.txtOtherCost = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.txtTaxClearing = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.txtTransport = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.panel7 = new System.Windows.Forms.Panel();
			this.cbxCurrency = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.grpHeader = new System.Windows.Forms.GroupBox();
			this.panel4 = new System.Windows.Forms.Panel();
			this.txtRemark = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.txtReceiveBy = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.cbxReason = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.chkIsPosted = new System.Windows.Forms.CheckBox();
			this.dtpDocDate = new System.Windows.Forms.DateTimePicker();
			this.label2 = new System.Windows.Forms.Label();
			this.txtReceiveNo = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
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
			this.panel1.SuspendLayout();
			this.pnlHeader.SuspendLayout();
			this.pnlBodyTop.SuspendLayout();
			this.grpCost.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel6.SuspendLayout();
			this.panel7.SuspendLayout();
			this.grpHeader.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panel2.SuspendLayout();
			this.pnlStockItems.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
			this.ts.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnSave);
			this.panel1.Controls.Add(this.btnCancel);
			this.panel1.Controls.Add(this.btnPostSave);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 610);
			this.panel1.Name = "panel1";
			this.panel1.Padding = new System.Windows.Forms.Padding(10);
			this.panel1.Size = new System.Drawing.Size(936, 53);
			this.panel1.TabIndex = 0;
			// 
			// btnSave
			// 
			this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnSave.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnSave.Location = new System.Drawing.Point(728, 10);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(99, 33);
			this.btnSave.TabIndex = 2;
			this.btnSave.Text = "&Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnCancel.Location = new System.Drawing.Point(827, 10);
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
			this.pnlHeader.Size = new System.Drawing.Size(936, 55);
			this.pnlHeader.TabIndex = 1;
			// 
			// lbTitle
			// 
			this.lbTitle.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbTitle.Font = new System.Drawing.Font("Leelawadee UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTitle.ForeColor = System.Drawing.Color.White;
			this.lbTitle.Location = new System.Drawing.Point(91, 2);
			this.lbTitle.Name = "lbTitle";
			this.lbTitle.Size = new System.Drawing.Size(774, 51);
			this.lbTitle.TabIndex = 3;
			this.lbTitle.Text = "Stock Receive";
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
			this.lbMode.Text = "SR";
			this.lbMode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// lbCode
			// 
			this.lbCode.Dock = System.Windows.Forms.DockStyle.Right;
			this.lbCode.Font = new System.Drawing.Font("Leelawadee UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbCode.ForeColor = System.Drawing.Color.Yellow;
			this.lbCode.Location = new System.Drawing.Point(865, 2);
			this.lbCode.Name = "lbCode";
			this.lbCode.Size = new System.Drawing.Size(69, 51);
			this.lbCode.TabIndex = 0;
			this.lbCode.Text = "Add";
			this.lbCode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// pnlBodyTop
			// 
			this.pnlBodyTop.Controls.Add(this.grpCost);
			this.pnlBodyTop.Controls.Add(this.grpHeader);
			this.pnlBodyTop.Dock = System.Windows.Forms.DockStyle.Top;
			this.pnlBodyTop.Location = new System.Drawing.Point(0, 55);
			this.pnlBodyTop.Name = "pnlBodyTop";
			this.pnlBodyTop.Padding = new System.Windows.Forms.Padding(15);
			this.pnlBodyTop.Size = new System.Drawing.Size(936, 303);
			this.pnlBodyTop.TabIndex = 2;
			// 
			// grpCost
			// 
			this.grpCost.Controls.Add(this.panel5);
			this.grpCost.Controls.Add(this.panel6);
			this.grpCost.Controls.Add(this.panel7);
			this.grpCost.Dock = System.Windows.Forms.DockStyle.Top;
			this.grpCost.Location = new System.Drawing.Point(15, 149);
			this.grpCost.Name = "grpCost";
			this.grpCost.Padding = new System.Windows.Forms.Padding(10);
			this.grpCost.Size = new System.Drawing.Size(906, 134);
			this.grpCost.TabIndex = 1;
			this.grpCost.TabStop = false;
			this.grpCost.Text = "Cost and Expenditure";
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.txtTotalAmount);
			this.panel5.Controls.Add(this.label5);
			this.panel5.Controls.Add(this.txtItemCost);
			this.panel5.Controls.Add(this.label9);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel5.Location = new System.Drawing.Point(10, 92);
			this.panel5.Name = "panel5";
			this.panel5.Padding = new System.Windows.Forms.Padding(2);
			this.panel5.Size = new System.Drawing.Size(886, 30);
			this.panel5.TabIndex = 2;
			// 
			// txtTotalAmount
			// 
			this.txtTotalAmount.Dock = System.Windows.Forms.DockStyle.Left;
			this.txtTotalAmount.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtTotalAmount.Location = new System.Drawing.Point(692, 2);
			this.txtTotalAmount.MaxLength = 150;
			this.txtTotalAmount.Name = "txtTotalAmount";
			this.txtTotalAmount.ReadOnly = true;
			this.txtTotalAmount.Size = new System.Drawing.Size(166, 29);
			this.txtTotalAmount.TabIndex = 9;
			this.txtTotalAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// label5
			// 
			this.label5.Dock = System.Windows.Forms.DockStyle.Left;
			this.label5.Location = new System.Drawing.Point(585, 2);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(107, 26);
			this.label5.TabIndex = 8;
			this.label5.Text = "Total amount:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtItemCost
			// 
			this.txtItemCost.Dock = System.Windows.Forms.DockStyle.Left;
			this.txtItemCost.Enabled = false;
			this.txtItemCost.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtItemCost.Location = new System.Drawing.Point(419, 2);
			this.txtItemCost.MaxLength = 15;
			this.txtItemCost.Name = "txtItemCost";
			this.txtItemCost.ReadOnly = true;
			this.txtItemCost.Size = new System.Drawing.Size(166, 29);
			this.txtItemCost.TabIndex = 7;
			this.txtItemCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.txtItemCost.TextChanged += new System.EventHandler(this.Txt_TextChanged);
			// 
			// label9
			// 
			this.label9.Dock = System.Windows.Forms.DockStyle.Left;
			this.label9.Location = new System.Drawing.Point(2, 2);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(417, 26);
			this.label9.TabIndex = 6;
			this.label9.Text = "Receive item cost:";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// panel6
			// 
			this.panel6.Controls.Add(this.txtOtherCost);
			this.panel6.Controls.Add(this.label11);
			this.panel6.Controls.Add(this.txtTaxClearing);
			this.panel6.Controls.Add(this.label7);
			this.panel6.Controls.Add(this.txtTransport);
			this.panel6.Controls.Add(this.label8);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel6.Location = new System.Drawing.Point(10, 62);
			this.panel6.Name = "panel6";
			this.panel6.Padding = new System.Windows.Forms.Padding(2);
			this.panel6.Size = new System.Drawing.Size(886, 30);
			this.panel6.TabIndex = 1;
			// 
			// txtOtherCost
			// 
			this.txtOtherCost.Dock = System.Windows.Forms.DockStyle.Left;
			this.txtOtherCost.Location = new System.Drawing.Point(692, 2);
			this.txtOtherCost.MaxLength = 15;
			this.txtOtherCost.Name = "txtOtherCost";
			this.txtOtherCost.Size = new System.Drawing.Size(166, 29);
			this.txtOtherCost.TabIndex = 8;
			this.txtOtherCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.txtOtherCost.TextChanged += new System.EventHandler(this.Txt_TextChanged);
			// 
			// label11
			// 
			this.label11.Dock = System.Windows.Forms.DockStyle.Left;
			this.label11.Location = new System.Drawing.Point(585, 2);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(107, 26);
			this.label11.TabIndex = 7;
			this.label11.Text = "Other cost:";
			this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtTaxClearing
			// 
			this.txtTaxClearing.Dock = System.Windows.Forms.DockStyle.Left;
			this.txtTaxClearing.Location = new System.Drawing.Point(419, 2);
			this.txtTaxClearing.MaxLength = 15;
			this.txtTaxClearing.Name = "txtTaxClearing";
			this.txtTaxClearing.Size = new System.Drawing.Size(166, 29);
			this.txtTaxClearing.TabIndex = 6;
			this.txtTaxClearing.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.txtTaxClearing.TextChanged += new System.EventHandler(this.Txt_TextChanged);
			// 
			// label7
			// 
			this.label7.Dock = System.Windows.Forms.DockStyle.Left;
			this.label7.Location = new System.Drawing.Point(278, 2);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(141, 26);
			this.label7.TabIndex = 5;
			this.label7.Text = "Tax / Clearing:";
			this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtTransport
			// 
			this.txtTransport.Dock = System.Windows.Forms.DockStyle.Left;
			this.txtTransport.Location = new System.Drawing.Point(131, 2);
			this.txtTransport.MaxLength = 15;
			this.txtTransport.Name = "txtTransport";
			this.txtTransport.Size = new System.Drawing.Size(147, 29);
			this.txtTransport.TabIndex = 4;
			this.txtTransport.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.txtTransport.TextChanged += new System.EventHandler(this.Txt_TextChanged);
			this.txtTransport.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Txt_KeyPress);
			this.txtTransport.Validating += new System.ComponentModel.CancelEventHandler(this.Txt_Validating);
			// 
			// label8
			// 
			this.label8.Dock = System.Windows.Forms.DockStyle.Left;
			this.label8.Location = new System.Drawing.Point(2, 2);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(129, 26);
			this.label8.TabIndex = 0;
			this.label8.Text = "Shipping cost:";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// panel7
			// 
			this.panel7.Controls.Add(this.cbxCurrency);
			this.panel7.Controls.Add(this.label10);
			this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel7.Location = new System.Drawing.Point(10, 32);
			this.panel7.Name = "panel7";
			this.panel7.Padding = new System.Windows.Forms.Padding(2);
			this.panel7.Size = new System.Drawing.Size(886, 30);
			this.panel7.TabIndex = 0;
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
			this.label10.Text = "Receipt Currency:";
			this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// grpHeader
			// 
			this.grpHeader.Controls.Add(this.panel4);
			this.grpHeader.Controls.Add(this.panel3);
			this.grpHeader.Controls.Add(this.panel2);
			this.grpHeader.Dock = System.Windows.Forms.DockStyle.Top;
			this.grpHeader.Location = new System.Drawing.Point(15, 15);
			this.grpHeader.Name = "grpHeader";
			this.grpHeader.Padding = new System.Windows.Forms.Padding(10);
			this.grpHeader.Size = new System.Drawing.Size(906, 134);
			this.grpHeader.TabIndex = 0;
			this.grpHeader.TabStop = false;
			this.grpHeader.Text = "Header Information";
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.txtRemark);
			this.panel4.Controls.Add(this.label6);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(10, 92);
			this.panel4.Name = "panel4";
			this.panel4.Padding = new System.Windows.Forms.Padding(2);
			this.panel4.Size = new System.Drawing.Size(886, 30);
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
			// label6
			// 
			this.label6.Dock = System.Windows.Forms.DockStyle.Left;
			this.label6.Location = new System.Drawing.Point(2, 2);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(129, 26);
			this.label6.TabIndex = 0;
			this.label6.Text = "Remark:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.txtReceiveBy);
			this.panel3.Controls.Add(this.label3);
			this.panel3.Controls.Add(this.cbxReason);
			this.panel3.Controls.Add(this.label4);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(10, 62);
			this.panel3.Name = "panel3";
			this.panel3.Padding = new System.Windows.Forms.Padding(2);
			this.panel3.Size = new System.Drawing.Size(886, 30);
			this.panel3.TabIndex = 1;
			// 
			// txtReceiveBy
			// 
			this.txtReceiveBy.Dock = System.Windows.Forms.DockStyle.Left;
			this.txtReceiveBy.Location = new System.Drawing.Point(664, 2);
			this.txtReceiveBy.MaxLength = 50;
			this.txtReceiveBy.Name = "txtReceiveBy";
			this.txtReceiveBy.Size = new System.Drawing.Size(206, 29);
			this.txtReceiveBy.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.Dock = System.Windows.Forms.DockStyle.Left;
			this.label3.Location = new System.Drawing.Point(550, 2);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(114, 26);
			this.label3.TabIndex = 3;
			this.label3.Text = "Received by:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cbxReason
			// 
			this.cbxReason.Dock = System.Windows.Forms.DockStyle.Left;
			this.cbxReason.FormattingEnabled = true;
			this.cbxReason.Location = new System.Drawing.Point(131, 2);
			this.cbxReason.Name = "cbxReason";
			this.cbxReason.Size = new System.Drawing.Size(419, 29);
			this.cbxReason.TabIndex = 1;
			// 
			// label4
			// 
			this.label4.Dock = System.Windows.Forms.DockStyle.Left;
			this.label4.Location = new System.Drawing.Point(2, 2);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(129, 26);
			this.label4.TabIndex = 0;
			this.label4.Text = "Description:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.chkIsPosted);
			this.panel2.Controls.Add(this.dtpDocDate);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Controls.Add(this.txtReceiveNo);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.Location = new System.Drawing.Point(10, 32);
			this.panel2.Name = "panel2";
			this.panel2.Padding = new System.Windows.Forms.Padding(2);
			this.panel2.Size = new System.Drawing.Size(886, 30);
			this.panel2.TabIndex = 0;
			// 
			// chkIsPosted
			// 
			this.chkIsPosted.Dock = System.Windows.Forms.DockStyle.Right;
			this.chkIsPosted.Enabled = false;
			this.chkIsPosted.Location = new System.Drawing.Point(802, 2);
			this.chkIsPosted.Name = "chkIsPosted";
			this.chkIsPosted.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
			this.chkIsPosted.Size = new System.Drawing.Size(82, 26);
			this.chkIsPosted.TabIndex = 4;
			this.chkIsPosted.Text = "Posted";
			this.chkIsPosted.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.chkIsPosted.UseVisualStyleBackColor = true;
			this.chkIsPosted.CheckedChanged += new System.EventHandler(this.chkIsPosted_CheckedChanged);
			// 
			// dtpDocDate
			// 
			this.dtpDocDate.Dock = System.Windows.Forms.DockStyle.Left;
			this.dtpDocDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpDocDate.Location = new System.Drawing.Point(419, 2);
			this.dtpDocDate.Name = "dtpDocDate";
			this.dtpDocDate.Size = new System.Drawing.Size(131, 29);
			this.dtpDocDate.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.Dock = System.Windows.Forms.DockStyle.Left;
			this.label2.Location = new System.Drawing.Point(337, 2);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(82, 26);
			this.label2.TabIndex = 2;
			this.label2.Text = "Date:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtReceiveNo
			// 
			this.txtReceiveNo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtReceiveNo.Dock = System.Windows.Forms.DockStyle.Left;
			this.txtReceiveNo.Location = new System.Drawing.Point(131, 2);
			this.txtReceiveNo.MaxLength = 20;
			this.txtReceiveNo.Name = "txtReceiveNo";
			this.txtReceiveNo.Size = new System.Drawing.Size(206, 29);
			this.txtReceiveNo.TabIndex = 1;
			this.txtReceiveNo.TextChanged += new System.EventHandler(this.txtReceiveNo_TextChanged);
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Left;
			this.label1.Location = new System.Drawing.Point(2, 2);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(129, 26);
			this.label1.TabIndex = 0;
			this.label1.Text = "Receive No.:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// pnlStockItems
			// 
			this.pnlStockItems.Controls.Add(this.dgv);
			this.pnlStockItems.Controls.Add(this.ts);
			this.pnlStockItems.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pnlStockItems.Location = new System.Drawing.Point(0, 358);
			this.pnlStockItems.Name = "pnlStockItems";
			this.pnlStockItems.Padding = new System.Windows.Forms.Padding(10);
			this.pnlStockItems.Size = new System.Drawing.Size(936, 252);
			this.pnlStockItems.TabIndex = 3;
			// 
			// dgv
			// 
			this.dgv.BackgroundColor = System.Drawing.Color.White;
			this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgv.Location = new System.Drawing.Point(10, 35);
			this.dgv.Name = "dgv";
			this.dgv.RowHeadersWidth = 51;
			this.dgv.Size = new System.Drawing.Size(916, 207);
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
			this.ts.Size = new System.Drawing.Size(916, 25);
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
			// StockReceiveInfo
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(936, 663);
			this.Controls.Add(this.pnlStockItems);
			this.Controls.Add(this.pnlBodyTop);
			this.Controls.Add(this.pnlHeader);
			this.Controls.Add(this.panel1);
			this.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "StockReceiveInfo";
			this.Text = "Stock Receiving";
			this.Load += new System.EventHandler(this.StockReceiveInfo_Load);
			this.panel1.ResumeLayout(false);
			this.pnlHeader.ResumeLayout(false);
			this.pnlBodyTop.ResumeLayout(false);
			this.grpCost.ResumeLayout(false);
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			this.panel6.ResumeLayout(false);
			this.panel6.PerformLayout();
			this.panel7.ResumeLayout(false);
			this.grpHeader.ResumeLayout(false);
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.pnlStockItems.ResumeLayout(false);
			this.pnlStockItems.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
			this.ts.ResumeLayout(false);
			this.ts.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnPostSave;
        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Label lbCode;
        private System.Windows.Forms.Label lbMode;
        private System.Windows.Forms.Panel pnlBodyTop;
        private System.Windows.Forms.Panel pnlStockItems;
        private System.Windows.Forms.GroupBox grpHeader;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDocDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtReceiveNo;
        private System.Windows.Forms.CheckBox chkIsPosted;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtReceiveBy;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbxReason;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox grpCost;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox txtTransport;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbxCurrency;
        private System.Windows.Forms.TextBox txtOtherCost;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTaxClearing;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ToolStrip ts;
        private System.Windows.Forms.ToolStripButton tsbtnAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtnEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbtnDelete;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox txtTotalAmount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtItemCost;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ToolStripButton tsbtnRefresh;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripLabel tslbItemId;
        private System.Windows.Forms.Label lbTitle;
    }
}