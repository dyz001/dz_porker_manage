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
    public partial class DlgAddDesk : Form
    {
        protected Form WinParent;
        public DlgAddDesk()
        {
            InitializeComponent();
        }
        protected void init_data()
        {
            txt_desk_name.Text = "";
            dtp_desk.Value = DateTime.Now;
        }

        public void ShowWithWinParent(Form param)
        {
            WinParent = param;
            init_data();
            Show();
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txt_desk_name.Text))
            {
                MessageBox.Show("没有填写桌子名称");
                return;
            }
            else
            {
                ((WinDeskManager)this.WinParent).AddCell(txt_desk_name.Text, "未开始", dtp_desk.Value);
                this.Hide();
            }
        }
        
    }
}
