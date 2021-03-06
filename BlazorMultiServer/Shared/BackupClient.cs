﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace BlazorMultiServer.Shared
{
    public class BackupClient
    {
        public async Task<ServerData> GetBackupData(string strUri)
        {
            ServerData Data = null;


            try
            {
                HttpClient client = new HttpClient { BaseAddress = new Uri(strUri) };

                Trace.TraceInformation("Call Backup Server Client at " + strUri );
                Data = await client.GetFromJsonAsync<ServerData>("ServerData");
            }
            catch (Exception e)
            {
                Trace.TraceError("Exception loading Backup Server client", e);
            } 

            return Data;
        }
    }
}
