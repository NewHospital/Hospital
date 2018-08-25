namespace WindowsFormsApplication2
{
    partial class EditPatientData
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
            this.But_search = new System.Windows.Forms.Button();
            this.Grid_patient = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.Lbl_PatientName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Grid_patient)).BeginInit();
            this.SuspendLayout();
            // 
            // Txt_patientName
            // 
            this.Txt_patientName.Location = new System.Drawing.Point(71, 55);
            this.Txt_patientName.Name = "Txt_patientName";
            this.Txt_patientName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_patientName.Size = new System.Drawing.Size(230, 20);
            this.Txt_patientName.TabIndex = 0;
            // 
            // But_search
            // 
            this.But_search.Location = new System.Drawing.Point(136, 100);
            this.But_search.Name = "But_search";
            this.But_search.Size = new System.Drawing.Size(113, 23);
            this.But_search.TabIndex = 1;
            this.But_search.Text = "بحث";
            this.But_search.UseVisualStyleBackColor = true;
            this.But_search.Click += new System.EventHandler(this.But_search_Click);
            // 
            // Grid_patient
            // 
            this.Grid_patient.AllowUserToAddRows = false;
            this.Grid_patient.AllowUserToDeleteRows = false;
            this.Grid_patient.AllowUserToResizeColumns = false;
            this.Grid_patient.AllowUserToResizeRows = false;
            this.Grid_patient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Grid_patient.BackgroundColor = System.Drawing.SystemColors.Highlight;
            this.Grid_patient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Grid_patient.Location = new System.Drawing.Point(34, 147);
            this.Grid_patient.Name = "Grid_patient";
            this.Grid_patient.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Grid_patient.Size = new System.Drawing.Size(311, 150);
            this.Grid_patient.TabIndex = 2;
            this.Grid_patient.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Grid_patient_CellDoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Traditional Arabic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(139, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "بحث عن مريض";
            // 
            // Lbl_PatientName
            // 
            this.Lbl_PatientName.AutoSize = true;
            this.Lbl_PatientName.Location = new System.Drawing.Point(317, 59);
            this.Lbl_PatientName.Name = "Lbl_PatientName";
            this.Lbl_PatientName.Size = new System.Drawing.Size(66, 13);
            this.Lbl_PatientName.TabIndex = 4;
            this.Lbl_PatientName.Text = "اسم المريض";
            // 
            // EditPatientData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(408, 309);
            this.Controls.Add(this.Lbl_PatientName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Grid_patient);
            this.Controls.Add(this.But_search);
            this.Controls.Add(this.Txt_patientName);
            this.Name = "EditPatientData";
            this.Text = "تعديل بيانات مريض";
            ((System.ComponentModel.ISupportInitialize)(this.Grid_patient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_patientName;
        private System.Windows.Forms.Button But_search;
        private System.Windows.Forms.DataGridView Grid_patient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Lbl_PatientName;
    }
}