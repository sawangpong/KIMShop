using KIM.models;
using KIM.models.Tool;
using KIM.views.Master;
using KIM.views.Tool;
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
    public partial class Member : Form
    {
        #region class field member

        private static Member instance;
        private string _selectedUserName = "";

        #endregion

        #region class properties
        public static Member GetInstance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new Member();
                }
                return instance;
            }

        }
        #endregion

        #region class helper

        private void UpdateUI()
        {
            tsbtnEdit.Enabled = !String.IsNullOrEmpty(_selectedUserName);
            tsbtnDelete.Enabled = tsbtnEdit.Enabled;

        }

        private void GetMemberList()
        {
            dgv.SuspendLayout();
            dgv.ClearSelection();
            dgv.DataSource = new UserDAL().GetUsers();
            dgv.Columns["IsActive"].Visible = false;
            dgv.Columns["PermissionClass"].Visible = false;
            dgv.Columns["PermissionName"].HeaderText = "Permission";
            dgv.Columns["UserName"].HeaderText = "User name";
            dgv.Columns["UserName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            lbCount.Text = $"found:{dgv.Rows.Count}";
            dgv.ResumeLayout();
        }

        private void MemberInfo(string userName)
        {
            using (var member = new MemberInfo(userName))
            {
                member.StartPosition = FormStartPosition.CenterScreen;
                if (member.ShowDialog(this) != DialogResult.OK)
                {
                    MessageBox.Show("Can't update User member information", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                GetMemberList();
            }
        }

        #endregion

        public Member()
        {
            InitializeComponent();
            dgv.DoubleBuffered();
            dgv.SettingDataGrid();
            CenterToScreen();
        }

        private void Member_Load(object sender, EventArgs e)
        {
            GetMemberList();
        }

        private void tsbtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            _selectedUserName = dgv["UserName", e.RowIndex].Value.ToString();

            UpdateUI();
        }

        private void tsbtnRefresh_Click(object sender, EventArgs e)
        {
            GetMemberList();
        }

        private void tsbtnAdd_Click(object sender, EventArgs e)
        {
            _selectedUserName = "";
            MemberInfo(_selectedUserName);
        }

        private void tsbtnEdit_Click(object sender, EventArgs e)
        {
            MemberInfo(_selectedUserName);
        }

        private void dgv_DoubleClick(object sender, EventArgs e)
        {
            tsbtnEdit.PerformClick();
        }
    }
}
