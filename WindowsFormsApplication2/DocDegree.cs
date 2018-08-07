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
    public partial class DocDegree : Form
    {
        public DocDegree()
        {
            InitializeComponent();
        }

        private void DocDegree_Load(object sender, EventArgs e)
        {

        }

        private void But_AddDocDegree_Click(object sender, EventArgs e)
        {
            ConnectionClass.Parameters(new SqlParameter("@ScientificDegreeName", Txt_AddDocDegree.Text));
            ConnectionClass.SQLCommand("Cproc_DocDegrees", CommandType.StoredProcedure, ExecuteReaderOrNonQuery.executeNonQuery);
            MessageBox.Show("تم اضافة تخصص طبي بنجاح");
            Txt_AddDocDegree.Clear();            

        }
    }
}
