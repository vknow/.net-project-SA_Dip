using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA39_TEAM5
{
    class Select_slots_Controller
    {
        private SA39_PROJECTEntities1 face_cont;
        
        public List<string> getAllFacilityName()
        {
            List<string> all_fac = new List<string>();
            face_cont = new SA39_PROJECTEntities1();
            var query = from n in face_cont.facilitydetails
                        group n by n.Facility_name;
            foreach(var t in query)
            {
                all_fac.Add(t.Key);
            }
            
            return all_fac;
        }
    }
}
