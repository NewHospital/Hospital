namespace WindowsFormsApplication2
{
    partial class DocFollowUp
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
            this.Com_RoomsNo = new System.Windows.Forms.ComboBox();
            this.Lbl_RoomNo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Com_RoomsNo
            // 
            this.Com_RoomsNo.FormattingEnabled = true;
            this.Com_RoomsNo.Location = new System.Drawing.Point(93, 59);
            this.Com_RoomsNo.Name = "Com_RoomsNo";
            this.Com_RoomsNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Com_RoomsNo.Size = new System.Drawing.Size(148, 21);
            this.Com_RoomsNo.TabIndex = 0;
            // 
            // Lbl_RoomNo
            // 
            this.Lbl_RoomNo.AutoSize = true;
            this.Lbl_RoomNo.Location = new System.Drawing.Point(281, 62);
            this.Lbl_RoomNo.Name = "Lbl_RoomNo";
            this.Lbl_RoomNo.Size = new System.Drawing.Size(55, 13);
            this.Lbl_RoomNo.TabIndex = 1;
            this.Lbl_RoomNo.Text = "رقم الغرفة";
            // 
            // DocFollowUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 335);
            this.Controls.Add(this.Lbl_RoomNo);
            this.Controls.Add(this.Com_RoomsNo);
            this.Name = "DocFollowUp";
            this.Text = "DocFollowUp";
            this.Load += new System.EventHandler(this.DocFollowUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Com_RoomsNo;
        private System.Windows.Forms.Label Lbl_RoomNo;
    }
}