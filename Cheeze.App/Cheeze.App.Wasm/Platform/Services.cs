using Microsoft.Extensions.Logging;
using System;
using System.Collections.Concurrent;
using System.Net.Http;

namespace Cheeze.App.Platform
{
    public partial class Services
    {
        partial void GetHttpMessageHandler(ref HttpMessageHandler handler)
        {
            handler = new Uno.UI.Wasm.WasmHttpHandler();
        }
    }
}
