namespace Hospital
{
    partial class AddRooms
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
            this.Txt_RoomNo = new System.Windows.Forms.TextBox();
            this.Txt_FloorNo = new System.Windows.Forms.TextBox();
            this.Com_AddRoom = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Txt_RoomNo
            // 
            this.Txt_RoomNo.Location = new System.Drawing.Point(123, 24);
            this.Txt_RoomNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_RoomNo.Name = "Txt_RoomNo";
            this.Txt_RoomNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_RoomNo.Size = new System.Drawing.Size(61, 20);
            this.Txt_RoomNo.TabIndex = 0;
            // 
            // Txt_FloorNo
            // 
            this.Txt_FloorNo.Location = new System.Drawing.Point(99, 72);
            this.Txt_FloorNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Txt_FloorNo.Name = "Txt_FloorNo";
            this.Txt_FloorNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Txt_FloorNo.Size = new System.Drawing.Size(86, 20);
            this.Txt_FloorNo.TabIndex = 1;
            // 
            // Com_AddRoom
            // 
            this.Com_AddRoom.FormattingEnabled = true;
            this.Com_AddRoom.Location = new System.Drawing.Point(63, 124);
            this.Com_AddRoom.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Com_AddRoom.Name = "Com_AddRoom";
            this.Com_AddRoom.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Com_AddRoom.Size = new System.Drawing.Size(121, 21);
            this.Com_AddRoom.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(99, 170);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 35);
            this.button1.TabIndex = 3;
            this.button1.Text = "إضافة غرفة";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(221, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "رقم الغرفة";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(240, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "الطابق";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(211, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "درجة الغرفة ";
            // 
            // AddRooms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 240);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Com_AddRoom);
            this.Controls.Add(this.Txt_FloorNo);
            this.Controls.Add(this.Txt_RoomNo);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "AddRooms";
            this.Text = "إضافة غرف";
            this.Load += new System.EventHandler(this.AddRooms_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txt_RoomNo;
        private System.Windows.Forms.TextBox Txt_FloorNo;
        private System.Windows.Forms.ComboBox Com_AddRoom;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}