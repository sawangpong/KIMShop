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
    public partial class About : Form
    {
        private static About instance;
        public static About GetInstance
        {
            get 
            { 
                if(instance == null || instance.IsDisposed)
                {
                    instance = new About();
                }
                return instance;
            }
        }

        public About()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void About_Load(object sender, EventArgs e)
        {
            lbName.Text = Application.ProductName;
            lbVersion.Text = $"version:{Application.ProductVersion}";
            lbProgrammer.Text = "Programmer: Tony";
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
