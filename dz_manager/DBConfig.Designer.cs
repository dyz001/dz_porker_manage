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
            this.SuspendLayout();
            // 
            // btn_test
            // 
            this.btn_test.Location = new System.Drawing.Point(138, 186);
            this.btn_test.Name = "btn_test";
            this.btn_test.Size = new System.Drawing.Size(75, 23);
            this.btn_test.TabIndex = 0;
            this.btn_test.Text = "测试连接";
            this.btn_test.UseVisualStyleBackColor = true;
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(351, 186);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(75, 23);
            this.btn_save.TabIndex = 1;
            this.btn_save.Text = "保存";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(536, 186);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 2;
            this.btn_close.Text = "关闭";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // txt_host
            // 
            this.txt_host.Location = new System.Drawing.Point(138, 44);
            this.txt_host.Name = "txt_host";
            this.txt_host.Size = new System.Drawing.Size(236, 21);
            this.txt_host.TabIndex = 3;
            // 
            // txt_db
            // 
            this.txt_db.Location = new System.Drawing.Point(138, 92);
            this.txt_db.Name = "txt_db";
            this.txt_db.Size = new System.Drawing.Size(236, 21);
            this.txt_db.TabIndex = 4;
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(138, 137);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(100, 21);
            this.txt_username.TabIndex = 5;
            // 
            // txt_pwd
            // 
            this.txt_pwd.Location = new System.Drawing.Point(373, 136);
            this.txt_pwd.Name = "txt_pwd";
            this.txt_pwd.Size = new System.Drawing.Size(100, 21);
            this.txt_pwd.TabIndex = 6;
            // 
            // lbl_host
            // 
            this.lbl_host.AutoSize = true;
            this.lbl_host.Location = new System.Drawing.Point(25, 44);
            this.lbl_host.Name = "lbl_host";
            this.lbl_host.Size = new System.Drawing.Size(65, 12);
            this.lbl_host.TabIndex = 7;
            this.lbl_host.Text = "数据库地址";
            // 
            // lbl_db_name
            // 
            this.lbl_db_name.AutoSize = true;
            this.lbl_db_name.Location = new System.Drawing.Point(25, 95);
            this.lbl_db_name.Name = "lbl_db_name";
            this.lbl_db_name.Size = new System.Drawing.Size(47, 12);
            this.lbl_db_name.TabIndex = 8;
            this.lbl_db_name.Text = "数据库:";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(25, 146);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(47, 12);
            this.lbl_username.TabIndex = 9;
            this.lbl_username.Text = "用户名:";
            // 
            // lbl_pwd
            // 
            this.lbl_pwd.AutoSize = true;
            this.lbl_pwd.Location = new System.Drawing.Point(312, 145);
            this.lbl_pwd.Name = "lbl_pwd";
            this.lbl_pwd.Size = new System.Drawing.Size(35, 12);
            this.lbl_pwd.TabIndex = 10;
            this.lbl_pwd.Text = "密码:";
            // 
            // DBConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 262);
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
    }
}