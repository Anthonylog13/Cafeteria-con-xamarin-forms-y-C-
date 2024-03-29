﻿using Cafeteria.Models;
using Cafeteria.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Cafeteria.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarritoDeCompras : ContentPage
    {
        public CarritoDeCompras()
        {
            InitializeComponent();
            BindingContext = new CarritoCViewModel();
        }

        private async void ListViewVenEmerge_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            await Navigation.PushAsync(new VentanaEmerCarrito(e.SelectedItem as CarritoModel));

        }
    }
}