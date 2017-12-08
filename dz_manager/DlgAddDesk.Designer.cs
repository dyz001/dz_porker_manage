namespace dz_manager
{
    partial class DlgAddDesk
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
            this.lbl_desk_name = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_desk_name = new System.Windows.Forms.TextBox();
            this.dtp_add_date = new System.Windows.Forms.DateTimePicker();
            this.btn_add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_desk_name
            // 
            this.lbl_desk_name.AutoSize = true;
            this.lbl_desk_name.Location = new System.Drawing.Point(142, 61);
            this.lbl_desk_name.Name = "lbl_desk_name";
            this.lbl_desk_name.Size = new System.Drawing.Size(65, 12);
            this.lbl_desk_name.TabIndex = 0;
            this.lbl_desk_name.Text = "桌子名称：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(142, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "牌桌日期：";
            // 
            // txt_desk_name
            // 
            this.txt_desk_name.Location = new System.Drawing.Point(230, 61);
            this.txt_desk_name.Name = "txt_desk_name";
            this.txt_desk_name.Size = new System.Drawing.Size(100, 21);
            this.txt_desk_name.TabIndex = 2;
            // 
            // dtp_add_date
            // 
            this.dtp_add_date.Location = new System.Drawing.Point(230, 111);
            this.dtp_add_date.Name = "dtp_add_date";
            this.dtp_add_date.Size = new System.Drawing.Size(200, 21);
            this.dtp_add_date.TabIndex = 3;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(256, 199);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(75, 23);
            this.btn_add.TabIndex = 4;
            this.btn_add.Text = "添加";
            this.btn_add.UseVisualStyleBackColor = true;
            // 
            // DlgAddDesk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 262);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.dtp_add_date);
            this.Controls.Add(this.txt_desk_name);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_desk_name);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DlgAddDesk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "添加桌子";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_desk_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_desk_name;
        private System.Windows.Forms.DateTimePicker dtp_add_date;
        private System.Windows.Forms.Button btn_add;
    }
}