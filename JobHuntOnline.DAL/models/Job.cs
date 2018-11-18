//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace JobHuntOnline.DAL.models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Job
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Job()
        {
            this.Applications = new HashSet<Application>();
        }
    
        public System.Guid Id { get; set; }
        public string Title { get; set; }
        public Nullable<int> Category { get; set; }
        public string EmployerID { get; set; }
        public Nullable<int> LocationId { get; set; }
        public string Description { get; set; }
        public Nullable<decimal> MinSalary { get; set; }
        public Nullable<decimal> MaxSalary { get; set; }
        public Nullable<System.DateTime> Deadline { get; set; }
        public Nullable<System.DateTime> DatedAdded { get; set; }
        public Nullable<System.DateTime> LastUpdated { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Application> Applications { get; set; }
        public virtual Location Location { get; set; }
    }
}
