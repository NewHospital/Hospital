﻿namespace Hospital
{
    partial class AddDrugUnits
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
            this.Lbl_AddDrugUnits = new System.Windows.Forms.Label();
            this.Txt_AddDrugUnits = new System.Windows.Forms.TextBox();
            this.But_AddDrugUnits = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Lbl_AddDrugUnits
            // 
            this.Lbl_AddDrugUnits.AutoSize = true;
            this.Lbl_AddDrugUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbl_AddDrugUnits.Location = new System.Drawing.Point(212, 62);
            this.Lbl_AddDrugUnits.Name = "Lbl_AddDrugUnits";
            this.Lbl_AddDrugUnits.Size = new System.Drawing.Size(68, 20);
            this.Lbl_AddDrugUnits.TabIndex = 0;
            this.Lbl_AddDrugUnits.Text = "وحدة الدواء";
            // 
            // Txt_AddDrugUnits
            // 
            this.Txt_AddDrugUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Txt_AddDrugUnits.Location = new System.Drawing.Point(12, 59);
            this.Txt_AddDrugUnits.Name = "Txt_AddDrugUnits";
            this.Txt_AddDrugUnits.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Txt_AddDrugUnits.Size = new System.Drawing.Size(190, 26);
            this.Txt_AddDrugUnits.TabIndex = 1;
            this.Txt_AddDrugUnits.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // But_AddDrugUnits
            // 
            this.But_AddDrugUnits.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.But_AddDrugUnits.Location = new System.Drawing.Point(94, 117);
            this.But_AddDrugUnits.Name = "But_AddDrugUnits";
            this.But_AddDrugUnits.Size = new System.Drawing.Size(75, 27);
            this.But_AddDrugUnits.TabIndex = 2;
            this.But_AddDrugUnits.Text = "اضافة";
            this.But_AddDrugUnits.UseVisualStyleBackColor = true;
            this.But_AddDrugUnits.Click += new System.EventHandler(this.But_AddDrugUnits_Click);
            // 
            // AddDrugUnits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 177);
            this.Controls.Add(this.But_AddDrugUnits);
            this.Controls.Add(this.Txt_AddDrugUnits);
            this.Controls.Add(this.Lbl_AddDrugUnits);
            this.Name = "AddDrugUnits";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إضافة وحدات الدواء";
            this.Load += new System.EventHandler(this.AddDrugUnits_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Lbl_AddDrugUnits;
        private System.Windows.Forms.TextBox Txt_AddDrugUnits;
        private System.Windows.Forms.Button But_AddDrugUnits;
    }
}