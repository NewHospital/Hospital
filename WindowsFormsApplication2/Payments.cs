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
    public partial class Payments : Form
    {
        hospitalEntities Hospital = new hospitalEntities();
        object x = new object();
        public int IdRoom { set; get; }
        public int Reservation { set; get; }
        public int fromAnotherForm = 0;
         decimal amountDue;
         decimal SumPrescription;
        public Payments()
        {
            InitializeComponent();
        }


        //public void setCombo (int n)
        //{
            
        //    //Com_RoomNo.SelectedItem.GetType().GetProperty("RoomId").GetValue(Com_RoomNo.SelectedItem) ;
        //    //x.GetType().GetProperty("RoomId").GetValue (x);
        //    //int y= Convert.ToInt32( x.GetType().GetProperty("RoomId").GetValue(x));

        //    var m =Com_RoomNo.SelectedIndex= 

        //    //Com_RoomNo.SelectedIndex = Com_RoomNo.Items.IndexOf(y);

        //    Com_RoomNo.Enabled = false;
        //}

        private void Payments_Load(object sender, EventArgs e)
        {
            var ActiveRooms = (from R in Hospital.Rooms
                               join Rs in Hospital.Reservations
                               on R.RoomId equals Rs.RoomID
                               where Rs.IsActive == true  
                               select new { R.RoomId, R.RoomNo }).ToList();

            Com_RoomNo.DataSource = ActiveRooms;
            Com_RoomNo.ValueMember = "RoomId";
            Com_RoomNo.DisplayMember = "RoomNo";
          
           }

        public string ReturnRoomNo (int RoomID)
        {
            var x = (from H in Hospital.Rooms
                     where H.RoomId == RoomID
                     select H.RoomNo).ToList();
            return x[0].ToString();
        }

        private void Com_RoomNo_SelectedValueChanged(object sender, EventArgs e)
        {
            Txt_amount.Enabled = false;
            Txt_Discription.Enabled = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false; 

            if (fromAnotherForm == 0)
            {             
            object Room = new object();
            Room = Com_RoomNo.SelectedItem;
            IdRoom = Convert.ToInt32( Room.GetType().GetProperty("RoomId").GetValue(Room).ToString ());
            }

            var PatientName = (from P in Hospital.Patients
                              join R in Hospital.Reservations
                              on P.PatientID equals R.patientId
                              where R.IsActive == true && R.RoomID== IdRoom
                               select new { P.PatientName}.PatientName).ToList ();
            Txt_PatientName.Text = PatientName[0].ToString();
      
            var ArriveDate = (from R in Hospital.Reservations
                              where R.IsActive == true && R.RoomID == IdRoom
                              select new { R.ArriveDate}.ArriveDate).ToList();
            string Date = ArriveDate[0].ToString("ddd, dd- MMM- yyy"); 
            Txt_arriveDate.Text = Date;


            var c = (from C in Hospital.Reservations
                     where C.RoomID == IdRoom && C.IsActive == true
                     select new { C.ReservationID }.ReservationID).ToList();
            Reservation = Convert.ToInt32(c[0].ToString());

            try { 
            var S = (from P in Hospital.Payments
                     where P.ReservationId == Reservation 
                     select P.Amount).Sum();
            decimal total = Convert.ToDecimal(S);
                        
                }   
            catch { label7.Text="0"; }
         
        }


        private void But_Receive_Click(object sender, EventArgs e)
        {
            decimal ValidAmount; 
            if (!string.IsNullOrEmpty (Txt_amount.Text) || Txt_amount.Text== "0")
            {
                if (decimal.TryParse(Txt_amount.Text, out ValidAmount))
                {
                    string serial = ConnectionClass.PaymentSerial();
                    Hospital.Cproc_AddPayment(Reservation, serial, Convert.ToDecimal(Txt_amount.Text), Txt_Discription.Text);
                    Txt_amount.Clear();
                    Txt_Discription.Clear();
                    var result= MessageBox.Show( "تم الاستلام بالإيصال، هل تريد تسجيل خروج للمريض", serial , MessageBoxButtons.YesNo);
                    if (result== System.Windows.Forms.DialogResult.Yes)
                    {
                       
                        this.Close();
                        Checkout Checkout = new Checkout();
                        Checkout.fromAnotherForm = 1;
                        Checkout.RoomId = IdRoom;
                        Checkout.x = IdRoom; 
                        TextBox Tx = new TextBox();
                        Tx.Text = Checkout.RoomNO(IdRoom);
                        Checkout.Controls[14].Hide();
                        Tx.Location = new System.Drawing.Point (375, 53);
                        Tx.Enabled = false;
                        Tx.RightToLeft = RightToLeft.Yes;
                        Checkout.Controls.Add(Tx);
                        
                        Checkout.Show();
                        Checkout.WindowState = FormWindowState.Normal;
                        Checkout.TopMost = true; 
                    }
                    else { this.Close(); }
                    
                }
                else { MessageBox.Show("يرجى كتابة المبلغ المستلم بشكل صحيح"); }
            }
            else { MessageBox.Show("يرجى إدخال المبلغ المدفوع"); }



        }

        private void But_Receive_MouseHover(object sender, EventArgs e)
        {
            Txt_amount.Enabled = true;
            Txt_Discription.Enabled = true; 
            decimal DSum;
            try
            {
                var sum = (from P in Hospital.Payments
                           where P.ReservationId == Reservation
                           select P.Amount).Sum();
      
                DSum = sum;
            }
            catch
            {
               
                DSum = 0;
            }
                      
            ConnectionClass.SQLCommandWithoutParameters("select publicSchema.CalculateHostingFees (" + Reservation + ")", CommandType.Text, ExecuteReaderOrNonQuery.executeScalar);
            int HostingamountDue = ConnectionClass.scalarReturn;
            
            try
            {
                SumPrescription = (from H in Hospital.VW_Prescription
                                   where H.ReservationID == Reservation && H.IsReceived==true
                                   select (H.Qnty * H.PricePerUnit)).Sum();
            }
            catch { SumPrescription = 0; }

            amountDue = SumPrescription + HostingamountDue;
            label7.Text = amountDue.ToString();
            label7.Visible = true;
            label9.Text = DSum.ToString();
            label9.Visible = true;
            label8.Text = (amountDue - DSum).ToString();
            label8.Visible = true;
        }
    }
}
