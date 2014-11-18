using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA39_TEAM5
{
    class Booking_Controller
    {
        private SA39_PROJECTEntities1 context;
        private ref_key keyed;
        private int key;
        public string getBookingID()
        {
            context = new SA39_PROJECTEntities1();
            var q_key = from n in context.ref_key
                    select n;
            keyed = q_key.First<ref_key>();
            key =(int) keyed.book_id;
            key++;
            return key.ToString();
        }

        public List<string> getAllMemberId()
        {
            var q_memberid = from n in context.memberdetails
                           select n.Member_id;
            return q_memberid.ToList();
        }
        public string getMemberName(string memberId)
        {
            var q_memberName = from n in context.memberdetails
                               where n.Member_id==memberId
                               select n.Member_name;
            return q_memberName.First();
        }
        public bool insert_Booking(bookingdetail b_ins)
        {
            context.bookingdetails.Add(b_ins);
            int conf=context.SaveChanges();
            if(conf==1)
            {
                keyed.book_id = key;
                context.SaveChanges();
                return true;
        
            }
            return false;
        }
    }
}
