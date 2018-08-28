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
    public partial class AddNewPrescription : Form
    {   
        hospitalEntities Hospital = new hospitalEntities();
        static List<CheckBox> checkList = new List<CheckBox>();
        public List<Drug> DrugList = new List<Drug>();
        
        public int RId;
        public int reservationId;
        public int PatientId; 
        public int DocId; 
        public static List<string> Value = new List<string>();
        int CHX = 382;
        int CHY = 82;

        public AddNewPrescription()
        {
            InitializeComponent();
        }

        private void AddNewPrescription_Load(object sender, EventArgs e)
        {
            checkList.Clear();
            Value.Clear();
            DrugList = Hospital.Drugs.ToList();

            foreach (var item in DrugList)
            {
                if (CHX > 31)
                {
                    CheckBox CH = new CheckBox();
                    CH.Text = item.DrugName.ToString();
                    CH.Name = item.DrugUnit.ToString();
                    CH.Location = new System.Drawing.Point(CHX, CHY);
                    this.Controls.Add(CH);
                    CHX -= 117;
                    checkList.Add(CH);
                }
                else if (CHX == 31)
                {
                    CheckBox CH = new CheckBox();
                    CH.Text = item.DrugName.ToString();
                    CH.Name = item.DrugUnit.ToString();
                    CH.Location = new System.Drawing.Point(CHX, CHY);
                    this.Controls.Add(CH);
                    CHY += 25;
                    CHX = 382;
                    checkList.Add(CH);
                }
            }
            But_Add.Visible = true;
            But_Add.Size = new System.Drawing.Size(75, 23);
            But_Add.Location = new System.Drawing.Point(193, CHY + 40);

           var  RoomNo = (from R in Hospital.Rooms
                          join RS in Hospital.Reservations
                          on R.RoomId equals RS.RoomID
                          join P in Hospital.Patients
                          on RS.patientId equals P.PatientID
                          where RS.IsActive == true
                          select new { R.RoomId, R.RoomNo, P.PatientName, P.PatientID, RS.ReservationID }).ToList();

            Com_Room.DataSource = RoomNo;
            Com_Room.ValueMember = "RoomId";
            Com_Room.DisplayMember = "RoomNO";


            

        }

        private void But_Add_Click(object sender, EventArgs e)
        {
            foreach (var item in checkList)
            {
                if (item.Checked == true)
                {
                    Value.Add(item.Text.ToString());
                }
            }
            if (Value.Count == 0)
            {
                MessageBox.Show("يجب اختيار صنف دواء واحد على الأقل");
            }
            else
            {
                this.Close();
                NewPrescriptionDetail Rec = new NewPrescriptionDetail();
                Rec.ReservationId = reservationId;
                Rec.DocId = DocId;
                Rec.PatientID = PatientId; 
                Rec.Show();
                //Rec.TopMost = true;
            }
            checkList.Clear();
        }

        private void Com_Doc_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void Com_Room_SelectedIndexChanged(object sender, EventArgs e)
        {
          
            var RidItem = Com_Room.SelectedItem;
             RId = Convert.ToInt32( RidItem.GetType().GetProperty("RoomId").GetValue(RidItem));
            var Pname= RidItem.GetType().GetProperty("PatientName").GetValue(RidItem);
            
            var ActiveDoc = (from R in Hospital.Rooms
                         join RS in Hospital.Reservations
                         on R.RoomId equals RS.RoomID
                         join D in Hospital.DocfollowUps
                         on RS.ReservationID equals D.ReservationID
                         join DS in Hospital.Doctors
                         on D.DoctorID equals DS.DoctorId
                         where RS.RoomID == RId
                          select new { DS.DoctorId, DS.DocName, RS.ReservationID }).ToList();
            Com_Doc.DataSource = ActiveDoc;
            Com_Doc.ValueMember = "DoctorId";
            Com_Doc.DisplayMember = "DocName";
            Txt_patient.Text = Pname.ToString();
            if (Com_Doc.SelectedItem!= null)
            { 
            var x = (Com_Doc.SelectedItem);
            DocId = Convert.ToInt32(x.GetType().GetProperty("DoctorId").GetValue(x));
            reservationId = Convert.ToInt32(x.GetType().GetProperty("ReservationID").GetValue(x));
                HelpClass.EnabledOrDisabled(true, But_Add);
                HelpClass.VisibleOrNot(true, Com_Doc);
                HelpClass.VisibleOrNot(false, label1);
                //PatientId= Convert.ToInt32(x.GetType().GetProperty("PatientID").GetValue(x));
            }
            else
            {
                HelpClass.EnabledOrDisabled(false, But_Add);
                label1.Text = "لا يوجد طبيب مخصص لهذا المريض";
                label1.Location = new Point(160, CHY + 80);
                HelpClass.VisibleOrNot(true, label1);
                HelpClass.VisibleOrNot(false, Com_Doc);
            }

        }
    }
}
