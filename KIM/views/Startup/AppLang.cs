using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KIM.views.Startup
{
    public partial class AppLang : Form
    {
        public string SelectedLanguage { get; set; }

        public AppLang()
        {
            InitializeComponent();
            btnKH.Text = "ភាសាខ្មែរ។";
        }

        private void AppLang_Load(object sender, EventArgs e)
        {

        }

        private void btn_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            vars.LANG_USE = btn.Tag.ToString();
            this.SelectedLanguage = vars.LANG_USE;

            this.Close();
        }
    }
}
