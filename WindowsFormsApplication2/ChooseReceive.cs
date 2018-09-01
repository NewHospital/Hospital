using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class ChooseReceive : Form
    {
        hospitalEntities Hospital = new hospitalEntities();
        int reservationID;
        int PatientID; 
        public ChooseReceive()
        {
            InitializeComponent();
        }

        private void ChooseReceive_Load(object sender, EventArgs e)
        {
            var Room = (from Rs in Hospital.Reservations
                        join R in Hospital.Rooms
                        on Rs.RoomID equals R.RoomId
                        join P in Hospital.Prescriptions
                        on Rs.ReservationID equals P.ReservationID
                        join pd in Hospital.PrescriptionDetails
                        on P.PrescriptionId equals pd.PrescriptionId
                        join Pa in Hospital.Patients
                        on Rs.patientId equals Pa.PatientID
                        where pd.IsReceived == false && Rs.IsActive == true
                        select new { R.RoomId, R.RoomNo, Rs.ReservationID, Pa.PatientName, Pa.PatientID }).Distinct(). ToList();

            Com_RoomNo.DataSource = Room;
            Com_RoomNo.ValueMember = "RoomId";
            Com_RoomNo.DisplayMember = "RoomNo";


           

        }

        private void Txt_patientName_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Com_RoomNo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var Co = Com_RoomNo.SelectedItem;
            var roomid = Co.GetType().GetProperty("RoomId").GetValue(Co);
             reservationID = Convert.ToInt32(Co.GetType().GetProperty("ReservationID").GetValue(Co));
             PatientID = Convert.ToInt32(Co.GetType().GetProperty("PatientID").GetValue(Co));
            var patient = Co.GetType().GetProperty("PatientName").GetValue(Co);
            Txt_patientName.Text = patient.ToString();
        }

        private void But_ReceivePresc_Click(object sender, EventArgs e)
        {
            this.Close();
            ReceivePrescription RecPresc = new ReceivePrescription();
            RecPresc.reservationID = reservationID;
            RecPresc.PatientID = PatientID;
            RecPresc.Show();
        }
    }
}
