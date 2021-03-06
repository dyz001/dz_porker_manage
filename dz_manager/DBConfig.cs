﻿using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using DataInput.DBOper;

namespace dz_manager
{
    public partial class DBConfig : Form
    {
        const string db_file = "db_conf.json";
        protected FileStream db_fs;
        public class DBAuthData
        {
            public string DBHost { get; set; }
            public string DBName { get; set; }
            public string DBUser { get; set; }
            public string DBPass { get; set; }
            public string DBPort { get; set; }
        }
        protected DBAuthData db_auth_data;
        protected static DBConfig m_instance;

        public static DBConfig GetInstance()
        {
            if(m_instance == null)
            {
                m_instance = new DBConfig();
            }
            return m_instance;
        }

        public DBAuthData GetDBAuthData()
        {
            return db_auth_data;
        }

        protected DBConfig()
        {
            m_instance = this;
            InitializeComponent();
            if(!File.Exists(db_file))
            {
                File.Create(db_file).Close();
                db_auth_data = new DBAuthData();
            }
            else
            {
                db_auth_data = DeserializeObject<DBAuthData>(File.ReadAllText(db_file));
                if(db_auth_data == null)
                {
                    db_auth_data = new DBAuthData();
                }
            }
            InitForm();
        }

        protected void InitForm()
        {
            if (db_auth_data == null) return;
            txt_db.Text = db_auth_data.DBName;
            txt_host.Text = db_auth_data.DBHost;
            txt_pwd.Text = string.IsNullOrEmpty(db_auth_data.DBPass) ? "" : Tools.Decrypt(db_auth_data.DBPass);
            txt_username.Text = db_auth_data.DBUser;
            txt_port.Text = db_auth_data.DBPort;
        }

        public string SerializeObject(object obj)
        {
            return JsonConvert.SerializeObject(obj, Formatting.Indented);
        }

        public static T DeserializeObject<T>(string param)
        {
            return JsonConvert.DeserializeObject<T>(param);
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btn_test_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txt_host.Text) || string.IsNullOrEmpty(txt_db.Text)
                || string.IsNullOrEmpty(txt_username.Text) || string.IsNullOrEmpty(txt_pwd.Text))
            {
                MessageBox.Show("信息填写不完整");
            }
            db_auth_data.DBPort = txt_port.Text;
            db_auth_data.DBHost = txt_host.Text;
            db_auth_data.DBName = txt_db.Text;
            db_auth_data.DBPass = Tools.Encrypt(txt_pwd.Text);
            db_auth_data.DBUser = txt_username.Text;
            if(DBUtil.TryOpenDB(db_auth_data))
            {
                lbl_con_result.Text = "连接成功";
            }
            else
            {
                lbl_con_result.Text = "连接失败";
            }

        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            db_auth_data.DBPort = txt_port.Text;
            db_auth_data.DBHost = txt_host.Text;
            db_auth_data.DBName = txt_db.Text;
            db_auth_data.DBPass = Tools.Encrypt(txt_pwd.Text);
            db_auth_data.DBUser = txt_username.Text;
            File.WriteAllText(db_file, SerializeObject(db_auth_data));
        }
    }
}
