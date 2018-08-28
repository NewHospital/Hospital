namespace WindowsFormsApplication2
{
    partial class ExistingPatientReservation
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
            this.Txt_Search = new System.Windows.Forms.TextBox();
            this.But_Search = new System.Windows.Forms.Button();
            this.GridResult = new System.Windows.Forms.DataGridView();
            this.Lbl_PatientName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.RdBut_Fellow = new System.Windows.Forms.RadioButton();
            this.RdBut_Reservation = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.GridResult)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Txt_Search
            // 
            this.Txt_Search.Location = new System.Drawing.Point(57, 44);
            this.Txt_Search.Name = "Txt_Search";
            this.Txt_Search.Size = new System.Drawing.Size(238, 20);
            this.Txt_Search.TabIndex = 0;
            // 
            // But_Search
            // 
            this.But_Search.Location = new System.Drawing.Point(108, 80);
            this.But_Search.Name = "But_Search";
            this.But_Search.Size = new System.Drawing.Size(133, 23);
            this.But_Search.TabIndex = 1;
            this.But_Search.Text = "بحث ";
            this.But_Search.UseVisualStyleBackColor = true;
            this.But_Search.Click += new System.EventHandler(this.But_Search_Click);
            // 
            // GridResult
            // 
            this.GridResult.AllowUserToAddRows = false;
            this.GridResult.AllowUserToDeleteRows = false;
            this.GridResult.AllowUserToOrderColumns = true;
            this.GridResult.AllowUserToResizeColumns = false;
            this.GridResult.AllowUserToResizeRows = false;
            this.GridResult.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GridResult.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.GridResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridResult.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.GridResult.Location = new System.Drawing.Point(12, 183);
            this.GridResult.Name = "GridResult";
            this.GridResult.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GridResult.Size = new System.Drawing.Size(343, 150);
            this.GridResult.TabIndex = 2;
            this.GridResult.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridResult_CellClick);
            this.GridResult.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridResult_CellContentDoubleClick);
            // 
            // Lbl_PatientName
            // 
            this.Lbl_PatientName.AutoSize = true;
            this.Lbl_PatientName.Location = new System.Drawing.Point(311, 47);
            this.Lbl_PatientName.Name = "Lbl_PatientName";
            this.Lbl_PatientName.Size = new System.Drawing.Size(66, 13);
            this.Lbl_PatientName.TabIndex = 3;
            this.Lbl_PatientName.Text = "اسم المريض";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Traditional Arabic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(144, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "بحث عن مريض";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RdBut_Fellow);
            this.groupBox1.Controls.Add(this.RdBut_Reservation);
            this.groupBox1.Location = new System.Drawing.Point(45, 122);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(269, 55);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "إضافة مرافق/حجز";
            // 
            // RdBut_Fellow
            // 
            this.RdBut_Fellow.AutoSize = true;
            this.RdBut_Fellow.Location = new System.Drawing.Point(11, 24);
            this.RdBut_Fellow.Name = "RdBut_Fellow";
            this.RdBut_Fellow.Size = new System.Drawing.Size(83, 17);
            this.RdBut_Fellow.TabIndex = 1;
            this.RdBut_Fellow.TabStop = true;
            this.RdBut_Fellow.Text = "إضافة مرافق";
            this.RdBut_Fellow.UseVisualStyleBackColor = true;
            // 
            // RdBut_Reservation
            // 
            this.RdBut_Reservation.AutoSize = true;
            this.RdBut_Reservation.Location = new System.Drawing.Point(163, 24);
            this.RdBut_Reservation.Name = "RdBut_Reservation";
            this.RdBut_Reservation.Size = new System.Drawing.Size(73, 17);
            this.RdBut_Reservation.TabIndex = 0;
            this.RdBut_Reservation.TabStop = true;
            this.RdBut_Reservation.Text = "إضافة حجز";
            this.RdBut_Reservation.UseVisualStyleBackColor = true;
            // 
            // ExistingPatientReservation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 361);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lbl_PatientName);
            this.Controls.Add(this.GridResult);
            this.Controls.Add(this.But_Search);
            this.Controls.Add(this.Txt_Search);
            this.Name = "ExistingPatientReservation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "بحث عن مريض";
            this.Load += new System.EventHandler(this.ExistingPatientReservation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GridResult)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_Search;
        private System.Windows.Forms.Button But_Search;
        private System.Windows.Forms.DataGridView GridResult;
        private System.Windows.Forms.Label Lbl_PatientName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton RdBut_Fellow;
        private System.Windows.Forms.RadioButton RdBut_Reservation;
    }
}