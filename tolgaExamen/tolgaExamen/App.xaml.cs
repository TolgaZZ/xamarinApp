using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using tolgaExamen.Services;
using tolgaExamen.Views;

namespace tolgaExamen
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            DependencyService.Register<MockDataStore>();
            MainPage = new MainPage();
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
