using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dz_manager
{
    public class SuperForm : Form
    {
        public SuperForm() 
        {
            this.TopLevel = false;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        }
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
        }
    }
}
