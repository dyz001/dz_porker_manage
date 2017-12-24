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

        protected virtual void PreShowWin() { }
        public void ShowWin()
        {
            PreShowWin();
            Show();
        }
        protected virtual void PreHide() { }

        public void HideWin()
        {
            PreHide();
            Hide();
        }
    }
}
