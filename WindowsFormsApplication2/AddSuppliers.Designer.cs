namespace Hospital
{
    partial class AddSuppliers
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
            this.Lbl_AddSuppliers = new System.Windows.Forms.Label();
            this.Txt_AddSuppliers = new System.Windows.Forms.TextBox();
            this.But_AddSuppliers = new System.Windows.Forms.Button();
            this.Txt_Contactname = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.LblAddContactNamen = new System.Windows.Forms.Label();
            this.LblAddJobtitle = new System.Windows.Forms.Label();
            this.LblAddContactTel = new System.Windows.Forms.Label();
            this.Lbl_AddBranch = new System.Windows.Forms.Label();
            this.But_AddContact = new System.Windows.Forms.Button();
            this.Com_branch = new System.Windows.Forms.ComboBox();
            this.Txt_Tel = new System.Windows.Forms.TextBox();
            this.Txt_JobTitle = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.But_addBranch = new System.Windows.Forms.Button();
            this.Txt_AddAddress = new System.Windows.Forms.TextBox();
            this.Lbl_Address = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Lbl_AddSuppliers
            // 
            this.Lbl_AddSuppliers.AutoSize = true;
            this.Lbl_AddSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_AddSuppliers.Location = new System.Drawing.Point(579, 30);
            this.Lbl_AddSuppliers.Name = "Lbl_AddSuppliers";
            this.Lbl_AddSuppliers.Size = new System.Drawing.Size(63, 20);
            this.Lbl_AddSuppliers.TabIndex = 1;
            this.Lbl_AddSuppliers.Text = "اسم المورد";
            // 
            // Txt_AddSuppliers
            // 
            this.Txt_AddSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_AddSuppliers.Location = new System.Drawing.Point(117, 29);
            this.Txt_AddSuppliers.Name = "Txt_AddSuppliers";
            this.Txt_AddSuppliers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_AddSuppliers.Size = new System.Drawing.Size(443, 26);
            this.Txt_AddSuppliers.TabIndex = 2;
            // 
            // But_AddSuppliers
            // 
            this.But_AddSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.But_AddSuppliers.Location = new System.Drawing.Point(291, 73);
            this.But_AddSuppliers.Name = "But_AddSuppliers";
            this.But_AddSuppliers.Size = new System.Drawing.Size(75, 27);
            this.But_AddSuppliers.TabIndex = 3;
            this.But_AddSuppliers.Text = "اضافة";
            this.But_AddSuppliers.UseVisualStyleBackColor = true;
            this.But_AddSuppliers.Click += new System.EventHandler(this.But_AddSuppliers_Click);
            // 
            // Txt_Contactname
            // 
            this.Txt_Contactname.Location = new System.Drawing.Point(472, 42);
            this.Txt_Contactname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Contactname.Name = "Txt_Contactname";
            this.Txt_Contactname.Size = new System.Drawing.Size(144, 20);
            this.Txt_Contactname.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.AutoSize = true;
            this.groupBox1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox1.Controls.Add(this.LblAddContactNamen);
            this.groupBox1.Controls.Add(this.LblAddJobtitle);
            this.groupBox1.Controls.Add(this.LblAddContactTel);
            this.groupBox1.Controls.Add(this.Lbl_AddBranch);
            this.groupBox1.Controls.Add(this.But_AddContact);
            this.groupBox1.Controls.Add(this.Com_branch);
            this.groupBox1.Controls.Add(this.Txt_Tel);
            this.groupBox1.Controls.Add(this.Txt_JobTitle);
            this.groupBox1.Controls.Add(this.Txt_Contactname);
            this.groupBox1.Location = new System.Drawing.Point(30, 246);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(622, 81);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جهات الاتصال";
            this.groupBox1.Visible = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // LblAddContactNamen
            // 
            this.LblAddContactNamen.AutoSize = true;
            this.LblAddContactNamen.Location = new System.Drawing.Point(519, 16);
            this.LblAddContactNamen.Name = "LblAddContactNamen";
            this.LblAddContactNamen.Size = new System.Drawing.Size(36, 13);
            this.LblAddContactNamen.TabIndex = 7;
            this.LblAddContactNamen.Text = "الاسم";
            // 
            // LblAddJobtitle
            // 
            this.LblAddJobtitle.AutoSize = true;
            this.LblAddJobtitle.Location = new System.Drawing.Point(397, 16);
            this.LblAddJobtitle.Name = "LblAddJobtitle";
            this.LblAddJobtitle.Size = new System.Drawing.Size(41, 13);
            this.LblAddJobtitle.TabIndex = 8;
            this.LblAddJobtitle.Text = "الوظيفة";
            // 
            // LblAddContactTel
            // 
            this.LblAddContactTel.AutoSize = true;
            this.LblAddContactTel.Location = new System.Drawing.Point(259, 16);
            this.LblAddContactTel.Name = "LblAddContactTel";
            this.LblAddContactTel.Size = new System.Drawing.Size(43, 13);
            this.LblAddContactTel.TabIndex = 9;
            this.LblAddContactTel.Text = "التليفون";
            // 
            // Lbl_AddBranch
            // 
            this.Lbl_AddBranch.AutoSize = true;
            this.Lbl_AddBranch.Location = new System.Drawing.Point(135, 16);
            this.Lbl_AddBranch.Name = "Lbl_AddBranch";
            this.Lbl_AddBranch.Size = new System.Drawing.Size(31, 13);
            this.Lbl_AddBranch.TabIndex = 10;
            this.Lbl_AddBranch.Text = "الفرع";
            // 
            // But_AddContact
            // 
            this.But_AddContact.Location = new System.Drawing.Point(5, 43);
            this.But_AddContact.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.But_AddContact.Name = "But_AddContact";
            this.But_AddContact.Size = new System.Drawing.Size(85, 21);
            this.But_AddContact.TabIndex = 9;
            this.But_AddContact.Text = "إضافة";
            this.But_AddContact.UseVisualStyleBackColor = true;
            this.But_AddContact.Click += new System.EventHandler(this.But_AddContact_Click);
            // 
            // Com_branch
            // 
            this.Com_branch.FormattingEnabled = true;
            this.Com_branch.Location = new System.Drawing.Point(95, 42);
            this.Com_branch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Com_branch.Name = "Com_branch";
            this.Com_branch.Size = new System.Drawing.Size(108, 21);
            this.Com_branch.TabIndex = 8;
            // 
            // Txt_Tel
            // 
            this.Txt_Tel.Location = new System.Drawing.Point(207, 42);
            this.Txt_Tel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_Tel.Name = "Txt_Tel";
            this.Txt_Tel.Size = new System.Drawing.Size(139, 20);
            this.Txt_Tel.TabIndex = 7;
            // 
            // Txt_JobTitle
            // 
            this.Txt_JobTitle.Location = new System.Drawing.Point(359, 42);
            this.Txt_JobTitle.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_JobTitle.Name = "Txt_JobTitle";
            this.Txt_JobTitle.Size = new System.Drawing.Size(109, 20);
            this.Txt_JobTitle.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.But_addBranch);
            this.groupBox2.Controls.Add(this.Txt_AddAddress);
            this.groupBox2.Location = new System.Drawing.Point(62, 136);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(585, 78);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "الفروع";
            this.groupBox2.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(519, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "عنوان الفرع";
            // 
            // But_addBranch
            // 
            this.But_addBranch.Location = new System.Drawing.Point(52, 40);
            this.But_addBranch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.But_addBranch.Name = "But_addBranch";
            this.But_addBranch.Size = new System.Drawing.Size(125, 21);
            this.But_addBranch.TabIndex = 9;
            this.But_addBranch.Text = "إضافة عنوان الفرع";
            this.But_addBranch.UseVisualStyleBackColor = true;
            this.But_addBranch.Click += new System.EventHandler(this.button1_Click);
            // 
            // Txt_AddAddress
            // 
            this.Txt_AddAddress.Location = new System.Drawing.Point(243, 41);
            this.Txt_AddAddress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_AddAddress.Name = "Txt_AddAddress";
            this.Txt_AddAddress.Size = new System.Drawing.Size(315, 20);
            this.Txt_AddAddress.TabIndex = 4;
            // 
            // Lbl_Address
            // 
            this.Lbl_Address.AutoSize = true;
            this.Lbl_Address.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_Address.Location = new System.Drawing.Point(448, 102);
            this.Lbl_Address.Name = "Lbl_Address";
            this.Lbl_Address.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Lbl_Address.Size = new System.Drawing.Size(208, 19);
            this.Lbl_Address.TabIndex = 8;
            this.Lbl_Address.Text = "يرجى إدخال عناوين الفروع ";
            this.Lbl_Address.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.Lbl_Address.Visible = false;
            this.Lbl_Address.Click += new System.EventHandler(this.Lbl_Address_Click);
            // 
            // AddSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(699, 417);
            this.Controls.Add(this.Lbl_Address);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.But_AddSuppliers);
            this.Controls.Add(this.Txt_AddSuppliers);
            this.Controls.Add(this.Lbl_AddSuppliers);
            this.Name = "AddSuppliers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إضافة مورد";
            this.Load += new System.EventHandler(this.AddSuppliers_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_AddSuppliers;
        private System.Windows.Forms.TextBox Txt_AddSuppliers;
        private System.Windows.Forms.Button But_AddSuppliers;
        private System.Windows.Forms.TextBox Txt_Contactname;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label LblAddContactNamen;
        private System.Windows.Forms.Label LblAddJobtitle;
        private System.Windows.Forms.Label LblAddContactTel;
        private System.Windows.Forms.Label Lbl_AddBranch;
        private System.Windows.Forms.Button But_AddContact;
        private System.Windows.Forms.ComboBox Com_branch;
        private System.Windows.Forms.TextBox Txt_Tel;
        private System.Windows.Forms.TextBox Txt_JobTitle;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button But_addBranch;
        private System.Windows.Forms.TextBox Txt_AddAddress;
        private System.Windows.Forms.Label Lbl_Address;
    }
}