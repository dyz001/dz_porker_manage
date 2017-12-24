namespace dz_manager
{
    partial class WinMemberQuery
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
            this.btn_save = new System.Windows.Forms.Button();
            this.dgv_userdata = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.game_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.wx_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ali_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proxy_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.choushui = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.balance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_query = new System.Windows.Forms.Button();
            this.txt_game_id = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_userdata)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("宋体", 15F);
            this.btn_save.Location = new System.Drawing.Point(289, 550);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(100, 40);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "保存";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // dgv_userdata
            // 
            this.dgv_userdata.AllowUserToDeleteRows = false;
            this.dgv_userdata.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_userdata.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_userdata.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_userdata.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.game_id,
            this.wx_id,
            this.ali_id,
            this.proxy_id,
            this.choushui,
            this.balance});
            this.dgv_userdata.Location = new System.Drawing.Point(15, 91);
            this.dgv_userdata.Name = "dgv_userdata";
            this.dgv_userdata.RowTemplate.Height = 23;
            this.dgv_userdata.Size = new System.Drawing.Size(751, 437);
            this.dgv_userdata.TabIndex = 2;
            // 
            // Id
            // 
            this.Id.HeaderText = "标识";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // game_id
            // 
            this.game_id.HeaderText = "游戏Id";
            this.game_id.Name = "game_id";
            // 
            // wx_id
            // 
            this.wx_id.HeaderText = "微信ID";
            this.wx_id.Name = "wx_id";
            // 
            // ali_id
            // 
            this.ali_id.HeaderText = "支付宝Id";
            this.ali_id.Name = "ali_id";
            // 
            // proxy_id
            // 
            this.proxy_id.HeaderText = "代理编号";
            this.proxy_id.Name = "proxy_id";
            // 
            // choushui
            // 
            this.choushui.HeaderText = "抽水方式";
            this.choushui.Name = "choushui";
            this.choushui.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.choushui.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // balance
            // 
            this.balance.HeaderText = "额度";
            this.balance.Name = "balance";
            // 
            // btn_query
            // 
            this.btn_query.Font = new System.Drawing.Font("宋体", 15F);
            this.btn_query.Location = new System.Drawing.Point(412, 32);
            this.btn_query.Name = "btn_query";
            this.btn_query.Size = new System.Drawing.Size(100, 40);
            this.btn_query.TabIndex = 1;
            this.btn_query.Text = "查询";
            this.btn_query.UseVisualStyleBackColor = true;
            this.btn_query.Click += new System.EventHandler(this.btn_query_Click);
            // 
            // txt_game_id
            // 
            this.txt_game_id.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_game_id.Font = new System.Drawing.Font("宋体", 15F);
            this.txt_game_id.Location = new System.Drawing.Point(187, 35);
            this.txt_game_id.Name = "txt_game_id";
            this.txt_game_id.Size = new System.Drawing.Size(218, 30);
            this.txt_game_id.TabIndex = 0;
            // 
            // WinMemberQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 630);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.dgv_userdata);
            this.Controls.Add(this.btn_query);
            this.Controls.Add(this.txt_game_id);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WinMemberQuery";
            this.Text = "会员查询";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_userdata)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_game_id;
        private System.Windows.Forms.Button btn_query;
        private System.Windows.Forms.DataGridView dgv_userdata;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn game_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn wx_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ali_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn proxy_id;
        private System.Windows.Forms.DataGridViewComboBoxColumn choushui;
        private System.Windows.Forms.DataGridViewTextBoxColumn balance;
    }
}