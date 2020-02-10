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
    public partial class AccountSet : Form
    {
        #region class field member
        private static AccountSet _instance;
        private string _selectedAccount = "";

        #endregion

        #region class properties

        public static AccountSet GetInstance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new AccountSet();
                }
                return _instance;
            }
        }
        #endregion

        #region class helper

        private void UpdateUI()
        {
            tsbtnEdit.Enabled = !String.IsNullOrEmpty(_selectedAccount);
        }

        private void GetAccountSet()
        {
            dgv.SuspendLayout();
            dgv.ClearSelection();
            dgv.DataSource = new AccountGroupDAL().GetAccountGroups();
            dgv.Columns["AccGroup"].HeaderText = "Account code";
            dgv.Columns["AccountName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns["AccountName"].HeaderText = "Account Information";
            dgv.ResumeLayout();

            lbCount.Text = $"found:{dgv.Rows.Count}";
            UpdateUI();
        }

        private void AddEditAccountGroup(string account)
        {
            using(var accInfo = new AccountGroupInfo(account))
            {
                accInfo.StartPosition = FormStartPosition.CenterScreen;
                if(accInfo.ShowDialog(this) != DialogResult.OK)
                {
                    MessageBox.Show("Can't update Account Group Info.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                GetAccountSet();
            }
        }

        #endregion


        public AccountSet()
        {
            InitializeComponent();
            dgv.DoubleBuffered();
            dgv.SettingDataGrid();

            CenterToScreen();
        }

        private void AccountSet_Load(object sender, EventArgs e)
        {
            GetAccountSet();
        }

        private void tsbtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            _selectedAccount = dgv["AccGroup", e.RowIndex].Value.ToString();

            UpdateUI();
        }

        private void dgv_DoubleClick(object sender, EventArgs e)
        {
            tsbtnEdit.PerformClick();
        }

        private void tsbtnAdd_Click(object sender, EventArgs e)
        {
            _selectedAccount = "";
            AddEditAccountGroup(_selectedAccount);
        }

        private void tsbtnEdit_Click(object sender, EventArgs e)
        {
            AddEditAccountGroup(_selectedAccount);
        }

        private void tsbtnRefresh_Click(object sender, EventArgs e)
        {
            GetAccountSet();
        }

        private void tsbtnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete selected Account?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (new AccountGroupDAL().RemoveAccountGroup(_selectedAccount) > 0)
                {
                    MessageBox.Show("Delete selected Account successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
