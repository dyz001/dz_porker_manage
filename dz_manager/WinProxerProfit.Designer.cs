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
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.txt_proxy_no = new System.Windows.Forms.TextBox();
            this.lbl_date = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.lbl_profit_all = new System.Windows.Forms.Label();
            this.lbl_profit_value = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtp_date
            // 
            this.dtp_date.Location = new System.Drawing.Point(135, 41);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(200, 21);
            this.dtp_date.TabIndex = 0;
            // 
            // txt_proxy_no
            // 
            this.txt_proxy_no.Location = new System.Drawing.Point(514, 41);
            this.txt_proxy_no.Name = "txt_proxy_no";
            this.txt_proxy_no.Size = new System.Drawing.Size(100, 21);
            this.txt_proxy_no.TabIndex = 1;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Location = new System.Drawing.Point(52, 44);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(77, 12);
            this.lbl_date.TabIndex = 2;
            this.lbl_date.Text = "请输入日期：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(380, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "请输入代理编号：";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(664, 38);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 4;
            this.btn_search.Text = "查询";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // lbl_profit_all
            // 
            this.lbl_profit_all.AutoSize = true;
            this.lbl_profit_all.Location = new System.Drawing.Point(223, 92);
            this.lbl_profit_all.Name = "lbl_profit_all";
            this.lbl_profit_all.Size = new System.Drawing.Size(65, 12);
            this.lbl_profit_all.TabIndex = 5;
            this.lbl_profit_all.Text = "盈利总额：";
            // 
            // lbl_profit_value
            // 
            this.lbl_profit_value.AutoSize = true;
            this.lbl_profit_value.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_profit_value.ForeColor = System.Drawing.Color.Red;
            this.lbl_profit_value.Location = new System.Drawing.Point(299, 84);
            this.lbl_profit_value.Name = "lbl_profit_value";
            this.lbl_profit_value.Size = new System.Drawing.Size(68, 27);
            this.lbl_profit_value.TabIndex = 6;
            this.lbl_profit_value.Text = "1234";
            // 
            // WinProxerProfit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(906, 449);
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
    }
}