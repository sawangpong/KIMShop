using KIM.data;
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
	public partial class CurrencyList : Form
	{
        #region class member
        private static CurrencyList instance;
 		private string _selectedCurrencyCode = string.Empty;

        #endregion

        #region class properties
        public static CurrencyList GetInstance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new CurrencyList();
                }
                return instance;
            }
        }
        #endregion

        #region class helper

        private void updateLangauge()
        {
            if(vars.LANG_USE == "KH")
            {
                lbTitle.Text = "";
                btnAdd.Text = "";
                btnClose.Text = "";
                btnDelete.Text = "";
                btnEdit.Text = "";
                btnRefresh.Text = "";
                btnExchange.Text = "";
            }
        }

		private void updateUI()
		{
			btnEdit.Enabled = (dgv.Rows.Count > 0 && !String.IsNullOrEmpty(_selectedCurrencyCode));
			btnDelete.Enabled = btnEdit.Enabled;
            btnExchange.Enabled = btnEdit.Enabled;
		}

		private void getCurrencyList()
		{
			dgv.SuspendLayout();
			dgv.DataSource = new CurrencyDAL().getCurrencies();

			dgv.Columns["CURCode"].HeaderText =  vars.LANG_USE != "EN" ? "" : "Code";
			dgv.Columns["CURdetail"].HeaderText = vars.LANG_USE != "EN" ? "" : "Currenct description";
			dgv.Columns["CURdetail"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

			dgv.ResumeLayout();
			_selectedCurrencyCode = "";
			updateUI();
		}

		private void addEditCurrencyInfo(string currencyCode)
		{
			using (var curInfo = new CurrencyInfo(currencyCode))
			{
				if(curInfo.ShowDialog() == DialogResult.OK)
				{

				}
			}

			// re-load currency list
			getCurrencyList();
		}

		#endregion

		public CurrencyList()
		{
			InitializeComponent();
            updateLangauge();
			utilcore.SettingDataGrid(ref dgv);
		}

		private void CurrencyListcs_Load(object sender, EventArgs e)
		{
			getCurrencyList();
		}

		private void btnRefresh_Click(object sender, EventArgs e)
		{
			getCurrencyList();

		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void dgv_CellEnter(object sender, DataGridViewCellEventArgs e)
		{
			_selectedCurrencyCode = dgv["CURCode", e.RowIndex].Value.ToString();

			updateUI();
		}

		private void dgv_DoubleClick(object sender, EventArgs e)
		{
			btnEdit.PerformClick();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			_selectedCurrencyCode = "";
			addEditCurrencyInfo(_selectedCurrencyCode);
		}

		private void btnEdit_Click(object sender, EventArgs e)
		{
			addEditCurrencyInfo(_selectedCurrencyCode);
		}

        private void btnExchange_Click(object sender, EventArgs e)
        {
            //var exch = new views.Master.ExchangeMaster(_selectedCurrencyCode);
            //exch.MdiParent = this.ParentForm;
            //exch.StartPosition = FormStartPosition.CenterScreen;
            //exch.Show();
            var exch = ExchangeMaster.GetInstance;
            exch.MdiParent = this.ParentForm;
            exch.StartPosition = FormStartPosition.CenterScreen;
            exch.BringToFront();
            exch.Show();

        }
    }
}
