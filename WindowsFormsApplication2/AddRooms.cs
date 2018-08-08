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
    public partial class AddRooms : Form
    {
        hospitalEntities Hospital = new hospitalEntities();
        public AddRooms()
        {
            InitializeComponent();
            
        }
        
        private void AddRooms_Load(object sender, EventArgs e)
        {
            
            List<RoomsDegree> RoomsList = Hospital.RoomsDegree.ToList();
            DataTable D = new DataTable();
            D.Columns.Add("RoomDegreeID");
            D.Columns.Add("DegreeName");
            foreach (var item in RoomsList)
            {
                D.Rows.Add(item.RoomDegreeID, item.DegreeName);
            }
            Com_AddRoom.DataSource = D;
            Com_AddRoom.ValueMember = D.Columns[0].ColumnName;
            Com_AddRoom.DisplayMember = D.Columns[1].ColumnName;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //Hospital.cproc_AddRooms (Com_AddRoom.ValueMember, Txt_FloorNo.Text, Txt_RoomNo.Text); 

            ConnectionClass.Parameters(new SqlParameter("@RoomDegree", Com_AddRoom.SelectedValue), new SqlParameter("@Roomfloor", Txt_FloorNo.Text), new SqlParameter("@RoomNo", Txt_RoomNo.Text));
            ConnectionClass.SQLCommand("cproc_AddRooms", CommandType.StoredProcedure, ExecuteReaderOrNonQuery.executeNonQuery);
            Txt_FloorNo.Clear();
            Txt_RoomNo.Clear();
            MessageBox.Show("أضيفت غرفة بنجاح");

        }
    }
}
