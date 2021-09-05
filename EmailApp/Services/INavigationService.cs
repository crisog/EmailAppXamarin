using System.Threading.Tasks;
using Xamarin.Forms;

namespace EmailApp.Services
{
    public interface INavigationService
    {
        Task NavigateAsync(Page page);
        Task NavigateBackAsync();
    }
}
