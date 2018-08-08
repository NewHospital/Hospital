using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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

        }

        private void But_AddFellow_Click(object sender, EventArgs e)
        {
            AddFellow AdFellow = new AddFellow();
            AdFellow.ShowDialog();
        }
    }
}
