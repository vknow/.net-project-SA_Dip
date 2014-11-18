using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SA39_TEAM5
{
    class Cancel_Booking_Controller
    {
        SA39_PROJECTEntities1 context;
        public void ComboBoxFill(Cancel_Booking d, System.Windows.Forms.ComboBox id, System.Windows.Forms.ComboBox name)
        {
            Cancel_Booking th = d;
            context = new SA39_PROJECTEntities1();

            var query = from cust in context.memberdetails
                        select cust;
            id.Items.Add("");
            foreach (memberdetail i in query.ToList())
            {
                id.Items.Add(i.Member_id);
                name.Items.Add(i.Member_name);
            }
        }

        public IEnumerable<object> getByID(string id,System.Windows.Forms.ComboBox b)
        {
            
            var query = from trans in context.bookingdetails
                        where trans.Member_id == id
                        select new{ trans.Booking_id,trans.Member_id,trans.Facility_id,trans.Booking_date,trans.Booking_time};
            memberdetail c = context.memberdetails.First(x => x.Member_id == id);
            b.Text = c.Member_name;
            return (query.ToList());
            
        }
        public  IEnumerable<object> getByName(string name)
        {
                var oq = from o in context.bookingdetails
                         where o.memberdetail.Member_name == name
                         select new { o.Booking_id, o.Member_id, o.Facility_id, o.Booking_date, o.Booking_time }; 
            return (oq.ToList());

        }
    }
}
