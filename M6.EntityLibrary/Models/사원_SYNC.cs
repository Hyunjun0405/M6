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
    
    public partial class 사원_SYNC
    {
        public int 사원번호 { get; set; }
        public bool 권한SYNC여부 { get; set; }
        public Nullable<System.DateTime> 권한SYNC일시 { get; set; }
        public bool 결재SYNC여부 { get; set; }
        public Nullable<System.DateTime> 결재SYNC일시 { get; set; }
        public bool 알림SYNC여부 { get; set; }
        public Nullable<System.DateTime> 알림SYNC일시 { get; set; }
        public System.DateTime 저장일시 { get; set; }
        public int 저장자 { get; set; }
    }
}
