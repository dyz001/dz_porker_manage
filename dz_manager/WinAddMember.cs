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
    public partial class WinAddMember : SuperForm
    {
        public WinAddMember()
        {
            InitializeComponent();
        }

        protected override void PreShowWin()
        {
            base.PreShowWin();
            txt_game_id.Text = "";
            txt_proxy_no.Text = "";
            txt_wx_id.Text = "";
            txt_ali_id.Text = "";
            txt_limit.Text = "";
            IList<choushui> db_choushui = DataManager.GetChouShuiList();
            cmb_choushui.Items.Clear();
            foreach(choushui item in db_choushui)
            {
                cmb_choushui.Items.Add(item);
            }
            cmb_choushui.SelectedText = "";
            cmb_choushui.SelectedItem = null;
            cmb_choushui.Text = "";
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            if(SaveCurRecord())
            {
                InitUI();
            }
        }

        protected bool CheckInput()
        {
            if(string.IsNullOrEmpty(txt_game_id.Text))
            {
                txt_game_id.Focus();
                return false;
            }
            if(string.IsNullOrEmpty(txt_wx_id.Text) && string.IsNullOrEmpty(txt_ali_id.Text))
            {
                txt_wx_id.Focus();
                return false;
            }
            if(cmb_choushui.SelectedItem == null)
            {
                cmb_choushui.Focus();
                return false;
            }
            return true;
        }

        protected bool SaveCurRecord()
        {
            if (!CheckInput()) return false ;
            member mem = new member();
            mem.first_balance = double.Parse(txt_limit.Text);
            mem.balance = double.Parse(txt_limit.Text);
            mem.game_id = txt_game_id.Text;
            mem.optor = DataManager.GetAuthUser().username;
            mem.proxy_id = txt_proxy_no.Text;
            mem.wx_id = txt_wx_id.Text;
            mem.ali_id = txt_ali_id.Text;
            mem.cs_type = (cmb_choushui.SelectedItem as choushui).cs_type;

            if (!DBUtil.GetInstance().SaveObj<member>(mem))
            {
                MessageBox.Show("会员保存失败");
                return false;
            }
            MessageBox.Show("录入成功");
            return true;
        }

        protected void InitUI()
        {
            txt_game_id.Text = "";
            txt_proxy_no.Text = "";
            txt_wx_id.Text = "";
            txt_ali_id.Text = "";
            txt_limit.Text = "";
            cmb_choushui.SelectedText = "";
            cmb_choushui.SelectedItem = null;
            cmb_choushui.Text = "";
        }

    }
}
