namespace Hospital
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.PurchasingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RoomReservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReservationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PatientReservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PharmacyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddDrugUnitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddDrugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ModigyRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddRoomDegreeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.AddRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RoomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ModifyDoctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddSpecializationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddDoctorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DoctorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SpecializationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DeletePatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ModifyPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PatientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MainDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PurchasingToolStripMenuItem
            // 
            this.PurchasingToolStripMenuItem.Name = "PurchasingToolStripMenuItem";
            this.PurchasingToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.PurchasingToolStripMenuItem.Text = "المشتريات";
            // 
            // RoomReservationToolStripMenuItem
            // 
            this.RoomReservationToolStripMenuItem.Name = "RoomReservationToolStripMenuItem";
            this.RoomReservationToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.RoomReservationToolStripMenuItem.Text = "حجز غرفة";
            // 
            // ReservationsToolStripMenuItem
            // 
            this.ReservationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RoomReservationToolStripMenuItem,
            this.PatientReservationToolStripMenuItem});
            this.ReservationsToolStripMenuItem.Name = "ReservationsToolStripMenuItem";
            this.ReservationsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.ReservationsToolStripMenuItem.Text = "الحجوزات";
            // 
            // PatientReservationToolStripMenuItem
            // 
            this.PatientReservationToolStripMenuItem.Name = "PatientReservationToolStripMenuItem";
            this.PatientReservationToolStripMenuItem.Size = new System.Drawing.Size(125, 22);
            this.PatientReservationToolStripMenuItem.Text = "حجز مريض";
            // 
            // PharmacyToolStripMenuItem
            // 
            this.PharmacyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddDrugUnitToolStripMenuItem,
            this.AddDrugToolStripMenuItem});
            this.PharmacyToolStripMenuItem.Name = "PharmacyToolStripMenuItem";
            this.PharmacyToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.PharmacyToolStripMenuItem.Text = "الصيدلية";
            // 
            // AddDrugUnitToolStripMenuItem
            // 
            this.AddDrugUnitToolStripMenuItem.Name = "AddDrugUnitToolStripMenuItem";
            this.AddDrugUnitToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.AddDrugUnitToolStripMenuItem.Text = "إضافة وحدات الدواء";
            this.AddDrugUnitToolStripMenuItem.Click += new System.EventHandler(this.AddDrugUnitsToolStripMenuItem_Click);
            // 
            // AddDrugToolStripMenuItem
            // 
            this.AddDrugToolStripMenuItem.Name = "AddDrugToolStripMenuItem";
            this.AddDrugToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.AddDrugToolStripMenuItem.Text = "إضافة صنف دواء ";
            this.AddDrugToolStripMenuItem.Click += new System.EventHandler(this.AddDrugToolStripMenuItem_Click);
            // 
            // ModigyRoomToolStripMenuItem
            // 
            this.ModigyRoomToolStripMenuItem.Name = "ModigyRoomToolStripMenuItem";
            this.ModigyRoomToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.ModigyRoomToolStripMenuItem.Text = "تعديل الغرفة";
            // 
            // AddRoomDegreeToolStripMenuItem1
            // 
            this.AddRoomDegreeToolStripMenuItem1.Name = "AddRoomDegreeToolStripMenuItem1";
            this.AddRoomDegreeToolStripMenuItem1.Size = new System.Drawing.Size(158, 22);
            this.AddRoomDegreeToolStripMenuItem1.Text = "إضافة درجة الغرفة";
            // 
            // AddRoomToolStripMenuItem
            // 
            this.AddRoomToolStripMenuItem.Name = "AddRoomToolStripMenuItem";
            this.AddRoomToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.AddRoomToolStripMenuItem.Text = "إضافة غرفة";
            // 
            // RoomsToolStripMenuItem
            // 
            this.RoomsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddRoomToolStripMenuItem,
            this.AddRoomDegreeToolStripMenuItem1,
            this.ModigyRoomToolStripMenuItem});
            this.RoomsToolStripMenuItem.Name = "RoomsToolStripMenuItem";
            this.RoomsToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.RoomsToolStripMenuItem.Text = "الغرف";
            // 
            // ModifyDoctorToolStripMenuItem
            // 
            this.ModifyDoctorToolStripMenuItem.Name = "ModifyDoctorToolStripMenuItem";
            this.ModifyDoctorToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.ModifyDoctorToolStripMenuItem.Text = "تعديل بيانات طبيب";
            // 
            // AddSpecializationToolStripMenuItem
            // 
            this.AddSpecializationToolStripMenuItem.Name = "AddSpecializationToolStripMenuItem";
            this.AddSpecializationToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.AddSpecializationToolStripMenuItem.Text = "إضافة درجة علمية";
            this.AddSpecializationToolStripMenuItem.Click += new System.EventHandler(this.AddSpecializationToolStripMenuItem_Click);
            // 
            // AddDoctorsToolStripMenuItem
            // 
            this.AddDoctorsToolStripMenuItem.Name = "AddDoctorsToolStripMenuItem";
            this.AddDoctorsToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.AddDoctorsToolStripMenuItem.Text = "إضافة طبيب";
            this.AddDoctorsToolStripMenuItem.Click += new System.EventHandler(this.AddDoctorsToolStripMenuItem_Click);
            // 
            // DoctorsToolStripMenuItem
            // 
            this.DoctorsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddDoctorsToolStripMenuItem,
            this.ModifyDoctorToolStripMenuItem,
            this.AddSpecializationToolStripMenuItem,
            this.SpecializationToolStripMenuItem});
            this.DoctorsToolStripMenuItem.Name = "DoctorsToolStripMenuItem";
            this.DoctorsToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.DoctorsToolStripMenuItem.Text = "الأطباء";
            // 
            // SpecializationToolStripMenuItem
            // 
            this.SpecializationToolStripMenuItem.Name = "SpecializationToolStripMenuItem";
            this.SpecializationToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.SpecializationToolStripMenuItem.Text = "إضافة التخصصات الطبية";
            this.SpecializationToolStripMenuItem.Click += new System.EventHandler(this.SpecializationToolStripMenuItem_Click);
            // 
            // DeletePatientToolStripMenuItem
            // 
            this.DeletePatientToolStripMenuItem.Name = "DeletePatientToolStripMenuItem";
            this.DeletePatientToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.DeletePatientToolStripMenuItem.Text = "حدف مريض";
            // 
            // ModifyPatientToolStripMenuItem
            // 
            this.ModifyPatientToolStripMenuItem.Name = "ModifyPatientToolStripMenuItem";
            this.ModifyPatientToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.ModifyPatientToolStripMenuItem.Text = "تعديل مريض";
            this.ModifyPatientToolStripMenuItem.Click += new System.EventHandler(this.ModifyPatientToolStripMenuItem_Click);
            // 
            // AddPatientToolStripMenuItem
            // 
            this.AddPatientToolStripMenuItem.Name = "AddPatientToolStripMenuItem";
            this.AddPatientToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.AddPatientToolStripMenuItem.Text = "إضافة مريض";
            this.AddPatientToolStripMenuItem.Click += new System.EventHandler(this.AddPatientToolStripMenuItem_Click);
            // 
            // PatientsToolStripMenuItem
            // 
            this.PatientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MainDataToolStripMenuItem,
            this.AddPatientToolStripMenuItem,
            this.ModifyPatientToolStripMenuItem,
            this.DeletePatientToolStripMenuItem});
            this.PatientsToolStripMenuItem.Name = "PatientsToolStripMenuItem";
            this.PatientsToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.PatientsToolStripMenuItem.Text = "المرضى";
            // 
            // MainDataToolStripMenuItem
            // 
            this.MainDataToolStripMenuItem.Name = "MainDataToolStripMenuItem";
            this.MainDataToolStripMenuItem.Size = new System.Drawing.Size(153, 22);
            this.MainDataToolStripMenuItem.Text = "البيانات الأساسية";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PatientsToolStripMenuItem,
            this.DoctorsToolStripMenuItem,
            this.RoomsToolStripMenuItem,
            this.PharmacyToolStripMenuItem,
            this.ReservationsToolStripMenuItem,
            this.PurchasingToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(839, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MainForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(839, 421);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Tahoma", 13F, System.Drawing.FontStyle.Bold);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "MainForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hospital Project";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem PurchasingToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RoomReservationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ReservationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PatientReservationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PharmacyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ModigyRoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddRoomDegreeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem AddRoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RoomsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ModifyDoctorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddSpecializationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddDoctorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DoctorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DeletePatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ModifyPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PatientsToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem MainDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddDrugUnitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddDrugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SpecializationToolStripMenuItem;
    }
}

