namespace dz_manager
{
    partial class WinDeskManager
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
            this.flp_desk_manager = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flp_desk_manager
            // 
            this.flp_desk_manager.Location = new System.Drawing.Point(42, 26);
            this.flp_desk_manager.Name = "flp_desk_manager";
            this.flp_desk_manager.Size = new System.Drawing.Size(935, 457);
            this.flp_desk_manager.TabIndex = 0;
            // 
            // WinDeskManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 514);
            this.Controls.Add(this.flp_desk_manager);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WinDeskManager";
            this.Text = "牌桌管理";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flp_desk_manager;
    }
}