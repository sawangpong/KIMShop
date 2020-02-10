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
    public partial class StockIssues : Form
    {
        #region class field
        private static StockIssues instance;
        private string _skCode = "";

        private string _selectedIssueNo = "";
        private bool _isPosted = false;

        #endregion

        #region Class properties
        public static StockIssues GetInstance
        {
            get
            {
                if(instance == null || instance.IsDisposed)
                {
                    instance = new StockIssues("SI");
                }
                return instance;
            }
        }

        #endregion

        #region class helper

        private void UpdateUI()
        {
            tsbtnEdit.Enabled = (!String.IsNullOrEmpty(_selectedIssueNo) && !_isPosted && dgv.Rows.Count > 0);
            tsbtnDelete.Enabled = tsbtnEdit.Enabled;
        }

        private void GetIssueList(string filter)
        {
            dgv.SuspendLayout();
            dgv.DataSource = new StockDAL().GetIssues(filter);

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgv.Columns["IsPosted"].Visible = false;
            dgv.Columns["SK_Code"].Visible = false;
            
            dgv.Columns["Posted"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgv.Columns["ISSUE_NUM"].HeaderText = "Issue-No.";
            
            dgv.Columns["IssueDate"].HeaderText = "Date";
            dgv.Columns["IssueDate"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns["IssueDate"].DefaultCellStyle.Format = "dd/MM/yyyy";
            
            dgv.Columns["IssuedBy"].HeaderText = "Issued by";
            
            dgv.Columns["TotalPrice"].HeaderText = "Total Price";
            dgv.Columns["TotalPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv.Columns["TotalPrice"].DefaultCellStyle.Format = "N2";

            dgv.ResumeLayout();

            UpdateUI();
        }

        private void GetIssueInfo(string IssueNo)
        {
            using(var  _issueInfo = new StockIssueInfo(_skCode,IssueNo))
            {
                _issueInfo.StartPosition = FormStartPosition.CenterScreen;
                if (_issueInfo.ShowDialog(this) == DialogResult.OK)
                {

                }
            }

            tsbtnRefresh.PerformClick();
           
        }

        #endregion

        public StockIssues(string SKCode="SI")
        {
            InitializeComponent();

            // utils.utilcore.SettingDataGrid(ref dgv);
            dgv.DoubleBuffered(true);
            dgv.SettingDataGrid();

            _skCode = SKCode;
            lbICCode.Text = _skCode;
        }

        private void StockIssues_Load(object sender, EventArgs e)
        {
            tsbtnRefresh.PerformClick();
        }

        private void tsbtnRefresh_Click(object sender, EventArgs e)
        {
            GetIssueList(tstxtFilter.Text);
        }

        private void tsbtnSearch_Click(object sender, EventArgs e)
        {
            tsbtnRefresh.PerformClick();
        }

        private void tsbtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            _isPosted = Convert.ToBoolean(dgv["IsPosted", e.RowIndex].Value);
            _selectedIssueNo = dgv["ISSUE_NUM", e.RowIndex].Value.ToString();

            UpdateUI();
        }

        private void dgv_DoubleClick(object sender, EventArgs e)
        {
            tsbtnEdit.PerformClick();
        }

        private void tsbtnAdd_Click(object sender, EventArgs e)
        {
            _selectedIssueNo = "";
            GetIssueInfo(_selectedIssueNo);
        }

        private void tsbtnEdit_Click(object sender, EventArgs e)
        {
            GetIssueInfo(_selectedIssueNo);
        }

        private void tstxtFilter_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                tsbtnSearch.PerformClick();
            }
        }
    }
}
