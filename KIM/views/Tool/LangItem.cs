using KIM.data;
using KIM.models;
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
    public partial class LangItem : Form
    {
        #region class field member
        private LangDict _lang;
        private DataActionMode _mode = DataActionMode.None;
        private string _keyword = string.Empty;

        #endregion

        #region class helper
        private void UpdateUI()
        {
            txtKeyword.Enabled = (_mode == DataActionMode.Add);
            btnSave.Enabled = !String.IsNullOrEmpty(txtKeyword.Text) &&
                                !String.IsNullOrEmpty(txtEN.Text);
        }

        private void GetItemLanguageInfo(string key)
        {
            switch (_mode)
            {
                case DataActionMode.Add:
                    _lang = new LangDict();
                    break;

                case DataActionMode.Edit:
                    _lang = new LangDAL().GetLanguage(key);
                    break;
            }

            // map
            txtKeyword.Text = _lang.Keyword;
            txtEN.Text = _lang.EN_text;
            txtKH.Text = _lang.KH_text;
            txtTH.Text = _lang.TH_text;

            UpdateUI();
        }

        private void UpdateItemLang(LangDict lang)
        {
            if (new LangDAL().UpdateLanguageDict(lang, _mode) <= 0)
            {
                MessageBox.Show("Error update Language dictionary!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        public LangItem(string keyWord)
        {
            InitializeComponent();

            _keyword = keyWord;
            _mode = String.IsNullOrEmpty(keyWord) ? DataActionMode.Add : DataActionMode.Edit;
            lbMode.Text = _mode.ToString();

            GetItemLanguageInfo(_keyword);
        }

        private void LangItem_Load(object sender, EventArgs e)
        {

        }

        private void txt_TextChanged(object sender, EventArgs e)
        {
            UpdateUI();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _lang.Keyword = txtKeyword.Text;
            _lang.KH_text = txtKH.Text;
            _lang.EN_text = txtEN.Text;
            _lang.TH_text = txtTH.Text;

            UpdateItemLang(_lang);
        }
    }
}
