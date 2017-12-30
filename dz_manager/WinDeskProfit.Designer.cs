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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btn_search = new System.Windows.Forms.Button();
            this.dtp_date = new System.Windows.Forms.DateTimePicker();
            this.txt_desk_no = new System.Windows.Forms.TextBox();
            this.lbl_date = new System.Windows.Forms.Label();
            this.lbl_desk_no = new System.Windows.Forms.Label();
            this.dgv_settle = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Member = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TakeIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fluctuate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PureFluctuate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Insure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PureInsure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChouShui = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JingChouShui = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Other = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Income = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Union = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Transfer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_settle)).BeginInit();
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
            // dgv_settle
            // 
            this.dgv_settle.AllowUserToDeleteRows = false;
            this.dgv_settle.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_settle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_settle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_settle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Member,
            this.TakeIn,
            this.Fluctuate,
            this.PureFluctuate,
            this.Insure,
            this.PureInsure,
            this.ChouShui,
            this.JingChouShui,
            this.Other,
            this.Income,
            this.Union,
            this.Balance,
            this.Transfer});
            this.dgv_settle.Location = new System.Drawing.Point(5, 91);
            this.dgv_settle.Name = "dgv_settle";
            this.dgv_settle.ReadOnly = true;
            this.dgv_settle.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 15F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_settle.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_settle.RowTemplate.Height = 23;
            this.dgv_settle.Size = new System.Drawing.Size(771, 510);
            this.dgv_settle.TabIndex = 5;
            this.dgv_settle.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.dgv_settle_CellPainting);
            // 
            // Id
            // 
            this.Id.HeaderText = "标识";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Member
            // 
            this.Member.HeaderText = "玩家";
            this.Member.Name = "Member";
            this.Member.ReadOnly = true;
            // 
            // TakeIn
            // 
            this.TakeIn.HeaderText = "带入";
            this.TakeIn.Name = "TakeIn";
            this.TakeIn.ReadOnly = true;
            // 
            // Fluctuate
            // 
            this.Fluctuate.HeaderText = "波动";
            this.Fluctuate.Name = "Fluctuate";
            this.Fluctuate.ReadOnly = true;
            // 
            // PureFluctuate
            // 
            this.PureFluctuate.HeaderText = "净波动";
            this.PureFluctuate.Name = "PureFluctuate";
            this.PureFluctuate.ReadOnly = true;
            // 
            // Insure
            // 
            this.Insure.HeaderText = "保险";
            this.Insure.Name = "Insure";
            this.Insure.ReadOnly = true;
            // 
            // PureInsure
            // 
            this.PureInsure.HeaderText = "净保险";
            this.PureInsure.Name = "PureInsure";
            this.PureInsure.ReadOnly = true;
            // 
            // ChouShui
            // 
            this.ChouShui.HeaderText = "抽水";
            this.ChouShui.Name = "ChouShui";
            this.ChouShui.ReadOnly = true;
            // 
            // JingChouShui
            // 
            this.JingChouShui.HeaderText = "净水";
            this.JingChouShui.Name = "JingChouShui";
            this.JingChouShui.ReadOnly = true;
            // 
            // Other
            // 
            this.Other.HeaderText = "其他";
            this.Other.Name = "Other";
            this.Other.ReadOnly = true;
            // 
            // Income
            // 
            this.Income.HeaderText = "收入";
            this.Income.Name = "Income";
            this.Income.ReadOnly = true;
            // 
            // Union
            // 
            this.Union.HeaderText = "联盟";
            this.Union.Name = "Union";
            this.Union.ReadOnly = true;
            // 
            // Balance
            // 
            this.Balance.HeaderText = "玩家额度";
            this.Balance.Name = "Balance";
            this.Balance.ReadOnly = true;
            // 
            // Transfer
            // 
            this.Transfer.HeaderText = "玩家转账";
            this.Transfer.Name = "Transfer";
            this.Transfer.ReadOnly = true;
            // 
            // WinDeskProfit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 630);
            this.Controls.Add(this.dgv_settle);
            this.Controls.Add(this.lbl_desk_no);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.txt_desk_no);
            this.Controls.Add(this.dtp_date);
            this.Controls.Add(this.btn_search);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WinDeskProfit";
            this.Text = "单桌每日赢利";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_settle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.DateTimePicker dtp_date;
        private System.Windows.Forms.TextBox txt_desk_no;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Label lbl_desk_no;
        private System.Windows.Forms.DataGridView dgv_settle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Member;
        private System.Windows.Forms.DataGridViewTextBoxColumn TakeIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fluctuate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PureFluctuate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Insure;
        private System.Windows.Forms.DataGridViewTextBoxColumn PureInsure;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChouShui;
        private System.Windows.Forms.DataGridViewTextBoxColumn JingChouShui;
        private System.Windows.Forms.DataGridViewTextBoxColumn Other;
        private System.Windows.Forms.DataGridViewTextBoxColumn Income;
        private System.Windows.Forms.DataGridViewTextBoxColumn Union;
        private System.Windows.Forms.DataGridViewTextBoxColumn Balance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Transfer;
    }
}