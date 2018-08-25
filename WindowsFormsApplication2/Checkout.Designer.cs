namespace WindowsFormsApplication2
{
    partial class Checkout
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
            this.But_CheckOut = new System.Windows.Forms.Button();
            this.Com_RoomNo = new System.Windows.Forms.ComboBox();
            this.Txt_PatientName = new System.Windows.Forms.TextBox();
            this.Txt_Arrival = new System.Windows.Forms.TextBox();
            this.Txt_TotalPaid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Txt_Remarks = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // But_CheckOut
            // 
            this.But_CheckOut.Location = new System.Drawing.Point(149, 240);
            this.But_CheckOut.Name = "But_CheckOut";
            this.But_CheckOut.Size = new System.Drawing.Size(229, 48);
            this.But_CheckOut.TabIndex = 0;
            this.But_CheckOut.Text = "تسجيل الخروج";
            this.But_CheckOut.UseVisualStyleBackColor = true;
            this.But_CheckOut.Click += new System.EventHandler(this.button1_Click);
            this.But_CheckOut.MouseHover += new System.EventHandler(this.But_CheckOut_MouseHover);
            // 
            // Com_RoomNo
            // 
            this.Com_RoomNo.FormattingEnabled = true;
            this.Com_RoomNo.Location = new System.Drawing.Point(375, 53);
            this.Com_RoomNo.Name = "Com_RoomNo";
            this.Com_RoomNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Com_RoomNo.Size = new System.Drawing.Size(67, 21);
            this.Com_RoomNo.TabIndex = 1;
            this.Com_RoomNo.SelectedValueChanged += new System.EventHandler(this.Com_RoomNo_SelectedValueChanged);
            // 
            // Txt_PatientName
            // 
            this.Txt_PatientName.Enabled = false;
            this.Txt_PatientName.Location = new System.Drawing.Point(58, 53);
            this.Txt_PatientName.Name = "Txt_PatientName";
            this.Txt_PatientName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_PatientName.Size = new System.Drawing.Size(234, 20);
            this.Txt_PatientName.TabIndex = 2;
            // 
            // Txt_Arrival
            // 
            this.Txt_Arrival.Enabled = false;
            this.Txt_Arrival.Location = new System.Drawing.Point(258, 110);
            this.Txt_Arrival.Name = "Txt_Arrival";
            this.Txt_Arrival.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_Arrival.Size = new System.Drawing.Size(184, 20);
            this.Txt_Arrival.TabIndex = 3;
            // 
            // Txt_TotalPaid
            // 
            this.Txt_TotalPaid.Enabled = false;
            this.Txt_TotalPaid.Location = new System.Drawing.Point(342, 155);
            this.Txt_TotalPaid.Name = "Txt_TotalPaid";
            this.Txt_TotalPaid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_TotalPaid.Size = new System.Drawing.Size(100, 20);
            this.Txt_TotalPaid.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "تسجيل خروج مريض ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(502, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "غرفة رقم";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(298, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "المريض ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(489, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "تاريخ الوصول";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(460, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "إجمالي المدفوعات";
            // 
            // Txt_Remarks
            // 
            this.Txt_Remarks.Location = new System.Drawing.Point(78, 199);
            this.Txt_Remarks.Name = "Txt_Remarks";
            this.Txt_Remarks.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_Remarks.Size = new System.Drawing.Size(364, 20);
            this.Txt_Remarks.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(504, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(48, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "ملاحظات";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(230, 161);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "إجمالي المستحق";
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(163, 161);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(106, 161);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "متبقي";
            this.label9.Visible = false;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label10.Location = new System.Drawing.Point(12, 160);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 18);
            this.label10.TabIndex = 15;
            // 
            // Checkout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(568, 316);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Txt_Remarks);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_TotalPaid);
            this.Controls.Add(this.Txt_Arrival);
            this.Controls.Add(this.Txt_PatientName);
            this.Controls.Add(this.Com_RoomNo);
            this.Controls.Add(this.But_CheckOut);
            this.Name = "Checkout";
            this.Text = "تسجيل الخروج";
            this.Load += new System.EventHandler(this.Checkout_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button But_CheckOut;
        private System.Windows.Forms.ComboBox Com_RoomNo;
        private System.Windows.Forms.TextBox Txt_PatientName;
        private System.Windows.Forms.TextBox Txt_Arrival;
        private System.Windows.Forms.TextBox Txt_TotalPaid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_Remarks;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
    }
}