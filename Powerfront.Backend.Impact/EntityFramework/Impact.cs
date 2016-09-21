//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Powerfront.Backend.Impact.EntityFramework
{
    using System;
    using System.Collections.Generic;
    
    public partial class Impact
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Impact()
        {
            this.BeneficiaryGroups = new HashSet<BeneficiaryGroup>();
        }
    
        public System.Guid ImpactId { get; set; }
        public string Other { get; set; }
        public string Notes { get; set; }
        public System.DateTime StartDate { get; set; }
        public System.DateTime FinishDate { get; set; }
        public string ImpactName { get; set; }
        public Nullable<System.Guid> BeneficiaryGroupId { get; set; }
    
        public virtual BeneficiaryGroup BeneficiaryGroup { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BeneficiaryGroup> BeneficiaryGroups { get; set; }
    }
}