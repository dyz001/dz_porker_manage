namespace dz_manager
{
    partial class WinDeskProfit
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
            this.btn_search = new System.Windows.Forms.Button();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.txt_desk_no = new System.Windows.Forms.TextBox();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_desk_no = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_search
            // 
            this.btn_search.Font = new System.Drawing.Font("宋体", 15F);
            this.btn_search.Location = new System.Drawing.Point(645, 31);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(100, 40);
            this.btn_search.TabIndex = 0;
            this.btn_search.Text = "查询";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // dtp_date
            // 
            this.dtp_date.Font = new System.Drawing.Font("宋体", 15F);
            this.dtp_date.Location = new System.Drawing.Point(157, 34);
            this.dtp_date.Name = "dtp_date";
            this.dtp_date.Size = new System.Drawing.Size(200, 30);
            this.dtp_date.TabIndex = 1;
            // 
            // txt_desk_no
            // 
            this.txt_desk_no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_desk_no.Font = new System.Drawing.Font("宋体", 15F);
            this.txt_desk_no.Location = new System.Drawing.Point(501, 33);
            this.txt_desk_no.Name = "txt_desk_no";
            this.txt_desk_no.Size = new System.Drawing.Size(100, 30);
            this.txt_desk_no.TabIndex = 2;
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("宋体", 15F);
            this.lbl_date.Location = new System.Drawing.Point(21, 35);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(129, 20);
            this.lbl_date.TabIndex = 3;
            this.lbl_date.Text = "请输入日期：";
            // 
            // lbl_desk_no
            // 
            this.lbl_desk_no.AutoSize = true;
            this.lbl_desk_no.Font = new System.Drawing.Font("宋体", 15F);
            this.lbl_desk_no.Location = new System.Drawing.Point(368, 37);
            this.lbl_desk_no.Name = "lbl_desk_no";
            this.lbl_desk_no.Size = new System.Drawing.Size(129, 20);
            this.lbl_desk_no.TabIndex = 4;
            this.lbl_desk_no.Text = "请输入桌号：";
            // 
            // WinDeskProfit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 490);
            this.Controls.Add(this.lbl_desk_no);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.txt_desk_no);
            this.Controls.Add(this.dtp_date);
            this.Controls.Add(this.btn_search);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WinDeskProfit";
            this.Text = "单桌每日赢利";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.TextBox txt_desk_no;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_desk_no;
    }
}