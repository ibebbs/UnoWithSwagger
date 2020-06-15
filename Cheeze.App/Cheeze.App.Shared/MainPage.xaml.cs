using Microsoft.Extensions.DependencyInjection;
using System;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

namespace Cheeze.App
{
    public sealed partial class MainPage : Page
    {
        private readonly ViewModel _viewModel;
        private IDisposable _behaviours;

        public MainPage()
        {
            this.InitializeComponent();

            _viewModel = Platform.Services.Instance.Provider.GetRequiredService<ViewModel>();
            DataContext = _viewModel;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            _behaviours = _viewModel.Activate();
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            base.OnNavigatedFrom(e);

            if (_behaviours != null)
            {
                _behaviours.Dispose();
                _behaviours = null;
            }
        }
    }
}
