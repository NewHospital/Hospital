namespace Hospital
{
    partial class DocDegree
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
            this.But_AddDocDegree = new System.Windows.Forms.Button();
            this.Txt_AddDocDegree = new System.Windows.Forms.TextBox();
            this.lbl_AddDocDegree = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // But_AddDocDegree
            // 
            this.But_AddDocDegree.Font = new System.Drawing.Font("Tahoma", 12F);
            this.But_AddDocDegree.Location = new System.Drawing.Point(328, 247);
            this.But_AddDocDegree.Name = "But_AddDocDegree";
            this.But_AddDocDegree.Size = new System.Drawing.Size(213, 50);
            this.But_AddDocDegree.TabIndex = 5;
            this.But_AddDocDegree.Text = "اضافة الدرجه العلميه";
            this.But_AddDocDegree.UseVisualStyleBackColor = true;
            // 
            // Txt_AddDocDegree
            // 
            this.Txt_AddDocDegree.Location = new System.Drawing.Point(160, 167);
            this.Txt_AddDocDegree.Name = "Txt_AddDocDegree";
            this.Txt_AddDocDegree.Size = new System.Drawing.Size(254, 24);
            this.Txt_AddDocDegree.TabIndex = 4;
            // 
            // lbl_AddDocDegree
            // 
            this.lbl_AddDocDegree.Font = new System.Drawing.Font("Tahoma", 10F);
            this.lbl_AddDocDegree.Location = new System.Drawing.Point(502, 154);
            this.lbl_AddDocDegree.Name = "lbl_AddDocDegree";
            this.lbl_AddDocDegree.Size = new System.Drawing.Size(138, 45);
            this.lbl_AddDocDegree.TabIndex = 3;
            this.lbl_AddDocDegree.Text = "الدرجه العلميه";
            this.lbl_AddDocDegree.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // DocDegree
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.But_AddDocDegree);
            this.Controls.Add(this.Txt_AddDocDegree);
            this.Controls.Add(this.lbl_AddDocDegree);
            this.Name = "DocDegree";
            this.Text = "DocDegree";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button But_AddDocDegree;
        private System.Windows.Forms.TextBox Txt_AddDocDegree;
        private System.Windows.Forms.Label lbl_AddDocDegree;
    }
}