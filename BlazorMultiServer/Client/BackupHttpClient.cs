using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BlazorMultiServer.Client
{
    public class BackupHttpClient : HttpClient
    {
        public BackupHttpClient(string uri)
        {
            BaseAddress = new Uri(uri);
        }
    }
}
