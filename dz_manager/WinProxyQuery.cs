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
    public partial class WinProxyQuery : SuperForm
    {
        protected IList<proxy> proxy_lst;
        protected IList<fanshui> fanshui_list;
        public WinProxyQuery()
        {
            InitializeComponent();
        }

        protected override void PreShowWin()
        {
            base.PreShowWin();
            dgv_proxy.DataSource = null;
            txt_proxy_gameid.Text = "";
            dgv_proxy.AutoGenerateColumns = false;
            dgv_proxy.Columns[0].DataPropertyName = "id";
            dgv_proxy.Columns[1].DataPropertyName = "name";
            dgv_proxy.Columns[2].DataPropertyName = "no";
            dgv_proxy.Columns[3].DataPropertyName = "fs_type";
        }

        private void btn_query_Click(object sender, EventArgs e)
        {
            proxy_lst = DBUtil.GetInstance().GetLstItems<proxy>("name = '" + txt_proxy_gameid.Text
                + "' or no = '" + txt_proxy_gameid.Text + "'");
            if(proxy_lst == null || proxy_lst.Count == 0)
            {
                MessageBox.Show("记录未找到，请核实名称或编号");
                txt_proxy_gameid.Focus();
                return;
            }

            fanshui_list = DataManager.GetFanShuiList();
            DataGridViewComboBoxColumn combo_column = dgv_proxy.Columns[3] as DataGridViewComboBoxColumn;
            combo_column.DataSource = fanshui_list;
            combo_column.DisplayMember = "fs_type";
            combo_column.ValueMember = "fs_type";
            dgv_proxy.DataSource = proxy_lst;
        }

        private void dgv_proxy_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            foreach(proxy entity in proxy_lst)
            {
                if(!DBUtil.GetInstance().Update<proxy>(entity))
                {
                    MessageBox.Show("代理:" + entity.name + ", 数据更新失败");
                    continue;
                }
            }
            MessageBox.Show("保存成功");
        }
    }
}
