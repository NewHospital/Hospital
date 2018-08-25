namespace WindowsFormsApplication2
{
    partial class Payments
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
            this.label1 = new System.Windows.Forms.Label();
            this.Com_RoomNo = new System.Windows.Forms.ComboBox();
            this.Txt_PatientName = new System.Windows.Forms.TextBox();
            this.Txt_arriveDate = new System.Windows.Forms.TextBox();
            this.Txt_amount = new System.Windows.Forms.TextBox();
            this.Txt_Discription = new System.Windows.Forms.TextBox();
            this.But_Receive = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "استلام نقدية ";
            // 
            // Com_RoomNo
            // 
            this.Com_RoomNo.FormattingEnabled = true;
            this.Com_RoomNo.Location = new System.Drawing.Point(215, 47);
            this.Com_RoomNo.Name = "Com_RoomNo";
            this.Com_RoomNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Com_RoomNo.Size = new System.Drawing.Size(102, 21);
            this.Com_RoomNo.TabIndex = 1;
            this.Com_RoomNo.SelectedValueChanged += new System.EventHandler(this.Com_RoomNo_SelectedValueChanged);
            // 
            // Txt_PatientName
            // 
            this.Txt_PatientName.Enabled = false;
            this.Txt_PatientName.Location = new System.Drawing.Point(83, 91);
            this.Txt_PatientName.Name = "Txt_PatientName";
            this.Txt_PatientName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_PatientName.Size = new System.Drawing.Size(234, 20);
            this.Txt_PatientName.TabIndex = 2;
            // 
            // Txt_arriveDate
            // 
            this.Txt_arriveDate.Enabled = false;
            this.Txt_arriveDate.Location = new System.Drawing.Point(168, 134);
            this.Txt_arriveDate.Name = "Txt_arriveDate";
            this.Txt_arriveDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_arriveDate.Size = new System.Drawing.Size(149, 20);
            this.Txt_arriveDate.TabIndex = 3;
            // 
            // Txt_amount
            // 
            this.Txt_amount.Enabled = false;
            this.Txt_amount.Location = new System.Drawing.Point(228, 177);
            this.Txt_amount.Name = "Txt_amount";
            this.Txt_amount.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_amount.Size = new System.Drawing.Size(89, 20);
            this.Txt_amount.TabIndex = 4;
            // 
            // Txt_Discription
            // 
            this.Txt_Discription.Enabled = false;
            this.Txt_Discription.Location = new System.Drawing.Point(83, 220);
            this.Txt_Discription.Name = "Txt_Discription";
            this.Txt_Discription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_Discription.Size = new System.Drawing.Size(232, 20);
            this.Txt_Discription.TabIndex = 5;
            // 
            // But_Receive
            // 
            this.But_Receive.Location = new System.Drawing.Point(113, 283);
            this.But_Receive.Name = "But_Receive";
            this.But_Receive.Size = new System.Drawing.Size(164, 43);
            this.But_Receive.TabIndex = 6;
            this.But_Receive.Text = "استلام";
            this.But_Receive.UseVisualStyleBackColor = true;
            this.But_Receive.Click += new System.EventHandler(this.But_Receive_Click);
            this.But_Receive.MouseHover += new System.EventHandler(this.But_Receive_MouseHover);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(342, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "الغرفة رقم";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(328, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "اسم المريض ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(335, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "تاريخ الدخول";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(324, 181);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "المبلغ المدفوع";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(349, 224);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "ملاحظات";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(178, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "label7";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(15, 181);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 16);
            this.label8.TabIndex = 13;
            this.label8.Text = "label8";
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(102, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "label9";
            this.label9.Visible = false;
            // 
            // Payments
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 365);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.But_Receive);
            this.Controls.Add(this.Txt_Discription);
            this.Controls.Add(this.Txt_amount);
            this.Controls.Add(this.Txt_arriveDate);
            this.Controls.Add(this.Txt_PatientName);
            this.Controls.Add(this.Com_RoomNo);
            this.Controls.Add(this.label1);
            this.Name = "Payments";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مدفوعات";
            this.Load += new System.EventHandler(this.Payments_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Com_RoomNo;
        private System.Windows.Forms.TextBox Txt_PatientName;
        private System.Windows.Forms.TextBox Txt_arriveDate;
        private System.Windows.Forms.TextBox Txt_amount;
        private System.Windows.Forms.TextBox Txt_Discription;
        private System.Windows.Forms.Button But_Receive;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}