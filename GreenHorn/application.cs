//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GreenHorn
{
    using System;
    using System.Collections.Generic;
    
    public partial class application
    {
        public int applicationId { get; set; }
        public int positionId { get; set; }
        public int candidateId { get; set; }
        public string status { get; set; }
        public System.DateTime createdAt { get; set; }
        public System.DateTime updatedAt { get; set; }
    
        public virtual candidate candidate { get; set; }
        public virtual position position { get; set; }
    }
}
