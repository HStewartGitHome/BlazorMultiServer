using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BlazorMultiServer.Shared
{
    public class JSHelper
    {
        private IJSRuntime _jsRuntime{ get; set; }
        

        public  JSHelper(IJSRuntime JSRuntime)
        {
            _jsRuntime = JSRuntime;
        }
        public async Task<string>GetDataTimeString()
        {
            string result = "";
            
            try
            { 
                result = await _jsRuntime.InvokeAsync<string>("getDateTime");
            
            }
            catch( Exception e )
            {
                Trace.TraceError("Excuting javascript getDataTime", e);
            }
            
            return result;

        }
    }
}
