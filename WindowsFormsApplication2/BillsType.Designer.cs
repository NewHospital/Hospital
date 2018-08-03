namespace Hospital
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
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txt_AddBillsType
            // 
            this.Txt_AddBillsType.Location = new System.Drawing.Point(24, 60);
            this.Txt_AddBillsType.Name = "Txt_AddBillsType";
            this.Txt_AddBillsType.Size = new System.Drawing.Size(124, 20);
            this.Txt_AddBillsType.TabIndex = 0;
            // 
            // But_AddBillsType
            // 
            this.But_AddBillsType.Location = new System.Drawing.Point(72, 114);
            this.But_AddBillsType.Name = "But_AddBillsType";
            this.But_AddBillsType.Size = new System.Drawing.Size(115, 31);
            this.But_AddBillsType.TabIndex = 1;
            this.But_AddBillsType.Text = "إضافة نوع الفاتوره";
            this.But_AddBillsType.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(174, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "نوع الفاتورة";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BillsType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 182);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.But_AddBillsType);
            this.Controls.Add(this.Txt_AddBillsType);
            this.Name = "BillsType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "نوع الفاتورة";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_AddBillsType;
        private System.Windows.Forms.Button But_AddBillsType;
        private System.Windows.Forms.Label label1;
    }
}