using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KIM.UserComponent
{ 
    public class SearchButton : Button
    {
        public SearchButton()
        {
            this.Width = (int)((decimal)this.Height * 1.25m);
            this.Image = global::KIM.Properties.Resources.ZoomHS;
            this.Text = "";

        }
    }
}
