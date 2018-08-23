namespace WindowsFormsApplication2
{
    partial class AddNewDoctor
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
            this.But_AddDoc = new System.Windows.Forms.Button();
            this.Txt_DocName = new System.Windows.Forms.TextBox();
            this.Txt_DoCAddress = new System.Windows.Forms.TextBox();
            this.Txt_DocTel = new System.Windows.Forms.TextBox();
            this.Rad_Male = new System.Windows.Forms.RadioButton();
            this.Rad_Female = new System.Windows.Forms.RadioButton();
            this.Gro_AddDoc = new System.Windows.Forms.GroupBox();
            this.Com_Degree = new System.Windows.Forms.ComboBox();
            this.Com_Specification = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.Gro_AddDoc.SuspendLayout();
            this.SuspendLayout();
            // 
            // But_AddDoc
            // 
            this.But_AddDoc.Location = new System.Drawing.Point(235, 284);
            this.But_AddDoc.Name = "But_AddDoc";
            this.But_AddDoc.Size = new System.Drawing.Size(122, 44);
            this.But_AddDoc.TabIndex = 0;
            this.But_AddDoc.Text = "إضافة طبيب";
            this.But_AddDoc.UseVisualStyleBackColor = true;
            this.But_AddDoc.Click += new System.EventHandler(this.But_AddDoc_Click);
            // 
            // Txt_DocName
            // 
            this.Txt_DocName.Location = new System.Drawing.Point(272, 78);
            this.Txt_DocName.Name = "Txt_DocName";
            this.Txt_DocName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_DocName.Size = new System.Drawing.Size(207, 20);
            this.Txt_DocName.TabIndex = 1;
            // 
            // Txt_DoCAddress
            // 
            this.Txt_DoCAddress.Location = new System.Drawing.Point(194, 124);
            this.Txt_DoCAddress.Name = "Txt_DoCAddress";
            this.Txt_DoCAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_DoCAddress.Size = new System.Drawing.Size(285, 20);
            this.Txt_DoCAddress.TabIndex = 2;
            // 
            // Txt_DocTel
            // 
            this.Txt_DocTel.Location = new System.Drawing.Point(379, 170);
            this.Txt_DocTel.Name = "Txt_DocTel";
            this.Txt_DocTel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_DocTel.Size = new System.Drawing.Size(100, 20);
            this.Txt_DocTel.TabIndex = 4;
            // 
            // Rad_Male
            // 
            this.Rad_Male.AutoSize = true;
            this.Rad_Male.Checked = true;
            this.Rad_Male.Location = new System.Drawing.Point(79, 18);
            this.Rad_Male.Name = "Rad_Male";
            this.Rad_Male.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Rad_Male.Size = new System.Drawing.Size(40, 17);
            this.Rad_Male.TabIndex = 5;
            this.Rad_Male.TabStop = true;
            this.Rad_Male.Text = "ذكر";
            this.Rad_Male.UseVisualStyleBackColor = true;
            // 
            // Rad_Female
            // 
            this.Rad_Female.AutoSize = true;
            this.Rad_Female.Location = new System.Drawing.Point(6, 18);
            this.Rad_Female.Name = "Rad_Female";
            this.Rad_Female.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Rad_Female.Size = new System.Drawing.Size(46, 17);
            this.Rad_Female.TabIndex = 6;
            this.Rad_Female.Text = "أنثى";
            this.Rad_Female.UseVisualStyleBackColor = true;
            // 
            // Gro_AddDoc
            // 
            this.Gro_AddDoc.Controls.Add(this.Rad_Female);
            this.Gro_AddDoc.Controls.Add(this.Rad_Male);
            this.Gro_AddDoc.Location = new System.Drawing.Point(43, 60);
            this.Gro_AddDoc.Name = "Gro_AddDoc";
            this.Gro_AddDoc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Gro_AddDoc.Size = new System.Drawing.Size(140, 45);
            this.Gro_AddDoc.TabIndex = 7;
            this.Gro_AddDoc.TabStop = false;
            this.Gro_AddDoc.Text = "نوع الجنس";
            // 
            // Com_Degree
            // 
            this.Com_Degree.FormattingEnabled = true;
            this.Com_Degree.Location = new System.Drawing.Point(52, 216);
            this.Com_Degree.Name = "Com_Degree";
            this.Com_Degree.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Com_Degree.Size = new System.Drawing.Size(121, 21);
            this.Com_Degree.TabIndex = 0;
            // 
            // Com_Specification
            // 
            this.Com_Specification.FormattingEnabled = true;
            this.Com_Specification.Location = new System.Drawing.Point(304, 216);
            this.Com_Specification.Name = "Com_Specification";
            this.Com_Specification.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Com_Specification.Size = new System.Drawing.Size(175, 21);
            this.Com_Specification.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(513, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "اسم الطبيب";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(513, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "عنوان الطبيب";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(513, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "رقم الهاتف";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(513, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "التخصص";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(187, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "الدرجة العلمية";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(164, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(193, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "إضافة بيانات طبيب";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(272, 216);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(26, 23);
            this.button2.TabIndex = 50;
            this.button2.Text = "+";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(160)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(23, 216);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(23, 21);
            this.button1.TabIndex = 51;
            this.button1.Text = "+";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddNewDoctor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 366);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Com_Specification);
            this.Controls.Add(this.Com_Degree);
            this.Controls.Add(this.Gro_AddDoc);
            this.Controls.Add(this.Txt_DocTel);
            this.Controls.Add(this.Txt_DoCAddress);
            this.Controls.Add(this.Txt_DocName);
            this.Controls.Add(this.But_AddDoc);
            this.Name = "AddNewDoctor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إضافة بيانات طبيب";
            this.Load += new System.EventHandler(this.AddNewDoctor_Load);
            this.Gro_AddDoc.ResumeLayout(false);
            this.Gro_AddDoc.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button But_AddDoc;
        private System.Windows.Forms.TextBox Txt_DocName;
        private System.Windows.Forms.TextBox Txt_DoCAddress;
        private System.Windows.Forms.TextBox Txt_DocTel;
        private System.Windows.Forms.RadioButton Rad_Male;
        private System.Windows.Forms.RadioButton Rad_Female;
        private System.Windows.Forms.GroupBox Gro_AddDoc;
        private System.Windows.Forms.ComboBox Com_Degree;
        private System.Windows.Forms.ComboBox Com_Specification;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}