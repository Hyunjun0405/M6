//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace M6.EntityLibrary.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class 인센티브견적
    {
        public long 견적번호 { get; set; }
        public long 단체번호 { get; set; }
        public long 공급업체번호 { get; set; }
        public string 통화코드 { get; set; }
        public decimal 환율 { get; set; }
        public long 공급단가 { get; set; }
        public Nullable<bool> 낙찰여부 { get; set; }
    }
}
