namespace WindowsFormsApplication2
{
    partial class AddReservation
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
            this.Lbl_PatientName = new System.Windows.Forms.Label();
            this.Com_Room = new System.Windows.Forms.ComboBox();
            this.Lbl_roomNo = new System.Windows.Forms.Label();
            this.Pick_arriveDate = new System.Windows.Forms.DateTimePicker();
            this.Lbl_arriveDate = new System.Windows.Forms.Label();
            this.RTxt_Remarks = new System.Windows.Forms.RichTextBox();
            this.Lbl_remarks = new System.Windows.Forms.Label();
            this.But_Addreservation = new System.Windows.Forms.Button();
            this.Lbl_ensureReservation = new System.Windows.Forms.Label();
            this.Lbl_Degree = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Lbl_PatientName
            // 
            this.Lbl_PatientName.AutoSize = true;
            this.Lbl_PatientName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_PatientName.Location = new System.Drawing.Point(95, 28);
            this.Lbl_PatientName.Name = "Lbl_PatientName";
            this.Lbl_PatientName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_PatientName.Size = new System.Drawing.Size(0, 19);
            this.Lbl_PatientName.TabIndex = 0;
            // 
            // Com_Room
            // 
            this.Com_Room.FormattingEnabled = true;
            this.Com_Room.Location = new System.Drawing.Point(178, 70);
            this.Com_Room.Name = "Com_Room";
            this.Com_Room.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Com_Room.Size = new System.Drawing.Size(131, 21);
            this.Com_Room.TabIndex = 1;
            this.Com_Room.SelectedIndexChanged += new System.EventHandler(this.Com_Room_SelectedIndexChanged);
            this.Com_Room.DisplayMemberChanged += new System.EventHandler(this.Com_Room_DisplayMemberChanged);
            this.Com_Room.SelectedValueChanged += new System.EventHandler(this.Com_Room_SelectedValueChanged);
            // 
            // Lbl_roomNo
            // 
            this.Lbl_roomNo.AutoSize = true;
            this.Lbl_roomNo.Location = new System.Drawing.Point(348, 70);
            this.Lbl_roomNo.Name = "Lbl_roomNo";
            this.Lbl_roomNo.Size = new System.Drawing.Size(55, 13);
            this.Lbl_roomNo.TabIndex = 3;
            this.Lbl_roomNo.Text = "الغرفة رقم";
            // 
            // Pick_arriveDate
            // 
            this.Pick_arriveDate.Location = new System.Drawing.Point(144, 125);
            this.Pick_arriveDate.Name = "Pick_arriveDate";
            this.Pick_arriveDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Pick_arriveDate.Size = new System.Drawing.Size(165, 20);
            this.Pick_arriveDate.TabIndex = 4;
            // 
            // Lbl_arriveDate
            // 
            this.Lbl_arriveDate.AutoSize = true;
            this.Lbl_arriveDate.Location = new System.Drawing.Point(340, 125);
            this.Lbl_arriveDate.Name = "Lbl_arriveDate";
            this.Lbl_arriveDate.Size = new System.Drawing.Size(63, 13);
            this.Lbl_arriveDate.TabIndex = 5;
            this.Lbl_arriveDate.Text = "تاريخ الوصول";
            // 
            // RTxt_Remarks
            // 
            this.RTxt_Remarks.Location = new System.Drawing.Point(32, 179);
            this.RTxt_Remarks.Name = "RTxt_Remarks";
            this.RTxt_Remarks.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RTxt_Remarks.Size = new System.Drawing.Size(277, 96);
            this.RTxt_Remarks.TabIndex = 7;
            this.RTxt_Remarks.Text = "";
            // 
            // Lbl_remarks
            // 
            this.Lbl_remarks.AutoSize = true;
            this.Lbl_remarks.Location = new System.Drawing.Point(352, 179);
            this.Lbl_remarks.Name = "Lbl_remarks";
            this.Lbl_remarks.Size = new System.Drawing.Size(51, 13);
            this.Lbl_remarks.TabIndex = 8;
            this.Lbl_remarks.Text = "ملاحظات ";
            // 
            // But_Addreservation
            // 
            this.But_Addreservation.Location = new System.Drawing.Point(120, 318);
            this.But_Addreservation.Name = "But_Addreservation";
            this.But_Addreservation.Size = new System.Drawing.Size(154, 35);
            this.But_Addreservation.TabIndex = 9;
            this.But_Addreservation.Text = "تأكيد الحجز";
            this.But_Addreservation.UseVisualStyleBackColor = true;
            this.But_Addreservation.Click += new System.EventHandler(this.But_Addreservation_Click);
            // 
            // Lbl_ensureReservation
            // 
            this.Lbl_ensureReservation.AutoSize = true;
            this.Lbl_ensureReservation.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_ensureReservation.Location = new System.Drawing.Point(257, 28);
            this.Lbl_ensureReservation.Name = "Lbl_ensureReservation";
            this.Lbl_ensureReservation.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_ensureReservation.Size = new System.Drawing.Size(150, 19);
            this.Lbl_ensureReservation.TabIndex = 10;
            this.Lbl_ensureReservation.Text = "تأكيد حجز للمريض:";
            // 
            // Lbl_Degree
            // 
            this.Lbl_Degree.AutoSize = true;
            this.Lbl_Degree.Location = new System.Drawing.Point(117, 70);
            this.Lbl_Degree.Name = "Lbl_Degree";
            this.Lbl_Degree.Size = new System.Drawing.Size(0, 13);
            this.Lbl_Degree.TabIndex = 11;
            // 
            // AddReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(428, 401);
            this.Controls.Add(this.Lbl_Degree);
            this.Controls.Add(this.Lbl_ensureReservation);
            this.Controls.Add(this.But_Addreservation);
            this.Controls.Add(this.Lbl_remarks);
            this.Controls.Add(this.RTxt_Remarks);
            this.Controls.Add(this.Lbl_arriveDate);
            this.Controls.Add(this.Pick_arriveDate);
            this.Controls.Add(this.Lbl_roomNo);
            this.Controls.Add(this.Com_Room);
            this.Controls.Add(this.Lbl_PatientName);
            this.Name = "AddReservation";
            this.Text = "إضافة حجز";
            this.Load += new System.EventHandler(this.AddReservation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_PatientName;
        private System.Windows.Forms.ComboBox Com_Room;
        private System.Windows.Forms.Label Lbl_roomNo;
        private System.Windows.Forms.DateTimePicker Pick_arriveDate;
        private System.Windows.Forms.Label Lbl_arriveDate;
        private System.Windows.Forms.RichTextBox RTxt_Remarks;
        private System.Windows.Forms.Label Lbl_remarks;
        private System.Windows.Forms.Button But_Addreservation;
        private System.Windows.Forms.Label Lbl_ensureReservation;
        private System.Windows.Forms.Label Lbl_Degree;
    }
}