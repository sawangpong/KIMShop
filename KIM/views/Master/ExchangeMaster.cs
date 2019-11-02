using KIM.models;
using KIM.utils;
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
    public partial class ExchangeMaster : Form
    {
        #region class members
        private static ExchangeMaster instance;

        private int _selectedExchangeId = 0;
        private string _selectedCurrencyCode = "";
        private int _selectedExchangeYear = DateTime.Today.Year;

        #endregion

        #region class properties
        public static ExchangeMaster GetInstance
        {
            get
            {
                if(instance == null || instance.IsDisposed)
                {
                    instance = new ExchangeMaster();
                }
                return instance;
            }
          }

        #endregion

        #region class helper
        private void updateLanguage()
        {
            if (vars.LANG_USE == "KH")
            {
                lbTitle.Text = "";

                tslbCurrencyCode.Text = "";
                btnAdd.Text = "";
                btnDelete.Text = "";
                btnEdit.Text = "";
                btnRefresh.Text = "";
                btnClose.Text = "";
            }
        }
        private void updateUI()
        {
            btnAdd.Enabled = !String.IsNullOrEmpty(_selectedCurrencyCode);
            btnRefresh.Enabled = btnAdd.Enabled;

            btnEdit.Enabled = (_selectedExchangeId > 0);
            btnDelete.Enabled = btnEdit.Enabled;
        }

        private void getCurrencyList()
        {
            tscbxCurcode.ComboBox.SuspendLayout();
            tscbxCurcode.ComboBox.DataSource = new CurrencyDAL().getCurrencies();
            tscbxCurcode.ComboBox.DisplayMember = "CURCode";
            tscbxCurcode.ComboBox.ValueMember = "CURCode";

            tscbxCurcode.ComboBox.ResumeLayout();
         }

        private void getExchangeYear()
        {
            tscbxExchangeYear.ComboBox.SuspendLayout();
            tscbxExchangeYear.ComboBox.DataSource = new ExchangeDAL().getExchangeYear();
            tscbxExchangeYear.ComboBox.DisplayMember = "y";
            tscbxExchangeYear.ComboBox.ValueMember = "y";
            tscbxExchangeYear.ComboBox.ResumeLayout();
        }

        private void getExchangeListByCurrency(string code, int yearExchange)
        {
            dgv.SuspendLayout();
            dgv.DataSource = new ExchangeDAL().getExchangeByCurrency(code, yearExchange);

            dgv.Columns["Id"].Visible = false;
            dgv.Columns["CURCode"].HeaderText = (vars.LANG_USE == "KH" ? "" : "Currency");
            dgv.Columns["ExchRate"].HeaderText = vars.LANG_USE == "KH" ? "" : "Exch Rate";
            dgv.Columns["ExchDate"].HeaderText = vars.LANG_USE == "KH" ? "" : "Date effective";
            dgv.Columns["SpreadDay"].HeaderText = vars.LANG_USE == "KH" ? "" : "Day of valid";
            dgv.Columns["ExpireDate"].HeaderText = vars.LANG_USE == "KH" ? "" : "Expire date";

            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dgv.ResumeLayout();

            // update UI
            tslbCur.Text = _selectedCurrencyCode;
            updateUI();
        }

        private void addEditExchange(string code)
        {
            using(var exInfo = new ExchangeInfo(code, _selectedExchangeId))
            {
                exInfo.StartPosition = FormStartPosition.CenterScreen;

                if(exInfo.ShowDialog() == DialogResult.OK)
                {
                    getExchangeYear();
                }
            }
            btnRefresh.PerformClick();
        }

        #endregion

        public ExchangeMaster()
        {
            InitializeComponent();
            utilcore.SettingDataGrid(ref dgv);
            updateLanguage();
            getCurrencyList(); 
            _selectedCurrencyCode = "";
        }

        public ExchangeMaster(string code)
        {
            InitializeComponent();
            utilcore.SettingDataGrid(ref dgv);
            updateLanguage();
            getCurrencyList();

            _selectedCurrencyCode = code;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tscbxCurcode_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (tscbxCurcode.SelectedIndex == -1)
                {
                    _selectedCurrencyCode = "";
                }
                else
                {
                    if (tscbxCurcode.ComboBox.SelectedValue.GetType() == typeof(string))
                    {
                        _selectedCurrencyCode = tscbxCurcode.ComboBox.SelectedValue.ToString();
                    }
                    else
                    {
                        _selectedCurrencyCode = "";
                    }
                }
            }
            catch
            {
                _selectedCurrencyCode = "";
            }

            updateUI();
            btnRefresh.PerformClick();

        }

        private void dgv_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            _selectedExchangeId = Convert.ToInt32(dgv["id", e.RowIndex].Value);

            updateUI();
        }

        private void ExchangeMaster_Load(object sender, EventArgs e)
        {
            getCurrencyList();
            getExchangeYear();

            if (!String.IsNullOrEmpty(_selectedCurrencyCode))
            {
                tscbxCurcode.Text = _selectedCurrencyCode;
            }
            else
            {
                tscbxCurcode.ComboBox.SelectedIndex = 0;
            }

            btnRefresh.PerformClick();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            getExchangeListByCurrency(_selectedCurrencyCode, _selectedExchangeYear);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _selectedExchangeId = 0;

            addEditExchange(_selectedCurrencyCode);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            addEditExchange(_selectedCurrencyCode);

        }

        private void dgv_DoubleClick(object sender, EventArgs e)
        {
            btnEdit.PerformClick();
        }

        private void tsbtnShowData_Click(object sender, EventArgs e)
        {
            _selectedCurrencyCode = tscbxCurcode.ComboBox.Text;
            _selectedExchangeYear = Convert.ToInt32(tscbxExchangeYear.ComboBox.Text);

            updateUI();
            btnRefresh.PerformClick();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to delete selected exchange record?","Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if(new ExchangeDAL().deleteExchangeRecord(_selectedExchangeId) > 0)
                {
                    MessageBox.Show("Delete exchange record successfully.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    getExchangeYear();
                }
            }

            btnRefresh.PerformClick();
        }
    }
}
