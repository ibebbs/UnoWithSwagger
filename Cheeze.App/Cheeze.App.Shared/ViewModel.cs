using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reactive.Disposables;
using System.Reactive.Linq;
using System.Windows.Input;

namespace Cheeze.App
{
    public class ViewModel : INotifyPropertyChanged
    {
        private readonly Store.Client.IStoreClient _storeClient;
        private readonly Platform.ISchedulers _schedulers;
        private readonly ILogger<ViewModel> _logger;
        private readonly MVx.Observable.Command _loadCheese;
        private readonly MVx.Observable.Property<IEnumerable<Store.Client.Cheese>> _cheeses;

        public event PropertyChangedEventHandler PropertyChanged;

        public ViewModel(Store.Client.IStoreClient storeClient, Platform.ISchedulers schedulers)
        {
            _storeClient = storeClient;
            _schedulers = schedulers;

            _logger = global::Uno.Extensions.LogExtensionPoint.AmbientLoggerFactory.CreateLogger<ViewModel>();

            _loadCheese = new MVx.Observable.Command(true);
            _cheeses = new MVx.Observable.Property<IEnumerable<Store.Client.Cheese>>(Enumerable.Empty<Store.Client.Cheese>(), nameof(Cheeses), args => PropertyChanged?.Invoke(this, args));
        }

        private IDisposable ShouldLoadCheeseWhenLoadCheeseInvoked()
        {
            return _loadCheese
                .Do(_ => _logger.LogInformation("Loading Cheeses!"))
                .SelectMany(_ => _storeClient.GetAsync())
                .ObserveOn(_schedulers.Dispatcher)
                .Subscribe(_cheeses);
        }

        public IDisposable Activate()
        {
            return new CompositeDisposable(
                ShouldLoadCheeseWhenLoadCheeseInvoked()
            );
        }

        public ICommand LoadCheese => _loadCheese;

        public IEnumerable<Store.Client.Cheese> Cheeses => _cheeses.Get();
    }
}
