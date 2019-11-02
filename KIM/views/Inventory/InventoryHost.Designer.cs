namespace KIM.views.Inventory
{
    partial class InventoryHost
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
            this.mnuIC = new System.Windows.Forms.MenuStrip();
            this.mnuStock = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuInventory = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuStockReceive = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuStockIssue = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuStockPurchase = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReturnPurchase = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuShipmentOrder = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuShipmentReturn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuClose = new System.Windows.Forms.ToolStripMenuItem();
            this.tstxtTitle = new System.Windows.Forms.ToolStripTextBox();
            this.mnuTools = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuToolbar = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlHeaderRight = new System.Windows.Forms.Panel();
            this.ts = new System.Windows.Forms.ToolStrip();
            this.tsbtnInventory = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnStockReceive = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnStockIssue = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnStockPurchase = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnReturnPurchase = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnShipmentOrder = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnReturnShipment = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbtnClose = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuIC.SuspendLayout();
            this.pnlHeaderRight.SuspendLayout();
            this.ts.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuIC
            // 
            this.mnuIC.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuIC.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuStock,
            this.tstxtTitle,
            this.mnuTools,
            this.mnuWindow});
            this.mnuIC.Location = new System.Drawing.Point(0, 0);
            this.mnuIC.MdiWindowListItem = this.mnuWindow;
            this.mnuIC.Name = "mnuIC";
            this.mnuIC.Size = new System.Drawing.Size(1122, 26);
            this.mnuIC.TabIndex = 2;
            this.mnuIC.Text = "menuStrip1";
            // 
            // mnuStock
            // 
            this.mnuStock.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuInventory,
            this.toolStripMenuItem1,
            this.mnuStockReceive,
            this.mnuStockIssue,
            this.toolStripMenuItem2,
            this.mnuStockPurchase,
            this.mnuReturnPurchase,
            this.toolStripMenuItem3,
            this.mnuShipmentOrder,
            this.mnuShipmentReturn,
            this.toolStripMenuItem4,
            this.mnuClose});
            this.mnuStock.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuStock.Name = "mnuStock";
            this.mnuStock.Size = new System.Drawing.Size(51, 22);
            this.mnuStock.Text = "Stock";
            // 
            // mnuInventory
            // 
            this.mnuInventory.Name = "mnuInventory";
            this.mnuInventory.Size = new System.Drawing.Size(199, 22);
            this.mnuInventory.Tag = "IC";
            this.mnuInventory.Text = "Inventory...";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(196, 6);
            // 
            // mnuStockReceive
            // 
            this.mnuStockReceive.Name = "mnuStockReceive";
            this.mnuStockReceive.Size = new System.Drawing.Size(199, 22);
            this.mnuStockReceive.Tag = "SR";
            this.mnuStockReceive.Text = "Stock Receive (SR)";
            this.mnuStockReceive.Click += new System.EventHandler(this.mnuStockReceive_Click);
            // 
            // mnuStockIssue
            // 
            this.mnuStockIssue.Name = "mnuStockIssue";
            this.mnuStockIssue.Size = new System.Drawing.Size(199, 22);
            this.mnuStockIssue.Tag = "SI";
            this.mnuStockIssue.Text = "Stock Issue (SI)";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(196, 6);
            // 
            // mnuStockPurchase
            // 
            this.mnuStockPurchase.Name = "mnuStockPurchase";
            this.mnuStockPurchase.Size = new System.Drawing.Size(199, 22);
            this.mnuStockPurchase.Tag = "SP";
            this.mnuStockPurchase.Text = "Stock Purchase (SP)";
            // 
            // mnuReturnPurchase
            // 
            this.mnuReturnPurchase.Name = "mnuReturnPurchase";
            this.mnuReturnPurchase.Size = new System.Drawing.Size(199, 22);
            this.mnuReturnPurchase.Tag = "RP";
            this.mnuReturnPurchase.Text = "Return Purchase (RP)";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(196, 6);
            // 
            // mnuShipmentOrder
            // 
            this.mnuShipmentOrder.Name = "mnuShipmentOrder";
            this.mnuShipmentOrder.Size = new System.Drawing.Size(199, 22);
            this.mnuShipmentOrder.Tag = "SO";
            this.mnuShipmentOrder.Text = "Shipment Order (SO)";
            // 
            // mnuShipmentReturn
            // 
            this.mnuShipmentReturn.Name = "mnuShipmentReturn";
            this.mnuShipmentReturn.Size = new System.Drawing.Size(199, 22);
            this.mnuShipmentReturn.Tag = "RS";
            this.mnuShipmentReturn.Text = "Return Shipment (RS)";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(196, 6);
            // 
            // mnuClose
            // 
            this.mnuClose.Name = "mnuClose";
            this.mnuClose.Size = new System.Drawing.Size(199, 22);
            this.mnuClose.Text = "&Close";
            this.mnuClose.Click += new System.EventHandler(this.mnuClose_Click);
            // 
            // tstxtTitle
            // 
            this.tstxtTitle.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tstxtTitle.BackColor = System.Drawing.Color.MidnightBlue;
            this.tstxtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tstxtTitle.Font = new System.Drawing.Font("Leelawadee UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tstxtTitle.ForeColor = System.Drawing.Color.White;
            this.tstxtTitle.HideSelection = false;
            this.tstxtTitle.MaxLength = 50;
            this.tstxtTitle.Name = "tstxtTitle";
            this.tstxtTitle.ReadOnly = true;
            this.tstxtTitle.ShortcutsEnabled = false;
            this.tstxtTitle.Size = new System.Drawing.Size(190, 22);
            this.tstxtTitle.Text = "Inventory Management";
            this.tstxtTitle.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // mnuTools
            // 
            this.mnuTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuToolbar});
            this.mnuTools.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuTools.Name = "mnuTools";
            this.mnuTools.Size = new System.Drawing.Size(52, 22);
            this.mnuTools.Text = "Tools";
            // 
            // mnuToolbar
            // 
            this.mnuToolbar.Checked = true;
            this.mnuToolbar.CheckOnClick = true;
            this.mnuToolbar.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mnuToolbar.Name = "mnuToolbar";
            this.mnuToolbar.Size = new System.Drawing.Size(122, 22);
            this.mnuToolbar.Text = "Toolbar";
            this.mnuToolbar.CheckedChanged += new System.EventHandler(this.mnuToolbar_CheckedChanged);
            // 
            // mnuWindow
            // 
            this.mnuWindow.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuWindow.Name = "mnuWindow";
            this.mnuWindow.Size = new System.Drawing.Size(67, 22);
            this.mnuWindow.Text = "Window";
            // 
            // pnlHeaderRight
            // 
            this.pnlHeaderRight.AutoSize = true;
            this.pnlHeaderRight.Controls.Add(this.ts);
            this.pnlHeaderRight.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeaderRight.Location = new System.Drawing.Point(0, 26);
            this.pnlHeaderRight.Name = "pnlHeaderRight";
            this.pnlHeaderRight.Padding = new System.Windows.Forms.Padding(3);
            this.pnlHeaderRight.Size = new System.Drawing.Size(1122, 62);
            this.pnlHeaderRight.TabIndex = 3;
            // 
            // ts
            // 
            this.ts.AllowMerge = false;
            this.ts.BackColor = System.Drawing.Color.Transparent;
            this.ts.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ts.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ts.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ts.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbtnInventory,
            this.toolStripSeparator8,
            this.tsbtnStockReceive,
            this.toolStripSeparator1,
            this.tsbtnStockIssue,
            this.toolStripSeparator2,
            this.tsbtnStockPurchase,
            this.toolStripSeparator4,
            this.tsbtnReturnPurchase,
            this.toolStripSeparator3,
            this.tsbtnShipmentOrder,
            this.toolStripSeparator5,
            this.tsbtnReturnShipment,
            this.toolStripSeparator6,
            this.tsbtnClose,
            this.toolStripSeparator7});
            this.ts.Location = new System.Drawing.Point(3, 3);
            this.ts.Name = "ts";
            this.ts.Size = new System.Drawing.Size(1116, 56);
            this.ts.Stretch = true;
            this.ts.TabIndex = 3;
            // 
            // tsbtnInventory
            // 
            this.tsbtnInventory.AutoSize = false;
            this.tsbtnInventory.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbtnInventory.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsbtnInventory.Image = global::KIM.Properties.Resources.Add;
            this.tsbtnInventory.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnInventory.Name = "tsbtnInventory";
            this.tsbtnInventory.Size = new System.Drawing.Size(100, 53);
            this.tsbtnInventory.Tag = "IC";
            this.tsbtnInventory.Text = "Inventory";
            this.tsbtnInventory.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnInventory.Click += new System.EventHandler(this.tsbtnInventory_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 56);
            // 
            // tsbtnStockReceive
            // 
            this.tsbtnStockReceive.AutoSize = false;
            this.tsbtnStockReceive.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbtnStockReceive.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsbtnStockReceive.Image = global::KIM.Properties.Resources.Add;
            this.tsbtnStockReceive.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnStockReceive.Name = "tsbtnStockReceive";
            this.tsbtnStockReceive.Size = new System.Drawing.Size(140, 53);
            this.tsbtnStockReceive.Tag = "SR";
            this.tsbtnStockReceive.Text = "Stock Receive (SR)";
            this.tsbtnStockReceive.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnStockReceive.Click += new System.EventHandler(this.tsbtnStockReceive_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 56);
            // 
            // tsbtnStockIssue
            // 
            this.tsbtnStockIssue.AutoSize = false;
            this.tsbtnStockIssue.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbtnStockIssue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsbtnStockIssue.Image = global::KIM.Properties.Resources.Add;
            this.tsbtnStockIssue.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnStockIssue.Name = "tsbtnStockIssue";
            this.tsbtnStockIssue.Size = new System.Drawing.Size(140, 53);
            this.tsbtnStockIssue.Tag = "SI";
            this.tsbtnStockIssue.Text = "Stock Issue (SI)";
            this.tsbtnStockIssue.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnStockIssue.Click += new System.EventHandler(this.tsbtnStockIssue_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 56);
            // 
            // tsbtnStockPurchase
            // 
            this.tsbtnStockPurchase.AutoSize = false;
            this.tsbtnStockPurchase.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbtnStockPurchase.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsbtnStockPurchase.Image = global::KIM.Properties.Resources.Add;
            this.tsbtnStockPurchase.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnStockPurchase.Name = "tsbtnStockPurchase";
            this.tsbtnStockPurchase.Size = new System.Drawing.Size(140, 53);
            this.tsbtnStockPurchase.Tag = "SP";
            this.tsbtnStockPurchase.Text = "Stock Purchase (SP)";
            this.tsbtnStockPurchase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnStockPurchase.Click += new System.EventHandler(this.tsbtnStockPurchase_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 56);
            // 
            // tsbtnReturnPurchase
            // 
            this.tsbtnReturnPurchase.AutoSize = false;
            this.tsbtnReturnPurchase.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbtnReturnPurchase.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsbtnReturnPurchase.Image = global::KIM.Properties.Resources.Add;
            this.tsbtnReturnPurchase.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnReturnPurchase.Name = "tsbtnReturnPurchase";
            this.tsbtnReturnPurchase.Size = new System.Drawing.Size(140, 53);
            this.tsbtnReturnPurchase.Tag = "RP";
            this.tsbtnReturnPurchase.Text = "Return Purchase (RP)";
            this.tsbtnReturnPurchase.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnReturnPurchase.Click += new System.EventHandler(this.tsbtnReturnPurchase_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 56);
            // 
            // tsbtnShipmentOrder
            // 
            this.tsbtnShipmentOrder.AutoSize = false;
            this.tsbtnShipmentOrder.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbtnShipmentOrder.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsbtnShipmentOrder.Image = global::KIM.Properties.Resources.Add;
            this.tsbtnShipmentOrder.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnShipmentOrder.Name = "tsbtnShipmentOrder";
            this.tsbtnShipmentOrder.Size = new System.Drawing.Size(140, 53);
            this.tsbtnShipmentOrder.Tag = "SO";
            this.tsbtnShipmentOrder.Text = "Shipment Order  (SO)";
            this.tsbtnShipmentOrder.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnShipmentOrder.Click += new System.EventHandler(this.tsbtnShipmentOrder_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 56);
            // 
            // tsbtnReturnShipment
            // 
            this.tsbtnReturnShipment.AutoSize = false;
            this.tsbtnReturnShipment.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbtnReturnShipment.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsbtnReturnShipment.Image = global::KIM.Properties.Resources.Add;
            this.tsbtnReturnShipment.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnReturnShipment.Name = "tsbtnReturnShipment";
            this.tsbtnReturnShipment.Size = new System.Drawing.Size(140, 53);
            this.tsbtnReturnShipment.Tag = "RS";
            this.tsbtnReturnShipment.Text = "Return Shipment (RS)";
            this.tsbtnReturnShipment.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnReturnShipment.Click += new System.EventHandler(this.tsbtnShipmentReturn_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 56);
            // 
            // tsbtnClose
            // 
            this.tsbtnClose.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.tsbtnClose.AutoSize = false;
            this.tsbtnClose.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsbtnClose.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tsbtnClose.Image = global::KIM.Properties.Resources.CLOSE;
            this.tsbtnClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbtnClose.Name = "tsbtnClose";
            this.tsbtnClose.Size = new System.Drawing.Size(100, 53);
            this.tsbtnClose.Text = "Close";
            this.tsbtnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsbtnClose.Click += new System.EventHandler(this.tsbtnClose_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 56);
            // 
            // InventoryHost
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1122, 692);
            this.Controls.Add(this.pnlHeaderRight);
            this.Controls.Add(this.mnuIC);
            this.Font = new System.Drawing.Font("Leelawadee UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnuIC;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "InventoryHost";
            this.Text = "Inventory Management";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.InventoryDashboard_Load);
            this.mnuIC.ResumeLayout(false);
            this.mnuIC.PerformLayout();
            this.pnlHeaderRight.ResumeLayout(false);
            this.pnlHeaderRight.PerformLayout();
            this.ts.ResumeLayout(false);
            this.ts.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip mnuIC;
        private System.Windows.Forms.ToolStripMenuItem mnuStock;
        private System.Windows.Forms.ToolStripTextBox tstxtTitle;
        private System.Windows.Forms.ToolStripMenuItem mnuInventory;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mnuStockReceive;
        private System.Windows.Forms.ToolStripMenuItem mnuStockIssue;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem mnuStockPurchase;
        private System.Windows.Forms.ToolStripMenuItem mnuReturnPurchase;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem mnuShipmentOrder;
        private System.Windows.Forms.ToolStripMenuItem mnuShipmentReturn;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem mnuClose;
        private System.Windows.Forms.Panel pnlHeaderRight;
        private System.Windows.Forms.ToolStrip ts;
        private System.Windows.Forms.ToolStripButton tsbtnInventory;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton tsbtnStockReceive;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbtnStockIssue;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbtnStockPurchase;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton tsbtnReturnPurchase;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton tsbtnShipmentOrder;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton tsbtnReturnShipment;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton tsbtnClose;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem mnuTools;
        private System.Windows.Forms.ToolStripMenuItem mnuToolbar;
        private System.Windows.Forms.ToolStripMenuItem mnuWindow;
    }
}