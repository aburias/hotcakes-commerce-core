//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Hotcakes.Commerce.Data.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class hcc_SearchObject
    {
        public hcc_SearchObject()
        {
            this.hcc_SearchObjectWords = new HashSet<hcc_SearchObjectWord>();
        }
    
        public long Id { get; set; }
        public int ObjectType { get; set; }
        public System.Guid ObjectId { get; set; }
        public string Title { get; set; }
        public long SiteId { get; set; }
        public System.DateTime LastIndexUtc { get; set; }
    
        public virtual ICollection<hcc_SearchObjectWord> hcc_SearchObjectWords { get; set; }
    }
}
