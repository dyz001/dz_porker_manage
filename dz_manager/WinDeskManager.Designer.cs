namespace dz_manager
{
    partial class WinDeskManager
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
            this.tlp_main = new System.Windows.Forms.TableLayoutPanel();
            this.pnl_add_desk = new System.Windows.Forms.Panel();
            this.btn_add_desk = new System.Windows.Forms.Button();
            this.pnl_desk_info = new System.Windows.Forms.Panel();
            this.lbl_desk_state = new System.Windows.Forms.Label();
            this.lbl_desk_no = new System.Windows.Forms.Label();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.lbl_date = new System.Windows.Forms.Label();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.tlp_main.SuspendLayout();
            this.pnl_add_desk.SuspendLayout();
            this.pnl_desk_info.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp_main
            // 
            this.tlp_main.ColumnCount = 6;
            this.tlp_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlp_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlp_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlp_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlp_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlp_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tlp_main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tlp_main.Controls.Add(this.pnl_add_desk, 0, 0);
            this.tlp_main.Controls.Add(this.pnl_desk_info, 1, 0);
            this.tlp_main.Location = new System.Drawing.Point(23, 69);
            this.tlp_main.Name = "tlp_main";
            this.tlp_main.RowCount = 4;
            this.tlp_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tlp_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tlp_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tlp_main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 130F));
            this.tlp_main.Size = new System.Drawing.Size(725, 520);
            this.tlp_main.TabIndex = 0;
            // 
            // pnl_add_desk
            // 
            this.pnl_add_desk.Controls.Add(this.btn_add_desk);
            this.pnl_add_desk.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_add_desk.Location = new System.Drawing.Point(10, 10);
            this.pnl_add_desk.Margin = new System.Windows.Forms.Padding(10);
            this.pnl_add_desk.Name = "pnl_add_desk";
            this.pnl_add_desk.Size = new System.Drawing.Size(100, 110);
            this.pnl_add_desk.TabIndex = 0;
            // 
            // btn_add_desk
            // 
            this.btn_add_desk.AutoSize = true;
            this.btn_add_desk.Location = new System.Drawing.Point(1, 0);
            this.btn_add_desk.Margin = new System.Windows.Forms.Padding(10);
            this.btn_add_desk.Name = "btn_add_desk";
            this.btn_add_desk.Size = new System.Drawing.Size(90, 90);
            this.btn_add_desk.TabIndex = 0;
            this.btn_add_desk.Text = "+";
            this.btn_add_desk.UseVisualStyleBackColor = true;
            this.btn_add_desk.Click += new System.EventHandler(this.btn_add_desk_Click);
            // 
            // pnl_desk_info
            // 
            this.pnl_desk_info.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnl_desk_info.Controls.Add(this.lbl_desk_state);
            this.pnl_desk_info.Controls.Add(this.lbl_desk_no);
            this.pnl_desk_info.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_desk_info.Location = new System.Drawing.Point(130, 10);
            this.pnl_desk_info.Margin = new System.Windows.Forms.Padding(10);
            this.pnl_desk_info.Name = "pnl_desk_info";
            this.pnl_desk_info.Size = new System.Drawing.Size(100, 110);
            this.pnl_desk_info.TabIndex = 1;
            this.pnl_desk_info.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pnl_desk_info_MouseUp);
            // 
            // lbl_desk_state
            // 
            this.lbl_desk_state.AutoSize = true;
            this.lbl_desk_state.Font = new System.Drawing.Font("宋体", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_desk_state.Location = new System.Drawing.Point(14, 63);
            this.lbl_desk_state.Name = "lbl_desk_state";
            this.lbl_desk_state.Size = new System.Drawing.Size(69, 20);
            this.lbl_desk_state.TabIndex = 1;
            this.lbl_desk_state.Text = "进行中";
            // 
            // lbl_desk_no
            // 
            this.lbl_desk_no.AutoSize = true;
            this.lbl_desk_no.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_desk_no.Location = new System.Drawing.Point(7, 13);
            this.lbl_desk_no.Name = "lbl_desk_no";
            this.lbl_desk_no.Size = new System.Drawing.Size(80, 27);
            this.lbl_desk_no.TabIndex = 0;
            this.lbl_desk_no.Text = "1号桌";
            // 
            // dtp_date
            // 
            this.dtp_date.CalendarFont = new System.Drawing.Font("宋体", 15F);
            this.dtp_date.Font = new System.Drawing.Font("宋体", 15F);
            this.dtp_date.Location = new System.Drawing.Point(290, 20);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(183, 30);
            this.dtp_date.TabIndex = 1;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("宋体", 15F);
            this.lbl_date.Location = new System.Drawing.Point(164, 26);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(129, 20);
            this.lbl_date.TabIndex = 2;
            this.lbl_date.Text = "请选择日期：";
            // 
            // btn_refresh
            // 
            this.btn_refresh.Font = new System.Drawing.Font("宋体", 15F);
            this.btn_refresh.Location = new System.Drawing.Point(524, 16);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(75, 36);
            this.btn_refresh.TabIndex = 3;
            this.btn_refresh.Text = "刷新";
            this.btn_refresh.UseVisualStyleBackColor = true;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // WinDeskManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 630);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.dtp_date);
            this.Controls.Add(this.tlp_main);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WinDeskManager";
            this.Text = "牌桌管理";
            this.tlp_main.ResumeLayout(false);
            this.pnl_add_desk.ResumeLayout(false);
            this.pnl_add_desk.PerformLayout();
            this.pnl_desk_info.ResumeLayout(false);
            this.pnl_desk_info.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_main;
        private System.Windows.Forms.Panel pnl_add_desk;
        private System.Windows.Forms.Button btn_add_desk;
        private System.Windows.Forms.Panel pnl_desk_info;
        private System.Windows.Forms.Label lbl_desk_no;
        private System.Windows.Forms.Label lbl_desk_state;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Button btn_refresh;

    }
}