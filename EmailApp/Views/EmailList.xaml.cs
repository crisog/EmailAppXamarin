using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using EmailApp.Models;
using EmailApp.ViewModels;
using EmailApp.Services;

namespace EmailApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EmailList : ContentPage
    {
        public ObservableCollection<Email> Emails { get; set; }

        public EmailList()
        {
            InitializeComponent();
        }
        public EmailList(ObservableCollection<Email> emails)
        {
            InitializeComponent();
            BindingContext = new EmailListViewModel(new NavigationService());
        }
    }
}