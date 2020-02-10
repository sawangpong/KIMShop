namespace KIM.views.warehouse.Inventory
{
    partial class StockIssueItem
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StockIssueItem));
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel11 = new System.Windows.Forms.Panel();
			this.lbIssueNo = new System.Windows.Forms.Label();
			this.lbCode = new System.Windows.Forms.Label();
			this.lbTitle = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lbItemId = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.grpItem = new System.Windows.Forms.GroupBox();
			this.panel3 = new System.Windows.Forms.Panel();
			this.dgv = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.panel7 = new System.Windows.Forms.Panel();
			this.panel6 = new System.Windows.Forms.Panel();
			this.txtTotalIssuePrice = new System.Windows.Forms.TextBox();
			this.lbTotalPrice = new System.Windows.Forms.Label();
			this.txtTotalCost = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.txtUnitCost = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.panel5 = new System.Windows.Forms.Panel();
			this.txtIssueQty = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtUnitPrice = new System.Windows.Forms.TextBox();
			this.lbUnitPrice = new System.Windows.Forms.Label();
			this.cbxUnit = new System.Windows.Forms.ComboBox();
			this.label6 = new System.Windows.Forms.Label();
			this.panel4 = new System.Windows.Forms.Panel();
			this.lbOnHand = new System.Windows.Forms.Label();
			this.txtCurrency = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.panel20 = new System.Windows.Forms.Panel();
			this.txtItemName = new System.Windows.Forms.TextBox();
			this.btnItemNo = new KIM.UserComponent.SearchButton();
			this.txtItemNo = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.panel2.SuspendLayout();
			this.panel11.SuspendLayout();
			this.panel1.SuspendLayout();
			this.grpItem.SuspendLayout();
			this.panel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
			this.panel6.SuspendLayout();
			this.panel5.SuspendLayout();
			this.panel4.SuspendLayout();
			this.panel20.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
			this.panel2.Controls.Add(this.panel11);
			this.panel2.Controls.Add(this.lbTitle);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel2.ForeColor = System.Drawing.Color.White;
			this.panel2.Location = new System.Drawing.Point(0, 0);
			this.panel2.Name = "panel2";
			this.panel2.Padding = new System.Windows.Forms.Padding(2);
			this.panel2.Size = new System.Drawing.Size(830, 55);
			this.panel2.TabIndex = 2;
			// 
			// panel11
			// 
			this.panel11.Controls.Add(this.lbIssueNo);
			this.panel11.Controls.Add(this.lbCode);
			this.panel11.Dock = System.Windows.Forms.DockStyle.Left;
			this.panel11.Location = new System.Drawing.Point(2, 2);
			this.panel11.Name = "panel11";
			this.panel11.Padding = new System.Windows.Forms.Padding(2);
			this.panel11.Size = new System.Drawing.Size(196, 51);
			this.panel11.TabIndex = 2;
			// 
			// lbIssueNo
			// 
			this.lbIssueNo.Dock = System.Windows.Forms.DockStyle.Fill;
			this.lbIssueNo.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbIssueNo.ForeColor = System.Drawing.Color.DarkBlue;
			this.lbIssueNo.Location = new System.Drawing.Point(2, 28);
			this.lbIssueNo.Name = "lbIssueNo";
			this.lbIssueNo.Size = new System.Drawing.Size(192, 21);
			this.lbIssueNo.TabIndex = 3;
			this.lbIssueNo.Text = "Issue No.";
			this.lbIssueNo.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// lbCode
			// 
			this.lbCode.Dock = System.Windows.Forms.DockStyle.Top;
			this.lbCode.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbCode.ForeColor = System.Drawing.Color.White;
			this.lbCode.Location = new System.Drawing.Point(2, 2);
			this.lbCode.Name = "lbCode";
			this.lbCode.Size = new System.Drawing.Size(192, 26);
			this.lbCode.TabIndex = 2;
			this.lbCode.Text = "S";
			// 
			// lbTitle
			// 
			this.lbTitle.Dock = System.Windows.Forms.DockStyle.Right;
			this.lbTitle.Font = new System.Drawing.Font("Leelawadee UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTitle.Location = new System.Drawing.Point(656, 2);
			this.lbTitle.Name = "lbTitle";
			this.lbTitle.Size = new System.Drawing.Size(172, 51);
			this.lbTitle.TabIndex = 0;
			this.lbTitle.Text = "Issue Item";
			this.lbTitle.TextAlign = System.Drawing.ContentAlignment.BottomRight;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.lbItemId);
			this.panel1.Controls.Add(this.btnSave);
			this.panel1.Controls.Add(this.btnCancel);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel1.Location = new System.Drawing.Point(0, 388);
			this.panel1.Name = "panel1";
			this.panel1.Padding = new System.Windows.Forms.Padding(10);
			this.panel1.Size = new System.Drawing.Size(830, 52);
			this.panel1.TabIndex = 3;
			// 
			// lbItemId
			// 
			this.lbItemId.Dock = System.Windows.Forms.DockStyle.Left;
			this.lbItemId.Font = new System.Drawing.Font("Leelawadee UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbItemId.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.lbItemId.Location = new System.Drawing.Point(10, 10);
			this.lbItemId.Name = "lbItemId";
			this.lbItemId.Size = new System.Drawing.Size(121, 32);
			this.lbItemId.TabIndex = 11;
			this.lbItemId.Text = "0";
			this.lbItemId.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
			// 
			// btnSave
			// 
			this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnSave.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnSave.Location = new System.Drawing.Point(614, 10);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(103, 32);
			this.btnSave.TabIndex = 1;
			this.btnSave.Text = "&Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
			this.btnCancel.Location = new System.Drawing.Point(717, 10);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(103, 32);
			this.btnCancel.TabIndex = 0;
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// grpItem
			// 
			this.grpItem.Controls.Add(this.panel3);
			this.grpItem.Controls.Add(this.panel7);
			this.grpItem.Controls.Add(this.panel6);
			this.grpItem.Controls.Add(this.panel5);
			this.grpItem.Controls.Add(this.panel4);
			this.grpItem.Controls.Add(this.panel20);
			this.grpItem.Dock = System.Windows.Forms.DockStyle.Fill;
			this.grpItem.Location = new System.Drawing.Point(0, 55);
			this.grpItem.Name = "grpItem";
			this.grpItem.Padding = new System.Windows.Forms.Padding(10);
			this.grpItem.Size = new System.Drawing.Size(830, 333);
			this.grpItem.TabIndex = 15;
			this.grpItem.TabStop = false;
			this.grpItem.Text = "Stock Item";
			// 
			// panel3
			// 
			this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel3.Controls.Add(this.dgv);
			this.panel3.Controls.Add(this.label1);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(10, 168);
			this.panel3.Name = "panel3";
			this.panel3.Padding = new System.Windows.Forms.Padding(5);
			this.panel3.Size = new System.Drawing.Size(810, 155);
			this.panel3.TabIndex = 18;
			// 
			// dgv
			// 
			this.dgv.BackgroundColor = System.Drawing.Color.White;
			this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgv.Location = new System.Drawing.Point(5, 31);
			this.dgv.Name = "dgv";
			this.dgv.RowHeadersWidth = 51;
			this.dgv.Size = new System.Drawing.Size(798, 117);
			this.dgv.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.BackColor = System.Drawing.SystemColors.ControlDarkDark;
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.label1.ForeColor = System.Drawing.Color.Yellow;
			this.label1.Location = new System.Drawing.Point(5, 5);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(798, 26);
			this.label1.TabIndex = 0;
			this.label1.Text = "Item On-Hand";
			// 
			// panel7
			// 
			this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel7.Location = new System.Drawing.Point(10, 152);
			this.panel7.Name = "panel7";
			this.panel7.Padding = new System.Windows.Forms.Padding(2);
			this.panel7.Size = new System.Drawing.Size(810, 16);
			this.panel7.TabIndex = 17;
			// 
			// panel6
			// 
			this.panel6.Controls.Add(this.txtTotalIssuePrice);
			this.panel6.Controls.Add(this.lbTotalPrice);
			this.panel6.Controls.Add(this.txtTotalCost);
			this.panel6.Controls.Add(this.label5);
			this.panel6.Controls.Add(this.txtUnitCost);
			this.panel6.Controls.Add(this.label3);
			this.panel6.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel6.Location = new System.Drawing.Point(10, 122);
			this.panel6.Name = "panel6";
			this.panel6.Padding = new System.Windows.Forms.Padding(2);
			this.panel6.Size = new System.Drawing.Size(810, 30);
			this.panel6.TabIndex = 16;
			// 
			// txtTotalIssuePrice
			// 
			this.txtTotalIssuePrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.txtTotalIssuePrice.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
			this.txtTotalIssuePrice.Location = new System.Drawing.Point(553, 2);
			this.txtTotalIssuePrice.MaxLength = 10;
			this.txtTotalIssuePrice.Name = "txtTotalIssuePrice";
			this.txtTotalIssuePrice.Size = new System.Drawing.Size(136, 29);
			this.txtTotalIssuePrice.TabIndex = 28;
			this.txtTotalIssuePrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// lbTotalPrice
			// 
			this.lbTotalPrice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.lbTotalPrice.Location = new System.Drawing.Point(455, 1);
			this.lbTotalPrice.Name = "lbTotalPrice";
			this.lbTotalPrice.Size = new System.Drawing.Size(94, 26);
			this.lbTotalPrice.TabIndex = 27;
			this.lbTotalPrice.Text = "Total price:";
			this.lbTotalPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtTotalCost
			// 
			this.txtTotalCost.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
			this.txtTotalCost.Dock = System.Windows.Forms.DockStyle.Left;
			this.txtTotalCost.Location = new System.Drawing.Point(318, 2);
			this.txtTotalCost.MaxLength = 10;
			this.txtTotalCost.Name = "txtTotalCost";
			this.txtTotalCost.ReadOnly = true;
			this.txtTotalCost.Size = new System.Drawing.Size(114, 29);
			this.txtTotalCost.TabIndex = 26;
			this.txtTotalCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.txtTotalCost.Visible = false;
			// 
			// label5
			// 
			this.label5.Dock = System.Windows.Forms.DockStyle.Left;
			this.label5.Location = new System.Drawing.Point(209, 2);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(109, 26);
			this.label5.TabIndex = 25;
			this.label5.Text = "Total cost:";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label5.Visible = false;
			// 
			// txtUnitCost
			// 
			this.txtUnitCost.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
			this.txtUnitCost.Dock = System.Windows.Forms.DockStyle.Left;
			this.txtUnitCost.Location = new System.Drawing.Point(123, 2);
			this.txtUnitCost.MaxLength = 10;
			this.txtUnitCost.Name = "txtUnitCost";
			this.txtUnitCost.ReadOnly = true;
			this.txtUnitCost.Size = new System.Drawing.Size(86, 29);
			this.txtUnitCost.TabIndex = 24;
			this.txtUnitCost.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.txtUnitCost.Visible = false;
			// 
			// label3
			// 
			this.label3.Dock = System.Windows.Forms.DockStyle.Left;
			this.label3.Location = new System.Drawing.Point(2, 2);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(121, 26);
			this.label3.TabIndex = 23;
			this.label3.Text = "Unit cost:";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label3.Visible = false;
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.txtIssueQty);
			this.panel5.Controls.Add(this.label4);
			this.panel5.Controls.Add(this.txtUnitPrice);
			this.panel5.Controls.Add(this.lbUnitPrice);
			this.panel5.Controls.Add(this.cbxUnit);
			this.panel5.Controls.Add(this.label6);
			this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel5.Location = new System.Drawing.Point(10, 92);
			this.panel5.Name = "panel5";
			this.panel5.Padding = new System.Windows.Forms.Padding(2);
			this.panel5.Size = new System.Drawing.Size(810, 30);
			this.panel5.TabIndex = 15;
			// 
			// txtIssueQty
			// 
			this.txtIssueQty.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
			this.txtIssueQty.Dock = System.Windows.Forms.DockStyle.Left;
			this.txtIssueQty.Location = new System.Drawing.Point(553, 2);
			this.txtIssueQty.MaxLength = 10;
			this.txtIssueQty.Name = "txtIssueQty";
			this.txtIssueQty.Size = new System.Drawing.Size(136, 29);
			this.txtIssueQty.TabIndex = 24;
			this.txtIssueQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.txtIssueQty.TextChanged += new System.EventHandler(this.txtIssueQty_TextChanged);
			this.txtIssueQty.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating);
			// 
			// label4
			// 
			this.label4.Dock = System.Windows.Forms.DockStyle.Left;
			this.label4.Location = new System.Drawing.Point(432, 2);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(121, 26);
			this.label4.TabIndex = 23;
			this.label4.Text = "Issue Qty.:";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtUnitPrice
			// 
			this.txtUnitPrice.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
			this.txtUnitPrice.Dock = System.Windows.Forms.DockStyle.Left;
			this.txtUnitPrice.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.txtUnitPrice.Location = new System.Drawing.Point(318, 2);
			this.txtUnitPrice.MaxLength = 10;
			this.txtUnitPrice.Name = "txtUnitPrice";
			this.txtUnitPrice.ReadOnly = true;
			this.txtUnitPrice.Size = new System.Drawing.Size(114, 29);
			this.txtUnitPrice.TabIndex = 22;
			this.txtUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			this.txtUnitPrice.Validating += new System.ComponentModel.CancelEventHandler(this.txt_Validating);
			// 
			// lbUnitPrice
			// 
			this.lbUnitPrice.Dock = System.Windows.Forms.DockStyle.Left;
			this.lbUnitPrice.Location = new System.Drawing.Point(209, 2);
			this.lbUnitPrice.Name = "lbUnitPrice";
			this.lbUnitPrice.Size = new System.Drawing.Size(109, 26);
			this.lbUnitPrice.TabIndex = 21;
			this.lbUnitPrice.Text = "Unit price:";
			this.lbUnitPrice.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cbxUnit
			// 
			this.cbxUnit.Dock = System.Windows.Forms.DockStyle.Left;
			this.cbxUnit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxUnit.FormattingEnabled = true;
			this.cbxUnit.Location = new System.Drawing.Point(123, 2);
			this.cbxUnit.Name = "cbxUnit";
			this.cbxUnit.Size = new System.Drawing.Size(86, 29);
			this.cbxUnit.TabIndex = 20;
			this.cbxUnit.SelectedValueChanged += new System.EventHandler(this.cbxUnit_SelectedValueChanged);
			// 
			// label6
			// 
			this.label6.Dock = System.Windows.Forms.DockStyle.Left;
			this.label6.Location = new System.Drawing.Point(2, 2);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(121, 26);
			this.label6.TabIndex = 19;
			this.label6.Text = "Unit:";
			this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.lbOnHand);
			this.panel4.Controls.Add(this.txtCurrency);
			this.panel4.Controls.Add(this.label2);
			this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel4.Location = new System.Drawing.Point(10, 62);
			this.panel4.Name = "panel4";
			this.panel4.Padding = new System.Windows.Forms.Padding(2);
			this.panel4.Size = new System.Drawing.Size(810, 30);
			this.panel4.TabIndex = 14;
			// 
			// lbOnHand
			// 
			this.lbOnHand.Dock = System.Windows.Forms.DockStyle.Right;
			this.lbOnHand.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.lbOnHand.Location = new System.Drawing.Point(665, 2);
			this.lbOnHand.Name = "lbOnHand";
			this.lbOnHand.Size = new System.Drawing.Size(143, 26);
			this.lbOnHand.TabIndex = 24;
			this.lbOnHand.Text = "0";
			this.lbOnHand.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtCurrency
			// 
			this.txtCurrency.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
			this.txtCurrency.Dock = System.Windows.Forms.DockStyle.Left;
			this.txtCurrency.Location = new System.Drawing.Point(123, 2);
			this.txtCurrency.MaxLength = 10;
			this.txtCurrency.Name = "txtCurrency";
			this.txtCurrency.ReadOnly = true;
			this.txtCurrency.Size = new System.Drawing.Size(86, 29);
			this.txtCurrency.TabIndex = 17;
			// 
			// label2
			// 
			this.label2.Dock = System.Windows.Forms.DockStyle.Left;
			this.label2.Location = new System.Drawing.Point(2, 2);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(121, 26);
			this.label2.TabIndex = 16;
			this.label2.Text = "Currency:";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// panel20
			// 
			this.panel20.Controls.Add(this.txtItemName);
			this.panel20.Controls.Add(this.btnItemNo);
			this.panel20.Controls.Add(this.txtItemNo);
			this.panel20.Controls.Add(this.label9);
			this.panel20.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel20.Location = new System.Drawing.Point(10, 32);
			this.panel20.Name = "panel20";
			this.panel20.Padding = new System.Windows.Forms.Padding(2);
			this.panel20.Size = new System.Drawing.Size(810, 30);
			this.panel20.TabIndex = 13;
			// 
			// txtItemName
			// 
			this.txtItemName.Dock = System.Windows.Forms.DockStyle.Left;
			this.txtItemName.Location = new System.Drawing.Point(301, 2);
			this.txtItemName.MaxLength = 80;
			this.txtItemName.Name = "txtItemName";
			this.txtItemName.Size = new System.Drawing.Size(392, 29);
			this.txtItemName.TabIndex = 16;
			// 
			// btnItemNo
			// 
			this.btnItemNo.Dock = System.Windows.Forms.DockStyle.Left;
			this.btnItemNo.Image = ((System.Drawing.Image)(resources.GetObject("btnItemNo.Image")));
			this.btnItemNo.Location = new System.Drawing.Point(269, 2);
			this.btnItemNo.Name = "btnItemNo";
			this.btnItemNo.Size = new System.Drawing.Size(32, 26);
			this.btnItemNo.TabIndex = 15;
			this.btnItemNo.UseVisualStyleBackColor = true;
			this.btnItemNo.Click += new System.EventHandler(this.btnItemNo_Click);
			// 
			// txtItemNo
			// 
			this.txtItemNo.Dock = System.Windows.Forms.DockStyle.Left;
			this.txtItemNo.Location = new System.Drawing.Point(123, 2);
			this.txtItemNo.MaxLength = 20;
			this.txtItemNo.Name = "txtItemNo";
			this.txtItemNo.Size = new System.Drawing.Size(146, 29);
			this.txtItemNo.TabIndex = 14;
			this.txtItemNo.TextChanged += new System.EventHandler(this.txtItemNo_TextChanged);
			this.txtItemNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtItemNo_KeyPress);
			// 
			// label9
			// 
			this.label9.Dock = System.Windows.Forms.DockStyle.Left;
			this.label9.Location = new System.Drawing.Point(2, 2);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(121, 26);
			this.label9.TabIndex = 10;
			this.label9.Text = "Item-No:";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// StockIssueItem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(830, 440);
			this.Controls.Add(this.grpItem);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel2);
			this.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "StockIssueItem";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "Stock Issue Item";
			this.Load += new System.EventHandler(this.StockIssueItem_Load);
			this.panel2.ResumeLayout(false);
			this.panel11.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			this.grpItem.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
			this.panel6.ResumeLayout(false);
			this.panel6.PerformLayout();
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			this.panel20.ResumeLayout(false);
			this.panel20.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.Label lbIssueNo;
        private System.Windows.Forms.Label lbCode;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbItemId;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox grpItem;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtIssueQty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label lbUnitPrice;
        private System.Windows.Forms.ComboBox cbxUnit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox txtCurrency;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.TextBox txtItemName;
        private UserComponent.SearchButton btnItemNo;
        private System.Windows.Forms.TextBox txtItemNo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.TextBox txtTotalCost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtUnitCost;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotalIssuePrice;
        private System.Windows.Forms.Label lbTotalPrice;
        private System.Windows.Forms.Label lbOnHand;
    }
}