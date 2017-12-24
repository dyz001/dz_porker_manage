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

        public static string GetSqlDateCond(string date_field, DateTime from, DateTime to)
        {
            return date_field + ">='" + from.ToShortDateString() + "' and " + date_field + "<'" + to.ToShortDateString() + "'";
        }

        public static double FormatDouble(double d_value)
        {
            return (double)((Int64)(d_value * 1000)) / 1000;
        }
    }
}
