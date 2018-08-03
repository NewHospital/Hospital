namespace Hospital
{
    partial class RoomDegrees
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
            this.Txt_AddNameDegree = new System.Windows.Forms.TextBox();
            this.Lbl_AddNameDegree = new System.Windows.Forms.Label();
            this.Lbl_AddFeesPerDay = new System.Windows.Forms.Label();
            this.Lbl_AddDiscription = new System.Windows.Forms.Label();
            this.But_AddRoomDegree = new System.Windows.Forms.Button();
            this.Txt_AddFeesPerDay = new System.Windows.Forms.TextBox();
            this.Txt_AddDiscription = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Txt_AddNameDegree
            // 
            this.Txt_AddNameDegree.Location = new System.Drawing.Point(120, 40);
            this.Txt_AddNameDegree.Name = "Txt_AddNameDegree";
            this.Txt_AddNameDegree.Size = new System.Drawing.Size(100, 20);
            this.Txt_AddNameDegree.TabIndex = 0;
            // 
            // Lbl_AddNameDegree
            // 
            this.Lbl_AddNameDegree.AutoSize = true;
            this.Lbl_AddNameDegree.Location = new System.Drawing.Point(226, 43);
            this.Lbl_AddNameDegree.Name = "Lbl_AddNameDegree";
            this.Lbl_AddNameDegree.Size = new System.Drawing.Size(60, 13);
            this.Lbl_AddNameDegree.TabIndex = 1;
            this.Lbl_AddNameDegree.Text = "درجة الغرفة";
            // 
            // Lbl_AddFeesPerDay
            // 
            this.Lbl_AddFeesPerDay.AutoSize = true;
            this.Lbl_AddFeesPerDay.Location = new System.Drawing.Point(226, 78);
            this.Lbl_AddFeesPerDay.Name = "Lbl_AddFeesPerDay";
            this.Lbl_AddFeesPerDay.Size = new System.Drawing.Size(62, 13);
            this.Lbl_AddFeesPerDay.TabIndex = 2;
            this.Lbl_AddFeesPerDay.Text = "السعر لليوم";
            this.Lbl_AddFeesPerDay.Click += new System.EventHandler(this.label2_Click);
            // 
            // Lbl_AddDiscription
            // 
            this.Lbl_AddDiscription.AutoSize = true;
            this.Lbl_AddDiscription.Location = new System.Drawing.Point(226, 110);
            this.Lbl_AddDiscription.Name = "Lbl_AddDiscription";
            this.Lbl_AddDiscription.Size = new System.Drawing.Size(37, 13);
            this.Lbl_AddDiscription.TabIndex = 3;
            this.Lbl_AddDiscription.Text = "الوصف";
            // 
            // But_AddRoomDegree
            // 
            this.But_AddRoomDegree.Location = new System.Drawing.Point(87, 207);
            this.But_AddRoomDegree.Name = "But_AddRoomDegree";
            this.But_AddRoomDegree.Size = new System.Drawing.Size(100, 39);
            this.But_AddRoomDegree.TabIndex = 4;
            this.But_AddRoomDegree.Text = "إضافه";
            this.But_AddRoomDegree.UseVisualStyleBackColor = true;
            // 
            // Txt_AddFeesPerDay
            // 
            this.Txt_AddFeesPerDay.Location = new System.Drawing.Point(120, 75);
            this.Txt_AddFeesPerDay.Name = "Txt_AddFeesPerDay";
            this.Txt_AddFeesPerDay.Size = new System.Drawing.Size(100, 20);
            this.Txt_AddFeesPerDay.TabIndex = 5;
            // 
            // Txt_AddDiscription
            // 
            this.Txt_AddDiscription.Location = new System.Drawing.Point(29, 110);
            this.Txt_AddDiscription.Multiline = true;
            this.Txt_AddDiscription.Name = "Txt_AddDiscription";
            this.Txt_AddDiscription.Size = new System.Drawing.Size(191, 71);
            this.Txt_AddDiscription.TabIndex = 6;
            // 
            // RoomDegrees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 276);
            this.Controls.Add(this.Txt_AddDiscription);
            this.Controls.Add(this.Txt_AddFeesPerDay);
            this.Controls.Add(this.But_AddRoomDegree);
            this.Controls.Add(this.Lbl_AddDiscription);
            this.Controls.Add(this.Lbl_AddFeesPerDay);
            this.Controls.Add(this.Lbl_AddNameDegree);
            this.Controls.Add(this.Txt_AddNameDegree);
            this.Name = "RoomDegrees";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "إضافة درجات الغرف";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_AddNameDegree;
        private System.Windows.Forms.Label Lbl_AddNameDegree;
        private System.Windows.Forms.Label Lbl_AddFeesPerDay;
        private System.Windows.Forms.Label Lbl_AddDiscription;
        private System.Windows.Forms.Button But_AddRoomDegree;
        private System.Windows.Forms.TextBox Txt_AddFeesPerDay;
        private System.Windows.Forms.TextBox Txt_AddDiscription;
    }
}