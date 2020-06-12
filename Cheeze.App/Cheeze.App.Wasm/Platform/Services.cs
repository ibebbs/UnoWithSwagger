using System;
using System.Collections.Concurrent;
using System.Net.Http;

namespace Cheeze.App.Platform
{
    public partial class Services
    {
        private class CustomHttpClientFactory : IHttpClientFactory
        {
            private readonly ConcurrentDictionary<string, HttpClient> _activeClients = new ConcurrentDictionary<string, HttpClient>();

            public HttpClient CreateClient(string name)
            {
                return _activeClients.GetOrAdd(name, _ => new HttpClient(new Uno.UI.Wasm.WasmHttpHandler()));
            }
        }

        private Type HttpClientFactory = typeof(CustomHttpClientFactory);
    }
}
