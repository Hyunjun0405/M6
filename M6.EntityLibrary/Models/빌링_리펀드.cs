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
    
    public partial class 빌링_리펀드
    {
        public string 티켓번호 { get; set; }
        public string 리펀드번호 { get; set; }
        public string 항공코드번호 { get; set; }
        public string 발권지점번호 { get; set; }
        public string 발권지점코드 { get; set; }
        public Nullable<System.DateTime> 빌링일 { get; set; }
        public string TERM { get; set; }
        public Nullable<long> 담당사원 { get; set; }
        public long FARE { get; set; }
        public long PENALTY { get; set; }
        public long COMM { get; set; }
        public long TAX { get; set; }
        public long CASH { get; set; }
        public long CARD { get; set; }
        public string 반영방식 { get; set; }
        public Nullable<long> 판매명세번호 { get; set; }
        public long 수납액 { get; set; }
        public long 공급가액 { get; set; }
        public long 부가세액 { get; set; }
        public Nullable<long> 분개번호 { get; set; }
        public string 비고 { get; set; }
    }
}
