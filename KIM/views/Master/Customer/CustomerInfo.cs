using KIM.data;
using KIM.data.dummy;
using KIM.models;
using KIM.models.Master;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KIM.views.Master.Customer
{
    public partial class CustomerInfo : Form
    {
        #region class members
        private data.Customer _customer;
        private data.DeliveryAddr _addr;
        private List<data.DeliveryAddr> _addrs = new List<data.DeliveryAddr>();

        private DataActionMode _custMode = DataActionMode.None;
        private DataActionMode _addrMode = DataActionMode.None;

        private string _customerCode = String.Empty;
        private int _selectedDeliveryAddrId = 0;

        #endregion

        #region class properties

        #endregion

        #region class helper

        private void getIndustrials()
        {
            cbxIndustry.DataSource = EnumWithName<CustomerIndustry>.ParseEnum();
            cbxIndustry.DisplayMember = "NAMEValue";
            cbxIndustry.ValueMember = "VALUE";
        }

        private void getCustomerType()
        {
            cbxCustomerType.DataSource = EnumWithName<CustomerType>.ParseEnum();
            cbxCustomerType.DisplayMember = "NAMEValue";
            cbxCustomerType.ValueMember = "VALUE";
        }

        private void getCustomerStatus()
        {
            cbxStatus.DataSource = EnumWithName<CustomerStatus>.ParseEnum();
            cbxStatus.DisplayMember = "NAMEValue";
            cbxStatus.ValueMember = "VALUE";
        }

        private void getDeliveryAddOption()
        {
            cbxDeliveryAddr.DataSource = DeliveryAddrOption.getDeliveryAddrOptions();
            cbxDeliveryAddr.DisplayMember = "Name";
            cbxDeliveryAddr.ValueMember = "Value";
        }

        private void getCR()
        {
            cbxCreditTerm.DataSource = new CRTermDAL().getCreditTerms();
            cbxCreditTerm.DisplayMember = "CRTerm";
            cbxCreditTerm.ValueMember = "CRCode";
        }

        private void getCurrency()
        {
            cbxCurrency.DataSource = new models.Tool.CurrencyDAL().getCurrencies();
            cbxCurrency.DisplayMember = "CURCode";
            cbxCurrency.ValueMember = "CURCode";
        }

        private void customerInfo(string customerCode)
        {
            // Add
            if (String.IsNullOrEmpty(customerCode))
            {
                _customer = new data.Customer();
                _customer.Active = true;
                _customer.Address = "";
                _customer.Balance = 0.00m;
                _customer.City = "";
                _customer.CompanyName = "";
                _customer.ContactName = "";
                _customer.Country = "";
                _customer.Creditlimit = 0.00m;
                _customer.CreditTerm = "COD";
                _customer.Currency = "USD";
                _customer.CustomerCode = "";
                _customer.CustomerType = 1;
                _customer.DeliveryAddress = 0;
                _customer.Email = "";
                _customer.Fax = "";
                _customer.Industry = 5;
                _customer.Mobile = "";
                _customer.Phone = "";
                _customer.Province = "";
                _customer.Status = 1;
                _customer.TaxCode = "";
                _customer.Website = "";
                _customer.Zipcode = "";
 
                txtContactName.Text = _customer.ContactName;
                txtBalance.Text = $"{_customer.Balance:N2}";
                txtAddress.Text = _customer.Address;
                txtCity.Text = _customer.City;
                txtCompany.Text = _customer.CompanyName;
                txtCountry.Text = _customer.Country;
                txtCreditlimit.Text = $"{_customer.Creditlimit:N2}";
                txtCustomerCode.Text = _customer.CustomerCode;
                txtEmail.Text = _customer.Email;
                txtFax.Text = _customer.Fax;
                txtMobile.Text = _customer.Mobile;
                txtPhone.Text = _customer.Phone;
                txtProvince.Text = _customer.Province;
                txtTaxCode.Text = _customer.TaxCode;
                txtWebsite.Text = _customer.Website;
                txtZipCode.Text = _customer.Zipcode;
                cbxCreditTerm.SelectedValue = _customer.CreditTerm;
                cbxCurrency.SelectedValue = _customer.Currency;
                cbxCustomerType.SelectedValue = _customer.CustomerType;
                cbxDeliveryAddr.SelectedValue = _customer.DeliveryAddress;
                cbxIndustry.SelectedValue = _customer.Industry;
                cbxStatus.SelectedValue = _customer.Status;
                chkActive.Checked = _customer.Active;
            }
            else // edit
            {
                _customer = new CustomerDAL().getCustomerByCode(customerCode);
                txtContactName.Text = _customer.ContactName;
                txtBalance.Text = $"{_customer.Balance:N2}";
                txtAddress.Text = _customer.Address;
                txtCity.Text = _customer.City;
                txtCompany.Text = _customer.CompanyName;
                txtCountry.Text = _customer.Country;
                txtCreditlimit.Text = $"{_customer.Creditlimit:N2}";
                txtCustomerCode.Text = _customer.CustomerCode;
                txtEmail.Text = _customer.Email;
                txtFax.Text = _customer.Fax;
                txtMobile.Text = _customer.Mobile;
                txtPhone.Text = _customer.Phone;
                txtProvince.Text = _customer.Province;
                txtTaxCode.Text = _customer.TaxCode;
                txtWebsite.Text = _customer.Website;
                txtZipCode.Text = _customer.Zipcode;
                cbxCreditTerm.SelectedValue = _customer.CreditTerm;
                cbxCurrency.SelectedValue = _customer.Currency;
                cbxCustomerType.SelectedValue = _customer.CustomerType;
                cbxDeliveryAddr.SelectedValue = _customer.DeliveryAddress;
                cbxIndustry.SelectedValue = _customer.Industry;
                cbxStatus.SelectedValue = _customer.Status;
                chkActive.Checked = _customer.Active;
            }

            updateUI();
        }

        private void updateUI()
        {
            txtCustomerCode.Enabled = (_custMode == DataActionMode.Add);
            if (_custMode == DataActionMode.Add)
            {
                cbxDeliveryAddr.Enabled = (!String.IsNullOrEmpty(txtCustomerCode.Text));
            }
            btnSave.Enabled = (!String.IsNullOrEmpty(txtCustomerCode.Text) &&
                               !String.IsNullOrEmpty(txtCompany.Text) &&
                               !String.IsNullOrEmpty(txtCountry.Text)

                               );
        }

        private void updateCustomerInfo(data.Customer customer, DataActionMode mode)
        {
            // save customer info data
            int _result = new CustomerDAL().updateCustomer(customer, mode);

            // save delivery address info
            if(_custMode == DataActionMode.Add)
            {
                if(_addrs.Count > 0)
                {
                    foreach(DeliveryAddr address in _addrs)
                    {
                        int _done = new CustomerDAL().updateDeliveryAddr(address, DataActionMode.Add);
                    }
                }
            }


            if (_result > 0)
            {
                MessageBox.Show("update customer information successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Question);
            }
        }

        private void getDeliveryAddrList(string custCode)
        {
            dgvAddr.SuspendLayout();

            _addrs = new CustomerDAL().getFullDeliveryList(custCode);
            dgvAddr.DataSource = _addrs.ToDataTable();
            tslbRecords.Text = $"found:{dgvAddr.Rows.Count}";

            // formatting dgv
            foreach(DataGridViewColumn dgc in dgvAddr.Columns)
            {
                if(dgc.Name != "Address" && dgc.Name != "ContactName")
                {
                    dgc.Visible = false;
                }
            }

            dgvAddr.Columns["Address"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvAddr.Columns["Address"].HeaderText = "Address";
            dgvAddr.Columns["ContactName"].HeaderText = "Contact name";
 
            dgvAddr.ResumeLayout();

            updateDeliveryAddrUI();
        }

        private void deliveryAddrInfo(DeliveryAddr addr, DataActionMode custMode, DataActionMode addrMode)
        {
            using(var _da = new views.Master.Customer.AddrInfo(addr, custMode, addrMode))
            {
                _da.StartPosition = FormStartPosition.CenterScreen;
                if(_da.ShowDialog(this) == DialogResult.OK)
                {
                    // add to delivery address collection
                    if (_custMode == DataActionMode.Add)
                    {
                        _addrs.Add(_da.Address);
                        dgvAddr.DataSource = _addrs.ToDataTable();
                    }
                }
            }

            if(_custMode != DataActionMode.Add)
            {
                tsbtnRefresh.PerformClick();
            }
        }

        private void updateDeliveryAddrUI()
        {
            tsbtnEditAddr.Enabled = (dgvAddr.Rows.Count > 0);
            tsbtnDeleteAddr.Enabled = tsbtnEditAddr.Enabled;
        }

        #endregion

        public CustomerInfo(string customerCode)
        {
            InitializeComponent();
            _customerCode = customerCode;

            _custMode = String.IsNullOrEmpty(_customerCode) ? DataActionMode.Add : DataActionMode.Edit;
            lbMode.Text = _custMode.ToString();

            //utils.utilcore.SettingDataGrid(ref dgvAddr);

            dgvAddr.DoubleBuffered(true);
            dgvAddr.SettingDataGrid();

            getCustomerType();
            getIndustrials();
            getCR();
            getDeliveryAddOption();
            getCurrency();
            getCustomerStatus();
        }

        private void CustomerInfo_Load(object sender, EventArgs e)
        {
            // initial values
            if (_custMode == DataActionMode.Add) _customerCode = "";

            customerInfo(_customerCode);

        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            updateUI();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _customer.Active = chkActive.Checked;
            _customer.Address = txtAddress.Text;
            _customer.Balance = Convert.ToDecimal(txtBalance.Text);
            _customer.City = txtCity.Text;
            _customer.CompanyName = txtCompany.Text;
            _customer.ContactName = txtContactName.Text;
            _customer.Country = txtCountry.Text;
            _customer.Creditlimit = Convert.ToDecimal(txtCreditlimit.Text);
            _customer.CustomerCode = txtCustomerCode.Text.ToUpper();
            _customer.Email = txtEmail.Text;
            _customer.Fax = txtFax.Text;
            _customer.Mobile = txtMobile.Text;
            _customer.Phone = txtPhone.Text;
            _customer.Province = txtProvince.Text;
            _customer.TaxCode = txtTaxCode.Text;
            _customer.Website = txtWebsite.Text;
            _customer.Zipcode = txtZipCode.Text;

            updateCustomerInfo(_customer, _custMode);
        }

        private void cbxCustomerType_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                _customer.CustomerType = Convert.ToInt32(cbxCustomerType.SelectedValue);
            }
            catch
            {
            }
        }

        private void cbxIndustry_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                _customer.Industry = Convert.ToInt32(cbxIndustry.SelectedValue);
            }
            catch
            {
            }
        }

        private void cbxCreditTerm_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                _customer.CreditTerm = cbxCreditTerm.SelectedValue.ToString();
            }
            catch
            {
            }
        }

        private void cbxCurrency_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                _customer.Currency = cbxCurrency.SelectedValue.ToString();
            }
            catch
            {
            }
        }

        private void cbxStatus_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                _customer.Status = Convert.ToInt32(cbxStatus.SelectedValue);
            }
            catch
            {
            }
        }

        private void cbxDeliveryAddr_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                _customer.DeliveryAddress = Convert.ToInt32(cbxDeliveryAddr.SelectedValue);
                pnlAddr.Visible = (_customer.DeliveryAddress > 0);

                // load deliveryAddress List
                getDeliveryAddrList(_customerCode);
            }
            catch
            { }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Cancel update customer information..", "Cancel", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void dgvAddr_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            _selectedDeliveryAddrId = Convert.ToInt32(dgvAddr["Id", e.RowIndex].Value);

            updateDeliveryAddrUI();
        }

        private void dgvAddr_DoubleClick(object sender, EventArgs e)
        {
            tsbtnEditAddr.PerformClick();
        }

        private void tsbtnAddAddr_Click(object sender, EventArgs e)
        {
            _addr = new DeliveryAddr();
            _addr.CustCode = txtCustomerCode.Text;
            _addrMode = DataActionMode.Add;
            deliveryAddrInfo(_addr,_custMode, _addrMode);
        }

        private void tsbtnEditAddr_Click(object sender, EventArgs e)
        {
            _addrMode = DataActionMode.Edit;
            _addr = new CustomerDAL().getAddrById(_selectedDeliveryAddrId);
            deliveryAddrInfo(_addr, _custMode ,_addrMode);
        }

        private void tsbtnRefresh_Click(object sender, EventArgs e)
        {
            getDeliveryAddrList(_customerCode);
        }

        private void tsbtnDeleteAddr_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to delete the selected item?","Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if(new CustomerDAL().removeDeliveryAddr(_selectedDeliveryAddrId) <= 0)
                {
                    MessageBox.Show("Delete record not success, contact your administrator....","Error", MessageBoxButtons.OK,  MessageBoxIcon.Error);
                }

                tsbtnRefresh.PerformClick();
            }
        }

        private void txtCreditlimit_Validating(object sender, CancelEventArgs e)
        {
            TextBox _text = sender as TextBox;
            if(_text.Text.IsNumeric() == false)
            {
                MessageBox.Show("Only numeric accepted", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _text.Focus();
                _text.SelectAll();
                e.Cancel = true;
            }
            
        }
    }
}
