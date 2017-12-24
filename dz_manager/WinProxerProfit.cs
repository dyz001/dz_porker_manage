using System;
using DataInput.DBOper;
using Model;
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
    public partial class WinProxerProfit : SuperForm
    {
        public class ProxyProfit
        {
            public int Id { get; set; }
            public string DeskName { get; set; }
            public double Profit { get; set; }
            public double FanShui { get; set; }
            public string DetailInfo 
            { 
                get
                {
                    return "详情";
                }
            }
        }

        protected List<ProxyProfit> m_profitLst;
        protected IList<bill_record> m_billRecords;
        protected IList<member> m_proxyMembers;
        protected proxy m_target;
        protected fanshui m_fanshui;
        public WinProxerProfit()
        {
            InitializeComponent();
            m_profitLst = new List<ProxyProfit>();
        }

        protected override void PreShowWin()
        {
            base.PreShowWin();
            txt_proxy_no.Text = "";
            dtp_date.Value = DateTime.Now;
            dgv_profit.AutoGenerateColumns = false;
            dgv_profit.Columns["Id"].DataPropertyName = "Id";
            dgv_profit.Columns["desk_no"].DataPropertyName = "DeskName";
            dgv_profit.Columns["profit"].DataPropertyName = "Profit";
            dgv_profit.Columns["fanshui"].DataPropertyName = "FanShui";
            dgv_profit.Columns["detail"].DataPropertyName = "DetailInfo";
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txt_proxy_no.Text))
            {
                txt_proxy_no.Focus();
                return;
            }
            m_target = DBUtil.GetInstance().GetEntityByWhere<proxy>("no = '" + txt_proxy_no.Text + "'");
            if(m_target == null)
            {
                txt_proxy_no.SelectAll();
                return;
            }
            m_fanshui = DBUtil.GetInstance().GetEntityByWhere<fanshui>("fs_type='" + m_target.fs_type + "'");
            if(m_fanshui == null)
            {
                MessageBox.Show("反水方式不存在:" + m_target.fs_type+", 请联系管理员解决");
                return;
            }
            m_proxyMembers = DBUtil.GetInstance().GetLstItems<member>("proxy_id='" + txt_proxy_no.Text + "'");
            if (m_proxyMembers.Count == 0) return;
            StringBuilder sb_member_ids = new StringBuilder();
            foreach(var item in m_proxyMembers)
            {
                sb_member_ids.Append("'").Append(item.game_id).Append("',");
            }
            sb_member_ids = sb_member_ids.Remove(sb_member_ids.Length - 1, 1);

            IList<desk> over_desk = DBUtil.GetInstance().GetLstItems<desk>(Tools.GetSqlDateCond("end_date", 
                dtp_date.Value, dtp_date.Value.AddDays(1)));
            if (over_desk.Count == 0) return;

            StringBuilder sb_over_desk_no = new StringBuilder();

            foreach(var item in over_desk)
            {
                sb_over_desk_no.Append("'").Append(item.name).Append("',");
            }
            sb_over_desk_no = sb_over_desk_no.Remove(sb_over_desk_no.Length - 1, 1);
            string where_cond = "";
            if(over_desk.Count > m_proxyMembers.Count)
            {
                where_cond = "member_name in (" + sb_member_ids.ToString() + ") and desk_name in (" + sb_over_desk_no.ToString() + ")";
            }
            else
            {
                where_cond = "desk_name in (" + sb_over_desk_no.ToString() + ")" + " and member_name in (" + sb_member_ids.ToString() + ")";
            }
            m_billRecords = DBUtil.GetInstance().GetLstItems<bill_record>(where_cond);
            double sum_profit = 0;
            //数据整理
            foreach(var item in m_billRecords)
            {
                ProxyProfit target = m_profitLst.Find(entity=>entity.DeskName == item.desk_name);
                if(target == null)
                {
                    target = new ProxyProfit();
                    target.DeskName = item.desk_name;
                    target.Id = item.id;
                    m_profitLst.Add(target);
                }
                sum_profit += item.jingchoushui;
                target.Profit += item.jingchoushui;
                target.FanShui += item.jingchoushui * m_fanshui.fs_value;
            }
            m_profitLst.ForEach(entity =>
            {
                entity.FanShui = Tools.FormatDouble(entity.FanShui);
                entity.Profit = Tools.FormatDouble(entity.Profit);
            });
            dgv_profit.DataSource = m_profitLst;
            lbl_profit_value.Text = sum_profit.ToString(); ;
        }
    }
}
