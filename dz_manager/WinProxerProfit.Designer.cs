namespace dz_manager
{
    partial class WinProxerProfit
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.txt_proxy_no = new System.Windows.Forms.TextBox();
            this.lbl_date = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.lbl_profit_all = new System.Windows.Forms.Label();
            this.lbl_profit_value = new System.Windows.Forms.Label();
            this.dgv_profit = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desk_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.profit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fanshui = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_profit)).BeginInit();
            this.SuspendLayout();
            // 
            // dtp_date
            // 
            this.dtp_date.Font = new System.Drawing.Font("宋体", 15F);
            this.dtp_date.Location = new System.Drawing.Point(153, 41);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(200, 30);
            this.dtp_date.TabIndex = 0;
            // 
            // txt_proxy_no
            // 
            this.txt_proxy_no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_proxy_no.Font = new System.Drawing.Font("宋体", 15F);
            this.txt_proxy_no.Location = new System.Drawing.Point(549, 41);
            this.txt_proxy_no.Name = "txt_proxy_no";
            this.txt_proxy_no.Size = new System.Drawing.Size(100, 30);
            this.txt_proxy_no.TabIndex = 1;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("宋体", 15F);
            this.lbl_date.Location = new System.Drawing.Point(19, 44);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(129, 20);
            this.lbl_date.TabIndex = 2;
            this.lbl_date.Text = "请输入日期：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 15F);
            this.label1.Location = new System.Drawing.Point(380, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "请输入代理编号：";
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("宋体", 15F);
            this.btn_search.Location = new System.Drawing.Point(662, 38);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(100, 40);
            this.btn_search.TabIndex = 4;
            this.btn_search.Text = "查询";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // lbl_profit_all
            // 
            this.lbl_profit_all.AutoSize = true;
            this.lbl_profit_all.Font = new System.Drawing.Font("宋体", 15F);
            this.lbl_profit_all.Location = new System.Drawing.Point(223, 92);
            this.lbl_profit_all.Name = "lbl_profit_all";
            this.lbl_profit_all.Size = new System.Drawing.Size(109, 20);
            this.lbl_profit_all.TabIndex = 5;
            this.lbl_profit_all.Text = "盈利总额：";
            // 
            // lbl_profit_value
            // 
            this.lbl_profit_value.AutoSize = true;
            this.lbl_profit_value.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_profit_value.ForeColor = System.Drawing.Color.Red;
            this.lbl_profit_value.Location = new System.Drawing.Point(317, 86);
            this.lbl_profit_value.Name = "lbl_profit_value";
            this.lbl_profit_value.Size = new System.Drawing.Size(68, 27);
            this.lbl_profit_value.TabIndex = 6;
            this.lbl_profit_value.Text = "1234";
            // 
            // dgv_profit
            // 
            this.dgv_profit.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 15F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_profit.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_profit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_profit.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.desk_no,
            this.profit,
            this.fanshui,
            this.detail});
            this.dgv_profit.Location = new System.Drawing.Point(57, 138);
            this.dgv_profit.Name = "dgv_profit";
            this.dgv_profit.RowTemplate.Height = 23;
            this.dgv_profit.Size = new System.Drawing.Size(576, 433);
            this.dgv_profit.TabIndex = 7;
            // 
            // Id
            // 
            this.Id.HeaderText = "标识";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // desk_no
            // 
            this.desk_no.HeaderText = "桌号";
            this.desk_no.Name = "desk_no";
            this.desk_no.ReadOnly = true;
            // 
            // profit
            // 
            this.profit.HeaderText = "盈利";
            this.profit.Name = "profit";
            this.profit.ReadOnly = true;
            // 
            // fanshui
            // 
            this.fanshui.HeaderText = "反水";
            this.fanshui.Name = "fanshui";
            this.fanshui.ReadOnly = true;
            // 
            // detail
            // 
            this.detail.HeaderText = "详情";
            this.detail.Name = "detail";
            this.detail.ReadOnly = true;
            // 
            // WinProxerProfit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 630);
            this.Controls.Add(this.dgv_profit);
            this.Controls.Add(this.lbl_profit_value);
            this.Controls.Add(this.lbl_profit_all);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.txt_proxy_no);
            this.Controls.Add(this.dtp_date);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WinProxerProfit";
            this.Text = "代理赢利查询";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_profit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.TextBox txt_proxy_no;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label lbl_profit_all;
        private System.Windows.Forms.Label lbl_profit_value;
        private System.Windows.Forms.DataGridView dgv_profit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn desk_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn profit;
        private System.Windows.Forms.DataGridViewTextBoxColumn fanshui;
        private System.Windows.Forms.DataGridViewTextBoxColumn detail;
    }
}