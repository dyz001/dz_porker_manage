using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dz_manager
{
    public partial class WinStatus : Form
    {
        protected static WinStatus m_instance;
        protected WinStatus()
        {
            InitializeComponent();
            this.TopLevel = false;
        }

        public void ShowByMsg(string msg, Form parent)
        {   
            this.Parent = parent;
            this.StartPosition = FormStartPosition.CenterParent;
            lbl_status.Text = msg;
            Show();
        }

        public static WinStatus GetInstance()
        {
            if(m_instance == null)
            {
                m_instance = new WinStatus();
            }
            return m_instance;
        }

        private void WinStatus_Load(object sender, EventArgs e)
        {

        }
    }
}
