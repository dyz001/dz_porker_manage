namespace dz_manager
{
    partial class WinProxyQuery
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
            this.txt_proxy_gameid = new System.Windows.Forms.TextBox();
            this.btn_query = new System.Windows.Forms.Button();
            this.dgv_proxy = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.choushui = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.btn_save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_proxy)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_proxy_gameid
            // 
            this.txt_proxy_gameid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_proxy_gameid.Font = new System.Drawing.Font("宋体", 15F);
            this.txt_proxy_gameid.Location = new System.Drawing.Point(199, 22);
            this.txt_proxy_gameid.Name = "txt_proxy_gameid";
            this.txt_proxy_gameid.Size = new System.Drawing.Size(214, 30);
            this.txt_proxy_gameid.TabIndex = 0;
            // 
            // btn_query
            // 
            this.btn_query.Font = new System.Drawing.Font("宋体", 15F);
            this.btn_query.Location = new System.Drawing.Point(435, 19);
            this.btn_query.Name = "btn_query";
            this.btn_query.Size = new System.Drawing.Size(100, 40);
            this.btn_query.TabIndex = 1;
            this.btn_query.Text = "查询";
            this.btn_query.UseVisualStyleBackColor = true;
            this.btn_query.Click += new System.EventHandler(this.btn_query_Click);
            // 
            // dgv_proxy
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_proxy.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_proxy.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_proxy.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.name,
            this.no,
            this.choushui});
            this.dgv_proxy.Location = new System.Drawing.Point(138, 86);
            this.dgv_proxy.Name = "dgv_proxy";
            this.dgv_proxy.RowTemplate.Height = 23;
            this.dgv_proxy.Size = new System.Drawing.Size(459, 402);
            this.dgv_proxy.TabIndex = 2;
            this.dgv_proxy.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_proxy_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "标识";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            // 
            // name
            // 
            this.name.HeaderText = "代理名称";
            this.name.Name = "name";
            this.name.ReadOnly = true;
            // 
            // no
            // 
            this.no.HeaderText = "代理编号";
            this.no.Name = "no";
            this.no.ReadOnly = true;
            // 
            // choushui
            // 
            this.choushui.HeaderText = "抽水方式";
            this.choushui.Name = "choushui";
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("宋体", 15F);
            this.btn_save.Location = new System.Drawing.Point(303, 529);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(100, 40);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "保存";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // WinProxyQuery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(780, 630);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.dgv_proxy);
            this.Controls.Add(this.btn_query);
            this.Controls.Add(this.txt_proxy_gameid);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WinProxyQuery";
            this.Text = "代理查询";
            ((System.ComponentModel.ISupportInitialize)(this.dgv_proxy)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_proxy_gameid;
        private System.Windows.Forms.Button btn_query;
        private System.Windows.Forms.DataGridView dgv_proxy;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn no;
        private System.Windows.Forms.DataGridViewComboBoxColumn choushui;
        private System.Windows.Forms.Button btn_save;
    }
}