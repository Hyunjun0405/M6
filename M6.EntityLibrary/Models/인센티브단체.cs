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
    
    public partial class 인센티브단체
    {
        public long 단체번호 { get; set; }
        public long 입찰번호 { get; set; }
        public Nullable<long> 참조번호 { get; set; }
        public string 조건코드 { get; set; }
        public Nullable<System.DateTime> 시작일시 { get; set; }
        public Nullable<System.DateTime> 종료일시 { get; set; }
        public Nullable<short> 박수 { get; set; }
        public Nullable<short> 일수 { get; set; }
        public long 희망가격 { get; set; }
        public long 견적단가 { get; set; }
        public long 낙찰가격 { get; set; }
        public long 항공원가 { get; set; }
        public long 수배원가 { get; set; }
        public long 기타원가 { get; set; }
        public string 견적상태 { get; set; }
        public Nullable<long> 담당부서 { get; set; }
        public Nullable<long> 담당사원 { get; set; }
    }
}
