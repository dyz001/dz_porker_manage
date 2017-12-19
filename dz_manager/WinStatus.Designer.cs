namespace dz_manager
{
    partial class WinStatus
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
            this.lbl_status = new System.Windows.Forms.Label();
            this.gpb_frame = new System.Windows.Forms.GroupBox();
            this.gpb_frame.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_status
            // 
            this.lbl_status.AutoSize = true;
            this.lbl_status.Location = new System.Drawing.Point(22, 26);
            this.lbl_status.Name = "lbl_status";
            this.lbl_status.Size = new System.Drawing.Size(41, 12);
            this.lbl_status.TabIndex = 0;
            this.lbl_status.Text = "label1";
            // 
            // gpb_frame
            // 
            this.gpb_frame.Controls.Add(this.lbl_status);
            this.gpb_frame.Location = new System.Drawing.Point(12, 9);
            this.gpb_frame.Name = "gpb_frame";
            this.gpb_frame.Size = new System.Drawing.Size(395, 62);
            this.gpb_frame.TabIndex = 1;
            this.gpb_frame.TabStop = false;
            // 
            // WinStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 87);
            this.ControlBox = false;
            this.Controls.Add(this.gpb_frame);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WinStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "WinStatus";
            this.Load += new System.EventHandler(this.WinStatus_Load);
            this.gpb_frame.ResumeLayout(false);
            this.gpb_frame.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_status;
        private System.Windows.Forms.GroupBox gpb_frame;
    }
}