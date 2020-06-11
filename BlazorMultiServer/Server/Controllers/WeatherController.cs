using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using BlazorMultiServer.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;

namespace BlazorMultiServer.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class WeatherController : ControllerBase
    {
        private readonly ILogger<WeatherController> _logger;
        private readonly IConfiguration _configuration;

        public WeatherController(ILogger<WeatherController> logger,
                                 IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        [HttpGet]
        public async Task<WeatherForecastModel> Get()
        {
            WeatherForecastModel forecast = null;

            try
            {
                string strUri = _configuration.GetValue<string>("MetaAPI");
                HttpClient client = new HttpClient { BaseAddress = new Uri(strUri) };
                
                forecast = await client.GetFromJsonAsync<WeatherForecastModel>("location/2471217/");
            }
            catch(Exception e)
            {
                Console.Write("Exception loading Weather Server client", e);
            }

            return forecast;
        }
    }
}
