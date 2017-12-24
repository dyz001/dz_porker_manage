namespace dz_manager
{
    partial class WinAddMember
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
            this.btn_add = new System.Windows.Forms.Button();
            this.flp_main = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl_row = new System.Windows.Forms.Panel();
            this.txt_game_id = new System.Windows.Forms.TextBox();
            this.lbl_gameid = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_wx_id = new System.Windows.Forms.TextBox();
            this.lbl_wx_id = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_ali_id = new System.Windows.Forms.TextBox();
            this.lbl_ali_id = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txt_proxy_no = new System.Windows.Forms.TextBox();
            this.lbl_proxy_no = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmb_choushui = new System.Windows.Forms.ComboBox();
            this.lbl_pump = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txt_limit = new System.Windows.Forms.TextBox();
            this.lbl_limit = new System.Windows.Forms.Label();
            this.flp_main.SuspendLayout();
            this.pnl_row.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("宋体", 15F);
            this.btn_add.Location = new System.Drawing.Point(244, 391);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(100, 40);
            this.btn_add.TabIndex = 1;
            this.btn_add.Text = "保存";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // flp_main
            // 
            this.flp_main.Controls.Add(this.pnl_row);
            this.flp_main.Controls.Add(this.panel1);
            this.flp_main.Controls.Add(this.panel2);
            this.flp_main.Controls.Add(this.panel3);
            this.flp_main.Controls.Add(this.panel4);
            this.flp_main.Controls.Add(this.panel5);
            this.flp_main.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flp_main.Location = new System.Drawing.Point(74, 23);
            this.flp_main.Name = "flp_main";
            this.flp_main.Size = new System.Drawing.Size(530, 301);
            this.flp_main.TabIndex = 0;
            // 
            // pnl_row
            // 
            this.pnl_row.Controls.Add(this.txt_game_id);
            this.pnl_row.Controls.Add(this.lbl_gameid);
            this.pnl_row.Location = new System.Drawing.Point(3, 3);
            this.pnl_row.Name = "pnl_row";
            this.pnl_row.Size = new System.Drawing.Size(527, 35);
            this.pnl_row.TabIndex = 0;
            // 
            // txt_game_id
            // 
            this.txt_game_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_game_id.Font = new System.Drawing.Font("宋体", 15F);
            this.txt_game_id.Location = new System.Drawing.Point(231, 4);
            this.txt_game_id.Name = "txt_game_id";
            this.txt_game_id.Size = new System.Drawing.Size(193, 30);
            this.txt_game_id.TabIndex = 1;
            // 
            // lbl_gameid
            // 
            this.lbl_gameid.AutoSize = true;
            this.lbl_gameid.Font = new System.Drawing.Font("宋体", 15F);
            this.lbl_gameid.Location = new System.Drawing.Point(57, 7);
            this.lbl_gameid.Name = "lbl_gameid";
            this.lbl_gameid.Size = new System.Drawing.Size(139, 20);
            this.lbl_gameid.TabIndex = 0;
            this.lbl_gameid.Text = "请输入游戏ID:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_wx_id);
            this.panel1.Controls.Add(this.lbl_wx_id);
            this.panel1.Location = new System.Drawing.Point(3, 44);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(527, 35);
            this.panel1.TabIndex = 2;
            // 
            // txt_wx_id
            // 
            this.txt_wx_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_wx_id.Font = new System.Drawing.Font("宋体", 15F);
            this.txt_wx_id.Location = new System.Drawing.Point(231, 4);
            this.txt_wx_id.Name = "txt_wx_id";
            this.txt_wx_id.Size = new System.Drawing.Size(193, 30);
            this.txt_wx_id.TabIndex = 1;
            // 
            // lbl_wx_id
            // 
            this.lbl_wx_id.AutoSize = true;
            this.lbl_wx_id.Font = new System.Drawing.Font("宋体", 15F);
            this.lbl_wx_id.Location = new System.Drawing.Point(57, 7);
            this.lbl_wx_id.Name = "lbl_wx_id";
            this.lbl_wx_id.Size = new System.Drawing.Size(139, 20);
            this.lbl_wx_id.TabIndex = 0;
            this.lbl_wx_id.Text = "请输入微信ID:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.txt_ali_id);
            this.panel2.Controls.Add(this.lbl_ali_id);
            this.panel2.Location = new System.Drawing.Point(3, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(527, 35);
            this.panel2.TabIndex = 3;
            // 
            // txt_ali_id
            // 
            this.txt_ali_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_ali_id.Font = new System.Drawing.Font("宋体", 15F);
            this.txt_ali_id.Location = new System.Drawing.Point(231, 4);
            this.txt_ali_id.Name = "txt_ali_id";
            this.txt_ali_id.Size = new System.Drawing.Size(193, 30);
            this.txt_ali_id.TabIndex = 1;
            // 
            // lbl_ali_id
            // 
            this.lbl_ali_id.AutoSize = true;
            this.lbl_ali_id.Font = new System.Drawing.Font("宋体", 15F);
            this.lbl_ali_id.Location = new System.Drawing.Point(57, 7);
            this.lbl_ali_id.Name = "lbl_ali_id";
            this.lbl_ali_id.Size = new System.Drawing.Size(159, 20);
            this.lbl_ali_id.TabIndex = 0;
            this.lbl_ali_id.Text = "请输入支付宝ID:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txt_proxy_no);
            this.panel3.Controls.Add(this.lbl_proxy_no);
            this.panel3.Location = new System.Drawing.Point(3, 126);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(527, 35);
            this.panel3.TabIndex = 4;
            // 
            // txt_proxy_no
            // 
            this.txt_proxy_no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_proxy_no.Font = new System.Drawing.Font("宋体", 15F);
            this.txt_proxy_no.Location = new System.Drawing.Point(231, 4);
            this.txt_proxy_no.Name = "txt_proxy_no";
            this.txt_proxy_no.Size = new System.Drawing.Size(193, 30);
            this.txt_proxy_no.TabIndex = 1;
            // 
            // lbl_proxy_no
            // 
            this.lbl_proxy_no.AutoSize = true;
            this.lbl_proxy_no.Font = new System.Drawing.Font("宋体", 15F);
            this.lbl_proxy_no.Location = new System.Drawing.Point(57, 7);
            this.lbl_proxy_no.Name = "lbl_proxy_no";
            this.lbl_proxy_no.Size = new System.Drawing.Size(169, 20);
            this.lbl_proxy_no.TabIndex = 0;
            this.lbl_proxy_no.Text = "请输入代理编号：";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cmb_choushui);
            this.panel4.Controls.Add(this.lbl_pump);
            this.panel4.Location = new System.Drawing.Point(3, 167);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(527, 35);
            this.panel4.TabIndex = 5;
            // 
            // cmb_choushui
            // 
            this.cmb_choushui.Font = new System.Drawing.Font("宋体", 15F);
            this.cmb_choushui.FormattingEnabled = true;
            this.cmb_choushui.Location = new System.Drawing.Point(233, 6);
            this.cmb_choushui.Name = "cmb_choushui";
            this.cmb_choushui.Size = new System.Drawing.Size(191, 28);
            this.cmb_choushui.TabIndex = 1;
            // 
            // lbl_pump
            // 
            this.lbl_pump.AutoSize = true;
            this.lbl_pump.Font = new System.Drawing.Font("宋体", 15F);
            this.lbl_pump.Location = new System.Drawing.Point(57, 7);
            this.lbl_pump.Name = "lbl_pump";
            this.lbl_pump.Size = new System.Drawing.Size(169, 20);
            this.lbl_pump.TabIndex = 0;
            this.lbl_pump.Text = "请输入抽水方式：";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txt_limit);
            this.panel5.Controls.Add(this.lbl_limit);
            this.panel5.Location = new System.Drawing.Point(3, 208);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(527, 35);
            this.panel5.TabIndex = 6;
            // 
            // txt_limit
            // 
            this.txt_limit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_limit.Font = new System.Drawing.Font("宋体", 15F);
            this.txt_limit.Location = new System.Drawing.Point(231, 4);
            this.txt_limit.Name = "txt_limit";
            this.txt_limit.Size = new System.Drawing.Size(193, 30);
            this.txt_limit.TabIndex = 1;
            // 
            // lbl_limit
            // 
            this.lbl_limit.AutoSize = true;
            this.lbl_limit.Font = new System.Drawing.Font("宋体", 15F);
            this.lbl_limit.Location = new System.Drawing.Point(57, 7);
            this.lbl_limit.Name = "lbl_limit";
            this.lbl_limit.Size = new System.Drawing.Size(129, 20);
            this.lbl_limit.TabIndex = 0;
            this.lbl_limit.Text = "请输入额度：";
            // 
            // WinAddMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 456);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.flp_main);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WinAddMember";
            this.Text = "添加会员";
            this.flp_main.ResumeLayout(false);
            this.pnl_row.ResumeLayout(false);
            this.pnl_row.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flp_main;
        private System.Windows.Forms.Panel pnl_row;
        private System.Windows.Forms.Label lbl_gameid;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txt_wx_id;
        private System.Windows.Forms.Label lbl_wx_id;
        private System.Windows.Forms.TextBox txt_game_id;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_ali_id;
        private System.Windows.Forms.Label lbl_ali_id;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txt_proxy_no;
        private System.Windows.Forms.Label lbl_proxy_no;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl_pump;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txt_limit;
        private System.Windows.Forms.Label lbl_limit;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.ComboBox cmb_choushui;
    }
}