using BankingXamarin.Services;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using XamarinMonkeyViewer.Views;

namespace XamarinMonkeyViewer
{
    public partial class App : Application
    {
        public static MonkeyDatabase Database { get; set; }


        public App()
        {
            InitializeComponent();

            Database = new MonkeyDatabase();

            MainPage = new CarouselMonkeyView();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
