using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KIM.data;
using KIM.models.Warehouse;

namespace KIM.views.warehouse
{
    public partial class StockItemList : Form
    {
        #region class field
        private string _selectedItemNo = string.Empty;
        private int _selectedItemId = 0;
        #endregion

        #region class property
        public data.ItemMaster ItemStock { get; set; }

        #endregion

        #region class helper

        private void updateUI()
        {
            btnSelect.Enabled = (!string.IsNullOrEmpty(_selectedItemNo) && dgv.Rows.Count > 0);
        }

        private void GetStockItemList(string filter)
        {
            dgv.SuspendLayout();
            dgv.DataSource = new ItemMasterDAL().getItemMasters(filter);

            // formatting datagridview
            dgv.Columns["ItemNo"].HeaderText = "Item-No.";
            dgv.Columns["ItemName"].HeaderText = "Description";
            dgv.Columns["ItemName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgv.Columns["StockUnit"].HeaderText = "SK unit";
            dgv.Columns["StockUnit"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv.Columns["ItemId"].Visible = false;
            dgv.Columns["VendorId"].Visible = false;
            dgv.Columns["Warehouse"].Visible = false;
            dgv.Columns["MinQty"].Visible = false;
            dgv.Columns["MaxQty"].Visible = false;
            dgv.Columns["ReorderQty"].Visible = false;
            dgv.Columns["CatCode"].Visible = false;
            dgv.Columns["WeightUnit"].Visible = false;
            dgv.Columns["UnitWeight"].Visible = false;
            dgv.Columns["InActive"].Visible = false;
            dgv.Columns["IsStockItem"].Visible = false;
            dgv.Columns["StockItem"].Visible = false;

            dgv.ResumeLayout();

            _selectedItemNo = "";
            updateUI();
        }

        #endregion
        public StockItemList(string filter)
        {
            InitializeComponent();
            //utils.utilcore.SettingDataGrid(ref dgv);

            dgv.DoubleBuffered();
            dgv.SettingDataGrid();

            GetStockItemList(filter);
        }

        private void dgv_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            _selectedItemNo = dgv["ItemNo", e.RowIndex].Value.ToString();
            _selectedItemId = Convert.ToInt32(dgv["ItemId",e.RowIndex].Value);

            this.ItemStock = new ItemMasterDAL().getItemMasterById(_selectedItemNo);
            
            updateUI();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.ItemStock = null;
        }

        private void dgv_DoubleClick(object sender, EventArgs e)
        {
            btnSelect.PerformClick();
        }

        private void StockItemList_Load(object sender, EventArgs e)
        {

        }
    }
}
