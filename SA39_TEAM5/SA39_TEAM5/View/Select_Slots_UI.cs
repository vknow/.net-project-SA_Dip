using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA39_TEAM5
{
    public partial class Select_Slots_UI : Form
    {
        Select_slots_Controller ss_controller; 
        public Select_Slots_UI()
        {
            InitializeComponent();
        }

        private void Select_Slots_UI_Load(object sender, EventArgs e)
        {
            ss_controller = new Select_slots_Controller();
            c_facility.DataSource = ss_controller.getAllFacilityName();

            fac_date.MinDate = DateTime.Now.Date;
            fac_date.MaxDate = DateTime.Now.Date.AddDays(7);
        }

        private void b_findslot_Click(object sender, EventArgs e)
        {
            //OPEN DIALOG BOX TO SELECT FACILITY AND TIMESLOT

            Search_slot_UI ss_ui = new Search_slot_UI(fac_date.Value, c_facility.Text.Trim());
            ss_ui.ShowDialog();
            if (ss_ui.DialogResult == System.Windows.Forms.DialogResult.OK)
            {
                t_facilityroom.Text = ss_ui.FacilityID;
                t_timeslot.Text = ss_ui.TimeSlot;
            }
            
            
        }
        private void b_book_Click(object sender, EventArgs e)
        {
            if (t_facilityroom.Text != "" && t_timeslot.Text != "")
            {
                Booking_UI bb = new Booking_UI(this, fac_date.Value.ToString("yyyy-MM-dd"),
                    t_facilityroom.Text, c_facility.Text, t_timeslot.Text);
                bb.MdiParent = this.MdiParent;
                bb.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Select Facility Room and Time Slot");
            }

        }

        private void b_cancel_Click(object sender, EventArgs e)
        {
            Main_UI mi = new Main_UI();
            mi.MdiParent = this.MdiParent;
            mi.Show();
            this.Close();
        }
    }
}
