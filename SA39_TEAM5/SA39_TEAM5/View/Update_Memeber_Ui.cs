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
    public partial class Update_Memeber_Ui : Form
    {
        updatemembercontrolles cont;
        memberdetail mem;
        public Update_Memeber_Ui()
        {
            InitializeComponent();
            mem = new memberdetail();
            cont = new updatemembercontrolles();
        }

        private void Update_Memeber_Ui_Load(object sender, EventArgs e)
        {
            cb_memid.DataSource=cont.getMemId();
        }

        private void getMember_Name(object sender, EventArgs e)
        {
            List <memberdetail> val =cont.getMemDetail(cb_memid.Text);
            tb_name.Text = val.ElementAt(0).Member_name;
            tb_contact.Text = val.ElementAt(0).Contact_number;
            tb_email.Text = val.ElementAt(0).Email;
        }

        private void bt_update_Click(object sender, EventArgs e)
        {
            
            if(tb_name.Text !="" )
            {
                mem.Member_id = cb_memid.Text;
                mem.Member_name = tb_name.Text;
                mem.Contact_number = tb_contact.Text;
                mem.Email = tb_email.Text;
               if( cont.save(mem)==1)
               {
                   MessageBox.Show("Successfully Updated");
               }
            }
        }

        private void bt_cancel_Click(object sender, EventArgs e)
        {
            Main_UI m = new Main_UI();
            m.MdiParent = this.MdiParent;
            m.Show();
            this.Close();
        }



       
    }
}
