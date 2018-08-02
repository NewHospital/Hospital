namespace WindowsFormsApplication2
{
    partial class Add_Diseases
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
            this.But_AddDiseases = new System.Windows.Forms.Button();
            this.Txt_AddDiseases = new System.Windows.Forms.TextBox();
            this.Lbl_AddDiseases = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // But_AddDiseases
            // 
            this.But_AddDiseases.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.But_AddDiseases.Location = new System.Drawing.Point(55, 124);
            this.But_AddDiseases.Name = "But_AddDiseases";
            this.But_AddDiseases.Size = new System.Drawing.Size(141, 23);
            this.But_AddDiseases.TabIndex = 0;
            this.But_AddDiseases.Text = "إضافة";
            this.But_AddDiseases.UseVisualStyleBackColor = true;
            // 
            // Txt_AddDiseases
            // 
            this.Txt_AddDiseases.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_AddDiseases.Location = new System.Drawing.Point(12, 57);
            this.Txt_AddDiseases.Name = "Txt_AddDiseases";
            this.Txt_AddDiseases.Size = new System.Drawing.Size(162, 23);
            this.Txt_AddDiseases.TabIndex = 1;
            // 
            // Lbl_AddDiseases
            // 
            this.Lbl_AddDiseases.AutoSize = true;
            this.Lbl_AddDiseases.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_AddDiseases.Location = new System.Drawing.Point(180, 57);
            this.Lbl_AddDiseases.Name = "Lbl_AddDiseases";
            this.Lbl_AddDiseases.Size = new System.Drawing.Size(94, 19);
            this.Lbl_AddDiseases.TabIndex = 2;
            this.Lbl_AddDiseases.Text = "اسم المرض ";
            // 
            // Add_Diseases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(273, 219);
            this.Controls.Add(this.Lbl_AddDiseases);
            this.Controls.Add(this.Txt_AddDiseases);
            this.Controls.Add(this.But_AddDiseases);
            this.Name = "Add_Diseases";
            this.Text = "إضافة أمراض";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button But_AddDiseases;
        private System.Windows.Forms.TextBox Txt_AddDiseases;
        private System.Windows.Forms.Label Lbl_AddDiseases;
    }
}