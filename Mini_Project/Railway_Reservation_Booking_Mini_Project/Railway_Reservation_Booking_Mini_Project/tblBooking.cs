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
    
    public partial class tblBooking
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblBooking()
        {
            this.tblCancellations = new HashSet<tblCancellation>();
        }
    
        public int Booking_ID { get; set; }
        public string Passenger_Name { get; set; }
        public int Train_No { get; set; }
        public string Class_Name { get; set; }
        public System.DateTime Travel_Date { get; set; }
        public int Tickets_Count { get; set; }
        public Nullable<decimal> Total_Amount { get; set; }
        public string Status { get; set; }
    
        public virtual tblTrain tblTrain { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblCancellation> tblCancellations { get; set; }
    }
}