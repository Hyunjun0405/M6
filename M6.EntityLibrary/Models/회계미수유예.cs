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
    
    public partial class 회계미수유예
    {
        public long 회계미수유예번호 { get; set; }
        public long 전표번호 { get; set; }
        public long 이월번호 { get; set; }
        public string 미수유형코드 { get; set; }
        public string 미수발생원인 { get; set; }
        public Nullable<bool> 유예승인여부 { get; set; }
        public string 유예사유 { get; set; }
        public Nullable<System.DateTime> 만료일_미수유예 { get; set; }
        public Nullable<System.DateTime> 입금예정일 { get; set; }
    }
}
