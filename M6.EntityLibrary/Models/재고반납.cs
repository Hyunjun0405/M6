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
    
    public partial class 재고반납
    {
        public long 재고번호 { get; set; }
        public System.DateTime 반납일시 { get; set; }
        public Nullable<short> 출발몇일전 { get; set; }
        public decimal 반납비율 { get; set; }
        public Nullable<short> 반납수량 { get; set; }
    }
}
