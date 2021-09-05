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
        public ICommand DeleteCommand { get; }
        public ICommand ItemTappedCommand { get; private set; }

        public EmailListViewModel(INavigationService navigationService) : base(navigationService)
        {
            // Uncomment this line to have an email after loading.
            //Emails.Add(new Email("cris@gmail.com", "joe@gmail.com", "testing", "This is an awesome email. Nobody is going to know what we are talking about. I'm glad about that!", 1630818389));
            ComposeEmailCommand = new Command<Email>(RedirectToCompose);
            ItemTappedCommand = new Command<Email>(ItemTapped);
            DeleteCommand = new Command<Email>(DeleteEmail);
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

        private void DeleteEmail(Email email)
        {
            Emails.Remove(email);
            Xamarin.Essentials.Preferences.Clear();
        }
    }
}
