using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KIM.data;
using KIM.models;

namespace KIM.views.Vendor
{
    public partial class VendorBox : Form
    {
        #region class field

        private string _vendorFilter = "";
        private data.Vendor _vendor = new data.Vendor();


        #endregion

        #region class property

        public data.Vendor VendorSource { get; set; }

        #endregion

        #region class helper

        private void updateUI()
        {
            btnSelect.Enabled = (_vendor != null);
        }

        private void getVendors(string filter)
        {
            _vendor = null;
            dgv.SuspendLayout();
            dgv.DataSource = new VendorDAL().getVendorList(filter);

            foreach (DataGridViewColumn dgc in dgv.Columns)
            {
                if(dgc.Name != "VendorCode" && dgc.Name != "VendorName")
                {
                    dgc.Visible = false;
                }
                else
                {
                    if(dgc.Name == "VendorName")
                    {
                        dgc.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                        dgc.HeaderText = "Vendor name";
                    }
                    else
                    {
                        dgc.HeaderText = "Vendor Code";
                    }
                }
            }

            dgv.ResumeLayout();

            updateUI();
        }

        #endregion

        public VendorBox(string venderFilter)
        {
            InitializeComponent();
            utils.utilcore.SettingDataGrid(ref dgv);

            _vendorFilter = venderFilter;
            txtSearchVendor.Text = _vendorFilter;
        }

        private void VendorBox_Load(object sender, EventArgs e)
        {
            getVendors(_vendorFilter);
        }

        private void dgv_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            _vendor = new VendorDAL().getVendorById(dgv["VendorCode", e.RowIndex].Value.ToString());
            this.VendorSource = _vendor;

            updateUI();

        }

        private void dgv_DoubleClick(object sender, EventArgs e)
        {
            btnSelect.PerformClick();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            _vendor = null;
            this.VendorSource = _vendor;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            getVendors(txtSearchVendor.Text);
        }

        private void txtSearchVendor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == (char)Keys.Enter)
            {
                btnSearch.PerformClick();
            }
        }
    }
}
