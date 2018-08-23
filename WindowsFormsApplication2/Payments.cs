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
        public int x;
        public int cc=0; 
        public Payments()
        {
            InitializeComponent();
        }

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

        private void Com_RoomNo_SelectedValueChanged(object sender, EventArgs e)
        {
            

            object Room = new object();
            Room = Com_RoomNo.SelectedItem;
             x= Convert.ToInt32( Room.GetType().GetProperty("RoomId").GetValue(Room).ToString ());

            var PatientName = (from P in Hospital.Patients
                              join R in Hospital.Reservations
                              on P.PatientID equals R.patientId
                              where R.IsActive == true && R.RoomID== x
                              select new { P.PatientName}.PatientName).ToList ();
            Txt_PatientName.Text = PatientName[0].ToString();
      
            var ArriveDate = (from R in Hospital.Reservations
                              where R.IsActive == true && R.RoomID == x
                              select new { R.ArriveDate}.ArriveDate).ToList();
            string Date = ArriveDate[0].ToString("ddd, dd- MMM- yyy"); 
            Txt_arriveDate.Text = Date;


            var c = (from C in Hospital.Reservations
                     where C.RoomID == x && C.IsActive == true
                     select new { C.ReservationID }.ReservationID).ToList();
            cc = Convert.ToInt32(c[0].ToString());

            try { 
            var S = (from P in Hospital.Payments
                     where P.ReservationId == cc
                     select P.Amount).Sum();
            decimal total = Convert.ToDecimal(S);
            label7.Text = total.ToString();
            label7.Visible = true;
                label7.ForeColor = Color.Red;
                }   
            catch { label7.Text="0"; }


        }


        private void But_Receive_Click(object sender, EventArgs e)
        {
            decimal ValidAmount; 
            if (!string.IsNullOrEmpty (Txt_amount.Text))
            {
                if (decimal.TryParse(Txt_amount.Text, out ValidAmount))
                {
                    string serial = ConnectionClass.PaymentSerial();
                    Hospital.Cproc_AddPayment(cc, serial, Convert.ToDecimal(Txt_amount.Text), Txt_Discription.Text);
                    Txt_amount.Clear();
                    Txt_Discription.Clear();
                    MessageBox.Show(serial + "تم استلام الإيصال برقم");
                }
                else { MessageBox.Show("يرجى كتابة المبلغ المستلم بشكل صحيح"); }
            }
            else { MessageBox.Show("يرجى إدخال المبلغ المدفوع"); }



        }
    }
}
