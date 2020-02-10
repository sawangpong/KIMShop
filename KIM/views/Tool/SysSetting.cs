
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using KIM.utils;
using KIM.models.Warehouse;
using KIM.data;
using KIM.models.AppSystem;
using KIM.models;
using KIM.models.Tool;


namespace KIM.views.Tool
{
    public partial class SysSetting : Form
    {
        #region class field
        private DataActionMode _mode = DataActionMode.None;
        private SysProfile _profile;
        private string _companyId = "";
        #endregion

        #region class properties

        #endregion

        #region class helper
        private void updateUI()
        {
            txtCompanyCode.Enabled = (_mode == DataActionMode.Add);
            btnSave.Enabled = (!String.IsNullOrWhiteSpace(txtCompanyCode.Text)
                                && !String.IsNullOrWhiteSpace(txtCompanyName.Text)
                                && !String.IsNullOrWhiteSpace(txtCountry.Text)
                                && !String.IsNullOrWhiteSpace(txtServerName.Text)
                                && !String.IsNullOrWhiteSpace(txtDatabaseName.Text)
                                && !String.IsNullOrWhiteSpace(txtDbAdmin.Text));
        }

        private void getSourchCurrency()
        {
            cbxSourceCurrency.DataSource = new CurrencyDAL().getCurrencies();
            cbxSourceCurrency.DisplayMember = "CURCode";
            cbxSourceCurrency.ValueMember = "CURCode";
        }

        private void getHomeCurrency()
        {
            cbxHomeCurrency.DataSource = new CurrencyDAL().getCurrencies();
            cbxHomeCurrency.DisplayMember = "CURCode";
            cbxHomeCurrency.ValueMember = "CURCode";
        }

        private void getWarehouses()
        {
            cbxDefaultWH.DataSource = new WarehouseDAL().GetWarehouses();
            cbxDefaultWH.DisplayMember = "WHName";
            cbxDefaultWH.ValueMember = "WHCode";
        }

        private void getUOMs()
        {
            cbxUOM.DataSource = new UOMDAL().GetUOMs();
            cbxUOM.DisplayMember = "UOMName";
            cbxUOM.ValueMember = "Factor";
        }

        private void getLang()
        {
            cbxLang.DataSource = new SystemDAL().GetLanguageTable();
            cbxLang.DisplayMember = "LanguageName";
            cbxLang.ValueMember = "LangCode";
        }

        private void getCreditTerm()
        {
            cbxCreditTerm.DataSource = new CRTermDAL().getCreditTerms();
            cbxCreditTerm.DisplayMember = "CRTerm";
            cbxCreditTerm.ValueMember = "CRCode";
        }

        private void GetProfile(string CompanyId)
        {
            switch (_mode)
            {
                case DataActionMode.Add:
                    _profile = new SysProfile();

                    _profile.Address = "";
                    _profile.AllowNagativeInventory = false;
                    _profile.CompanyCode = vars.COMPANY_CODE;
                    _profile.CompanyName = "";
                    _profile.ContactName = "";
                    _profile.Country = "";
                    _profile.CreditDuration = 0;
                    _profile.CreditLimit = 1000m;
                    _profile.DatabaseName = vars.DEFAULT_DB_NAME;
                    _profile.DBAdmin = vars.DBUSER;
                    _profile.DBAdminPassword = vars.DBPassword;
                    _profile.DefaultLangCode = "EN";
                    _profile.DefaultWeightUOM = "GRAM";
                    _profile.DefaultWH = "";
                    _profile.HomeCurrency = "USD";
                    _profile.ImageLocation = "";
                    _profile.PaymentTerm = "COD";
                    _profile.ProfitMarkupRate = 100.0m;
                    _profile.ServerName = vars.SERVER;
                    _profile.SourceCurrency = "USD";
                    _profile.TaxID = "";
                    _profile.TelFax = "";
                    _profile.VATRate = 7.0m;
                    break;

                case DataActionMode.Edit:
                    _profile = new SystemDAL().GetSystemProfile(CompanyId);
                    break;

            }
            MapProfile();
        }

        private void MapProfile()
        {
            txtAddress.Text = _profile.Address;
            txtCompanyCode.Text = _profile.CompanyCode;
            txtCompanyName.Text = _profile.CompanyName;
            txtContactName.Text = _profile.ContactName;
            txtCountry.Text = _profile.Country;
            txtDatabaseName.Text = _profile.DatabaseName;
            txtDbAdmin.Text = _profile.DBAdmin;
            txtDbPassword.Text = _profile.DBAdminPassword;
            txtDefaultCreditduration.Text = _profile.CreditDuration.ToString();
            txtDefaultCreditLimit.Text = $"{_profile.CreditLimit:N2}";
            txtImageLocation.Text = _profile.ImageLocation;
            txtMarkupProfit.Text = $"{_profile.ProfitMarkupRate:N2}";
            txtServerName.Text = _profile.ServerName;
            txtTaxId.Text = _profile.TaxID;
            txtTelFax.Text = _profile.TelFax;
            txtVATRate.Text = $"{_profile.VATRate:N2}";

            cbxCreditTerm.SelectedValue = _profile.PaymentTerm;
            cbxDefaultWH.SelectedValue = _profile.DefaultWH;
            cbxHomeCurrency.SelectedValue = _profile.HomeCurrency;
            cbxLang.SelectedValue = _profile.DefaultLangCode;
            cbxSourceCurrency.SelectedValue = _profile.SourceCurrency;
            cbxUOM.SelectedText = _profile.DefaultWeightUOM;

            chkAllowNagativeInventory.Checked = _profile.AllowNagativeInventory;

            updateUI();
        }

