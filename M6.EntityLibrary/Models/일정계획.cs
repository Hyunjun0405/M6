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
    
    public partial class 일정계획
    {
        public long 일정계획번호 { get; set; }
        public long 회원번호 { get; set; }
        public string 계획명 { get; set; }
        public Nullable<System.DateTime> 여행일시작 { get; set; }
        public Nullable<System.DateTime> 여행일종료 { get; set; }
    }
}
