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
    public partial class AddDiseases : Form
    {
        public AddDiseases()
        {
            InitializeComponent();
        }

        private void AddDiseases_Load(object sender, EventArgs e)
        {

        }

        private void But_AddDiseases_Click(object sender, EventArgs e)
        {
            hospitalEntities H = new hospitalEntities();
            H.Cproc_AddDiseases(Txt_AddDiseases.Text);
            MessageBox.Show("تمت الإضافة بنجاح");
            Txt_AddDiseases.Clear();
        
        }
    }
}
