﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KIM.views.Inventory;

namespace KIM.views.Inventory
{
    public partial class InventoryHost : Form
    {
        #region class field
        private static InventoryHost instance;

        #endregion

        #region class property
        public static InventoryHost GetInstance
        {
            get
            {
                if(instance == null || instance.IsDisposed)
                {
                    instance = new InventoryHost();
                }
                return instance;
            }
        }

        #endregion


        public InventoryHost()
        {
            InitializeComponent();

            // change backgroud color for MDI form
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(7, 100, 101); //Color.FromArgb(62, 73, 97);

        }

        private void InventoryDashboard_Load(object sender, EventArgs e)
        {

        }

        private void mnuClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mnuToolbar_CheckedChanged(object sender, EventArgs e)
        {
            ts.Visible = mnuToolbar.Checked;
        }

        private void tsbtnClose_Click(object sender, EventArgs e)
        {
            mnuClose.PerformClick();
        }

        private void tsbtnShipmentReturn_Click(object sender, EventArgs e)
        {
            mnuShipmentReturn.PerformClick();
        }

        private void tsbtnShipmentOrder_Click(object sender, EventArgs e)
        {
            mnuShipmentOrder.PerformClick();
        }

        private void tsbtnReturnPurchase_Click(object sender, EventArgs e)
        {
            mnuReturnPurchase.PerformClick();
        }

        private void tsbtnStockPurchase_Click(object sender, EventArgs e)
        {
            mnuStockPurchase.PerformClick();
        }

        private void tsbtnInventory_Click(object sender, EventArgs e)
        {
            mnuInventory.PerformClick();
        }

        private void tsbtnStockReceive_Click(object sender, EventArgs e)
        {
            mnuStockReceive.PerformClick();
        }

        private void tsbtnStockIssue_Click(object sender, EventArgs e)
        {
            mnuStockIssue.PerformClick();
        }

        private void mnuStockReceive_Click(object sender, EventArgs e)
        {
            ToolStripMenuItem _mnu = sender as ToolStripMenuItem;

            StockReceives stock = new StockReceives(_mnu.Tag.ToString());
            stock.MdiParent = this;
            stock.StartPosition = FormStartPosition.CenterScreen;
            stock.Show();

        }
    }
}
