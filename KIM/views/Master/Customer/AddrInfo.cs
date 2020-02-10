using KIM.data;
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
    public partial class AddrInfo : Form
    {
        #region class field member
        private string _code = "";
        private DataActionMode _addrMode = DataActionMode.None;
        private DataActionMode _custMode = DataActionMode.None;

        //private DeliveryAddr _addr;
        #endregion

        #region class properties
        public DeliveryAddr Address { get; set; }

        #endregion

        #region class helper
        private void updateUI()
        {
            btnSave.Enabled = ( !String.IsNullOrEmpty(txtProvince.Text) &&
                                !String.IsNullOrEmpty(txtCountry.Text) &&
                                !String.IsNullOrEmpty(txtContactName.Text) 
                              );
        }

        private void addressInfo(DeliveryAddr addr)
        {
            txtAddress.Text = addr.Address;
            txtCity.Text = addr.City;
            txtContactName.Text = addr.ContactName;
            txtCountry.Text = addr.Country;
            txtFax.Text = addr.fax;
            txtEmail.Text = addr.email;
            txtMobile.Text = addr.mobile;
            txtPhone.Text = addr.phone;
            txtProvince.Text = addr.Province;
            txtZipCode.Text = addr.Zipcode;

            updateUI();
        }

        #endregion


        public AddrInfo(DeliveryAddr addr, DataActionMode custMode, DataActionMode addrMode)
        {
            InitializeComponent();
            Address = addr;
            _custMode = custMode;
            _addrMode = addrMode;

            lbMode.Text = _addrMode.ToString();
            lbCustomerCode.Text = Address.CustCode;
        }

        private void AddrInfo_Load(object sender, EventArgs e)
        {
            addressInfo(Address);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Address.Address = txtAddress.Text;
            Address.City = txtCity.Text;
            Address.ContactName = txtContactName.Text;
            Address.Country = txtCountry.Text;
            Address.CustCode = lbCustomerCode.Text;
            Address.email = txtEmail.Text;
            Address.fax = txtFax.Text;
            Address.mobile = txtMobile.Text;
            Address.phone = txtPhone.Text;
            Address.Province = txtProvince.Text;
            Address.Zipcode = txtZipCode.Text;

            if(_custMode != DataActionMode.Add)
            {
                var _result = new CustomerDAL().updateDeliveryAddr(Address, _addrMode);
            }
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            updateUI();
        }
    }
}
