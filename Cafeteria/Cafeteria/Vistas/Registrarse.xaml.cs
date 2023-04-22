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
	public partial class Registrarse : ContentPage
	{
		public Registrarse ()
		{
			InitializeComponent ();
			BindingContext = new ViewModelRegistrarse();
			
		}

        private void btnvolver_Clicked(object sender, EventArgs e)
        {
			Navigation.PopAsync();
        }

       
    }
}