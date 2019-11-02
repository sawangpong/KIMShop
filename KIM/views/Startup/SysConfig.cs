using KIM.utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KIM.views.Startup
{
    public partial class SysConfig : Form
    {
        #region class field
        private DataActionMode _mode = DataActionMode.None;

        #endregion

        #region class properties

        #endregion

        #region class helper
        private void updateUI()
        {
            btnSave.Enabled = (!String.IsNullOrWhiteSpace(txtCompanyCode.Text)
                                && !String.IsNullOrWhiteSpace(txtServerName.Text)
                                && !String.IsNullOrWhiteSpace(txtDatabaseName.Text)
                                && !String.IsNullOrWhiteSpace(txtDbAdmin.Text));
        }

        private void updateLangauge()
        {
            if(vars.LANG_USE == "KH")
            {
                lbTitle.Text = "";
                lbCompanyCode.Text = "";
                lbDatabase.Text = "";
                lbDbAdmin.Text = "";
                lbDBPassword.Text = "";
                lbServer.Text = "";
                btnCancel.Text = "";
                btnSave.Text = "";

            }
        }

        #endregion

        public SysConfig(DataActionMode mode)
        {
            InitializeComponent();
            updateLangauge();

            _mode = mode;
            lbMode.Text = _mode.ToString();
        }

        private void SysConfig_Load(object sender, EventArgs e)
        {

            if (_mode == DataActionMode.Create)
            {
                txtCompanyCode.Text = vars.COMPANY_ID;
                txtDatabaseName.Text = vars.DEFAULT_DB_NAME;
            }
            else
            {
                txtCompanyCode.Text = vars.COMPANY_ID;
                txtDatabaseName.Text = vars.DBNAME;
                txtDbAdmin.Text = vars.DBUSER;
                txtDbPassword.Text = vars.DBPassword;
                txtServerName.Text = vars.SERVER;
            }
        }

        private void textChanged(object sender, EventArgs e)
        {
            updateUI();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (utilcore.CreateAppRegistry(vars.APP_KEY, txtCompanyCode.Text, txtServerName.Text, txtDatabaseName.Text, txtDbAdmin.Text, txtDbPassword.Text))
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
}
