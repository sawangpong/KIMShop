using KIM.data;
using KIM.models;
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
    public partial class ExchangeInfo : Form
    {
        #region class member

        private Exchange _exchange;
        private int _exchangeId = 0;
        private string _code = string.Empty;
        private DataActionMode _mode = DataActionMode.None;

        #endregion

        #region class properties

        #endregion

        #region class helper

        private void updateLanguage()
        {
            if(vars.LANG_USE == "KH")
            {
                lbTitle.Text = "";
                lbCode.Text = "";
                lbMode.Text = "";
                lbExpire.Text = "";
                lbExchDate.Text = "";
                lbValid.Text = "";
                lbExchangeRate.Text = "";
                btnCancel.Text = "";
                btnSave.Text = "";
            }
        }
        private void updateUI()
        {

        }

        private void getExchangeInfo(int id)
        {
            switch (_mode)
            {
                case DataActionMode.Add:
                    _exchange = new Exchange();
                    txtCurCode.Text = _code;
                    txtExchangeRate.Text = $"{0:N4}";
                    dtpExchDate.Value = DateTime.Today;
                    txtDayValid.Text = "1";
                    break;

                case DataActionMode.Edit:
                    _exchange = new ExchangeDAL().getExchangeInfo(id);
                    txtCurCode.Text = _exchange.CURCode;
                    txtExchangeRate.Text = $"{_exchange.ExchRate:N4}";
                    dtpExchDate.Value = _exchange.ExchDate;
                    txtDayValid.Text = _exchange.SpreadDay.ToString();
                    dtpExpire.Value = _exchange.ExpireDate.Value;
                    break;
            }

            updateUI();
        }

        private void updateExchange(Exchange exchange)
        {
            if (new ExchangeDAL().updateExchange(exchange) > 0)
            {
                MessageBox.Show("Update exchange record successfully", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion


        public ExchangeInfo(string code, int exchangeId)
        {
            InitializeComponent();
            updateLanguage();
            _code = code;
            _exchangeId = exchangeId;
            _mode = _exchangeId == 0 ? DataActionMode.Add : DataActionMode.Edit;
            lbMode.Text = _mode.ToString();

        }

        private void txtDayValid_TextChanged(object sender, EventArgs e)
        {
            if (txtDayValid.Text.IsNumeric())
            {
                int _days = Convert.ToInt32(txtDayValid.Text);
                  dtpExpire.Value = dtpExchDate.Value.AddDays(_days);
            }
        }

        private void ExchangeInfo_Load(object sender, EventArgs e)
        {
            getExchangeInfo(_exchangeId);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_mode == DataActionMode.Add)
            {
                _exchange.Id = 0;
                _exchange.CURCode = txtCurCode.Text;
            }
            _exchange.ExchDate = dtpExchDate.Value;
            _exchange.ExchRate = Convert.ToDecimal(txtExchangeRate.Text);
            _exchange.ExpireDate = dtpExpire.Value;
            _exchange.SpreadDay = Convert.ToInt32(txtDayValid.Text);

            updateExchange(_exchange);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

 
        private void txt_Validating(object sender, CancelEventArgs e)
        {
            TextBox _text = sender as TextBox;
            bool _valid = _text.Text.IsNumeric();
            if (_valid == false)
            {
                MessageBox.Show("Accept numeric only!!!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                e.Cancel = true;
                _text.Focus();
                _text.SelectAll();
            }
            else
            {
                switch (_text.Name)
                {
                    case "txtExchangeRate":
                        decimal _value = Convert.ToDecimal(_text.Text);
                        if(_value <= 0.00m)
                        {
                            _value = 1.00m;
                            _text.Text = $"{_value:N4}";
                        }
                        break;

                    case "txtDayValid":
                        int _dayValue = Convert.ToInt32(_text.Text);
                        if(_dayValue <= 0)
                        {
                            _dayValue = 1;
                            _text.Text = $"{_dayValue}";
                        }
                        break;
                }
            }
        }

        private void txtExchangeRate_TextChanged(object sender, EventArgs e)
        {
            //if (txtExchangeRate.Text.IsNumeric())
            //{
            //    decimal _rate = Convert.ToDecimal(txtExchangeRate.Text);
            //    if(_rate <= 0.00m)
            //    {
            //        _rate = 1.00m;
            //    }
            //   // txtExchangeRate.Text = $"{_rate}";
            //}
        }
    }
}
