namespace WindowsFormsApplication2
{
    partial class DoctorFollowUp
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
            this.Com_RoomNo = new System.Windows.Forms.ComboBox();
            this.lbl_RoomNo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Com_RoomNo
            // 
            this.Com_RoomNo.FormattingEnabled = true;
            this.Com_RoomNo.Location = new System.Drawing.Point(123, 63);
            this.Com_RoomNo.Name = "Com_RoomNo";
            this.Com_RoomNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Com_RoomNo.Size = new System.Drawing.Size(160, 21);
            this.Com_RoomNo.TabIndex = 0;
            // 
            // lbl_RoomNo
            // 
            this.lbl_RoomNo.AutoSize = true;
            this.lbl_RoomNo.Location = new System.Drawing.Point(357, 66);
            this.lbl_RoomNo.Name = "lbl_RoomNo";
            this.lbl_RoomNo.Size = new System.Drawing.Size(55, 13);
            this.lbl_RoomNo.TabIndex = 1;
            this.lbl_RoomNo.Text = "رقم الغرفة";
            // 
            // DoctorFollowUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 357);
            this.Controls.Add(this.lbl_RoomNo);
            this.Controls.Add(this.Com_RoomNo);
            this.Name = "DoctorFollowUp";
            this.Text = "DoctorFollowUp";
            this.Load += new System.EventHandler(this.DoctorFollowUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Com_RoomNo;
        private System.Windows.Forms.Label lbl_RoomNo;
    }
}