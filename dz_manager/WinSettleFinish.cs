using System;
using Model;
using DataInput.DBOper;
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
    public partial class WinSettleFinish : SuperForm
    {
        protected IList<bill_record> m_bill_list;
        protected desk m_desk;
        protected member m_member;
        protected double m_desk_income;
        protected double m_desk_union;
        protected string desk_no;
        public WinSettleFinish()
        {
            InitializeComponent();
        }

        public void SetDeskNo(string desk_no)
        {
            this.desk_no = desk_no;
            lbl_desk_no_val.Text = desk_no;
        }
        
        protected double format_double(double d_value)
        {
            return (double)((Int64)(d_value * 1000)) / 1000;
            //return d_value;
        }

        protected override void PreShowWin()
        {
            base.PreShowWin();
            if(string.IsNullOrEmpty(desk_no))
            {
                return;
            }
            //todo:初始化gridview
            m_bill_list = DBUtil.GetInstance().GetLstItems<bill_record>("desk_name='" + lbl_desk_no_val.Text + "'");
            m_desk = DBUtil.GetInstance().GetEntityByWhere<desk>("name='" + lbl_desk_no_val.Text + "'");            
            foreach(var item in m_bill_list)
            {
                item.pure_fluctuate = item.pure_fluctuate <= double.Epsilon ? 0.975 * item.fluctuate : item.pure_fluctuate;
                item.pure_fluctuate = format_double(item.pure_fluctuate);
                item.pure_insure = item.pure_insure <= double.Epsilon ? 0.975 * item.insure : item.pure_insure;
                item.pure_insure = format_double(item.pure_insure);
                item.choushui = item.choushui <= double.Epsilon ? (item.fluctuate > 1 ? item.fluctuate * 0.05 : 0) : item.choushui;
                item.choushui = format_double(item.choushui);
                item.jingchoushui = item.jingchoushui <= double.Epsilon ? Math.Abs((double)item.fluctuate * 0.025) : item.jingchoushui;
                item.jingchoushui = format_double(item.jingchoushui);
                item.transfer = item.take_in + item.fluctuate - item.other;
                member t_member = DBUtil.GetInstance().GetEntityByWhere<member>("game_id='" + item.member_name + "'");
                item.member_init_balance = item.member_init_balance < double.Epsilon ? t_member.first_balance : item.member_init_balance;
                m_desk_income += item.jingchoushui + item.pure_insure - item.other;
                m_desk_union += item.pure_fluctuate + item.pure_insure;
            }
            m_desk.income = m_desk.income < double.Epsilon ? m_desk_income : m_desk.income;
            m_desk.league = m_desk.league < double.Epsilon ? m_desk_union : m_desk.league;
            m_desk.income = format_double(m_desk.income);
            m_desk.league = format_double(m_desk.league);
            dgv_settle.AutoGenerateColumns = false;
            dgv_settle.Columns["Id"].DataPropertyName = "id";
            dgv_settle.Columns["Member"].DataPropertyName = "member_name";
            dgv_settle.Columns["Fluctuate"].DataPropertyName = "fluctuate";
            dgv_settle.Columns["PureFluctuate"].DataPropertyName = "pure_fluctuate";
            dgv_settle.Columns["Insure"].DataPropertyName = "insure";
            dgv_settle.Columns["PureInsure"].DataPropertyName = "pure_insure";
            dgv_settle.Columns["ChouShui"].DataPropertyName = "choushui";
            dgv_settle.Columns["JingChouShui"].DataPropertyName = "jingchoushui";
            dgv_settle.Columns["Other"].DataPropertyName = "other";
            dgv_settle.Columns["Balance"].DataPropertyName = "member_init_balance";
            dgv_settle.Columns["Transfer"].DataPropertyName = "transfer";
            dgv_settle.Columns["TakeIn"].DataPropertyName = "take_in";
            dgv_settle.DataSource = m_bill_list;
            
        }

        private void btn_finish_Click(object sender, EventArgs e)
        {
            //todo:更新桌子状态为结束，并计算营收
            bool is_ok = true;
            m_desk.status = (int)desk.EStatus.EEnd;
            if(!DBUtil.GetInstance().Update<desk>(m_desk))
            {
                is_ok = false;
                MessageBox.Show("桌子数据保存失败");
            }
            foreach(var item in m_bill_list)
            {
                if(!DBUtil.GetInstance().Update<bill_record>(item))
                {
                    is_ok = false;
                    MessageBox.Show("玩家：" + item.member_name + " 数据保存失败");
                }
            }
            if(is_ok)
            {
                MessageBox.Show("出账成功");
            }
        }

        private void dgv_settle_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            string target_value = "";
            if ((this.dgv_settle.Columns["Income"].Index ==
                e.ColumnIndex || this.dgv_settle.Columns["Union"].Index == e.ColumnIndex) && e.RowIndex >= 0)
            {
                if (this.dgv_settle.Columns["Income"].Index == e.ColumnIndex)
                {
                    target_value = m_desk.income.ToString();
                }
                else
                {
                    target_value = m_desk.league.ToString();
                }
                Rectangle newRect = new Rectangle(e.CellBounds.X + 1,
                    e.CellBounds.Y + 1, e.CellBounds.Width - 4,
                    e.CellBounds.Height - 4);

                using (
                    Brush gridBrush = new SolidBrush(this.dgv_settle.GridColor),
                    backColorBrush = new SolidBrush(e.CellStyle.BackColor))
                {
                    using (Pen gridLinePen = new Pen(gridBrush))
                    {
                        // Erase the cell.
                        e.Graphics.FillRectangle(backColorBrush, e.CellBounds);

                        // Draw the grid lines (only the right and bottom lines;
                        // DataGridView takes care of the others).
                        e.Graphics.DrawLine(gridLinePen, e.CellBounds.Right - 1, e.CellBounds.Top ,
                            e.CellBounds.Right - 1, e.CellBounds.Bottom);
                        if(e.RowIndex == dgv_settle.RowCount - 1)
                        {   
                            e.Graphics.DrawLine(gridLinePen, e.CellBounds.Left + 1,
                                e.CellBounds.Bottom - 1, e.CellBounds.Right - 1,
                                e.CellBounds.Bottom - 1);
                        }
                        // Draw the text content of the cell, ignoring alignment.
                        if(e.RowIndex == 0)
                        {
                            e.Graphics.DrawString(target_value, e.CellStyle.Font,
                                Brushes.Crimson, e.CellBounds.X + 2,
                                e.CellBounds.Y + 2, StringFormat.GenericDefault);
                        }
                        e.Handled = true;
                    }
                }
            }

        }
    }
}
