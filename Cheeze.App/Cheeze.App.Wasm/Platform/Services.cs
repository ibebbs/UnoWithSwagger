using Microsoft.Extensions.Logging;
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

            private readonly ILogger<CustomHttpClientFactory> _logger;

            public CustomHttpClientFactory()
            {
                _logger = global::Uno.Extensions.LogExtensionPoint.AmbientLoggerFactory.CreateLogger<CustomHttpClientFactory>();
                _logger.LogInformation("Using CustomHttpClientFactory");
            }
            public HttpClient CreateClient(string name)
            {
                _logger.LogInformation($"Creating HttpClient named '{name}'");

                return _activeClients.GetOrAdd(name, _ => new HttpClient(new Uno.UI.Wasm.WasmHttpHandler()) { BaseAddress = new Uri("http://localhost:5000") } );
            }
        }

        private Type HttpClientFactory = typeof(CustomHttpClientFactory);
    }
}
