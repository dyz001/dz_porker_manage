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
    public partial class WinMain : Form
    {
        protected WinUserInput m_winUserInput;
        public WinMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (m_winUserInput == null)
            {
                m_winUserInput = new WinUserInput();
                m_winUserInput.Owner = this;
                m_winUserInput.Show();
            }
        }
    }
}
