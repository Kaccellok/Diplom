using DevExpress.Mvvm;
using Landmark.Services;
using Landmark.View.Tests.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Input;

namespace Landmark.VeiwModels
{
    public class MainViewModel : BindableBase
    {
        private readonly PageNavigationService _navigation;

        public Page CurrentPage { get; set; }

        public MainViewModel(PageNavigationService navigationService)
        {
            navigationService.OnPageChanged += page => CurrentPage = page;
            navigationService.Navigate(new StartPage());
            _navigation = navigationService;
        }

        public ICommand GoBack => new DelegateCommand(() =>
        {
            _navigation.GoBack();
        }, () => _navigation.CanGoBack);
    }
}
