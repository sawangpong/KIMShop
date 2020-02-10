using KIM.models;
using KIM.models.Master;
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

namespace KIM.views.Master.Customer
{
    public partial class Customers : Form
    {
        #region class members
        private static Customers instance;
        private string _selectedCustomerCode = String.Empty;

        #endregion

        #region class properties
        public static Customers GetInstance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new Customers();
                }
                return instance;
            }
        }

        #endregion

        #region class helper

        private void updateLangauge()
        {
            if (vars.LANG_USE == "KM")
            {
                lbTitle.Text = "";
                tsbtnAddCustomer.Text = "";
                tsbtnEditCustomer.Text = "";
                tsbtnDelete.Text = "";
                tsbtnRefresh.Text = "";
                tslbCustomerCode.Text = "";
                tsbtnSearch.Text = "";
                tsbtnClose.Text = "";
            }
        }

        private void updateUI()
        {
            tsbtnEditCustomer.Enabled = (!String.IsNullOrEmpty(_selectedCustomerCode) || dgv.Rows.Count > 0);
            tsbtnDelete.Enabled = tsbtnEditCustomer.Enabled;
        }

        private void getCustomers(string custCodeFilter)
        {
            dgv.SuspendLayout();
            if (String.IsNullOrEmpty(custCodeFilter))
            {
                dgv.DataSource = new CustomerDAL().getCustomers();
            }
            else
            {
                dgv.DataSource = new CustomerDAL().getCustomersByCode(custCodeFilter);
            }

            // formatting datagridview
            dgv.Columns["Active"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns["Currency"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns["Addr"].HeaderText = "Address";
            dgv.Columns["Addr"].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
  
            dgv.ResumeLayout();

            lbRecords.Text = $"found:{dgv.Rows.Count}";
        }

        private void addEditCustomer(string customerCode)
        {
            using (var customerInfo = new CustomerInfo(customerCode))
            {
                customerInfo.StartPosition = FormStartPosition.CenterScreen;
                if (customerInfo.ShowDialog() == DialogResult.OK)
                {
                    tsbtnRefresh.PerformClick();
                }
            }
        }

        #endregion

        public Customers()
        {
            InitializeComponent();
            updateLangauge();
            
            //utilcore.SettingDataGrid(ref dgv);
            
            dgv.DoubleBuffered(true);
            dgv.SettingDataGrid();
        }

        private void tsbtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Customers_Load(object sender, EventArgs e)
        {
           tstxtSearch.Text = "";
            getCustomers(tstxtSearch.Text);
            updateUI();
        }

        private void tsbtnAddCustomer_Click(object sender, EventArgs e)
        {
            _selectedCustomerCode = "";
            addEditCustomer(_selectedCustomerCode);
        }

        private void tsbtnEditCustomer_Click(object sender, EventArgs e)
        {
            addEditCustomer(_selectedCustomerCode);
        }

        private void tsbtnRefresh_Click(object sender, EventArgs e)
        {
            getCustomers(tstxtSearch.Text);
        }

        private void dgv_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            _selectedCustomerCode = dgv["CustomerCode", e.RowIndex].Value.ToString();

            updateUI();
        }

        private void dgv_DoubleClick(object sender, EventArgs e)
        {
            tsbtnEditCustomer.PerformClick();
        }

        private void tsbtnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to delete the selected customer?","Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if(new CustomerDAL().removeCustomer(_selectedCustomerCode) <= 0)
                {
                    MessageBox.Show("Can't delete record, contact your administrator for more details.","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                tsbtnRefresh.PerformClick();
            }
        }

        private void tstxtSearch_TextChanged(object sender, EventArgs e)
        {
            updateUI();
        }

        private void tsbtnSearch_Click(object sender, EventArgs e)
        {
            tsbtnRefresh.PerformClick();
        }

        private void tstxtSearch_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                tsbtnSearch.PerformClick();
            }
        }
    }
}
