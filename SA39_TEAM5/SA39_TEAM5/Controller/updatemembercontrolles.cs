using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA39_TEAM5
{
    class updatemembercontrolles
    {
        SA39_PROJECTEntities1 up_context;
        memberdetail me;

        public List<string> getMemId()
        {
            up_context = new SA39_PROJECTEntities1();
            var q = from i in up_context.memberdetails 
                    select i.Member_id;
            return q.ToList();
        }
        public List<memberdetail> getMemDetail(string memid)
        {
            List<memberdetail> values = new List<memberdetail>();
            var q = from i in up_context.memberdetails
                    where i.Member_id == memid
                    select i;
            values = q.ToList<memberdetail>();
            return values;

        }
        public int save(memberdetail me1)
        {

            var q = from i in up_context.memberdetails
                    where i.Member_id == me1.Member_id
                    select i;
            me = q.First<memberdetail>();

            me.Contact_number = me1.Contact_number;
            me.Member_name = me1.Member_name;
            me.Email = me1.Email;

            return up_context.SaveChanges();
        }
    }
}
