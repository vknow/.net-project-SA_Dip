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
    public partial class DeleteFacilityUI : Form
    {
        private DeleteFacility_controller con;
        private List<string> facilityname;
        private List<string> facilityId;
        public DeleteFacilityUI()
        {
            InitializeComponent();
        }

        private void DeleteFacilityUI_Load(object sender, EventArgs e)
        {
            con = new DeleteFacility_controller();
            facilityname = con.GetFacilityName();
            cb_del_facname.DataSource = facilityname;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //GET FACILITY ID
            facilityId = con.GetFacilityId(cb_del_facname.Text);
            cb_del_facid.DataSource = facilityId;
        }
        private void reload_cb()
        {
            facilityId = con.GetFacilityId(cb_del_facname.Text);
            cb_del_facid.DataSource = facilityId;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBoxButtons a = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show("Confirm to delete Faclility Record ?", "", a);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                if (con.Delete(cb_del_facname.Text, cb_del_facid.Text) > 0)
                {
                    MessageBox.Show("Successfully Deleted");
                    reload_cb();
                }
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Main_UI m = new Main_UI();
            m.MdiParent = this.MdiParent;
            m.Show();
            this.Close();
        }
    }
}
