using KIM.data;
using KIM.models;
using KIM.models.Tool;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KIM.views.Tool
{
    public partial class MemberInfo : Form
    {
        #region class field member
        private DataActionMode _mode = DataActionMode.None;
        private User user;
        private int _selectedPermissionId = 0;

        #endregion

        #region class helper
        private void UpdateUI()
        {
            btnSave.Enabled = (!String.IsNullOrEmpty(txtUserName.Text) &&
                               _selectedPermissionId > (int)UserPermission.None &&
                               txtPassword.Text.Equals(txtConfirmPassword.Text));
        }

        private void GetPermissions()
        {
            cbxPermission.DataSource = UserDAL.PermissionList();
            cbxPermission.DisplayMember = "Name";
            cbxPermission.ValueMember = "Value";
        }

        private void GetUserInfo(string userName)
        {
            switch (_mode)
            {
                case DataActionMode.Add:
                    user = new User();
                    user.PermissionClass = (int)UserPermission.User;
                    _selectedPermissionId = user.PermissionClass;
                    user.PermissionName = UserPermission.User.ToString();
                    user.IsActive = true;
                    break;

                case DataActionMode.Edit:
                    user = new UserDAL().GetUserByName(userName);
                    break;
            }

            txtUserName.Text = user.Username;
            txtPassword.Text = user.Password;
            txtConfirmPassword.Text = user.Password;
            chkActiveUser.Checked = user.IsActive;
            cbxPermission.SelectedValue = user.PermissionClass;

            UpdateUI();

        }


        #endregion

        public MemberInfo(string UserName)
        {
            InitializeComponent();

            _mode = String.IsNullOrEmpty(UserName) ? DataActionMode.Add : DataActionMode.Edit;
            lbMode.Text = _mode.ToString();

            GetPermissions();
            GetUserInfo(UserName);
        }

        private void MemberInfo_Load(object sender, EventArgs e)
        {
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void cbxPermission_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                _selectedPermissionId = Convert.ToInt32(cbxPermission.SelectedValue);
            }
            catch
            {
                _selectedPermissionId = (int)UserPermission.User;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            user.Username = txtUserName.Text;
            user.Password = txtPassword.Text;
            user.IsActive = chkActiveUser.Checked;
            user.PermissionClass = _selectedPermissionId;
            user.PermissionName = Enum.GetName(typeof(UserPermission), _selectedPermissionId).ToString();

            if(new UserDAL().UpdateUser(_mode,user) > 0)
            {
                MessageBox.Show("Update User successfully.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
