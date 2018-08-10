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

namespace Hospital
{
    public partial class AddNewPatient : Form
    {
        public AddNewPatient()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Diseases_Enter(object sender, EventArgs e)
        {

        }

        private void AddNewPatient_Load(object sender, EventArgs e)
        {
            hospitalEntities Hospital = new hospitalEntities();
            List<bloodGroups> BloodList = Hospital.bloodGroups.ToList ();
            DataTable D = new DataTable();
            D.Columns.Add("BloodID");
            D.Columns.Add ("BloodGroupName");
            foreach (var item in BloodList)
            {
                D.Rows.Add(item.BloodID, item.BloodGroupName);
            }
            Com_BloodGroups.DataSource = D;
            Com_BloodGroups.DisplayMember = D.Columns[1].ColumnName;
            Com_BloodGroups.ValueMember = D.Columns[0].ColumnName;
        }

        private void But_AddFellow_Click(object sender, EventArgs e)
        {
            AddFellow AdFellow = new AddFellow();
            AdFellow.ShowDialog();
        }
    }
}
