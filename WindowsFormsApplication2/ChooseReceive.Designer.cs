namespace WindowsFormsApplication2
{
    partial class ChooseReceive
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
            this.Txt_patientName = new System.Windows.Forms.TextBox();
            this.But_ReceivePresc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Com_RoomNo
            // 
            this.Com_RoomNo.FormattingEnabled = true;
            this.Com_RoomNo.Location = new System.Drawing.Point(117, 42);
            this.Com_RoomNo.Name = "Com_RoomNo";
            this.Com_RoomNo.Size = new System.Drawing.Size(121, 21);
            this.Com_RoomNo.TabIndex = 0;
            this.Com_RoomNo.SelectedIndexChanged += new System.EventHandler(this.Com_RoomNo_SelectedIndexChanged);
            // 
            // Txt_patientName
            // 
            this.Txt_patientName.Enabled = false;
            this.Txt_patientName.Location = new System.Drawing.Point(48, 104);
            this.Txt_patientName.Name = "Txt_patientName";
            this.Txt_patientName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_patientName.Size = new System.Drawing.Size(237, 20);
            this.Txt_patientName.TabIndex = 1;
            this.Txt_patientName.TextChanged += new System.EventHandler(this.Txt_patientName_TextChanged);
            // 
            // But_ReceivePresc
            // 
            this.But_ReceivePresc.Location = new System.Drawing.Point(117, 155);
            this.But_ReceivePresc.Name = "But_ReceivePresc";
            this.But_ReceivePresc.Size = new System.Drawing.Size(109, 37);
            this.But_ReceivePresc.TabIndex = 2;
            this.But_ReceivePresc.Text = "استلام روشته";
            this.But_ReceivePresc.UseVisualStyleBackColor = true;
            this.But_ReceivePresc.Click += new System.EventHandler(this.But_ReceivePresc_Click);
            // 
            // ChooseReceive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 240);
            this.Controls.Add(this.But_ReceivePresc);
            this.Controls.Add(this.Txt_patientName);
            this.Controls.Add(this.Com_RoomNo);
            this.Name = "ChooseReceive";
            this.Text = "ChooseReceive";
            this.Load += new System.EventHandler(this.ChooseReceive_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Com_RoomNo;
        private System.Windows.Forms.TextBox Txt_patientName;
        private System.Windows.Forms.Button But_ReceivePresc;
    }
}