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
    public partial class WinLogin : Form
    {
        WinMain main;
        DBConfig win_config;
        public WinLogin()
        {
            InitializeComponent();
            main = new WinMain();
            win_config = new DBConfig();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            //todo:查询数据库确定用户存在
            this.Hide();
            main.StartPosition = FormStartPosition.CenterScreen;
            main.Show();
        }

        private void btn_db_set_Click(object sender, EventArgs e)
        {
            win_config.Show();
        }
    }
}
