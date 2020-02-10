using KIM.data;
using KIM.models;
using KIM.models.Warehouse;
using KIM.models.Warehouse.Inventory;
using KIM.models.Tool;
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
    public partial class StockIssueInfo : Form
    {
        #region class field member
        private SKIssueH _issueH;
        private List<SKIssueItem> _issueItems = new List<SKIssueItem>();
        private DataActionMode _mode = DataActionMode.None;
        private DataActionMode _issueItemMode = DataActionMode.None;
        private string _issueNo = "";
        private string _skCode = "";
        private int _selectedIssueItemId = 0;
        private bool _doPosted = false;

        #endregion

        #region class properties

        #endregion

        #region class helper
        private void UpdateUI()
        {
            txtIssueNo.Enabled = (_mode == DataActionMode.Add && !_issueH.IsPosted);
            btnPostSave.Enabled = (_mode == DataActionMode.Edit
                                    && dgv.Rows.Count > 0
                                    && btnSave.Enabled);
            btnSave.Enabled = (!String.IsNullOrEmpty(txtIssueNo.Text)
                                && !String.IsNullOrEmpty(cbxReason.Text)
                                && !String.IsNullOrEmpty(txtIssuedBy.Text));
        }

        private void UpdateIssueToolBar()
        {
            tsbtnAdd.Enabled = !String.IsNullOrEmpty(txtIssueNo.Text);
            tsbtnEdit.Enabled = (_selectedIssueItemId > 0);
            tsbtnDelete.Enabled = tsbtnEdit.Enabled;
        }

        private void getCurrency()
        {
            cbxCurrency.DataSource = new CurrencyDAL().getCurrencies();
            cbxCurrency.DisplayMember = "CURCode";
            cbxCurrency.ValueMember = "CURCode";
        }

        private void getIssueReason()
        {
            cbxReason.DataSource = new StockDAL().getStockIssueReason();
            cbxReason.DisplayMember = "Reason";
            cbxReason.ValueMember = "Reason";
        }

        private void GetIssueInfo(string Issueno)
        {
            switch (_mode)
            {
                case DataActionMode.Add:
                    _issueH = new SKIssueH();

                    _issueH.CreateBy = vars.USER_NAME;
                    _issueH.CreateDate = DateTime.Now;
                    _issueH.ModifyBy = vars.USER_NAME;
                    _issueH.ModifyDate = DateTime.Now;
                    _issueH.Currency = "USD";
                    _issueH.IsPosted = false;
                    _issueH.IssueDate = DateTime.Today;
                    _issueH.IssuedBy = vars.USER_NAME;
                    _issueH.IssueId = 0;
                    _issueH.ISSUE_NUM = "";
                    _issueH.PostedBy = "";
                    _issueH.PostedDate = null;
                    _issueH.Reason = "";
                    _issueH.Remark = "";
                    _issueH.SK_Code = _skCode;
                    _issueH.TotalCost = 0m;
                    _issueH.TotalPrice = 0m;
                    break;

                case DataActionMode.Edit:
                    _issueH = new StockDAL().GetIssueInfo(Issueno);
                    break;
            }

            // mapping data
            txtIssueNo.Text = _issueH.ISSUE_NUM;
            txtIssuedBy.Text = _issueH.IssuedBy;
            txtTotalPrice.Text = $"{_issueH.TotalCost:N2}";
            txtRemark.Text = _issueH.Remark;

            cbxCurrency.SelectedValue = _issueH.Currency;
            cbxReason.SelectedValue = _issueH.Reason;
            dtpIssueDate.Value = _issueH.IssueDate;
            chkIsPosted.Checked = _issueH.IsPosted;

            // load IssueItems
            getIssueItems(_issueH.ISSUE_NUM);

            UpdateUI();
        }

        private void UpdateStockIssue(SKIssueH issue, DataActionMode mode)
        {
            if (new StockDAL().UpdateStockIssue(issue, mode) > 0)
            {
                // save issue item
                if (_mode == DataActionMode.Add)
                {
                    foreach (SKIssueItem item in _issueItems)
                    {
                        if (new StockDAL().UpdateIssueItem(item, DataActionMode.Add) > 0)
                        {
                            MessageBox.Show($"Issue '{issue.ISSUE_NUM}' save!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
                else
                {
                    if (_doPosted)
                    {
                        // Posting - update IssueItem
                        foreach (SKIssueItem item in _issueItems)
                        {
                            item.IsPosted = _doPosted;
                            if (new StockDAL().UpdateIssueItem(item, mode) > 0)
                            {
                            }
                        }

                        // Update Transaction
                        if (new StockDAL().PostedStockIssueItems(_issueItems) > 0)
                        {
                            // update last cost for ItemMaster
                            int _r = 0;
                            foreach (var _item in _issueItems)
                            {
                                _r += new ItemMasterDAL().UpdateLastUnitCost(_item.ItemNo);
                            }

                            if(_r > 0)
                            {
                                MessageBox.Show($"Posted Issue '{issue.ISSUE_NUM}' successfully!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
        }

        private void getIssueItems(string issueNo)
        {
            switch (_mode)
            {
                case DataActionMode.Add:
                    //_issueItems = new List<SKIssueItem>();
                    break;

                case DataActionMode.Edit:
                    _issueItems = new StockDAL().GetIssueItems(issueNo);
                    break;
            }

            dgv.SuspendLayout();
            dgv.DataSource = _issueItems.ToDataTable();

            dgv.Columns["Id"].Visible = false;
            dgv.Columns["IsPosted"].Visible = false;
            dgv.Columns["SK_Code"].Visible = false;
            dgv.Columns["SKI_ISSUE_NUM"].Visible = false;
            dgv.Columns["ItemId"].Visible = false;
            dgv.Columns["Currency"].Visible = false;

            dgv.Columns["UnitCost"].Visible = false;
            dgv.Columns["TotalItemCost"].Visible = false;

            dgv.Columns["ItemNo"].HeaderText = "Item-No.";
            dgv.Columns["ItemName"].HeaderText = "Description";
            dgv.Columns["IssueQty"].HeaderText = "Qty. Issue";
            dgv.Columns["IssueQty"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv.Columns["IssueQty"].DefaultCellStyle.Format = "N2";

            dgv.Columns["UnitPrice"].HeaderText = "Unit Price";
            dgv.Columns["UnitPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv.Columns["UnitPrice"].DefaultCellStyle.Format = "N2";

            dgv.Columns["TotalItemPrice"].HeaderText = "Extended Price";
            dgv.Columns["TotalItemPrice"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv.Columns["TotalItemPrice"].DefaultCellStyle.Format = "N2";

            dgv.ResumeLayout();

            UpdateIssueToolBar();

            txtTotalPrice.Text = $"{GetIssueTotalAmount():N2}";

        }

        private decimal GetIssueTotalAmount()
        {
            decimal _totalAmt = 0m;
            foreach (DataGridViewRow dgr in dgv.Rows)
            {
                _totalAmt += Convert.ToDecimal(dgr.Cells["TotalItemPrice"].Value);
            }
            return _totalAmt;
        }

        private void getIssueItemInfo(int issueItemId, string issueNo, DataActionMode IssueMode, DataActionMode ItemMode)
        {
            using (var _issueItemInfo = new StockIssueItem(_skCode, issueNo, issueItemId, IssueMode, ItemMode))
            {
                _issueItemInfo.StartPosition = FormStartPosition.CenterParent;
                if (_issueItemInfo.ShowDialog(this) == DialogResult.OK)
                {
                    switch (IssueMode)
                    {
                        case DataActionMode.Add:
                            _issueItems.Add(_issueItemInfo.IssueItem);
                            break;
                    }

                    getIssueItems(_issueNo);
                }
            }
        }

        #endregion

        public StockIssueInfo(String SKCode, String IssueNo)
        {
            InitializeComponent();
            _issueNo = IssueNo;
            _skCode = SKCode;
            _mode = String.IsNullOrEmpty(_issueNo) ? DataActionMode.Add : DataActionMode.Edit;

            utils.utilcore.SettingDataGrid(ref dgv);

            lbMode.Text = _mode.ToString();
            lbCode.Text = _skCode;

            getCurrency();
            getIssueReason();
        }

        private void StockIssueInfo_Load(object sender, EventArgs e)
        {
            GetIssueInfo(_issueNo);
        }

        private void dgv_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            _selectedIssueItemId = Convert.ToInt32(dgv["Id", e.RowIndex].Value);

            UpdateIssueToolBar();
        }

        private void dgv_DoubleClick(object sender, EventArgs e)
        {
            tsbtnEdit.PerformClick();
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            UpdateUI();
            UpdateIssueToolBar();
        }

        private void tsbtnRefresh_Click(object sender, EventArgs e)
        {
            // load IssueItems
            getIssueItems(_issueH.ISSUE_NUM);
        }

        private void tsbtnAdd_Click(object sender, EventArgs e)
        {
            _selectedIssueItemId = 0;
            _issueItemMode = DataActionMode.Add;
            getIssueItemInfo(_selectedIssueItemId, txtIssueNo.Text, _mode, _issueItemMode);
        }

        private void tsbtnEdit_Click(object sender, EventArgs e)
        {
            _issueItemMode = DataActionMode.Edit;
            getIssueItemInfo(_selectedIssueItemId, txtIssueNo.Text, _mode, _issueItemMode);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _doPosted = false;
            _issueH.IsPosted = _doPosted;
            _issueH.IssuedBy = txtIssuedBy.Text;
            _issueH.ISSUE_NUM = txtIssueNo.Text;
            _issueH.PostedBy = "";
            _issueH.PostedDate = null;
            _issueH.Reason = cbxReason.Text;
            _issueH.Remark = txtRemark.Text;
            _issueH.TotalPrice = Convert.ToDecimal(txtTotalPrice.Text);

            UpdateStockIssue(_issueH, _mode);

        }

        private void cbxCurrency_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                _issueH.Currency = cbxCurrency.SelectedValue.ToString();
            }
            catch
            {
            }
        }

        private void dtpIssueDate_ValueChanged(object sender, EventArgs e)
        {
            _issueH.IssueDate = dtpIssueDate.Value;
        }

        private void btnPostSave_Click(object sender, EventArgs e)
        {
            _doPosted = true;
            _mode = DataActionMode.Edit;
            _issueH.IsPosted = _doPosted;
            _issueH.PostedBy = vars.USER_NAME;
            _issueH.PostedDate = DateTime.Now;
            _issueH.ModifyBy = vars.USER_NAME;
            _issueH.ModifyDate = DateTime.Now;

            UpdateStockIssue(_issueH, _mode);

        }
    }
}
