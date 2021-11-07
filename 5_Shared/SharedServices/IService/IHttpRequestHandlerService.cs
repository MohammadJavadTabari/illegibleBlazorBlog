﻿using System.Net.Http;
using System.Threading.Tasks;

namespace illegible.Shared.SharedServices.IService
{
    // you can see complete docs on HttpRequestHandlerService class
    public interface IHttpRequestHandlerService
    {
        Task<HttpResponseMessage> PostAsHttpJsonAsync(object DTO ,string uriAddress);
        Task<TDTO> GetAsHttpAsync<TDTO>(string uriAddress);
    }
}