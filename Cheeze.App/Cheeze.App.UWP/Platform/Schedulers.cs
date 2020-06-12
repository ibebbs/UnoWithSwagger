using System;
using System.Reactive.Concurrency;
using Windows.UI.Xaml;

namespace Cheeze.App.Platform
{
    public partial class Schedulers : ISchedulers
    {
        private static readonly Lazy<IScheduler> DispatchScheduler = new Lazy<IScheduler>(() => new CoreDispatcherScheduler(Window.Current.Dispatcher));

        public IScheduler Default => Scheduler.Default;

        public IScheduler Dispatcher => DispatchScheduler.Value;
    }
}
