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
    
    public partial class 상품재고입고
    {
        public long 입고번호 { get; set; }
        public long 재고번호 { get; set; }
        public Nullable<long> 공급계약번호 { get; set; }
        public string 공급방식 { get; set; }
        public Nullable<bool> 선급여부 { get; set; }
        public Nullable<short> 입고수량 { get; set; }
        public long 입고단가 { get; set; }
        public long 커미션 { get; set; }
        public Nullable<System.DateTime> 발권마감일 { get; set; }
        public string 기안내용 { get; set; }
        public string 반납조건 { get; set; }
        public string 페널티조건 { get; set; }
        public Nullable<System.DateTime> 입고일시 { get; set; }
    }
}
