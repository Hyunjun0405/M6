using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M6.Data.Models
{
    public class 코드
    {
        [Key]
        public Int64? 번호 { get; set; }
        public string 테이블 { get; set; }
        public string 컬럼명 { get; set; }
        public string 코드명 { get; set; }

        //public 기초코드(string _종류, string _코드, string _코드명)
        //{
        //    this.종류 = _종류;
        //    this.코드 = _코드;
        //    this.코드명 = _코드명;
        //}
    }

    public class CODE
    {
        [Key]
        public Int64? 번호 { get; set; }
        public string 테이블 { get; set; }
        public string 컬럼명 { get; set; }
        public string 코드명 { get; set; }
    }

}
