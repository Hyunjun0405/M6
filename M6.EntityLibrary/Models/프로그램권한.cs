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
    
    public partial class 프로그램권한
    {
        public int 권한번호 { get; set; }
        public int 프로그램번호 { get; set; }
        public string 오브젝트명 { get; set; }
        public string KEY1 { get; set; }
        public string VALUE1 { get; set; }
        public string KEY2 { get; set; }
        public string VALUE2 { get; set; }
        public string KEY3 { get; set; }
        public string VALUE3 { get; set; }
        public string 권한코드 { get; set; }
        public System.DateTime 시작일 { get; set; }
        public System.DateTime 종료일 { get; set; }
        public System.DateTime 저장일시 { get; set; }
        public int 저장자 { get; set; }
        public string 비고 { get; set; }
    
        public virtual 프로그램 프로그램 { get; set; }
    }
}
