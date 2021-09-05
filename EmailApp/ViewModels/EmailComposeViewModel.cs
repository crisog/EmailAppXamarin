using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Windows.Input;
using EmailApp.Models;
using EmailApp.Services;
using Xamarin.Forms;

namespace EmailApp.ViewModels
{
    public class EmailComposeViewModel: BaseViewModel
    {
        private ObservableCollection<Email> _emails;

        public Email ComposeEmail { get; set; } = new Email();
        public ICommand SaveCommand { get; }

        public EmailComposeViewModel(INavigationService navigationService, ObservableCollection<Email> Emails) : base(navigationService)
        {
            _emails = Emails;
            SaveCommand = new Command(SaveEmail);
        }

        private async void SaveEmail()
        {
            Console.WriteLine(ComposeEmail.From);
            _emails.Add(new Email(ComposeEmail.From, ComposeEmail.To, ComposeEmail.Subject, ComposeEmail.Body, DateTimeOffset.Now.ToUnixTimeSeconds()));
            await NavigationService.NavigateBackAsync();
        }

    }
}
