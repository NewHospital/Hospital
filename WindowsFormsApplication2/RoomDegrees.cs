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
    public partial class RoomDegrees : Form
    {
        public RoomDegrees()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void But_AddRoomDegree_Click(object sender, EventArgs e)
        {
            decimal value = 0;
            if (decimal.TryParse(Txt_AddFeesPerDay.Text, out value))
            { 
            ConnectionClass.Parameters(new SqlParameter("@Name", Txt_AddNameDegree.Text), new SqlParameter("@FeesDay", value), new SqlParameter("@Discription", Txt_AddDiscription.Text));
            ConnectionClass.SQLCommand("Cproc_AddRoomsDegree", CommandType.StoredProcedure, ExecuteReaderOrNonQuery.executeNonQuery);
            Txt_AddDiscription.Clear();
            Txt_AddFeesPerDay.Clear();
            Txt_AddNameDegree.Clear();
            MessageBox.Show("تم إضافة درجة الغرفة بنجاح");
            }
            else
            {
                MessageBox.Show("يرجى إدخال رقم فقط لمصاريف الاستضافة");
            }
        }
    }
}
