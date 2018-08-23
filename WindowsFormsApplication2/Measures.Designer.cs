namespace WindowsFormsApplication2
{
    partial class Measures
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
            this.Com_DocName = new System.Windows.Forms.ComboBox();
            this.Com_RoomNo = new System.Windows.Forms.ComboBox();
            this.Lbl_DocName = new System.Windows.Forms.Label();
            this.lbl_RoomNo = new System.Windows.Forms.Label();
            this.Txt_PatientName = new System.Windows.Forms.TextBox();
            this.Com_Diseases = new System.Windows.Forms.ComboBox();
            this.Txt_result = new System.Windows.Forms.TextBox();
            this.RTxt_Remark = new System.Windows.Forms.RichTextBox();
            this.But_addMeasure = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Com_DocName
            // 
            this.Com_DocName.FormattingEnabled = true;
            this.Com_DocName.Location = new System.Drawing.Point(132, 28);
            this.Com_DocName.Name = "Com_DocName";
            this.Com_DocName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Com_DocName.Size = new System.Drawing.Size(181, 21);
            this.Com_DocName.TabIndex = 0;
            this.Com_DocName.SelectedValueChanged += new System.EventHandler(this.Com_DocName_SelectedValueChanged);
            // 
            // Com_RoomNo
            // 
            this.Com_RoomNo.FormattingEnabled = true;
            this.Com_RoomNo.Location = new System.Drawing.Point(225, 81);
            this.Com_RoomNo.Name = "Com_RoomNo";
            this.Com_RoomNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Com_RoomNo.Size = new System.Drawing.Size(88, 21);
            this.Com_RoomNo.TabIndex = 1;
            this.Com_RoomNo.SelectedValueChanged += new System.EventHandler(this.Com_RoomNo_SelectedValueChanged);
            // 
            // Lbl_DocName
            // 
            this.Lbl_DocName.AutoSize = true;
            this.Lbl_DocName.Location = new System.Drawing.Point(321, 28);
            this.Lbl_DocName.Name = "Lbl_DocName";
            this.Lbl_DocName.Size = new System.Drawing.Size(64, 13);
            this.Lbl_DocName.TabIndex = 2;
            this.Lbl_DocName.Text = "اسم الطبيب";
            // 
            // lbl_RoomNo
            // 
            this.lbl_RoomNo.AutoSize = true;
            this.lbl_RoomNo.Location = new System.Drawing.Point(330, 86);
            this.lbl_RoomNo.Name = "lbl_RoomNo";
            this.lbl_RoomNo.Size = new System.Drawing.Size(55, 13);
            this.lbl_RoomNo.TabIndex = 3;
            this.lbl_RoomNo.Text = "رقم الغرفة";
            // 
            // Txt_PatientName
            // 
            this.Txt_PatientName.Enabled = false;
            this.Txt_PatientName.Location = new System.Drawing.Point(26, 81);
            this.Txt_PatientName.Name = "Txt_PatientName";
            this.Txt_PatientName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_PatientName.Size = new System.Drawing.Size(157, 20);
            this.Txt_PatientName.TabIndex = 4;
            // 
            // Com_Diseases
            // 
            this.Com_Diseases.FormattingEnabled = true;
            this.Com_Diseases.Location = new System.Drawing.Point(132, 138);
            this.Com_Diseases.Name = "Com_Diseases";
            this.Com_Diseases.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Com_Diseases.Size = new System.Drawing.Size(181, 21);
            this.Com_Diseases.TabIndex = 5;
            // 
            // Txt_result
            // 
            this.Txt_result.Location = new System.Drawing.Point(99, 185);
            this.Txt_result.Name = "Txt_result";
            this.Txt_result.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_result.Size = new System.Drawing.Size(214, 20);
            this.Txt_result.TabIndex = 6;
            // 
            // RTxt_Remark
            // 
            this.RTxt_Remark.Location = new System.Drawing.Point(38, 226);
            this.RTxt_Remark.Name = "RTxt_Remark";
            this.RTxt_Remark.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.RTxt_Remark.Size = new System.Drawing.Size(275, 64);
            this.RTxt_Remark.TabIndex = 7;
            this.RTxt_Remark.Text = "";
            // 
            // But_addMeasure
            // 
            this.But_addMeasure.Location = new System.Drawing.Point(112, 313);
            this.But_addMeasure.Name = "But_addMeasure";
            this.But_addMeasure.Size = new System.Drawing.Size(165, 46);
            this.But_addMeasure.TabIndex = 8;
            this.But_addMeasure.Text = "إضافة قياس";
            this.But_addMeasure.UseVisualStyleBackColor = true;
            this.But_addMeasure.Click += new System.EventHandler(this.But_addMeasure_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(328, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "نوع القياس";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(350, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "النتيجة";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 226);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "ملاحظات";
            // 
            // Measures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 385);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.But_addMeasure);
            this.Controls.Add(this.RTxt_Remark);
            this.Controls.Add(this.Txt_result);
            this.Controls.Add(this.Com_Diseases);
            this.Controls.Add(this.Txt_PatientName);
            this.Controls.Add(this.lbl_RoomNo);
            this.Controls.Add(this.Lbl_DocName);
            this.Controls.Add(this.Com_RoomNo);
            this.Controls.Add(this.Com_DocName);
            this.Name = "Measures";
            this.Text = "القياسات";
            this.Load += new System.EventHandler(this.Measures_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox Com_DocName;
        private System.Windows.Forms.ComboBox Com_RoomNo;
        private System.Windows.Forms.Label Lbl_DocName;
        private System.Windows.Forms.Label lbl_RoomNo;
        private System.Windows.Forms.TextBox Txt_PatientName;
        private System.Windows.Forms.ComboBox Com_Diseases;
        private System.Windows.Forms.TextBox Txt_result;
        private System.Windows.Forms.RichTextBox RTxt_Remark;
        private System.Windows.Forms.Button But_addMeasure;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}