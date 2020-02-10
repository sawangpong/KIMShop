using KIM.models.Warehouse;
using KIM.data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KIM.utils;
using KIM.views.Master.Vendor;
using KIM.models;
using KIM.models.Tool;
using KIM.models.Master;

namespace KIM.views.warehouse
{
    public partial class ItemInfo : Form
    {
        #region class field
        private DataActionMode _mode = DataActionMode.None;
        private DataActionMode _itemPicMode = DataActionMode.None;
        private data.ItemMaster _itemMaster;
        private data.ItemMasterPic _itemMasterPic;
        private string _itemNo = "";

        #endregion

        #region class helper

        private void getCurrency()
        {
            cbxCurrency.DataSource = new models.Tool.CurrencyDAL().getCurrencies();
            cbxCurrency.DisplayMember = "CURCode";
            cbxCurrency.ValueMember = "CURCode";
        }
        private void getCategories()
        {
            cbxCAT.DataSource = new CategoryDAL().getCategories();
            cbxCAT.DisplayMember = "CatName";
            cbxCAT.ValueMember = "CatCode";
        }

        private void getAccountGroups()
        {
            cbxACC.DataSource = new AccountGroupDAL().GetAccountGroups();
            cbxACC.DisplayMember = "AccName";
            cbxACC.ValueMember = "AccGroup";
        }

        private void getWarehouses()
        {
            cbxWH.DataSource = new WarehouseDAL().GetWarehouses();
            cbxWH.DisplayMember = "WHName";
            cbxWH.ValueMember = "WHCode";
        }

        private void getSKUs()
        {
            cbxSKU.DataSource = new SkuDAL().GetSKUs();
            cbxSKU.DisplayMember = "SKUCode";
            cbxSKU.ValueMember = "SKUCode";
        }

        private void getUOMs()
        {
            cbxUOM.DataSource = new UOMDAL().GetUOMs();
            cbxUOM.DisplayMember = "UOMName";
            cbxUOM.ValueMember = "UOMName";
        }

        private void updateUI()
        {
            txtItemNo.Enabled = (_mode == DataActionMode.Add);
            btnItemNo.Visible = txtItemNo.Enabled;
            btnSave.Enabled = (!String.IsNullOrEmpty(txtItemNo.Text)
                                && !String.IsNullOrEmpty(txtItemDesc.Text)
                              );

            btnClearPic.Enabled = picMaster.Image != null;
        }

        private string getVendorName(string id) => new VendorDAL().GetVendorById(id).VendorName;
           
