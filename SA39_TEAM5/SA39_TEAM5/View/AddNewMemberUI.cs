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
    public partial class AddNewMemberUI : Form
    {
        AddMemberController abc = new AddMemberController();
        public AddNewMemberUI()
        {
            InitializeComponent();
        }

        private void AddNewMemberUI_Load(object sender, EventArgs e)
        {
            tb_memid.Text = abc.generateMemId();
        }

        private void bt_add_Click(object sender, EventArgs e)
        {
            memberdetail m = new memberdetail();
            if (tb_mem_name.Text != "" || (radioButton1.Checked == false && radioButton1.Checked == false))
            {
                m.Member_id = tb_memid.Text;
                m.Member_name = tb_mem_name.Text;
                if (radioButton1.Checked == true)
                { m.Gender = "M"; }
                else
                { m.Gender = "F"; }
                m.Contact_number = tb_contact.Text;
                m.Email = tb_email.Text;

                if (abc.Create(m) == 1)
                {
                    MessageBox.Show("Member Added");
                }

            }
            else
            {
                MessageBox.Show("Enter Valid Details");
            }

            
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            Main_UI mi = new Main_UI();
            mi.MdiParent = this.MdiParent;
            mi.Show();
            this.Close();
        }

        private void bt_clear_Click(object sender, EventArgs e)
        {
            tb_mem_name.Text = "";
            tb_email.Text = "";
            tb_contact.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
        }
    }
}
