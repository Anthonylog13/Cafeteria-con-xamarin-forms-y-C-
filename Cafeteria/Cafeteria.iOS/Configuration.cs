using Foundation;
using SQLite.Net.Interop;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using UIKit;
using Xamarin.Forms;
[assembly: Dependency(typeof(Cafeteria.iOS.Configuration))]

namespace Cafeteria.iOS
{
    public class Configuration:IConfiguration
    {
        private string Directorio;
        private ISQLitePlatform Plataforma;

        public string directorio
        {
            get
            {
                if (string.IsNullOrEmpty(Directorio))
                {
                    var dir = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                    Directorio = Path.Combine(dir, "..", "Library");

                }
                return Directorio;
            }
        }

        public ISQLitePlatform plataforma
        {
            get
            {
                if (plataforma==null)
                {
                    Plataforma=new SQLite.Net.Platform.XamarinIOS.SQLitePlatformIOS();

                }
                return Plataforma;
            }
        }
    }
}