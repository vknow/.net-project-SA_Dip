using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace SA39_TEAM5
{
    class Add_New_Facility_Controller
    {
        private SA39_PROJECTEntities1 sa;
        private facilitydetail f;
        private bool status = true;
        private string text = "";
        public string Store_Record(FlowLayoutPanel.ControlCollection det, string facility_name, string facility_desc)
        {
            sa = new SA39_PROJECTEntities1();
            foreach (Control c in det)
            {
                if (c.Name == "textbox")
                {
                    var query = from n in sa.facilitydetails
                                where n.Facility_id == c.Text
                                select n.Facility_id;

                    if (query.Any())
                    {
                        status = false;
                        text = text + " " + query.First();
                    }
                }

            }
            if (status)
            {
                foreach (Control c in det)
                {
                    f = new facilitydetail();
                    if (c.Name == "textbox")
                    {
                        f.Facility_id = c.Text;
                        f.Facility_name = facility_name;
                        f.Facility_desc = facility_desc;
                        sa.facilitydetails.Add(f);
                        sa.SaveChanges();
                    }

                }
            }
            return text;
        }

        public bool checkText(FlowLayoutPanel.ControlCollection det)
        {
            bool flag = true;
            sa = new SA39_PROJECTEntities1();
            foreach (Control c in det)
            {
                if (c.Name == "textbox" && c.Text == "")
                {
                    flag = false;
                }
            }
            return flag;
        }
    }
}
