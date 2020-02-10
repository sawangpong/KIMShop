using KIM;
using KIM.models.Tool;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace KIM.utils
{

    public static class LangUtils
    {
        public static void GetLanguageByDefaultCode(string code)
        {
            DataTable _dt = new LangDAL().GetLanguageByCode(code);

            vars.LANG_DICT = new Hashtable();
            foreach (DataRow _dr in _dt.Rows)
            {
                switch (code)
                {
                    case "EN":
                        vars.LANG_DICT.Add(_dr["KeyWord"].ToString(), _dr["EN_text"].ToString());
                        break;

                    case "KH":
                        vars.LANG_DICT.Add(_dr["KeyWord"].ToString(), _dr["KH_text"].ToString());
                        break;

                    case "TH":
                        vars.LANG_DICT.Add(_dr["KeyWord"].ToString(), _dr["TH_text"].ToString());
                        break;
                }
            }
        }

        public static void SetDefaultLanguage(string code, ref Form form)
        {
            GetLanguageByDefaultCode(code);

            //if(vars.LANG_DICT.Count > 0)
            //{
            //    MessageBox.Show("Language Loaded...");
            //}

            foreach (Control c in form.Controls)
            {
                if (c.GetType().ToString() == "System.Windows.Forms.Label"
                    || c.GetType().ToString() == "System.Windows.Forms.ToolStripMenuItem")
                {
                    //c.Text = vars.LANG_DICT.ContainsKey(c.Tag.ToString()).First().Value.ToString();
                }
            }
        }

        public static string GetLanguageValue(this System.Windows.Forms.MenuStrip item)
        {
            string _result = item.Text;
            if (item.Tag != null)
            {
                if (vars.LANG_DICT[item.Tag.ToString()] != null)
                {
                    _result = vars.LANG_DICT[item.Tag.ToString()].ToString();
                }
            }
            return _result;
        }

        public static string GetLanguageValue(this System.Windows.Forms.ToolStripMenuItem item)
        {
            string _result = item.Text;
            if (item.Tag != null)
            {
                if (vars.LANG_DICT[item.Tag.ToString()] != null)
                {
                    _result = vars.LANG_DICT[item.Tag.ToString()].ToString();
                }
            }
            return _result;
        }

        public static string GetLanguageValue(this System.Windows.Forms.ToolStripItem item)
        {
            string _result = item.Text;
            if (item.Tag != null)
            {
                if (vars.LANG_DICT[item.Tag.ToString()] != null)
                {
                    _result = vars.LANG_DICT[item.Tag.ToString()].ToString();
                }
            }
            return _result;
        }

        //public static string GetLanguageValue(Control key)
        //{
        //    string _result = "";

        //    if(key is System.Windows.Forms.MenuStrip)
        //    {
        //        MenuStrip mnu = key as System.Windows.Forms.MenuStrip;
        //        if(mnu.Tag != null)
        //        {
        //            _result = vars.LANG_DICT[mnu.Tag.ToString()].ToString();
        //        }
        //        else
        //        {
        //            _result = mnu.Text;
        //        }
        //    }
        //    else if(key is System.Windows.Forms.ToolStripMenuItem)
        //    {
        //        System.Windows.Forms.ToolStripMenuItem item = key as System.Windows.Forms.ToolStripMenuItem;
        //        if(item.Tag != null)
        //        {
        //            _result = vars.LANG_DICT[item.Tag.ToString()].ToString();
        //        }
        //        else
        //        {
        //            _result = item.Text;
        //        }
        //    }

        //    return _result;
        //}
    }
}
