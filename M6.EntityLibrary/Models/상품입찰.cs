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
    
    public partial class 상품입찰
    {
        public long 입찰번호 { get; set; }
        public Nullable<System.DateTime> 견적일시작 { get; set; }
        public Nullable<System.DateTime> 견적일종료 { get; set; }
        public Nullable<System.DateTime> 행사일시작 { get; set; }
        public Nullable<System.DateTime> 행사일마지막 { get; set; }
        public Nullable<short> 출발확정최소인원 { get; set; }
        public Nullable<bool> 고정환율여부 { get; set; }
        public string 통화코드 { get; set; }
        public decimal 환율 { get; set; }
    }
}
