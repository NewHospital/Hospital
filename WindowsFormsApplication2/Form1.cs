﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication2; 

namespace Hospital
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConnectionClass.Connection(@"Data Source=.;Initial Catalog=hospital;Integrated Security=True");
            hospitalEntities Hospital = new hospitalEntities();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox3_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {

        }

        private void AddPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewPatient addPatient = new AddNewPatient();
            addPatient.ShowDialog();
        }
        private void ModifyPatientToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AddDrugToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDrug Drug = new AddDrug();
            Drug.ShowDialog();
        }

        private void AddDrugUnitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddDrugUnits DrugUnits = new AddDrugUnits();
            DrugUnits.ShowDialog();
        }

        private void AddSpecializationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DocDegree Degree    = new DocDegree();
            Degree.ShowDialog();
        }

        private void SpecializationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSpecialization Specialization = new AddSpecialization();
            Specialization.ShowDialog();
        }

        private void AddDoctorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewDoctor NewDoc = new AddNewDoctor();
            NewDoc.ShowDialog();

        }

        private void AddRoomDegreeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RoomDegrees Deg = new RoomDegrees();
            Deg.ShowDialog();

        }

        private void AddRoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddRooms Room = new AddRooms();
            Room.ShowDialog();
        }

        private void AddDiseasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void AddSupplierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddSuppliers Supplier = new AddSuppliers();
            Supplier.ShowDialog();
        }

        private void AddingBuyInvoiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddBuyingInvoice BuyInvoice = new AddBuyingInvoice();
            BuyInvoice.ShowDialog();

        }

        private void FollowUpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FollowUp Follow = new FollowUp();
            Follow.ShowDialog();
        }

        private void MeasuresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Measures M = new Measures();
            M.ShowDialog();
        }

        private void PaymentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Payments pay = new Payments();
            pay.ShowDialog();
            
        }

        private void CheckoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Checkout Cout = new Checkout();
            Cout.ShowDialog();
        }

        private void RoomReservationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExistingPatientReservation ExistReservation = new ExistingPatientReservation();
            ExistReservation.ShowDialog();
        }

        private void EditPatientDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditPatientData EditData = new EditPatientData();
            EditData.ShowDialog();
        }

        private void AddprescriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewPrescription Pres = new AddNewPrescription();
            Pres.ShowDialog();
        }

        private void PrescriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddNewPrescription Presc = new AddNewPrescription();
            Presc.ShowDialog();
        }

        private void ReceivePrescriptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ChooseReceive Rec = new ChooseReceive();
            Rec.ShowDialog();
        }
    }
}
