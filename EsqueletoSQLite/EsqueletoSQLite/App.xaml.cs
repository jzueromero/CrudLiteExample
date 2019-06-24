using EsqueletoSQLite.Data;
using EsqueletoSQLite.Services;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace EsqueletoSQLite
{
    public partial class App : Application
    {
        private static FriendDatabase database;

        public static FriendDatabase Database
        {
            get
            {
                if (database == null)
                {
                    database =
                         new FriendDatabase(DependencyService.Get<IFileHelper>().GetLocalFilePath("NombreDetuDB.db3"));
                }
                return database;
            }
        }
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
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
