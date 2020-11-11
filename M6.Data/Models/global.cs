using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using M6.Data.Models;

namespace M6
{
    public static class global
    {
        public static List<기초코드> 코드리스트 { get; set; }

        static global()
        {
            코드리스트 = new List<기초코드>();
            코드리스트.Add(new 기초코드("공항", "FJR", "알푸자이라 국제공항"));
            코드리스트.Add(new 기초코드("공항", "RKT", "라스알카이마 국제공항"));
            코드리스트.Add(new 기초코드("도시", "FJR", "라스알카이마 국제공항"));
            코드리스트.Add(new 기초코드("도시", "MCT", "알푸자이라 국제공항"));
            코드리스트.Add(new 기초코드("도시", "LHE", "국제공항 국제공항"));
        }

        public static void RefreshData()
        {
            코드리스트.Clear();
            코드리스트 = new List<기초코드>();
            코드리스트.Add(new 기초코드("공항", "MCT", "알푸자이라"));
            코드리스트.Add(new 기초코드("공항", "LHE", "국제공항"));

            코드리스트.Add(new 기초코드("공항", "FJR", "알푸자이라 국제공항"));
            코드리스트.Add(new 기초코드("공항", "RKT", "라스알카이마 국제공항"));
            코드리스트.Add(new 기초코드("도시", "FJR", "라스알카이마"));

        }
        public static List<기초코드> GetList(string 종류)
        {
            try
            {
                return 코드리스트.Where(u => u.종류 == 종류).ToList();
            }
            catch (System.Exception)
            {
                return null;
            }
        }
        public static string GetCodeValue(string 종류, string 코드명)
        {
            try
            {
                return 코드리스트.FirstOrDefault(u => u.코드명 == 코드명 && u.종류 == 종류).코드.ToString();
            }
            catch (System.Exception)
            {
                return string.Empty;
            }
        }
        public static string GetCodeName(string 종류, string 코드)
        {
            try
            {
                return 코드리스트.FirstOrDefault(u => u.코드 == 코드 && u.종류 == 종류).코드명.ToString();
            }
            catch (System.Exception)
            {
                return string.Empty;
            }
        }
    }
}
