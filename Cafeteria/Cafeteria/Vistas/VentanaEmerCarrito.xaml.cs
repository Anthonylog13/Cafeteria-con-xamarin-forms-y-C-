using Cafeteria.Models;
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
    public partial class VentanaEmerCarrito : ContentPage
    {
        public VentanaEmerCarrito(CarritoModel _carrito)
        {
            InitializeComponent();
            BindingContext = new VentanaEmerCarritoViewModel(_carrito);

        }
    }
}