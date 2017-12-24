namespace dz_manager
{
    partial class WinMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pnl_win = new System.Windows.Forms.Panel();
            this.rdo_add_score = new System.Windows.Forms.RadioButton();
            this.gpb_top_btns = new System.Windows.Forms.GroupBox();
            this.rdo_data_query = new System.Windows.Forms.RadioButton();
            this.rdo_member_mgr = new System.Windows.Forms.RadioButton();
            this.rdo_proxy_mgr = new System.Windows.Forms.RadioButton();
            this.gpb_add_score = new System.Windows.Forms.GroupBox();
            this.gpb_top_btns.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_win
            // 
            this.pnl_win.Location = new System.Drawing.Point(172, 93);
            this.pnl_win.Name = "pnl_win";
            this.pnl_win.Size = new System.Drawing.Size(780, 630);
            this.pnl_win.TabIndex = 1;
            // 
            // rdo_add_score
            // 
            this.rdo_add_score.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdo_add_score.AutoSize = true;
            this.rdo_add_score.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.rdo_add_score.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdo_add_score.Location = new System.Drawing.Point(44, 13);
            this.rdo_add_score.Name = "rdo_add_score";
            this.rdo_add_score.Size = new System.Drawing.Size(144, 37);
            this.rdo_add_score.TabIndex = 0;
            this.rdo_add_score.TabStop = true;
            this.rdo_add_score.Text = "上分管理 ";
            this.rdo_add_score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdo_add_score.UseVisualStyleBackColor = false;
            this.rdo_add_score.CheckedChanged += new System.EventHandler(this.rdo_add_score_CheckedChanged);
            // 
            // gpb_top_btns
            // 
            this.gpb_top_btns.Controls.Add(this.rdo_data_query);
            this.gpb_top_btns.Controls.Add(this.rdo_member_mgr);
            this.gpb_top_btns.Controls.Add(this.rdo_proxy_mgr);
            this.gpb_top_btns.Controls.Add(this.rdo_add_score);
            this.gpb_top_btns.Location = new System.Drawing.Point(23, 10);
            this.gpb_top_btns.Name = "gpb_top_btns";
            this.gpb_top_btns.Size = new System.Drawing.Size(911, 56);
            this.gpb_top_btns.TabIndex = 2;
            this.gpb_top_btns.TabStop = false;
            // 
            // rdo_data_query
            // 
            this.rdo_data_query.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdo_data_query.AutoSize = true;
            this.rdo_data_query.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.rdo_data_query.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdo_data_query.Location = new System.Drawing.Point(687, 13);
            this.rdo_data_query.Name = "rdo_data_query";
            this.rdo_data_query.Size = new System.Drawing.Size(130, 37);
            this.rdo_data_query.TabIndex = 3;
            this.rdo_data_query.TabStop = true;
            this.rdo_data_query.Text = "数据查询";
            this.rdo_data_query.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdo_data_query.UseVisualStyleBackColor = false;
            // 
            // rdo_member_mgr
            // 
            this.rdo_member_mgr.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdo_member_mgr.AutoSize = true;
            this.rdo_member_mgr.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.rdo_member_mgr.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdo_member_mgr.Location = new System.Drawing.Point(447, 10);
            this.rdo_member_mgr.Name = "rdo_member_mgr";
            this.rdo_member_mgr.Size = new System.Drawing.Size(144, 37);
            this.rdo_member_mgr.TabIndex = 2;
            this.rdo_member_mgr.TabStop = true;
            this.rdo_member_mgr.Text = "会员管理 ";
            this.rdo_member_mgr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdo_member_mgr.UseVisualStyleBackColor = false;
            // 
            // rdo_proxy_mgr
            // 
            this.rdo_proxy_mgr.Appearance = System.Windows.Forms.Appearance.Button;
            this.rdo_proxy_mgr.AutoSize = true;
            this.rdo_proxy_mgr.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.rdo_proxy_mgr.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rdo_proxy_mgr.Location = new System.Drawing.Point(233, 13);
            this.rdo_proxy_mgr.Name = "rdo_proxy_mgr";
            this.rdo_proxy_mgr.Size = new System.Drawing.Size(144, 37);
            this.rdo_proxy_mgr.TabIndex = 1;
            this.rdo_proxy_mgr.TabStop = true;
            this.rdo_proxy_mgr.Text = "代理管理 ";
            this.rdo_proxy_mgr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rdo_proxy_mgr.UseVisualStyleBackColor = false;
            // 
            // gpb_add_score
            // 
            this.gpb_add_score.Location = new System.Drawing.Point(23, 84);
            this.gpb_add_score.Name = "gpb_add_score";
            this.gpb_add_score.Size = new System.Drawing.Size(146, 645);
            this.gpb_add_score.TabIndex = 3;
            this.gpb_add_score.TabStop = false;
            // 
            // WinMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(991, 756);
            this.Controls.Add(this.gpb_add_score);
            this.Controls.Add(this.gpb_top_btns);
            this.Controls.Add(this.pnl_win);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "WinMain";
            this.Text = "德扑圈积分管理系统";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpb_top_btns.ResumeLayout(false);
            this.gpb_top_btns.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_win;
        private System.Windows.Forms.RadioButton rdo_add_score;
        private System.Windows.Forms.GroupBox gpb_top_btns;
        private System.Windows.Forms.RadioButton rdo_proxy_mgr;
        private System.Windows.Forms.RadioButton rdo_member_mgr;
        private System.Windows.Forms.RadioButton rdo_data_query;
        private System.Windows.Forms.GroupBox gpb_add_score;
    }
}

