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
    
    public partial class SKTRAN
    {
        public int SKT_ID { get; set; }
        public int SKT_SKR { get; set; }
        public string SK_CODE { get; set; }
        public int SKT_STATUS { get; set; }
        public string DOC_NUM { get; set; }
        public System.DateTime DOC_DATE { get; set; }
        public string ITEMNO { get; set; }
        public string ITEMNAME { get; set; }
        public string SK_UNIT { get; set; }
        public string CURRENCY { get; set; }
        public decimal SKT_U_COST { get; set; }
        public decimal SKT_QTY { get; set; }
        public decimal SKT_TOTALCOST { get; set; }
        public decimal U_PRICE { get; set; }
        public decimal U_DISCOUNT { get; set; }
        public decimal U_NET_PRICE { get; set; }
        public decimal U_VAT { get; set; }
        public decimal TOTAL_PRICE { get; set; }
        public string CreateBy { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string UpdateBy { get; set; }
        public Nullable<System.DateTime> LastUpdate { get; set; }
    }
}
