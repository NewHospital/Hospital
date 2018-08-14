﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Hospital;

namespace WindowsFormsApplication2
{
    public partial class AddBuyingInvoice : Form
    {
        public AddBuyingInvoice()
        {
            InitializeComponent();
        }
        public static int C; 

        public static List<ComboBox> DrugUnitList = new List<ComboBox>();
        public static List<string> DrugUnitValue = new List<string>();

        public static List<TextBox> QntyTextboxList = new List<TextBox>();
        public static List<string> QntyValueList = new List<string>();

        public static List<TextBox> PriceTextboxList = new List<TextBox>();
        public static List<string> PriceValueList = new List<string>();
        
        public static List<DateTimePicker> ExpDatList = new List<DateTimePicker>();
        public static List<DateTime> DatevalueList = new List<DateTime>();

        public SqlParameter OutParameter = new SqlParameter("GetID", SqlDbType.Int);
        public SqlParameter SerialParameter = new SqlParameter("serial", SqlDbType.NVarChar);
        public static List<Drugs> DrugList;
        public static string serial; 

        public int DrugXPosition = 431;
        public int DrugYPosition = 155;
        public int QntyXPosition = 329;
        public int QntyYPosition = 155;
        public int UnitXPosition = 232;
        public int UnitYPosition = 155;
        public int ExpXPosition = 103;
        public int ExpYPosition = 155; 



        hospitalEntities Hospital = new hospitalEntities();
        private void AddBuyingInvoice_Load(object sender, EventArgs e)
        {
            
            List<Suppliers> SupList = Hospital.Suppliers.ToList();
            Com_Suppliers.DataSource = SupList;
            Com_Suppliers.DisplayMember = "SupplierName";
            Com_Suppliers.ValueMember = "SupplierId";
            if (string.IsNullOrEmpty( SearchSupplier.x) )
            { Txt_SupplierName.Text = SearchSupplier.x; }
            else
            {
                Txt_SupplierName.Text = Com_Suppliers.SelectedItem.ToString ();
            }
            

        }

        private void Com_Suppliers_SelectedIndexChanged(object sender, EventArgs e)
        {
            Txt_SupplierName.Visible = true;
            Txt_SupplierName.Text = Com_Suppliers.Text; 
        }

