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
    
    public partial class 부서경로
    {
        public long 부서번호 { get; set; }
        public string 년월 { get; set; }
        public Nullable<long> 부서번호_본부 { get; set; }
        public Nullable<long> 부서번호_부문 { get; set; }
        public Nullable<long> 부서번호_부서 { get; set; }
        public Nullable<long> 부서번호_파트 { get; set; }
        public string 부서명_본부 { get; set; }
        public string 부서명_부문 { get; set; }
        public string 부서명_부서 { get; set; }
        public string 부서명_파트 { get; set; }
    }
}
