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
    public partial class UOMMaster : Form
    {
        #region class field member
        private static UOMMaster instance;
        private string _selectedUOM = "";
        private UOM _uom;
        #endregion

        #region class properties
        public static UOMMaster GetInstance
        {
            get
            {
                if(instance == null || instance.IsDisposed)
                {
                    instance = new UOMMaster();
                }
                return instance;
            }
        }
        #endregion

        #region helper

        private void UpdateUI()
        {
            tsbtnEdit.Enabled = !String.IsNullOrEmpty(_selectedUOM);
            tsbtnDelete.Enabled = tsbtnEdit.Enabled;
        }

        private void GetUOMList()
        {
            dgv.SuspendLayout();
            dgv.ClearSelection();
            dgv.DataSource = new UOMDAL().GetUOMs();
            dgv.Columns["UOMName"].HeaderText = "UOM";
            dgv.Columns["UOMName"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns["Factor"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgv.Columns["Factor"].DefaultCellStyle.Format = "N2";
            dgv.ResumeLayout();

            UpdateUI();
            lbCount.Text = $"found:{dgv.Rows.Count}";
        }

        private void AddEditUOM(string name)
        {
            using(var _uomInfo = new UOMInfo(name))
            {
                _uomInfo.StartPosition = FormStartPosition.CenterScreen;
                if(_uomInfo.ShowDialog(this) <= 0)
                {
                    MessageBox.Show("Can't update UOM Info", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                GetUOMList();
            }
        }

        #endregion

        public UOMMaster()
        {
            InitializeComponent();
            dgv.DoubleBuffered();
            dgv.SettingDataGrid();
        }

        private void UOMMaster_Load(object sender, EventArgs e)
        {
            GetUOMList();
        }

        private void dgv_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            _selectedUOM = dgv["UOMName", e.RowIndex].Value.ToString();

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

        private void tsbtnAdd_Click(object sender, EventArgs e)
        {
            _selectedUOM = "";
            AddEditUOM(_selectedUOM);
        }

        private void tsbtnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to delete the selected UOM record?","Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if(new UOMDAL().RemoveUOM(_selectedUOM) > 0)
                {
                    MessageBox.Show("Delete the selected UOM record successfully", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void tsbtnEdit_Click(object sender, EventArgs e)
        {
            AddEditUOM(_selectedUOM);
        }

        private void tsbtnRefresh_Click(object sender, EventArgs e)
        {
            GetUOMList();
        }
    }
}
