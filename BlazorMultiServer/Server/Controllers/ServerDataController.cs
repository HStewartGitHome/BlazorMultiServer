using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazorMultiServer.Shared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace BlazorMultiServer.Server.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ServerDataController : ControllerBase
    {
        private readonly ILogger<ServerDataController> logger;

        public ServerDataController(ILogger<ServerDataController> logger)
        {
            this.logger = logger;
        }

        [HttpGet]
        public async Task<ServerData> Get()
        {
            ServerData Data = new ServerData();
            Data.ClientMessage = "";  // client
            Data.ServerMessage = "Response from Primary Server";
            Data.ActionMessage = "Normal Action";

            await Task.Delay(0);
            return Data;
        }

    }
}
