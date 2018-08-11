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
    public partial class AddSuppliers : Form
    {
        hospitalEntities Hospital = new hospitalEntities();
        public static SqlParameter GetId = new SqlParameter("GetIdentity", SqlDbType.Int);
        
         
        
        
        public AddSuppliers()
        {
            InitializeComponent();
        }

        private void But_AddContact_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(Com_branch.SelectedValue) != 0)
            { 
                if (string.IsNullOrEmpty(Txt_Contactname.Text) || string.IsNullOrEmpty(Txt_JobTitle.Text) || string.IsNullOrEmpty(Txt_Tel.Text))
            {
                    MessageBox.Show("يرجى استكمال البيانات");
            }
            else
            {
                    Hospital.Cproc_AddSupplierContact(Txt_Contactname.Text, Txt_JobTitle.Text, Txt_Tel.Text, Convert.ToInt32(Com_branch.SelectedValue));
                    Txt_Contactname.Clear();
                    Txt_JobTitle.Clear();
                    Txt_Tel.Clear();
                    MessageBox.Show("تمت إضافة مسؤول اتصال بنجاح");
            }
        }
            else
            {
                MessageBox.Show("يرجى تحديد عنوان فرع الموجود به جهة الاتصال");

            }
        }

        private void But_AddSuppliers_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty (Txt_AddSuppliers.Text))
            { GetId.Direction = ParameterDirection.ReturnValue;
            ConnectionClass.Parameters(new SqlParameter("@supplierName", Txt_AddSuppliers.Text), GetId);
            ConnectionClass.SQLCommand("Cproc_AddSuppliers", CommandType.StoredProcedure, ExecuteReaderOrNonQuery.executeNonQuery);
            Txt_AddSuppliers.Enabled= false;
            But_AddSuppliers.Visible = false;
            Lbl_Address.Visible =true;
                groupBox2.Visible = true; 
            }
            else
            {
                MessageBox.Show("يرجى ادخال اسم المورد");
            }
                                             
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
                if (!string.IsNullOrEmpty(Txt_AddAddress.Text))
                {
                    ConnectionClass.Parameters(new SqlParameter("@supplierId", GetId.Value), new SqlParameter("@supplierAddress", Txt_AddAddress.Text));
                    ConnectionClass.SQLCommand("Cproc_AddSupplierAddress", CommandType.StoredProcedure, ExecuteReaderOrNonQuery.executeNonQuery);
                    Txt_AddAddress.Clear();
                    MessageBox.Show("تم إضافة عنوان فرع بنجاح");
                    groupBox1.Visible = true;
                }
                else
                {
                    MessageBox.Show("يرجى ادخال عنوان المورد");
                }
            
           
        }

        private void AddSuppliers_Load(object sender, EventArgs e)
        {

        }

        private void Lbl_Address_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            List <SupplierAddress> SupList = Hospital.SupplierAddress.ToList ();
            
            
            var filter= SupList.Where (a=> a.SupplierId== Convert.ToInt32(  GetId.Value)).ToList ();
            Com_branch.DataSource = filter;
            Com_branch.DisplayMember = "SupplierAdress";
            Com_branch.ValueMember = "AddressId";
            
           
           
        }
    }
}
