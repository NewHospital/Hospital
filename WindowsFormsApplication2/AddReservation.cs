﻿using System;
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
    public partial class AddReservation : Form
    {
        hospitalEntities Hospital = new hospitalEntities();
        public int Id = AddNewPatient.x;
        
        public AddReservation()
        {
            InitializeComponent();
        }

        private void AddReservation_Load(object sender, EventArgs e)
        {
            var PatientName = (from E in Hospital.Patients
                              where E.PatientID == Id
                              select new { E.PatientName }).ToList();
            Lbl_PatientName.Text = PatientName [0].PatientName;

            SqlConnection Con = new SqlConnection("Data Source=.;Initial Catalog=hospital;Integrated Security=True;MultipleActiveResultSets=True;Application Name=EntityFramework");
            Con.Open();
            SqlCommand Com = new SqlCommand("select Rooms.RoomId, Rooms.RoomNo, Rooms.RoomDegree from Hosting.Rooms where RoomId not in (select RoomId from PatientSector.Reservations where IsActive= 1)", Con);
            SqlDataReader read = Com.ExecuteReader();
            DataTable D = new DataTable();
            D.Columns.Add("roomId");
            D.Columns.Add("RoomNo");
           
            D.Load(read);

            Com_Room.DataSource = D;
            Com_Room.DisplayMember = D.Columns[1].ColumnName;
            Com_Room.ValueMember = D.Columns[0].ColumnName;
         
            Con.Close();

            }

        private void But_Addreservation_Click(object sender, EventArgs e)
        {
            ConnectionClass.Parameters(new SqlParameter("@patientId", Id), new SqlParameter("@RoomId",Com_Room.SelectedValue ), new SqlParameter("@ArriveDate", Convert.ToDateTime (Pick_arriveDate.Value) ), new SqlParameter ("@Discription", RTxt_Remarks.Text));
            ConnectionClass.SQLCommand("AddReservation", CommandType.StoredProcedure, ExecuteReaderOrNonQuery.executeNonQuery);
            MessageBox.Show("تم الحجز بنجاح");
            RTxt_Remarks.Clear();
            this.Close();
            this.Dispose();
        }

        private void Com_Room_SelectedIndexChanged(object sender, EventArgs e)
        {
       
        }

        private void Com_Room_DisplayMemberChanged(object sender, EventArgs e)
        {
        
        }

        private void Com_Room_SelectedValueChanged(object sender, EventArgs e)
        {
            if (Com_Room.SelectedValue != null)
            {
                string n = (((DataRowView)Com_Room.SelectedItem)[0]).ToString();
                int z = int.Parse(n);
                var Q = (from E in Hospital.Rooms
                         where E.RoomId == z
                         select new { E.RoomDegree }).ToList();
                int m = Q[0].RoomDegree;
                var s = (from E in Hospital.RoomsDegrees
                         where E.RoomDegreeID == m
                         select new { E.DegreeName }).ToList();

                Lbl_Degree.Text = s[0].DegreeName;

            }
        }
    }
    }



