using Blueteeth.Data;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Blueteeth
{
    public partial class App : Application
    {
        private static BlueteethContext context;

        public App(string path)
        {
            InitializeComponent();

            context = new BlueteethContext(path);

            MainPage = new MainPage(context);
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
