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
    
    public partial class BSMGR0BOMHEAD
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public BSMGR0BOMHEAD()
        {
            this.BSMGR0BOMCONTENT = new HashSet<BSMGR0BOMCONTENT>();
        }
    
        public string COMCODE { get; set; }
        public string BOMDOCTYPE { get; set; }
        public string BOMDOCNUM { get; set; }
        public System.DateTime BOMDOCFROM { get; set; }
        public System.DateTime BOMDOCUNTIL { get; set; }
        public string MATDOCTYPE { get; set; }
        public string MATDOCNUM { get; set; }
        public Nullable<decimal> QUANTITY { get; set; }
        public Nullable<int> ISDELETED { get; set; }
        public Nullable<int> ISPASSIVE { get; set; }
        public string DRAWNUM { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BSMGR0BOMCONTENT> BSMGR0BOMCONTENT { get; set; }
        public virtual BSMGR0GEN001 BSMGR0GEN001 { get; set; }
    }
}
