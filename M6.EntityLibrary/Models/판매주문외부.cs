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
    
    public partial class 판매주문외부
    {
        public long 주문번호 { get; set; }
        public string 외부키 { get; set; }
        public string 구분 { get; set; }
        public Nullable<long> 업체번호 { get; set; }
        public string 주문내용 { get; set; }
        public string 결제내용 { get; set; }
    }
}
