using Rg.Plugins.Popup.Services;
using System.Collections.ObjectModel;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinMonkeyViewer.Models;
using XamarinMonkeyViewer.Views;

namespace XamarinMonkeyViewer.ViewModels
{
    public class ManualMonkeyViewModel : BaseViewModel
    {
        private Monkey _currentMonkey;
        private int _monkeyIndex=0;

        public Monkey CurrentMonkey
        {
            get
            { return _currentMonkey; }
            set
            {
                _currentMonkey = value;
                OnPropertyChanged();
            }
        }

        public ICommand MonkeyTappedCommand { get; set; }
        public ICommand NextMonkeyCommand { get; set; }
        public ICommand PreviousMonkeyCommand { get; set; }

        public ObservableCollection<Monkey> Monkeys { get; set; }

        public ManualMonkeyViewModel(INavigation navigation) : base(navigation)
        {
            Monkeys = new ObservableCollection<Monkey>(App.Database.GetMonkeys());

            MonkeyTappedCommand = new Command(MonkeyImageTapped);
            NextMonkeyCommand = new Command(NextMonkey);
            PreviousMonkeyCommand = new Command(PreviousMonkey);

            CurrentMonkey = Monkeys[_monkeyIndex];
        }

        private void NextMonkey()
        {
            if (_monkeyIndex < Monkeys.Count-1)
            {
                _monkeyIndex++;
                CurrentMonkey = Monkeys[_monkeyIndex];
            }
        }

        private void PreviousMonkey()
        {
            if (_monkeyIndex > 0)
            {
                _monkeyIndex--;
                CurrentMonkey = Monkeys[_monkeyIndex];
            }
        }

        private async void MonkeyImageTapped()
        {
            var page = new MonkeyDescriptionPopupView(CurrentMonkey);
            await PopupNavigation.Instance.PushAsync(page);
        }
    }
}
