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
    public partial class AddFellow : Form
    {
        public AddFellow()
        {
            InitializeComponent();
        }

        private void AddFellow_Load(object sender, EventArgs e)
        {
            
        }

        private void But_AddFellow_Click(object sender, EventArgs e)
        {
            if (AddNewPatient.x !=0)
            { 
            ConnectionClass.Parameters(new SqlParameter("@Fellowname", Txt_FellowName.Text), new SqlParameter("@SoSeNo", Txt_FellowSoSeNo.Text), new SqlParameter("@phoneNumber", Txt_FellowPhone.Text), new SqlParameter("@patientId", AddNewPatient.x));
            ConnectionClass.SQLCommand("Cproc_AddFellow", CommandType.StoredProcedure, ExecuteReaderOrNonQuery.executeNonQuery);
                var Result = MessageBox.Show("أضيف مرافق بنجاح، هل تريد إضافة حجز", "إضافة مرافق", MessageBoxButtons.YesNo);
                if (Result== System.Windows.Forms.DialogResult.No)
                {
                    this.Close();
                    this.Dispose();
                }
                else
                {
                    this.Close();
                    this.Dispose();
                    // add reservation 
                }
            }
        }
    }
}
