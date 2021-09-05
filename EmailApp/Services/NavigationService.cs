using System.Threading.Tasks;
using Xamarin.Forms;

namespace EmailApp.Services
{
    public class NavigationService : INavigationService
    {
        public Task NavigateAsync(Page page) => App.Current.MainPage.Navigation.PushAsync(page);
        public Task NavigateBackAsync() => App.Current.MainPage.Navigation.PopAsync();

    }
}
