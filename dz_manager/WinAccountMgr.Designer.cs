namespace dz_manager
{
    partial class WinAccountMgr
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txt_desk_no = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.DGView = new System.Windows.Forms.DataGridView();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_out_bill = new System.Windows.Forms.Button();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColTakeIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColFluctuate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColInsure = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColOther = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DGView)).BeginInit();
            this.SuspendLayout();
            // 
            // txt_desk_no
            // 
            this.txt_desk_no.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_desk_no.Font = new System.Drawing.Font("宋体", 15F);
            this.txt_desk_no.Location = new System.Drawing.Point(177, 27);
            this.txt_desk_no.Name = "txt_desk_no";
            this.txt_desk_no.Size = new System.Drawing.Size(200, 30);
            this.txt_desk_no.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 15F);
            this.button1.Location = new System.Drawing.Point(407, 26);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 31);
            this.button1.TabIndex = 1;
            this.button1.Text = "结算";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // DGView
            // 
            this.DGView.AllowUserToAddRows = false;
            this.DGView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.ControlDark;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("宋体", 15F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.DGView.ColumnHeadersHeight = 40;
            this.DGView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.DGView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColName,
            this.ColTakeIn,
            this.ColFluctuate,
            this.ColInsure,
            this.ColOther});
            this.DGView.GridColor = System.Drawing.SystemColors.ButtonFace;
            this.DGView.Location = new System.Drawing.Point(60, 102);
            this.DGView.Name = "DGView";
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.ButtonFace;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGView.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.DGView.RowTemplate.Height = 23;
            this.DGView.Size = new System.Drawing.Size(547, 400);
            this.DGView.TabIndex = 2;
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("宋体", 15F);
            this.btn_save.Location = new System.Drawing.Point(167, 553);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(76, 31);
            this.btn_save.TabIndex = 3;
            this.btn_save.Text = "保存";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_out_bill
            // 
            this.btn_out_bill.Font = new System.Drawing.Font("宋体", 15F);
            this.btn_out_bill.Location = new System.Drawing.Point(406, 553);
            this.btn_out_bill.Name = "btn_out_bill";
            this.btn_out_bill.Size = new System.Drawing.Size(76, 31);
            this.btn_out_bill.TabIndex = 4;
            this.btn_out_bill.Text = "出账";
            this.btn_out_bill.UseVisualStyleBackColor = true;
            // 
            // ColName
            // 
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ColName.DefaultCellStyle = dataGridViewCellStyle9;
            this.ColName.HeaderText = "玩家";
            this.ColName.Name = "ColName";
            // 
            // ColTakeIn
            // 
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ColTakeIn.DefaultCellStyle = dataGridViewCellStyle10;
            this.ColTakeIn.HeaderText = "带入";
            this.ColTakeIn.Name = "ColTakeIn";
            // 
            // ColFluctuate
            // 
            dataGridViewCellStyle11.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ColFluctuate.DefaultCellStyle = dataGridViewCellStyle11;
            this.ColFluctuate.HeaderText = "波动";
            this.ColFluctuate.Name = "ColFluctuate";
            // 
            // ColInsure
            // 
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ColInsure.DefaultCellStyle = dataGridViewCellStyle12;
            this.ColInsure.HeaderText = "保险";
            this.ColInsure.Name = "ColInsure";
            // 
            // ColOther
            // 
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("宋体", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ColOther.DefaultCellStyle = dataGridViewCellStyle13;
            this.ColOther.HeaderText = "其他";
            this.ColOther.Name = "ColOther";
            // 
            // WinAccountMgr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 642);
            this.Controls.Add(this.btn_out_bill);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.DGView);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_desk_no);
            this.Name = "WinAccountMgr";
            this.Text = "WinAccountMgr";
            ((System.ComponentModel.ISupportInitialize)(this.DGView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_desk_no;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView DGView;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_out_bill;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColTakeIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColFluctuate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColInsure;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColOther;
    }
}