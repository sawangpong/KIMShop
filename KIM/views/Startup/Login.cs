using KIM.data;
using KIM.models;
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
    public partial class Login : Form
    {
        #region class members

        #endregion

        #region class properties
        public int LogId { get; set; } = 0;
        #endregion

        #region class helper

        private int getLogId()
        {
            var _log = new SystemLog()
            {
                ComputerName = vars.COMP_NAME,
                LoginDT = DateTime.Now,
                LoginName = txtUserName.Text,
                LogoutDT = null
            };

            return new UserDAL().getNewUserId(_log);
        }
        private void updateUI()
        {
            btnLogin.Enabled = !String.IsNullOrEmpty(txtUserName.Text);
        }

        private void UpdateLang()
        {
            if(vars.LANG_USE == "KH")
            {
                lbkConfig.Text = "ការកំណត់រចនាសម្ព័ន្ធប្រព័ន្ធ។";
                lbLogin.Text = "ចូល";
                lbPassword.Text = "ពាក្យសម្ងាត់។";
                lbUsername.Text = "ឈ្មោះ​អ្នកប្រើប្រាស់";
                btnCancel.Text = "បោះបង់។";
                btnLogin.Text = "ចូល";
            }
        }

        #endregion

        public Login()
        {
            InitializeComponent();

            UpdateLang();

            txtPassword.Text = string.Empty;
            txtUserName.Text = vars.USER_NAME;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                var userInfo = new UserDAL().getUserPermission(txtUserName.Text, txtPassword.Text);

                if (userInfo == null || userInfo.PermissionClass == 0)
                {
                    MessageBox.Show("Invalid user, contact your administrator", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Exit();
                }
				vars.USER_NAME = txtUserName.Text;
                vars.PERMISSION_ID = userInfo.PermissionClass;
                vars.PERMISSION_NAME = userInfo.PermissionName;
                this.LogId = getLogId();
            }
            catch
            {
                throw new Exception("Can't login to system, contact your administrator");
            }
        }

        private void txtUserName_TextChanged(object sender, EventArgs e)
        {
            updateUI();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            lbConnectionString.Text = $"Server:{vars.SERVER} Database:{vars.DBNAME}";
            txtUserName.Text = System.Environment.UserName;
        }

        private void lbkConfig_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (views.Startup.SysConfig _config = new SysConfig(DataActionMode.Modify))
            {
                if (_config.ShowDialog(this) == DialogResult.OK)
                {
                    Application.Exit();
                }
            }
        }
    }
}
