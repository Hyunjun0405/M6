using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace M6.Data.Models
{
    [Table("개체")]
    public class 개체
    {
        [Key]
        public int 개체번호 { get; set; }
        [MaxLength(6)]
        public string 개체구분 { get; set; }
        [MaxLength(100)]
        public string 개체명 { get; set; }
        [MaxLength(100)]
        public string 한글성명 { get; set; }
        [MaxLength(100)]
        public string 영문성명 { get; set; }
        [MaxLength(100)]
        public string 별칭 { get; set; }
        [MaxLength(200)]
        public string 대표연락처 { get; set; }
        [MaxLength(100)]
        public string 이메일 { get; set; }
        [MaxLength(20)]
        public string 전화 { get; set; }
        [MaxLength(200)]
        public string 주소 { get; set; }
    }

    [Table("공항")]
    public class 공항
    {
        [Key]
        [MaxLength(3)]
        public string 공항코드 { get; set; }
        [MaxLength(2)]
        public string 국가코드 { get; set; }
        [MaxLength(5)]
        public string 도시코드 { get; set; }
        [MaxLength(100)]
        public string 공항명 { get; set; }
        [MaxLength(100)]
        public string 한글명 { get; set; }
        [MaxLength(100)]
        public string 영문명 { get; set; }
        public double? 위도 { get; set; }
        public double? 경도 { get; set; }
        [MaxLength(200)]
        public string 홈페이지 { get; set; }
        public short? 타임존 { get; set; }
    }



}
