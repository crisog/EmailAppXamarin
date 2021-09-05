using System;
using System.Collections.Generic;
using EmailApp.Models;
using EmailApp.Services;
using EmailApp.ViewModels;
using Xamarin.Forms;

namespace EmailApp.Views
{
    public partial class EmailDetail : ContentPage
    {
        public EmailDetail()
        {
            InitializeComponent();
        }

        public EmailDetail(Email Email)
        {
            InitializeComponent();
            BindingContext = new EmailDetailViewModel(new NavigationService(), Email);
        }
    }
}
