﻿namespace WindowsFormsApplication2
{
    partial class AddDrug
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
            this.button1 = new System.Windows.Forms.Button();
            this.txt_Drugname = new System.Windows.Forms.TextBox();
            this.Txt_pricePerUnit = new System.Windows.Forms.TextBox();
            this.Com_DrugUnit = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(181, 252);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 41);
            this.button1.TabIndex = 0;
            this.button1.Text = "إضافة";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // txt_Drugname
            // 
            this.txt_Drugname.Location = new System.Drawing.Point(101, 74);
            this.txt_Drugname.Name = "txt_Drugname";
            this.txt_Drugname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txt_Drugname.Size = new System.Drawing.Size(255, 24);
            this.txt_Drugname.TabIndex = 1;
            // 
            // Txt_pricePerUnit
            // 
            this.Txt_pricePerUnit.Location = new System.Drawing.Point(181, 182);
            this.Txt_pricePerUnit.Name = "Txt_pricePerUnit";
            this.Txt_pricePerUnit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_pricePerUnit.Size = new System.Drawing.Size(175, 24);
            this.Txt_pricePerUnit.TabIndex = 2;
            // 
            // Com_DrugUnit
            // 
            this.Com_DrugUnit.FormattingEnabled = true;
            this.Com_DrugUnit.Location = new System.Drawing.Point(193, 124);
            this.Com_DrugUnit.Name = "Com_DrugUnit";
            this.Com_DrugUnit.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Com_DrugUnit.Size = new System.Drawing.Size(163, 24);
            this.Com_DrugUnit.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(417, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "اسم الدواء";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(417, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "وحدة الدواء";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(417, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "سعر الوحدة";
            // 
            // AddDrug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 332);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Com_DrugUnit);
            this.Controls.Add(this.Txt_pricePerUnit);
            this.Controls.Add(this.txt_Drugname);
            this.Controls.Add(this.button1);
            this.Name = "AddDrug";
            this.Text = "أضافة دواء";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_Drugname;
        private System.Windows.Forms.TextBox Txt_pricePerUnit;
        private System.Windows.Forms.ComboBox Com_DrugUnit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}