namespace Hospital
{
    partial class AddFellow
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
            this.Txt_FellowName = new System.Windows.Forms.TextBox();
            this.Txt_FellowSoSeNo = new System.Windows.Forms.TextBox();
            this.Txt_FellowPhone = new System.Windows.Forms.TextBox();
            this.But_AddFellow = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txt_FellowName
            // 
            this.Txt_FellowName.Location = new System.Drawing.Point(41, 53);
            this.Txt_FellowName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_FellowName.Name = "Txt_FellowName";
            this.Txt_FellowName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_FellowName.Size = new System.Drawing.Size(244, 20);
            this.Txt_FellowName.TabIndex = 0;
            // 
            // Txt_FellowSoSeNo
            // 
            this.Txt_FellowSoSeNo.Location = new System.Drawing.Point(103, 98);
            this.Txt_FellowSoSeNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_FellowSoSeNo.Name = "Txt_FellowSoSeNo";
            this.Txt_FellowSoSeNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_FellowSoSeNo.Size = new System.Drawing.Size(182, 20);
            this.Txt_FellowSoSeNo.TabIndex = 2;
            // 
            // Txt_FellowPhone
            // 
            this.Txt_FellowPhone.Location = new System.Drawing.Point(180, 154);
            this.Txt_FellowPhone.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_FellowPhone.Name = "Txt_FellowPhone";
            this.Txt_FellowPhone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_FellowPhone.Size = new System.Drawing.Size(105, 20);
            this.Txt_FellowPhone.TabIndex = 3;
            // 
            // But_AddFellow
            // 
            this.But_AddFellow.Location = new System.Drawing.Point(128, 212);
            this.But_AddFellow.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.But_AddFellow.Name = "But_AddFellow";
            this.But_AddFellow.Size = new System.Drawing.Size(116, 28);
            this.But_AddFellow.TabIndex = 4;
            this.But_AddFellow.Text = "إضافة مرافق ";
            this.But_AddFellow.UseVisualStyleBackColor = true;
            this.But_AddFellow.Click += new System.EventHandler(this.But_AddFellow_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(318, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "اسم المرافق";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(318, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "الرقم القومي";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(329, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "رقم الهاتف";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Traditional Arabic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(145, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "إضافة مرافق";
            // 
            // AddFellow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(413, 285);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.But_AddFellow);
            this.Controls.Add(this.Txt_FellowPhone);
            this.Controls.Add(this.Txt_FellowSoSeNo);
            this.Controls.Add(this.Txt_FellowName);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddFellow";
            this.Text = "إضافة مرافق";
            this.Load += new System.EventHandler(this.AddFellow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_FellowName;
        private System.Windows.Forms.TextBox Txt_FellowSoSeNo;
        private System.Windows.Forms.TextBox Txt_FellowPhone;
        private System.Windows.Forms.Button But_AddFellow;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}