using KIM.models.Warehouse;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KIM.views.warehouse
{
    public partial class WHLoc : Form
    {
        #region class field member
        private static WHLoc _instance;
        private string _selectedCategory = "";

        #endregion

        #region class properties

        public static WHLoc GetInstance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new WHLoc();
                }
                return _instance;
            }
        }
        #endregion

        #region

        private void UpdateUI()
        {
            tsbtnEdit.Enabled = !String.IsNullOrEmpty(_selectedCategory);
            tsbtnDelete.Enabled = tsbtnEdit.Enabled;
        }

        private void GetWHLocations()
        {
            dgv.SuspendLayout();
            dgv.ClearSelection();
            dgv.DataSource = new WarehouseDAL().GetWarehouses().ToDataTable();
            dgv.Columns["WHCode"].HeaderText = "Code";
            dgv.Columns["WHName"].HeaderText = "Warehouse Info.";
            dgv.Columns["WHName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.ResumeLayout();

            UpdateUI();
        }

        private void AddEditWHLocation(string code)
        {
            using (var whInfo = new WHLocInfo(code))
            {
                whInfo.StartPosition = FormStartPosition.CenterScreen;
                if (whInfo.ShowDialog(this) <= 0)
                {
                    MessageBox.Show("Can't update Warehouse info.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                GetWHLocations();
            }
        }

        #endregion

        public WHLoc()
        {
            InitializeComponent();
            dgv.DoubleBuffered();
            dgv.SettingDataGrid();

            CenterToScreen();
        }

        private void WHLoc_Load(object sender, EventArgs e)
        {
            GetWHLocations();
        }

        private void tsbtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbtnRefresh_Click(object sender, EventArgs e)
        {
            GetWHLocations();
        }

        private void dgv_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            _selectedCategory = dgv["WHCode", e.RowIndex].Value.ToString();

            UpdateUI();
        }

        private void dgv_DoubleClick(object sender, EventArgs e)
        {
            tsbtnEdit.PerformClick();
        }

        private void tsbtnAdd_Click(object sender, EventArgs e)
        {
            _selectedCategory = "";
            AddEditWHLocation(_selectedCategory);
        }

        private void tsbtnEdit_Click(object sender, EventArgs e)
        {
            AddEditWHLocation(_selectedCategory);
        }

        private void tsbtnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete the selected Warehouse location?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (new WarehouseDAL().RemoveWarehouse(_selectedCategory) > 0)
                {
                    MessageBox.Show("Delete the Warehouse location successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetWHLocations();
                }
            }
        }
    }
}
