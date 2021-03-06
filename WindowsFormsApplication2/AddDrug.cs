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
using WindowsFormsApplication2;

namespace Hospital
{
    public partial class AddDrug : Form
    {
        public AddDrug()
        {
            InitializeComponent();
            
        }

        private void AddDrug_Load(object sender, EventArgs e)
        {
                hospitalEntities HosPital = new hospitalEntities();

            List<DrugUnit> DrugUnitList = HosPital.DrugUnits.ToList();
            DataTable Table = new DataTable();
            Table.Columns.Add("DrugUnitId");
            Table.Columns.Add("DrugUnitName");
            foreach (var item in DrugUnitList.Where(a => a.DrugUnitName != null || a.DrugUnitName != ""))

            {
                Table.Rows.Add(item.DrugUnitId, item.DrugUnitName);
            }
            Com_DrugUnit.DataSource = Table;
            Com_DrugUnit.ValueMember = Table.Columns[0].ColumnName;
            Com_DrugUnit.DisplayMember = Table.Columns[1].ColumnName;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal value = 0;
            decimal.TryParse(Txt_pricePerUnit.Text, out value);
            ConnectionClass.Parameters(new SqlParameter("@DrugName", txt_Drugname.Text), new SqlParameter("@DrugUnit", Com_DrugUnit.SelectedValue), new SqlParameter("@PricePerUnit", value));
            ConnectionClass.SQLCommand("Cproc_AddDrug", CommandType.StoredProcedure, ExecuteReaderOrNonQuery.executeNonQuery);
            MessageBox.Show("تم إضافة الدواء بنجاح");
            txt_Drugname.Clear();
            Txt_pricePerUnit.Clear();
          

        }
    }
}
