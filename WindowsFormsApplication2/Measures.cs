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
using System.Collections;
using WindowsFormsApplication2;
using System.Data.SqlClient; 

namespace WindowsFormsApplication2
{

    public partial class Measures : Form
    { hospitalEntities Hospital = new hospitalEntities();
        
        public int yy;
        public int y; 


        public Measures()
        {
            InitializeComponent();
        }

        private void Measures_Load(object sender, EventArgs e)
        {
            List<Doctor> DocList = Hospital.Doctors.ToList ();
            Com_DocName.DataSource = DocList;
            Com_DocName.ValueMember = "DoctorId"; 
            Com_DocName.DisplayMember = "DocName";

            List<Disease> DiseaseList = Hospital.Diseases.ToList();
            
            Com_Diseases.DataSource = DiseaseList;
            Com_Diseases.ValueMember = "DiseaseId";
            Com_Diseases.DisplayMember = "DiseaseName";
            y = ((Doctor)(Com_DocName.SelectedItem)).DoctorId;

        }

        private void Com_DocName_SelectedValueChanged(object sender, EventArgs e)
        {
             y =  ((Doctor)(Com_DocName.SelectedItem)).DoctorId; 
            var x = ((from D in Hospital.Doctors
                     join R in Hospital.DocfollowUps
                     on D.DoctorId equals R.DoctorID
                     join RN in Hospital.Reservations
                     on R.ReservationID equals RN.ReservationID 
                     join o in Hospital.Rooms
                     on RN.RoomID equals o.RoomId
                     where RN.IsActive == true && D.DoctorId== y
                     select new { o.RoomId, o.RoomNo})).ToList();
            Com_RoomNo.DataSource = x;
            Com_RoomNo.ValueMember = "RoomId";
            Com_RoomNo.DisplayMember = "RoomNo";
            //var s = Hospital.Reservations.ToList().FindAll(a => a.RoomID == Convert.ToInt32(Com_RoomNo.SelectedValue)).ToList().Select(a => a.patientId).ToList();
            //int v = s[0];

            //Txt_PatientName.Text = v.ToString();
        }

        private void Com_RoomNo_SelectionChangeCommitted(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void Com_RoomNo_SelectedValueChanged(object sender, EventArgs u)
        {
            object ss = new object();
            ss = Com_RoomNo.SelectedItem;
            var rr = ss.GetType().GetProperty("RoomId").GetValue(ss).ToString();
            yy = Convert.ToInt32(rr); 
               var P = (from D in Hospital.Doctors
                         join R in Hospital.DocfollowUps
                         on D.DoctorId equals R.DoctorID
                         join RN in Hospital.Reservations
                         on R.ReservationID equals RN.ReservationID
                         join o in Hospital.Rooms
                         on RN.RoomID equals o.RoomId
                         join h in Hospital.Patients
                         on RN.patientId equals h.PatientID
                         where R.IsActive == true && o.RoomId == yy
                         select new { h.PatientName }).ToList();
                Txt_PatientName.Text = (P[0]).PatientName.ToString();
       }

        private void But_addMeasure_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty (Txt_result.Text))
            { 
            int D = ((Disease)Com_Diseases.SelectedItem).DiseaseId; 
            var patientId = ((Hospital.Reservations.ToList().FindAll(a => a.RoomID == y&& a.IsActive== true).ToList().Select(a => a.patientId)).ToList());
            int ss = int.Parse (patientId [0].ToString ());
            Hospital.Cproc_AddMeasure(ss, D, Txt_result.Text, RTxt_Remark.Text, y);
            //ConnectionClass.Parameters(new SqlParameter("@patientId", ss), new SqlParameter("@diseaseId", D), new SqlParameter("@MeasureResult", Txt_result.Text), new SqlParameter("@remark", RTxt_Remark.Text), new SqlParameter("@doctorId", y));
            //ConnectionClass.SQLCommand("Cproc_AddMeasure", CommandType.StoredProcedure, ExecuteReaderOrNonQuery.executeNonQuery);
            RTxt_Remark.Clear();
            
            Txt_result.Clear();
            MessageBox.Show("تم إضافة القياس بنجاح", "تأكيد الإضافة");
            }
            else { MessageBox.Show ("يرجى إدخال نتيجة القياس"); }
        }
    }
}
    