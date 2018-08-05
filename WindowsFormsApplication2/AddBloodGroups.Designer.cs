namespace WindowsFormsApplication2
{
    partial class AddBloodGroups
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
            this.Txt_AddBloodGroup = new System.Windows.Forms.TextBox();
            this.Lbl_AddBloodGroup = new System.Windows.Forms.Label();
            this.But_AddBloodGroup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Txt_AddBloodGroup
            // 
            this.Txt_AddBloodGroup.Location = new System.Drawing.Point(12, 36);
            this.Txt_AddBloodGroup.Name = "Txt_AddBloodGroup";
            this.Txt_AddBloodGroup.Size = new System.Drawing.Size(151, 20);
            this.Txt_AddBloodGroup.TabIndex = 1;
            this.Txt_AddBloodGroup.TextChanged += new System.EventHandler(this.Txt_AddBloodGroup_TextChanged);
            // 
            // Lbl_AddBloodGroup
            // 
            this.Lbl_AddBloodGroup.AutoSize = true;
            this.Lbl_AddBloodGroup.Location = new System.Drawing.Point(187, 40);
            this.Lbl_AddBloodGroup.Name = "Lbl_AddBloodGroup";
            this.Lbl_AddBloodGroup.Size = new System.Drawing.Size(57, 13);
            this.Lbl_AddBloodGroup.TabIndex = 2;
            this.Lbl_AddBloodGroup.Text = "فصيلة الدم";
            // 
            // But_AddBloodGroup
            // 
            this.But_AddBloodGroup.Location = new System.Drawing.Point(66, 78);
            this.But_AddBloodGroup.Name = "But_AddBloodGroup";
            this.But_AddBloodGroup.Size = new System.Drawing.Size(104, 23);
            this.But_AddBloodGroup.TabIndex = 3;
            this.But_AddBloodGroup.Text = "إضافة فصيلة";
            this.But_AddBloodGroup.UseVisualStyleBackColor = true;
            this.But_AddBloodGroup.Click += new System.EventHandler(this.But_AddBloodGroup_Click);
            // 
            // AddBloodGroups
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 127);
            this.Controls.Add(this.But_AddBloodGroup);
            this.Controls.Add(this.Lbl_AddBloodGroup);
            this.Controls.Add(this.Txt_AddBloodGroup);
            this.Name = "AddBloodGroups";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddBloodGroups";
            this.Load += new System.EventHandler(this.AddBloodGroups_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox Txt_AddBloodGroup;
        private System.Windows.Forms.Label Lbl_AddBloodGroup;
        private System.Windows.Forms.Button But_AddBloodGroup;
    }
}