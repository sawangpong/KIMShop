using KIM.models.Tool;
using KIM.utils;
using KIM.views;
using KIM.views.Tool;
using System;
using System.Collections;
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
        //private string _lang = "EN";

        #endregion

        #region class helper

        private void updateLangauge()
        {
            foreach (Control c in this.Controls)
            {
                if (c is System.Windows.Forms.MenuStrip)
                {
                    System.Windows.Forms.MenuStrip mnu = c as System.Windows.Forms.MenuStrip;
                    mnu.Text = mnu.GetLanguageValue();

                    if (mnu.Items.Count > 0)
                    {
                        foreach (var mu in mnu.Items)
                        {
                            if (mu is System.Windows.Forms.ToolStripMenuItem)
                            {
                                System.Windows.Forms.ToolStripMenuItem _item = mu as System.Windows.Forms.ToolStripMenuItem;
                                _item.Text = _item.GetLanguageValue();
                                if (_item.DropDownItems.Count > 0)
                                {
                                    foreach (System.Windows.Forms.ToolStripItem item in _item.DropDownItems)
                                    {
                                        item.Text = item.GetLanguageValue();
                                    }
                                }
                            }
                        }
                    }
                }
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
            //_lang = vars.LANG_USE;
            LangUtils.GetLanguageByDefaultCode(vars.LANG_USE);
            mnuLang.Text = vars.LANG_USE; //_lang;          updateLangauge();

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
            if (!new UserDAL().UserLogout(vars.USER_ID))
            {
                MessageBox.Show("Error during update logout time, logout anyway!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void mnuCurrency_Click(object sender, EventArgs e)
        {
            var currencies = views.Tool.CurrencyList.GetInstance;
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
            var customers = views.Master.Customer.Customers.GetInstance;
            customers.StartPosition = FormStartPosition.CenterScreen;
            customers.MdiParent = this;
            customers.BringToFront();
            customers.Show();
        }

        private void mnuVendor_Click(object sender, EventArgs e)
        {
            var suppliers = views.Master.Vendor.vendor.GetInstance;
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
            var inventory = views.warehouse.Inventory.InventoryHost.GetInstance;
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

        private void mnuSetting_Click(object sender, EventArgs e)
        {
            using (var sysSetting = new SysSetting(vars.SYS_PROFILE.CompanyCode, DataActionMode.Edit))
            {
                sysSetting.StartPosition = FormStartPosition.CenterScreen;
                sysSetting.ShowDialog(this);
            }
        }

        private void mnuLangManager_Click(object sender, EventArgs e)
        {
            var langManager = views.Tool.LangManager.GetInstance;
            langManager.StartPosition = FormStartPosition.CenterScreen;
            langManager.MdiParent = this;
            langManager.BringToFront();
            langManager.Show();
        }

        private void mnuAbout_Click(object sender, EventArgs e)
        {
            var about = views.Startup.About.GetInstance;
            about.Show(this);
        }

        private void mnuSKU_Click(object sender, EventArgs e)
        {
            var sku = views.warehouse.SKUnit.GetInstance;
            sku.MdiParent = this;
            sku.StartPosition = FormStartPosition.CenterScreen;
            sku.BringToFront();
            sku.Show();
        }

        private void mnuItemCategory_Click(object sender, EventArgs e)
        {
            var itemCat = views.warehouse.ItemCategory.GetInstance;
            itemCat.MdiParent = this;
            itemCat.StartPosition = FormStartPosition.CenterScreen;
            itemCat.BringToFront();
            itemCat.Show();
        }

        private void mnuWHLocation_Click(object sender, EventArgs e)
        {
            var whLoc = views.warehouse.WHLoc.GetInstance;
            whLoc.MdiParent = this;
            whLoc.StartPosition = FormStartPosition.CenterScreen;
            whLoc.BringToFront();
            whLoc.Show();
        }

        private void mnuAccountGroup_Click(object sender, EventArgs e)
        {
            var accSet = views.Master.AccountSet.GetInstance;
            accSet.MdiParent = this;
            accSet.StartPosition = FormStartPosition.CenterScreen;
            accSet.BringToFront();
            accSet.Show();
        }

        private void mnuUserMember_Click(object sender, EventArgs e)
        {
            var member = views.Tool.Member.GetInstance;
            member.MdiParent = this;
            member.StartPosition = FormStartPosition.CenterScreen;
            member.BringToFront();
            member.Show();
        }

        private void mnuUOM_Click(object sender, EventArgs e)
        {
            var uom = views.Tool.UOMMaster.GetInstance;
            uom.MdiParent = this;
            uom.StartPosition = FormStartPosition.CenterScreen;
            uom.BringToFront();
            uom.Show();
        }

        private void mnuOrderManager_Click(object sender, EventArgs e)
        {
            var ordManager = views.Order.OrderMgr.GetInstance;
            ordManager.MdiParent = this;
            ordManager.StartPosition = FormStartPosition.CenterScreen;
            ordManager.BringToFront();
            ordManager.Show();
        }
    }
}
