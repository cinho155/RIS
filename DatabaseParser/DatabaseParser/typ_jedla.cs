//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DatabaseParser
{
    using System;
    using System.Collections.Generic;
    
    public partial class typ_jedla
    {
        public typ_jedla()
        {
            this.jedlo = new HashSet<jedlo>();
        }
    
        public int id_typu { get; set; }
        public int typ { get; set; }
    
        public virtual ICollection<jedlo> jedlo { get; set; }
        public virtual text text { get; set; }
    }
}
