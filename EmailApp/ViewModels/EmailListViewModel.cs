using System.Collections.ObjectModel;
using System.Windows.Input;
using EmailApp.Models;
using EmailApp.Services;
using EmailApp.Views;
using Xamarin.Forms;

namespace EmailApp.ViewModels
{
    
    public class EmailListViewModel : BaseViewModel
    {
        private ObservableCollection<Email> _emails;

        public ICommand ComposeEmailCommand { get; }

        public EmailListViewModel(INavigationService navigationService) : base(navigationService)
        {
            ComposeEmailCommand = new Command<Email>(RedirectToCompose);
        }

        private async void RedirectToCompose(Email email)
        {
            await NavigationService.NavigateAsync(new EmailCompose(_emails));
        }
    }
}
