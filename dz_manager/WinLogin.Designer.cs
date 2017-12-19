namespace dz_manager
{
    partial class WinLogin
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
            this.components = new System.ComponentModel.Container();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.btn_db_set = new System.Windows.Forms.Button();
            this.lbl_status = new System.Windows.Forms.Label();
            this.tm_check = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Location = new System.Drawing.Point(113, 52);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(53, 12);
            this.lbl_username.TabIndex = 0;
            this.lbl_username.Text = "用户名：";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Location = new System.Drawing.Point(115, 104);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(41, 12);
            this.lbl_password.TabIndex = 1;
            this.lbl_password.Text = "密码：";
            // 
            // txt_username
            // 
            this.txt_username.Location = new System.Drawing.Point(199, 52);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(164, 21);
            this.txt_username.TabIndex = 2;
            // 
            // txt_password
            // 
            this.txt_password.Location = new System.Drawing.Point(199, 104);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(164, 21);
            this.txt_password.TabIndex = 3;
            // 
            // btn_login
            // 
            this.btn_login.Location = new System.Drawing.Point(132, 185);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(75, 23);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "登录";
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // btn_db_set
            // 
            this.btn_db_set.Location = new System.Drawing.Point(297, 185);
            this.btn_db_set.Name = "btn_db_set";
            this.btn_db_set.Size = new System.Drawing.Size(75, 23);
            this.btn_db_set.TabIndex = 5;
            this.btn_db_set.Text = "设置数据库";
            this.btn_db_set.UseVisualStyleBackColor = true;
            this.btn_db_set.Click += new System.EventHandler(this.btn_db_set_Click);
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(117, 148);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(0, 12);
            this.lbl_status.TabIndex = 6;
            // 
            // tm_check
            // 
            this.tm_check.Tick += new System.EventHandler(this.tm_check_Tick);
            // 
            // WinLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 262);
            this.Controls.Add(this.lbl_status);
            this.Controls.Add(this.btn_db_set);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.lbl_password);
            this.Controls.Add(this.lbl_username);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WinLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "德扑圈上分系统";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox txt_username;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Button btn_db_set;
        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.Timer tm_check;
    }
}