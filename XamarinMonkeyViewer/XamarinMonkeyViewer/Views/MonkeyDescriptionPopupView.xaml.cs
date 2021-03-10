using Rg.Plugins.Popup.Pages;
using Rg.Plugins.Popup.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinMonkeyViewer.Models;
using XamarinMonkeyViewer.ViewModels;

namespace XamarinMonkeyViewer.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MonkeyDescriptionPopupView : PopupPage
    {
        public MonkeyDescriptionPopupView(Monkey monkey)
        {
            InitializeComponent();

            BindingContext = new MonkeyDescriptionPopupViewModel(Navigation, monkey);
        }

        private async void OnClose(object sender, EventArgs e)
        {
            await PopupNavigation.Instance.PopAsync();
        }

        protected override Task OnAppearingAnimationEndAsync()
        {
            return Content.FadeTo(0.8);
        }

        protected override Task OnDisappearingAnimationBeginAsync()
        {
            return Content.FadeTo(1);
        }
    }
}