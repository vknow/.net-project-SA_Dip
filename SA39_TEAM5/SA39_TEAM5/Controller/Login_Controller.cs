using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA39_TEAM5
{

    class Login_Controller
    {
        private SA39_PROJECTEntities1 user;
        private userdetail user_ent;
        public Login_Controller()
        {

        }
        public bool CheckUser(userdetail u)
        {
            try
            {
                user = new SA39_PROJECTEntities1();
                var u_check = from n in user.userdetails
                              where n.Username == u.Username
                              select n;
                user_ent = u_check.First<userdetail>();
                if (user_ent.Password == u.Password)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch(InvalidOperationException)
            {
                return false;
            }
            catch(Exception)
            {
                return false;
            }
        }
        public string getRole(string user_name)
        {
            user = new SA39_PROJECTEntities1();
            var u_check = from n in user.userdetails
                          where n.Username == user_name
                          select n.Role;
             string str = u_check.First();
            return (str);
        }
    }
}
