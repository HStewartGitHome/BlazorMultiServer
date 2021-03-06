#pragma checksum "C:\SRC\BlazorMultiServer\BlazorMultiServer\Client\Pages\ServerTest.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a056fb784b7400ef175089a1f2b1ab3dd641084d"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorMultiServer.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\SRC\BlazorMultiServer\BlazorMultiServer\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\SRC\BlazorMultiServer\BlazorMultiServer\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\SRC\BlazorMultiServer\BlazorMultiServer\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\SRC\BlazorMultiServer\BlazorMultiServer\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\SRC\BlazorMultiServer\BlazorMultiServer\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\SRC\BlazorMultiServer\BlazorMultiServer\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\SRC\BlazorMultiServer\BlazorMultiServer\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\SRC\BlazorMultiServer\BlazorMultiServer\Client\_Imports.razor"
using BlazorMultiServer.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\SRC\BlazorMultiServer\BlazorMultiServer\Client\_Imports.razor"
using BlazorMultiServer.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\SRC\BlazorMultiServer\BlazorMultiServer\Client\Pages\ServerTest.razor"
using BlazorMultiServer.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/servertest")]
    public partial class ServerTest : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Server Test Request</h1>\r\n\r\n");
            __builder.AddMarkupContent(1, "<p>This component demonstrates fetching data from the server(s).</p>\r\n\r\n\r\n");
#nullable restore
#line 10 "C:\SRC\BlazorMultiServer\BlazorMultiServer\Client\Pages\ServerTest.razor"
 if ((normalData == null) ||  (passthruData == null))
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(2, "    ");
            __builder.AddMarkupContent(3, "<p><em>Loading...</em></p>\r\n");
#nullable restore
#line 13 "C:\SRC\BlazorMultiServer\BlazorMultiServer\Client\Pages\ServerTest.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(4, "    ");
            __builder.OpenElement(5, "table");
            __builder.AddAttribute(6, "class", "table");
            __builder.AddMarkupContent(7, "\r\n        ");
            __builder.AddMarkupContent(8, "<thead>\r\n            <tr>\r\n                <th>Server</th>\r\n                <th>Client</th>\r\n                <th>Server</th>\r\n                <th>Action</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(9, "tbody");
            __builder.AddMarkupContent(10, "\r\n            ");
            __builder.OpenElement(11, "tr");
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.AddMarkupContent(13, "<td>Normal Server</td>\r\n                ");
            __builder.OpenElement(14, "td");
            __builder.AddContent(15, 
#nullable restore
#line 28 "C:\SRC\BlazorMultiServer\BlazorMultiServer\Client\Pages\ServerTest.razor"
                     normalData.ClientMessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\r\n                ");
            __builder.OpenElement(17, "td");
            __builder.AddContent(18, 
#nullable restore
#line 29 "C:\SRC\BlazorMultiServer\BlazorMultiServer\Client\Pages\ServerTest.razor"
                     normalData.ServerMessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                ");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 30 "C:\SRC\BlazorMultiServer\BlazorMultiServer\Client\Pages\ServerTest.razor"
                     normalData.ActionMessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n            ");
            __builder.OpenElement(24, "tr");
            __builder.AddMarkupContent(25, "\r\n                ");
            __builder.AddMarkupContent(26, "<td>Passthru Server</td>\r\n                ");
            __builder.OpenElement(27, "td");
            __builder.AddContent(28, 
#nullable restore
#line 34 "C:\SRC\BlazorMultiServer\BlazorMultiServer\Client\Pages\ServerTest.razor"
                     passthruData.ClientMessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                ");
            __builder.OpenElement(30, "td");
            __builder.AddContent(31, 
#nullable restore
#line 35 "C:\SRC\BlazorMultiServer\BlazorMultiServer\Client\Pages\ServerTest.razor"
                     passthruData.ServerMessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n                ");
            __builder.OpenElement(33, "td");
            __builder.AddContent(34, 
#nullable restore
#line 36 "C:\SRC\BlazorMultiServer\BlazorMultiServer\Client\Pages\ServerTest.razor"
                     passthruData.ActionMessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(35, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n            ");
            __builder.OpenElement(37, "tr");
            __builder.AddMarkupContent(38, "\r\n                ");
            __builder.AddMarkupContent(39, "<td>Passthru Weather</td>\r\n                ");
            __builder.OpenElement(40, "td");
            __builder.AddContent(41, 
#nullable restore
#line 40 "C:\SRC\BlazorMultiServer\BlazorMultiServer\Client\Pages\ServerTest.razor"
                     weatherData.ClientMessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n                ");
            __builder.OpenElement(43, "td");
            __builder.AddContent(44, 
#nullable restore
#line 41 "C:\SRC\BlazorMultiServer\BlazorMultiServer\Client\Pages\ServerTest.razor"
                     weatherData.ServerMessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(45, "\r\n                ");
            __builder.OpenElement(46, "td");
            __builder.AddContent(47, 
#nullable restore
#line 42 "C:\SRC\BlazorMultiServer\BlazorMultiServer\Client\Pages\ServerTest.razor"
                     weatherData.ActionMessage

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n");
#nullable restore
#line 46 "C:\SRC\BlazorMultiServer\BlazorMultiServer\Client\Pages\ServerTest.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 48 "C:\SRC\BlazorMultiServer\BlazorMultiServer\Client\Pages\ServerTest.razor"
       
    private ServerData normalData;
    private ServerData passthruData;
    private ServerData weatherData;

    protected override async Task OnInitializedAsync()
    {
        // initialize normal client
        normalData = await InitializeNormalClient();
        if ( normalData == null )
        {
            normalData = new ServerData();
            normalData.ServerMessage = "Primary Server is down";
            normalData.ActionMessage = "offline primary server is down";
        }
        passthruData = await InitializePassthrewClient();
        weatherData = await InitializeWeatherPassthrewClient();
    }

    private async Task<ServerData> InitializeNormalClient()
    {
        ServerData Data = null;
        try
        {
            Data = await Http.GetFromJsonAsync<ServerData>("ServerData");
        }
        catch (Exception e)
        {
            Console.Write("Exception loading Primary Server client", e);
        }
        if (Data != null)
            Data.ClientMessage = "Called to Normal Blazor Call from Normal Client";
        return Data;
    }


    private async Task<ServerData> InitializePassthrewClient()
    {
        ServerData Data = await Http.GetFromJsonAsync<ServerData>("Passthru");
        if (Data != null)
            Data.ClientMessage = "Called to Passthrough Blazor Call from Normal Client";
        return Data;
    }


    private async Task<ServerData> InitializeWeatherPassthrewClient()
    {
        WeatherForecastModel forecast = await Http.GetFromJsonAsync<WeatherForecastModel>("Weather");
        ServerData Data = new ServerData();
        Data.ClientMessage = "Called to Passthrough Blazor Call for external Json from Normal Client";
        if (forecast == null)
        {
            Data.ServerMessage = "Forecast is null";
            Data.ActionMessage = "External Passthrough";
        }
        else
        {
            Data.ServerMessage = "Forecast return from external server thru Primary Service";
            Data.ActionMessage = "External Passthrough";
        }

        return Data;
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
