using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
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

        public static string Encrypt(string str)
        {
            //创建一个内存流
            SymmetricAlgorithm mCSP = new DESCryptoServiceProvider();
            ICryptoTransform ct; //定义基本的加密转换运算
            MemoryStream ms; //定义内存流
            CryptoStream cs; //定义将内存流链接到加密转换的流
            byte[] byt;
            //CreateEncryptor创建(对称数据)加密对象
            ct = mCSP.CreateEncryptor(Convert.FromBase64String(Constant.ENCRYPT_KEY), Convert.FromBase64String(Constant.ENCRYPT_IV)); //用指定的密钥和初始化向量创建对称数据加密标准
            byt = Encoding.UTF8.GetBytes(str); //将Value字符转换为UTF-8编码的字节序列
            ms = new MemoryStream(); //创建内存流
            cs = new CryptoStream(ms, ct, CryptoStreamMode.Write); //将内存流链接到加密转换的流
            cs.Write(byt, 0, byt.Length); //写入内存流
            cs.FlushFinalBlock(); //将缓冲区中的数据写入内存流，并清除缓冲区
            cs.Close(); //释放内存流
            return Convert.ToBase64String(ms.ToArray()); //将内存流转写入字节数组并转换为string字符
        }

        

        public static string Decrypt(string src)
        {
            try
            {
                SymmetricAlgorithm mCSP = new DESCryptoServiceProvider();
                ICryptoTransform ct; //定义基本的加密转换运算
                MemoryStream ms; //定义内存流
                CryptoStream cs; //定义将数据流链接到加密转换的流
                byte[] byt;
                ct = mCSP.CreateDecryptor(Convert.FromBase64String(Constant.ENCRYPT_KEY), Convert.FromBase64String(Constant.ENCRYPT_IV)); //用指定的密钥和初始化向量创建对称数据解密标准
                byt = Convert.FromBase64String(src); //将Value(Base 64)字符转换成字节数组
                ms = new MemoryStream();
                cs = new CryptoStream(ms, ct, CryptoStreamMode.Write);
                cs.Write(byt, 0, byt.Length);
                cs.FlushFinalBlock();
                cs.Close();
                return Encoding.UTF8.GetString(ms.ToArray()); //将字节数组中的所有字符解码为一个字符串
            }
            catch(Exception ex)
            {
                MessageBox.Show("数据库连接失败, 请重新设置连接信息：" + ex.Message );
                return "";
            }
        }
    }
}
