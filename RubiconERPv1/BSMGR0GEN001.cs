//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RubiconERPv1
{
    using System;
    using System.Collections.Generic;
    
    public partial class BSMGR0GEN001
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BSMGR0GEN001()
        {
            this.BSMGR0BOM001 = new HashSet<BSMGR0BOM001>();
            this.BSMGR0BOMHEAD = new HashSet<BSMGR0BOMHEAD>();
            this.BSMGR0CCM001 = new HashSet<BSMGR0CCM001>();
            this.BSMGR0CCMHEAD = new HashSet<BSMGR0CCMHEAD>();
            this.BSMGR0CCMTEXT = new HashSet<BSMGR0CCMTEXT>();
            this.BSMGR0MATHEAD = new HashSet<BSMGR0MATHEAD>();
            this.BSMGR0MATTEXT = new HashSet<BSMGR0MATTEXT>();
            this.BSMGR0MAT001 = new HashSet<BSMGR0MAT001>();
            this.BSMGR0ROTHEAD = new HashSet<BSMGR0ROTHEAD>();
            this.BSMGR0ROTOPRCONTENT = new HashSet<BSMGR0ROTOPRCONTENT>();
            this.BSMGR0ROTBOMCONTENT = new HashSet<BSMGR0ROTBOMCONTENT>();
            this.BSMGR0ROT001 = new HashSet<BSMGR0ROT001>();
            this.BSMGR0ROT002 = new HashSet<BSMGR0ROT002>();
            this.BSMGR0ROT003 = new HashSet<BSMGR0ROT003>();
            this.BSMGR0WCM001 = new HashSet<BSMGR0WCM001>();
            this.BSMGR0WCMHEAD = new HashSet<BSMGR0WCMHEAD>();
            this.BSMGR0WCMOPR = new HashSet<BSMGR0WCMOPR>();
            this.BSMGR0WCMTEXT = new HashSet<BSMGR0WCMTEXT>();
        }
    
        public string COMCODE { get; set; }
        public string COMTEXT { get; set; }
        public string ADDRESS1 { get; set; }
        public string ADDRESS2 { get; set; }
        public string CITYCODE { get; set; }
        public string COUNTRYCODE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BSMGR0BOM001> BSMGR0BOM001 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BSMGR0BOMHEAD> BSMGR0BOMHEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BSMGR0CCM001> BSMGR0CCM001 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BSMGR0CCMHEAD> BSMGR0CCMHEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BSMGR0CCMTEXT> BSMGR0CCMTEXT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BSMGR0MATHEAD> BSMGR0MATHEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BSMGR0MATTEXT> BSMGR0MATTEXT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BSMGR0MAT001> BSMGR0MAT001 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BSMGR0ROTHEAD> BSMGR0ROTHEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BSMGR0ROTOPRCONTENT> BSMGR0ROTOPRCONTENT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BSMGR0ROTBOMCONTENT> BSMGR0ROTBOMCONTENT { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BSMGR0ROT001> BSMGR0ROT001 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BSMGR0ROT002> BSMGR0ROT002 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BSMGR0ROT003> BSMGR0ROT003 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BSMGR0WCM001> BSMGR0WCM001 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BSMGR0WCMHEAD> BSMGR0WCMHEAD { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BSMGR0WCMOPR> BSMGR0WCMOPR { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BSMGR0WCMTEXT> BSMGR0WCMTEXT { get; set; }
    }
}
