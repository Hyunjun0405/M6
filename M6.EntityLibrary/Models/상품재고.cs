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
    
    public partial class 상품재고
    {
        public long 재고번호 { get; set; }
        public Nullable<long> 상품번호 { get; set; }
        public Nullable<System.DateTime> 출발일 { get; set; }
        public string 여정 { get; set; }
        public string 출국편구분 { get; set; }
        public string 귀국편구분 { get; set; }
        public System.DateTime 출발일시 { get; set; }
        public Nullable<System.DateTime> 귀국일시 { get; set; }
        public string 교통수단구분 { get; set; }
        public string 공급방식 { get; set; }
        public string 대표항공코드 { get; set; }
        public string 재고명 { get; set; }
        public long 재고원가 { get; set; }
        public long 재고원가_소아 { get; set; }
        public long 재고원가_유아 { get; set; }
        public long 성인유류세 { get; set; }
        public long 성인제세금 { get; set; }
        public long 소아유류세 { get; set; }
        public long 소아제세금 { get; set; }
        public long 유아유류세 { get; set; }
        public long 유아제세금 { get; set; }
        public Nullable<short> 총입고수량 { get; set; }
        public Nullable<short> 총모객수량 { get; set; }
        public Nullable<short> 총판매수량 { get; set; }
        public Nullable<short> 총반납수량 { get; set; }
        public Nullable<System.DateTime> 명단마감일 { get; set; }
        public Nullable<System.DateTime> 발권마감일 { get; set; }
        public Nullable<bool> 특별규정여부 { get; set; }
        public Nullable<long> 정책번호 { get; set; }
    }
}
