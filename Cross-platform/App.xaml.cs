using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace LUBA
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            var image = new Image { Source = "waterfront.jpg" };

            MainPage = new Data_Entry.MainPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }
    }
}
