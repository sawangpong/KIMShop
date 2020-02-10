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
    public partial class StockReceives : Form
    {
        #region class field
        private static StockReceives instance;

        private int _doc_id = 0;
        private string _docNum = "";
        private string _SKCode = "";
        private bool _isPosted = false;

        #endregion

        #region class properties
        public static StockReceives GetInstance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new StockReceives("SR");
                }
                return instance;
            }
        }
        #endregion

        #region class helper

        private void updateUI()
        {
            tsbtnEdit.Enabled = (!String.IsNullOrEmpty(_docNum) && !_isPosted);
            tsbtnDelete.Enabled = tsbtnEdit.Enabled;
        }

        private void getStockReceivedList(string filter)
        {
            dgv.SuspendLayout();
            dgv.DataSource = new StockDAL().getStockReceives(filter);

            // formatting datagridView
            dgv.Columns["IsPosted"].Visible = false;
            dgv.Columns["DOC_ID"].Visible = false;
            dgv.Columns["SK_Code"].Visible = false;
 
            dgv.Columns["Posted"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns["DOC_NUM"].HeaderText = "Document";
            dgv.Columns["DocDate"].HeaderText = "Date";
            dgv.Columns["ReceiveBy"].HeaderText = "Receive by";
            dgv.Columns["TaxAndClearing"].HeaderText = "Tax / Clearing";
            dgv.Columns["TaxAndClearing"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv.Columns["TransportCost"].HeaderText = "Transport";
            dgv.Columns["TransportCost"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv.Columns["OtherServices"].HeaderText = "Other cost";
            dgv.Columns["OtherServices"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv.Columns["TotalItemCost"].HeaderText = "Total items Values";
            dgv.Columns["TotalItemCost"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv.Columns["TotalAmount"].HeaderText = "Total Amount";
            dgv.Columns["TotalAmount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgv.ResumeLayout();

            updateUI();
        }

        private void stockReceiveInfo(string icCode,string docRef)
        {
            using (var sk = new StockReceiveInfo(icCode,docRef))
            {
                sk.StartPosition = FormStartPosition.CenterScreen;
                if (sk.ShowDialog(this) == DialogResult.OK)
                {
                    tsbtnRefresh.PerformClick();
                }
            }
        }

        #endregion

        public StockReceives(string SKCode = "SR")
        {
            InitializeComponent();
            _SKCode = SKCode;
            lbICCode.Text = _SKCode;

            //utils.utilcore.SettingDataGrid(ref dgv);

            dgv.DoubleBuffered(true);
            dgv.SettingDataGrid();

            tstxtFilter.Text = "";
        }

        private void tsbtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbtnAdd_Click(object sender, EventArgs e)
        {
            _docNum = "";
            stockReceiveInfo(_SKCode,_docNum);
        }

        private void dgv_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            _docNum = dgv["DOC_NUM", e.RowIndex].Value.ToString();
            _doc_id = Convert.ToInt32(dgv["DOC_ID", e.RowIndex].Value.ToString());
            _isPosted = Convert.ToBoolean(dgv["IsPosted", e.RowIndex].Value);
            updateUI();
        }

        private void StockReceives_Load(object sender, EventArgs e)
        {
            tsbtnRefresh.PerformClick();
        }

        private void tsbtnRefresh_Click(object sender, EventArgs e)
        {
            getStockReceivedList(tstxtFilter.Text);
        }

        private void tsbtnSearch_Click(object sender, EventArgs e)
        {
            tsbtnRefresh.PerformClick();
        }

        private void tsbtnEdit_Click(object sender, EventArgs e)
        {
            stockReceiveInfo(_SKCode,_docNum);
        }

        private void dgv_DoubleClick(object sender, EventArgs e)
        {
            tsbtnEdit.PerformClick();
        }

        private void tstxtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                tsbtnRefresh.PerformClick();
            }
        }
    }
}
