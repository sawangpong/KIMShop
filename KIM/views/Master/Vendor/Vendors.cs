using KIM.models;
using KIM.models.Master;
using KIM.views.Master.Vendor;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KIM.views.Master.Vendor
{
    public partial class vendor : Form
    {
        #region class field member
        private static vendor instance;
        private string _selectedVendorCode = "";

        #endregion

        #region class property
        public static vendor GetInstance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new vendor();
                }
                return instance;
            }
        }
        #endregion
        
        #region class helper
        private void updateUI()
        {
            tsbtnEdit.Enabled = (!String.IsNullOrEmpty(_selectedVendorCode));
            tsbtnDelete.Enabled = tsbtnEdit.Enabled;
        }
        
        private void getVendors(string vendorCode = "")
        {
            dgv.SuspendLayout();
            dgv.DataSource = new VendorDAL().GetVendors(vendorCode);

            // formatting datagridview
            dgv.Columns["IsActive"].Visible = false;
            dgv.Columns["Active"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgv.Columns["Active"].DefaultCellStyle.Font = new Font(dgv.Font, FontStyle.Bold);
            dgv.Columns["Address"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns["VendorCode"].HeaderText = "Code";
            dgv.Columns["VendorName"].HeaderText = "Name";
            dgv.Columns["ContactName"].HeaderText = "Contact name";

            dgv.ResumeLayout();

            lbRecord.Text = $"found:{dgv.Rows.Count}";
            updateUI();
        }
        
        private void getVendorInfo(string vendorCode)
        {
            using(var _venforInfo = new views.Master.Vendor.VendorInfo(vendorCode))
            {
                _venforInfo.StartPosition = FormStartPosition.CenterScreen;

                if(_venforInfo.ShowDialog() == DialogResult.Cancel)
                {
                    //MessageBox.Show("Can't update Vendor information, contact your administrator.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            tsbtnRefresh.PerformClick();
        }

        #endregion

        public vendor()
        {
            InitializeComponent();

            dgv.DoubleBuffered(true);
            dgv.SettingDataGrid();
            
        }

        private void vendor_Load(object sender, EventArgs e)
        {
            getVendors("");
        }

        private void tsbtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            _selectedVendorCode = dgv["VendorCode", e.RowIndex].Value.ToString();

            updateUI();
        }

        private void dgv_DoubleClick(object sender, EventArgs e)
        {
            tsbtnEdit.PerformClick();
        }

        private void tsbtnAdd_Click(object sender, EventArgs e)
        {
            _selectedVendorCode = "";
            getVendorInfo(_selectedVendorCode);
        }

        private void tsbtnEdit_Click(object sender, EventArgs e)
        {
            getVendorInfo(_selectedVendorCode);
        }

        private void tsbtnRefresh_Click(object sender, EventArgs e)
        {
            getVendors();
        }

        private void tsbtnSearchVendor_Click(object sender, EventArgs e)
        {
            getVendors(tstxtVendorCode.Text);
        }
    }
}
