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
            dgv_proxy.UserDeletingRow += this.OnDeleteRow;
            dgv_proxy.UserDeletedRow += this.OnDeletedRow;
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

        public void OnDeleteRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            if (MessageBox.Show("是否删除选中代理", "提示", MessageBoxButtons.YesNo) != System.Windows.Forms.DialogResult.Yes)
            {
                e.Cancel = true;
                return;
            }
        }

        public void OnDeletedRow(object sender, DataGridViewRowEventArgs e)
        {   
            if(DBUtil.GetInstance().Delete<proxy>("no = '" + e.Row.Cells["no"].Value + "'") <= 0)
            {
                MessageBox.Show("删除失败");
                return;
            }
            DBUtil.GetInstance().UpdateItems<member>("proxy_id = ''", "proxy_id = '" + e.Row.Cells["no"].Value + "'");
        }

        private void btn_del_Click(object sender, EventArgs e)
        {
            if (dgv_proxy.SelectedRows.Count == 0)
            {
                MessageBox.Show("当前没有选择记录");
                return;
            }
            else
            {
                if(MessageBox.Show("是否删除选中代理", "提示", MessageBoxButtons.YesNo) != System.Windows.Forms.DialogResult.Yes)
                {
                    return;
                }

                //更新此代理下的所有会员的代理为本人
                StringBuilder sb = new StringBuilder();
                sb.Append("(");
                DataGridViewSelectedRowCollection row_collection = dgv_proxy.SelectedRows;
                foreach(DataGridViewRow item in dgv_proxy.SelectedRows)
                {
                    sb.Append("\'" + item.Cells["no"].Value + "\',");
                }
                sb = sb.Remove(sb.Length - 1, 1).Append(")");
                DBUtil.GetInstance().UpdateItems<member>("proxy_id = ''", "proxy_id in " + sb.ToString());
                if(DBUtil.GetInstance().Delete<proxy>("no in " + sb.ToString()) > 0)
                {
                    MessageBox.Show("删除成功");
                    proxy_lst = DBUtil.GetInstance().GetLstItems<proxy>("name = '" + txt_proxy_gameid.Text
                + "' or no = '" + txt_proxy_gameid.Text + "'");
                    dgv_proxy.DataSource = proxy_lst;
                }
                else
                {
                    MessageBox.Show("操作失败");
                }
            }
        }
    }
}
