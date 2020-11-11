using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M6.Data
{
    class publicEnum
    {

        public enum enum상품_완납시한기준 { 주문일 = 5, 출발일 = 6 }
        public enum enum상품_좌석확정기준 { 즉시확정 = 3, 관리자확정 = 4 }
        public enum enum상품_행사날짜기준 { 날짜만 = 1, 시간까지 = 2 }
        public enum enum상품_상품종류 { IP_해외패키지 = 7, DP_국내패키지 = 8 }
        public enum enum상품_통화코드 { KRW = 9, USD = 10, YEN = 11, CHF = 12, EUR = 13, AUD = 14, CAD = 15, NZD = 16, CNY = 17, MYR = 18, GBP = 19, HKD = 20, SGD = 21, THB = 22, TWD = 23 }        
    }

}
