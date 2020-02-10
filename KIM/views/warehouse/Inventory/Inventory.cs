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
    public partial class Inventory : Form
    {
        #region class field
        private static Inventory instance;
        private DataTable _dt;

        #endregion

        #region class properties
        public static Inventory GetInstance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new Inventory();
                }
                return instance;
            }
        }
        #endregion

        #region class helper

        private void updateUI()
        {

        }

        private void getInventory(string filter)
        {
            dgv.SuspendLayout();
            _dt = new StockDAL().GetStockBalance(filter);
            dgv.DataSource = _dt;

            dgv.Columns["ItemNo"].HeaderText = "Item-No.";
            dgv.Columns["ITEMNAME"].HeaderText = "Description";
            dgv.Columns["SK_UNIT"].HeaderText = "Unit Stock";
            dgv.Columns["CURRENCY"].HeaderText = "Home currency";

            dgv.Columns["OnHand"].HeaderText = "Qty. ON-Hand";
            dgv.Columns["OnHand"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv.Columns["OnHand"].DefaultCellStyle.Format = "N2";

            dgv.Columns["Booking"].HeaderText = "Qty.Booking";
            dgv.Columns["Booking"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv.Columns["Booking"].DefaultCellStyle.Format = "N2";

            dgv.Columns["Available"].HeaderText = "Qty.Available";
            dgv.Columns["Available"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv.Columns["Available"].DefaultCellStyle.Format = "N2";

            dgv.Columns["OnOrder"].HeaderText = "Qty. ON-Purchase";
            dgv.Columns["OnOrder"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv.Columns["OnOrder"].DefaultCellStyle.Format = "N2";

            dgv.Columns["UnitCost"].HeaderText = "Unit cost";
            dgv.Columns["UnitCost"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv.Columns["UnitCost"].DefaultCellStyle.Format = "N2";

            dgv.Columns["TotalValue"].HeaderText = "Total stock Value";
            dgv.Columns["TotalValue"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv.Columns["TotalValue"].DefaultCellStyle.Format = "N2";

            dgv.Columns["LastUpdate"].HeaderText = "Last Update";
            dgv.Columns["LastUpdate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns["LastUpdate"].DefaultCellStyle.Format = "dd/MM/yyyy hh:mm";

            dgv.ResumeLayout();

            updateUI();
        }


        #endregion

        public Inventory()
        {
            InitializeComponent();

            //utils.utilcore.SettingDataGrid(ref dgv);
            dgv.DoubleBuffered(true);
            dgv.SettingDataGrid();
        }

        private void Inventory_Load(object sender, EventArgs e)
        {
            getInventory("");
        }

        private void tsbtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbtnRefresh_Click(object sender, EventArgs e)
        {
            getInventory(tstxtSearch.Text);
        }

        private void tsbtnSearch_Click(object sender, EventArgs e)
        {
            tsbtnRefresh.PerformClick();
        }

        private void tstxtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                tsbtnRefresh.PerformClick();
            }
        }
    }
}
