using KIM.data;
using KIM.models.Warehouse;
using KIM.models.Warehouse.Inventory;
using KIM.views.warehouse;
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
    public partial class StockReceiveItem : Form
    {
        #region class field
        private data.ItemMaster _itemMaster;
        private DataActionMode _docMode = DataActionMode.None;
        private DataActionMode _mode = DataActionMode.None;
        private int _itemId = 0;
        private int _recordId = 0;
        private string _docNo = "";
        private string _SKCode = "";

        #endregion

        #region class properties
        public SKReceiveItem ItemReceive { get; set; }

        #endregion

        #region class helper
        private void updateUI()
        {
            btnSave.Enabled = (Convert.ToDecimal(txtReceiveQty.Text) > 0);
        }

        private void getUnits()
        {
            cbxUnit.DataSource = new SkuDAL().GetSKUs();
            cbxUnit.DisplayMember = "SKUCode";
            cbxUnit.ValueMember = "SKUCode";
        }

        private void GetItemInfo(int id)
        {
            switch (_mode)
            {
                case DataActionMode.Add:
                    this.ItemReceive = new SKReceiveItem();
                    this.ItemReceive.AvgUnitCost = 0m;
                    this.ItemReceive.SK_Code = _SKCode;
                    this.ItemReceive.Currency = "USD";
                    this.ItemReceive.SKR_DOC_NUM = _docNo;
                    this.ItemReceive.IsPosted = false;
                    this.ItemReceive.ItemId = 0;
                    this.ItemReceive.ItemName = "";
                    this.ItemReceive.ItemNo = "";
                    this.ItemReceive.ItemTotalAmount = 0m;
                    this.ItemReceive.OtherCost = 0m;
                    this.ItemReceive.Qty = 0m;
                    this.ItemReceive.SKI_ID = 0;
                    this.ItemReceive.TaxClearing = 0m;
                    this.ItemReceive.TotalItemCost = 0m;
                    this.ItemReceive.Transport = 0m;
                    this.ItemReceive.Unit = "PC";
                    this.ItemReceive.UnitCost = 0m;
                    break;

                case DataActionMode.Edit:
                    this.ItemReceive = new StockDAL().getStockReceiveItem(id);
                    break;
            }

            _itemId = this.ItemReceive.ItemId;
            txtItemNo.Text = this.ItemReceive.ItemNo;
            txtItemName.Text = this.ItemReceive.ItemName;
            txtCurrency.Text = this.ItemReceive.Currency;
            cbxUnit.SelectedValue = this.ItemReceive.Unit;
            txtUnitCost.Text = $"{this.ItemReceive.UnitCost:N2}";
            txtReceiveQty.Text = $"{this.ItemReceive.Qty:N2}";
            txtTotalItemCost.Text = $"{this.ItemReceive.TotalItemCost:N2}";

            txtTax.Text = $"{this.ItemReceive.TaxClearing:N2}";
            txtTransport.Text = $"{this.ItemReceive.Transport:N2}";
            txtOtherCost.Text = $"{this.ItemReceive.OtherCost:N2}";
            TxtTotalAmount.Text = $"{this.ItemReceive.ItemTotalAmount:N2}";
            txtAvgUnitCost.Text = $"{this.ItemReceive.AvgUnitCost:N2}";

            updateUI();
        }


        #endregion

        public StockReceiveItem(string SKCode, string DocNum,int recordId,int ItemId, DataActionMode docMode)
        {
            InitializeComponent();
            _docMode = docMode;
            _SKCode = SKCode;
            _docNo = DocNum;
            _itemId = ItemId;
            _recordId = recordId;
            _mode = (recordId == 0 ? DataActionMode.Add : DataActionMode.Edit);

            lbCode.Text = _SKCode;
            lbDocId.Text = _docNo;
            grpItem.Text = $"Stock Item [{_mode.ToString()}]";
            getUnits();
        }

        private void StockReceiveItem_Load(object sender, EventArgs e)
        {
            GetItemInfo(_recordId);
        }

        private void btnItemNo_Click(object sender, EventArgs e)
        {
            using (var _itemList = new StockItemList(""))
            {
                _itemList.StartPosition = FormStartPosition.CenterScreen;

                if (_itemList.ShowDialog(this) == DialogResult.OK)
                {
                    _itemMaster = _itemList.ItemStock;
                    _itemId = _itemMaster.ItemId;
                    lbItemId.Text = _itemId.ToString();
                    txtItemNo.Text = _itemMaster.ItemNo;
                    txtItemName.Text = _itemMaster.ItemName;
                    txtCurrency.Text = _itemMaster.Currency;
                    cbxUnit.SelectedValue = _itemMaster.StockUnit;
                }
            }
        }

        private void txt_Validating(object sender, CancelEventArgs e)
        {
            TextBox _text = sender as TextBox;
            bool _valid = _text.Text.IsNumeric();

            if (_valid == false)
            {
                MessageBox.Show("Only numeric is accepted!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _text.Focus();
                _text.SelectAll();
                e.Cancel = true;
            }
            else
            {
                _text.Text = $"{_text.Text:N2}";
            }
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            if (txtUnitCost.Text.IsNumeric() && txtReceiveQty.Text.IsNumeric())
            {
                txtTotalItemCost.Text = $"{CalTotalItemCost():N2}";
                updateUI();
            }
        }

        private decimal CalTotalItemCost()
        {
            if (!txtUnitCost.Text.IsNumeric()) return 0m;
            if (!txtReceiveQty.Text.IsNumeric()) return 0m;

            return (Convert.ToDecimal(txtUnitCost.Text) * Convert.ToDecimal(txtReceiveQty.Text));
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            this.ItemReceive.ItemId = _itemId;
            this.ItemReceive.ItemName = txtItemName.Text;
            this.ItemReceive.ItemNo = txtItemNo.Text;
            this.ItemReceive.ItemTotalAmount = Convert.ToDecimal(TxtTotalAmount.Text);
            this.ItemReceive.OtherCost = Convert.ToDecimal(txtOtherCost.Text);
            this.ItemReceive.Qty = Convert.ToDecimal(txtReceiveQty.Text);
            this.ItemReceive.TaxClearing = Convert.ToDecimal(txtTax.Text);
            this.ItemReceive.TotalItemCost = Convert.ToDecimal(txtTotalItemCost.Text);
            this.ItemReceive.Transport = Convert.ToDecimal(txtTransport.Text);
            this.ItemReceive.UnitCost = Convert.ToDecimal(txtUnitCost.Text);
            this.ItemReceive.AvgUnitCost = Convert.ToDecimal(txtAvgUnitCost.Text);

            if (_docMode == DataActionMode.Edit)
            {
                DataActionMode _itemMode = this.ItemReceive.SKI_ID == 0 ? DataActionMode.Add : DataActionMode.Edit;
                new StockDAL().UpdateStockReceiveItem(this.ItemReceive, _itemMode);
            }
        }

        private void cbxUnit_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                this.ItemReceive.Unit = cbxUnit.SelectedValue.ToString();
            }
            catch { }
        }
    }
}
