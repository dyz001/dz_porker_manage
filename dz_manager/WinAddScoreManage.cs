using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using DataInput.DBOper;

namespace dz_manager
{
    public partial class WinAddScoreManage : SuperForm
    {
        public class ScoreCell : ICloneable
        {
            protected Label lbl_desk_no;
            protected Label lbl_desk_no_val;
            protected Label lbl_game_id;
            protected Label lbl_game_id_val;
            protected Label lbl_add_score;
            protected Label lbl_add_score_sum;
            protected TextBox txt_add_score;
            protected Label lbl_balance;
            protected Label lbl_balance_val;
            protected Button btn_add;
            protected Button btn_finish;
            protected Panel pnl_main;

            public void SetVisible(bool isVisible)
            {
                this.pnl_main.Visible = isVisible;
            }

            public ScoreCell(Label desk_no, Label desk_no_val, Label game_id, Label game_id_val, Label add_score,
                Label add_score_sum, TextBox txt_add_score, Label balance, Label balance_val, Button btn_add,
                Button btn_finish, Panel pnl_main)
            {
                this.lbl_add_score = add_score;
                this.lbl_add_score_sum = add_score_sum;
                this.lbl_balance = balance;
                this.lbl_balance_val = balance_val;
                this.lbl_desk_no = desk_no;
                this.lbl_desk_no_val = desk_no_val;
                this.lbl_game_id = game_id;
                this.lbl_game_id_val = game_id_val;
                this.txt_add_score = txt_add_score;
                this.btn_add = btn_add;
                this.btn_finish = btn_finish;
                this.pnl_main = pnl_main;
            }

            public void SetData(string desk_no, string game_id, string score_sum, string balance)
            {
                this.lbl_desk_no_val.Text = desk_no;
                this.lbl_game_id_val.Text = game_id;
                this.lbl_add_score_sum.Text = score_sum;
                this.lbl_balance_val.Text = balance;
            }

            public Panel GetMainPnl()
            {
                return this.pnl_main;
            }

            public object Clone()
            {
                return new ScoreCell(Tools.CopyControl(this.lbl_desk_no) as Label,
                    Tools.CopyControl(this.lbl_desk_no_val) as Label,
                    Tools.CopyControl(this.lbl_game_id) as Label,
                    Tools.CopyControl(this.lbl_game_id_val) as Label,
                    Tools.CopyControl(this.lbl_add_score) as Label,
                    Tools.CopyControl(this.lbl_add_score_sum) as Label,
                    Tools.CopyControl(this.txt_add_score) as TextBox,
                    Tools.CopyControl(this.lbl_balance) as Label,
                    Tools.CopyControl(this.lbl_balance_val) as Label,
                    Tools.CopyControl(this.btn_add) as Button,
                    Tools.CopyControl(this.btn_finish) as Button,
                    Tools.CopyControl(this.pnl_main) as Panel);
            }
        }

        public class SumScore
        {
            public string member_name { get; set; }
            public double sum_score { get; set; }
        }

        protected ScoreCell m_cell_first;
        protected desk m_desk;
        protected member m_member;
        protected DlgAddBalance m_dlgAddBalance;
        protected const string sql_get_sum_score = 
            "select member_name, sum(score) as sum_score from add_score_record where desk_name='{0}' and member_name = '{1}' group by member_name";
        public WinAddScoreManage()
        {
            InitializeComponent();
            //初始化模板
            m_cell_first = new ScoreCell(this.lbl_desk_no, this.lbl_desk_no_val,
                this.lbl_member_id, this.lbl_member_id_val,
                this.lbl_add_score, this.lbl_score_sum, this.txt_score,
                this.lbl_balance, this.lbl_balance_val, this.btn_add, this.btn_finish, this.pnl_template);
            m_cell_first.SetVisible(false);
            m_dlgAddBalance = new DlgAddBalance();
        }

        protected override void PreShowWin()
        {
            base.PreShowWin();
            txt_desk_no.Text = "";
            m_cell_first.SetVisible(false);
            txt_game_id.Text = "";
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            m_desk = DBUtil.GetInstance().GetEntityByWhere<desk>("name='" + txt_desk_no.Text + "'");
            if(m_desk == null)
            {
                MessageBox.Show(Constant.WIN_SCORE_DESK_NOT_FOUND);
                txt_desk_no.Focus();
                return;
            }
            m_member = DBUtil.GetInstance().GetEntityByWhere<member>("game_id='" + txt_game_id.Text + "'");
            if(m_member == null)
            {
                MessageBox.Show(Constant.WIN_SCORE_MEMBER_NOT_FOUND);
                txt_game_id.Focus();
                return;
            }
            SumScore sum_score = DBUtil.GetInstance().GetEntityBySql<SumScore>
                (string.Format(sql_get_sum_score, m_desk.name, m_member.game_id));
            m_cell_first.SetData(m_desk.name, m_member.game_id, sum_score == null ? "0" : sum_score.sum_score.ToString(), m_member.balance.ToString());
            m_cell_first.SetVisible(true);
        }

        private void btn_finish_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txt_score.Text))
            {
                MessageBox.Show("没有上分");
                return;
            }
            if(int.Parse(txt_score.Text) > int.Parse(lbl_balance_val.Text))
            {
                MessageBox.Show("上分大于余额");
                txt_score.Focus();
                return;
            }
            add_score_record add_score = new add_score_record();
            add_score.desk_id = m_desk.id;
            add_score.desk_name = lbl_desk_no_val.Text;
            add_score.member_name = lbl_member_id_val.Text;
            add_score.member_id = m_member.id;
            add_score.score = double.Parse(txt_score.Text);
            add_score.cur_score = m_member.balance - add_score.score;
            add_score.add_time = DateTime.Now;
            m_member.balance -= add_score.score;
            if(!DBUtil.GetInstance().Update<member>(m_member))
            {
                MessageBox.Show("用户信息保存失败");
                return;
            }
            add_score.optor = DataManager.GetAuthUser().username;
            if(!DBUtil.GetInstance().SaveObj<add_score_record>(add_score))
            {
                MessageBox.Show("添加记录失败");
                return;
            }
            MessageBox.Show("上分操作完成");

            //更新ui显示
            txt_score.Text = "";
            lbl_score_sum.Text = (double.Parse(lbl_score_sum.Text) + add_score.score).ToString();
            lbl_balance_val.Text = m_member.balance.ToString();
        }

        public void AddBalance(double balance)
        {
            if(balance <= 0)
            {
                return;
            }
            m_member.balance += balance;
            if(!DBUtil.GetInstance().Update<member>(m_member))
            {
                MessageBox.Show("填充额度失败");
                return;
            }

            lbl_balance_val.Text = m_member.balance.ToString();

            //todo: 添加余额增加记录
            add_balance_record record = new add_balance_record();
            record.game_id = m_member.game_id;
            record.add_balance = balance;
            record.cur_balance = m_member.balance;
            record.optor = DataManager.GetAuthUser().username;
            if (!DBUtil.GetInstance().SaveObj<add_balance_record>(record))
            {
                MessageBox.Show("记录保存失败");
                return;
            }
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            m_dlgAddBalance.ShowWithWin(this);
        }
    }
}
