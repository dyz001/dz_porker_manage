using DataInput.DBOper;
using Model;
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
        protected delegate void HideWinCallback();
        protected delegate void ShowMainWinCallback();
        protected delegate void SetStatusCallback(string s);
        protected Task<bool> auth_user_task;
        public WinLogin()
        {
            InitializeComponent();
            main = new WinMain();
            win_config = DBConfig.GetInstance();
            txt_password.PasswordChar = '*';
        }

        public bool CheckDBConfig(dz_manager.DBConfig.DBAuthData auth_data)
        {
            if(string.IsNullOrEmpty(auth_data.DBHost) ||
                string.IsNullOrEmpty(auth_data.DBName) ||
                string.IsNullOrEmpty(auth_data.DBPass) ||
                string.IsNullOrEmpty(auth_data.DBPort) ||
                string.IsNullOrEmpty(auth_data.DBUser))
            {
                return false;
            }
            return true;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            //检查数据库连接
            dz_manager.DBConfig.DBAuthData auth_data = win_config.GetDBAuthData();
            if (!CheckDBConfig(auth_data))
            {
                MessageBox.Show(Constant.DB_NOT_CONFIG);
                return;
            }
            if (string.IsNullOrEmpty(txt_username.Text) ||
                string.IsNullOrEmpty(txt_password.Text))
            {
                MessageBox.Show(Constant.DB_USER_OR_PASSWORD_NULL, "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (!DBUtil.TryOpenDB(auth_data))
            {
                MessageBox.Show(Constant.DB_CONNECT_FAIL);
                return;
            }
            DBUtil.SetMysqlAuth(auth_data);//设置数据库授权
            lbl_status.Text = Constant.WIN_VERIFY_USERINFO;
            tm_check.Start();
            //todo:查询数据库确定用户存在
            auth_user_task = new Task<bool>(AuthUser);
            auth_user_task.Start();
        }

        public bool AuthUser()
        {
            IList<auth_user> ret = DBUtil.GetInstance().GetLstItems<auth_user>("username = \"" + txt_username.Text + "\" and password = \"" + txt_password.Text + "\"");
            if (ret == null || ret.Count < 1)
            {
                MessageBox.Show(Constant.DB_USER_OR_PASSWORD_ERROR);
                return false;
            }
            DataManager.SetAuthUser(ret[0]);
            return true;
        }

        public void HideWin()
        {
            if(this.InvokeRequired)
            {
                HideWinCallback hide_cb = new HideWinCallback(HideWin);
                this.Invoke(hide_cb);
            }
            else
            {
                this.Hide();
            }
        }

        public void SetStatus(string text)
        {
            if(this.lbl_status.InvokeRequired)
            {
                SetStatusCallback set_status_cb = new SetStatusCallback(SetStatus);
                this.Invoke(set_status_cb, new object[] { text });
            }
            else
            {
                this.lbl_status.Text = text;
            }
        }

        public void ShowMain()
        {
            if(main.InvokeRequired)
            {
                ShowMainWinCallback show_main_cb = new ShowMainWinCallback(ShowMain);
                this.Invoke(show_main_cb);
            }
            else
            {
                main.StartPosition = FormStartPosition.CenterScreen;
                main.Show();
            }
        }

        protected string encrypt_pass(string password)
        {
            return password;
        }

        private void btn_db_set_Click(object sender, EventArgs e)
        {
            win_config.Show();
        }

        private void tm_check_Tick(object sender, EventArgs e)
        {
            if (auth_user_task == null) return;
            if(auth_user_task.Status == TaskStatus.RanToCompletion)
            {
                if(auth_user_task.Result)
                {
                    HideWin();
                    ShowMain();
                    tm_check.Stop();
                    auth_user_task = null;
                }
            }
        }
    }
}
