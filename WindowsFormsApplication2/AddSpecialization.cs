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
    public partial class AddSpecialization : Form
    {
        public AddSpecialization()
        {
            InitializeComponent();
        }

        private void But_AddSpecialization_Click(object sender, EventArgs e)
        {
            ConnectionClass.Parameters(new SqlParameter("@SpecificationName", Txt_AddSpecialization.Text));
            ConnectionClass.SQLCommand("Cproc_AddSpecialization", CommandType.StoredProcedure, ExecuteReaderOrNonQuery.executeNonQuery);
            MessageBox.Show("تم إضافة تخصص طبي");
            Txt_AddSpecialization.Clear();


        }
    }
}
