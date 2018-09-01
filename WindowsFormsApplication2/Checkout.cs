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
using System.Data.SqlClient; 

namespace WindowsFormsApplication2
{
    public partial class Checkout : Form
    {
        hospitalEntities Hospital = new hospitalEntities();
        public decimal amountDue=0; 
        public int fromAnotherForm = 0;
        public string PName;
        public int ReservationId;
        public DateTime D;
        public decimal DSum=0;
        public int RoomId;
        public int x; 

        public Checkout()
        {
            InitializeComponent();
            
        }

        public string RoomNO (int RId)
        {
            var x = (from H in Hospital.Rooms
                     where H.RoomId == RId
                     select H.RoomNo).ToList();
            return x[0].ToString();
        }

        private void Checkout_Load(object sender, EventArgs e)
        {
            
            var Rooms = (from R in Hospital.Rooms
                         join RS in Hospital.Reservations
                         on R.RoomId equals RS.RoomID
                         where RS.IsActive == true
                         select new { R.RoomId, R.RoomNo }).ToList();
            Com_RoomNo.DataSource = Rooms;
            Com_RoomNo.ValueMember = "RoomId";
            Com_RoomNo.DisplayMember = "RoomNo";
        }

        private void Com_RoomNo_SelectedValueChanged(object sender, EventArgs e)
        {
            HelpClass.VisibleOrNot(false, label7, label9, label8, label10);
            if (fromAnotherForm==0)
            { 
            object S = new object();
            S = Com_RoomNo.SelectedItem;
            x = Convert.ToInt32(S.GetType().GetProperty("RoomId").GetValue(S));
            }
            var PatientName = (from R in Hospital.Reservations
                               join p in Hospital.Patients
                               on R.patientId equals p.PatientID
                               where R.IsActive == true && R.RoomID == x
                               select new { p.PatientName, R.ReservationID, R.ArriveDate, R.RoomID }).ToList();
             PName = PatientName[0].PatientName.ToString();
             ReservationId = Convert.ToInt32(PatientName[0].ReservationID);
             D = Convert.ToDateTime(PatientName[0].ArriveDate);
             RoomId = Convert.ToInt32(PatientName[0].RoomID);
            try
            { 
            var sum = (from P in Hospital.Payments
                       where P.ReservationId == ReservationId
                       select P.Amount).Sum();
                Txt_TotalPaid.Text = sum.ToString();
                
                DSum = sum; 
            }
            catch {
                        Txt_TotalPaid.Text = "0";
                        DSum = 0;
                  }
            
            Txt_Arrival.Text = D.ToString("ddd, dd- MMM- yyyy");
            Txt_PatientName.Text = PName;
        }

       
 private void button1_Click(object sender, EventArgs e)
        {
            ConnectionClass.SQLCommandWithoutParameters("select publicSchema.CalculateHostingFees (" + ReservationId + ")", CommandType.Text, ExecuteReaderOrNonQuery.executeScalar);
            int HostingamountDue = ConnectionClass.scalarReturn;
            decimal SumPrescription;    
            try {
                     SumPrescription = (from H in Hospital.VW_Prescription
                     where H.ReservationID == ReservationId && H.IsReceived== true
                     select H.Qnty * H.PricePerUnit).Sum();
                }
            catch { SumPrescription = 0; }

         amountDue=SumPrescription+HostingamountDue;
        if (amountDue > DSum)
            {
                var Result= MessageBox.Show("يجب استكمال المستحقات قبل تسجيل الخروج ، هل تريد سداد المستحقات الآن", "استكمال المستحقات", MessageBoxButtons.YesNo);
                if (Result == System.Windows.Forms.DialogResult.Yes)
                {
                    this.Close();
                    label8.Text = amountDue.ToString();
                    label10.Text = (amountDue - DSum).ToString();
                    Payments Pay = new Payments();
                    Pay.fromAnotherForm = 1;
                    Pay.IdRoom = RoomId;
                    //Pay.Controls[11].Hide();
                    
                    TextBox Txt = new TextBox();
                    Txt.Text = Pay.ReturnRoomNo(RoomId);
                    Txt.Enabled = false;
                    Txt.RightToLeft = RightToLeft.Yes;
                    Txt.Location = new System.Drawing.Point(215, 47);
                    Pay.Controls.Add(Txt);
                    Pay.Controls["Com_RoomNo"].Visible = false; 
                    Pay.Show();
                    Pay.WindowState = FormWindowState.Normal;
                    Pay.TopMost = true;

                }
                else { this.Close(); }
                
            }  
        else
                
            {
                DateTime CheckoutTime = DateTime.Now;
                Hospital.Cproc_Checkout(ReservationId, CheckoutTime, Txt_Remarks.Text);
                MessageBox.Show("تم تسجيل خروج المريض");
                this.Close();
            }

        }

        private void Pay_Load(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void But_CheckOut_MouseHover(object sender, EventArgs e)
        {
            HelpClass.VisibleOrNot(true, label7, label9, label8, label10);
            ConnectionClass.SQLCommandWithoutParameters("select publicSchema.CalculateHostingFees (" + ReservationId + ")", CommandType.Text, ExecuteReaderOrNonQuery.executeScalar);
            int HostingamountDue = ConnectionClass.scalarReturn;
            decimal SumPrescription;
            try
            {
                SumPrescription = (from H in Hospital.VW_Prescription
                                   where H.ReservationID == ReservationId && H.IsReceived== true
                                   select H.Qnty * H.PricePerUnit).Sum();
            }
            catch { SumPrescription = 0; }
            amountDue = SumPrescription + HostingamountDue;
            label8.Text = (amountDue).ToString();
            label10.Text = (amountDue-DSum).ToString();

        }
    }
}
