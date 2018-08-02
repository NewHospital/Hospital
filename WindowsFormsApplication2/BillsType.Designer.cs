namespace WindowsFormsApplication2
{
    partial class BillsType
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
            this.Txt_AddBillsType = new System.Windows.Forms.TextBox();
            this.But_AddBillsType = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Txt_AddBillsType
            // 
            this.Txt_AddBillsType.Location = new System.Drawing.Point(77, 74);
            this.Txt_AddBillsType.Name = "Txt_AddBillsType";
            this.Txt_AddBillsType.Size = new System.Drawing.Size(124, 20);
            this.Txt_AddBillsType.TabIndex = 0;
            // 
            // But_AddBillsType
            // 
            this.But_AddBillsType.Location = new System.Drawing.Point(83, 145);
            this.But_AddBillsType.Name = "But_AddBillsType";
            this.But_AddBillsType.Size = new System.Drawing.Size(115, 47);
            this.But_AddBillsType.TabIndex = 1;
            this.But_AddBillsType.Text = "إضافة نوع الفاتوره";
            this.But_AddBillsType.UseVisualStyleBackColor = true;
            // 
            // BillsType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.But_AddBillsType);
            this.Controls.Add(this.Txt_AddBillsType);
            this.Name = "BillsType";
            this.Text = "نوع الفاتورة";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_AddBillsType;
        private System.Windows.Forms.Button But_AddBillsType;
    }
}