namespace SA39_TEAM5
{
    partial class Booking_UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Booking_UI));
            this.book_cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_bookingid = new System.Windows.Forms.TextBox();
            this.tb_membername = new System.Windows.Forms.TextBox();
            this.cb_memberid = new System.Windows.Forms.ComboBox();
            this.tb_facilityname = new System.Windows.Forms.TextBox();
            this.tb_facilityid = new System.Windows.Forms.TextBox();
            this.tb_timeslot = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // book_cancel
            // 
            this.book_cancel.Location = new System.Drawing.Point(413, 459);
            this.book_cancel.Margin = new System.Windows.Forms.Padding(4);
            this.book_cancel.Name = "book_cancel";
            this.book_cancel.Size = new System.Drawing.Size(90, 29);
            this.book_cancel.TabIndex = 0;
            this.book_cancel.Text = "<Back";
            this.book_cancel.UseVisualStyleBackColor = true;
            this.book_cancel.Click += new System.EventHandler(this.book_cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(185, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Booking ID";
            // 
            // tb_bookingid
            // 
            this.tb_bookingid.Location = new System.Drawing.Point(304, 110);
            this.tb_bookingid.Name = "tb_bookingid";
            this.tb_bookingid.ReadOnly = true;
            this.tb_bookingid.Size = new System.Drawing.Size(100, 24);
            this.tb_bookingid.TabIndex = 2;
            // 
            // tb_membername
            // 
            this.tb_membername.Location = new System.Drawing.Point(304, 208);
            this.tb_membername.Name = "tb_membername";
            this.tb_membername.ReadOnly = true;
            this.tb_membername.Size = new System.Drawing.Size(171, 24);
            this.tb_membername.TabIndex = 3;
            // 
            // cb_memberid
            // 
            this.cb_memberid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_memberid.FormattingEnabled = true;
            this.cb_memberid.Location = new System.Drawing.Point(304, 158);
            this.cb_memberid.Name = "cb_memberid";
            this.cb_memberid.Size = new System.Drawing.Size(100, 26);
            this.cb_memberid.TabIndex = 4;
            this.cb_memberid.SelectedIndexChanged += new System.EventHandler(this.cb_memberid_SelectedIndexChanged);
            // 
            // tb_facilityname
            // 
            this.tb_facilityname.Location = new System.Drawing.Point(304, 255);
            this.tb_facilityname.Name = "tb_facilityname";
            this.tb_facilityname.ReadOnly = true;
            this.tb_facilityname.Size = new System.Drawing.Size(100, 24);
            this.tb_facilityname.TabIndex = 5;
            // 
            // tb_facilityid
            // 
            this.tb_facilityid.Location = new System.Drawing.Point(304, 301);
            this.tb_facilityid.Name = "tb_facilityid";
            this.tb_facilityid.ReadOnly = true;
            this.tb_facilityid.Size = new System.Drawing.Size(100, 24);
            this.tb_facilityid.TabIndex = 6;
            // 
            // tb_timeslot
            // 
            this.tb_timeslot.Location = new System.Drawing.Point(304, 344);
            this.tb_timeslot.Name = "tb_timeslot";
            this.tb_timeslot.ReadOnly = true;
            this.tb_timeslot.Size = new System.Drawing.Size(100, 24);
            this.tb_timeslot.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(185, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "Member Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(185, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "Member Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(185, 261);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Facility Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(185, 307);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Facility ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(185, 350);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "Time Slot";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(185, 396);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Date";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(188, 459);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(90, 29);
            this.button1.TabIndex = 15;
            this.button1.Text = "Book";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Maiandra GD", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(257, 39);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(224, 29);
            this.label8.TabIndex = 16;
            this.label8.Text = "Facility Slot Booking";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(304, 390);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(98, 24);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 565);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(304, 459);
            this.button2.Margin = new System.Windows.Forms.Padding(4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(90, 29);
            this.button2.TabIndex = 19;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Booking_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(584, 562);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_timeslot);
            this.Controls.Add(this.tb_facilityid);
            this.Controls.Add(this.tb_facilityname);
            this.Controls.Add(this.cb_memberid);
            this.Controls.Add(this.tb_membername);
            this.Controls.Add(this.tb_bookingid);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.book_cancel);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "Booking_UI";
            this.Text = "Booking Form";
            this.Load += new System.EventHandler(this.Booking_UI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button book_cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_bookingid;
        private System.Windows.Forms.TextBox tb_membername;
        private System.Windows.Forms.ComboBox cb_memberid;
        private System.Windows.Forms.TextBox tb_facilityname;
        private System.Windows.Forms.TextBox tb_facilityid;
        private System.Windows.Forms.TextBox tb_timeslot;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button2;
    }
}