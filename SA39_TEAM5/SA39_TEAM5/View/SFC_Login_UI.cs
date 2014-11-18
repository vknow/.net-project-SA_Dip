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
    public partial class SFC_Login_UI : Form
    {
        TEAM5_Sports_Facility_Center ref_obj;
        userdetail u_mem;
        public SFC_Login_UI()
        {
            InitializeComponent();
        }
        public SFC_Login_UI(TEAM5_Sports_Facility_Center obj)
        {
            InitializeComponent();
            ref_obj = obj;
        }

        private void SFC_Login_UI_Load(object sender, EventArgs e)
        {
            
        }

        private void login_bt_Click(object sender, EventArgs e)
        {
            u_mem = new userdetail();
            u_mem.Username = t_username.Text.Trim();
            u_mem.Password = t_password.Text.Trim();
            
            Login_Controller lg_con = new Login_Controller();
            if(lg_con.CheckUser(u_mem))
            {
                ref_obj.userid = u_mem.Username;
                Main_UI ma_ui = new Main_UI();
                ma_ui.MdiParent = ref_obj;
                ma_ui.Show();
                string role = lg_con.getRole(u_mem.Username);
                if(role == "user")
                {
                    ref_obj.enable_normal_user();
                }
                else
                {
                    ref_obj.enable_admin_user();
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("UserName and/or Password Mismatch :P");
            }
        }

        private void b_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
