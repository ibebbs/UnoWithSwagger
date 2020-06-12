using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

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

        private void RegisterGlobalServices(IServiceCollection services)
        {
            if (HttpClientFactory != null)
            {
                services.Add(ServiceDescriptor.Singleton(typeof(IHttpClientFactory), HttpClientFactory));
            }

            services.AddHttpClient<Store.Client.IStoreClient, Store.Client.StoreClient>(
                httpClient => httpClient.BaseAddress = new Uri("http://localhost:5000")
            );

            services.AddSingleton<ISchedulers, Schedulers>();

            services.AddTransient<ViewModel>();
        }

        public void PerformRegistration()
        {
            if (_serviceProvider.IsValueCreated) throw new InvalidOperationException("You cannot register services after the service provider has been created");

            RegisterGlobalServices(_serviceCollection);
        }

        public IServiceProvider Provider => _serviceProvider.Value;
    }
}
