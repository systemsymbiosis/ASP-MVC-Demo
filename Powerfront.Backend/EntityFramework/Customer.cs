//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Powerfront.Backend.EntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class Customer
    {
        public string TypeId { get; set; }
        public string PropertyId { get; set; }
        public string Value { get; set; }
        public string CustomerId { get; set; }
    
        public virtual Property Property { get; set; }
        public virtual Type Type { get; set; }
    }
}
