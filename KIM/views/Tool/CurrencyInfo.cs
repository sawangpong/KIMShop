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
	public partial class CurrencyInfo : Form
	{
		#region class member
		private DataActionMode _mode = DataActionMode.None;
		private string _currencyCode = string.Empty;
		private Currency _currency = new Currency();

		#endregion

		#region class properties

		#endregion

		#region class helper
		private void updateUI()
		{
            txtCurCode.Enabled = (_mode == DataActionMode.Add ? true :false);

			btnSave.Enabled = !String.IsNullOrEmpty(txtCurCode.Text);
		}

        private void updateLanguage()
        {
            if(vars.LANG_USE == "KH")
            {
                lbCurCode.Text = "";
                lbCurDetail.Text = "";
                lbMode.Text = "";
                lbTitle.Text = "";
                btnCancel.Text = "";
                btnSave.Text = "";
            }
        }

        private void updateCurrency(Currency currency)
        {
            int _result = 0;
            switch (_mode) 
            {
                case DataActionMode.Add:
                    _result = new CurrencyDAL().addCurrency(currency);
                    break;

                case DataActionMode.Edit:
                    _result = new CurrencyDAL().updateCurrency(currency);
                    break;
            }

            if(_result > 0)
            {
                MessageBox.Show("Update record successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

		#endregion
		public CurrencyInfo(string currencyCode)
		{
			InitializeComponent();
            updateLanguage();

			_currencyCode = currencyCode;
			_mode = String.IsNullOrEmpty(_currencyCode) ? DataActionMode.Add : DataActionMode.Edit;
			lbMode.Text = vars.LANG_USE != "EN" ? _mode.ToString() : _mode.ToString();
		}

		private void CurrencyInfo_Load(object sender, EventArgs e)
		{
			if(_mode == DataActionMode.Edit)
			{
				_currency = new CurrencyDAL().getCurrencyByName(_currencyCode);
			}

			txtCurCode.Text = _currency.CURCode;
			txtdetail.Text = _currency.CURdetail;

            updateUI();
		}

		private void txtCurCode_TextChanged(object sender, EventArgs e)
		{
			updateUI();
		}

        private void btnSave_Click(object sender, EventArgs e)
        {
            switch (_mode)
            {
                case DataActionMode.Add:
                    _currency.CURCode = txtCurCode.Text;
                    _currency.CURdetail = txtdetail.Text;
                    break;

                case DataActionMode.Edit:
                    _currency.CURdetail = txtdetail.Text;
                    break;
            }

            updateCurrency(_currency);

        }
    }
}
