using KIM.data;
using KIM.models.Warehouse;
using KIM.models.Warehouse.Inventory;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KIM.views.warehouse.Inventory
{
    public partial class StockOnhand : Form
    {
        #region class field

        private SKIssueItem _item;

        private string _filter;
        #endregion

        #region class properties
        public string ItemNo { get; set; }
        public string ItemName { get; set; }
        public string Unit { get; set; }
        public string Currency { get; set; }
        public decimal UnitCost { get; set; }

        #endregion

        #region class helper

        private void GetStockOnhand(string filter)
        {
            dgv.SuspendLayout();
            dgv.DataSource = new StockDAL().GetStockBalance(filter);

            // formatting
            dgv.Columns["ItemNo"].HeaderText = "Item-No.";
            dgv.Columns["ITEMNAME"].HeaderText = "Description";
            dgv.Columns["SK_UNIT"].HeaderText = "Unit";
            dgv.Columns["CURRENCY"].HeaderText = "Currency";
            dgv.Columns["OnHand"].HeaderText = "Qty. ON-hand";
            dgv.Columns["OnHand"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv.Columns["OnHand"].DefaultCellStyle.Format = "N2";

            dgv.Columns["Booking"].HeaderText = "Qty. Booking";
            dgv.Columns["Booking"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv.Columns["Booking"].DefaultCellStyle.Format = "N2";

            dgv.Columns["Available"].HeaderText = "Qty. Available";
            dgv.Columns["Available"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv.Columns["Available"].DefaultCellStyle.Format = "N2";

            dgv.Columns["OnOrder"].HeaderText = "Qty. ON-Order";
            dgv.Columns["OnOrder"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv.Columns["OnOrder"].DefaultCellStyle.Format = "N2";

            dgv.Columns["UnitCost"].HeaderText = "Unit cost";
            dgv.Columns["UnitCost"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv.Columns["UnitCost"].DefaultCellStyle.Format = "N2";

            dgv.Columns["TotalValue"].HeaderText = "Total values";
            dgv.Columns["TotalValue"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv.Columns["TotalValue"].DefaultCellStyle.Format = "N2";

            dgv.ResumeLayout();

            UpdateUI();
        }

        private void UpdateUI()
        {
            btnSelect.Enabled = (dgv.Rows.Count >= 0 && !String.IsNullOrEmpty(this.ItemNo));
        }

        #endregion

        public StockOnhand(string filter)
        {
            InitializeComponent();
            _filter = filter;

            //utils.utilcore.SettingDataGrid(ref dgv);

            dgv.DoubleBuffered(true);
            dgv.SettingDataGrid();
        }

        private void StockOnhand_Load(object sender, EventArgs e)
        {
            GetStockOnhand(_filter);
        }

        private void dgv_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.ItemName = dgv["ITEMNAME", e.RowIndex].Value.ToString();
            this.ItemNo = dgv["ItemNo", e.RowIndex].Value.ToString();
            this.Unit = dgv["SK_UNIT", e.RowIndex].Value.ToString();
            this.Currency = dgv["CURRENCY", e.RowIndex].Value.ToString();
            this.UnitCost = Convert.ToDecimal(dgv["UnitCost", e.RowIndex].Value);
        }


        private void dgv_DoubleClick(object sender, EventArgs e)
        {
            btnSelect.PerformClick();
        }
    }
}
