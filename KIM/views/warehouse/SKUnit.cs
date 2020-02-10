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
    public partial class SKUnit : Form
    {
        #region class field member

        private static SKUnit instance;
        private string _selectedSKU = "";


        #endregion

        #region class properties

        public static SKUnit GetInstance
        {
            get
            {
                if (instance == null || instance.IsDisposed)
                {
                    instance = new SKUnit();
                }
                return instance;
            }
        }


        #endregion

        #region class helper

        private void UpdateUI()
        {
            tsbtnEdit.Enabled = !(String.IsNullOrEmpty(_selectedSKU));
            tsbtnDelete.Enabled = tsbtnEdit.Enabled;
        }

        private void GetSKUList()
        {
            dgv.SuspendLayout();
            dgv.ClearSelection();

            dgv.DataSource = new SkuDAL().GetSKUs();

            dgv.Columns["SKUCode"].HeaderText = "SKU Name";
            dgv.Columns["SKUDetail"].HeaderText = "Description";
            dgv.Columns["SKUDetail"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns["ConvertFactor"].HeaderText = "Factor";
            dgv.Columns["ConvertFactor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv.Columns["ConvertFactor"].DefaultCellStyle.Format = "N2";


            dgv.ResumeLayout();
            lbCount.Text = $"found:{dgv.Rows.Count}";
            UpdateUI();
        }

        private void AddEditSKUItem(string skuCode)
        {
            using (var skuInfo = new SKUinfo(skuCode))
            {
                skuInfo.StartPosition = FormStartPosition.CenterScreen;

                if (skuInfo.ShowDialog(this) == DialogResult.OK)
                {
                    _selectedSKU = "";
                    GetSKUList();
                }
            }
        }

        #endregion

        public SKUnit()
        {
            InitializeComponent();
            dgv.DoubleBuffered();
            dgv.SettingDataGrid();

            CenterToScreen();
        }

        private void SKUnit_Load(object sender, EventArgs e)
        {
            GetSKUList();
        }

        private void dgv_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            _selectedSKU = dgv["SKUCode", e.RowIndex].Value.ToString();

            UpdateUI();
        }

        private void dgv_DoubleClick(object sender, EventArgs e)
        {
            tsbtnEdit.PerformClick();
        }

        private void tsbtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbtnRefresh_Click(object sender, EventArgs e)
        {
            GetSKUList();
        }

        private void tsbtnAdd_Click(object sender, EventArgs e)
        {
            _selectedSKU = "";
            AddEditSKUItem(_selectedSKU);
        }

        private void tsbtnEdit_Click(object sender, EventArgs e)
        {
            AddEditSKUItem(_selectedSKU);
        }

        private void tsbtnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you want to delete the selected SKU?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (new SkuDAL().RemoveSUK(_selectedSKU) > 0)
                {
                    MessageBox.Show("Delete the selected SKU successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetSKUList();
                }
            }
        }
    }
}
