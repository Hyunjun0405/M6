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
    
    public partial class 판매명세
    {
        public long 판매명세번호 { get; set; }
        public Nullable<long> 주문번호 { get; set; }
        public Nullable<long> 판매번호 { get; set; }
        public string 고객구분 { get; set; }
        public Nullable<long> 회원번호 { get; set; }
        public string 한글성명 { get; set; }
        public string 성별 { get; set; }
        public Nullable<short> 출생년도 { get; set; }
        public string 영문성명 { get; set; }
        public string 영문성 { get; set; }
        public string 영문이름 { get; set; }
        public string 영문호칭 { get; set; }
        public Nullable<System.DateTime> 영문변경일 { get; set; }
        public string 객실번호 { get; set; }
        public long 입금가 { get; set; }
        public string 판매종류 { get; set; }
        public string 가격구분 { get; set; }
        public string 연령구분 { get; set; }
        public Nullable<short> 수량 { get; set; }
        public long 상품가격 { get; set; }
        public long 할인총액 { get; set; }
        public long 판매가격 { get; set; }
        public long 추가요금 { get; set; }
        public long 유류세 { get; set; }
        public long 제세금 { get; set; }
        public long 서비스총액 { get; set; }
        public long 수수료총액 { get; set; }
        public long 기타요금 { get; set; }
        public long 커미션 { get; set; }
        public Nullable<bool> 제로컴여부 { get; set; }
        public Nullable<bool> 총액여부 { get; set; }
        public Nullable<bool> 계산서여부 { get; set; }
        public decimal 총커미션율 { get; set; }
        public decimal 판매커미션율 { get; set; }
        public decimal 제휴커미션율 { get; set; }
        public long 판매커미션 { get; set; }
        public long 제휴커미션 { get; set; }
        public long 총액커미션 { get; set; }
        public long 기타커미션 { get; set; }
        public long 부가세액 { get; set; }
        public long 원천세액 { get; set; }
        public Nullable<bool> 취소여부 { get; set; }
        public Nullable<System.DateTime> 변경일 { get; set; }
    }
}
