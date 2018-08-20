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
using System.Configuration;

namespace WindowsFormsApplication2
{
    public partial class FollowUp : Form
    {
        hospitalEntities Hospital = new hospitalEntities();
        public FollowUp()
        {
            InitializeComponent();
        }

        private void FollowUp_Load(object sender, EventArgs e)
        {
            ConnectionClass.SQLCommandWithoutParameters("select [ReservationID], [RoomNo]from [PatientSector].[Reservations] join [Hosting].[Rooms]on Reservations.RoomID= Rooms.RoomId where Reservations.IsActive = 1", CommandType.Text, ExecuteReaderOrNonQuery.executeReader);
            DataTable D = ConnectionClass.MyDataTable;
            Com_RoomNo.DataSource = D;
            Com_RoomNo.ValueMember = D.Columns[0].ColumnName;
            Com_RoomNo.DisplayMember = D.Columns[1].ColumnName;


          

        }

        private void Com_RoomNo_SelectedValueChanged(object sender, EventArgs e)
        {
           
            string txt = (((DataRowView)Com_RoomNo.SelectedItem)[1]).ToString(); 
            SqlConnection Conn = new SqlConnection("Data Source=.;Initial Catalog=hospital;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework");
            SqlCommand Com = new SqlCommand("select DoctorId, DocName from MedicalSector.Doctors where DoctorId not in (select DoctorID from PatientSector.Reservations R join [PatientSector].[DocfollowUp] D on D.ReservationID= R.ReservationID join Hosting.Rooms on r.RoomID= Rooms.RoomId where r.IsActive = 1 and RoomNo="+ txt+ ")", Conn);
            Conn.Open();
            SqlDataReader Read = Com.ExecuteReader();
            DataTable D1 = new DataTable();
            D1.Load(Read);
            Conn.Close();
            ((ListBox)Ch_Doctors).DataSource = D1;
            ((ListBox)Ch_Doctors).ValueMember = D1.Columns[0].ColumnName;
            ((ListBox)Ch_Doctors).DisplayMember = D1.Columns[1].ColumnName;


            if (Com_RoomNo.SelectedValue != null)
            { 
            string M = (((DataRowView)Com_RoomNo.SelectedItem)[1]).ToString();
            var x = (from E in Hospital.Reservations
                     join R in Hospital.Rooms
                     on E.RoomID equals R.RoomId
                     where E.IsActive == true && R.RoomNo == M
                     select new { E.ReservationID }.ReservationID).First().ToString();
            int Y = int.Parse(x);
            
            var s = (from E in Hospital.Reservations
                     join R in Hospital.Patient
                     on E.patientId equals R.PatientID
                     where E.ReservationID== Y
                     select new { R.PatientName}.PatientName).First().ToString();
                Txt_patientName.Text = s; 
            }

        }

        private void Com_RoomNo_SelectionChangeCommitted(object sender, EventArgs e)
        {
  
            
        }

        private void But_AddFollow_Click(object sender, EventArgs e)
        {

            if (Ch_Doctors.CheckedItems.Count!=0)
            { 
            string M = (((DataRowView) Com_RoomNo.SelectedItem)[1]).ToString();
            var x = (from E in Hospital.Reservations
                     join R in Hospital.Rooms
                     on E.RoomID equals R.RoomId
                     where E.IsActive == true && R.RoomNo == M
                     select new { E.ReservationID }.ReservationID).First().ToString();


                List<string> L = new List<string>();

                                         
                foreach (DataRowView item in Ch_Doctors.CheckedItems)
                {
                    L.Add((item[0]).ToString());
                }

                for (int N = 0; N < L.Count; N++)
                {
                    ConnectionClass.Parameters(new SqlParameter("@reservationId", int.Parse(x)), new SqlParameter("@DocId", L[N]));
                    ConnectionClass.SQLCommand("Cproc_AddDocFollowUp", CommandType.StoredProcedure, ExecuteReaderOrNonQuery.executeNonQuery);

                }
                MessageBox.Show("تم إضافة المتابعة بنجاح");
                this.Close();
            }
            else { MessageBox.Show("يرجى تحديد الطبيب المتابع"); }

        }



        private void Ch_Doctors_SelectedValueChanged(object sender, EventArgs e)
        {

        }
    }
}
