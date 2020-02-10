using KIM.data;
using KIM.models.Tool;
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
    public partial class StockReceiveInfo : Form
    {
        #region class field
        private string _SKCode = "";
        private string _docNum = "";
        private DataActionMode _mode = DataActionMode.None;
        private DataActionMode _itemMode = DataActionMode.None;
        private bool _doPost = false;
        private bool _isPostedItem = false;
        private SKReceiveH _stockH;
        private List<SKReceiveItem> _items = new List<SKReceiveItem>();
        private int _selectedStockReceiveRecordId = 0;
        private int _itemId = 0;

        #endregion

        #region class properties
        #endregion

        #region class helper

        private void UpdateUI()
        {
            txtReceiveNo.Enabled = (_mode == DataActionMode.Add);

            btnSave.Enabled = (!String.IsNullOrEmpty(txtReceiveNo.Text)
                                && !String.IsNullOrEmpty(txtReceiveBy.Text)
                                && !String.IsNullOrEmpty(cbxReason.Text)
                                );
            btnPostSave.Enabled = (btnSave.Enabled && dgv.Rows.Count > 0 && _mode == DataActionMode.Edit);
        }

        private void getCurrency()
        {
            cbxCurrency.DataSource = new CurrencyDAL().getCurrencies();
            cbxCurrency.DisplayMember = "CURCode";
            cbxCurrency.ValueMember = "CURCode";
        }

        private void getReason()
        {
            cbxReason.DataSource = new StockDAL().getStockReceiveReason();
            cbxReason.DisplayMember = "Reason";
            cbxReason.ValueMember = "Reason";
        }

        private void GetStokReceiveInfo(string docNum)
        {
            switch (_mode)
            {
                case DataActionMode.Add:
                    _stockH = new SKReceiveH();
                    _stockH.SK_Code = _SKCode;
                    _stockH.CreateBy = vars.USER_NAME;
                    _stockH.CreateDate = DateTime.Today;
                    _stockH.Currency = "USD";
                    _stockH.DocDate = DateTime.Today;
                    _stockH.DOC_NUM = "";
                    _stockH.DOC_ID = 0;
                    _stockH.IsPosted = false;
                    _stockH.PostedBy = "";
                    _stockH.PostedDate = null;
                    _stockH.ModifyBy = vars.USER_NAME;
                    _stockH.ModifyDate = DateTime.Today;
                    _stockH.OtherServices = 0m;
                    _stockH.Reason = "";
                    _stockH.ReceiveBy = vars.USER_NAME;
                    _stockH.Remark = "";
                    _stockH.TaxAndClearing = 0m;
                    _stockH.TotalAmount = 0m;
                    _stockH.TotalItemCost = 0m;
                    _stockH.TransportCost = 0m;
                    break;

                case DataActionMode.Edit:
                    _stockH = new StockDAL().getStokInfoById(docNum);
                    break;
            }

            txtReceiveNo.Text = _stockH.DOC_NUM;
            txtItemCost.Text = $"{_stockH.TotalItemCost:N2}";
            txtOtherCost.Text = $"{_stockH.OtherServices:N2}";
            txtReceiveBy.Text = _stockH.ReceiveBy;
            txtRemark.Text = _stockH.Remark;
            txtTaxClearing.Text = $"{_stockH.TaxAndClearing:N2}";
            txtTotalAmount.Text = $"{_stockH.TotalAmount:N2}";
            txtTransport.Text = $"{_stockH.TransportCost:N2}";
            cbxCurrency.SelectedValue = _stockH.Currency;
            cbxReason.Text = _stockH.Reason;
            chkIsPosted.Checked = _stockH.IsPosted;
            dtpDocDate.Value = _stockH.DocDate;

            UpdateUI();

            tsbtnRefresh.PerformClick();
        }

        private decimal GetTotalAmount()
        {
            if (!txtTransport.Text.IsNumeric()) return 0m;
            if (!txtTaxClearing.Text.IsNumeric()) return 0m;
            if (!txtOtherCost.Text.IsNumeric()) return 0m;
            if (!txtItemCost.Text.IsNumeric()) return 0m;

            return Convert.ToDecimal(txtOtherCost.Text) + Convert.ToDecimal(txtTaxClearing.Text) + Convert.ToDecimal(txtTransport.Text) + Convert.ToDecimal(txtItemCost.Text);
        }

        private decimal AverageShippingCostRatio()
        {
            if (Convert.ToDecimal(txtTransport.Text) == 0m) return 0m;
            if (Convert.ToDecimal(txtItemCost.Text) == 0m) return 0m;

            return (Convert.ToDecimal(txtTransport.Text) / Convert.ToDecimal(txtItemCost.Text));
        }

        private decimal AverageTaxRatio()
        {
            if (Convert.ToDecimal(txtTaxClearing.Text) == 0m) return 0m;
            if (Convert.ToDecimal(txtItemCost.Text) == 0m) return 0m;

            return (Convert.ToDecimal(txtTaxClearing.Text) / Convert.ToDecimal(txtItemCost.Text));
        }
        private decimal AverageOtherCostRatio()
        {
            if (Convert.ToDecimal(txtOtherCost.Text) == 0m) return 0m;
            if (Convert.ToDecimal(txtItemCost.Text) == 0m) return 0m;

            return (Convert.ToDecimal(txtOtherCost.Text) / Convert.ToDecimal(txtItemCost.Text));
        }

        private void UpdateStockReceive()
        {
            _stockH.IsPosted = _doPost;
            _stockH.SK_Code = _SKCode;
            _stockH.DocDate = dtpDocDate.Value;
            _stockH.DOC_NUM = txtReceiveNo.Text;
            if (_doPost) _stockH.PostedDate = DateTime.Now;
            _stockH.PostedBy = _doPost ? vars.USER_NAME : "";
            _stockH.ModifyDate = DateTime.Today;
            _stockH.OtherServices = Convert.ToDecimal(txtOtherCost.Text);
            _stockH.Reason = cbxReason.Text;
            _stockH.ReceiveBy = txtReceiveBy.Text;
            _stockH.Remark = txtRemark.Text;
            _stockH.TaxAndClearing = Convert.ToDecimal(txtTaxClearing.Text);
            _stockH.TotalAmount = Convert.ToDecimal(txtTotalAmount.Text);
            _stockH.TotalItemCost = Convert.ToDecimal(txtItemCost.Text);
            _stockH.TransportCost = Convert.ToDecimal(txtTransport.Text);

            //
            // update information
            //
            if (new StockDAL().updateStokReceiveH(_stockH, _mode) > 0)
            {
                // Save data only
                decimal _avgShippingCode = AverageShippingCostRatio();
                decimal _avgTax = AverageTaxRatio();
                decimal _avgOtherCode = AverageOtherCostRatio();

                if (_mode == DataActionMode.Edit) _items = new StockDAL().GetStockReceivedItemLists(_stockH.DOC_NUM);

                foreach (var _item in _items)
                {
                    _item.IsPosted = _doPost;
                    _item.Transport = _avgShippingCode * _item.TotalItemCost;
                    _item.TaxClearing = _avgTax * _item.TotalItemCost;
                    _item.OtherCost = _avgOtherCode * _item.TotalItemCost;
                    _item.ItemTotalAmount = (_item.TaxClearing + _item.Transport + _item.OtherCost + _item.TotalItemCost);
                    _item.AvgUnitCost = _item.ItemTotalAmount / _item.Qty;

                    new StockDAL().UpdateStockReceiveItem(_item, _mode);
                }

                // Posted Data to Transaction
                if (_doPost)
                {
                    if (new StockDAL().PostedStockRecivedItems(_items) <= 0)
                    {
                        // reset the state
                        _stockH.IsPosted = false;
                        _stockH.PostedDate = null;
                        _stockH.PostedBy = "";
                        if (new StockDAL().updateStokReceiveH(_stockH, _mode) > 0)
                        {
                            foreach (var _item in _items)
                            {
                                _item.IsPosted = false;
                                new StockDAL().UpdateStockReceiveItem(_item, _mode);
                            }
                        }
                        MessageBox.Show("Error posted,\n\n Please contact your administrator for help.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        // update last cost for ItemMaster
                        foreach (var _item in _items)
                        {
                            int _x = new ItemMasterDAL().UpdateLastUnitCost(_item.ItemNo);
                        }
                        MessageBox.Show("Posted update stock successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Update stock successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        #region Stock Receive Item

        private void GetStockReceiveItems(string docNo)
        {
            dgv.SuspendLayout();

            switch (_mode)
            {
                case DataActionMode.Add:
                    dgv.DataSource = _items.ToDataTable();
                    break;

                case DataActionMode.Edit:
                    dgv.DataSource = new StockDAL().GetStockReceivedItemLists(docNo).ToDataTable();
                    break;
            }

            // formatting datagridview
            dgv.Columns["SKI_ID"].Visible = false;
            dgv.Columns["IsPosted"].Visible = false;
            dgv.Columns["SK_Code"].Visible = false;
            dgv.Columns["ItemId"].Visible = false;
            dgv.Columns["SKR_DOC_NUM"].Visible = false;
            dgv.Columns["Currency"].Visible = false;

            dgv.Columns["UnitCost"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv.Columns["UnitCost"].HeaderText = "Unit Cost";

            dgv.Columns["Qty"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgv.Columns["TotalItemCost"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv.Columns["TotalItemCost"].HeaderText = "Item Cost";

            dgv.Columns["TaxClearing"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv.Columns["TaxClearing"].HeaderText = "Tax / Clearing";

            dgv.Columns["Transport"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv.Columns["Transport"].HeaderText = "Shipping Cost";

            dgv.Columns["OtherCost"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv.Columns["OtherCost"].HeaderText = "Other Cost";

            dgv.Columns["ItemTotalAmount"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv.Columns["ItemTotalAmount"].HeaderText = "Total amount";

            dgv.Columns["AvgUnitCost"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv.Columns["AvgUnitCost"].HeaderText = "AVG Unit Cost";

            dgv.ResumeLayout();

            txtItemCost.Text = $"{GetItemReceiveSummary():N2}";

            UpdateItemToolBar();
            UpdateUI();
        }

        private void UpdateItemToolBar()
        {
            tsbtnAdd.Enabled = !String.IsNullOrEmpty(txtReceiveNo.Text);
            tsbtnEdit.Enabled = (_selectedStockReceiveRecordId > 0 && dgv.Rows.Count > 0 && !_isPostedItem);
            tsbtnDelete.Enabled = tsbtnEdit.Enabled;
        }

        private void GetStockReceiveItemInfo(string SKcode, string docId, int recordId, int itemId, DataActionMode docMode)
        {
            using (var item = new StockReceiveItem(SKcode, docId, recordId, itemId, docMode))
            {
                item.StartPosition = FormStartPosition.CenterScreen;

                if (item.ShowDialog(this) == DialogResult.OK)
                {
                    _items.Add(item.ItemReceive);
                    tsbtnRefresh.PerformClick();
                }
            }
        }

        private decimal GetItemReceiveSummary()
        {
            if (dgv.Rows.Count == 0) return 0m;

            decimal _total = 0.00m;

            foreach (DataGridViewRow dgr in dgv.Rows)
            {
                _total += Convert.ToDecimal(dgr.Cells["TotalItemCost"].Value);
            }

            return _total;
        }
        #endregion


        #endregion

        public StockReceiveInfo(string SKCode, string docNum)
        {
            InitializeComponent();

            utils.utilcore.SettingDataGrid(ref dgv);

            _SKCode = SKCode;
            _docNum = docNum;
            _mode = String.IsNullOrEmpty(docNum) ? DataActionMode.Add : DataActionMode.Edit;

            lbMode.Text = _mode.ToString();
            lbCode.Text = _SKCode;

            getCurrency();
            getReason();

        }

        private void StockReceiveInfo_Load(object sender, EventArgs e)
        {
            GetStokReceiveInfo(_docNum);
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // post flag
            _doPost = false;

            // update stock
            UpdateStockReceive();
        }

        private void cbxCurrency_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                _stockH.Currency = cbxCurrency.SelectedValue.ToString();
            }
            catch { }
        }

        private void chkIsPosted_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void Txt_TextChanged(object sender, EventArgs e)
        {
            txtTotalAmount.Text = $"{GetTotalAmount():N2}";
        }

        private void Txt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter && e.KeyChar == (char)Keys.Tab)
            {
            }
        }

        private void Txt_Validating(object sender, CancelEventArgs e)
        {
            TextBox _text = sender as TextBox;
            bool _valid = _text.Text.IsNumeric();

            if (_valid == false)
            {
                MessageBox.Show("Only numeric is accepted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _text.Focus();
                _text.SelectAll();
                e.Cancel = true;
            }
            else
            {
                _text.Text = $"{_text.Text:N2}";
            }

        }

        private void btnPostSave_Click(object sender, EventArgs e)
        {
            // Post flag
            _doPost = true;

            // update stock
            UpdateStockReceive();
        }

        private void tsbtnAdd_Click(object sender, EventArgs e)
        {
            _itemMode = DataActionMode.Add;
            _selectedStockReceiveRecordId = 0;
            GetStockReceiveItemInfo(_SKCode, txtReceiveNo.Text, _selectedStockReceiveRecordId, _itemId, _mode);
        }

        private void tsbtnEdit_Click(object sender, EventArgs e)
        {
            _itemMode = DataActionMode.Edit;
            GetStockReceiveItemInfo(_SKCode, txtReceiveNo.Text, _selectedStockReceiveRecordId, _itemId, _mode);
        }

        private void dgv_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            _selectedStockReceiveRecordId = Convert.ToInt32(dgv["SKI_ID", e.RowIndex].Value.ToString());
            _itemId = Convert.ToInt32(dgv["ItemId", e.RowIndex].Value.ToString());
            _isPostedItem = Convert.ToBoolean(dgv["IsPosted", e.RowIndex].Value);
            tslbItemId.Text = $"{_selectedStockReceiveRecordId}";
            UpdateItemToolBar();
        }

        private void tsbtnRefresh_Click(object sender, EventArgs e)
        {
            GetStockReceiveItems(_stockH.DOC_NUM);
        }

        private void dgv_DoubleClick(object sender, EventArgs e)
        {
            tsbtnEdit.PerformClick();
        }

        private void txtReceiveNo_TextChanged(object sender, EventArgs e)
        {
            UpdateUI();
            UpdateItemToolBar();
        }
    }
}
