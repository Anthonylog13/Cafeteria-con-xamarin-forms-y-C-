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
    public partial class VentanaEmer : ContentPage
    {
        public VentanaEmer(PersonaModels _persona)
        {
            InitializeComponent();
            BindingContext = new VentanaEmerViewModel(_persona);
        }
    }
}