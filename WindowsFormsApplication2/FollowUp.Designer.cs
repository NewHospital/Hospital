namespace WindowsFormsApplication2
{
    partial class FollowUp
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
            this.Lbl_roomNo = new System.Windows.Forms.Label();
            this.Ch_Doctors = new System.Windows.Forms.CheckedListBox();
            this.But_AddFollow = new System.Windows.Forms.Button();
            this.Txt_patientName = new System.Windows.Forms.TextBox();
            this.Lbl_patientName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Com_RoomNo
            // 
            this.Com_RoomNo.FormattingEnabled = true;
            this.Com_RoomNo.Location = new System.Drawing.Point(210, 28);
            this.Com_RoomNo.Name = "Com_RoomNo";
            this.Com_RoomNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Com_RoomNo.Size = new System.Drawing.Size(79, 21);
            this.Com_RoomNo.TabIndex = 0;
            this.Com_RoomNo.SelectionChangeCommitted += new System.EventHandler(this.Com_RoomNo_SelectionChangeCommitted);
            this.Com_RoomNo.SelectedValueChanged += new System.EventHandler(this.Com_RoomNo_SelectedValueChanged);
            // 
            // Lbl_roomNo
            // 
            this.Lbl_roomNo.AutoSize = true;
            this.Lbl_roomNo.Location = new System.Drawing.Point(302, 31);
            this.Lbl_roomNo.Name = "Lbl_roomNo";
            this.Lbl_roomNo.Size = new System.Drawing.Size(55, 13);
            this.Lbl_roomNo.TabIndex = 1;
            this.Lbl_roomNo.Text = "رقم الغرفة";
            // 
            // Ch_Doctors
            // 
            this.Ch_Doctors.FormattingEnabled = true;
            this.Ch_Doctors.Location = new System.Drawing.Point(61, 125);
            this.Ch_Doctors.Name = "Ch_Doctors";
            this.Ch_Doctors.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Ch_Doctors.Size = new System.Drawing.Size(291, 94);
            this.Ch_Doctors.TabIndex = 2;
            this.Ch_Doctors.SelectedValueChanged += new System.EventHandler(this.Ch_Doctors_SelectedValueChanged);
            // 
            // But_AddFollow
            // 
            this.But_AddFollow.Location = new System.Drawing.Point(138, 239);
            this.But_AddFollow.Name = "But_AddFollow";
            this.But_AddFollow.Size = new System.Drawing.Size(149, 42);
            this.But_AddFollow.TabIndex = 3;
            this.But_AddFollow.Text = "إضافة متابعات";
            this.But_AddFollow.UseVisualStyleBackColor = true;
            this.But_AddFollow.Click += new System.EventHandler(this.But_AddFollow_Click);
            // 
            // Txt_patientName
            // 
            this.Txt_patientName.Enabled = false;
            this.Txt_patientName.Location = new System.Drawing.Point(65, 85);
            this.Txt_patientName.Name = "Txt_patientName";
            this.Txt_patientName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_patientName.Size = new System.Drawing.Size(224, 20);
            this.Txt_patientName.TabIndex = 4;
            // 
            // Lbl_patientName
            // 
            this.Lbl_patientName.AutoSize = true;
            this.Lbl_patientName.Location = new System.Drawing.Point(291, 88);
            this.Lbl_patientName.Name = "Lbl_patientName";
            this.Lbl_patientName.Size = new System.Drawing.Size(66, 13);
            this.Lbl_patientName.TabIndex = 5;
            this.Lbl_patientName.Text = "اسم المريض";
            // 
            // FollowUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 330);
            this.Controls.Add(this.Lbl_patientName);
            this.Controls.Add(this.Txt_patientName);
            this.Controls.Add(this.But_AddFollow);
            this.Controls.Add(this.Ch_Doctors);
            this.Controls.Add(this.Lbl_roomNo);
            this.Controls.Add(this.Com_RoomNo);
            this.Name = "FollowUp";
            this.Text = "متابعات المرضى";
            this.Load += new System.EventHandler(this.FollowUp_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Com_RoomNo;
        private System.Windows.Forms.Label Lbl_roomNo;
        private System.Windows.Forms.CheckedListBox Ch_Doctors;
        private System.Windows.Forms.Button But_AddFollow;
        private System.Windows.Forms.TextBox Txt_patientName;
        private System.Windows.Forms.Label Lbl_patientName;
    }
}