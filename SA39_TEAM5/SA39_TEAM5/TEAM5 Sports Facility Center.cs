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
    public partial class TEAM5_Sports_Facility_Center : Form
    {
        //private int childFormNumber = 0;
        public string userid
        {
            get;
            set;
        }
        public TEAM5_Sports_Facility_Center()
        {
            InitializeComponent();
        }
        
        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseActiveChild();
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (this.userid != null)
            {
                CloseActiveChild();
                Main_UI ma_ui = new Main_UI();
                ma_ui.MdiParent = this;
                ma_ui.Show();
                ma_ui.WindowState = FormWindowState.Maximized;
             
            }
            else
            {
                SFC_Login_UI log = new SFC_Login_UI(this);
                log.MdiParent = this;
                log.Show();
            }

        }
        public void enable_normal_user()
        {
            addToolStripMenuItem.Enabled = true;
            updateToolStripMenuItem.Enabled = true;
            bookToolStripMenuItem.Enabled = true;
            addToolStripMenuItem.DropDownItems[1].Enabled= false;
            updateToolStripMenuItem.DropDownItems[2].Enabled = false;
            
        }
        public void enable_admin_user()
        {
            addToolStripMenuItem.Enabled = true;
            updateToolStripMenuItem.Enabled = true;
            bookToolStripMenuItem.Enabled = false;
            addToolStripMenuItem.DropDownItems[1].Enabled = true;
            updateToolStripMenuItem.DropDownItems[1].Enabled = true;
            addToolStripMenuItem.DropDownItems[0].Enabled = false;
            updateToolStripMenuItem.DropDownItems[0].Enabled = false;
            updateToolStripMenuItem.DropDownItems[1].Enabled = false;
            updateToolStripMenuItem.DropDownItems[2].Enabled = true;
            toolStripMenuItem1.Enabled = true;
            reportToolStripMenuItem.Enabled = true;
        }
        private void disableAll()
        {
            bookToolStripMenuItem.Enabled = false;
            addToolStripMenuItem.Enabled = false;
            updateToolStripMenuItem.Enabled = false;
            toolStripMenuItem1.Enabled = false;
            reportToolStripMenuItem.Enabled = false;
            
        }
        private void TEAM5_Sports_Facility_Center_Load(object sender, EventArgs e)
        {
            disableAll();
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseActiveChild();
            userid = null;
            disableAll();
            loginToolStripMenuItem_Click(sender, e);
        }

        private void CloseActiveChild()
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseActiveChild();
            this.Close();
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void bookToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CloseActiveChild();
            Select_Slots_UI ma_ui = new Select_Slots_UI();
            ma_ui.MdiParent = this;
            ma_ui.Show();
            ma_ui.WindowState = FormWindowState.Maximized;
        }

        private void cancelBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseActiveChild();
            Cancel_Booking ca_ui = new Cancel_Booking();
            ca_ui.MdiParent = this;
            ca_ui.Show();
            ca_ui.WindowState = FormWindowState.Maximized;
        }

        private void newMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseActiveChild();
            AddNewMemberUI new_ui = new AddNewMemberUI();
            new_ui.MdiParent = this;
            new_ui.Show();
            new_ui.WindowState = FormWindowState.Maximized;
        }

        private void newFacilityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseActiveChild();
            AddFacility new_fac = new AddFacility();
            new_fac.MdiParent = this;
            new_fac.Show();
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CloseActiveChild();
            MantainanceUI main_tain = new MantainanceUI();
            main_tain.MdiParent = this;
            main_tain.Show();
        }

        private void facilityToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseActiveChild();
            DeleteFacilityUI del_fac= new DeleteFacilityUI();
            del_fac.MdiParent = this;
            del_fac.Show();
        }

        private void memberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseActiveChild();
            Update_Memeber_Ui new_mem = new Update_Memeber_Ui();
            new_mem.MdiParent = this;
            new_mem.Show();
        }

        private void deleteMemberToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseActiveChild();
            deletememberUI dem = new deletememberUI();
            dem.MdiParent = this;
            dem.Show();
        }

        private void barChartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report.OccupancyForm oc = new Report.OccupancyForm();
            oc.ShowDialog();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Report.MemberDet_Report_UI mme_rp = new Report.MemberDet_Report_UI();
            mme_rp.ShowDialog();
        }

        private void transactionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report.crosstab_form trans = new Report.crosstab_form();
            trans.ShowDialog();
            
        }

        
    }
}
