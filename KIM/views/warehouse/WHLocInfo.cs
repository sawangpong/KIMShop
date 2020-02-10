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
    public partial class WHLocInfo : Form
    {
        #region class field
        private DataActionMode _mode = DataActionMode.None;
        private WareHouse _wh;
        private string _whCode = "";

        #endregion

        #region class helper

        private void UpdateUI()
        {
            txtWHCode.Enabled = _mode == DataActionMode.Add;

            btnSave.Enabled = !String.IsNullOrEmpty(txtWHCode.Text);
        }

        private void GetWHInfo(string code)
        {
            switch (_mode)
            {
                case DataActionMode.Add:
                    _wh = new WareHouse();
                    break;

                case DataActionMode.Edit:
                    _wh = new WarehouseDAL().GetWarehouseById(code);
                    break;
            }

            txtWHCode.Text = _wh.WHCode;
            txtWHName.Text = _wh.WHName;

            UpdateUI();
        }

        #endregion

        public WHLocInfo(string Code)
        {
            InitializeComponent();

            _whCode = Code;
            _mode = String.IsNullOrEmpty(_whCode) ? DataActionMode.Add : DataActionMode.Edit;
            lbMode.Text = _mode.ToString();
        }

        private void WHLocInfo_Load(object sender, EventArgs e)
        {
            GetWHInfo(_whCode);
        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _wh.WHCode = txtWHCode.Text;
            _wh.WHName = txtWHName.Text;

            if(new WarehouseDAL().UpdateWarehouse(_wh,_mode) > 0)
            {
                MessageBox.Show("Update Warehouse location successfully.", "Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
