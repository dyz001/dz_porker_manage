namespace dz_manager
{
    partial class DBConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_test = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.txt_host = new System.Windows.Forms.TextBox();
            this.txt_db = new System.Windows.Forms.TextBox();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_pwd = new System.Windows.Forms.TextBox();
            this.lbl_host = new System.Windows.Forms.Label();
            this.lbl_db_name = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_pwd = new System.Windows.Forms.Label();
            this.lbl_port = new System.Windows.Forms.Label();
            this.txt_port = new System.Windows.Forms.TextBox();
            this.lbl_con_result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_test
            // 
            this.btn_test.Font = new System.Drawing.Font("宋体", 15F);
            this.btn_test.Location = new System.Drawing.Point(92, 188);
            this.btn_test.Name = "btn_test";
            this.btn_test.Size = new System.Drawing.Size(100, 40);
            this.btn_test.TabIndex = 0;
            this.btn_test.Text = "测试连接";
            this.btn_test.UseVisualStyleBackColor = true;
            this.btn_test.Click += new System.EventHandler(this.btn_test_Click);
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("宋体", 15F);
            this.btn_save.Location = new System.Drawing.Point(305, 188);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(100, 40);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "保存";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_close
            // 
            this.btn_close.Font = new System.Drawing.Font("宋体", 15F);
            this.btn_close.Location = new System.Drawing.Point(490, 188);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(100, 40);
            this.btn_close.TabIndex = 2;
            this.btn_close.Text = "关闭";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // txt_host
            // 
            this.txt_host.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_host.Font = new System.Drawing.Font("宋体", 15F);
            this.txt_host.Location = new System.Drawing.Point(143, 43);
            this.txt_host.Name = "txt_host";
            this.txt_host.Size = new System.Drawing.Size(236, 30);
            this.txt_host.TabIndex = 3;
            // 
            // txt_db
            // 
            this.txt_db.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_db.Font = new System.Drawing.Font("宋体", 15F);
            this.txt_db.Location = new System.Drawing.Point(143, 91);
            this.txt_db.Name = "txt_db";
            this.txt_db.Size = new System.Drawing.Size(236, 30);
            this.txt_db.TabIndex = 4;
            // 
            // txt_username
            // 
            this.txt_username.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_username.Font = new System.Drawing.Font("宋体", 15F);
            this.txt_username.Location = new System.Drawing.Point(143, 136);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(100, 30);
            this.txt_username.TabIndex = 5;
            // 
            // txt_pwd
            // 
            this.txt_pwd.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_pwd.Font = new System.Drawing.Font("宋体", 15F);
            this.txt_pwd.Location = new System.Drawing.Point(378, 135);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.Size = new System.Drawing.Size(100, 30);
            this.txt_pwd.TabIndex = 6;
            this.txt_pwd.UseSystemPasswordChar = true;
            // 
            // lbl_host
            // 
            this.lbl_host.AutoSize = true;
            this.lbl_host.Font = new System.Drawing.Font("宋体", 15F);
            this.lbl_host.Location = new System.Drawing.Point(18, 44);
            this.lbl_host.Name = "lbl_host";
            this.lbl_host.Size = new System.Drawing.Size(119, 20);
            this.lbl_host.TabIndex = 7;
            this.lbl_host.Text = "数据库地址:";
            // 
            // lbl_db_name
            // 
            this.lbl_db_name.AutoSize = true;
            this.lbl_db_name.Font = new System.Drawing.Font("宋体", 15F);
            this.lbl_db_name.Location = new System.Drawing.Point(25, 95);
            this.lbl_db_name.Name = "lbl_db_name";
            this.lbl_db_name.Size = new System.Drawing.Size(79, 20);
            this.lbl_db_name.TabIndex = 8;
            this.lbl_db_name.Text = "数据库:";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("宋体", 15F);
            this.lbl_username.Location = new System.Drawing.Point(26, 141);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(79, 20);
            this.lbl_username.TabIndex = 9;
            this.lbl_username.Text = "用户名:";
            // 
            // lbl_pwd
            // 
            this.lbl_pwd.AutoSize = true;
            this.lbl_pwd.Font = new System.Drawing.Font("宋体", 15F);
            this.lbl_pwd.Location = new System.Drawing.Point(314, 139);
            this.lbl_pwd.Name = "lbl_pwd";
            this.lbl_pwd.Size = new System.Drawing.Size(59, 20);
            this.lbl_pwd.TabIndex = 10;
            this.lbl_pwd.Text = "密码:";
            // 
            // lbl_port
            // 
            this.lbl_port.AutoSize = true;
            this.lbl_port.Font = new System.Drawing.Font("宋体", 15F);
            this.lbl_port.Location = new System.Drawing.Point(384, 52);
            this.lbl_port.Name = "lbl_port";
            this.lbl_port.Size = new System.Drawing.Size(69, 20);
            this.lbl_port.TabIndex = 11;
            this.lbl_port.Text = "端口：";
            // 
            // txt_port
            // 
            this.txt_port.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_port.Font = new System.Drawing.Font("宋体", 15F);
            this.txt_port.Location = new System.Drawing.Point(440, 45);
            this.txt_port.Name = "txt_port";
            this.txt_port.Size = new System.Drawing.Size(100, 30);
            this.txt_port.TabIndex = 12;
            // 
            // lbl_con_result
            // 
            this.lbl_con_result.AutoSize = true;
            this.lbl_con_result.Location = new System.Drawing.Point(138, 238);
            this.lbl_con_result.Name = "lbl_con_result";
            this.lbl_con_result.Size = new System.Drawing.Size(0, 12);
            this.lbl_con_result.TabIndex = 13;
            // 
            // DBConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 262);
            this.Controls.Add(this.lbl_con_result);
            this.Controls.Add(this.txt_port);
            this.Controls.Add(this.lbl_port);
            this.Controls.Add(this.lbl_pwd);
            this.Controls.Add(this.lbl_username);
            this.Controls.Add(this.lbl_db_name);
            this.Controls.Add(this.lbl_host);
            this.Controls.Add(this.txt_pwd);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.txt_db);
            this.Controls.Add(this.txt_host);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_test);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DBConfig";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DBConfig";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_test;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.TextBox txt_host;
        private System.Windows.Forms.TextBox txt_db;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_pwd;
        private System.Windows.Forms.Label lbl_host;
        private System.Windows.Forms.Label lbl_db_name;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_pwd;
        private System.Windows.Forms.Label lbl_port;
        private System.Windows.Forms.TextBox txt_port;
        private System.Windows.Forms.Label lbl_con_result;
    }
}