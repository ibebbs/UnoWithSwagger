using System.Reactive.Concurrency;

namespace Cheeze.App.Platform
{
    public interface ISchedulers
    {
        IScheduler Default { get; }

        IScheduler Dispatcher { get; }
    }

    public partial class Schedulers
    {
    }
}
