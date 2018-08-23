using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApplication2;
using System.Data.SqlClient;

namespace Hospital
{
    public partial class AddNewPatient : Form
    {
        public static SqlParameter PatientId = new SqlParameter("Id", SqlDbType.Int);
        public static int x;

        public AddNewPatient()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Diseases_Enter(object sender, EventArgs e)
        {

        }

        private void AddNewPatient_Load(object sender, EventArgs e)
        {
            hospitalEntities Hospital = new hospitalEntities();
            List<bloodGroup> BloodList = Hospital.bloodGroups.ToList();
            Com_BloodGroups.DataSource = BloodList;
            Com_BloodGroups.ValueMember = "BloodID";
            Com_BloodGroups.DisplayMember = "BloodGroupName";

            But_AddReservation.Visible = false;
            But_AddFellow.Visible = false;
        }

        private void But_AddFellow_Click(object sender, EventArgs e)
        {
            AddFellow AdFellow = new AddFellow();
            AdFellow.ShowDialog();
        }

        private void But_AddPatient_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Txt_PatientName.Text) && !string.IsNullOrEmpty(Txt_Mobile.Text) && !string.IsNullOrEmpty(Txt_Address.Text))
            {
                if (radioButton1.Checked == false && radioButton2.Checked == false)
                { MessageBox.Show("برجاء تحديد نوع الجنس"); }
                else
                { if (!string.IsNullOrEmpty(Txt_SoSeNo.Text))
                    { if (Txt_SoSeNo.Text.Length != 14)
                        { MessageBox.Show("برجاء كتابة رقم البطاقة بشكل صحيح مكونة من 14 رقم"); }
                        else
                        {
                            try
                            { PatientId.Direction = ParameterDirection.ReturnValue;
                                
                                ConnectionClass.Parameters(new SqlParameter("@patientName", Txt_PatientName.Text), new SqlParameter("@Gender", radioButton1.Checked), new SqlParameter("@DoB", Convert.ToDateTime(Pik_DOB.Text)), new SqlParameter("@SoSeNo", Txt_SoSeNo.Text), new SqlParameter("@BloodGroup", Convert.ToInt32(Com_BloodGroups.SelectedValue)), new SqlParameter("@phoneNumber", Txt_Mobile.Text), new SqlParameter("@address", Txt_Address.Text), PatientId);
                                ConnectionClass.SQLCommand("Cproc_AddNewPatient", CommandType.StoredProcedure, ExecuteReaderOrNonQuery.executeNonQuery);
                                x = (int)PatientId.Value;
                                var result = MessageBox.Show("هل تريد إضافة مرافق أو حجز", "تم التسجيل بنجاح", MessageBoxButtons.YesNo);
                                if (result == System.Windows.Forms.DialogResult.No)
                                {
                                    ConnectionClass.ParameterList.Clear();
                                    this.Close();
                                    this.Hide();
                                    this.Dispose();
                                }
                                else
                                {
                                    ConnectionClass.ParameterList.Clear();
                                    Txt_Address.Enabled = false;
                                    Txt_Mobile.Enabled = false;
                                    Txt_PatientName.Enabled = false;
                                    Txt_SoSeNo.Enabled = false;
                                    Pik_DOB.Enabled = false;
                                    Com_BloodGroups.Enabled = false;
                                    radioButton1.Enabled = false;
                                    radioButton2.Enabled = false;


                                    But_AddPatient.Location = new System.Drawing.Point(411, 396);
                                    But_AddPatient.Enabled = false;
                                    But_AddFellow.Location = new System.Drawing.Point(238, 396);
                                    But_AddFellow.Visible = true;
                                    But_AddReservation.Location = new System.Drawing.Point(58, 396);
                                    But_AddReservation.Visible = true;

                                }
                            }
                            catch (SqlException SQLEx)
                            {
                                if (SQLEx.Number == 2627)
                                {
                                    MessageBox.Show("هذا المريض مسجل من قبل");
                                    ConnectionClass.MyCommand.Parameters.Clear();
                                    ConnectionClass.ParameterList.Clear();
                                    ConnectionClass.MyCOnnection.Close();
                                    this.Close();
                                    this.Dispose();          

                                }
                            }
                    
                        }
                    }


                    else { MessageBox.Show("يرجى إدخال الرقم القومي"); }
                }
            
            }
            else { MessageBox.Show("برجاء ادخال اسم المريض ورقم تليفونه وعنوانه"); }

        }

        private void But_AddReservation_Click(object sender, EventArgs e)
        {
            AddReservation reservation = new AddReservation();
            reservation.ShowDialog();
            this.Close();
            this.Dispose();
        }
    }
} 

