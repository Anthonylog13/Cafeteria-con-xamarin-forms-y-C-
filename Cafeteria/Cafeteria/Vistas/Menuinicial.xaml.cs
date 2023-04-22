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
    public partial class Menuinicial : MasterDetailPage
    {
        public Menuinicial()
        {
            InitializeComponent();
            this.Master = new Master();
            this.Detail = new NavigationPage(new Detail());
            App.MAsterDet = this;

        }
    }
}