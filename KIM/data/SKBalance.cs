//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KIM.data
{
    using System;
    using System.Collections.Generic;
    
    public partial class SKBalance
    {
        public int SKB_ID { get; set; }
        public int SKB_SKI { get; set; }
        public string SK_ITEMNO { get; set; }
        public string SK_ITEMNAME { get; set; }
        public string SKU { get; set; }
        public decimal AVAI_QTY { get; set; }
        public decimal ONHAND { get; set; }
        public decimal BOOKING { get; set; }
        public decimal ON_ORDER { get; set; }
        public System.DateTime LASTUPDATE { get; set; }
    }
}