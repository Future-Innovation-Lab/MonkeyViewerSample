using System.Windows.Input;
using Xamarin.Forms;
using XamarinMonkeyViewer.Views;

namespace XamarinMonkeyViewer.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        public ICommand ManualCommand { get; set; }
        public ICommand CarouselCommand { get; set; }

        public MainPageViewModel(INavigation navigation) : base(navigation)
        {
            ManualCommand = new Command(Manual);
            CarouselCommand = new Command(Carousel);
        }

        public void Manual()
        {
            Navigation.PushAsync(new ManualMonkeyView());
        }

        public void Carousel()
        {
            Navigation.PushAsync(new CarouselMonkeyView());
        }
    }
}
