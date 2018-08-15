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

namespace WindowsFormsApplication2
{
    public partial class SearchSupplier : Form
    {
        public static string x; 
        public SearchSupplier()
        {
            InitializeComponent();
        }

        private void But_Search_Click(object sender, EventArgs e)
        {
            
            hospitalEntities Hospital = new hospitalEntities();
            List<Suppliers> SupList = Hospital.Suppliers.ToList ();
            var FilterList = (from s in SupList
                              where s.SupplierName.Contains("" + txt_SearchText.Text + "") 
                              select new {s.SupplierName}).ToList();
                             

            dataGridView1.DataSource = FilterList;
            
            dataGridView1.Columns[0].HeaderText = "اسم المورد";
            
            




        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var RowIndex = e.RowIndex;
            DataGridViewRow Row = dataGridView1.Rows[RowIndex];
             x = Row.Cells[0].Value.ToString ();
            
            this.Hide();
            AddBuyingInvoice BuyInvoice = new AddBuyingInvoice();
          
            BuyInvoice.Com_Suppliers.Enabled = false; 
            BuyInvoice.ShowDialog();
             
            


        }

        private void SearchSupplier_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
