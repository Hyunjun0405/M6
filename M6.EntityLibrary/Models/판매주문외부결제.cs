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
    
    public partial class 판매주문외부결제
    {
        public long 외부결제번호 { get; set; }
        public string 품목코드 { get; set; }
        public string 공급처코드 { get; set; }
        public string 항공사코드 { get; set; }
        public string 주문번호_공급처 { get; set; }
        public Nullable<long> 주문번호 { get; set; }
        public Nullable<long> 주문아이템번호 { get; set; }
        public string 카드사명 { get; set; }
        public string 승인일자 { get; set; }
        public string 승인번호 { get; set; }
        public Nullable<bool> 발권완료여부 { get; set; }
    }
}