        private void getItemInfo(string itemno)
        {
            switch (_mode)
            {
                case DataActionMode.Add:
                    _itemMaster = new data.ItemMaster();
                    _itemMaster.ItemId = 0;
                    _itemMaster.WeightFactor = 1.0m;
                    _itemMaster.MaxQty = 0m;
                    _itemMaster.MinQty = 0m;
                    _itemMaster.ReorderQty = 0m;
                    _itemMaster.AccGroup = "CONSUME";
                    _itemMaster.CatCode = "MC";
                    _itemMaster.CreateBy = vars.USER_NAME;
                    _itemMaster.CreateDate = DateTime.Now;
                    _itemMaster.ImageLocate = "";
                    _itemMaster.InActive = false;
                    _itemMaster.IsStockItem = true;
                    _itemMaster.ModifyBy = vars.USER_NAME;
                    _itemMaster.ModifyDate = DateTime.Now;
                    _itemMaster.StockUnit = "PC";
                    _itemMaster.UnitWeight = 0.00m;
                    _itemMaster.VendorId = "";
                    _itemMaster.VendorItemNo = "";
                    _itemMaster.Warehouse = "WHSHOP";
                    _itemMaster.WeightUnit = "KG";
                    _itemMaster.barcode = null;
                    _itemMaster.UnitSellPrice = 0.00m;
                    _itemMaster.AvgUnitCost = 0.00m;
                    _itemMaster.Brand = "";
                    _itemMaster.Dimension = "";
                    _itemMaster.Currency = "USD";
                    
                    break;

                case DataActionMode.Edit:
                    _itemMaster = new ItemMasterDAL().getItemMasterById(itemno);
                    break;
            }

            chkInActive.Checked = _itemMaster.InActive;
            chkStockItem.Checked = _itemMaster.IsStockItem;
            txtItemDesc.Text = _itemMaster.ItemName;
            txtItemNo.Text = _itemMaster.ItemNo;
            txtUnitFactor.Text = $"{_itemMaster.WeightFactor:N4}";
            txtVendorCode.Text = _itemMaster.VendorId;
            txtVendorItem.Text = _itemMaster.VendorItemNo;
            txtVendorName.Text = (_mode == DataActionMode.Edit ? (String.IsNullOrEmpty(_itemMaster.VendorId) ? "" :  getVendorName(_itemMaster.VendorId)) : "");
            txtReorderQ.Text = $"{_itemMaster.ReorderQty:N2}";
            txtMaxQStock.Text = $"{_itemMaster.MaxQty:N2}";
            txtMinQStock.Text = $"{_itemMaster.MinQty}";
            txtUnitWeight.Text = $"{_itemMaster.UnitWeight:N4}";
            txtUnitSellPrice.Text = $"{_itemMaster.UnitSellPrice:N2}";
            txtAvgCost.Text = $"{_itemMaster.AvgUnitCost:N2}";
            txtUnitFactor.Text = $"{_itemMaster.WeightFactor:N4}";
            txtBrand.Text = _itemMaster.Brand;
            txtDimension.Text = _itemMaster.Dimension;

            barcodePic.Image = _itemMaster.barcode == null ? null : _itemMaster.barcode.ToImageFromByte();

            cbxACC.SelectedValue = _itemMaster.AccGroup;
            cbxCAT.SelectedValue = _itemMaster.CatCode;
            cbxSKU.SelectedValue = _itemMaster.StockUnit;
            cbxUOM.Text = _itemMaster.WeightUnit;
            cbxCurrency.SelectedValue = _itemMaster.Currency;
            cbxWH.SelectedValue = _itemMaster.Warehouse;

            lbItemId.Text = $"{_itemMaster.ItemId}";

            // get item image
            if (_mode == DataActionMode.Edit)
            {
                _itemMasterPic = new ItemMasterPicDAL().getItemPictureById(_itemMaster.ItemNo);
                _itemPicMode = _itemMasterPic == null ? DataActionMode.Add : DataActionMode.Edit;

                if (_itemMasterPic != null)
                {
                    picMaster.Image = _itemMasterPic.ItemPic == null ? null : _itemMasterPic.ItemPic.ToImageFromByte();
                }
            }
            else
            {
                _itemPicMode = DataActionMode.Add;
            }

            lbPicMode.Text = _itemPicMode.ToString();

            updateUI();
        }

        private void updateItemMaster(data.ItemMaster item, DataActionMode mode)
        {
            if(new ItemMasterDAL().updateItemMaster(item,mode) > 0)
            {
                if (_itemPicMode == DataActionMode.Add)
                {
                    if (picMaster.Image != null)
                    {
                        _itemMasterPic = new ItemMasterPic();
                        _itemMasterPic.ItemNo = _itemMaster.ItemNo;
                        _itemMasterPic.ItemPic = picMaster.Image.ImageToByte();
                        updateItemPicture(_itemMasterPic, _itemPicMode);
                    }
                }
                else if (_itemPicMode == DataActionMode.Edit) // item picture in edit mode
                {
                    if (picMaster.Image == null)
                    {
                        if (_itemPicMode == DataActionMode.Edit)
                        {
                            if (new ItemMasterPicDAL().removeItemMasterPic(_itemMaster.ItemNo) <= 0)
                            {
                            }
                        }
                    }
                    else
                    {
                        _itemMasterPic.ItemPic = picMaster.Image.ImageToByte();
                        updateItemPicture(_itemMasterPic, _itemPicMode);
                    }
                }
            }
        }
  
        private void updateItemPicture(ItemMasterPic item, DataActionMode mode)
        {
            if (new ItemMasterPicDAL().updateItemMasterPic(_itemMasterPic, _itemPicMode) > 0)
            {
                MessageBox.Show("Update Item master successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        public ItemInfo(string itemNo)
        {
            InitializeComponent();

            _itemNo = itemNo;

            _mode = (String.IsNullOrEmpty(_itemNo) ? DataActionMode.Add : DataActionMode.Edit);
            _itemPicMode = _mode == DataActionMode.Add ? DataActionMode.Add : DataActionMode.None;
            lbMode.Text = _mode.ToString();

            getCurrency();
            getCategories();
            getAccountGroups();
            getWarehouses();
            getSKUs();
            getUOMs();

        }

        private void ItemInfo_Load(object sender, EventArgs e)
        {
            getItemInfo(_itemNo);
        }

        private void cbxUOM_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                _itemMaster.WeightUnit = cbxUOM.Text;
                _itemMaster.WeightFactor = new UOMDAL().GetUnitFactor(_itemMaster.WeightUnit);
                 txtUnitFactor.Text = $"{_itemMaster.WeightFactor:N4}";
            }
            catch
            {
                txtUnitFactor.Text = $"{0:N4}";
            }
        }

        private void cbxWH_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                lbWHCode.Text = cbxWH.SelectedValue.ToString();
            }
            catch
            {
                lbWarehouse.Text = "";
            }
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            if (_mode == DataActionMode.Add)
            {
                TextBox txt = sender as TextBox;
                if (txt.Name == "txtItemNo")
                {
                    if (!String.IsNullOrEmpty(txtItemNo.Text))
                    {
                        Image _barcode = BarcodeUtils.GenerateBitmapBarcode(txtItemNo.Text);
                        barcodePic.Image = _barcode == null ? null : _barcode; // gen barcode
                    }
                    else
                    {
                        barcodePic.Image = null;
                    }
                }
            }
            
