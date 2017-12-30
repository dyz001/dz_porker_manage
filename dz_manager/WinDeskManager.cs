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
    public partial class WinDeskManager : SuperForm
    {
        const int MAX_COLUMN = 8;
        const int CELL_WIDTH = 120;
        const int CELL_HEIGHT = 120;
        const int MAX_DESK_NUM = 200;
        protected DlgAddDesk m_wAddDesk;
        protected Panel pnl_template;
        protected Cell cell_template;
        protected Dictionary<string, Cell> m_dicCell;
        protected IList<desk> m_curDeskData;

        protected class Cell : ICloneable
        {
            protected Panel m_pMain;
            protected Label m_lDeskNo;
            protected Label m_lState;

            public Cell(Panel pnl, Label lbl_desk_no, Label lbl_state)
            {
                m_pMain = pnl;
                m_lDeskNo = lbl_desk_no;
                m_lState = lbl_state;
            }

            public void SetData(string desk_no, string state)
            {
                m_lDeskNo.Text = desk_no;
                m_lState.Text = state;
            }

            public void SetBackGroundColor(Color color)
            {
                m_pMain.BackColor = color;
            }

            public void SetVisible(bool param)
            {
                m_pMain.Visible = param;
            }

            public Panel GetMainPnl()
            {
                return m_pMain;
            }

            public void SetState(string state)
            {
                m_lState.Text = state;
            }

            public object Clone()
            {
                Panel pnl_target = new Panel();
                pnl_target.Size = m_pMain.Size;
                pnl_target.Dock = m_pMain.Dock;
                pnl_target.Margin = m_pMain.Margin;
                //pnl_target.
                Label lbl_desk_target = new Label();
                lbl_desk_target.Font = m_lDeskNo.Font;
                lbl_desk_target.Left = m_lDeskNo.Left;
                lbl_desk_target.Top = m_lDeskNo.Top;
                lbl_desk_target.Size = m_lDeskNo.Size;
                Label lbl_state = new Label();
                lbl_state.Font = m_lState.Font;
                lbl_state.Left = m_lState.Left;
                lbl_state.Top = m_lState.Top;
                lbl_state.Size = m_lState.Size;
                pnl_target.Controls.Add(lbl_desk_target);
                pnl_target.Controls.Add(lbl_state);
                return new Cell(pnl_target, lbl_desk_target, lbl_state);
            }
        }

        public WinDeskManager()
        {
            InitializeComponent();
            m_dicCell = new Dictionary<string, Cell>();
            cell_template = new Cell(pnl_desk_info, lbl_desk_no, lbl_desk_state);
            pnl_desk_info.Parent.Controls.Remove(pnl_desk_info);
            m_wAddDesk = new DlgAddDesk();
            InitDeskData();
        }

        protected void InitDeskData()
        {
            m_curDeskData = DBUtil.GetInstance().GetLstItems<desk>("create_date >= '" + dtp_date.Value.ToShortDateString()
                + "' and create_date < '" + dtp_date.Value.AddDays(1).ToShortDateString() + "'", MAX_DESK_NUM);
            //init desk
            foreach (desk d in m_curDeskData)
            {
                AddDesk(d.name, d.status == 0 ? Constant.WIN_DESK_CREATE :
                    (d.status == 1 ? Constant.WIN_DESK_BEGIN : Constant.WIN_DESK_OVER));
            }
        }

        private void pnl_add_desk_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnl_desk_info_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void btn_add_desk_Click(object sender, EventArgs e)
        {   
            m_wAddDesk.ShowWithWinParent(this);
        }

        public void RefreshDesk()
        {
            foreach(Cell cell in m_dicCell.Values)
            {
                this.tlp_main.Controls.Remove(cell.GetMainPnl());
            }
            m_dicCell.Clear();
            m_curDeskData = DBUtil.GetInstance().GetLstItems<desk>("create_date >= '" + dtp_date.Value.ToShortDateString()
                + "' and create_date < '" + dtp_date.Value.AddDays(1).ToShortDateString() + "'", MAX_DESK_NUM);

            //init desk
            foreach(desk d in m_curDeskData)
            {
                AddDesk(d.name, d.status == 0 ? Constant.WIN_DESK_CREATE :
                    (d.status == 1 ? Constant.WIN_DESK_BEGIN : Constant.WIN_DESK_OVER));
            }
        }

        public void AddCell(string desk_no, string state, DateTime date_time)
        {
            if(!SaveDesk(desk_no, date_time))
            {
                MessageBox.Show("数据保存出错");
                return;
            }
            AddDesk(desk_no, state);
        }

        protected void AddDesk(string desk_no, string state)
        {
            if (m_dicCell.ContainsKey(desk_no))
            {
                MessageBox.Show(Constant.WIN_DESK_ALREADY_EXIST + desk_no);
                return;
            }
            Cell desk_cell = (Cell)cell_template.Clone();
            m_dicCell.Add(desk_no, desk_cell);
            desk_cell.SetData(desk_no, state);
            desk_cell.SetBackGroundColor(Color.Gray);
            this.tlp_main.Controls.Add(desk_cell.GetMainPnl());
            desk_cell.GetMainPnl().BackColor = (state == Constant.WIN_DESK_OVER ? Color.Red : Color.Green);
            //this.tlp_main.Controls.Add(new Button());
            this.tlp_main.Controls.SetChildIndex(desk_cell.GetMainPnl(), 1);
            //desk_cell.SetVisible(true);
        }
        
        protected bool SaveDesk(string desk_no, DateTime date_time)
        {
            desk target = new desk();
            target.create_date = date_time;
            target.status = 0;
            target.name = desk_no;
            target.optor = DataManager.GetAuthUser().username;
            return DBUtil.GetInstance().SaveObj<desk>(target);
        }

        private void btn_refresh_Click(object sender, EventArgs e)
        {
            RefreshDesk();
        }

        private void dtp_date_ValueChanged(object sender, EventArgs e)
        {
            RefreshDesk();
        }
    }
}
