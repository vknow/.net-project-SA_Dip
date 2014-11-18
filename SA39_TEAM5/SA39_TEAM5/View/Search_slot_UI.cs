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
    public partial class Search_slot_UI : Form
    {
        Search_slot_Controller ssc_cont;
        static List<KeyValuePair<string, string>> time_no_avail;
        DateTime ser_date;
        string ser_fac_name;
        static int no_of_set;
        static List<string> l_fac_id;
        public Search_slot_UI()
        {
            InitializeComponent();
            ssc_cont = new Search_slot_Controller();
        }
        public Search_slot_UI(DateTime ser_date, string ser_fac_name)
        {
            InitializeComponent();
            ssc_cont = new Search_slot_Controller();
            this.ser_date = ser_date;
            this.ser_fac_name = ser_fac_name;
        }
        private int setForm() 
        {
            //GET ALL FACILITY ID TO PARTICULAR FACITITY NAME
            //RETURN COUNT
            l_fac_id = new List<string>();
            l_fac_id = ssc_cont.getAllFacilityID(ser_fac_name);
            return (l_fac_id.Count);
        }
        private void Search_slot_UI_Load(object sender, EventArgs e)
        {
            no_of_set = setForm();
            time_no_avail = ssc_cont.get_avail_Slot(ser_date.ToString("yyyy-MM-dd"),ser_fac_name);
            this.MaximumSize = new Size(no_of_set * 100, 500); //SETTING DIALOG BOX SIZE
            this.MinimumSize = new Size(no_of_set * 100, 500); //SETTING DIALOG BOX SIZE
            button_load();     // DRAWING  DYNAMIC BUTTONS
        }
        public void button_load()
        {
            Button[] b = new Button[10];

            DateTime curr_date = DateTime.Now.Date;
            int curr_time = DateTime.Now.TimeOfDay.Hours;
            
            string[] str = l_fac_id.ToArray();

            GroupBox[] g = new GroupBox[no_of_set];

            for (int j = 0; j < no_of_set; j++)
            {
                //CREATING GROUPBOX

                g[j] = new GroupBox();
                g[j].Text = str[j];
                this.Controls.Add(g[j]);
                g[j].Size = new Size(75, 350);
                g[j].Location = new Point(100 * j, 50);


                List<DateTime> s_date = ssc_cont.getStartDate(str[j]);
                List<DateTime> e_date = ssc_cont.getEndDate(str[j]);

                int y = 0;
                int x = 10;
                for (int i = 0; i < 10; i++)
                {
                    //CREATING BOTTON FOR EACH TIME SLOT
                    y += 30; //POSITION OF BUTTON 'Y-AIXS'
                    b[i] = new Button();
                    b[i].Size = new Size(60, 25);
                    b[i].Location = new Point(x, y);
                    b[i].Text = String.Format("{0:00}:00", i + 9);

                    //DETECTING BOOKED SLOT

                    foreach (KeyValuePair<string, string> in0 in time_no_avail)
                    {
                        if (in0.Key == g[j].Text && in0.Value == b[i].Text)
                        {
                            b[i].Enabled = false;
                            b[i].BackColor = Color.Red;
                        }
                    }

                    int temp = Convert.ToInt32((b[i].Text).Split(':')[0]);

                    //SET UNAVAILABLE BEFORE CURRENT TIME

                    if ((curr_date.Date == ser_date.Date && temp <= curr_time) )
                    {
                        b[i].Enabled = false;
                        b[i].BackColor = Color.Yellow;
                    }

                    //SET UNAVAILABLE SLOTS FROM MAINTAINCE TABLE

                    for (int le = 0; le < s_date.Count;le++ )
                    {
                         if(ser_date.Date <=e_date.ElementAt(le).Date && ser_date.Date >= s_date.ElementAt(le).Date)
                         {
                             b[i].Enabled = false;
                             b[i].BackColor = Color.Yellow;
                         }
                    }

                    g[j].Controls.Add(b[i]);
                    b[i].Click += new System.EventHandler(this.button1_Click);
                }
                x = x + 70;
            }
            time_no_avail.Clear();


        }

        public String TimeSlot
        {
            get;
            set;
        }
        public String FacilityID
        {
            get;
            set;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            TimeSlot = b.Text;
            FacilityID = b.Parent.Text;
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
        }
    }
}
