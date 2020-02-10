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
    public partial class ItemCategory : Form
    {
        #region class field member
        private static ItemCategory _instance;
        private string _selectedCategory = "";

        #endregion

        #region class properties

        public static ItemCategory GetInstance
        {
            get
            {
                if (_instance == null || _instance.IsDisposed)
                {
                    _instance = new ItemCategory();
                }
                return _instance;
            }
        }
        #endregion

        #region class helper

        private void UpdateUI()
        {
            tsbtnEdit.Enabled = (!String.IsNullOrEmpty(_selectedCategory));
        }

        private void GetItemCategories()
        {
            dgv.SuspendLayout();
            dgv.ClearSelection();
            dgv.DataSource = new CategoryDAL().getCategories();

            dgv.Columns["CatCode"].HeaderText = "Category Code";
            dgv.Columns["CatName"].HeaderText = "Category Name";
            dgv.Columns["CatName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.ResumeLayout();

            lbCount.Text = $"found:{dgv.Rows.Count}";
            UpdateUI();
        }

        private void AddEditItemCat(string code)
        {
            using (var itemCat = new ItemCatInfo(code))
            {
                itemCat.StartPosition = FormStartPosition.CenterScreen;
                if (itemCat.ShowDialog(this) == DialogResult.OK)
                {
                    GetItemCategories();
                }
            }
        }

        #endregion

        public ItemCategory()
        {
            InitializeComponent();
            dgv.DoubleBuffered();
            dgv.SettingDataGrid();

            CenterToScreen();
        }

        private void ItemCategory_Load(object sender, EventArgs e)
        {
            GetItemCategories();
        }

        private void dgv_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            _selectedCategory = dgv["CatCode", e.RowIndex].Value.ToString();

            UpdateUI();
        }

        private void tsbtnAdd_Click(object sender, EventArgs e)
        {
            _selectedCategory = "";
            AddEditItemCat(_selectedCategory);
        }

        private void dgv_DoubleClick(object sender, EventArgs e)
        {
            tsbtnEdit.PerformClick();
        }

        private void tsbtnEdit_Click(object sender, EventArgs e)
        {
            AddEditItemCat(_selectedCategory);
        }

        private void tsbtnRefresh_Click(object sender, EventArgs e)
        {
            GetItemCategories();
        }

        private void tsbtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbtnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete the selected Category?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (new CategoryDAL().removeCategory(_selectedCategory) > 0)
                {
                    MessageBox.Show("Delete seleted Category successfully.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetItemCategories();
                }
            }
        }
    }
}
