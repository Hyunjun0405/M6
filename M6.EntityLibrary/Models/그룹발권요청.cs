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
    
    public partial class 그룹발권요청
    {
        public long 요청번호 { get; set; }
        public long 단체번호 { get; set; }
        public Nullable<bool> 공급연동여부 { get; set; }
        public string 항공코드 { get; set; }
        public string 요청구분 { get; set; }
        public Nullable<long> 요청자 { get; set; }
        public Nullable<System.DateTime> 요청일시 { get; set; }
        public string 비고 { get; set; }
        public string 결제수단 { get; set; }
        public string PNR_COPY { get; set; }
        public Nullable<short> 주문수량 { get; set; }
        public string 작업상태 { get; set; }
        public Nullable<long> 작업자 { get; set; }
        public Nullable<System.DateTime> 작업일시 { get; set; }
        public string PNR_항공사 { get; set; }
        public string AUTH접수번호 { get; set; }
    }
}
