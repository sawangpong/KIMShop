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
    
    public partial class SysProfile
    {
        public int ProfineId { get; set; }
        public string CompanyCode { get; set; }
        public string CompanyName { get; set; }
        public string Address { get; set; }
        public string TelFax { get; set; }
        public string Country { get; set; }
        public string ContactName { get; set; }
        public string DefaultLangCode { get; set; }
        public string ServerName { get; set; }
        public string DatabaseName { get; set; }
        public string DBAdmin { get; set; }
        public string DBAdminPassword { get; set; }
        public string ImageLocation { get; set; }
        public string HomeCurrency { get; set; }
        public string SourceCurrency { get; set; }
        public string TaxID { get; set; }
        public decimal VATRate { get; set; }
        public decimal ProfitMarkupRate { get; set; }
        public string DefaultWeightUOM { get; set; }
        public string DefaultWH { get; set; }
        public bool AllowNagativeInventory { get; set; }
        public decimal CreditLimit { get; set; }
        public int CreditDuration { get; set; }
        public string PaymentTerm { get; set; }
    }
}
