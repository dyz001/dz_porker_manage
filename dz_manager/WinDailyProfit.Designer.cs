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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btn_search = new System.Windows.Forms.Button();
            this.lbl_datetime = new System.Windows.Forms.Label();
            this.data_grid_daily = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.data_grid_daily)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(218, 25);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 21);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(461, 22);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 1;
            this.btn_search.Text = "查询";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // lbl_datetime
            // 
            this.lbl_datetime.AutoSize = true;
            this.lbl_datetime.Location = new System.Drawing.Point(135, 33);
            this.lbl_datetime.Name = "lbl_datetime";
            this.lbl_datetime.Size = new System.Drawing.Size(65, 12);
            this.lbl_datetime.TabIndex = 2;
            this.lbl_datetime.Text = "输入日期：";
            // 
            // data_grid_daily
            // 
            this.data_grid_daily.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.data_grid_daily.Location = new System.Drawing.Point(24, 65);
            this.data_grid_daily.Name = "data_grid_daily";
            this.data_grid_daily.RowTemplate.Height = 23;
            this.data_grid_daily.Size = new System.Drawing.Size(734, 344);
            this.data_grid_daily.TabIndex = 3;
            // 
            // DailyProfit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 421);
            this.Controls.Add(this.data_grid_daily);
            this.Controls.Add(this.lbl_datetime);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.dateTimePicker1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DailyProfit";
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
    }
}