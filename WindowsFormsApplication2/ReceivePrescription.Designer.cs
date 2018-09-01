namespace WindowsFormsApplication2
{
    partial class ReceivePrescription
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
            this.Txt_patientName = new System.Windows.Forms.TextBox();
            this.But_receive = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Txt_patientName
            // 
            this.Txt_patientName.Enabled = false;
            this.Txt_patientName.Location = new System.Drawing.Point(126, 24);
            this.Txt_patientName.Name = "Txt_patientName";
            this.Txt_patientName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_patientName.Size = new System.Drawing.Size(236, 20);
            this.Txt_patientName.TabIndex = 1;
            // 
            // But_receive
            // 
            this.But_receive.Location = new System.Drawing.Point(207, 228);
            this.But_receive.Name = "But_receive";
            this.But_receive.Size = new System.Drawing.Size(75, 23);
            this.But_receive.TabIndex = 2;
            this.But_receive.Text = "تسليم";
            this.But_receive.UseVisualStyleBackColor = true;
            this.But_receive.Visible = false;
            this.But_receive.Click += new System.EventHandler(this.But_receive_Click);
            // 
            // ReceivePrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(514, 475);
            this.Controls.Add(this.But_receive);
            this.Controls.Add(this.Txt_patientName);
            this.Name = "ReceivePrescription";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "استلام روشته";
            this.Load += new System.EventHandler(this.ReceivePrescription_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Txt_patientName;
        private System.Windows.Forms.Button But_receive;
    }
}