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
    
    public partial class 여행자보험료
    {
        public long 번호 { get; set; }
        public string 보험사코드 { get; set; }
        public long 거래처번호 { get; set; }
        public System.DateTime 시작일 { get; set; }
        public System.DateTime 종료일 { get; set; }
        public Nullable<bool> 해외여부 { get; set; }
        public string 성별 { get; set; }
        public short 나이 { get; set; }
        public string 보장코드 { get; set; }
        public short 여행일수 { get; set; }
        public long 보험료단가 { get; set; }
        public long 보험료 { get; set; }
    }
}
