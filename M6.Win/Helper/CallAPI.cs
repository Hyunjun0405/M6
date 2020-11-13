using DevExpress.DataAccess.Native.Data;
using Newtonsoft.Json;
using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace M6.Win.Helper
{
    class CallAPI
    {
        public static async Task<HttpResponseMessage> PostBasicAsync(CommandType _commandtype, string _query)
        {
          
            Uri uri = new Uri(@"https://localhost:44341");
            HttpClient client = new HttpClient();
            client.BaseAddress = uri;
            string jsonCommandType = JsonConvert.SerializeObject(_commandtype, Formatting.Indented);
            String uriToCall = String.Format("/api/DataSet/GetData?_query={0}", _query);
            HttpResponseMessage response = await client.GetAsync(uriToCall);
            return response;
        }
        //public static async Task<HttpResponseMessage> PostBasicAsync(CommandType _commandtype, string _query)
        //{

        //    Uri uri = new Uri(@"https://localhost:44341");
        //    HttpClient client = new HttpClient();
        //    client.BaseAddress = uri;
        //    string jsonCommandType = JsonConvert.SerializeObject(_commandtype, Formatting.Indented);
        //    String uriToCall = String.Format("/api/DataSet/GetData?_query={0}", _query);
        //    HttpResponseMessage response = await client.GetAsync(uriToCall);
        //    return response;
        //}

        public static async Task<HttpResponseMessage> PostBasicAsync(object content, CancellationToken cancellationToken)
        {
            Uri uri = new Uri(@"https://localhost:44341/api/DataSet/GetData");
            using (var client = new HttpClient())
            using (var request = new HttpRequestMessage(HttpMethod.Post, uri))
            {
                var json = JsonConvert.SerializeObject(content);
                using (var stringContent = new StringContent(json, Encoding.UTF8, "application/json"))
                {
                    request.Content = stringContent;

                    using (var response = await client
                        .SendAsync(request, HttpCompletionOption.ResponseHeadersRead, cancellationToken)
                        .ConfigureAwait(false))
                    {
                        response.EnsureSuccessStatusCode();
                        return response;
                    }
                }
                
            }         
        }


        public static async Task<HttpResponseMessage> PostBasicAsync(CommandType _commandtype, string _query, System.Data.DataTable _datatable)
        {
            Uri uri = new Uri(@"https://localhost:44341");
            HttpClient client = new HttpClient();
            client.BaseAddress = uri;
            string jsonCommandType = JsonConvert.SerializeObject(_commandtype, Formatting.Indented);
            string jsonDataTable = JsonConvert.SerializeObject(_datatable, Formatting.Indented);
            String uriToCall = String.Format("/api/DataSet/GetData/{0}/{1}/", jsonCommandType, _query, jsonDataTable);
            HttpResponseMessage response = await client.PostAsync(uriToCall, null);
            return response;
        }
    }
}
