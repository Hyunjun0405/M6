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
    
    public partial class 지상비견적세부
    {
        public long 견적번호 { get; set; }
        public long 입찰상품번호 { get; set; }
        public long 공급업체번호 { get; set; }
        public string 시즌코드 { get; set; }
        public Nullable<short> 인원시작 { get; set; }
        public Nullable<short> 인원종료 { get; set; }
        public long 공급단가 { get; set; }
    }
}
