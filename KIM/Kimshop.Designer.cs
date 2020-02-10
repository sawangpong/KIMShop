namespace KIM
{
    partial class Kimshop
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kimshop));
			this.mnuMain = new System.Windows.Forms.MenuStrip();
			this.mnuFile = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuCustomer = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuVendor = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuAccountGroup = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuExchange = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuOrder = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuWarehouse = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuInventory = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuItemMaster = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuItemCategory = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuSKU = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuWHLocation = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuTools = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuUserMember = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuCurrency = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuUOM = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuToolbars = new System.Windows.Forms.ToolStripMenuItem();
			this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuLangManager = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuSetting = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuWindow = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuCascade = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuVertical = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuHorizontal = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuHelp = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuAbout = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuLang = new System.Windows.Forms.ToolStripTextBox();
			this.sts = new System.Windows.Forms.StatusStrip();
			this.tblbComputername = new System.Windows.Forms.ToolStripStatusLabel();
			this.tblbUserId = new System.Windows.Forms.ToolStripStatusLabel();
			this.tsMain = new System.Windows.Forms.ToolStrip();
			this.tsbtnCustomer = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
			this.tsbtnVendor = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
			this.tslbPermission = new System.Windows.Forms.ToolStripLabel();
			this.tsbtnItemMaster = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
			this.tsbtnInventory = new System.Windows.Forms.ToolStripButton();
			this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
			this.mnuOrderManager = new System.Windows.Forms.ToolStripMenuItem();
			this.mnuMain.SuspendLayout();
			this.sts.SuspendLayout();
			this.tsMain.SuspendLayout();
			this.SuspendLayout();
			// 
			// mnuMain
			// 
			this.mnuMain.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mnuMain.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.mnuMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuFile,
            this.mnuOrder,
            this.mnuWarehouse,
            this.mnuTools,
            this.mnuWindow,
            this.mnuHelp,
            this.mnuLang});
			this.mnuMain.Location = new System.Drawing.Point(2, 2);
			this.mnuMain.MdiWindowListItem = this.mnuWindow;
			this.mnuMain.Name = "mnuMain";
			this.mnuMain.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
			this.mnuMain.Size = new System.Drawing.Size(985, 27);
			this.mnuMain.TabIndex = 0;
			// 
			// mnuFile
			// 
			this.mnuFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCustomer,
            this.mnuVendor,
            this.toolStripMenuItem1,
            this.mnuAccountGroup,
            this.mnuExchange,
            this.toolStripMenuItem4,
            this.mnuExit});
			this.mnuFile.Name = "mnuFile";
			this.mnuFile.Size = new System.Drawing.Size(39, 21);
			this.mnuFile.Tag = "File";
			this.mnuFile.Text = "&File";
			// 
			// mnuCustomer
			// 
			this.mnuCustomer.Name = "mnuCustomer";
			this.mnuCustomer.Size = new System.Drawing.Size(163, 22);
			this.mnuCustomer.Tag = "Customer";
			this.mnuCustomer.Text = "Customers";
			this.mnuCustomer.Click += new System.EventHandler(this.mnuCustomer_Click);
			// 
			// mnuVendor
			// 
			this.mnuVendor.Name = "mnuVendor";
			this.mnuVendor.Size = new System.Drawing.Size(163, 22);
			this.mnuVendor.Tag = "Vendor";
			this.mnuVendor.Text = "Vendors";
			this.mnuVendor.Click += new System.EventHandler(this.mnuVendor_Click);
			// 
			// toolStripMenuItem1
			// 
			this.toolStripMenuItem1.Name = "toolStripMenuItem1";
			this.toolStripMenuItem1.Size = new System.Drawing.Size(160, 6);
			// 
			// mnuAccountGroup
			// 
			this.mnuAccountGroup.Name = "mnuAccountGroup";
			this.mnuAccountGroup.Size = new System.Drawing.Size(163, 22);
			this.mnuAccountGroup.Tag = "AccountGroup";
			this.mnuAccountGroup.Text = "Account Group";
			this.mnuAccountGroup.Click += new System.EventHandler(this.mnuAccountGroup_Click);
			// 
			// mnuExchange
			// 
			this.mnuExchange.Name = "mnuExchange";
			this.mnuExchange.Size = new System.Drawing.Size(163, 22);
			this.mnuExchange.Tag = "ExchangeRate";
			this.mnuExchange.Text = "Exchange Rate";
			this.mnuExchange.Click += new System.EventHandler(this.mnuExchange_Click);
			// 
			// toolStripMenuItem4
			// 
			this.toolStripMenuItem4.Name = "toolStripMenuItem4";
			this.toolStripMenuItem4.Size = new System.Drawing.Size(160, 6);
			// 
			// mnuExit
			// 
			this.mnuExit.Name = "mnuExit";
			this.mnuExit.Size = new System.Drawing.Size(163, 22);
			this.mnuExit.Tag = "Exit";
			this.mnuExit.Text = "E&xit";
			this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
			// 
			// mnuOrder
			// 
			this.mnuOrder.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuOrderManager});
			this.mnuOrder.Name = "mnuOrder";
			this.mnuOrder.Size = new System.Drawing.Size(55, 21);
			this.mnuOrder.Tag = "Order";
			this.mnuOrder.Text = "Order";
			// 
			// mnuWarehouse
			// 
			this.mnuWarehouse.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuInventory,
            this.toolStripMenuItem3,
            this.mnuItemMaster,
            this.toolStripMenuItem6,
            this.mnuItemCategory,
            this.mnuSKU,
            this.mnuWHLocation});
			this.mnuWarehouse.Name = "mnuWarehouse";
			this.mnuWarehouse.Size = new System.Drawing.Size(86, 21);
			this.mnuWarehouse.Tag = "Warehouse";
			this.mnuWarehouse.Text = "Warehouse";
			// 
			// mnuInventory
			// 
			this.mnuInventory.Name = "mnuInventory";
			this.mnuInventory.Size = new System.Drawing.Size(210, 22);
			this.mnuInventory.Text = "Inventory Management";
			this.mnuInventory.Click += new System.EventHandler(this.mnuInventory_Click);
			// 
			// toolStripMenuItem3
			// 
			this.toolStripMenuItem3.Name = "toolStripMenuItem3";
			this.toolStripMenuItem3.Size = new System.Drawing.Size(207, 6);
			// 
			// mnuItemMaster
			// 
			this.mnuItemMaster.Name = "mnuItemMaster";
			this.mnuItemMaster.Size = new System.Drawing.Size(210, 22);
			this.mnuItemMaster.Text = "Item master";
			this.mnuItemMaster.Click += new System.EventHandler(this.mnuItemMaster_Click);
			// 
			// toolStripMenuItem6
			// 
			this.toolStripMenuItem6.Name = "toolStripMenuItem6";
			this.toolStripMenuItem6.Size = new System.Drawing.Size(207, 6);
			// 
			// mnuItemCategory
			// 
			this.mnuItemCategory.Name = "mnuItemCategory";
			this.mnuItemCategory.Size = new System.Drawing.Size(210, 22);
			this.mnuItemCategory.Text = "Item Category";
			this.mnuItemCategory.Click += new System.EventHandler(this.mnuItemCategory_Click);
			// 
			// mnuSKU
			// 
			this.mnuSKU.Name = "mnuSKU";
			this.mnuSKU.Size = new System.Drawing.Size(210, 22);
			this.mnuSKU.Text = "Stock unit (SKU)";
			this.mnuSKU.Click += new System.EventHandler(this.mnuSKU_Click);
			// 
			// mnuWHLocation
			// 
			this.mnuWHLocation.Name = "mnuWHLocation";
			this.mnuWHLocation.Size = new System.Drawing.Size(210, 22);
			this.mnuWHLocation.Text = "Warehouse Location";
			this.mnuWHLocation.Click += new System.EventHandler(this.mnuWHLocation_Click);
			// 
			// mnuTools
			// 
			this.mnuTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuUserMember,
            this.toolStripMenuItem2,
            this.mnuCurrency,
            this.mnuUOM,
            this.toolStripMenuItem5,
            this.mnuToolbars,
            this.toolStripMenuItem7,
            this.mnuLangManager,
            this.mnuSetting});
			this.mnuTools.Name = "mnuTools";
			this.mnuTools.Size = new System.Drawing.Size(52, 21);
			this.mnuTools.Tag = "Tools";
			this.mnuTools.Text = "Tools";
			// 
			// mnuUserMember
			// 
			this.mnuUserMember.Name = "mnuUserMember";
			this.mnuUserMember.Size = new System.Drawing.Size(199, 22);
			this.mnuUserMember.Tag = "UserMember";
			this.mnuUserMember.Text = "User Members";
			this.mnuUserMember.Click += new System.EventHandler(this.mnuUserMember_Click);
			// 
			// toolStripMenuItem2
			// 
			this.toolStripMenuItem2.Name = "toolStripMenuItem2";
			this.toolStripMenuItem2.Size = new System.Drawing.Size(196, 6);
			// 
			// mnuCurrency
			// 
			this.mnuCurrency.Name = "mnuCurrency";
			this.mnuCurrency.Size = new System.Drawing.Size(199, 22);
			this.mnuCurrency.Text = "Currency";
			this.mnuCurrency.Click += new System.EventHandler(this.mnuCurrency_Click);
			// 
			// mnuUOM
			// 
			this.mnuUOM.Name = "mnuUOM";
			this.mnuUOM.Size = new System.Drawing.Size(199, 22);
			this.mnuUOM.Text = "Unit of Measurement";
			this.mnuUOM.Click += new System.EventHandler(this.mnuUOM_Click);
			// 
			// toolStripMenuItem5
			// 
			this.toolStripMenuItem5.Name = "toolStripMenuItem5";
			this.toolStripMenuItem5.Size = new System.Drawing.Size(196, 6);
			// 
			// mnuToolbars
			// 
			this.mnuToolbars.CheckOnClick = true;
			this.mnuToolbars.Name = "mnuToolbars";
			this.mnuToolbars.Size = new System.Drawing.Size(199, 22);
			this.mnuToolbars.Tag = "Toolbar";
			this.mnuToolbars.Text = "Toolbars";
			this.mnuToolbars.CheckedChanged += new System.EventHandler(this.mnuToolbars_CheckedChanged);
			// 
			// toolStripMenuItem7
			// 
			this.toolStripMenuItem7.Name = "toolStripMenuItem7";
			this.toolStripMenuItem7.Size = new System.Drawing.Size(196, 6);
			// 
			// mnuLangManager
			// 
			this.mnuLangManager.Name = "mnuLangManager";
			this.mnuLangManager.Size = new System.Drawing.Size(199, 22);
			this.mnuLangManager.Text = "Language Manager...";
			this.mnuLangManager.Click += new System.EventHandler(this.mnuLangManager_Click);
			// 
			// mnuSetting
			// 
			this.mnuSetting.Name = "mnuSetting";
			this.mnuSetting.Size = new System.Drawing.Size(199, 22);
			this.mnuSetting.Tag = "Setting";
			this.mnuSetting.Text = "Setting...";
			this.mnuSetting.Click += new System.EventHandler(this.mnuSetting_Click);
			// 
			// mnuWindow
			// 
			this.mnuWindow.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuCascade,
            this.mnuVertical,
            this.mnuHorizontal});
			this.mnuWindow.Name = "mnuWindow";
			this.mnuWindow.Size = new System.Drawing.Size(67, 21);
			this.mnuWindow.Tag = "Window";
			this.mnuWindow.Text = "Window";
			// 
			// mnuCascade
			// 
			this.mnuCascade.Name = "mnuCascade";
			this.mnuCascade.Size = new System.Drawing.Size(136, 22);
			this.mnuCascade.Text = "Cascade";
			this.mnuCascade.Click += new System.EventHandler(this.mnuCascade_Click);
			// 
			// mnuVertical
			// 
			this.mnuVertical.Name = "mnuVertical";
			this.mnuVertical.Size = new System.Drawing.Size(136, 22);
			this.mnuVertical.Text = "Vertical";
			this.mnuVertical.Click += new System.EventHandler(this.mnuVertical_Click);
			// 
			// mnuHorizontal
			// 
			this.mnuHorizontal.Name = "mnuHorizontal";
			this.mnuHorizontal.Size = new System.Drawing.Size(136, 22);
			this.mnuHorizontal.Text = "Horizontal";
			this.mnuHorizontal.Click += new System.EventHandler(this.mnuHorizontal_Click);
			// 
			// mnuHelp
			// 
			this.mnuHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuAbout});
			this.mnuHelp.Name = "mnuHelp";
			this.mnuHelp.Size = new System.Drawing.Size(47, 21);
			this.mnuHelp.Tag = "Help";
			this.mnuHelp.Text = "Help";
			// 
			// mnuAbout
			// 
			this.mnuAbout.Name = "mnuAbout";
			this.mnuAbout.Size = new System.Drawing.Size(111, 22);
			this.mnuAbout.Tag = "About";
			this.mnuAbout.Text = "About";
			this.mnuAbout.Click += new System.EventHandler(this.mnuAbout_Click);
			// 
			// mnuLang
			// 
			this.mnuLang.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.mnuLang.BackColor = System.Drawing.Color.DarkBlue;
			this.mnuLang.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.mnuLang.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.mnuLang.ForeColor = System.Drawing.Color.White;
			this.mnuLang.MaxLength = 5;
			this.mnuLang.Name = "mnuLang";
			this.mnuLang.ReadOnly = true;
			this.mnuLang.ShortcutsEnabled = false;
			this.mnuLang.Size = new System.Drawing.Size(37, 21);
			this.mnuLang.Text = "EN";
			this.mnuLang.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// sts
			// 
			this.sts.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.sts.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.sts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tblbComputername,
            this.tblbUserId});
			this.sts.Location = new System.Drawing.Point(2, 586);
			this.sts.Name = "sts";
			this.sts.Size = new System.Drawing.Size(985, 22);
			this.sts.TabIndex = 2;
			// 
			// tblbComputername
			// 
			this.tblbComputername.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.tblbComputername.Name = "tblbComputername";
			this.tblbComputername.Size = new System.Drawing.Size(26, 17);
			this.tblbComputername.Text = "xxx";
			// 
			// tblbUserId
			// 
			this.tblbUserId.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.tblbUserId.Name = "tblbUserId";
			this.tblbUserId.Size = new System.Drawing.Size(29, 17);
			this.tblbUserId.Text = "id:0";
			// 
			// tsMain
			// 
			this.tsMain.AutoSize = false;
			this.tsMain.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
			this.tsMain.ImageScalingSize = new System.Drawing.Size(20, 20);
			this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnCustomer,
            this.toolStripSeparator1,
            this.tsbtnVendor,
            this.toolStripSeparator2,
            this.tslbPermission,
            this.tsbtnItemMaster,
            this.toolStripSeparator4,
            this.tsbtnInventory,
            this.toolStripSeparator3});
			this.tsMain.Location = new System.Drawing.Point(2, 29);
			this.tsMain.Margin = new System.Windows.Forms.Padding(3);
			this.tsMain.Name = "tsMain";
			this.tsMain.Size = new System.Drawing.Size(985, 53);
			this.tsMain.TabIndex = 4;
			// 
			// tsbtnCustomer
			// 
			this.tsbtnCustomer.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tsbtnCustomer.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnCustomer.Image")));
			this.tsbtnCustomer.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbtnCustomer.Name = "tsbtnCustomer";
			this.tsbtnCustomer.Size = new System.Drawing.Size(68, 50);
			this.tsbtnCustomer.Tag = "Customer";
			this.tsbtnCustomer.Text = "Customer";
			this.tsbtnCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.tsbtnCustomer.Click += new System.EventHandler(this.tsbtnCustomer_Click);
			// 
			// toolStripSeparator1
			// 
			this.toolStripSeparator1.Name = "toolStripSeparator1";
			this.toolStripSeparator1.Size = new System.Drawing.Size(6, 53);
			// 
			// tsbtnVendor
			// 
			this.tsbtnVendor.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnVendor.Image")));
			this.tsbtnVendor.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbtnVendor.Name = "tsbtnVendor";
			this.tsbtnVendor.Size = new System.Drawing.Size(55, 50);
			this.tsbtnVendor.Tag = "Vendor";
			this.tsbtnVendor.Text = "Vendor";
			this.tsbtnVendor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.tsbtnVendor.Click += new System.EventHandler(this.tsbtnVendor_Click);
			// 
			// toolStripSeparator2
			// 
			this.toolStripSeparator2.Name = "toolStripSeparator2";
			this.toolStripSeparator2.Size = new System.Drawing.Size(6, 53);
			// 
			// tslbPermission
			// 
			this.tslbPermission.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
			this.tslbPermission.Font = new System.Drawing.Font("Leelawadee UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tslbPermission.ForeColor = System.Drawing.SystemColors.ControlDark;
			this.tslbPermission.Name = "tslbPermission";
			this.tslbPermission.Size = new System.Drawing.Size(30, 50);
			this.tslbPermission.Text = "xx:xx";
			// 
			// tsbtnItemMaster
			// 
			this.tsbtnItemMaster.AutoSize = false;
			this.tsbtnItemMaster.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnItemMaster.Image")));
			this.tsbtnItemMaster.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbtnItemMaster.Name = "tsbtnItemMaster";
			this.tsbtnItemMaster.Size = new System.Drawing.Size(85, 50);
			this.tsbtnItemMaster.Tag = "ItemMaster";
			this.tsbtnItemMaster.Text = "Item Master";
			this.tsbtnItemMaster.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.tsbtnItemMaster.Click += new System.EventHandler(this.tsbtnItemMaster_Click);
			// 
			// toolStripSeparator4
			// 
			this.toolStripSeparator4.Name = "toolStripSeparator4";
			this.toolStripSeparator4.Size = new System.Drawing.Size(6, 53);
			// 
			// tsbtnInventory
			// 
			this.tsbtnInventory.Image = ((System.Drawing.Image)(resources.GetObject("tsbtnInventory.Image")));
			this.tsbtnInventory.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.tsbtnInventory.Name = "tsbtnInventory";
			this.tsbtnInventory.Size = new System.Drawing.Size(65, 50);
			this.tsbtnInventory.Tag = "Inventory";
			this.tsbtnInventory.Text = "Inventory";
			this.tsbtnInventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.tsbtnInventory.Click += new System.EventHandler(this.tsbtnInventory_Click);
			// 
			// toolStripSeparator3
			// 
			this.toolStripSeparator3.Name = "toolStripSeparator3";
			this.toolStripSeparator3.Size = new System.Drawing.Size(6, 53);
			// 
			// mnuOrderManager
			// 
			this.mnuOrderManager.Name = "mnuOrderManager";
			this.mnuOrderManager.Size = new System.Drawing.Size(180, 22);
			this.mnuOrderManager.Text = "Order Manager";
			this.mnuOrderManager.Click += new System.EventHandler(this.mnuOrderManager_Click);
			// 
			// Kimshop
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(989, 610);
			this.Controls.Add(this.tsMain);
			this.Controls.Add(this.sts);
			this.Controls.Add(this.mnuMain);
			this.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.IsMdiContainer = true;
			this.MainMenuStrip = this.mnuMain;
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.Name = "Kimshop";
			this.Padding = new System.Windows.Forms.Padding(2);
			this.Text = "KIM Shop";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Kimshop_FormClosing);
			this.Load += new System.EventHandler(this.Kimshop_Load);
			this.mnuMain.ResumeLayout(false);
			this.mnuMain.PerformLayout();
			this.sts.ResumeLayout(false);
			this.sts.PerformLayout();
			this.tsMain.ResumeLayout(false);
			this.tsMain.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMain;
        private System.Windows.Forms.ToolStripMenuItem mnuFile;
        private System.Windows.Forms.StatusStrip sts;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ToolStripMenuItem mnuTools;
        private System.Windows.Forms.ToolStripMenuItem mnuToolbars;
        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ToolStripButton tsbtnCustomer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtnInventory;
        private System.Windows.Forms.ToolStripLabel tslbPermission;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem mnuCustomer;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuWarehouse;
        private System.Windows.Forms.ToolStripMenuItem mnuInventory;
        private System.Windows.Forms.ToolStripMenuItem mnuUserMember;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripStatusLabel tblbComputername;
        private System.Windows.Forms.ToolStripStatusLabel tblbUserId;
		private System.Windows.Forms.ToolStripMenuItem mnuVendor;
		private System.Windows.Forms.ToolStripMenuItem mnuOrder;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
		private System.Windows.Forms.ToolStripMenuItem mnuItemMaster;
		private System.Windows.Forms.ToolStripMenuItem mnuWindow;
		private System.Windows.Forms.ToolStripMenuItem mnuHelp;
		private System.Windows.Forms.ToolStripMenuItem mnuAbout;
		private System.Windows.Forms.ToolStripMenuItem mnuExchange;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
		private System.Windows.Forms.ToolStripMenuItem mnuCurrency;
		private System.Windows.Forms.ToolStripSeparator toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem mnuCascade;
        private System.Windows.Forms.ToolStripMenuItem mnuVertical;
        private System.Windows.Forms.ToolStripMenuItem mnuHorizontal;
        private System.Windows.Forms.ToolStripButton tsbtnVendor;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem mnuAccountGroup;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem6;
        private System.Windows.Forms.ToolStripMenuItem mnuItemCategory;
        private System.Windows.Forms.ToolStripMenuItem mnuSKU;
        private System.Windows.Forms.ToolStripMenuItem mnuWHLocation;
        private System.Windows.Forms.ToolStripMenuItem mnuUOM;
        private System.Windows.Forms.ToolStripButton tsbtnItemMaster;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripTextBox mnuLang;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem7;
        private System.Windows.Forms.ToolStripMenuItem mnuSetting;
        private System.Windows.Forms.ToolStripMenuItem mnuLangManager;
        private System.Windows.Forms.ToolStripMenuItem mnuOrderManager;
    }
}

