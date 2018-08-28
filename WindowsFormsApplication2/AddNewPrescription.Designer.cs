namespace WindowsFormsApplication2
{
    partial class AddNewPrescription
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
            this.But_Add = new System.Windows.Forms.Button();
            this.Com_Doc = new System.Windows.Forms.ComboBox();
            this.Com_Room = new System.Windows.Forms.ComboBox();
            this.Txt_patient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // But_Add
            // 
            this.But_Add.Location = new System.Drawing.Point(179, 250);
            this.But_Add.Name = "But_Add";
            this.But_Add.Size = new System.Drawing.Size(75, 23);
            this.But_Add.TabIndex = 0;
            this.But_Add.Text = "إرسال  الدواء";
            this.But_Add.UseVisualStyleBackColor = true;
            this.But_Add.Click += new System.EventHandler(this.But_Add_Click);
            // 
            // Com_Doc
            // 
            this.Com_Doc.FormattingEnabled = true;
            this.Com_Doc.Location = new System.Drawing.Point(205, 35);
            this.Com_Doc.Name = "Com_Doc";
            this.Com_Doc.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Com_Doc.Size = new System.Drawing.Size(183, 21);
            this.Com_Doc.TabIndex = 1;
            this.Com_Doc.SelectedIndexChanged += new System.EventHandler(this.Com_Doc_SelectedIndexChanged);
            // 
            // Com_Room
            // 
            this.Com_Room.FormattingEnabled = true;
            this.Com_Room.Location = new System.Drawing.Point(409, 35);
            this.Com_Room.Name = "Com_Room";
            this.Com_Room.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Com_Room.Size = new System.Drawing.Size(75, 21);
            this.Com_Room.TabIndex = 2;
            this.Com_Room.SelectedIndexChanged += new System.EventHandler(this.Com_Room_SelectedIndexChanged);
            // 
            // Txt_patient
            // 
            this.Txt_patient.Enabled = false;
            this.Txt_patient.Location = new System.Drawing.Point(12, 35);
            this.Txt_patient.Name = "Txt_patient";
            this.Txt_patient.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_patient.Size = new System.Drawing.Size(187, 20);
            this.Txt_patient.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(202, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // AddNewPrescription
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 403);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txt_patient);
            this.Controls.Add(this.Com_Room);
            this.Controls.Add(this.Com_Doc);
            this.Controls.Add(this.But_Add);
            this.Name = "AddNewPrescription";
            this.Text = "AddNewPrescription";
            this.Load += new System.EventHandler(this.AddNewPrescription_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button But_Add;
        private System.Windows.Forms.ComboBox Com_Doc;
        private System.Windows.Forms.ComboBox Com_Room;
        private System.Windows.Forms.TextBox Txt_patient;
        private System.Windows.Forms.Label label1;
    }
}