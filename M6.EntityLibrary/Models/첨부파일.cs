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
    
    public partial class 첨부파일
    {
        public int 파일번호 { get; set; }
        public string 파일명 { get; set; }
        public string 서버경로 { get; set; }
        public string 첨부경로 { get; set; }
        public bool 암호화여부 { get; set; }
        public System.DateTime 등록일시 { get; set; }
        public int 등록자 { get; set; }
    }
}
