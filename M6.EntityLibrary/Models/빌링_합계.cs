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
    
    public partial class 빌링_합계
    {
        public string 항공코드번호 { get; set; }
        public Nullable<System.DateTime> 빌링일 { get; set; }
        public string TERM { get; set; }
        public string 발권지점번호 { get; set; }
        public string 발권지점코드 { get; set; }
        public long FARE { get; set; }
        public long DISC { get; set; }
        public long CASH_발권 { get; set; }
        public long CARD_발권 { get; set; }
        public long CASH_환불 { get; set; }
        public long CARD_환불 { get; set; }
        public long ADM { get; set; }
        public long ACM { get; set; }
        public long COMM { get; set; }
        public long VAT { get; set; }
        public long 송금액 { get; set; }
        public Nullable<long> 분개번호 { get; set; }
        public string 비고 { get; set; }
    }
}
