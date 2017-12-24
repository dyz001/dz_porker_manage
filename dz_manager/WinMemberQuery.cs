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
    public partial class WinMemberQuery : SuperForm
    {
        protected IList<member> mem_list;
        public WinMemberQuery()
        {
            InitializeComponent();
        }

        protected override void PreShowWin()
        {
            base.PreShowWin();
            txt_game_id.Text = "";
            dgv_userdata.DataSource = null;
            //dgv_userdata.Columns[4].DataPropertyName
            dgv_userdata.AutoGenerateColumns = false;
            dgv_userdata.Columns[0].DataPropertyName = "id";
            dgv_userdata.Columns[1].DataPropertyName = "game_id";
            dgv_userdata.Columns[2].DataPropertyName = "wx_id";
            dgv_userdata.Columns[3].DataPropertyName = "ali_id";
            dgv_userdata.Columns[4].DataPropertyName = "proxy_id";
            dgv_userdata.Columns[5].DataPropertyName = "cs_type";
            dgv_userdata.Columns[6].DataPropertyName = "balance";

            DataGridViewComboBoxColumn combo_column = dgv_userdata.Columns[5] as DataGridViewComboBoxColumn;
            combo_column.DataSource = DataManager.GetChouShuiList();
            combo_column.DisplayMember = "cs_type";
            combo_column.ValueMember = "cs_type";
        }

        private void btn_query_Click(object sender, EventArgs e)
        {
            mem_list = DBUtil.GetInstance().GetLstItems<member>("game_id = '" + txt_game_id.Text + "'");
            dgv_userdata.DataSource = mem_list;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            foreach(member entity in mem_list)
            {
                if(!DBUtil.GetInstance().Update<member>(entity))
                {
                    MessageBox.Show("会员：" + entity.game_id + ", 数据更新失败");
                }
            }
            MessageBox.Show("信息保存成功");
        }
    }
}
