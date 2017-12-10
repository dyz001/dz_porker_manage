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
        protected Dictionary<SubBtnType, List<RadioButton>> m_dic_btns;
        protected List<RadioButton> AddScoreSubBtns;
        protected List<RadioButton> ProxyMgrSubBtns;
        protected List<RadioButton> MemMgrSubBtns;
        protected List<RadioButton> DataMgrSubBtns;
        protected List<SuperForm> m_win_lst;

        public enum SubBtnType
        {
            EAddScore = 0,
            EProxyMgr = 1,
            EMemMgr = 2,
            EDataQuery = 3,
        }

        const int sub_btn_width = 80;
        const int sub_btn_height = 40;

        const int sub_btn_left = 10;
        const int sub_btn_top = 30;
        const int sub_btn_vertical_interval = 20;

        public WinMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            m_dic_btns = new Dictionary<SubBtnType,List<RadioButton>>();
            AddScoreSubBtns = new List<RadioButton>();
            ProxyMgrSubBtns = new List<RadioButton>();
            MemMgrSubBtns = new List<RadioButton>();
            DataMgrSubBtns = new List<RadioButton>();
            m_win_lst = new List<SuperForm>();

            //add buttons
            AddScoreSubBtns.Add(GetNewRdoBtn("牌桌管理", sub_btn_width, sub_btn_height, (object obj, EventArgs args)=>{
                RadioButton btn = obj as RadioButton;
                if (btn == null) return;
                if (btn.Checked == false) return;
                ShowSubWin(typeof(WinDeskManager));
            }));
            AddScoreSubBtns.Add(GetNewRdoBtn("上分管理", sub_btn_width, sub_btn_height, (object obj, EventArgs args)=>{
                RadioButton btn = obj as RadioButton;
                if (btn == null) return;
                if (btn.Checked == false) return;
                ShowSubWin(typeof(WinAddScoreManage));
            }));
            AddScoreSubBtns.Add(GetNewRdoBtn("结算管理", sub_btn_width, sub_btn_height,(object obj, EventArgs args)=>{
                RadioButton btn = obj as RadioButton;
                if (btn == null) return;
                if (btn.Checked == false) return;
                ShowSubWin(typeof(WinSettleAddScore));
            }));
            AddSubRadioBtns(AddScoreSubBtns);
            m_dic_btns.Add(SubBtnType.EAddScore, AddScoreSubBtns);

            ProxyMgrSubBtns.Add(GetNewRdoBtn("代理添加", sub_btn_width, sub_btn_height, (object obj, EventArgs args) =>
            {
                RadioButton btn = obj as RadioButton;
                if (btn == null) return;
                if (btn.Checked == false) return;
                ShowSubWin(typeof(WinProxyAdd));
            }));
            ProxyMgrSubBtns.Add(GetNewRdoBtn("代理查询", sub_btn_width, sub_btn_height,(object obj, EventArgs args)=>{
                RadioButton btn = obj as RadioButton;
                if (btn == null) return;
                if (btn.Checked == false) return;
                ShowSubWin(typeof(WinProxyQuery));
            }));
            AddSubRadioBtns(ProxyMgrSubBtns);
            m_dic_btns.Add(SubBtnType.EProxyMgr, ProxyMgrSubBtns);

            MemMgrSubBtns.Add(GetNewRdoBtn("会员添加", sub_btn_width, sub_btn_height, (object obj, EventArgs args) =>
            {
                RadioButton btn = obj as RadioButton;
                if (btn == null) return;
                if (btn.Checked == false) return;
                ShowSubWin(typeof(WinAddMember));
            }));
            MemMgrSubBtns.Add(GetNewRdoBtn("会员查询", sub_btn_width, sub_btn_height, (object obj, EventArgs args) =>
            {
                RadioButton btn = obj as RadioButton;
                if (btn == null) return;
                if (btn.Checked == false) return;
                ShowSubWin(typeof(WinMemberQuery));
            }));
            AddSubRadioBtns(MemMgrSubBtns);
            m_dic_btns.Add(SubBtnType.EMemMgr, MemMgrSubBtns);

            DataMgrSubBtns.Add(GetNewRdoBtn("日盈利查询", sub_btn_width, sub_btn_height, (object obj, EventArgs args) =>
            {
                RadioButton btn = obj as RadioButton;
                if (btn == null) return;
                if (btn.Checked == false) return;
                ShowSubWin(typeof(WinDailyProfit));
            }));
            DataMgrSubBtns.Add(GetNewRdoBtn("单桌盈利查询", sub_btn_width, sub_btn_height, (object obj, EventArgs args) =>
            {
                RadioButton btn = obj as RadioButton;
                if (btn == null) return;
                if (btn.Checked == false) return;
                ShowSubWin(typeof(WinDeskProfit));
            }));
            DataMgrSubBtns.Add(GetNewRdoBtn("代理盈利查询", sub_btn_width, sub_btn_height, (object obj, EventArgs args) =>
            {
                RadioButton btn = obj as RadioButton;
                if (btn == null) return;
                if (btn.Checked == false) return;
                ShowSubWin(typeof(WinProxerProfit));
            }));
            AddSubRadioBtns(DataMgrSubBtns);
            m_dic_btns.Add(SubBtnType.EDataQuery, DataMgrSubBtns);

            //event init
            rdo_proxy_mgr.CheckedChanged += this.OnMainMenuCheckChanged;
            rdo_member_mgr.CheckedChanged += this.OnMainMenuCheckChanged;
            rdo_data_query.CheckedChanged += this.OnMainMenuCheckChanged;
            rdo_add_score.CheckedChanged += this.OnMainMenuCheckChanged;
        }

        public void ShowSubWin(Type sub_win_type)
        {
            pnl_win.Controls.Clear();
            if(pnl_win.Controls.Count > 0)
            {
                pnl_win.Controls[0].Visible = false;
            }
            SuperForm form = GetWinByType(sub_win_type);
            pnl_win.Controls.Add(form);
            form.Show();
        }

        public SuperForm GetWinByType(Type type)
        {
            SuperForm target = null;
            foreach(SuperForm form in m_win_lst)
            {
                if(form.GetType() == type)
                {
                    target = form;
                }
            }
            if(target == null)
            {
                object obj = Activator.CreateInstance(type);
                m_win_lst.Add((SuperForm)obj);
                target = (SuperForm)obj;
            }
            return target;
        }

        protected void AddSubRadioBtns(List<RadioButton> btns)
        {
            for(int i = 0; i < btns.Count; i++)
            {
                gpb_add_score.Controls.Add(btns[i]);
                btns[i].Left = sub_btn_left;
                btns[i].Top = sub_btn_top + i * (sub_btn_vertical_interval + sub_btn_height);
                btns[i].Visible = false;
            }
        }

        protected void ShowSubBtnsByType(SubBtnType btn_type)
        {
            foreach(SubBtnType type in m_dic_btns.Keys)
            {
                foreach(RadioButton btn in m_dic_btns[type])
                {
                    btn.Visible = (type == btn_type);
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void rdo_add_score_CheckedChanged(object sender, EventArgs e)
        {
            //OnMainMenuCheckChanged();
        }

        protected override void OnClosed(EventArgs e)
        {
            Application.Exit();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            if (MessageBox.Show("确定要退出吗？", "退出提示", MessageBoxButtons.OKCancel)
                == System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        protected void OnMainMenuCheckChanged(object sender, EventArgs e)
        {
            if(rdo_add_score.Checked)
            {
                ShowSubBtnsByType(SubBtnType.EAddScore);
            }
            if(rdo_data_query.Checked)
            {
                ShowSubBtnsByType(SubBtnType.EDataQuery);
            }
            if(rdo_member_mgr.Checked)
            {
                ShowSubBtnsByType(SubBtnType.EMemMgr);
            }
            if(rdo_proxy_mgr.Checked)
            {
                ShowSubBtnsByType(SubBtnType.EProxyMgr);
            }
        }

        protected RadioButton GetNewRdoBtn(string text, int width, int height, EventHandler check_change)
        {
            RadioButton btn = new RadioButton();
            btn.Text = text;
            btn.Width = width;
            btn.Height = height;
            btn.Appearance = Appearance.Button;
            btn.CheckedChanged += check_change;
            return btn;
        }
    }
}
