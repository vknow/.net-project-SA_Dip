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
    public partial class AddFacility : Form
    {
        private Add_New_Facility_Controller cs;
        private int count;
        private TextBox t;
        private Button b;
        public AddFacility()
        {
            InitializeComponent();
        }

        private void bt_addFac_Click(object sender, EventArgs e)
        {
           
            try
            {
                flowLayoutPanel1.Controls.Clear();
           
                count = Convert.ToInt32(tb_facCount.Text);
                for (int i = 0; i < count; i++)
                {
                    t = new TextBox();
                    t.Height = 20;
                    t.Width = 100;
                    t.Name = "textbox";
                    t.Parent = flowLayoutPanel1;
                    flowLayoutPanel1.Controls.Add(t);
                }
                b = new Button();
                b.Height = 25;
                b.Width = 100;
                b.Parent = flowLayoutPanel1;
                b.BackColor = Color.Gray;
                b.Text = "Update";
                b.Click += new EventHandler(update_Click);
                flowLayoutPanel1.Controls.Add(b);
            }
            catch(InvalidCastException)
            {
                MessageBox.Show("Enter a Valid Data");
            }
  
        }
        public void update_Click(object sender, EventArgs e)
        {
            cs = new Add_New_Facility_Controller();
            if (cs.checkText(flowLayoutPanel1.Controls))
            {
               
                if (tb_facName.Text != "")
                {
                    string status = cs.Store_Record(flowLayoutPanel1.Controls, tb_facName.Text, tb_facDesc.Text);
                    if (!status.Equals(""))
                    {
                        MessageBox.Show(status + "present");
                    }
                    else
                    {
                        MessageBox.Show("Facility Added");
                    }
                }
                else
                {
                    MessageBox.Show("Enter Facility Name");
                }
            }
            else
            {
                MessageBox.Show("Facility ID cannot be Empty");
            }
        }

        private void AddFacility_Load(object sender, EventArgs e)
        {

        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            
            Main_UI m = new Main_UI();
            m.MdiParent = this.MdiParent;
            this.Close();
            m.Show();
        }
    }
}
