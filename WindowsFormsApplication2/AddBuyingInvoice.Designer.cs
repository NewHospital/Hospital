namespace WindowsFormsApplication2
{
    partial class AddBuyingInvoice
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Com_Suppliers = new System.Windows.Forms.ComboBox();
            this.Txt_SupplierName = new System.Windows.Forms.TextBox();
            this.Lbl_SupplierName = new System.Windows.Forms.Label();
            this.But_Search = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.But_AddItem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.But_Save = new System.Windows.Forms.Button();
            this.But_AddInvoice = new System.Windows.Forms.Button();
            this.Lbl_Sum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Com_Suppliers
            // 
            this.Com_Suppliers.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Com_Suppliers.FormattingEnabled = true;
            this.Com_Suppliers.Location = new System.Drawing.Point(281, 12);
            this.Com_Suppliers.Name = "Com_Suppliers";
            this.Com_Suppliers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Com_Suppliers.Size = new System.Drawing.Size(276, 27);
            this.Com_Suppliers.TabIndex = 0;
            this.Com_Suppliers.SelectedIndexChanged += new System.EventHandler(this.Com_Suppliers_SelectedIndexChanged);
            this.Com_Suppliers.DragLeave += new System.EventHandler(this.Com_Suppliers_DragLeave);
            // 
            // Txt_SupplierName
            // 
            this.Txt_SupplierName.Enabled = false;
            this.Txt_SupplierName.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_SupplierName.Location = new System.Drawing.Point(345, 63);
            this.Txt_SupplierName.Name = "Txt_SupplierName";
            this.Txt_SupplierName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_SupplierName.Size = new System.Drawing.Size(207, 23);
            this.Txt_SupplierName.TabIndex = 1;
            // 
            // Lbl_SupplierName
            // 
            this.Lbl_SupplierName.AutoSize = true;
            this.Lbl_SupplierName.Location = new System.Drawing.Point(563, 68);
            this.Lbl_SupplierName.Name = "Lbl_SupplierName";
            this.Lbl_SupplierName.Size = new System.Drawing.Size(59, 13);
            this.Lbl_SupplierName.TabIndex = 2;
            this.Lbl_SupplierName.Text = "اسم المورد";
            // 
            // But_Search
            // 
            this.But_Search.Location = new System.Drawing.Point(12, 12);
            this.But_Search.Name = "But_Search";
            this.But_Search.Size = new System.Drawing.Size(118, 27);
            this.But_Search.TabIndex = 3;
            this.But_Search.Text = "بحث عن المورد";
            this.But_Search.UseVisualStyleBackColor = true;
            this.But_Search.Click += new System.EventHandler(this.But_Search_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(51, 64);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(268, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "تاريخ الفاتورة";
            // 
            // But_AddItem
            // 
            this.But_AddItem.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.But_AddItem.Location = new System.Drawing.Point(571, 155);
            this.But_AddItem.Name = "But_AddItem";
            this.But_AddItem.Size = new System.Drawing.Size(51, 37);
            this.But_AddItem.TabIndex = 15;
            this.But_AddItem.Text = "+";
            this.But_AddItem.UseVisualStyleBackColor = true;
            this.But_AddItem.Visible = false;
            this.But_AddItem.Click += new System.EventHandler(this.But_AddItem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(107, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 13);
            this.label5.TabIndex = 23;
            this.label5.Text = "تاريخ انتهاء الصلاحية";
            this.label5.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "سعر الوحدة";
            this.label4.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(345, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "الكمية";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(463, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "صنف الدواء";
            this.label2.Visible = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 27);
            this.button1.TabIndex = 24;
            this.button1.Text = "إضافة فاتورة مبيعات";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // But_Save
            // 
            this.But_Save.Location = new System.Drawing.Point(571, 209);
            this.But_Save.Name = "But_Save";
            this.But_Save.Size = new System.Drawing.Size(51, 105);
            this.But_Save.TabIndex = 25;
            this.But_Save.Text = "حفظ";
            this.But_Save.UseVisualStyleBackColor = true;
            this.But_Save.Visible = false;
            this.But_Save.Click += new System.EventHandler(this.But_Save_Click);
            // 
            // But_AddInvoice
            // 
            this.But_AddInvoice.Location = new System.Drawing.Point(571, 331);
            this.But_AddInvoice.Name = "But_AddInvoice";
            this.But_AddInvoice.Size = new System.Drawing.Size(51, 96);
            this.But_AddInvoice.TabIndex = 26;
            this.But_AddInvoice.Text = "إرسال";
            this.But_AddInvoice.UseVisualStyleBackColor = true;
            this.But_AddInvoice.Visible = false;
            this.But_AddInvoice.Click += new System.EventHandler(this.But_AddInvoice_Click);
            // 
            // Lbl_Sum
            // 
            this.Lbl_Sum.AutoSize = true;
            this.Lbl_Sum.Location = new System.Drawing.Point(48, 195);
            this.Lbl_Sum.Name = "Lbl_Sum";
            this.Lbl_Sum.Size = new System.Drawing.Size(0, 13);
            this.Lbl_Sum.TabIndex = 27;
            // 
            // AddBuyingInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(638, 451);
            this.Controls.Add(this.Lbl_Sum);
            this.Controls.Add(this.But_AddInvoice);
            this.Controls.Add(this.But_Save);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.But_AddItem);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.But_Search);
            this.Controls.Add(this.Lbl_SupplierName);
            this.Controls.Add(this.Txt_SupplierName);
            this.Controls.Add(this.Com_Suppliers);
            this.MaximizeBox = false;
            this.Name = "AddBuyingInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddBuyingInvoice";
            this.Load += new System.EventHandler(this.AddBuyingInvoice_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Txt_SupplierName;
        private System.Windows.Forms.Label Lbl_SupplierName;
        private System.Windows.Forms.Button But_Search;
        public System.Windows.Forms.ComboBox Com_Suppliers;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button But_AddItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button But_Save;
        private System.Windows.Forms.Button But_AddInvoice;
        private System.Windows.Forms.Label Lbl_Sum;
    }
}