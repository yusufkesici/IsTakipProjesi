//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace garantiTakip
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_hizmetturu
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_hizmetturu()
        {
            this.tbl_cari = new HashSet<tbl_cari>();
        }
    
        public int IND { get; set; }
        public Nullable<int> FIRMANO { get; set; }
        public string HIZMETTURU { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_cari> tbl_cari { get; set; }
    }
}
