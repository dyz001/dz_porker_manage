using System;
using Model;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataInput.DBOper;

namespace dz_manager
{
    public partial class WinProxyAdd : SuperForm
    {
        public WinProxyAdd()
        {
            InitializeComponent();
        }

        protected override void PreShowWin()
        {
            base.PreShowWin();
            InitUI();
            IList<fanshui> lst_fanshui = DataManager.GetFanShuiList();
            foreach(fanshui item in lst_fanshui)
            {
                cmb_fanshui.Items.Add(item);
            }
        }

        protected void InitUI()
        {
            txt_proxy_name.Text = "";
            txt_proxy_no.Text = "";
            cmb_fanshui.Items.Clear();
        }

        protected bool CheckInput()
        {
            if(string.IsNullOrEmpty(txt_proxy_name.Text))
            {
                txt_proxy_name.Focus();
                return false;
            }
            if(string.IsNullOrEmpty(txt_proxy_no.Text))
            {
                txt_proxy_no.Focus();
                return false;
            }

            return true;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (!CheckInput()) return;
            fanshui sel_fanshui = (cmb_fanshui.SelectedItem as fanshui);
            if(sel_fanshui == null)
            {
                MessageBox.Show("反水方式输入错误");
                cmb_fanshui.Focus();
                return;
            }
            proxy entity = new proxy();
            entity.fs_type = (cmb_fanshui.SelectedItem as fanshui).fs_type;
            entity.name = txt_proxy_name.Text;
            entity.no = txt_proxy_no.Text;
            entity.optor = DataManager.GetAuthUser().username;

            if(!DBUtil.GetInstance().SaveObj<proxy>(entity))
            {
                MessageBox.Show("代理信息保存失败");
            }
            MessageBox.Show("信息保存成功");
            InitUI();
        }
    }
}
