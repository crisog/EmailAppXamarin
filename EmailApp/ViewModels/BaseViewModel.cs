using System;
using System.ComponentModel;
using EmailApp.Services;

namespace EmailApp.ViewModels
{
    public abstract class BaseViewModel : INotifyPropertyChanged
    {
        protected BaseViewModel(INavigationService navigationService)
        {
            NavigationService = navigationService;
        }

        protected INavigationService NavigationService { get; }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
