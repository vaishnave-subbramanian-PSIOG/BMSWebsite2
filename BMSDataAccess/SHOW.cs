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
    
    public partial class SHOW
    {
        public System.TimeSpan ShowTime { get; set; }
        public int MovieID { get; set; }
        public int MovieHallID { get; set; }
        public int ShowID { get; set; }
    
        public virtual MOVIE MOVIE { get; set; }
        public virtual MOVIEHALL MOVIEHALL { get; set; }
        public virtual SHOWINFO SHOWINFO { get; set; }
    }
}
