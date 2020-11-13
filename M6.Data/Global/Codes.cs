using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using M6.Data.Models;

namespace M6.Data.Global
{
    public static class CodeList
    {
        public static List<CODE> codelist { get; set; }

        static CodeList()
        {          
        }

        public static void RefreshData()
        {
            //코드리스트.Clear();
            //코드리스트 = new List<기초코드>();
            //코드리스트.Add(new 기초코드("공항", "MCT", "알푸자이라"));
            //코드리스트.Add(new 기초코드("공항", "LHE", "국제공항"));

            //코드리스트.Add(new 기초코드("공항", "FJR", "알푸자이라 국제공항"));
            //코드리스트.Add(new 기초코드("공항", "RKT", "라스알카이마 국제공항"));
            //코드리스트.Add(new 기초코드("도시", "FJR", "라스알카이마"));

        }
        public static List<CODE> GetList(string 컬럼명)
        {
            try
            {
                return codelist.Where(u => u.컬럼명 == 컬럼명).ToList();
            }
            catch (System.Exception)
            {
                return null;
            }
        }
        public static string GetCodeValue(string 컬럼명, string 코드명)
        {
            try
            {
                return codelist.FirstOrDefault(u => u.코드명 == 코드명 && u.컬럼명 == 컬럼명).번호.ToString();
            }
            catch (System.Exception)
            {
                return string.Empty;
            }
        }
        public static string GetCodeName(string 컬럼명, int 번호)
        {
            try
            {
                return codelist.FirstOrDefault(c => c.번호 == 번호).코드명.ToString();
            }
            catch (System.Exception)
            {
                return string.Empty;
            }
        }
    }
}
