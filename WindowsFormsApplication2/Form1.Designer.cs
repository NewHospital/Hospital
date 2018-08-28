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
            this.AddSupplierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddingBuyInvoiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RoomReservationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ReservationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PharmacyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddDrugUnitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddDrugToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddRoomDegreeToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.AddRoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.RoomsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddSpecializationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddDoctorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DoctorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.SpecializationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.FollowUpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MeasuresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AddPatientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PatientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EditPatientDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.AccountsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PaymentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CheckoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.PrescriptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // PurchasingToolStripMenuItem
            // 
            this.PurchasingToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddSupplierToolStripMenuItem,
            this.AddingBuyInvoiceToolStripMenuItem});
            this.PurchasingToolStripMenuItem.Name = "PurchasingToolStripMenuItem";
            this.PurchasingToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.PurchasingToolStripMenuItem.Text = "المشتريات";
            // 
            // AddSupplierToolStripMenuItem
            // 
            this.AddSupplierToolStripMenuItem.Name = "AddSupplierToolStripMenuItem";
            this.AddSupplierToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.AddSupplierToolStripMenuItem.Text = "إضافة مورد";
            this.AddSupplierToolStripMenuItem.Click += new System.EventHandler(this.AddSupplierToolStripMenuItem_Click);
            // 
            // AddingBuyInvoiceToolStripMenuItem
            // 
            this.AddingBuyInvoiceToolStripMenuItem.Name = "AddingBuyInvoiceToolStripMenuItem";
            this.AddingBuyInvoiceToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            this.AddingBuyInvoiceToolStripMenuItem.Text = "إضافة فاتورة مشتريات";
            this.AddingBuyInvoiceToolStripMenuItem.Click += new System.EventHandler(this.AddingBuyInvoiceToolStripMenuItem_Click);
            // 
            // RoomReservationToolStripMenuItem
            // 
            this.RoomReservationToolStripMenuItem.Name = "RoomReservationToolStripMenuItem";
            this.RoomReservationToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.RoomReservationToolStripMenuItem.Text = "إضافة حجز / مرافق";
            this.RoomReservationToolStripMenuItem.Click += new System.EventHandler(this.RoomReservationToolStripMenuItem_Click);
            // 
            // ReservationsToolStripMenuItem
            // 
            this.ReservationsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RoomReservationToolStripMenuItem});
            this.ReservationsToolStripMenuItem.Name = "ReservationsToolStripMenuItem";
            this.ReservationsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.ReservationsToolStripMenuItem.Text = "الحجوزات";
            // 
            // PharmacyToolStripMenuItem
            // 
            this.PharmacyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddDrugUnitToolStripMenuItem,
            this.AddDrugToolStripMenuItem,
            this.PrescriptionToolStripMenuItem});
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
            // AddRoomDegreeToolStripMenuItem1
            // 
            this.AddRoomDegreeToolStripMenuItem1.Name = "AddRoomDegreeToolStripMenuItem1";
            this.AddRoomDegreeToolStripMenuItem1.Size = new System.Drawing.Size(158, 22);
            this.AddRoomDegreeToolStripMenuItem1.Text = "إضافة درجة الغرفة";
            this.AddRoomDegreeToolStripMenuItem1.Click += new System.EventHandler(this.AddRoomDegreeToolStripMenuItem1_Click);
            // 
            // AddRoomToolStripMenuItem
            // 
            this.AddRoomToolStripMenuItem.Name = "AddRoomToolStripMenuItem";
            this.AddRoomToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.AddRoomToolStripMenuItem.Text = "إضافة غرفة";
            this.AddRoomToolStripMenuItem.Click += new System.EventHandler(this.AddRoomToolStripMenuItem_Click);
            // 
            // RoomsToolStripMenuItem
            // 
            this.RoomsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddRoomDegreeToolStripMenuItem1,
            this.AddRoomToolStripMenuItem});
            this.RoomsToolStripMenuItem.Name = "RoomsToolStripMenuItem";
            this.RoomsToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.RoomsToolStripMenuItem.Text = "الغرف";
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
            this.AddSpecializationToolStripMenuItem,
            this.SpecializationToolStripMenuItem,
            this.FollowUpToolStripMenuItem,
            this.MeasuresToolStripMenuItem});
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
            // FollowUpToolStripMenuItem
            // 
            this.FollowUpToolStripMenuItem.Name = "FollowUpToolStripMenuItem";
            this.FollowUpToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.FollowUpToolStripMenuItem.Text = "المتابعات";
            this.FollowUpToolStripMenuItem.Click += new System.EventHandler(this.FollowUpToolStripMenuItem_Click);
            // 
            // MeasuresToolStripMenuItem
            // 
            this.MeasuresToolStripMenuItem.Name = "MeasuresToolStripMenuItem";
            this.MeasuresToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.MeasuresToolStripMenuItem.Text = "القياسات";
            this.MeasuresToolStripMenuItem.Click += new System.EventHandler(this.MeasuresToolStripMenuItem_Click);
            // 
            // AddPatientToolStripMenuItem
            // 
            this.AddPatientToolStripMenuItem.Name = "AddPatientToolStripMenuItem";
            this.AddPatientToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.AddPatientToolStripMenuItem.Text = "إضافة مريض";
            this.AddPatientToolStripMenuItem.Click += new System.EventHandler(this.AddPatientToolStripMenuItem_Click);
            // 
            // PatientsToolStripMenuItem
            // 
            this.PatientsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddPatientToolStripMenuItem,
            this.EditPatientDataToolStripMenuItem});
            this.PatientsToolStripMenuItem.Name = "PatientsToolStripMenuItem";
            this.PatientsToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.PatientsToolStripMenuItem.Text = "المرضى";
            // 
            // EditPatientDataToolStripMenuItem
            // 
            this.EditPatientDataToolStripMenuItem.Name = "EditPatientDataToolStripMenuItem";
            this.EditPatientDataToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.EditPatientDataToolStripMenuItem.Text = "تعديل بيانات مريض";
            this.EditPatientDataToolStripMenuItem.Click += new System.EventHandler(this.EditPatientDataToolStripMenuItem_Click);
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
            this.PurchasingToolStripMenuItem,
            this.AccountsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(839, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // AccountsToolStripMenuItem
            // 
            this.AccountsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.PaymentToolStripMenuItem,
            this.CheckoutToolStripMenuItem});
            this.AccountsToolStripMenuItem.Name = "AccountsToolStripMenuItem";
            this.AccountsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.AccountsToolStripMenuItem.Text = "الحسابات";
            // 
            // PaymentToolStripMenuItem
            // 
            this.PaymentToolStripMenuItem.Name = "PaymentToolStripMenuItem";
            this.PaymentToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.PaymentToolStripMenuItem.Text = "مدفوعات";
            this.PaymentToolStripMenuItem.Click += new System.EventHandler(this.PaymentToolStripMenuItem_Click);
            // 
            // CheckoutToolStripMenuItem
            // 
            this.CheckoutToolStripMenuItem.Name = "CheckoutToolStripMenuItem";
            this.CheckoutToolStripMenuItem.Size = new System.Drawing.Size(164, 22);
            this.CheckoutToolStripMenuItem.Text = "تسجيل خروج مريض";
            this.CheckoutToolStripMenuItem.Click += new System.EventHandler(this.CheckoutToolStripMenuItem_Click);
            // 
            // PrescriptionToolStripMenuItem
            // 
            this.PrescriptionToolStripMenuItem.Name = "PrescriptionToolStripMenuItem";
            this.PrescriptionToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.PrescriptionToolStripMenuItem.Text = "إضافة روشته";
            this.PrescriptionToolStripMenuItem.Click += new System.EventHandler(this.PrescriptionToolStripMenuItem_Click);
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
        private System.Windows.Forms.ToolStripMenuItem PharmacyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddRoomDegreeToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem AddRoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem RoomsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddSpecializationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddDoctorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DoctorsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddPatientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PatientsToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem AddDrugUnitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddDrugToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SpecializationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddSupplierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AddingBuyInvoiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem FollowUpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MeasuresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AccountsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PaymentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CheckoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EditPatientDataToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem PrescriptionToolStripMenuItem;
    }
}

