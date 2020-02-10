using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KIM.data;
using KIM.models;
using KIM.models.Master;
using KIM.models.Tool;

namespace KIM.views.Master.Vendor
{
    public partial class VendorInfo : Form
    {
        #region class field member
        private data.Vendor _vendor = new data.Vendor();
        private DataActionMode _mode = DataActionMode.None;
        private string _vendorCode = "";
        #endregion

        #region class properties

        #endregion

        #region class helper
        private void updateUI()
        {
            txtVendorCode.Enabled = (_mode == DataActionMode.Add);
            btnSave.Enabled = (!String.IsNullOrEmpty(txtVendorCode.Text) 
                                && !String.IsNullOrWhiteSpace(txtVendorName.Text)
                              );
        }

        private void getCurrency()
        {
            cbxCurrency.DataSource = new models.Tool.CurrencyDAL().getCurrencies();
            cbxCurrency.DisplayMember = "CURCode";
            cbxCurrency.ValueMember = "CURCode";
        }

        private void getVendorStatus()
        {
            cbxStatus.DataSource = EnumWithName<VendorStatus>.ParseEnum();
            cbxStatus.DisplayMember = "NameValue";
            cbxStatus.ValueMember = "Value";
        }

        private void getVendorType()
        {
            cbxVendorType.DataSource = EnumWithName<VendorType>.ParseEnum();
            cbxVendorType.DisplayMember = "NameValue";
            cbxVendorType.ValueMember = "Value";
        }

        private void getVendorInfo(string vendorCode)
        {
            switch (_mode)
            {
                case DataActionMode.Add:
                    _vendor = new data.Vendor();
                    _vendor.VendorType = 1;
                    _vendor.Status = 1;
                    _vendor.Isactive = true;
                    _vendor.Currency = cbxCurrency.Text;
                    break;

                case DataActionMode.Edit:
                    _vendor = new VendorDAL().GetVendorById(vendorCode);
                    break;
            }
            chkIsActive.Checked = _vendor.Isactive;
            txtAddress.Text = _vendor.Address;
            txtCity.Text = _vendor.City;
            txtContactName.Text = _vendor.ContactName;
            txtCountry.Text = _vendor.Country;
            txtEmail.Text = _vendor.email;
            txtFax.Text = _vendor.Fax;
            txtMobile.Text = _vendor.mobile;
            txtPhone.Text = _vendor.Tel;
            txtProvince.Text = _vendor.Province;
            txtWebsite.Text = _vendor.website;
            txtZipCode.Text = _vendor.Zipcode;
            txtVendorCode.Text = _vendor.VendorCode;
            txtVendorName.Text = _vendor.VendorName;
            cbxCurrency.SelectedValue = _vendor.Currency;
            cbxStatus.SelectedValue = _vendor.Status;
            cbxVendorType.SelectedValue = _vendor.VendorType;
            updateUI();
        }


        private void updateVendorInfo(DataActionMode mode)
        {
            _vendor.Address = txtAddress.Text;
            _vendor.City = txtCity.Text;
            _vendor.ContactName = txtContactName.Text;
            _vendor.Country = txtCountry.Text;
            _vendor.Currency = cbxCurrency.Text;
            _vendor.email = txtEmail.Text;
            _vendor.Fax = txtFax.Text;
            _vendor.Isactive = chkIsActive.Checked;
            _vendor.mobile = txtMobile.Text;
            _vendor.Province = txtProvince.Text;
            _vendor.Tel = txtPhone.Text;
            _vendor.VendorCode = txtVendorCode.Text;
            _vendor.VendorName = txtVendorName.Text;
            _vendor.website = txtWebsite.Text;
            _vendor.Zipcode = txtZipCode.Text;

            int _result = new VendorDAL().UpdateVendor(_vendor, _mode);

            if(_result > 0)
            {
                MessageBox.Show("Vendor record update successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        #endregion


        public VendorInfo(string vendorCode)
        {
            InitializeComponent();

            _vendorCode = vendorCode;
            _mode = String.IsNullOrEmpty(vendorCode) ? DataActionMode.Add : DataActionMode.Edit;
            lbMode.Text = _mode.ToString();
            getCurrency();
            getVendorStatus();
            getVendorType();
        }

        private void VendorInfo_Load(object sender, EventArgs e)
        {
            getVendorInfo(_vendorCode);
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            updateUI();

        }

        private void cbxStatus_SelectionChangeCommitted(object sender, EventArgs e)
        {
        }

        private void cbxVendorType_SelectionChangeCommitted(object sender, EventArgs e)
        {
        }

        private void cbxCurrency_SelectionChangeCommitted(object sender, EventArgs e)
        {
            _vendor.Currency = cbxCurrency.Text;
        }

        private void cbxStatus_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                _vendor.Status = Convert.ToInt32(cbxStatus.SelectedValue.ToString());
            }
            catch
            {

            }
        }

        private void cbxVendorType_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                _vendor.VendorType = Convert.ToInt32(cbxVendorType.SelectedValue.ToString());
            }
            catch
            {

            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            updateVendorInfo(_mode);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
