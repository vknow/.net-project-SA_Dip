using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SA39_TEAM5
{
    class AddMemberController
    {
        SA39_PROJECTEntities1 ent;
        public string generateMemId()
        {
            ent = new SA39_PROJECTEntities1();
            memberdetail mem= new memberdetail();
            string memid;

            var query = from i in ent.memberdetails
                        orderby i.Member_id descending 
                            select i.Member_id;

            string temp = query.First();
            int val = Convert.ToInt32(Regex.Match(temp, @"\d+").Value);
            memid = temp.Substring(0, 1) + String.Format("{0:000}", (val + 1)) + temp.Substring(temp.Length-1,1);
                
            return memid;
        }

        public int Create(memberdetail obj)
        {
            ent = new SA39_PROJECTEntities1();
            ent.memberdetails.Add(obj);
            return (ent.SaveChanges());
        }

    }
}
