using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;

namespace fnbot.shop.Web
{
    public interface IClient : IDisposable
    {
        CookieContainer Cookies { get; }

        void SetHeader(string key, string value, bool validate = true);

        Task<Response> SendAsync(string method, string uri, IReadOnlyDictionary<string, string> reqHeaders = null, bool addBody = true);
        Task<Response> SendJsonAsync(string method, string uri, string json, IReadOnlyDictionary<string, string> reqHeaders = null, bool addBody = true);
        Task<Response> SendContentAsync(string method, string uri, HttpContent content, IReadOnlyDictionary<string, string> reqHeaders = null, bool addBody = true);
        Task<Response> SendFormAsync(string method, string uri, IReadOnlyDictionary<string, string> formParams, IReadOnlyDictionary<string, string> reqHeaders = null, bool addBody = true);
        Task<Response> SendMultipartAsync(string method, string uri, IReadOnlyDictionary<string, object> multipartParams, IReadOnlyDictionary<string, string> reqHeaders = null, bool addBody = true);
        Task<string>   GetAsync(string uri, IReadOnlyDictionary<string, string> reqHeaders = null);
    }
}
