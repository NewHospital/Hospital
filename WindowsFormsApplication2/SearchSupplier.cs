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
        public int Row; 
        public SearchSupplier()
        {
            InitializeComponent();
        }

        private void But_Search_Click(object sender, EventArgs e)
        {
            
            hospitalEntities Hospital = new hospitalEntities();
            List<Supplier> SupList = Hospital.Suppliers.ToList ();
            var FilterList = (from s in SupList
                              where s.SupplierName.Contains("" + txt_SearchText.Text + "") 
                              select new {s.SupplierName, s.SupplierId}).ToList();
                             

            dataGridView1.DataSource = FilterList;
            dataGridView1.Columns[1].Visible = false; 
            dataGridView1.Columns[0].HeaderText = "اسم المورد";
            
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
             Row = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[1].FormattedValue);
            this.Hide();
            AddBuyingInvoice BuyInvoice = new AddBuyingInvoice();
            BuyInvoice.fromAnotherForm = 1;
            BuyInvoice.Com_Suppliers.Enabled = false;
            BuyInvoice.ComboSelected = Row - 1; 
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
