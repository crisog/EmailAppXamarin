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
        public ObservableCollection<Email> Emails { get; set; } = new ObservableCollection<Email>() { };

        private Email _selectedEmail;
        public Email SelectedEmail
        {
            get { return _selectedEmail; }
            set
            {
                _selectedEmail = value;
            }
        }

        public ICommand ComposeEmailCommand { get; }
        public ICommand ItemTappedCommand { get; private set; }

        public EmailListViewModel(INavigationService navigationService) : base(navigationService)
        {
            ComposeEmailCommand = new Command<Email>(RedirectToCompose);
            ItemTappedCommand = new Command<Email>(ItemTapped);
        }

        private async void RedirectToCompose(Email email)
        {
            await NavigationService.NavigateAsync(new EmailCompose(Emails));
            SelectedEmail = null;
        }

        private async void ItemTapped(Email email)
        {
            await NavigationService.NavigateAsync(new EmailDetail(email));
            SelectedEmail = null;
        }
    }
}
