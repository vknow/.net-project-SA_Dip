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
    public partial class Booking_UI : Form
    {
        Select_Slots_UI temp_obj;
        Booking_Controller b_cont;
        bookingdetail b_ins;
        string[] book_val = new string[4];
        public Booking_UI()
        {
            InitializeComponent();
        }
        public Booking_UI(Select_Slots_UI s,string bok_date,string bok_facno,string bok_facname,string bok_time) 
        {
            temp_obj = s;
            book_val[0] = bok_date;
            book_val[1] = bok_facno;
            book_val[2] = bok_facname;
            book_val[3] = bok_time;
            InitializeComponent();
        }

        private void Booking_UI_Load(object sender, EventArgs e)
        {
            b_cont = new Booking_Controller();
            tb_bookingid.Text = b_cont.getBookingID();
            cb_memberid.DataSource = b_cont.getAllMemberId();
            tb_facilityid.Text = book_val[1];
            tb_facilityname.Text = book_val[2];
            tb_timeslot.Text = book_val[3];
            dateTimePicker1.Value = Convert.ToDateTime(book_val[0]);

        }

        private void book_cancel_Click(object sender, EventArgs e)
        {
            temp_obj.Show();
            this.Close();
        }

        private void cb_memberid_SelectedIndexChanged(object sender, EventArgs e)
        {
            tb_membername.Text = b_cont.getMemberName(cb_memberid.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            b_ins = new bookingdetail();
            b_ins.Booking_id = Convert.ToInt32(tb_bookingid.Text);
            b_ins.Member_id = cb_memberid.Text;
            b_ins.Facility_id = tb_facilityid.Text;
            b_ins.Booking_date = dateTimePicker1.Value;
            b_ins.Booking_time = tb_timeslot.Text;
            if(b_cont.insert_Booking(b_ins))
            {
                MessageBox.Show("Slot Booked");
                
                Main_UI mi = new Main_UI();
                mi.MdiParent = this.MdiParent;
                mi.Show();
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Main_UI mi = new Main_UI();
            mi.MdiParent = this.MdiParent;
            mi.Show();
            this.Close();
        }
    }
}
