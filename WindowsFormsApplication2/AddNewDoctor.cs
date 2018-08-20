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
    public partial class AddNewDoctor : Form
    {
        public AddNewDoctor()
        {
            InitializeComponent();
        }

        private void AddNewDoctor_Load(object sender, EventArgs e)
        {
            hospitalEntities Hospital = new hospitalEntities();
            List <Specification> DocSpecilizationList = Hospital.Specification.ToList();
            DataTable DT = new DataTable();
            DT.Columns.Add("SpecificationId");
            DT.Columns.Add("SpecificationName");
            Com_Specification.DataSource = DT;
            foreach (var item in DocSpecilizationList)
            {
                DT.Rows.Add(item.SpecificationId, item.SpecificationName);
            }
            Com_Specification.DisplayMember = DT.Columns [1].ColumnName;
            Com_Specification.ValueMember = DT.Columns [0].ColumnName;

            List <ScientificDegree> DocDegreeList = Hospital.ScientificDegree.ToList();
            DataTable DT1 = new DataTable();
            DT1.Columns.Add("ScientificDegreeId");
            DT1.Columns.Add("ScientificDegreeName");
            foreach (var item in DocDegreeList)
            {
                DT1.Rows.Add(item.ScientificDegreeId, item.ScientificDegreeName);
            }
            Com_Degree.DataSource = DT1;
            Com_Degree.DisplayMember = DT1.Columns[1].ColumnName;
            Com_Degree.ValueMember = DT1.Columns[0].ColumnName; 





        }

        private void But_AddDoc_Click(object sender, EventArgs e)
        {
            try
            {
                bool x = true;
                if (Rad_Male.Checked)
                {
                    x = true;
                }
                else if (Rad_Female.Checked)
                {
                    x = false;
                }

                ConnectionClass.Parameters(new SqlParameter("@DocName", Txt_DocName.Text), new SqlParameter("@DocAddress", Txt_DoCAddress.Text), new SqlParameter("@Docphone", Txt_DocTel.Text), new SqlParameter("@DocDegree", Com_Degree.SelectedValue), new SqlParameter("@DocSpecification", Com_Specification.SelectedValue), new SqlParameter("@gender", x));
                ConnectionClass.SQLCommand("Cproc_AddNewDoc", CommandType.StoredProcedure, ExecuteReaderOrNonQuery.executeNonQuery);
                Txt_DoCAddress.Clear();
                Txt_DocName.Clear();
                Txt_DocTel.Clear();
                MessageBox.Show("تم إضافة طبيب");
            }
            catch (SqlException Ex)
            {
                if (Ex.Number == 2627)
                {
                    MessageBox.Show("هذا الطبيب مسجل من قبل");
                    ConnectionClass.MyCOnnection.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AddSpecialization Specialization = new AddSpecialization();
            Specialization.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DocDegree Degree = new DocDegree();
            Degree.ShowDialog();
        }
    }
}
