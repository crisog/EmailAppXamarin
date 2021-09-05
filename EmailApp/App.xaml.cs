using System;
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

            MainPage = new NavigationPage(new HomePage()) {
                Title = "EmailApp",
                BarBackgroundColor = Color.FromHex("#DB4437"),
                BarTextColor = Color.White,
            };
            
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
