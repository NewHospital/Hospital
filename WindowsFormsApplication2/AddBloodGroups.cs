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
    public partial class AddBloodGroups : Form
    {
        public AddBloodGroups()
        {
            InitializeComponent();

            



        }

        private void AddBloodGroups_Load(object sender, EventArgs e)
        {
            
        }

        private void But_AddBloodGroup_Click(object sender, EventArgs e)
        {
           
            ConnectionClass.parameters(new  SqlParameter ("@BloodGroupName", Txt_AddBloodGroup.Text));
            ConnectionClass.SQLCommand("Cproc_AddBloodGroup", CommandType.StoredProcedure, ExecuteReaderOrNonQuery.executeNonQuery);
            Txt_AddBloodGroup.Clear();
            MessageBox.Show("تم إضافة الفصيلة بنجاح");
        }

        private void Txt_AddBloodGroup_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
