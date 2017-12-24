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
    public partial class DlgAddBalance : Form
    {
        protected WinAddScoreManage m_pAddScoreManager;
        public DlgAddBalance()
        {
            InitializeComponent();
        }

        public void ShowWithWin(WinAddScoreManage pWin)
        {
            m_pAddScoreManager = pWin;
            Show();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if (m_pAddScoreManager == null) return;
            if(string.IsNullOrEmpty(txt_balance.Text))
            {
                MessageBox.Show("没有输入金额");
                txt_balance.Focus();
                return;
            }
            if(double.Parse(txt_balance.Text) <= 0)
            {
                MessageBox.Show("输入金额不合法");
                txt_balance.Focus();
                return;
            }
            m_pAddScoreManager.AddBalance(double.Parse(txt_balance.Text));
            Hide();
        }
    }
}
