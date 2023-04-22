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
	public partial class IniciarSesion : ContentPage
	{
		public IniciarSesion ()
		{
			InitializeComponent ();
            BindingContext = new LoginViewModel();
		}

       

        private void btnRegistrarse_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Registrarse());
        }

       
    }
}