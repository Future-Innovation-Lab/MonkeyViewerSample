using System.Windows.Input;
using Xamarin.Forms;
using XamarinMonkeyViewer.Views;

namespace XamarinMonkeyViewer.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        private HtmlWebViewSource _html;

        public HtmlWebViewSource Html { get { return _html; } set { _html = value; OnPropertyChanged(); } }

        public ICommand ManualCommand { get; set; }
        public ICommand CarouselCommand { get; set; }

        public ICommand EditCommand { get; set; }


        public MainPageViewModel(INavigation navigation) : base(navigation)
        {
            ManualCommand = new Command(Manual);
            CarouselCommand = new Command(Carousel);
            EditCommand = new Command(Edit);
        }

        public void Manual()
        {
            var html = new HtmlWebViewSource
            {
                Html = "<html> <h>HELLO</h> </html>"
            };
            Html = html;

            //Navigation.PushAsync(new ManualMonkeyView());
        }

        public void Carousel()
        {
            Navigation.PushAsync(new CarouselMonkeyView());
        }

        public void Edit()
        {
            Navigation.PushAsync(new EditMonkeysView());
        }
    }
}
