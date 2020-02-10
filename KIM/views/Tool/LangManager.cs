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
    public partial class LangManager : Form
    {
        #region class field
        private static LangManager instance;
        private int _lineId = 0;
        private string _langKeyword = "";

        #endregion

        #region class properties
        public static LangManager GetInstance
        {
            get
            {
                if(instance == null || instance.IsDisposed)
                {
                    instance = new LangManager();
                }
                return instance;
            }
        }

        #endregion

        #region class helper
        private void UpdateUI()
        {
            tsbtnEdit.Enabled = (_lineId > 0);
            tsbtnDelete.Enabled = tsbtnEdit.Enabled;
        }

        private void GetLangDict()
        {
            dgv.SuspendLayout();
            dgv.DataSource = new LangDAL().GetLanguages().ToDataTable();

            dgv.Columns["EN_text"].HeaderText = "EN";
            dgv.Columns["KH_text"].HeaderText = "KH";
            dgv.Columns["TH_text"].HeaderText = "TH";

            dgv.ResumeLayout();

            UpdateUI();
        }

        private void LangDictItem(string keyword)
        {
            using(LangItem _langItem = new LangItem(keyword))
            {
                _langItem.StartPosition = FormStartPosition.CenterScreen;

                if(_langItem.ShowDialog(this) == DialogResult.OK)
                {
                    tsbtnRefresh.PerformClick();
                }
            }
        }


        #endregion


        public LangManager()
        {
            InitializeComponent();
            // utils.utilcore.SettingDataGrid(ref dgv);
            dgv.DoubleBuffered(true);
            dgv.SettingDataGrid();

        }

        private void tsbtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LangManager_Load(object sender, EventArgs e)
        {
            GetLangDict();
        }

        private void dgv_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            _lineId = Convert.ToInt32(dgv["Id",e.RowIndex].Value);
            _langKeyword = dgv["Keyword", e.RowIndex].Value.ToString();

        }

        private void dgv_DoubleClick(object sender, EventArgs e)
        {
            tsbtnEdit.PerformClick();
        }

        private void tsbtnAdd_Click(object sender, EventArgs e)
        {
            _lineId = 0;
            _langKeyword = "";

            LangDictItem(_langKeyword);
        }

        private void tsbtnEdit_Click(object sender, EventArgs e)
        {
            LangDictItem(_langKeyword);

        }

        private void tsbtnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to delete dictionary item?","Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if(new LangDAL().RemoveLangDict(_langKeyword) > 0)
                {
                    MessageBox.Show("Delete dictionary item successfully..", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            tsbtnRefresh.PerformClick();
        }

        private void tsbtnRefresh_Click(object sender, EventArgs e)
        {
            GetLangDict();
        }
    }
}
