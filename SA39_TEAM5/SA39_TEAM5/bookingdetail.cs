//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SA39_TEAM5
{
    using System;
    using System.Collections.Generic;
    
    public partial class bookingdetail
    {
        public int Booking_id { get; set; }
        public string Member_id { get; set; }
        public string Facility_id { get; set; }
        public System.DateTime Booking_date { get; set; }
        public string Booking_time { get; set; }
    
        public virtual facilitydetail facilitydetail { get; set; }
        public virtual memberdetail memberdetail { get; set; }
    }
}
