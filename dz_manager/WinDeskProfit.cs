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
    public partial class WinDeskProfit : SuperForm
    {
        protected desk m_desk;
        protected IList<bill_record> m_bill_list;
        public WinDeskProfit()
        {
            InitializeComponent();
        }

        protected override void PreShowWin()
        {
            base.PreShowWin();
            txt_desk_no.Text = "";
            dtp_date.Value = DateTime.Now;
            dgv_settle.DataSource = null;
            

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

        private void btn_search_Click(object sender, EventArgs e)
        {
            m_bill_list = DBUtil.GetInstance().GetLstItems<bill_record>("desk_name='" + txt_desk_no.Text + "'");
            m_desk = DBUtil.GetInstance().GetEntityByWhere<desk>("name = '" + txt_desk_no.Text + "'");
            dgv_settle.DataSource = m_bill_list;
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
                        e.Graphics.DrawLine(gridLinePen, e.CellBounds.Right - 1, e.CellBounds.Top,
                            e.CellBounds.Right - 1, e.CellBounds.Bottom);
                        if (e.RowIndex == dgv_settle.RowCount - 1)
                        {
                            e.Graphics.DrawLine(gridLinePen, e.CellBounds.Left + 1,
                                e.CellBounds.Bottom - 1, e.CellBounds.Right - 1,
                                e.CellBounds.Bottom - 1);
                        }
                        // Draw the text content of the cell, ignoring alignment.
                        if (e.RowIndex == 0)
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
