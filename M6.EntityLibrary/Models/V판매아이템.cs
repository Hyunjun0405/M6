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
    
    public partial class V판매아이템
    {
        public System.DateTime 출발일 { get; set; }
        public int 주문번호 { get; set; }
        public string 서비스주체 { get; set; }
        public string 품목구분 { get; set; }
        public string 품목종류 { get; set; }
        public string 유입구분 { get; set; }
        public int 닷컴여부 { get; set; }
        public int 제로컴여부 { get; set; }
        public Nullable<long> 상품번호 { get; set; }
        public Nullable<long> 단체번호 { get; set; }
        public Nullable<long> 제휴가격번호 { get; set; }
        public int 주문아이템번호 { get; set; }
        public System.DateTime 행사시작일시 { get; set; }
        public Nullable<System.DateTime> 행사종료일시 { get; set; }
    }
}
