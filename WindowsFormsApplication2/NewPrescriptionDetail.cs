using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using Hospital; 

namespace WindowsFormsApplication2
{
    public partial class NewPrescriptionDetail : Form
    {
        hospitalEntities Hospital = new hospitalEntities();
        public int ReservationId;
        public int DocId;
        public int PatientID;
        List<int> QntyLis = new List<int> ();
        List<string> DoseList= new List<string>();
        List<int> IdList = new List<int>();


        SqlParameter X = new SqlParameter();
        int XDrug = 344;
        int YDrug = 59;
        int XQnty = 267;
        int YQnty = 59;
        int XDisc = 12;
        int YDisc = 59;
        
        public NewPrescriptionDetail()
        {
            InitializeComponent();
        }

        private void NewPrescriptionDetail_Load(object sender, EventArgs e)
        {
            IdList.Clear();
            for (int i = 0; i < AddNewPrescription.Value.Count; i++)
            {
                TextBox Drug = new TextBox();
                Drug.Text = AddNewPrescription.Value[i].ToString();
                Drug.Name = AddNewPrescription.Value[i].ToString();
                Drug.Size = new System.Drawing.Size(97, 20);
                Drug.Location = new System.Drawing.Point(XDrug, YDrug);
                Drug.Enabled = false;
                this.Controls.Add(Drug);

                TextBox Qnty = new TextBox();
                Qnty.Name = i.ToString();
                Qnty.Size = new Size(57, 20);
                Qnty.Location = new Point(XQnty, YQnty);
                Qnty.RightToLeft = RightToLeft.Yes;
                this.Controls.Add(Qnty);

                TextBox Disc = new TextBox();
                Disc.Name = i + 100.ToString();
                Disc.Size = new Size(235, 20);
                Disc.Location = new Point(XDisc, YDisc);
                Disc.RightToLeft = RightToLeft.Yes;
                this.Controls.Add(Disc);
                YDrug += 25;
                YQnty += 25;
                YDisc += 25;
            }
            But_Save.Location = new Point(192, YDrug + 30);
            But_Save.Visible = true;
            
        }

        private void But_Save_Click(object sender, EventArgs e)
        {
            IdList.Clear();
            foreach (var item in AddNewPrescription.Value)
            {
                var IdX = (from H in Hospital.Drugs
                           where H.DrugName == item
                           select new { H.DrugId }.DrugId).ToList();
                int Id = IdX[0];
                IdList.Add(Id);
                             
            }
            HelpClass.VisibleOrNot (true, But_send);
            But_send.Location = new Point(192, YDrug + 70);
            HelpClass.EnabledOrDisabled(false, But_Save);

            for (int i = 6; i < Controls.Count; i+=3)
            {
                if (!string.IsNullOrEmpty(Controls[i].Text) && !string.IsNullOrEmpty(Controls[(i + 1)].Text))
                {
                   
                    X.Direction = ParameterDirection.ReturnValue; 
                    int ValidQuant;
                    if (int.TryParse(Controls[i].Text, out ValidQuant))
                    {
                        QntyLis.Add(Convert.ToInt32(Controls[i].Text));
                        DoseList.Add(Controls[i + 1].Text);
                   
                    } 
                    else
                    {
                        But_send.Visible = false;
                        MessageBox.Show("يرجى إدخال الكمية بشكل صحيح");
                        But_Save.Enabled = true;
                        QntyLis.Clear();
                        DoseList.Clear();
                        break;
                    }
          
                }
                else {
                    But_send.Visible = false;
                    MessageBox.Show("يرجى استكمال بيانات الروشته");
                    But_Save.Enabled = true;
                    QntyLis.Clear();
                    DoseList.Clear();
                    break; 
                     }

            }
            
      
        }
  

        private void But_send_Click_1(object sender, EventArgs e)
        {
         
            ConnectionClass.Parameters(new SqlParameter("@DocId", DocId), new SqlParameter("@reservationid", ReservationId), X);
            ConnectionClass.SQLCommand("Cprco_AddNewPrescription", CommandType.StoredProcedure, ExecuteReaderOrNonQuery.executeNonQuery);
            int PrescriptionId = Convert.ToInt32(X.Value);

            for (int i = 0; i < IdList.Count; i++)
            {
                ConnectionClass.Parameters(new SqlParameter("@PrescriptionId", PrescriptionId), new SqlParameter("@drugID", IdList[i]), new SqlParameter("@Qnty", QntyLis[i]), new SqlParameter("@dose", DoseList[i]));
                ConnectionClass.SQLCommand("Cproc_AddPrescriptionDetail", CommandType.StoredProcedure, ExecuteReaderOrNonQuery.executeNonQuery);
                
            }
            
            MessageBox.Show("تم الإرسال بنجاح");
            this.Close();
            AddNewPrescription.Value.Clear();
        }
    }
}