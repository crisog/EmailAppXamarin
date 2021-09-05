using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using EmailApp.Models;
using EmailApp.Services;
using EmailApp.ViewModels;
using Xamarin.Forms;

namespace EmailApp.Views
{
    public partial class EmailCompose : ContentPage
    {
        public EmailCompose()
        {
            InitializeComponent();
        }

        public EmailCompose(ObservableCollection<Email> Emails)
        {
            InitializeComponent();
            BindingContext = new EmailComposeViewModel(new NavigationService(), Emails);
        }
    }
}
