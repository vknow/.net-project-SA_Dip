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
    public partial class MantainanceUI : Form
    {
        private maintainance_controller con;
        private List<string> facilityname;
        private List<string> facilityId;

        public MantainanceUI()
        {
            InitializeComponent();
        }

        private void MantainanceUI_Load_1(object sender, EventArgs e)
        {
            con = new maintainance_controller();
            facilityname = con.GetFacilityName();
            cb_facility_name.DataSource = facilityname;
            dt_start.MinDate = DateTime.Now;
            dt_end.MinDate = DateTime.Now;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            facilityId = con.GetFacilityId(cb_facility_name.Text);
            cb_facility_id.DataSource = facilityId;
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            bool status = con.SetData(cb_facility_id.Text, dt_start.Text, dt_end.Text);
            if (status)
            {
                MessageBox.Show("Added Successfully");
            }
            else
            {
                MessageBox.Show("Record Present");
            }
        }
       
        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            dt_end.MinDate = dt_start.Value.AddDays(1);
        }

        private void bt_Cancel_Click(object sender, EventArgs e)
        {
            Main_UI m = new Main_UI();
            m.MdiParent = this.MdiParent;
            m.Show();
            this.Close();

        }

       

    }
}
