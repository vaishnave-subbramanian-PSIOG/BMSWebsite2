//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BMSDataAccess
{
    using System;
    using System.Collections.Generic;
    
    public partial class MOVIEHALL
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public MOVIEHALL()
        {
            this.MOVIEHALLSEATs = new HashSet<MOVIEHALLSEAT>();
            this.SHOWs = new HashSet<SHOW>();
        }
    
        public int MovieHallID { get; set; }
        public decimal Price { get; set; }
        public int Capacity { get; set; }
        public string MovieHallType { get; set; }
        public int TheatreID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MOVIEHALLSEAT> MOVIEHALLSEATs { get; set; }
        public virtual THEATRECOMPLEX THEATRECOMPLEX { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SHOW> SHOWs { get; set; }
    }
}
