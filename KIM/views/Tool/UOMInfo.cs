using KIM.data;
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
    public partial class UOMInfo : Form
    {
        #region class field member

        private DataActionMode _mode = DataActionMode.None;
        private UOM _uom;

        #endregion

        #region helper

        private void UpdateUI()
        {
            txtUOMName.Enabled = (_mode == DataActionMode.Add);

            btnSave.Enabled = (!String.IsNullOrEmpty(txtUOMName.Text) && 
                                !String.IsNullOrEmpty(txtFactor.Text));
        }

        private void GetUOMInfo(string name)
        {
            switch (_mode)
            {
                case DataActionMode.Add:
                    _uom = new UOM();
                    _uom.Factor = 1.00m;
                    break;

                case DataActionMode.Edit:
                    _uom = new UOMDAL().GetUOMById(name);
                    break;
            }

            txtUOMName.Text = _uom.UOMName;
            txtFactor.Text = $"{_uom.Factor:N2}";
        }
        #endregion

        public UOMInfo(string UOMName)
        {
            InitializeComponent();

            _mode = String.IsNullOrEmpty(UOMName) ? DataActionMode.Add : DataActionMode.Edit;
            lbMode.Text = _mode.ToString();

            GetUOMInfo(UOMName);
        }

        private void UOMInfo_Load(object sender, EventArgs e)
        {

        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void txtFactor_Validating(object sender, CancelEventArgs e)
        {
            TextBox _text = sender as TextBox;
            bool _valid = _text.Text.IsNumeric();
            if (_valid == false)
            {
                MessageBox.Show("Ony numeric accepted!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
                _text.Focus();
                _text.SelectAll();
            }
            else
            {
                txtFactor.Text = $"{_text.Text:N2}";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _uom.UOMName = txtUOMName.Text;
            _uom.Factor = txtFactor.ToDecimal();

            if(new UOMDAL().UpdateUOM(_uom, _mode) > 0)
            {
                MessageBox.Show("Update UOM record successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
