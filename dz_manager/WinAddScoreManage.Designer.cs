namespace dz_manager
{
    partial class WinAddScoreManage
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
            this.lbl_desk_no = new System.Windows.Forms.Label();
            this.txt_desk_no = new System.Windows.Forms.TextBox();
            this.lbl_game_id = new System.Windows.Forms.Label();
            this.txt_game_id = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_desk_no
            // 
            this.lbl_desk_no.AutoSize = true;
            this.lbl_desk_no.Location = new System.Drawing.Point(59, 57);
            this.lbl_desk_no.Name = "lbl_desk_no";
            this.lbl_desk_no.Size = new System.Drawing.Size(53, 12);
            this.lbl_desk_no.TabIndex = 0;
            this.lbl_desk_no.Text = "牌桌号：";
            // 
            // txt_desk_no
            // 
            this.txt_desk_no.Location = new System.Drawing.Point(119, 57);
            this.txt_desk_no.Name = "txt_desk_no";
            this.txt_desk_no.Size = new System.Drawing.Size(100, 21);
            this.txt_desk_no.TabIndex = 1;
            // 
            // lbl_game_id
            // 
            this.lbl_game_id.AutoSize = true;
            this.lbl_game_id.Location = new System.Drawing.Point(262, 65);
            this.lbl_game_id.Name = "lbl_game_id";
            this.lbl_game_id.Size = new System.Drawing.Size(65, 12);
            this.lbl_game_id.TabIndex = 2;
            this.lbl_game_id.Text = "游戏编号：";
            // 
            // txt_game_id
            // 
            this.txt_game_id.Location = new System.Drawing.Point(366, 65);
            this.txt_game_id.Name = "txt_game_id";
            this.txt_game_id.Size = new System.Drawing.Size(100, 21);
            this.txt_game_id.TabIndex = 3;
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(534, 62);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 4;
            this.btn_search.Text = "查询";
            this.btn_search.UseVisualStyleBackColor = true;
            // 
            // WinAddScoreManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 394);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.txt_game_id);
            this.Controls.Add(this.lbl_game_id);
            this.Controls.Add(this.txt_desk_no);
            this.Controls.Add(this.lbl_desk_no);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WinAddScoreManage";
            this.Text = "上分管理";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_desk_no;
        private System.Windows.Forms.TextBox txt_desk_no;
        private System.Windows.Forms.Label lbl_game_id;
        private System.Windows.Forms.TextBox txt_game_id;
        private System.Windows.Forms.Button btn_search;
    }
}