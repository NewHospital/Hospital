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

namespace WindowsFormsApplication2
{
    
    public partial class DoctorFollowUp : Form
    {
        hospitalEntities Hospital = new hospitalEntities();
        public DoctorFollowUp()
        {
            InitializeComponent();
        }

        private void DoctorFollowUp_Load(object sender, EventArgs e)
        {
            List<Reservations> OccupiedRooms = Hospital.Reservations.ToList();
            //List<Rooms> roomNo = Hospital.Rooms.ToList();
            //var x = (from E in OccupiedRooms
            //         join R in roomNo
            //         on E.RoomID equals R.RoomId
            //         select new { E.ReservationID, R.RoomNo }).ToList();

            Com_RoomNo.DataSource = OccupiedRooms;
            Com_RoomNo.ValueMember = "ReservationID";
            Com_RoomNo.ValueMember = "RoomID";
        }
    }
}
