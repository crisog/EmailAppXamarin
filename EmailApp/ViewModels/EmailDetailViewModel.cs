using System;
using EmailApp.Models;
using EmailApp.Services;

namespace EmailApp.ViewModels
{
    public class EmailDetailViewModel: BaseViewModel
    {
        public Email Email { get; set; } = new Email();

        public string From { get; set; } 

        public EmailDetailViewModel(INavigationService navigationService, Email email) : base(navigationService)
        {
            Email = email;
        }
    }
}
