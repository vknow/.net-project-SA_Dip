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
    public partial class Cancel_Booking : Form
    {
        Cancel_Booking_Controller cont;
        public Cancel_Booking()
        {
            InitializeComponent();
        }

        private void Cancel_Booking_Load(object sender, EventArgs e)
        {
            cont = new Cancel_Booking_Controller();
            cont.ComboBoxFill(this,cb_memid,cb_memname);
        }

        private void search_Click(object sender, EventArgs e)
        {
            if(cb_memid.Text != "")
            {
                dataGridView1.DataSource = (cont.getByID(cb_memid.Text, cb_memname)).ToList();

            }
            else
            {
                
                dataGridView1.DataSource = cont.getByName(cb_memname.Text).ToList();
            }
            cb_memid.SelectedIndex = 0;
        }

        private void cancel_slot_Click(object sender, EventArgs e)
        {
            MessageBoxButtons a = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Confirm to delete one booking record?", "", a);
            
            //Cancel Booking in Datagridview
            
            if (result == DialogResult.Yes)
            {
                SA39_PROJECTEntities1 context = new SA39_PROJECTEntities1();
                int x = dataGridView1.CurrentRow.Index;
                string str = dataGridView1[0, x - 1].Value.ToString();
                int y = Convert.ToInt16(str);

                bookingdetail book = context.bookingdetails.First(i => i.Booking_id == y);

                context.bookingdetails.Remove(book);
                context.SaveChanges();

                dataGridView1.DataSource = cont.getByName(cb_memname.Text).ToList();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
