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
    
    public partial class 선급계약
    {
        public long 선급번호 { get; set; }
        public string 품목구분 { get; set; }
        public Nullable<bool> 인센티브여부 { get; set; }
        public string 계약명 { get; set; }
        public Nullable<System.DateTime> 시작일 { get; set; }
        public Nullable<System.DateTime> 종료일 { get; set; }
        public Nullable<long> 공급업체번호 { get; set; }
        public string 공급방식 { get; set; }
        public long 공급총액 { get; set; }
        public Nullable<short> 공급총수량 { get; set; }
        public Nullable<bool> 선급여부 { get; set; }
        public long 선급총액 { get; set; }
        public long 선급대체총액 { get; set; }
        public string 지불방식 { get; set; }
        public string 허들기준 { get; set; }
        public decimal 허들비율 { get; set; }
        public string 부과기준 { get; set; }
        public decimal 부과비율 { get; set; }
        public string 단가내역 { get; set; }
        public string 계약내용 { get; set; }
    }
}
