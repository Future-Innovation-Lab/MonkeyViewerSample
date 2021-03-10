using Rg.Plugins.Popup.Services;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinMonkeyViewer.Models;
using XamarinMonkeyViewer.Views;

namespace XamarinMonkeyViewer.ViewModels
{
    public class CarouselMonkeyViewModel : BaseViewModel
    {
        private Monkey _currentMonkey;

        public Monkey CurrentMonkey { get
            { return _currentMonkey; } set {
                _currentMonkey = value ;
                OnPropertyChanged();
            } }

        public ICommand MonkeyTappedCommand { get; set; }

        public ObservableCollection<Monkey> Monkeys { get; set; }



        public CarouselMonkeyViewModel(INavigation navigation) : base(navigation)
        {
            Monkeys = new ObservableCollection<Monkey>(App.Database.GetMonkeys());

            MonkeyTappedCommand = new Command<Monkey>(MonkeyImageTapped);
        }

        private async void MonkeyImageTapped(Monkey monkey)
        {
            var page = new MonkeyDescriptionPopupView(monkey);
            await PopupNavigation.Instance.PushAsync(page);
        }
    }
}
