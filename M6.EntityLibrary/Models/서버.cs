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
    
    public partial class 서버
    {
        public int 서버일련번호 { get; set; }
        public string HOSTNAME { get; set; }
        public string IP { get; set; }
        public int RDP포트 { get; set; }
        public string SVC포트 { get; set; }
        public string 공인IP { get; set; }
        public string 서비스구분 { get; set; }
        public string 서버역할 { get; set; }
        public int 메인담당자 { get; set; }
        public Nullable<int> 서브담당자 { get; set; }
        public string 보안프로토콜 { get; set; }
        public bool 사용여부 { get; set; }
        public Nullable<System.DateTime> 사용시작일 { get; set; }
        public Nullable<System.DateTime> 사용종료일 { get; set; }
        public string 상세정보 { get; set; }
        public string 비고 { get; set; }
        public Nullable<int> 첨부파일번호 { get; set; }
        public string OS업데이트방식 { get; set; }
        public byte[] 상세정보LOB { get; set; }
        public byte[] 비고LOB { get; set; }
        public string OS정보 { get; set; }
    }
}
