//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WcfDataService
{
    using System;
    using System.Collections.Generic;
    
    public partial class BuyingGroup
    {
        public BuyingGroup()
        {
            this.Customers = new HashSet<Customer>();
            this.SpecialDeals = new HashSet<SpecialDeal>();
        }
    
        public int BuyingGroupID { get; set; }
        public string BuyingGroupName { get; set; }
        public int LastEditedBy { get; set; }
        public System.DateTime ValidFrom { get; set; }
        public System.DateTime ValidTo { get; set; }
    
        public virtual Person Person { get; set; }
        public virtual ICollection<Customer> Customers { get; set; }
        public virtual ICollection<SpecialDeal> SpecialDeals { get; set; }
    }
}
