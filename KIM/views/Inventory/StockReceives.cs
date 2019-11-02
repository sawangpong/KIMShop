using KIM.models.Warehouse;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KIM.views.Inventory
{
    public partial class StockReceives : Form
    {
        #region class field
        private int _doc_id = 0;
        private string _refDoc = "";
        private string _icCode = "";

        #endregion

        #region class properties
  
        #endregion

        #region class helper

        private void updateUI()
        {
            tsbtnEdit.Enabled = !String.IsNullOrEmpty(_refDoc);
            tsbtnDelete.Enabled = tsbtnEdit.Enabled;

        }

        private void getStockReceivedList(string filter)
        {
            dgv.SuspendLayout();
            dgv.DataSource = new StockDAL().getStockReceives(filter);

            // formatting datagridView
            dgv.Columns["DOC_ID"].Visible = false;
            dgv.Columns["Code"].Visible = false;
            dgv.Columns["Remark"].Visible = false;
            dgv.Columns["CreateBy"].Visible = false;
            dgv.Columns["CreateDate"].Visible = false;
            dgv.Columns["ModifyBy"].Visible = false;
            dgv.Columns["ModifyDate"].Visible = false;

            dgv.Columns["DocRef"].HeaderText = "Document";
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

        private void stockReceiveInfo(string docref)
        {
            //using(var sk = new StockReceiveInfo(docref,"SR", ICControlMode.StockReceive ))
            //{
            //    sk.StartPosition = FormStartPosition.CenterScreen;
            //    if(sk.ShowDialog(this) == DialogResult.OK)
            //    {
            //        tsbtnRefresh.PerformClick();
            //    }
            //}
        }

        #endregion

        public StockReceives(string ICCode)
        {
            InitializeComponent();
            _icCode = ICCode;
            lbICCode.Text = _icCode;
            utils.utilcore.SettingDataGrid(ref dgv);

            tstxtFilter.Text = "";
        }

        private void tsbtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbtnAdd_Click(object sender, EventArgs e)
        {
            _refDoc = "";
            stockReceiveInfo(_refDoc);
        }

        private void dgv_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            _refDoc = dgv["DocRef", e.RowIndex].Value.ToString();
            _doc_id = Convert.ToInt32(dgv["DOC_ID", e.RowIndex].Value.ToString());

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
            stockReceiveInfo(_refDoc);
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
