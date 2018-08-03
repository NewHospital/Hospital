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
            this.SuspendLayout();
            // 
            // Lbl_AddSuppliers
            // 
            this.Lbl_AddSuppliers.AutoSize = true;
            this.Lbl_AddSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_AddSuppliers.Location = new System.Drawing.Point(272, 69);
            this.Lbl_AddSuppliers.Name = "Lbl_AddSuppliers";
            this.Lbl_AddSuppliers.Size = new System.Drawing.Size(63, 20);
            this.Lbl_AddSuppliers.TabIndex = 1;
            this.Lbl_AddSuppliers.Text = "اسم المورد";
            // 
            // Txt_AddSuppliers
            // 
            this.Txt_AddSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_AddSuppliers.Location = new System.Drawing.Point(12, 66);
            this.Txt_AddSuppliers.Name = "Txt_AddSuppliers";
            this.Txt_AddSuppliers.Size = new System.Drawing.Size(190, 26);
            this.Txt_AddSuppliers.TabIndex = 2;
            // 
            // But_AddSuppliers
            // 
            this.But_AddSuppliers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.But_AddSuppliers.Location = new System.Drawing.Point(166, 149);
            this.But_AddSuppliers.Name = "But_AddSuppliers";
            this.But_AddSuppliers.Size = new System.Drawing.Size(75, 27);
            this.But_AddSuppliers.TabIndex = 3;
            this.But_AddSuppliers.Text = "اضافة";
            this.But_AddSuppliers.UseVisualStyleBackColor = true;
            // 
            // AddSuppliers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 214);
            this.Controls.Add(this.But_AddSuppliers);
            this.Controls.Add(this.Txt_AddSuppliers);
            this.Controls.Add(this.Lbl_AddSuppliers);
            this.Name = "AddSuppliers";
            this.Text = "AddSuppliers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_AddSuppliers;
        private System.Windows.Forms.TextBox Txt_AddSuppliers;
        private System.Windows.Forms.Button But_AddSuppliers;
    }
}