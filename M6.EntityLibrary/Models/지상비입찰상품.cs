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
    
    public partial class 지상비입찰상품
    {
        public long 입찰번호 { get; set; }
        public long 상품번호 { get; set; }
        public string 조건코드 { get; set; }
        public Nullable<short> 견적기준인원 { get; set; }
        public long 기타원가 { get; set; }
        public long 원가총액 { get; set; }
        public long 지상원가 { get; set; }
        public long 지상원가_소아 { get; set; }
        public long 객실원가 { get; set; }
    }
}
