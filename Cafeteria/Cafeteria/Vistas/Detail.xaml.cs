using Cafeteria.Models;
using Cafeteria.ViewModel;
using Cafeteria.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cafeteria
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Detail : ContentPage
    {
        
        public Detail()
        {
            InitializeComponent();
            BindingContext = new DetailViewModel();
           



        }

        private async void ListViewVenEmerge_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            await Navigation.PushAsync(new VentanaEmerProduct(e.SelectedItem as ProductoModel));
        }

        private void ToolbarItem_Clicked(object sender, EventArgs e)
        {
             App.MAsterDet.Detail.Navigation.PushAsync(new CarritoDeCompras());
        }
    }
}