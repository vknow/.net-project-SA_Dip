using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA39_TEAM5
{
    public partial class deletememberUI : Form
    {
        deletemembercontroller con;

        public deletememberUI()
        {
            InitializeComponent();
            
        }
      

        private void deletememberUI_Load(object sender, EventArgs e)
        {
            con = new deletemembercontroller();
            cb_mem_id.DataSource = con.GetMemberId();
            cb_mem_name.DataSource = con.GetMemberName();
        }
        
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_mem_name.SelectedIndex != -1)
            {

                cb_mem_name.SelectedIndex = con.Compareid(cb_mem_id.Text);
            }

        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            cb_mem_id.SelectedIndex = con.CompareName(cb_mem_name.Text);
        }
       
        private void button1_Click(object sender, EventArgs e)//delete Button
        {
            con.Delete(cb_mem_id.Text);
            cb_mem_name.DataSource = con.GetMemberName();
            cb_mem_id.DataSource = con.GetMemberId();

        }

        private void button1_Click_1(object sender, EventArgs e)//Cancel button
        {
            Main_UI ma = new Main_UI();
            ma.MdiParent = this.MdiParent;
            ma.Show();
            this.Close();
        }
    }
}
