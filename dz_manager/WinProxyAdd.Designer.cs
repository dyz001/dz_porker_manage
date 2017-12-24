namespace dz_manager
{
    partial class WinProxyAdd
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_proxy_name = new System.Windows.Forms.TextBox();
            this.txt_proxy_no = new System.Windows.Forms.TextBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.cmb_fanshui = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F);
            this.label1.Location = new System.Drawing.Point(108, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "代理名称：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 15F);
            this.label3.Location = new System.Drawing.Point(46, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "请输入反水方式：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 15F);
            this.label4.Location = new System.Drawing.Point(108, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "代理编号：";
            // 
            // txt_proxy_name
            // 
            this.txt_proxy_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_proxy_name.Font = new System.Drawing.Font("宋体", 15F);
            this.txt_proxy_name.Location = new System.Drawing.Point(238, 70);
            this.txt_proxy_name.Name = "txt_proxy_name";
            this.txt_proxy_name.Size = new System.Drawing.Size(100, 30);
            this.txt_proxy_name.TabIndex = 4;
            // 
            // txt_proxy_no
            // 
            this.txt_proxy_no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_proxy_no.Font = new System.Drawing.Font("宋体", 15F);
            this.txt_proxy_no.Location = new System.Drawing.Point(238, 114);
            this.txt_proxy_no.Name = "txt_proxy_no";
            this.txt_proxy_no.Size = new System.Drawing.Size(100, 30);
            this.txt_proxy_no.TabIndex = 6;
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("宋体", 15F);
            this.btn_save.Location = new System.Drawing.Point(155, 232);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(100, 40);
            this.btn_save.TabIndex = 7;
            this.btn_save.Text = "保存";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // cmb_fanshui
            // 
            this.cmb_fanshui.Font = new System.Drawing.Font("宋体", 15F);
            this.cmb_fanshui.FormattingEnabled = true;
            this.cmb_fanshui.Location = new System.Drawing.Point(236, 158);
            this.cmb_fanshui.Name = "cmb_fanshui";
            this.cmb_fanshui.Size = new System.Drawing.Size(137, 28);
            this.cmb_fanshui.TabIndex = 8;
            // 
            // WinProxyAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 495);
            this.Controls.Add(this.cmb_fanshui);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.txt_proxy_no);
            this.Controls.Add(this.txt_proxy_name);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WinProxyAdd";
            this.Text = "代理添加";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_proxy_name;
        private System.Windows.Forms.TextBox txt_proxy_no;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.ComboBox cmb_fanshui;
    }
}