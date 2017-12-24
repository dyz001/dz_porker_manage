namespace dz_manager
{
    partial class WinAddScoreManage
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
            this.lbl_desk_no = new System.Windows.Forms.Label();
            this.txt_desk_no = new System.Windows.Forms.TextBox();
            this.lbl_game_id = new System.Windows.Forms.Label();
            this.txt_game_id = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.flp_main = new System.Windows.Forms.FlowLayoutPanel();
            this.pnl_template = new System.Windows.Forms.Panel();
            this.lbl_score_sum = new System.Windows.Forms.Label();
            this.btn_finish = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.lbl_balance_val = new System.Windows.Forms.Label();
            this.lbl_balance = new System.Windows.Forms.Label();
            this.txt_score = new System.Windows.Forms.TextBox();
            this.lbl_add_score = new System.Windows.Forms.Label();
            this.lbl_member_id_val = new System.Windows.Forms.Label();
            this.lbl_member_id = new System.Windows.Forms.Label();
            this.lbl_desk_no_val = new System.Windows.Forms.Label();
            this.lbl_deskno = new System.Windows.Forms.Label();
            this.flp_main.SuspendLayout();
            this.pnl_template.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_desk_no
            // 
            this.lbl_desk_no.AutoSize = true;
            this.lbl_desk_no.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_desk_no.Location = new System.Drawing.Point(10, 10);
            this.lbl_desk_no.Name = "lbl_desk_no";
            this.lbl_desk_no.Size = new System.Drawing.Size(120, 27);
            this.lbl_desk_no.TabIndex = 0;
            this.lbl_desk_no.Text = "牌桌号：";
            // 
            // txt_desk_no
            // 
            this.txt_desk_no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_desk_no.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_desk_no.Location = new System.Drawing.Point(109, 7);
            this.txt_desk_no.Name = "txt_desk_no";
            this.txt_desk_no.Size = new System.Drawing.Size(149, 38);
            this.txt_desk_no.TabIndex = 1;
            // 
            // lbl_game_id
            // 
            this.lbl_game_id.AutoSize = true;
            this.lbl_game_id.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_game_id.Location = new System.Drawing.Point(261, 11);
            this.lbl_game_id.Name = "lbl_game_id";
            this.lbl_game_id.Size = new System.Drawing.Size(147, 27);
            this.lbl_game_id.TabIndex = 2;
            this.lbl_game_id.Text = "游戏编号：";
            // 
            // txt_game_id
            // 
            this.txt_game_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_game_id.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_game_id.Location = new System.Drawing.Point(395, 6);
            this.txt_game_id.Name = "txt_game_id";
            this.txt_game_id.Size = new System.Drawing.Size(204, 38);
            this.txt_game_id.TabIndex = 3;
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_search.Location = new System.Drawing.Point(640, 2);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(100, 45);
            this.btn_search.TabIndex = 4;
            this.btn_search.Text = "查询";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // flp_main
            // 
            this.flp_main.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flp_main.Controls.Add(this.pnl_template);
            this.flp_main.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flp_main.Location = new System.Drawing.Point(8, 66);
            this.flp_main.Name = "flp_main";
            this.flp_main.Size = new System.Drawing.Size(761, 531);
            this.flp_main.TabIndex = 5;
            // 
            // pnl_template
            // 
            this.pnl_template.Controls.Add(this.lbl_score_sum);
            this.pnl_template.Controls.Add(this.btn_finish);
            this.pnl_template.Controls.Add(this.btn_add);
            this.pnl_template.Controls.Add(this.lbl_balance_val);
            this.pnl_template.Controls.Add(this.lbl_balance);
            this.pnl_template.Controls.Add(this.txt_score);
            this.pnl_template.Controls.Add(this.lbl_add_score);
            this.pnl_template.Controls.Add(this.lbl_member_id_val);
            this.pnl_template.Controls.Add(this.lbl_member_id);
            this.pnl_template.Controls.Add(this.lbl_desk_no_val);
            this.pnl_template.Controls.Add(this.lbl_deskno);
            this.pnl_template.Location = new System.Drawing.Point(10, 10);
            this.pnl_template.Margin = new System.Windows.Forms.Padding(10);
            this.pnl_template.Name = "pnl_template";
            this.pnl_template.Size = new System.Drawing.Size(741, 61);
            this.pnl_template.TabIndex = 0;
            // 
            // lbl_score_sum
            // 
            this.lbl_score_sum.AutoSize = true;
            this.lbl_score_sum.Font = new System.Drawing.Font("宋体", 15F);
            this.lbl_score_sum.Location = new System.Drawing.Point(314, 18);
            this.lbl_score_sum.Name = "lbl_score_sum";
            this.lbl_score_sum.Size = new System.Drawing.Size(49, 20);
            this.lbl_score_sum.TabIndex = 10;
            this.lbl_score_sum.Text = "1000";
            // 
            // btn_finish
            // 
            this.btn_finish.Font = new System.Drawing.Font("宋体", 15F);
            this.btn_finish.Location = new System.Drawing.Point(666, 11);
            this.btn_finish.Name = "btn_finish";
            this.btn_finish.Size = new System.Drawing.Size(70, 33);
            this.btn_finish.TabIndex = 9;
            this.btn_finish.Text = "完成";
            this.btn_finish.UseVisualStyleBackColor = true;
            this.btn_finish.Click += new System.EventHandler(this.btn_finish_Click);
            // 
            // btn_add
            // 
            this.btn_add.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Bold);
            this.btn_add.Location = new System.Drawing.Point(617, 9);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(35, 35);
            this.btn_add.TabIndex = 8;
            this.btn_add.Text = "+";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // lbl_balance_val
            // 
            this.lbl_balance_val.AutoSize = true;
            this.lbl_balance_val.Font = new System.Drawing.Font("宋体", 15F);
            this.lbl_balance_val.Location = new System.Drawing.Point(564, 18);
            this.lbl_balance_val.Name = "lbl_balance_val";
            this.lbl_balance_val.Size = new System.Drawing.Size(49, 20);
            this.lbl_balance_val.TabIndex = 7;
            this.lbl_balance_val.Text = "1000";
            // 
            // lbl_balance
            // 
            this.lbl_balance.AutoSize = true;
            this.lbl_balance.Font = new System.Drawing.Font("宋体", 15F);
            this.lbl_balance.Location = new System.Drawing.Point(504, 18);
            this.lbl_balance.Name = "lbl_balance";
            this.lbl_balance.Size = new System.Drawing.Size(69, 20);
            this.lbl_balance.TabIndex = 6;
            this.lbl_balance.Text = "额度：";
            // 
            // txt_score
            // 
            this.txt_score.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_score.Font = new System.Drawing.Font("宋体", 15F);
            this.txt_score.Location = new System.Drawing.Point(385, 13);
            this.txt_score.Name = "txt_score";
            this.txt_score.Size = new System.Drawing.Size(110, 30);
            this.txt_score.TabIndex = 5;
            // 
            // lbl_add_score
            // 
            this.lbl_add_score.AutoSize = true;
            this.lbl_add_score.Font = new System.Drawing.Font("宋体", 15F);
            this.lbl_add_score.Location = new System.Drawing.Point(266, 18);
            this.lbl_add_score.Name = "lbl_add_score";
            this.lbl_add_score.Size = new System.Drawing.Size(69, 20);
            this.lbl_add_score.TabIndex = 4;
            this.lbl_add_score.Text = "上分：";
            // 
            // lbl_member_id_val
            // 
            this.lbl_member_id_val.AutoSize = true;
            this.lbl_member_id_val.Font = new System.Drawing.Font("宋体", 15F);
            this.lbl_member_id_val.Location = new System.Drawing.Point(210, 18);
            this.lbl_member_id_val.Name = "lbl_member_id_val";
            this.lbl_member_id_val.Size = new System.Drawing.Size(49, 20);
            this.lbl_member_id_val.TabIndex = 3;
            this.lbl_member_id_val.Text = "张三";
            // 
            // lbl_member_id
            // 
            this.lbl_member_id.AutoSize = true;
            this.lbl_member_id.Font = new System.Drawing.Font("宋体", 15F);
            this.lbl_member_id.Location = new System.Drawing.Point(135, 18);
            this.lbl_member_id.Name = "lbl_member_id";
            this.lbl_member_id.Size = new System.Drawing.Size(79, 20);
            this.lbl_member_id.TabIndex = 2;
            this.lbl_member_id.Text = "游戏ID:";
            // 
            // lbl_desk_no_val
            // 
            this.lbl_desk_no_val.AutoSize = true;
            this.lbl_desk_no_val.Font = new System.Drawing.Font("宋体", 15F);
            this.lbl_desk_no_val.Location = new System.Drawing.Point(80, 18);
            this.lbl_desk_no_val.Name = "lbl_desk_no_val";
            this.lbl_desk_no_val.Size = new System.Drawing.Size(49, 20);
            this.lbl_desk_no_val.TabIndex = 1;
            this.lbl_desk_no_val.Text = "0333";
            // 
            // lbl_deskno
            // 
            this.lbl_deskno.AutoSize = true;
            this.lbl_deskno.Font = new System.Drawing.Font("宋体", 15F);
            this.lbl_deskno.Location = new System.Drawing.Point(5, 18);
            this.lbl_deskno.Name = "lbl_deskno";
            this.lbl_deskno.Size = new System.Drawing.Size(89, 20);
            this.lbl_deskno.TabIndex = 0;
            this.lbl_deskno.Text = "牌桌号：";
            // 
            // WinAddScoreManage
            // 
            this.AcceptButton = this.btn_search;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 630);
            this.Controls.Add(this.flp_main);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_game_id);
            this.Controls.Add(this.lbl_game_id);
            this.Controls.Add(this.txt_desk_no);
            this.Controls.Add(this.lbl_desk_no);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WinAddScoreManage";
            this.Text = "上分管理";
            this.flp_main.ResumeLayout(false);
            this.pnl_template.ResumeLayout(false);
            this.pnl_template.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_desk_no;
        private System.Windows.Forms.TextBox txt_desk_no;
        private System.Windows.Forms.Label lbl_game_id;
        private System.Windows.Forms.TextBox txt_game_id;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.FlowLayoutPanel flp_main;
        private System.Windows.Forms.Panel pnl_template;
        private System.Windows.Forms.Label lbl_deskno;
        private System.Windows.Forms.Label lbl_desk_no_val;
        private System.Windows.Forms.Label lbl_member_id;
        private System.Windows.Forms.Label lbl_member_id_val;
        private System.Windows.Forms.Label lbl_add_score;
        private System.Windows.Forms.TextBox txt_score;
        private System.Windows.Forms.Label lbl_balance;
        private System.Windows.Forms.Label lbl_balance_val;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Button btn_finish;
        private System.Windows.Forms.Label lbl_score_sum;
    }
}