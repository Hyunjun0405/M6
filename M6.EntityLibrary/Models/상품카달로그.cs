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
    
    public partial class 상품카달로그
    {
        public long 카달로그번호 { get; set; }
        public Nullable<long> 상위번호 { get; set; }
        public string 카달로그명 { get; set; }
        public Nullable<short> 단계 { get; set; }
        public string 상위경로 { get; set; }
        public string 경로 { get; set; }
        public string 경로명 { get; set; }
        public Nullable<long> 참조번호 { get; set; }
        public Nullable<short> 정렬 { get; set; }
        public Nullable<bool> 서브메인 { get; set; }
        public Nullable<bool> 노출여부 { get; set; }
        public Nullable<short> 노드레벨 { get; set; }
    }
}
