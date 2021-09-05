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

        public ICommand ComposeEmailCommand { get; }

        public EmailListViewModel(INavigationService navigationService) : base(navigationService)
        {

            Emails.Add(new Email("cris@gmail.com", "joe@gmail.com", "testing", "testing", "1231231231"));
            
            ComposeEmailCommand = new Command<Email>(RedirectToCompose);
        }

        private async void RedirectToCompose(Email email)
        {
            await NavigationService.NavigateAsync(new EmailCompose(Emails));
        }
    }
}
