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
    public partial class StockIssueItem : Form
    {
        #region class field
        private SKIssueItem _item;
        private string _skCode = "";
        private string _issueNo = "";
        private int _issueId = 0;
        private DataActionMode _issueItemMode = DataActionMode.None;
        private DataActionMode _issueMode = DataActionMode.None;

        private decimal _currentItemOnhand = 0m;
        private decimal _currentItemAvailable = 0m;

        #endregion

        #region class properties

        public SKIssueItem IssueItem { get; set; }

        #endregion

        #region class helper
        private void updateUI()
        {
            txtItemNo.Enabled = (_issueItemMode == DataActionMode.Add);
            btnItemNo.Enabled = (!String.IsNullOrEmpty(txtItemNo.Text) && _issueItemMode == DataActionMode.Add);
            btnSave.Enabled = (!String.IsNullOrEmpty(txtItemNo.Text) && Convert.ToDecimal(txtIssueQty.Text) > 0m);
        }
        private void getUnits()
        {
            cbxUnit.DataSource = new SkuDAL().GetSKUs();
            cbxUnit.DisplayMember = "SKUCode";
            cbxUnit.ValueMember = "SKUCode";
        }

        private void getItem(int id)
        {
            switch (_issueItemMode)
            {
                case DataActionMode.Add:
                    _item = new SKIssueItem();
                    _item.Currency = "USD";
                    _item.IsPosted = false;
                    _item.IssueQty = 0m;
                    _item.ItemId = 0;
                    _item.ItemName = "";
                    _item.ItemNo = "";
                    _item.SKI_ISSUE_NUM = _issueNo;
                    _item.SK_Code = _skCode;
                    _item.Unit = "PC";
                    _item.TotalItemPrice = 0m;
                    _item.TotalItemCost = 0m;
                    _item.UnitPrice = 0m;
                    _item.UnitCost = 0m;

                    break;

                case DataActionMode.Edit:
                    _item = new StockDAL().GetIssueItemInfo(id);
                    break;
            }

            txtIssueQty.Text = $"{_item.IssueQty:N2}";
            txtItemName.Text = _item.ItemName;
            txtItemNo.Text = _item.ItemNo;
            txtCurrency.Text = _item.Currency;
            txtUnitCost.Text = $"{_item.UnitCost:N2}";
            txtTotalCost.Text = $"{_item.TotalItemCost:N2}";
            txtUnitPrice.Text = $"{_item.UnitPrice:N2}";
            txtTotalIssuePrice.Text = $"{_item.TotalItemPrice:N2}";
            cbxUnit.SelectedValue = _item.Unit;

            if (_issueItemMode == DataActionMode.Edit)
            {
                GetItemOnhand(_item.ItemNo);
            }

            updateUI();
        }

        private void GetOnhandList(string filter)
        {
            using (var _onhand = new StockOnhand(filter))
            {
                _onhand.StartPosition = FormStartPosition.CenterScreen;
                if (_onhand.ShowDialog(this) == DialogResult.OK)
                {
                    txtCurrency.Text = _onhand.Currency;
                    txtItemName.Text = _onhand.ItemName;
                    txtItemNo.Text = _onhand.ItemNo;
                    txtUnitCost.Text = $"{_onhand.UnitCost:N2}";
                    cbxUnit.SelectedValue = _onhand.Unit;
                    txtUnitPrice.Text = $"{GetItemPrice(_onhand.ItemNo):N2}";

                    // display Onhand list
                    GetItemOnhand(txtItemNo.Text);
                }
            }
        }

        private Decimal GetItemPrice(String itemNo)
        {
            return new ItemMasterDAL().GetItemPrice(itemNo);
        }

        private void GetItemOnhand(string itemNo)
        {
            dgv.SuspendLayout();
            dgv.DataSource = new StockDAL().GetStockBalance(txtItemNo.Text);
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgv.Columns["ItemNo"].Visible = false;
            dgv.Columns["ITEMNAME"].Visible = false;
            dgv.Columns["SK_UNIT"].Visible = false;
            dgv.Columns["CURRENCY"].Visible = false;
            dgv.Columns["LastUpdate"].Visible = false;
            dgv.Columns["UnitCost"].Visible = false;

            dgv.Columns["OnHand"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv.Columns["Booking"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv.Columns["Available"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv.Columns["OnOrder"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;


            dgv.Columns["TotalValue"].DefaultCellStyle.Format = "N2";
            dgv.Columns["TotalValue"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;

            dgv.ResumeLayout();

            _currentItemAvailable = Convert.ToDecimal(dgv["Available", 0].Value);
            _currentItemOnhand = Convert.ToDecimal(dgv["OnHand", 0].Value);
            lbOnHand.Text = $"{_currentItemOnhand:N2} / {_currentItemAvailable:N2}";
        }

        private decimal SumTotalPriceValues()
        {
            if (!txtUnitPrice.Text.IsNumeric()) return 0m;
            if (!txtIssueQty.Text.IsNumeric()) return 0m;

            return Convert.ToDecimal(txtIssueQty.Text) * Convert.ToDecimal(txtUnitPrice.Text);
        }

        private decimal SumTotalCostValues()
        {
            if (!txtUnitCost.Text.IsNumeric()) return 0m;
            if (!txtIssueQty.Text.IsNumeric()) return 0m;

            return Convert.ToDecimal(txtIssueQty.Text) * Convert.ToDecimal(txtUnitCost.Text);
        }

        private void UpdateIssueItem(SKIssueItem item)
        {
            if (new StockDAL().UpdateIssueItem(item, _issueItemMode) <= 0)
            {
                MessageBox.Show("Can't update issue item!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion


        public StockIssueItem(string SKCode, string IssueNo, int IssueItemId, DataActionMode IssueMode, DataActionMode IssueItemMode)
        {
            InitializeComponent();

            //utils.utilcore.SettingDataGrid(ref dgv);
            dgv.DoubleBuffered(true);
            dgv.SettingDataGrid();

            _skCode = SKCode;
            _issueNo = IssueNo;
            _issueId = IssueItemId;
            _issueMode = IssueMode;
            _issueItemMode = IssueItemMode;

            lbCode.Text = _skCode;
            lbIssueNo.Text = _issueNo;
            lbItemId.Text = IssueItemId.ToString();

            grpItem.Text = $"Stock Issue Item [{_issueItemMode.ToString()}]";

            getUnits();
        }

        private void StockIssueItem_Load(object sender, EventArgs e)
        {
            getItem(_issueId);
        }

        private void txtItemNo_TextChanged(object sender, EventArgs e)
        {
            updateUI();
        }

        private void txtItemNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnItemNo.PerformClick();
            }
        }

        private void btnItemNo_Click(object sender, EventArgs e)
        {
            GetOnhandList(txtItemNo.Text);
        }

        private void txt_Validating(object sender, CancelEventArgs e)
        {
            TextBox _textBox = sender as TextBox;
            bool _valid = _textBox.Text.IsNumeric();

            if (_valid == false)
            {
                MessageBox.Show("Only numeric value accepted!.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _textBox.Focus();
                _textBox.SelectAll();
                e.Cancel = true;
            }
            else
            {
                if(_textBox.Name == "txtIssueQty")
                {
                    if(Convert.ToDecimal(_textBox.Text) > _currentItemAvailable)
                    {
                       if( MessageBox.Show("Quantity Issue must be equal or less than Available Qty.","Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning) == DialogResult.OK)
                        {
                            _textBox.Focus();
                            _textBox.SelectAll();
                            e.Cancel = true;
                        }
                    }
                }

                _textBox.Text = $"{_textBox.Text:N2}";
            }
        }

        private void txtIssueQty_TextChanged(object sender, EventArgs e)
        {
            txtTotalIssuePrice.Text = $"{SumTotalPriceValues():N2}";
            txtTotalCost.Text = $"{SumTotalCostValues():N2}";
            updateUI();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _item.Currency = txtCurrency.Text;
            _item.IssueQty = Convert.ToDecimal(txtIssueQty.Text);
            _item.ItemNo = txtItemNo.Text;
            _item.ItemName = txtItemName.Text;
            _item.UnitPrice = Convert.ToDecimal(txtUnitPrice.Text);
            _item.TotalItemPrice = Convert.ToDecimal(txtTotalIssuePrice.Text);
            _item.UnitCost = Convert.ToDecimal(txtUnitCost.Text);
            _item.TotalItemCost = Convert.ToDecimal(txtTotalCost.Text);

            switch (_issueMode)
            {
                case DataActionMode.Add:
                    this.IssueItem = _item;
                    break;

                case DataActionMode.Edit:
                    UpdateIssueItem(_item);
                    break;
            }
        }

        private void cbxUnit_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                _item.Unit = cbxUnit.SelectedValue.ToString();
            }
            catch
            {

            }
        }
    }
}
