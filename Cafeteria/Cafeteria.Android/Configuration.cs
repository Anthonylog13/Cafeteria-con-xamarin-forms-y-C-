using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SQLite.Net.Interop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using Xamarin.Forms;

[assembly: Dependency(typeof(Cafeteria.Droid.Configuration))]

namespace Cafeteria.Droid
{
    public class Configuration : IConfiguration
    {
        private string Directorio;
        private ISQLitePlatform Plataforma;
        
        public string directorio
        {
            get
            {
                if (string.IsNullOrEmpty(Directorio))
                {
                    Directorio = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
                }
                return Directorio;
            }
        }

        public ISQLitePlatform plataforma
        {
            get
            {
                if (Plataforma==null)
                {
                    Plataforma =  new SQLite.Net.Platform.XamarinAndroid.SQLitePlatformAndroid();

                }
                return Plataforma;  
            }
        }
    }
}