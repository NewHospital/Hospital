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
    public partial class ReceivePrescription : Form
    {
        hospitalEntities Hospital = new hospitalEntities();
        int ChX = 344;
        int ChY = 80;
        int DNameX = 208;
        int DNameY = 80;
        int QX = 113;
        int QY = 80;
        public int reservationID;
        public int PatientID;
        int drugId;
        int Quant;
        int presId;
       


        List<TextBox> ListDrugNameTextboxes = new List<TextBox>();
        List<int> ListDrugId;
        List<CheckBox> ListReceivedCheck = new List<CheckBox>();
        List<TextBox> QntyTextBox = new List<TextBox>();
        List<string> ListQntyValue = new List<string>();

        public ReceivePrescription()
        {
            InitializeComponent();
        }

        private void ReceivePrescription_Load(object sender, EventArgs e)
        {
            int num = 1;
            var prescriptionDetail = (from pd in Hospital.PrescriptionDetails
                                      join p in Hospital.Prescriptions
                                      on pd.PrescriptionId equals p.PrescriptionId
                                      join r in Hospital.Reservations
                                      on p.ReservationID equals r.ReservationID
                                      where r.ReservationID == reservationID && pd.IsReceived == false
                                      select new { pd.IsReceived, pd.Qnty, p.ReservationID, pd.DrugId , pd.PrescriptionId}).ToList();

           
                foreach (var item in prescriptionDetail)
                {
                    object s = (object)item;
                    var Q = s.GetType().GetProperty("Qnty").GetValue(s);
                    var D = Convert.ToInt32(s.GetType().GetProperty("DrugId").GetValue(s));
                    bool t = Convert.ToBoolean(s.GetType().GetProperty("IsReceived").GetValue(s));
                    var drugName = (from H in Hospital.Drugs
                                    where H.DrugId == D
                                    select new { H.DrugName }.DrugName).ToList();
                    CheckBox Rec = new CheckBox();
                    Rec.Checked = false;
                    Rec.Name = "CH" + num;
                    Rec.Location = new Point(ChX, ChY);
                    this.Controls.Add(Rec);
                    Rec.Size = new Size(100, 20);
                    ChY += 25;
                    ListReceivedCheck.Add(Rec);


                    TextBox Tx = new TextBox();
                    Tx.Location = new Point(DNameX, DNameY);
                    DNameY += 25;
                    Tx.Name = "DName" + num;
                    Tx.Enabled = false;
                    Tx.Text = drugName[0].ToString();
                    Tx.Size = new Size(123, 20);
                    this.Controls.Add(Tx);
                    ListDrugNameTextboxes.Add(Tx);

                    TextBox qu = new TextBox();
                    qu.Name = "Q" + num;
                    qu.Location = new Point(QX, QY);
                    qu.Text = Q.ToString();
                    qu.Size = new Size(43, 20);
                    qu.Enabled = false;
                    QY += 25;
                    this.Controls.Add(qu);

                    But_receive.Visible = true;
                    But_receive.Location = new Point(207, QY + 25);

                    var patientName = (from H in Hospital.Patients
                                       where H.PatientID == PatientID
                                       select new { H.PatientName }.PatientName).ToList();
                    Txt_patientName.Text = patientName[0].ToString();

                }
            
            }

        private void Com_RoomNo_SelectedIndexChanged(object sender, EventArgs e)
        {

        

        }

        private void But_receive_Click(object sender, EventArgs e)
        {
            var prescriptionDetail = (from pd in Hospital.PrescriptionDetails
                                      join p in Hospital.Prescriptions
                                      on pd.PrescriptionId equals p.PrescriptionId
                                      join r in Hospital.Reservations
                                      on p.ReservationID equals r.ReservationID
                                      where p.ReservationID == reservationID && pd.IsReceived == false

                                      select new { pd.IsReceived, pd.Qnty, p.ReservationID, pd.DrugId, pd.PrescriptionId }).ToList();



            for (int i = 0; i < ListReceivedCheck.Count; i++)
            {
                if (ListReceivedCheck[i].Checked == true)
            {
                object s = (object) prescriptionDetail[i];
                var D = Convert.ToInt32(s.GetType().GetProperty("DrugId").GetValue(s));
                var prescId = Convert.ToInt32(s.GetType().GetProperty("PrescriptionId").GetValue(s));
                bool t = Convert.ToBoolean(s.GetType().GetProperty("IsReceived").GetValue(s));
                int q = Convert.ToInt32(s.GetType().GetProperty("Qnty").GetValue(s));
                  
                        ConnectionClass.SQLCommandWithoutParameters("update [pharmacy].[PrescriptionDetail] set IsReceived= 1 where PrescriptionId =" + prescId + "and DrugId = " + D + "", CommandType.Text, ExecuteReaderOrNonQuery.executeNonQuery);
                        ConnectionClass.SQLCommandWithoutParameters("update  [pharmacy].[Drugs] set Balance-=" + q + "  where DrugId =" + D + "", CommandType.Text, ExecuteReaderOrNonQuery.executeNonQuery);
                       
            }   
         }
            MessageBox.Show("تم التسليم بنجاح");
            this.Close();
        }
        
            
         
    }
}
