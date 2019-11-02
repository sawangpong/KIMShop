using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KIM.views.Inventory
{
	public partial class Inventory : Form
	{
        #region class field
        private static Inventory instance;

        #endregion

        #region class properties
        public static Inventory  GetInstance
        {
            get
            {
                if(instance == null || instance.IsDisposed)
                {
                    instance = new Inventory();
                }
               return instance;
            }
        }
        #endregion


        #region class helper

        private void updateUI()
        {

        }

        #endregion

        public Inventory()
		{
			InitializeComponent();
		}

        private void Inventory_Load(object sender, EventArgs e)
        {

        }

        private void tsbtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
