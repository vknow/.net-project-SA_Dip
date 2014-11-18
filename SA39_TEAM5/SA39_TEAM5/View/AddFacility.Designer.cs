namespace SA39_TEAM5
{
    partial class AddFacility
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFacility));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_facName = new System.Windows.Forms.TextBox();
            this.tb_facCount = new System.Windows.Forms.TextBox();
            this.tb_facDesc = new System.Windows.Forms.TextBox();
            this.bt_addFac = new System.Windows.Forms.Button();
            this.bt_cancel = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(160, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Facility Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(160, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Count";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(160, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 18);
            this.label3.TabIndex = 3;
            this.label3.Text = "Facility Description";
            // 
            // tb_facName
            // 
            this.tb_facName.Location = new System.Drawing.Point(291, 67);
            this.tb_facName.MaxLength = 30;
            this.tb_facName.Name = "tb_facName";
            this.tb_facName.Size = new System.Drawing.Size(192, 24);
            this.tb_facName.TabIndex = 4;
            // 
            // tb_facCount
            // 
            this.tb_facCount.Location = new System.Drawing.Point(291, 112);
            this.tb_facCount.MaxLength = 2;
            this.tb_facCount.Name = "tb_facCount";
            this.tb_facCount.Size = new System.Drawing.Size(41, 24);
            this.tb_facCount.TabIndex = 5;
            // 
            // tb_facDesc
            // 
            this.tb_facDesc.Location = new System.Drawing.Point(291, 158);
            this.tb_facDesc.MaxLength = 50;
            this.tb_facDesc.Multiline = true;
            this.tb_facDesc.Name = "tb_facDesc";
            this.tb_facDesc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tb_facDesc.Size = new System.Drawing.Size(192, 93);
            this.tb_facDesc.TabIndex = 6;
            // 
            // bt_addFac
            // 
            this.bt_addFac.Location = new System.Drawing.Point(291, 274);
            this.bt_addFac.Name = "bt_addFac";
            this.bt_addFac.Size = new System.Drawing.Size(81, 38);
            this.bt_addFac.TabIndex = 7;
            this.bt_addFac.Text = "Add";
            this.bt_addFac.UseVisualStyleBackColor = true;
            this.bt_addFac.Click += new System.EventHandler(this.bt_addFac_Click);
            // 
            // bt_cancel
            // 
            this.bt_cancel.Location = new System.Drawing.Point(402, 274);
            this.bt_cancel.Name = "bt_cancel";
            this.bt_cancel.Size = new System.Drawing.Size(81, 38);
            this.bt_cancel.TabIndex = 8;
            this.bt_cancel.Text = "Cancel";
            this.bt_cancel.UseVisualStyleBackColor = true;
            this.bt_cancel.Click += new System.EventHandler(this.bt_cancel_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(271, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(154, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "ADD FACILITY";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-10, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(140, 568);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(291, 318);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(192, 232);
            this.flowLayoutPanel1.TabIndex = 10;
            // 
            // AddFacility
            // 
            this.AcceptButton = this.bt_addFac;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(584, 562);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.bt_cancel);
            this.Controls.Add(this.bt_addFac);
            this.Controls.Add(this.tb_facDesc);
            this.Controls.Add(this.tb_facCount);
            this.Controls.Add(this.tb_facName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(600, 600);
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "AddFacility";
            this.Text = "Add New Facility";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AddFacility_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_facName;
        private System.Windows.Forms.TextBox tb_facCount;
        private System.Windows.Forms.TextBox tb_facDesc;
        private System.Windows.Forms.Button bt_addFac;
        private System.Windows.Forms.Button bt_cancel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}