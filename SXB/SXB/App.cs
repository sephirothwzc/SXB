using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;
using SXB.ViewModel.Pages;
using System.Threading.Tasks;
using SXBModels;
using Navigation;
using SXB.ICommonCLR;

namespace SXB
{
    public class App : Application
    {
        public App()
        {
            //// The root page of your application
            //MainPage = new ContentPage
            //{
            //    Content = new StackLayout
            //    {
            //        VerticalOptions = LayoutOptions.Center,
            //        Children = {
            //            new Label {
            //                XAlign = TextAlignment.Center,
            //                Text = "Welcome to Xamarin Forms!"
            //            }
            //        }
            //    }
            //};

            var mainPageViewModel = new SYS_USERS_PageModel();

            mainPageViewModel.LoadItemsAsync(LoadItemsAsync("http://192.168.200.137/SXBWebApi/api/SYS_USER"));

            var navigationFrame = new NavigationFrame(mainPageViewModel);
            MainPage = navigationFrame.Root;
        }
        private static async Task<List<SYS_USER>> LoadItemsAsync(string feedUri)
        {
            return  await XHttpClient.Get<List<SYS_USER>>(feedUri);
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
