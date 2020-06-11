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
    public class PassthruController : ControllerBase
    {
        private readonly ILogger<PassthruController> _logger;
        private readonly IConfiguration _configuration;

        public PassthruController(ILogger<PassthruController> logger,
                                  IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        [HttpGet]
        public async Task<ServerData> Get()
        {
            ServerData Data = await GetBackupData();
            if (Data == null)
            {
                Data = new ServerData();
                Data.ClientMessage = "";  // client
                Data.ServerMessage = "Fail to Get Data from Passthrough Server";
                Data.ActionMessage = "Passthrough Action";

            }
            return Data;
        }

        public async Task<ServerData> GetBackupData()
        {
            ServerData Data = null;


            try
            {
                string strUri = _configuration.GetValue<string>("BackupAPI");
                BackupClient client = new BackupClient();
                Data = await client.GetBackupData(strUri);
                if (Data != null)
                    Data.ActionMessage = "Passthrough Action";


            }
            catch (Exception e)
            { 
                Console.Write("Exception loading Backup Server client", e);
            }

            return Data;
        }
    }
}
