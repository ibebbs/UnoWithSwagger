using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using Uno.Extensions;

namespace Cheeze.App.Platform
{
    public partial class Services
    {
        public static readonly Services Service = new Services();

        private readonly ServiceCollection _serviceCollection;
        private readonly Lazy<IServiceProvider> _serviceProvider;

        private Services()
        {
            _serviceCollection = new ServiceCollection();
            _serviceProvider = new Lazy<IServiceProvider>(() => _serviceCollection.BuildServiceProvider());
        }

        private void RegisterGlobalServices(IServiceCollection services, ILogger logger)
        {
            services
                .AddHttpClient<Store.Client.IStoreClient, Store.Client.StoreClient>(
                    httpClient => httpClient.BaseAddress = GetBaseAddress())
                .ConfigurePrimaryHttpMessageHandler(PrimaryHttpMessageHandler);

            services.AddSingleton<ISchedulers, Schedulers>();

            services.AddTransient<ViewModel>();
        }

        partial void GetHttpMessageHandler(ref HttpMessageHandler handler);

        partial void GetBaseAddress(ref Uri uri);

        private Uri GetBaseAddress()
        {
            Uri uri = null;

            GetBaseAddress(ref uri);

            uri ??= new Uri("http://localhost:5000");

            return uri;
        }

        private HttpMessageHandler PrimaryHttpMessageHandler()
        {
            HttpMessageHandler handler = null;

            GetHttpMessageHandler(ref handler);

            handler ??= new HttpClientHandler();

            return handler;
        }

        public void PerformRegistration(ILogger logger)
        {
            if (_serviceProvider.IsValueCreated) throw new InvalidOperationException("You cannot register services after the service provider has been created");

            RegisterGlobalServices(_serviceCollection, logger);
        }

        public IServiceProvider Provider => _serviceProvider.Value;
    }
}
