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
    
    public partial class Jobs_Types
    {
        public int Id { get; set; }
        public Nullable<System.Guid> JobId { get; set; }
        public string JobType { get; set; }
    
        public virtual JobType JobType1 { get; set; }
    }
}
