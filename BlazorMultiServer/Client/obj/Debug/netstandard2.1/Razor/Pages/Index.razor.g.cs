#pragma checksum "C:\SRC\BlazorMultiServer\BlazorMultiServer\Client\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "24f026a53cced632220cf237ba484b6061606e6a"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Hello, This test multiple servers</h1>\r\n\r\nThis sample is designed to test connections to different server conditions \r\n");
            __builder.AddMarkupContent(1, "<p> </p>\r\n\r\n");
            __builder.AddMarkupContent(2, "<p>___1.  Simple normal Blazor WebAssembly  ASP.Core Server </p>\r\n");
            __builder.AddMarkupContent(3, "<p>___2.  Web Assembly Connected with external service connected thru ASP Server</p>\r\n");
            __builder.AddMarkupContent(4, "<p>___3.  Web Assembly Connected with clone ASP Server connected thru ASP Server</p>\r\n");
            __builder.AddMarkupContent(5, "<p> </p>\r\n");
            __builder.AddMarkupContent(6, "<p>These unfortunately have technical issues with WebAssembly not able to connected to other API\'s</p>\r\n");
            __builder.AddMarkupContent(7, "<p> </p>\r\n");
            __builder.AddMarkupContent(8, "<p>___4. Web Assembly connected to clone ASP Server though client</p>\r\n");
            __builder.AddMarkupContent(9, "<p>___5. Redundant service if primary server is done go to backup</p>\r\n");
            __builder.AddMarkupContent(10, "<p> </p>\r\n\r\n\r\n");
            __builder.AddMarkupContent(11, "<p> The following steps were use to create this example</p>\r\n");
            __builder.AddMarkupContent(12, "<p> </p>\r\n\r\n");
            __builder.AddMarkupContent(13, "<p>___1.  Build Sample Blazor WebAssembly App with ASP.Core Hoot on </p>\r\n");
            __builder.AddMarkupContent(14, "<p>___2.  Add simple API request and page for testing purposes</p>\r\n");
            __builder.AddMarkupContent(15, "<p>___3.  Clone Server component for new Server with different ports</p>\r\n");
            __builder.AddMarkupContent(16, "<p>___4.  Update clone so it is different and update client to call it</p>\r\n");
            __builder.AddMarkupContent(17, "<p>___5.  Seperate the Passthru server calls from Client calls because of client issue</p>\r\n");
            __builder.AddMarkupContent(18, "<p>___6.  Add External Json API as part of the test for Passthru</p>\r\n");
            __builder.AddMarkupContent(19, "<p> </p>\r\n\r\n\r\n");
            __builder.AddMarkupContent(20, "<p>\r\n   Technical issues with executing client. This example uses clone of ASP server\r\n   But running on Port 5002 and 5003. \r\n</p>\r\n");
            __builder.AddMarkupContent(21, "<p>\r\n   But when HtmlClient makes call get Json  from the server the connection\r\n   is refused and does not function. \r\n</p>\r\n");
            __builder.AddMarkupContent(22, "<p>\r\n   This logic is the same logic used in the Passthru logic in server and that functions.\r\n   The clienttest option on menu demostrates this problem.\r\n</p>");
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591