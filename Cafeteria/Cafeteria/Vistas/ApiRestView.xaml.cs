using Cafeteria.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cafeteria.Vistas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class ApiRestView : ContentPage
	{
		private string url = "https://jsonplaceholder.typicode.com/todos";
		HttpClient client= new HttpClient();

        public ApiRestView ()
		{
			InitializeComponent ();
		}
        protected override async void OnAppearing()
        {
			string contenido= await client.GetStringAsync (url);
			IEnumerable< UsuarioApiModel> list=JsonConvert.DeserializeObject<IEnumerable<UsuarioApiModel>> (contenido);
			ltusuario.ItemsSource=new ObservableCollection<UsuarioApiModel> (list);
            base.OnAppearing();
        }
    }
}