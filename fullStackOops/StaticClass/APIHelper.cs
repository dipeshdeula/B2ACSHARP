using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace fullStackOops.StaticClass
{
    public static class APIHelper
    {
        private static readonly HttpClient _httpClient = new HttpClient();

        public static async Task <string>GetApiResponseAsync(string endpoint)
        { 
            var response = await _httpClient.GetStringAsync(endpoint);
            return response;
        }
    }
}
