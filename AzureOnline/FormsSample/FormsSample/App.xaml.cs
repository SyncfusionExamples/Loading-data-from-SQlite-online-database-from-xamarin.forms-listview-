using AppServiceHelpers;
using AppServiceHelpers.Abstractions;
using FormsSample.Models;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace FormsSample
{
    public partial class App : Application
    {
        IEasyMobileServiceClient client;
        public App()
        {
            InitializeComponent();
            client = new EasyMobileServiceClient();
            client.Initialize("http://xamarin-todo-sample.azurewebsites.net");
            client.RegisterTable<ToDo>();
            client.FinalizeSchema();

            MainPage = new NavigationPage(new Pages.ToDoListPage(client));
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
