namespace SA39_TEAM5
{
    partial class Select_Slots_UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Select_Slots_UI));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.c_facility = new System.Windows.Forms.ComboBox();
            this.fac_date = new System.Windows.Forms.DateTimePicker();
            this.t_timeslot = new System.Windows.Forms.TextBox();
            this.t_facilityroom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.b_findslot = new System.Windows.Forms.Button();
            this.b_book = new System.Windows.Forms.Button();
            this.b_cancel = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(269, 89);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Facility";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(170, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 18);
            this.label2.TabIndex = 1;
            this.label2.Text = "Facility";
            // 
            // c_facility
            // 
            this.c_facility.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.c_facility.FormattingEnabled = true;
            this.c_facility.Location = new System.Drawing.Point(275, 180);
            this.c_facility.Name = "c_facility";
            this.c_facility.Size = new System.Drawing.Size(121, 26);
            this.c_facility.TabIndex = 2;
            // 
            // fac_date
            // 
            this.fac_date.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fac_date.Location = new System.Drawing.Point(275, 230);
            this.fac_date.Name = "fac_date";
            this.fac_date.Size = new System.Drawing.Size(121, 24);
            this.fac_date.TabIndex = 3;
            // 
            // t_timeslot
            // 
            this.t_timeslot.Location = new System.Drawing.Point(275, 277);
            this.t_timeslot.Name = "t_timeslot";
            this.t_timeslot.ReadOnly = true;
            this.t_timeslot.Size = new System.Drawing.Size(121, 24);
            this.t_timeslot.TabIndex = 4;
            // 
            // t_facilityroom
            // 
            this.t_facilityroom.Location = new System.Drawing.Point(275, 325);
            this.t_facilityroom.Name = "t_facilityroom";
            this.t_facilityroom.ReadOnly = true;
            this.t_facilityroom.Size = new System.Drawing.Size(121, 24);
            this.t_facilityroom.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(170, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 18);
            this.label3.TabIndex = 6;
            this.label3.Text = "Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(170, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Time Slot";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(170, 328);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Facility Room";
            // 
            // b_findslot
            // 
            this.b_findslot.Location = new System.Drawing.Point(418, 274);
            this.b_findslot.Name = "b_findslot";
            this.b_findslot.Size = new System.Drawing.Size(75, 31);
            this.b_findslot.TabIndex = 9;
            this.b_findslot.Text = "Find Slots";
            this.b_findslot.UseVisualStyleBackColor = true;
            this.b_findslot.Click += new System.EventHandler(this.b_findslot_Click);
            // 
            // b_book
            // 
            this.b_book.Location = new System.Drawing.Point(275, 383);
            this.b_book.Name = "b_book";
            this.b_book.Size = new System.Drawing.Size(75, 31);
            this.b_book.TabIndex = 10;
            this.b_book.Text = "Book";
            this.b_book.UseVisualStyleBackColor = true;
            this.b_book.Click += new System.EventHandler(this.b_book_Click);
            // 
            // b_cancel
            // 
            this.b_cancel.Location = new System.Drawing.Point(374, 383);
            this.b_cancel.Name = "b_cancel";
            this.b_cancel.Size = new System.Drawing.Size(75, 31);
            this.b_cancel.TabIndex = 11;
            this.b_cancel.Text = "Cancel";
            this.b_cancel.UseVisualStyleBackColor = true;
            this.b_cancel.Click += new System.EventHandler(this.b_cancel_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(157, 565);
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // Select_Slots_UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(584, 562);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.b_cancel);
            this.Controls.Add(this.b_book);
            this.Controls.Add(this.b_findslot);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.t_facilityroom);
            this.Controls.Add(this.t_timeslot);
            this.Controls.Add(this.fac_date);
            this.Controls.Add(this.c_facility);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "Select_Slots_UI";
            this.Text = "Book Facility";
            this.Load += new System.EventHandler(this.Select_Slots_UI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox c_facility;
        private System.Windows.Forms.DateTimePicker fac_date;
        private System.Windows.Forms.TextBox t_timeslot;
        private System.Windows.Forms.TextBox t_facilityroom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button b_findslot;
        private System.Windows.Forms.Button b_book;
        private System.Windows.Forms.Button b_cancel;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}