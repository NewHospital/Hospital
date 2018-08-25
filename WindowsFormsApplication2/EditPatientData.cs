using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hospital; 

namespace WindowsFormsApplication2
{
    public partial class EditPatientData : Form
    {
        hospitalEntities Hospital = new hospitalEntities();
        public EditPatientData()
        {
            InitializeComponent();
        }

        private void But_search_Click(object sender, EventArgs e)
        {
            var PatientName = (from H in Hospital.Patients
                               where H.PatientName.Contains(Txt_patientName.Text)
                               select new { H.PatientID, H.PatientName, H.Gender, H.DOB,H.SoSecNo , H.BloodGroup, H.PhoneNumber, H.Address  }).ToList();
            Grid_patient.DataSource = PatientName;
            Grid_patient.Columns[1].HeaderText = "اسم المريض";
            Grid_patient.Columns[0].Visible = false;
            Grid_patient.Columns[2].Visible = false;
            Grid_patient.Columns[3].Visible = false;
            Grid_patient.Columns[4].Visible = false;
            Grid_patient.Columns[5].Visible = false;
            Grid_patient.Columns[6].Visible = false;
            Grid_patient.Columns[7].Visible = false;
        }

        private void Grid_patient_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Close();
            int PatientId = Convert.ToInt32(Grid_patient.Rows[e.RowIndex].Cells["PatientID"].FormattedValue);
            int RadioButtonValue = Convert.ToInt32(Grid_patient.Rows[e.RowIndex].Cells["Gender"].FormattedValue);
            string BirthDate = (Grid_patient.Rows[e.RowIndex].Cells["DOB"].FormattedValue).ToString();
            int BloodGroup = Convert.ToInt32 (Grid_patient.Rows[e.RowIndex].Cells["BloodGroup"].FormattedValue);
            AddNewPatient Patient = new AddNewPatient();
            Patient.EditedPatient = PatientId;
            Patient.Controls["But_AddPatient"].Visible = false;
            Patient.Controls["But_EditPatient"].Visible = true; 
            Patient.Text = "تعديل بيانات مريض";
            Patient.Controls["label8"].Text = "تعديل بيانات مريض";
            Patient.Controls["Txt_PatientName"].Text = (Grid_patient.Rows[e.RowIndex].Cells["PatientName"].FormattedValue).ToString();
            Patient.Controls["Txt_SoSeNo"].Text= (Grid_patient.Rows[e.RowIndex].Cells["SoSecNo"].FormattedValue).ToString();
            Patient.Controls["Txt_Mobile"].Text= (Grid_patient.Rows[e.RowIndex].Cells["PhoneNumber"].FormattedValue).ToString();
            Patient.Controls["Txt_Address"].Text= (Grid_patient.Rows[e.RowIndex].Cells["Address"].FormattedValue).ToString();
            Patient.SetRadioButton(RadioButtonValue);
            Patient.SetBirthDay(BirthDate);
            Patient.Show();
            Patient.SetBloodCombo(BloodGroup);
            Patient.WindowState = FormWindowState.Normal;
            Patient.TopMost = true;


            
           }
    }
}
