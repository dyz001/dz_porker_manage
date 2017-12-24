namespace dz_manager
{
    partial class WinDailyProfit
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_search = new System.Windows.Forms.Button();
            this.lbl_datetime = new System.Windows.Forms.Label();
            this.data_grid_daily = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desk_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.choushui = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.insure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.other = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.union = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_daily)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("宋体", 15F);
            this.dateTimePicker1.Location = new System.Drawing.Point(213, 22);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 30);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("宋体", 15F);
            this.btn_search.Location = new System.Drawing.Point(463, 18);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(100, 40);
            this.btn_search.TabIndex = 1;
            this.btn_search.Text = "查询";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // lbl_datetime
            // 
            this.lbl_datetime.AutoSize = true;
            this.lbl_datetime.Font = new System.Drawing.Font("宋体", 15F);
            this.lbl_datetime.Location = new System.Drawing.Point(102, 28);
            this.lbl_datetime.Name = "lbl_datetime";
            this.lbl_datetime.Size = new System.Drawing.Size(109, 20);
            this.lbl_datetime.TabIndex = 2;
            this.lbl_datetime.Text = "输入日期：";
            // 
            // data_grid_daily
            // 
            this.data_grid_daily.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 15F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data_grid_daily.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.data_grid_daily.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_grid_daily.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.desk_no,
            this.choushui,
            this.insure,
            this.other,
            this.sum,
            this.union,
            this.detail});
            this.data_grid_daily.Location = new System.Drawing.Point(24, 75);
            this.data_grid_daily.Name = "data_grid_daily";
            this.data_grid_daily.RowTemplate.Height = 23;
            this.data_grid_daily.Size = new System.Drawing.Size(734, 506);
            this.data_grid_daily.TabIndex = 3;
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
            // choushui
            // 
            this.choushui.HeaderText = "水";
            this.choushui.Name = "choushui";
            this.choushui.ReadOnly = true;
            // 
            // insure
            // 
            this.insure.HeaderText = "保险";
            this.insure.Name = "insure";
            this.insure.ReadOnly = true;
            // 
            // other
            // 
            this.other.HeaderText = "其他";
            this.other.Name = "other";
            this.other.ReadOnly = true;
            // 
            // sum
            // 
            this.sum.HeaderText = "合计";
            this.sum.Name = "sum";
            this.sum.ReadOnly = true;
            // 
            // union
            // 
            this.union.HeaderText = "联盟";
            this.union.Name = "union";
            this.union.ReadOnly = true;
            // 
            // detail
            // 
            this.detail.HeaderText = "详情";
            this.detail.Name = "detail";
            this.detail.ReadOnly = true;
            // 
            // WinDailyProfit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 630);
            this.Controls.Add(this.data_grid_daily);
            this.Controls.Add(this.lbl_datetime);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.dateTimePicker1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WinDailyProfit";
            this.Text = "日赢利查询";
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_daily)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Label lbl_datetime;
        private System.Windows.Forms.DataGridView data_grid_daily;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn desk_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn choushui;
        private System.Windows.Forms.DataGridViewTextBoxColumn insure;
        private System.Windows.Forms.DataGridViewTextBoxColumn other;
        private System.Windows.Forms.DataGridViewTextBoxColumn sum;
        private System.Windows.Forms.DataGridViewTextBoxColumn union;
        private System.Windows.Forms.DataGridViewTextBoxColumn detail;
    }
}