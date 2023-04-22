using Cafeteria.Models;
using Cafeteria.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cafeteria.Vistas
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Perfil : ContentPage
	{
        //ObservableCollection<PersonaModels> ListaP;
		public Perfil ()
		{
			InitializeComponent ();
            BindingContext = new PerfilViewModel();

            

        }

        private async void ListViewName_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            await Navigation.PushAsync(new VentanaEmer(e.SelectedItem as PersonaModels));
        }

        private void SearchBar_TextChanged(object sender, TextChangedEventArgs e)
        {

           // ListViewName.ItemsSource = ListaP.Where(s => s.NameBD.Equals(e.NewTextValue));




        }

        private void ConsumoApi_Clicked(object sender, EventArgs e)
        {
            App.MAsterDet.Detail.Navigation.PushAsync(new ApiRestView());
        }
    }
}