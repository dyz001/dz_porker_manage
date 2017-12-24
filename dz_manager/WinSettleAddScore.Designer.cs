namespace dz_manager
{
    partial class WinSettleAddScore
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle21 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgv_settle = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Member = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TakeIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fluctuate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Insure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Other = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_out_account = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_settle = new System.Windows.Forms.Button();
            this.txt_desk_no = new System.Windows.Forms.TextBox();
            this.lbl_desk_no = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_settle)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_settle
            // 
            this.dgv_settle.AllowUserToDeleteRows = false;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dgv_settle.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle17;
            this.dgv_settle.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("宋体", 15F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_settle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle18;
            this.dgv_settle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_settle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Member,
            this.TakeIn,
            this.Fluctuate,
            this.Insure,
            this.Other});
            this.dgv_settle.Location = new System.Drawing.Point(44, 58);
            this.dgv_settle.Name = "dgv_settle";
            this.dgv_settle.RowTemplate.Height = 23;
            this.dgv_settle.Size = new System.Drawing.Size(656, 296);
            this.dgv_settle.TabIndex = 6;
            // 
            // Id
            // 
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Id.DefaultCellStyle = dataGridViewCellStyle19;
            this.Id.HeaderText = "标识";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // Member
            // 
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Member.DefaultCellStyle = dataGridViewCellStyle20;
            this.Member.HeaderText = "玩家";
            this.Member.Name = "Member";
            // 
            // TakeIn
            // 
            dataGridViewCellStyle21.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle21.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TakeIn.DefaultCellStyle = dataGridViewCellStyle21;
            this.TakeIn.HeaderText = "带入";
            this.TakeIn.Name = "TakeIn";
            // 
            // Fluctuate
            // 
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle22.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Fluctuate.DefaultCellStyle = dataGridViewCellStyle22;
            this.Fluctuate.HeaderText = "波动";
            this.Fluctuate.Name = "Fluctuate";
            // 
            // Insure
            // 
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle23.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Insure.DefaultCellStyle = dataGridViewCellStyle23;
            this.Insure.HeaderText = "保险";
            this.Insure.Name = "Insure";
            // 
            // Other
            // 
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Other.DefaultCellStyle = dataGridViewCellStyle24;
            this.Other.HeaderText = "其他";
            this.Other.Name = "Other";
            // 
            // btn_out_account
            // 
            this.btn_out_account.Font = new System.Drawing.Font("宋体", 15F);
            this.btn_out_account.Location = new System.Drawing.Point(467, 369);
            this.btn_out_account.Name = "btn_out_account";
            this.btn_out_account.Size = new System.Drawing.Size(100, 40);
            this.btn_out_account.TabIndex = 5;
            this.btn_out_account.Text = "出账";
            this.btn_out_account.UseVisualStyleBackColor = true;
            this.btn_out_account.Click += new System.EventHandler(this.btn_out_account_Click);
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("宋体", 15F);
            this.btn_save.Location = new System.Drawing.Point(175, 369);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(100, 40);
            this.btn_save.TabIndex = 4;
            this.btn_save.Text = "保存";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_settle
            // 
            this.btn_settle.Font = new System.Drawing.Font("宋体", 15F);
            this.btn_settle.Location = new System.Drawing.Point(492, 14);
            this.btn_settle.Name = "btn_settle";
            this.btn_settle.Size = new System.Drawing.Size(88, 32);
            this.btn_settle.TabIndex = 3;
            this.btn_settle.Text = "结算";
            this.btn_settle.UseVisualStyleBackColor = true;
            this.btn_settle.Click += new System.EventHandler(this.btn_settle_Click);
            // 
            // txt_desk_no
            // 
            this.txt_desk_no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_desk_no.Font = new System.Drawing.Font("宋体", 15F);
            this.txt_desk_no.Location = new System.Drawing.Point(307, 16);
            this.txt_desk_no.Name = "txt_desk_no";
            this.txt_desk_no.Size = new System.Drawing.Size(133, 30);
            this.txt_desk_no.TabIndex = 2;
            // 
            // lbl_desk_no
            // 
            this.lbl_desk_no.AutoSize = true;
            this.lbl_desk_no.Font = new System.Drawing.Font("宋体", 15F);
            this.lbl_desk_no.Location = new System.Drawing.Point(171, 18);
            this.lbl_desk_no.Name = "lbl_desk_no";
            this.lbl_desk_no.Size = new System.Drawing.Size(129, 20);
            this.lbl_desk_no.TabIndex = 1;
            this.lbl_desk_no.Text = "请输入桌号：";
            // 
            // WinSettleAddScore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 427);
            this.Controls.Add(this.dgv_settle);
            this.Controls.Add(this.btn_out_account);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_settle);
            this.Controls.Add(this.txt_desk_no);
            this.Controls.Add(this.lbl_desk_no);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WinSettleAddScore";
            this.Text = "上分结算";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_settle)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_desk_no;
        private System.Windows.Forms.TextBox txt_desk_no;
        private System.Windows.Forms.Button btn_settle;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_out_account;
        private System.Windows.Forms.DataGridView dgv_settle;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Member;
        private System.Windows.Forms.DataGridViewTextBoxColumn TakeIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fluctuate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Insure;
        private System.Windows.Forms.DataGridViewTextBoxColumn Other;
    }
}