//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DashboardApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order
    {
        public int ID { get; set; }
        public int UserId { get; set; }
        public int ItemId { get; set; }
        public int Units { get; set; }
    
        public virtual Item Item { get; set; }
        public virtual User User { get; set; }
    }
}