            updateUI();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _itemMaster.ItemNo = txtItemNo.Text;
            _itemMaster.ItemName = txtItemDesc.Text;
            _itemMaster.barcode = barcodePic.Image.ImageToByte();
            _itemMaster.Brand = txtBrand.Text;
            _itemMaster.Dimension = txtDimension.Text;
            _itemMaster.WeightUnit = cbxUOM.Text;
            _itemMaster.WeightFactor = Convert.ToDecimal(txtUnitFactor.Text);
            _itemMaster.MaxQty = Convert.ToDecimal(txtMaxQStock.Text);
            _itemMaster.MinQty = Convert.ToDecimal(txtMinQStock.Text);
            _itemMaster.ReorderQty = Convert.ToDecimal(txtReorderQ.Text);
            _itemMaster.UnitSellPrice = Convert.ToDecimal(txtUnitSellPrice.Text);
            _itemMaster.AvgUnitCost = Convert.ToDecimal(txtAvgCost.Text);
            _itemMaster.CreateBy = vars.USER_NAME;
            _itemMaster.CreateDate = DateTime.Now;
            _itemMaster.ImageLocate = "";
            _itemMaster.InActive = chkInActive.Checked;
            _itemMaster.IsStockItem = chkStockItem.Checked;
            _itemMaster.ModifyBy = vars.USER_NAME;
            _itemMaster.ModifyDate = DateTime.Now;
            _itemMaster.UnitWeight = Convert.ToDecimal(txtUnitWeight.Text);
            _itemMaster.VendorId = txtVendorCode.Text;
            _itemMaster.VendorItemNo = txtVendorItem.Text;

            // update data to databas
            updateItemMaster(_itemMaster, _mode);
        }

        private void cbxSKU_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                _itemMaster.StockUnit = cbxSKU.SelectedValue.ToString();
            }
            catch { }
        }

        private void cbxACC_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                _itemMaster.AccGroup = cbxACC.SelectedValue.ToString();
                lbAccCode.Text = _itemMaster.AccGroup;
            }
            catch 
            {

            }
        }

        private void cbxCAT_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                _itemMaster.CatCode = cbxCAT.SelectedValue.ToString();
            }
            catch
            {

            }
        }

        private void btnLoadPic_Click(object sender, EventArgs e)
        {
            picMaster.Image = ImageUtils.GetImageFile();
            updateUI();
        }

        private void btnClearPic_Click(object sender, EventArgs e)
        {
           // _itemPicMode = DataActionMode.Edit;
            picMaster.Image = null;
            updateUI();
        }

        private void chkInActive_CheckedChanged(object sender, EventArgs e)
        {
            _itemMaster.InActive = chkInActive.Checked;
        }

        private void chkStockItem_CheckedChanged(object sender, EventArgs e)
        {
            _itemMaster.IsStockItem = chkStockItem.Checked;
        }

        private void btnVendor_Click(object sender, EventArgs e)
        {
            using(var _vendorBox = new VendorBox(txtVendorCode.Text))
            {
                _vendorBox.StartPosition = FormStartPosition.CenterScreen;
                if(_vendorBox.ShowDialog(this) == DialogResult.OK)
                {
                    var _vendorData = _vendorBox.VendorSource;
                    if(_vendorData != null)
                    {
                        txtVendorCode.Text = _vendorData.VendorCode;
                        txtVendorName.Text = _vendorData.VendorName;
                    }
                }
            }
        }

        private void cbxCurrency_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                _itemMaster.Currency = cbxCurrency.SelectedValue.ToString();
            }
            catch { }
        }

        private void txt_Validating(object sender, CancelEventArgs e)
        {
            TextBox _tb = sender as TextBox;
            bool _valid = _tb.Text.IsNumeric();

            if (_valid == false)
            {
                MessageBox.Show("Only numeric value accepted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _tb.Focus();
                _tb.SelectAll();
                e.Cancel = true;
            }
            else
            {
                _tb.Text = $"{_tb.Text:N2}";
            }
        }
    }
}
