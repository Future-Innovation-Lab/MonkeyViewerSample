using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using XamarinMonkeyViewer.Models;

namespace XamarinMonkeyViewer.ViewModels
{
    public class MonkeyDescriptionPopupViewModel : BaseViewModel
    {
        public Monkey CurrentMonkey { get; set; }

        public MonkeyDescriptionPopupViewModel(INavigation navigation, Monkey monkey) : base(navigation)
        {
            CurrentMonkey = monkey;
        }
    }
}
