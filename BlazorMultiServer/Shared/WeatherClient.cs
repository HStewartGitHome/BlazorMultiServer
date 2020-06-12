using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace BlazorMultiServer.Shared
{
    public class WeatherClient
    {
        public async Task<WeatherForecastModel> GetWeatherData(string strUri)
        {
            WeatherForecastModel Data = null;


            try
            {
                HttpClient client = new HttpClient { BaseAddress = new Uri(strUri) };

                Trace.TraceInformation("Call Weather Server Client at " + strUri );
                Data = await client.GetFromJsonAsync<WeatherForecastModel>("location/2471217/");
            }
            catch (Exception e)
            {
                Trace.TraceError("Exception loading Weather Server client", e);
            }

            return Data;
        }
    }
}
