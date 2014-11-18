using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA39_TEAM5
{
    class maintainance_controller
    {
        private SA39_PROJECTEntities1 context;
        private List<string> facilityName;
        private List<string> facilityId;
        private maintainancedetail m1;
        public List<string> GetFacilityName()
        {
            context = new SA39_PROJECTEntities1();
            var q = from n in context.facilitydetails
                    group n by n.Facility_name;
            facilityName = new List<string>();
            foreach (var t in q)
            {
                facilityName.Add(t.Key);
            }
            return facilityName;
        }
        public List<string> GetFacilityId(string facility)
        {
            context = new SA39_PROJECTEntities1();
            facilityId = new List<string>();
            var q = from n in context.facilitydetails
                    where n.Facility_name == facility
                    select n.Facility_id;
            return q.ToList<string>();
        }
        public bool SetData(string id, string start, string end)
        {
            context = new SA39_PROJECTEntities1();
            var q = from n in context.maintainancedetails
                    where n.facility_id == id
                    select n;
            int temp = 0, up = 0;
            foreach (var t in q)
            {
                if (t.facility_id == id && t.startdate == Convert.ToDateTime(start) && t.enddate != Convert.ToDateTime(end))
                {
                    m1 = t;
                    up = 1;
                }
                if (t.facility_id == id && t.startdate <= Convert.ToDateTime(start))
                {
                    if (t.enddate >= Convert.ToDateTime(end))
                    {
                        temp++;
                    }
                }
            }
            if (temp == 0 && up == 0)
            {
                maintainancedetail m = new maintainancedetail();
                m.facility_id = id;
                m.startdate = Convert.ToDateTime(start).Date;
                m.enddate = Convert.ToDateTime(end).Date;
                context.maintainancedetails.Add(m);
                context.SaveChanges();
                return true;
            }
            else if (up > 0)
            {
                m1.enddate = Convert.ToDateTime(end).Date;
                context.SaveChanges();
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
