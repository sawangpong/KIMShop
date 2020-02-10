using KIM.data;
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
    public partial class ItemCatInfo : Form
    {
        #region class field member
        private string _catCode = "";
        private Category category;
        private DataActionMode _mode = DataActionMode.None;


        #endregion


        #region class helper
        private void UpdateUI()
        {
            txtCatCode.Enabled = (_mode == DataActionMode.Add);

            btnSave.Enabled = (!String.IsNullOrEmpty(txtCatCode.Text)
                            && !String.IsNullOrEmpty(txtCatName.Text));
        }

        private void GetItemCatInfo(string code)
        {
            switch (_mode)
            {
                case DataActionMode.Add:
                    category = new Category();
                    break;

                case DataActionMode.Edit:
                    category = new CategoryDAL().getCategoryById(code);
                    break;
            }

            txtCatCode.Text = category.CatCode;
            txtCatName.Text = category.CatName;

            UpdateUI();
        }

        #endregion

        public ItemCatInfo(string CatCode)
        {
            InitializeComponent();

            _catCode = CatCode;
            _mode = String.IsNullOrEmpty(_catCode) ? DataActionMode.Add : DataActionMode.Edit;

            lbMode.Text = _mode.ToString();

        }

        private void ItemCatInfo_Load(object sender, EventArgs e)
        {
            GetItemCatInfo(_catCode);
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            category.CatName = txtCatName.Text;
            category.CatCode = txtCatCode.Text;

            if (new CategoryDAL().updateCategory(category, _mode) > 0)
            {
                MessageBox.Show("Update Category success", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
