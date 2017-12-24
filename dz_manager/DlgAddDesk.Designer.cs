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
            this.txt_desk_name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtp_desk = new System.Windows.Forms.DateTimePicker();
            this.btn_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_desk_name
            // 
            this.lbl_desk_name.AutoSize = true;
            this.lbl_desk_name.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_desk_name.Location = new System.Drawing.Point(17, 28);
            this.lbl_desk_name.Name = "lbl_desk_name";
            this.lbl_desk_name.Size = new System.Drawing.Size(134, 27);
            this.lbl_desk_name.TabIndex = 0;
            this.lbl_desk_name.Text = "牌桌名称:";
            // 
            // txt_desk_name
            // 
            this.txt_desk_name.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txt_desk_name.Location = new System.Drawing.Point(152, 24);
            this.txt_desk_name.Name = "txt_desk_name";
            this.txt_desk_name.Size = new System.Drawing.Size(182, 38);
            this.txt_desk_name.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(17, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 27);
            this.label1.TabIndex = 2;
            this.label1.Text = "牌桌日期:";
            // 
            // dtp_desk
            // 
            this.dtp_desk.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dtp_desk.Location = new System.Drawing.Point(149, 86);
            this.dtp_desk.Name = "dtp_desk";
            this.dtp_desk.Size = new System.Drawing.Size(222, 38);
            this.dtp_desk.TabIndex = 4;
            // 
            // btn_ok
            // 
            this.btn_ok.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btn_ok.Location = new System.Drawing.Point(136, 148);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(100, 40);
            this.btn_ok.TabIndex = 5;
            this.btn_ok.Text = "确定";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // DlgAddDesk
            // 
            this.AcceptButton = this.btn_ok;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 212);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.dtp_desk);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_desk_name);
            this.Controls.Add(this.lbl_desk_name);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "DlgAddDesk";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加桌子";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_desk_name;
        private System.Windows.Forms.TextBox txt_desk_name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtp_desk;
        private System.Windows.Forms.Button btn_ok;
    }
}