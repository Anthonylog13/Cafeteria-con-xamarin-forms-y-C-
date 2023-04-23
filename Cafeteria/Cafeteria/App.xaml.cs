using Cafeteria.Data;
using Cafeteria.Vistas;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cafeteria
{
    public partial class App : Application
    {
        public static MasterDetailPage MAsterDet { get; set; }


        static DatabaseQuery database;
        public static DatabaseQuery Database
        {
            get
            {
                if (database==null)
                {
                    database = new DatabaseQuery(Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "Cafeteriaa.db3"));

                }
                return database;
            }
        }



        public App()
        {
            InitializeComponent();

           MainPage = new NavigationPage( new Vistas.IniciarSesion());
            //MainPage = new NavigationPage(new Vistas.Menuinicial());
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
