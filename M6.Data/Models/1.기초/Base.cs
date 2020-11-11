using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M6.Data.Models
{
    public class 기초코드
    {
        public string 종류 { get; set; }
        public string 코드 { get; set; }
        public string 코드명 { get; set; }

        public 기초코드(string _종류, string _코드, string _코드명)
        {
            this.종류 = _종류;
            this.코드 = _코드;
            this.코드명 = _코드명;
        }

      

    }

    
}
