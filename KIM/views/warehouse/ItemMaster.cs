using KIM.data;
using KIM.models.Warehouse;
using KIM.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KIM.views.warehouse
{
    public partial class ItemMaster : Form
    {
        #region class field member
        private static ItemMaster instance;
        private string _selectedItemNo = "";

        #endregion

        #region class properties
        public static ItemMaster GetInstance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new ItemMaster();
                }
                return instance;
            }
        }



        #endregion

        #region class helper
        private void updateLang()
        {

        }

        private void updateUI()
        {
            tsbtnEdit.Enabled = !String.IsNullOrEmpty(_selectedItemNo);
            tsbtnDelete.Enabled = tsbtnEdit.Enabled;
        }

        private void getItems(string filter)
        {
            dgv.SuspendLayout();
            dgv.DataSource = new ItemMasterDAL().getItemMasters(filter);
            dgv.Columns["InActive"].Visible = false;
            dgv.Columns["IsStockItem"].Visible = false;
            dgv.Columns["StockItem"].HeaderText = "SK Item";
            dgv.Columns["StockItem"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns["StockItem"].DefaultCellStyle.Font = new Font(dgv.Font, FontStyle.Bold);

            /*
            dgv.Columns["Barcode"].Visible = false;
            dgv.Columns["VendorItemNo"].Visible = false;
            dgv.Columns["AccGroup"].Visible = false;
            dgv.Columns["WeightFactor"].Visible = false;
              dgv.Columns["ImageLocate"].Visible = false;
            dgv.Columns["CreateDate"].Visible = false;
            dgv.Columns["CreateBY"].Visible = false;
            dgv.Columns["ModifyDate"].Visible = false;
            dgv.Columns["ModifyBy"].Visible = false;
            */
            dgv.Columns["ItemNo"].HeaderText = "Item-No.";
            dgv.Columns["ItemName"].HeaderText = "Description";
            dgv.Columns["ItemName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns["VendorId"].HeaderText = "Vendor";
            dgv.Columns["CatCode"].HeaderText = "CAT.";
            dgv.Columns["StockUnit"].HeaderText = "SKU";

            dgv.Columns["MaxQty"].HeaderText = "Max";
            dgv.Columns["MaxQty"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgv.Columns["MinQty"].HeaderText = "Min";
            dgv.Columns["MinQty"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgv.Columns["ReorderQty"].HeaderText = "Re-Order.";
            dgv.Columns["ReorderQty"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgv.Columns["UnitWeight"].HeaderText = "weight";
            dgv.Columns["UnitWeight"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            
            dgv.Columns["WeightUnit"].HeaderText = "UOM";

            dgv.ResumeLayout();
            updateUI();

            lbRecords.Text = $"found:{dgv.Rows.Count}";
        }


        private void itemInfo(string itemNo)
        {
            using (var itemInfo = new ItemInfo(itemNo))
            {
                itemInfo.StartPosition = FormStartPosition.CenterScreen;
                if (itemInfo.ShowDialog(this) == DialogResult.OK)
                {
                    tsbtnRefresh.PerformClick();
                }
            }
        }

        private void getItemImage(string itemNo)
        {
            if (!String.IsNullOrEmpty(itemNo))
            {
                ItemMasterPic _item = new ItemMasterPicDAL().getItemPictureById(itemNo);
                if (_item != null)
                {
                    pic.Image = _item.ItemPic.ToImageFromByte();
                }
                else
                {
                    pic.Image = null;
                }
            }
        }

        #endregion


        public ItemMaster()
        {
            InitializeComponent();
            utilcore.SettingDataGrid(ref dgv);
        }

        private void ItemMaster_Load(object sender, EventArgs e)
        {
            tsbtnRefresh.PerformClick();
        }

        private void tsbtnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void tsbtnAdd_Click(object sender, EventArgs e)
        {
            _selectedItemNo = "";
            itemInfo(_selectedItemNo);
        }

        private void dgv_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            _selectedItemNo = dgv["ItemNo", e.RowIndex].Value.ToString();
            getItemImage(_selectedItemNo);
            updateUI();
        }

        private void dgv_DoubleClick(object sender, EventArgs e)
        {
            tsbtnEdit.PerformClick();
        }

        private void tsbtnEdit_Click(object sender, EventArgs e)
        {
            itemInfo(_selectedItemNo);
        }


        private void tsbtnRefresh_Click(object sender, EventArgs e)
        {
            getItems(tstxtSearch.Text);
        }

        private void tsbtnSearch_Click(object sender, EventArgs e)
        {
            tsbtnRefresh.PerformClick();
        }

        private void tstxtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                tsbtnSearch.PerformClick();
            }
        }
    }
}
