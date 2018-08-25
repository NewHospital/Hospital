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
            if (RdBut_Reservation.Checked== true)
            { 
            
            PatientId = Convert.ToInt32 (GridResult.Rows[e.RowIndex].Cells["PatientID"].FormattedValue.ToString());
            
            AddReservation Reservation = new AddReservation();
            Reservation.Id = PatientId; 
            Reservation.ShowDialog();
            this.Close();
            }
            else if (RdBut_Fellow.Checked== true)
            {
                
                PatientId = Convert.ToInt32(GridResult.Rows[e.RowIndex].Cells["PatientID"].FormattedValue.ToString());

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