        private void But_Search_Click(object sender, EventArgs e)
        {
            this.Hide ();
            SearchSupplier search = new SearchSupplier();
            search.ShowDialog();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void But_AddItem_Click(object sender, EventArgs e)
        {
            
            ComboBox DrugId = new ComboBox();
            DrugId.Name = "Com_Drug" + C;
            DrugId.Location= new System.Drawing.Point(DrugXPosition, DrugYPosition);
            DrugId.Size = new System.Drawing.Size(121, 21);
            this.Controls.Add(DrugId);
            DrugYPosition += 25;
            DrugUnitList.Add(DrugId);

            TextBox Qnty = new TextBox();
            Qnty.Name = "Txt_Qnty" + C;
            Qnty.Location = new System.Drawing.Point(QntyXPosition, QntyYPosition);
            Qnty.Size = new System.Drawing.Size(68, 20);
            this.Controls.Add(Qnty);
            QntyYPosition += 25;
            QntyTextboxList.Add(Qnty);


            TextBox UnitPrice = new TextBox();
            UnitPrice.Name = "Txt_UnitPrice" + C;
            UnitPrice.Location = new System.Drawing.Point(UnitXPosition, UnitYPosition);
            UnitPrice.Size= new System.Drawing. Size (62,20);
            this.Controls.Add(UnitPrice);
            UnitYPosition += 25;
            PriceTextboxList.Add(UnitPrice);


            DateTimePicker ExpDate = new DateTimePicker();
            ExpDate.Name = "PicKer_Exp" + C;
            ExpDate.Location = new System.Drawing.Point(ExpXPosition, ExpYPosition);
            ExpDate.Size = new System.Drawing.Size(104, 20);
            this.Controls.Add(ExpDate);
            ExpYPosition += 25;
            ExpDatList.Add(ExpDate);

            C++;


            DrugList = Hospital.Drugs.ToList();
            DrugId.DataSource = DrugList;
            DrugId.DisplayMember = "DrugName";
            DrugId.ValueMember = "DrugId";


            But_Save.Visible = true;
            

        }

        private void Com_Suppliers_DragLeave(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Com_Suppliers.Enabled = false;
            But_Search.Visible = false; 
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            But_AddItem.Visible = true;
        }

        private void But_Save_Click(object sender, EventArgs e)
        {
             for (int i = 0; i < DrugUnitList.Count;)
                    {
                        for (int C = 15; C <= this.Controls.Count; C += 4)
                        {
                            if (!string.IsNullOrEmpty(Controls[C].Text) && !string.IsNullOrEmpty(Controls[C + 1].Text))
                            {
                                int validQuantity;
                                decimal validprice;

                                if (int.TryParse(Controls[C].Text, out validQuantity) && decimal.TryParse(Controls[C + 1].Text, out validprice))
                                {
                                    var x = (DrugUnitList[i].SelectedValue);
                                    DrugUnitValue.Add((x).ToString());
                                    QntyValueList.Add(QntyTextboxList[i].Text);
                                    PriceValueList.Add(PriceTextboxList[i].Text);
                                    DatevalueList.Add(Convert.ToDateTime(ExpDatList[i].Text));
                                    But_AddInvoice.Visible = true;
                                    i++;
                                }

                                else
                                {
                                 MessageBox.Show("يرجى إدخال الرقم بشكل صحيح");
                                i = 500;
                                C= 500;
                                }
                           
                        }
                            else
                            {
                                MessageBox.Show("يرجى استكمال بيانات الفاتورة");
                            i = 100;
                            C = 500;
                        }

                        }
                    }
        }

        private void But_AddInvoice_Click(object sender, EventArgs e)
        {
            int found = 0;
           
            for (int i = 0; i < DrugUnitValue.Count; i++ )
            {
                for (int m = 0; m < DrugUnitValue.Count; m++)
                {
                    if (DrugUnitValue[i] == DrugUnitValue[m])
                    {
                        found++;
                    }
                }
                    
                
             }                 

            if (found<=DrugUnitValue.Count)
            //try
            {
                serial  = ConnectionClass.SerialNumber();
                OutParameter.Direction = ParameterDirection.ReturnValue;
                ConnectionClass.Parameters(new SqlParameter("@supplierId", Com_Suppliers.SelectedValue), new SqlParameter ("@invoiceDate", Convert.ToDateTime( dateTimePicker1.Text)), new SqlParameter ("@InvAutoNumber", serial), OutParameter);
                ConnectionClass.SQLCommand("Cproc_AddBuyInvoice", CommandType.StoredProcedure, ExecuteReaderOrNonQuery.executeNonQuery);
                int x = (int) OutParameter.Value;
                for (int i = 0; i < PriceValueList.Count; i++)
                    {
                int x1 =  int.Parse (DrugUnitValue[i]);
                decimal price = Convert.ToDecimal(PriceValueList[i]);
                int quantity = int.Parse(QntyValueList[i]);
                DateTime D = DatevalueList[i]; 
                ConnectionClass.Parameters(new SqlParameter("@InvoiceId", x), new SqlParameter("@DrugId", x1), new SqlParameter("@pricePerUnit", price), new SqlParameter("@Qnty", quantity), new SqlParameter ("@Expdate", D));
                ConnectionClass.SQLCommand("AddInvoiceDetail", CommandType.StoredProcedure, ExecuteReaderOrNonQuery.executeNonQuery);
                    }

                var result = MessageBox.Show("تم اضافة الفاتورة بنجاح، هل تريد إضافة فاتورة أخرى", "تأكيد الخروج", MessageBoxButtons.YesNo);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    this.Close();
                    AddBuyingInvoice newInvoice = new AddBuyingInvoice();
                    newInvoice.ShowDialog();
                }
                else
                { this.Close(); }}
        //}
            //catch { MessageBox.Show ("حدث خطأ برجاء مراجعة الفاتورة"); }
            else
            {
                MessageBox.Show("هناك عنصر مكرر بالفاتورة");
                DrugUnitValue.Clear();
                PriceValueList.Clear();
                QntyValueList.Clear();
                DatevalueList.Clear();
            }

            
        }
    }
}
