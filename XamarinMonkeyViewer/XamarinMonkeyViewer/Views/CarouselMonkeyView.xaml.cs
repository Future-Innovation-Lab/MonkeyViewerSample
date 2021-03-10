using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinMonkeyViewer.ViewModels;

namespace XamarinMonkeyViewer.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarouselMonkeyView : ContentPage
    {
        public CarouselMonkeyView()
        {
            InitializeComponent();

            BindingContext = new CarouselMonkeyViewModel(Navigation);
        }
    }
}