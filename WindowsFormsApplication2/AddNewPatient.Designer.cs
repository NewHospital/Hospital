namespace Hospital
{
    partial class AddNewPatient
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
            this.Txt_PatientName = new System.Windows.Forms.TextBox();
            this.Lbl_PatientName = new System.Windows.Forms.Label();
            this.Lbl_Gender = new System.Windows.Forms.Label();
            this.GenderGroup = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.Pik_DOB = new System.Windows.Forms.DateTimePicker();
            this.Lbl_DOB = new System.Windows.Forms.Label();
            this.Txt_SoSeNo = new System.Windows.Forms.TextBox();
            this.Txt_Mobile = new System.Windows.Forms.TextBox();
            this.Txt_Address = new System.Windows.Forms.TextBox();
            this.Com_BloodGroups = new System.Windows.Forms.ComboBox();
            this.Lbl_SoSeNo = new System.Windows.Forms.Label();
            this.Lbl_BloodGroup = new System.Windows.Forms.Label();
            this.Lbl_Tel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.But_AddPatient = new System.Windows.Forms.Button();
            this.But_AddReservation = new System.Windows.Forms.Button();
            this.But_AddFellow = new System.Windows.Forms.Button();
            this.But_EditPatient = new System.Windows.Forms.Button();
            this.GenderGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // Txt_PatientName
            // 
            this.Txt_PatientName.Location = new System.Drawing.Point(230, 62);
            this.Txt_PatientName.Name = "Txt_PatientName";
            this.Txt_PatientName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_PatientName.Size = new System.Drawing.Size(251, 20);
            this.Txt_PatientName.TabIndex = 0;
            // 
            // Lbl_PatientName
            // 
            this.Lbl_PatientName.AutoSize = true;
            this.Lbl_PatientName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_PatientName.Location = new System.Drawing.Point(507, 62);
            this.Lbl_PatientName.Name = "Lbl_PatientName";
            this.Lbl_PatientName.Size = new System.Drawing.Size(80, 16);
            this.Lbl_PatientName.TabIndex = 1;
            this.Lbl_PatientName.Text = "اسم المريض ";
            // 
            // Lbl_Gender
            // 
            this.Lbl_Gender.AutoSize = true;
            this.Lbl_Gender.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Gender.Location = new System.Drawing.Point(520, 108);
            this.Lbl_Gender.Name = "Lbl_Gender";
            this.Lbl_Gender.Size = new System.Drawing.Size(68, 16);
            this.Lbl_Gender.TabIndex = 2;
            this.Lbl_Gender.Text = "نوع الجنس";
            this.Lbl_Gender.Click += new System.EventHandler(this.label2_Click);
            // 
            // GenderGroup
            // 
            this.GenderGroup.Controls.Add(this.radioButton2);
            this.GenderGroup.Controls.Add(this.radioButton1);
            this.GenderGroup.Location = new System.Drawing.Point(334, 94);
            this.GenderGroup.Name = "GenderGroup";
            this.GenderGroup.Size = new System.Drawing.Size(147, 42);
            this.GenderGroup.TabIndex = 3;
            this.GenderGroup.TabStop = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(12, 16);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(46, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "أنثى";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(95, 16);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(43, 17);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "ذكر ";
            this.radioButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // Pik_DOB
            // 
            this.Pik_DOB.Location = new System.Drawing.Point(279, 161);
            this.Pik_DOB.Name = "Pik_DOB";
            this.Pik_DOB.Size = new System.Drawing.Size(200, 20);
            this.Pik_DOB.TabIndex = 2;
            // 
            // Lbl_DOB
            // 
            this.Lbl_DOB.AutoSize = true;
            this.Lbl_DOB.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_DOB.Location = new System.Drawing.Point(515, 161);
            this.Lbl_DOB.Name = "Lbl_DOB";
            this.Lbl_DOB.Size = new System.Drawing.Size(73, 16);
            this.Lbl_DOB.TabIndex = 4;
            this.Lbl_DOB.Text = "تاريخ الميلاد";
            // 
            // Txt_SoSeNo
            // 
            this.Txt_SoSeNo.Location = new System.Drawing.Point(279, 205);
            this.Txt_SoSeNo.Name = "Txt_SoSeNo";
            this.Txt_SoSeNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_SoSeNo.Size = new System.Drawing.Size(200, 20);
            this.Txt_SoSeNo.TabIndex = 5;
            // 
            // Txt_Mobile
            // 
            this.Txt_Mobile.Location = new System.Drawing.Point(375, 296);
            this.Txt_Mobile.Name = "Txt_Mobile";
            this.Txt_Mobile.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_Mobile.Size = new System.Drawing.Size(100, 20);
            this.Txt_Mobile.TabIndex = 6;
            // 
            // Txt_Address
            // 
            this.Txt_Address.Location = new System.Drawing.Point(114, 341);
            this.Txt_Address.Name = "Txt_Address";
            this.Txt_Address.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_Address.Size = new System.Drawing.Size(361, 20);
            this.Txt_Address.TabIndex = 7;
            // 
            // Com_BloodGroups
            // 
            this.Com_BloodGroups.FormattingEnabled = true;
            this.Com_BloodGroups.Location = new System.Drawing.Point(354, 250);
            this.Com_BloodGroups.Name = "Com_BloodGroups";
            this.Com_BloodGroups.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Com_BloodGroups.Size = new System.Drawing.Size(121, 21);
            this.Com_BloodGroups.TabIndex = 8;
            // 
            // Lbl_SoSeNo
            // 
            this.Lbl_SoSeNo.AutoSize = true;
            this.Lbl_SoSeNo.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_SoSeNo.Location = new System.Drawing.Point(508, 205);
            this.Lbl_SoSeNo.Name = "Lbl_SoSeNo";
            this.Lbl_SoSeNo.Size = new System.Drawing.Size(78, 16);
            this.Lbl_SoSeNo.TabIndex = 9;
            this.Lbl_SoSeNo.Text = "الرقم القومي";
            // 
            // Lbl_BloodGroup
            // 
            this.Lbl_BloodGroup.AutoSize = true;
            this.Lbl_BloodGroup.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_BloodGroup.Location = new System.Drawing.Point(519, 252);
            this.Lbl_BloodGroup.Name = "Lbl_BloodGroup";
            this.Lbl_BloodGroup.Size = new System.Drawing.Size(66, 16);
            this.Lbl_BloodGroup.TabIndex = 10;
            this.Lbl_BloodGroup.Text = "فصيلة الدم";
            // 
            // Lbl_Tel
            // 
            this.Lbl_Tel.AutoSize = true;
            this.Lbl_Tel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Tel.Location = new System.Drawing.Point(541, 296);
            this.Lbl_Tel.Name = "Lbl_Tel";
            this.Lbl_Tel.Size = new System.Drawing.Size(42, 16);
            this.Lbl_Tel.TabIndex = 11;
            this.Lbl_Tel.Text = "موبايل";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(538, 342);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 16);
            this.label7.TabIndex = 12;
            this.label7.Text = "العنوان";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Traditional Arabic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label8.Location = new System.Drawing.Point(191, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(184, 37);
            this.label8.TabIndex = 13;
            this.label8.Text = "البيانات الأساسية للمريض";
            // 
            // But_AddPatient
            // 
            this.But_AddPatient.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.But_AddPatient.Location = new System.Drawing.Point(248, 396);
            this.But_AddPatient.Name = "But_AddPatient";
            this.But_AddPatient.Size = new System.Drawing.Size(144, 36);
            this.But_AddPatient.TabIndex = 15;
            this.But_AddPatient.Text = "إضافة مريض";
            this.But_AddPatient.UseVisualStyleBackColor = true;
            this.But_AddPatient.Click += new System.EventHandler(this.But_AddPatient_Click);
            // 
            // But_AddReservation
            // 
            this.But_AddReservation.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.But_AddReservation.Location = new System.Drawing.Point(12, 379);
            this.But_AddReservation.Name = "But_AddReservation";
            this.But_AddReservation.Size = new System.Drawing.Size(144, 36);
            this.But_AddReservation.TabIndex = 16;
            this.But_AddReservation.Text = "إضافة حجز";
            this.But_AddReservation.UseVisualStyleBackColor = true;
            this.But_AddReservation.Click += new System.EventHandler(this.But_AddReservation_Click);
            // 
            // But_AddFellow
            // 
            this.But_AddFellow.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.But_AddFellow.Location = new System.Drawing.Point(82, 396);
            this.But_AddFellow.Name = "But_AddFellow";
            this.But_AddFellow.Size = new System.Drawing.Size(144, 36);
            this.But_AddFellow.TabIndex = 17;
            this.But_AddFellow.Text = "إضافة مرافق";
            this.But_AddFellow.UseVisualStyleBackColor = true;
            this.But_AddFellow.Click += new System.EventHandler(this.But_AddFellow_Click);
            // 
            // But_EditPatient
            // 
            this.But_EditPatient.Location = new System.Drawing.Point(232, 379);
            this.But_EditPatient.Name = "But_EditPatient";
            this.But_EditPatient.Size = new System.Drawing.Size(144, 36);
            this.But_EditPatient.TabIndex = 18;
            this.But_EditPatient.Text = "تعديل بيانات مريض";
            this.But_EditPatient.UseVisualStyleBackColor = true;
            this.But_EditPatient.Visible = false;
            this.But_EditPatient.Click += new System.EventHandler(this.But_EditPatient_Click);
            // 
            // AddNewPatient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 466);
            this.Controls.Add(this.But_EditPatient);
            this.Controls.Add(this.But_AddFellow);
            this.Controls.Add(this.But_AddReservation);
            this.Controls.Add(this.But_AddPatient);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.Lbl_Tel);
            this.Controls.Add(this.Lbl_BloodGroup);
            this.Controls.Add(this.Lbl_SoSeNo);
            this.Controls.Add(this.Com_BloodGroups);
            this.Controls.Add(this.Txt_Address);
            this.Controls.Add(this.Txt_Mobile);
            this.Controls.Add(this.Txt_SoSeNo);
            this.Controls.Add(this.Lbl_DOB);
            this.Controls.Add(this.Pik_DOB);
            this.Controls.Add(this.GenderGroup);
            this.Controls.Add(this.Lbl_Gender);
            this.Controls.Add(this.Lbl_PatientName);
            this.Controls.Add(this.Txt_PatientName);
            this.Name = "AddNewPatient";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إضافة مريض جديد";
            this.Load += new System.EventHandler(this.AddNewPatient_Load);
            this.GenderGroup.ResumeLayout(false);
            this.GenderGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_PatientName;
        private System.Windows.Forms.Label Lbl_PatientName;
        private System.Windows.Forms.Label Lbl_Gender;
        private System.Windows.Forms.GroupBox GenderGroup;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.DateTimePicker Pik_DOB;
        private System.Windows.Forms.Label Lbl_DOB;
        private System.Windows.Forms.TextBox Txt_SoSeNo;
        private System.Windows.Forms.TextBox Txt_Mobile;
        private System.Windows.Forms.TextBox Txt_Address;
        private System.Windows.Forms.ComboBox Com_BloodGroups;
        private System.Windows.Forms.Label Lbl_SoSeNo;
        private System.Windows.Forms.Label Lbl_BloodGroup;
        private System.Windows.Forms.Label Lbl_Tel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button But_AddPatient;
        private System.Windows.Forms.Button But_AddReservation;
        private System.Windows.Forms.Button But_AddFellow;
        private System.Windows.Forms.Button But_EditPatient;
    }
}