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
    public partial class DlgAddDesk : Form
    {
        protected Form WinParent;
        public DlgAddDesk()
        {
            InitializeComponent();
        }
        protected void init_data()
        {
            txt_desk_name.Text = "";
            dtp_desk.Value = DateTime.Now;
        }

        public void ShowWithWinParent(Form param)
        {
            WinParent = param;
            init_data();
            Show();
        }

        protected bool CheckExist(string desk_no)
        {
            if(DBUtil.GetInstance().CheckExistByWhere<desk>("name='" + desk_no + "'"))
            {
                return true;
            }
            return false;
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txt_desk_name.Text))
            {
                txt_desk_name.Focus();
                return;
            }
            else
            {
                if (CheckExist(txt_desk_name.Text))
                {
                    txt_desk_name.Focus();
                    txt_desk_name.SelectAll();
                    return;
                }
                ((WinDeskManager)this.WinParent).AddCell(txt_desk_name.Text, "未开始", dtp_desk.Value);
                this.Hide();
            }
        }
        
    }
}
