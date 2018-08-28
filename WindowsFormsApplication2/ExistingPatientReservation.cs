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
    public partial class ExistingPatientReservation : Form
    {
        hospitalEntities Hospital = new hospitalEntities();
        int PatientId; 
        public ExistingPatientReservation()
        {
            InitializeComponent();
        }

        private void ExistingPatientReservation_Load(object sender, EventArgs e)
        {

        }

        private void But_Search_Click(object sender, EventArgs e)
        {
            var PatientName = (from E in Hospital.Patients
                               where E.PatientName.Contains (Txt_Search.Text)
                               select new { E.PatientName, E.PatientID }).ToList();
            GridResult.DataSource = PatientName;
            GridResult.Columns[0].HeaderText = "اسم المريض";
            GridResult.Columns[1].Visible = false; 
        }

        private void GridResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void GridResult_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {


            PatientId = Convert.ToInt32(GridResult.Rows[e.RowIndex].Cells["PatientID"].FormattedValue.ToString());

            if (RdBut_Reservation.Checked== true)
            { 
            var ExistOrNOt = (from H in Hospital.Reservations
                                  where H.patientId == PatientId && H.IsActive == true
                                  select new { H.patientId }).ToList();

                if (ExistOrNOt.Count == 0)
                { 
            AddReservation Reservation = new AddReservation();
            Reservation.Id = PatientId; 
            Reservation.ShowDialog();
            this.Close();
                }
                else
                {
                    MessageBox.Show("هذا المريض مسجل له حجز حاليا، يرجى تسجيل خروجه قبل حجز الغرفة");
                    this.Close();
                    ExistingPatientReservation Exist = new ExistingPatientReservation();
                    Exist.Show();
                    Exist.WindowState = FormWindowState.Normal;
                  
                }
            }

            

            else if (RdBut_Fellow.Checked== true)
            {
                
                AddFellow F = new AddFellow();
                this.Close();
                F.patientId = PatientId;
                F.WindowState = FormWindowState.Normal;
                F.TopMost = true; 
                F.Show();
                


            }
            else
            {
                MessageBox.Show("يرجى تحديد نوع الإضافة حجز/ مرافق");
            }
        }
    }
}
