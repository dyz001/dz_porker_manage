namespace dz_manager
{
    partial class WinAddBalance
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
            this.lbl_balance = new System.Windows.Forms.Label();
            this.txt_balance = new System.Windows.Forms.TextBox();
            this.btn_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_balance
            // 
            this.lbl_balance.AutoSize = true;
            this.lbl_balance.Font = new System.Drawing.Font("宋体", 15F);
            this.lbl_balance.Location = new System.Drawing.Point(29, 70);
            this.lbl_balance.Name = "lbl_balance";
            this.lbl_balance.Size = new System.Drawing.Size(109, 20);
            this.lbl_balance.TabIndex = 0;
            this.lbl_balance.Text = "输入额度：";
            // 
            // txt_balance
            // 
            this.txt_balance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txt_balance.Font = new System.Drawing.Font("宋体", 15F);
            this.txt_balance.Location = new System.Drawing.Point(136, 68);
            this.txt_balance.Name = "txt_balance";
            this.txt_balance.Size = new System.Drawing.Size(209, 30);
            this.txt_balance.TabIndex = 1;
            // 
            // btn_ok
            // 
            this.btn_ok.Font = new System.Drawing.Font("宋体", 15F);
            this.btn_ok.Location = new System.Drawing.Point(164, 144);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(75, 37);
            this.btn_ok.TabIndex = 2;
            this.btn_ok.Text = "确定";
            this.btn_ok.UseVisualStyleBackColor = true;
            // 
            // WinAddBalance
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(434, 212);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.txt_balance);
            this.Controls.Add(this.lbl_balance);
            this.Font = new System.Drawing.Font("宋体", 9F);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WinAddBalance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "填充额度";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_balance;
        private System.Windows.Forms.TextBox txt_balance;
        private System.Windows.Forms.Button btn_ok;
    }
}