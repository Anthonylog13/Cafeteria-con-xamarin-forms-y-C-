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
    public partial class Master : ContentPage
    {
        public Master()
        {
            InitializeComponent();
        }

       private async void btnAcerca_Clicked(object sender, EventArgs e)
        {
            App.MAsterDet.IsPresented = false;
            await App.MAsterDet.Detail.Navigation.PushAsync(new About());
        }

        private async void btnprofile_Clicked(object sender, EventArgs e)
       {
           App.MAsterDet.IsPresented = false;
           await App.MAsterDet.Detail.Navigation.PushAsync(new Perfil());
       }

        private async void btninicio_Clicked(object sender, EventArgs e)
       {
           //App.MAsterDet.IsPresented = false;
           //await App.MAsterDet.Detail.Navigation.PushAsync(new Detail());

       }

        private async void btnsettings_Clicked(object sender, EventArgs e)
       {
           App.MAsterDet.IsPresented = false;
           await App.MAsterDet.Detail.Navigation.PushAsync(new Ajustes());
       }

            private async void btnCerrar_Clicked(object sender, EventArgs e)
              {
                 
                await Navigation.PushAsync(new Vistas.IniciarSesion());
              await App.Database.SetTodoCarritoModel();
            await App.Database.SetTodoProductoModel();

        }

              private async void btnHistorial_Clicked(object sender, EventArgs e)
              {
                  App.MAsterDet.IsPresented = false;
                  await App.MAsterDet.Detail.Navigation.PushAsync(new HistorialP());
              }

              private async void btnMetodoP_Clicked(object sender, EventArgs e)
              {
                  App.MAsterDet.IsPresented = false;
                  await App.MAsterDet.Detail.Navigation.PushAsync(new MetodoPago());
              }

              private async void btnDirecciones_Clicked(object sender, EventArgs e)
              {
                  App.MAsterDet.IsPresented = false;
                  await App.MAsterDet.Detail.Navigation.PushAsync(new Direcciones());
              }

              private async void btnCupones_Clicked(object sender, EventArgs e)
              {
                  App.MAsterDet.IsPresented = false;
                  await App.MAsterDet.Detail.Navigation.PushAsync(new Cupones());
              }
    }
}