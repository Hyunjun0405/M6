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
    
    public partial class 티켓_DSR
    {
        public string 티켓번호 { get; set; }
        public string 티켓구분 { get; set; }
        public string 항공코드번호 { get; set; }
        public string 티켓번호EX { get; set; }
        public Nullable<long> 판매명세번호 { get; set; }
        public Nullable<System.DateTime> 출발일 { get; set; }
        public string PNR { get; set; }
        public string 탑승객명 { get; set; }
        public string GDS { get; set; }
        public string 발권지점코드 { get; set; }
        public Nullable<System.DateTime> 발권일 { get; set; }
        public Nullable<long> 발권자 { get; set; }
        public Nullable<bool> 국내선여부 { get; set; }
        public Nullable<bool> E티켓여부 { get; set; }
        public Nullable<bool> 자동발권여부 { get; set; }
        public long SHOWN { get; set; }
        public long DISC { get; set; }
        public long FARE { get; set; }
        public long COMM { get; set; }
        public long TAX { get; set; }
        public long CASH { get; set; }
        public long CARD { get; set; }
        public string 비고 { get; set; }
    }
}
