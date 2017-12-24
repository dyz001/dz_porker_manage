using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dz_manager
{
    public class Tools
    {
        public static Control CopyControl(Control src)
        {
            Control target = (Control)Activator.CreateInstance(src.GetType());
            target.Size = src.Size;
            target.Text = src.Text;
            target.Left = src.Left;
            target.Top = src.Top;
            target.Font = src.Font;
            target.Text = src.Text;
            if(target is TextBox)
            {
                (target as TextBox).BorderStyle = (src as TextBox).BorderStyle;
            }
            return target;
        }
    }
}
