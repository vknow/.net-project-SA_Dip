using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA39_TEAM5
{
    class DeleteFacility_controller
    {
        private SA39_PROJECTEntities1 context;
        private List<string> facilityName;
        private List<string> facilityId;
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
        public int Delete(string name, string id)
        {
            var delmain = from n in context.maintainancedetails
                          where n.facility_id == id
                          select n;
            var delbookdetail = from n in context.bookingdetails
                                where n.Facility_id == id
                                select n;
            var delfid = from n in context.facilitydetails
                         where n.Facility_id == id
                         select n;
            foreach (var t in delmain)
            {
                context.maintainancedetails.Remove(t);

            }
            foreach (var t in delbookdetail)
            {
                context.bookingdetails.Remove(t);
            }

            facilitydetail f = delfid.First<facilitydetail>();
            context.facilitydetails.Remove(f);
            return (context.SaveChanges());
        }
    }
}
