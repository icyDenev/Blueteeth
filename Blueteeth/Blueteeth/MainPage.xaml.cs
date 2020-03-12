using Blueteeth.Data;
using Blueteeth.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Blueteeth
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        BlueteethContext context;

        public MainPage()
        {
            InitializeComponent();

            Init();

            ScaleWelcomeAsync();
        }

        public MainPage(BlueteethContext context) : this()
        {
            this.context = context;
        }

        public void Init()
        {
            BackgroundColor = Constants.BackgroundColor;
        }

        async void ScaleWelcomeAsync()
        {
            await LabelWelcome.ScaleYTo(1, 250, Easing.Linear).ConfigureAwait(false);
        }
    }
}
