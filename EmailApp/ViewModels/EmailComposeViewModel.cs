using System;
using System.Collections.ObjectModel;
using EmailApp.Models;
using EmailApp.Services;

namespace EmailApp.ViewModels
{
    public class EmailComposeViewModel: BaseViewModel
    {
        private ObservableCollection<Email> _emails;

        public EmailComposeViewModel(INavigationService navigationService, ObservableCollection<Email> Emails) : base(navigationService)
        {
            _emails = Emails;
        }

    }
}
