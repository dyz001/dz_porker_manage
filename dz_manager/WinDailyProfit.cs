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
    public partial class WinDailyProfit : SuperForm
    {
        public class DailyProfit
        {
            public int Id { get; set; }
            public string DeskName { get; set; }
            public double JingShui { get; set; }
            public double Insure { get; set; }
            public double Other { get; set; }
            public double InCome { get; set; }
            public double League { get; set; }
            public string DetailInfo
            {
                get
                {
                    return "详情";
                }
            }
        }

        protected List<DailyProfit> m_lstDailyProfit;
        private BindingSource bindingS = new BindingSource();

        public WinDailyProfit()
        {
            InitializeComponent();
            m_lstDailyProfit = new List<DailyProfit>();
        }

        protected override void PreShowWin()
        {
            base.PreShowWin();
            data_grid_daily.AutoGenerateColumns = false;
            data_grid_daily.Columns["Id"].DataPropertyName = "Id";
            data_grid_daily.Columns["desk_no"].DataPropertyName = "DeskName";
            data_grid_daily.Columns["choushui"].DataPropertyName = "JingShui";
            data_grid_daily.Columns["insure"].DataPropertyName = "Insure";
            data_grid_daily.Columns["other"].DataPropertyName = "Other";
            data_grid_daily.Columns["sum"].DataPropertyName = "InCome";
            data_grid_daily.Columns["union"].DataPropertyName = "League";
            data_grid_daily.Columns["detail"].DataPropertyName = "DetailInfo";
        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            IList<desk> over_desks = DBUtil.GetInstance().GetLstItems<desk>(Tools.GetSqlDateCond("end_date", 
                dtp_date.Value, dtp_date.Value.AddDays(1)));
            if(over_desks.Count == 0)
            {
                return;
            }
            m_lstDailyProfit.Clear();
            StringBuilder sb_over_desk = new StringBuilder();
            foreach(var item in over_desks)
            {
                sb_over_desk.Append("'").Append(item.name).Append("',");
            }
            sb_over_desk = sb_over_desk.Remove(sb_over_desk.Length - 1, 1);
            IList<bill_record> bill_records = DBUtil.GetInstance().GetLstItems<bill_record>(
                "desk_name in (" + sb_over_desk + ")");
            foreach(var item in bill_records)
            {
                DailyProfit target = m_lstDailyProfit.Find(entity => entity.DeskName == item.desk_name);
                if (target == null)
                {
                    desk t_desk = over_desks.First(entity => entity.name == item.desk_name);
                    target = new DailyProfit();
                    target.DeskName = item.desk_name;
                    target.Id = item.id;
                    target.InCome = t_desk.income;
                    target.League = t_desk.league;
                    m_lstDailyProfit.Add(target);
                }
                target.Insure += item.pure_insure;
                target.JingShui += item.jingchoushui;
                target.Other += item.other;
            }

            data_grid_daily.DataSource = m_lstDailyProfit;
        }

        private void data_grid_daily_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void data_grid_daily_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == data_grid_daily.Columns.Count - 1)
            {
                string desk_no = data_grid_daily.Rows[e.RowIndex].Cells["desk_no"].Value.ToString();
                WinMain.GetInstance().ShowFinishDeskWin(desk_no);
            }
        }
    }
}
