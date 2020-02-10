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

namespace KIM.views.Master
{
    public partial class AccountGroupInfo : Form
    {
        #region class field member
        private AccountGroup accountGroup;
        private DataActionMode _mode = DataActionMode.None;


        #endregion

        #region class helper
        private void UpdateUI()
        {
            txtAccCode.Enabled = (_mode == DataActionMode.Add);

            btnSave.Enabled = (!String.IsNullOrEmpty(txtAccCode.Text) && 
                                !String.IsNullOrEmpty(txtAccountName.Text));
        }

        private void GetAccountInfo(string Code)
        {
            switch (_mode)
            {
                case DataActionMode.Add:
                    accountGroup = new AccountGroup();
                    break;

                case DataActionMode.Edit:
                    accountGroup = new AccountGroupDAL().GetAccountGroupById(Code);
                    break;
            }

            txtAccCode.Text = accountGroup.AccGroup;
            txtAccountName.Text = accountGroup.AccountName;

            UpdateUI();
        }

        #endregion


        public AccountGroupInfo(string AccountCode)
        {
            InitializeComponent();

            _mode = String.IsNullOrEmpty(AccountCode) ? DataActionMode.Add : DataActionMode.Edit;
            lbMode.Text = _mode.ToString();

            GetAccountInfo(AccountCode);

        }

        private void AccoutGroupInfo_Load(object sender, EventArgs e)
        {

        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            accountGroup.AccGroup = txtAccCode.Text;
            accountGroup.AccountName = txtAccountName.Text;

            if(new AccountGroupDAL().UpdateAccountGroup(accountGroup,_mode) > 0)
            {
                MessageBox.Show("Update Account Group successfully.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
