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
    public partial class SKUinfo : Form
    {
        #region class field member

        private DataActionMode _mode = DataActionMode.None;
        private SKU _sku;
        private string _skuCode = string.Empty;
        #endregion

        #region class helper

        private void SKUData()
        {
            switch (_mode)
            {
                case DataActionMode.Add:
                    _sku = new SKU();
                    break;

                case DataActionMode.Edit:
                    _sku = new SkuDAL().GetSKUbyId(_skuCode);
                    break;
            }

            txtSKUCode.Text = _sku.SKUCode;
            txtSKUDetail.Text = _sku.SKUDetail;
            txtConvertFactor.Text = $"{_sku.ConvertFactor:N2}";

            UpdateUI();

        }

        private void UpdateUI()
        {
            txtSKUCode.Enabled = (_mode != DataActionMode.Edit);

            btnSave.Enabled = (!String.IsNullOrEmpty(txtSKUCode.Text) 
                                && !String.IsNullOrEmpty(txtSKUDetail.Text));
        }

        #endregion


        public SKUinfo(string SKUCode)
        {
            InitializeComponent();

            _skuCode = SKUCode;
            _mode = String.IsNullOrEmpty(_skuCode) ? DataActionMode.Add : DataActionMode.Edit;
            lbMode.Text = _mode.ToString();
        }

        private void SKUinfo_Load(object sender, EventArgs e)
        {
            SKUData();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _sku.SKUDetail = txtSKUDetail.Text;
            _sku.SKUCode = txtSKUCode.Text;
            _sku.ConvertFactor = Convert.ToDecimal(txtConvertFactor.Text);

            if(new SkuDAL().UpdateSKU(_sku,_mode) > 0)
            {
                MessageBox.Show("Update SKU data successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void txt_Validating(object sender, CancelEventArgs e)
        {
            TextBox _text = sender as TextBox;
            bool _valid = _text.Text.IsNumeric();

            if (_valid == false)
            {
                MessageBox.Show("Only numeric is accepted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _text.Focus();
                _text.SelectAll();
                e.Cancel = true;
            }
            else
            {
                _text.Text = $"{_text.Text:N2}";
            }
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }
    }
}
