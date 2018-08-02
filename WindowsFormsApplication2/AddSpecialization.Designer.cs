namespace WindowsFormsApplication2
{
    partial class AddSpecialization
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
            this.lbl_AddSpecialization = new System.Windows.Forms.Label();
            this.Txt_AddSpecialization = new System.Windows.Forms.TextBox();
            this.But_AddSpecialization = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_AddSpecialization
            // 
            this.lbl_AddSpecialization.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lbl_AddSpecialization.Location = new System.Drawing.Point(481, 172);
            this.lbl_AddSpecialization.Name = "lbl_AddSpecialization";
            this.lbl_AddSpecialization.Size = new System.Drawing.Size(138, 45);
            this.lbl_AddSpecialization.TabIndex = 0;
            this.lbl_AddSpecialization.Text = "اسم التخصص";
            this.lbl_AddSpecialization.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Txt_AddSpecialization
            // 
            this.Txt_AddSpecialization.Location = new System.Drawing.Point(139, 185);
            this.Txt_AddSpecialization.Name = "Txt_AddSpecialization";
            this.Txt_AddSpecialization.Size = new System.Drawing.Size(254, 24);
            this.Txt_AddSpecialization.TabIndex = 1;
            // 
            // But_AddSpecialization
            // 
            this.But_AddSpecialization.Font = new System.Drawing.Font("Tahoma", 12F);
            this.But_AddSpecialization.Location = new System.Drawing.Point(323, 265);
            this.But_AddSpecialization.Name = "But_AddSpecialization";
            this.But_AddSpecialization.Size = new System.Drawing.Size(176, 50);
            this.But_AddSpecialization.TabIndex = 2;
            this.But_AddSpecialization.Text = "اضافة تخصص";
            this.But_AddSpecialization.UseVisualStyleBackColor = true;
            // 
            // AddSpecialization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.But_AddSpecialization);
            this.Controls.Add(this.Txt_AddSpecialization);
            this.Controls.Add(this.lbl_AddSpecialization);
            this.Name = "AddSpecialization";
            this.Text = "AddSpecialization";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_AddSpecialization;
        private System.Windows.Forms.TextBox Txt_AddSpecialization;
        private System.Windows.Forms.Button But_AddSpecialization;
    }
}