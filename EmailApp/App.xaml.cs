﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using EmailApp.Views;

namespace EmailApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new EmailList());
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
