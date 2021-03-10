using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using Xamarin.Forms;
using XamarinMonkeyViewer.Models;

namespace XamarinMonkeyViewer.ViewModels
{
    public class ManualMonkeyViewModel : BaseViewModel
    {

        public ObservableCollection<Monkey> Monkeys { get; set; }

        public ManualMonkeyViewModel(INavigation navigation) : base(navigation)
        {



        }
    }
}
