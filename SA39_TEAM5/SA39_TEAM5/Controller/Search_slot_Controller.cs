using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace SA39_TEAM5
{
    class Search_slot_Controller
    {
        SA39_PROJECTEntities1 context;
        //facilitydetail fac_d;
        public List<string>getAllFacilityID(string fac_name)
        {
            context = new SA39_PROJECTEntities1();
            List<string> l = new List<string>();
            var q = from n in context.facilitydetails
                    where n.Facility_name==fac_name
                    select n.Facility_id;
            l = q.ToList();
            return l;
        }
        public List<KeyValuePair<string,string>> get_avail_Slot(string date , string fac_name)
        {
            //SELECT FACILITYID AND TIME FROM BOOKING TABLE AND
            //SAVING AS PAIRS
            //SO THAT VALUE PRESENT IN PAIRS ARE MARKED AS RED BUTTONS

            List<KeyValuePair<string, string>> l = new List<KeyValuePair<string,string>>();
            SqlConnection con = new SqlConnection(@"data source =(local);Integrated security=sspi;initial catalog=SA39_project");
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "select booking_time,facility_id from BookingDetails where  Booking_Date='" + date + "' and Facility_ID in (select Facility_ID from FacilityDetails where Facility_Name='" + fac_name + "')";
            cmd.Connection = con;
            con.Open();
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.HasRows)
            {
                while (rd.Read())
                {
                    l.Add(new KeyValuePair<string, string>(rd[1].ToString().Trim(), rd[0].ToString()));

                }
            }
            con.Close();
            return l;
        }
        public List<DateTime> getStartDate(string facilityid)
        {
            var q = from n in context.maintainancedetails
                    where n.facility_id == facilityid
                    select n.startdate;
                return ((List<DateTime>)q.ToList());
        }
        public List<DateTime> getEndDate(string facilityid)
        {
            var q = from n in context.maintainancedetails
                    where n.facility_id == facilityid
                    select n.enddate;

            return ((List<DateTime>)q.ToList());
        }
    }
}
