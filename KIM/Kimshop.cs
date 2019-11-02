using KIM.models;
using KIM.utils;
using KIM.views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KIM
{
    public partial class Kimshop : Form
    {
        #region class member
        private string _lang="EN";

        #endregion

        #region class helper

        private void updateLangauge()
        {
            if(_lang == "KH")
            {
                // Menu File
                mnuFile.Text = "ឯកសារ";
                mnuCustomer.Text = "អតិថិជន។";
				mnuVendor.Text = "";
				mnuExchange.Text = "";
                mnuExit.Text = "ចេញ";

				// Menu Order
				mnuOrder.Text = "";

                // Menu Warehouse
                mnuWarehouse.Text = "ឃ្លាំង។";
                mnuInventory.Text = "សារពើភ័ណ្ឌ។";
				mnuItemMaster.Text = "";

                // Menu Tools
                mnuTools.Text = "ឧបករណ៍។";
                mnuSysConfig.Text = "ការកំណត់រចនាសម្ព័ន្ធប្រព័ន្ធ។";
                mnuUserMember.Text = "សមាជិកអ្នកប្រើប្រាស់។";
                mnuToolbars.Text = "របារឧបករណ៍។";
				mnuCurrency.Text = "";

                // toolbars
                tsbtnCustomer.Text = "អតិថិជន";
                tsbtnInventory.Text = "សារពើភ័ណ្ឌ។";

				// Menu Help
				mnuHelp.Text = "";
				mnuAbout.Text = "";
            }
         }

        private void updatePermissions()
        {
            tslbPermission.Text = $"{vars.USER_NAME}:[{vars.USER_PERMISSION}]";
        }

        #endregion

        public Kimshop()
        {
            InitializeComponent();
            mnuToolbars.Checked = true;
            _lang = vars.LANG_USE;
            mnuLang.Text = _lang;
            updateLangauge();
 
            // change backgroud color for MDI form
            Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.FromArgb(7, 100, 151); //Color.FromArgb(62, 73, 97);

            // statusbar
            tblbComputername.Text = vars.COMP_NAME;
            tblbUserId.Text = $"id:{vars.USER_ID}";

        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void mnuToolbars_CheckedChanged(object sender, EventArgs e)
        {
            tsMain.Visible = mnuToolbars.Checked;
        }

		private void Kimshop_Load(object sender, EventArgs e)
		{
			tslbPermission.Text = $"{vars.USER_NAME}:[{vars.PERMISSION_NAME}]";
		}

		private void Kimshop_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!new UserDAL().userLogout(vars.USER_ID))
			{
				MessageBox.Show("Error during update logout time, logout anyway!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void mnuCurrency_Click(object sender, EventArgs e)
		{
            var currencies = views.Master.CurrencyList.GetInstance;
			currencies.MdiParent = this;
			currencies.StartPosition = FormStartPosition.CenterParent;
            currencies.BringToFront();
			currencies.Show();

		}

        private void mnuExchange_Click(object sender, EventArgs e)
        {
             var exch = views.Master.ExchangeMaster.GetInstance;
            exch.MdiParent = this;
            exch.StartPosition = FormStartPosition.CenterScreen;
            exch.BringToFront();
            exch.Show();
        }

        private void mnuHorizontal_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void mnuVertical_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void mnuCascade_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void tsbtnCustomer_Click(object sender, EventArgs e)
        {
            mnuCustomer.PerformClick();
        }

        private void tsbtnInventory_Click(object sender, EventArgs e)
        {
            mnuInventory.PerformClick();
        }

        private void mnuCustomer_Click(object sender, EventArgs e)
        {
            var customers = views.Customer.Customers.GetInstance;
            customers.StartPosition = FormStartPosition.CenterScreen;
            customers.MdiParent = this;
            customers.BringToFront();
            customers.Show();
        }

        private void mnuVendor_Click(object sender, EventArgs e)
        {
            var suppliers = views.Supplier.vendor.GetInstance;
            suppliers.StartPosition = FormStartPosition.CenterScreen;
            suppliers.MdiParent = this;
            suppliers.BringToFront();
            suppliers.Show();
        }

        private void tsbtnVendor_Click(object sender, EventArgs e)
        {
            mnuVendor.PerformClick();
        }

        private void mnuInventory_Click(object sender, EventArgs e)
        {
            var inventory = views.Inventory.InventoryHost.GetInstance;
            inventory.StartPosition = FormStartPosition.CenterScreen;
            inventory.WindowState = FormWindowState.Maximized;
            inventory.BringToFront();
            inventory.Show();
        }

        private void mnuItemMaster_Click(object sender, EventArgs e)
        {
            var itemMaster = views.warehouse.ItemMaster.GetInstance;
            itemMaster.StartPosition = FormStartPosition.CenterScreen;
            itemMaster.MdiParent = this;
            itemMaster.BringToFront();
            itemMaster.Show();
        }

        private void tsbtnItemMaster_Click(object sender, EventArgs e)
        {
            mnuItemMaster.PerformClick();
        }
    }
}
