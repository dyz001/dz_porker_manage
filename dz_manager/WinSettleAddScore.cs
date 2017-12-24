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
    public partial class WinSettleAddScore : SuperForm
    {
        public class SumScore
        {
            public string member_name { get; set; }
            public double sum_score { get; set; }
        }
        protected const string sql_settle = "select member_name, sum(score) as" +
            " sum_score from add_score_record where desk_name = '{0}' group by member_name";
        protected IList<bill_record> m_bill_list;
        public WinSettleAddScore()
        {
            InitializeComponent();
        }

        protected override void PreShowWin()
        {
            base.PreShowWin();
            dgv_settle.Columns[0].DataPropertyName = "id";
            dgv_settle.Columns[1].DataPropertyName = "member_name";
            dgv_settle.Columns[2].DataPropertyName = "take_in";
            dgv_settle.Columns[3].DataPropertyName = "fluctuate";
            dgv_settle.Columns[4].DataPropertyName = "insure";
            dgv_settle.Columns[5].DataPropertyName = "other";
            dgv_settle.AutoGenerateColumns = false;
        }

        private void btn_settle_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txt_desk_no.Text))
            {
                MessageBox.Show("未输入桌号");
                txt_desk_no.Focus();
                return;
            }
            IList<SumScore> sum_score_lst = DBUtil.GetInstance().GetLstBySql<SumScore>(string.Format(sql_settle, txt_desk_no.Text));
            if(sum_score_lst.Count == 0)
            {
                MessageBox.Show("此桌没有上分记录");
                return;
            }
            m_bill_list = DBUtil.GetInstance().GetLstItems<bill_record>("desk_name='" + txt_desk_no.Text + "'");
            int max_id = 0;
            foreach(bill_record bill in m_bill_list)
            {
                max_id = bill.id < max_id ? max_id : bill.id;
            }
            foreach(SumScore score in sum_score_lst)
            {
                int target = m_bill_list.Count(entity =>entity.member_name == score.member_name);
                if (target == 0)
                {
                    m_bill_list.Add(new bill_record()
                    {
                        id = max_id + 1,
                        member_name = score.member_name,
                        take_in = score.sum_score,
                        desk_name = txt_desk_no.Text
                    });
                    max_id = max_id + 1;
                }
            }
            dgv_settle.DataSource = m_bill_list;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            if (m_bill_list == null) return;
            bool is_ok = true;
            foreach(var item in m_bill_list)
            {
                if(item.fluctuate != 0 || item.insure != 0 || item.other != 0)
                {
                    if(!DBUtil.GetInstance().CheckAndAdd<bill_record>("member_name='" + item.member_name + "' and desk_name='" + 
                        item.desk_name + "'", item))
                    {
                        is_ok = false;
                        MessageBox.Show("会员:" + item.member_name + "的数据保存失败");
                    }
                }
            }
            if(is_ok)
            {
                MessageBox.Show("数据保存成功");
            }
        }

        private void btn_out_account_Click(object sender, EventArgs e)
        {
            WinMain.GetInstance().ShowFinishDeskWin(txt_desk_no.Text);
        }
    }
}
