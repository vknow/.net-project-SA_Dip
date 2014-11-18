using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA39_TEAM5
{
    class deletemembercontroller
    {
        private SA39_PROJECTEntities1 context;
        private memberdetail m;
        //private bookingdetail b;
        public List<string> GetMemberName()
        {
            context = new SA39_PROJECTEntities1();
            var q = from n in context.memberdetails
                    select n.Member_name;
            return q.ToList();
        }
        public List<string> GetMemberId()
        {
            context = new SA39_PROJECTEntities1();
            var q = from n in context.memberdetails
                    select n.Member_id;
            return q.ToList();
        }
        public int CompareName(String name)
        {
            int index = 0, i = 0;
            context = new SA39_PROJECTEntities1();
            var q = from n in context.memberdetails
                    select n;
            foreach (var t in q)
            {
                m = (memberdetail)t;
                if (m.Member_name == name)
                {
                    index = i;
                }
                i++;
            }
            return index;
        }
        public int Compareid(String id)
        {
            int index = 1, i = 0;
            context = new SA39_PROJECTEntities1();
            var q = from n in context.memberdetails
                    select n;
            foreach (var t in q)
            {
                m = (memberdetail)t;
                if (m.Member_id == id)
                {
                    index = i;
                }
                i++;
            }
            return index;
        }
        public void Delete(string id)
        {
            var delbook = from n in context.bookingdetails
                          where n.Member_id == id
                          select n;
            var delmember = from n in context.memberdetails
                            where n.Member_id == id
                            select n;
            if (delbook.Any())
            {
                foreach (var t in delbook)
                {
                    context.bookingdetails.Remove(t);
                }
            }

            context.memberdetails.Remove(delmember.First<memberdetail>());
            context.SaveChanges();
        }
    }
}
