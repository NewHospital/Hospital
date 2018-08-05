using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Hospital
{
    public partial class AddDrugUnits : Form
    {
        
        public AddDrugUnits()
        {
            InitializeComponent();
            ConnectionClass.Connection("Data Source=.;Initial Catalog=hospital;Integrated Security=True");

        }

        private void AddDrugUnits_Load(object sender, EventArgs e)
        {
           
        }

        private void But_AddDrugUnits_Click(object sender, EventArgs e)
        {
            ConnectionClass.parameters(new SqlParameter("@DtugUnitName", Txt_AddDrugUnits.Text));
            ConnectionClass.SQLCommand("Cproc_AddDrugUnits", MyCommandtype.storedProcedure, ExecuteReaderOrNonQuery.executeNonQuery);
            MessageBox.Show("تم إضافة وحدة الدواء بنجاح");
            Txt_AddDrugUnits.Clear();

        }
    }
}
