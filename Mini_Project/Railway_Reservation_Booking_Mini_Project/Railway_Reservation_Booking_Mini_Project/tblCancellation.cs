//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Railway_Reservation_Booking_Mini_Project
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblCancellation
    {
        public int Cancellation_ID { get; set; }
        public Nullable<int> Booking_ID { get; set; }
        public string Passenger_Name { get; set; }
        public Nullable<int> Train_No { get; set; }
        public string Class_Name { get; set; }
        public Nullable<int> Tickets_Count { get; set; }
        public Nullable<System.DateTime> DateOf_Cancel { get; set; }
    
        public virtual tblBooking tblBooking { get; set; }
        public virtual tblTrain tblTrain { get; set; }
    }
}
