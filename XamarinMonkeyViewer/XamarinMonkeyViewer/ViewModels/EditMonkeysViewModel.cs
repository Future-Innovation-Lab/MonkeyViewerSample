using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;
using XamarinMonkeyViewer.Models;

namespace XamarinMonkeyViewer.ViewModels
{
    public class EditMonkeysViewModel : BaseViewModel
    {
        public ObservableCollection<Monkey> _monkeys;
        public ObservableCollection<Monkey> Monkeys
        {
            get { return _monkeys; }
            set
            {
                _monkeys = value;
                OnPropertyChanged();
            }
        }


        public ICommand DeleteMonkeyCommand { get; set; }

        public EditMonkeysViewModel(INavigation navigation) : base(navigation)
        {
            Monkeys = new ObservableCollection<Monkey>(App.Database.GetMonkeys());

            DeleteMonkeyCommand = new Command<Monkey>(DeleteMonkey);
        }

        private void DeleteMonkey(Monkey monkey)
        {
            App.Database.DeleteMonkey(monkey.MonkeyId);
            Monkeys = new ObservableCollection<Monkey>(App.Database.GetMonkeys());

        }
    }
}