        private void updateProfile()
        {
            if (new SystemDAL().UpdateSystemProfile(_profile, _mode) > 0)
            {
                if (utilcore.CreateAppRegistry(vars.APP_KEY, txtCompanyCode.Text, txtServerName.Text, txtDatabaseName.Text, txtDbAdmin.Text, txtDbPassword.Text, lbLangCode.Text))
                {
                    // read configuration information for registry
                    if (utilcore.ReadAppRegistryConfiguration(vars.APP_KEY))
                    {
                        // update connectionString in App.Config
                        if (utilcore.UpdateConnectionString(vars.SYS_CONN_NAME, vars.SERVER, vars.DBNAME, vars.DBUSER, vars.DBPassword))
                        {
                            vars.CONNECTION_NAME = utilcore.getCurrentConnectionString(vars.SYS_CONN_NAME);
                        }
                    }
                }
            }
        }

        #endregion

        private void textChanged(object sender, EventArgs e)
        {
            updateUI();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            // update Profile
            _profile.Address = txtAddress.Text;
            _profile.AllowNagativeInventory = chkAllowNagativeInventory.Checked;
            _profile.CompanyCode = txtCompanyCode.Text;
            _profile.CompanyName = txtCompanyName.Text;
            _profile.ContactName = txtContactName.Text;
            _profile.Country = txtCountry.Text;
            _profile.CreditDuration = Convert.ToInt32(txtDefaultCreditduration.Text);
            _profile.CreditLimit = Convert.ToDecimal(txtDefaultCreditLimit.Text);
            _profile.DatabaseName = txtDatabaseName.Text;
            _profile.DBAdmin = txtDbAdmin.Text;
            _profile.DBAdminPassword = txtDbPassword.Text;
            _profile.DefaultLangCode = lbLangCode.Text;
            _profile.DefaultWeightUOM = cbxUOM.Text;
            _profile.DefaultWH = lbWHCode.Text;
            _profile.HomeCurrency = cbxHomeCurrency.Text;
            _profile.ImageLocation = txtImageLocation.Text;
            _profile.PaymentTerm = lbCRCode.Text;
            _profile.ProfitMarkupRate = Convert.ToDecimal(txtMarkupProfit.Text);
            _profile.ServerName = txtServerName.Text;
            _profile.SourceCurrency = cbxSourceCurrency.Text;
            _profile.TaxID = txtTaxId.Text;
            _profile.TelFax = txtTelFax.Text;
            _profile.VATRate = Convert.ToDecimal(txtVATRate.Text);

            updateProfile();
        }

        public SysSetting(string ProfileId, DataActionMode Mode = DataActionMode.Add)
        {
            InitializeComponent();
            getLang();
            getHomeCurrency();
            getSourchCurrency();
            getUOMs();
            getWarehouses();
            getCreditTerm();

            _mode = Mode;
            _companyId = ProfileId;
            lbMode.Text = _mode.ToString();
            GetProfile(_companyId);
        }

        private void SysProfile_Load(object sender, EventArgs e)
        {

            updateUI();
        }

        private void txtCompanyCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                updateUI();
            }
        }

        private void cbxCreditTerm_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                lbCRCode.Text = cbxCreditTerm.SelectedValue.ToString();
            }
            catch
            {
                lbCRCode.Text = "";
            }
        }

        private void cbxDefaultWH_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                lbWHCode.Text = cbxDefaultWH.SelectedValue.ToString();
            }
            catch
            {
                lbWHCode.Text = "";
            }
        }

        private void cbxUOM_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                lbUOMFactor.Text = $"{ cbxUOM.SelectedValue.ToString():N4}";
            }
            catch
            {
                lbUOMFactor.Text = $"{0:N4}";
            }
        }

        private void cbxLang_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                lbLangCode.Text = cbxLang.SelectedValue.ToString();
            }
            catch
            {
                lbLangCode.Text = "";
            }
        }

        private void txt_Validating(object sender, CancelEventArgs e)
        {
            TextBox _textBox = sender as TextBox;
            bool _valid = _textBox.Text.IsNumeric();

            if (_valid == false)
            {
                MessageBox.Show("Only numeric accepted!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _textBox.Focus();
                _textBox.SelectAll();
                e.Cancel = true;
            }
        }

        private void btnImageLocation_Click(object sender, EventArgs e)
        {
            txtImageLocation.Text = utilcore.GetFolderPath();
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            updateUI();
        }
    }
}


