using Cafeteria.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Cafeteria.ViewModel
{
    public class DetailViewModel: BaseViewModel
    {
        #region Attributes
        public object listViewSource;
        private int ProductId;
        private string Description;
        private decimal Price;
        private string Url;
        #endregion

        #region Properties
        public int ProductIdTx 
        {
            get { return this.ProductId; }
            set { SetValue(ref this.ProductId, value); }
        }
        public string DescriptionTxt
        {
            get { return this.Description; }
            set { SetValue(ref this.Description, value); }
        }
        public Decimal PriceTxt
        {
            get { return this.Price; }
            set { SetValue(ref this.Price, value); }
        }
        public string UrlTxt
        {
            get { return this.Url; }
            set { SetValue(ref this.Url, value); }
        }

        public object ListViewSource { get { return this.listViewSource; } set { SetValue(ref this.listViewSource, value); } }
        #endregion

        #region Methods
        public async Task LoadData()

        {

            var producto1 = new ProductoModel
            {

                DescriptionBD = "Café",
                PriceBD = 1200,
                UrlBD = "cafe.png"
            };

            await App.Database.SaveProductoModelsAsync(producto1);

            var producto2 = new ProductoModel
            {

                DescriptionBD = "Malteada de café",
                PriceBD = 10800,
                UrlBD = "postre.png"
            };

            await App.Database.SaveProductoModelsAsync(producto2);

            var producto3 = new ProductoModel
            {

                DescriptionBD = "Mojito",
                PriceBD = 11000,
                UrlBD = "bebidalimon.png"
            };

            await App.Database.SaveProductoModelsAsync(producto3);

            var producto4 = new ProductoModel
            {

                DescriptionBD = "Tarta de nutella",
                PriceBD = 5700,
                UrlBD = "postrechocolate.png"
            };

            await App.Database.SaveProductoModelsAsync(producto4);
            var producto5 = new ProductoModel
            {

                DescriptionBD = "Baguette con queso",
                PriceBD = 7500,
                UrlBD = "panamarillo.png"
            };

            await App.Database.SaveProductoModelsAsync(producto5);
            var producto6 = new ProductoModel
            {

                DescriptionBD = "Sándwich ",
                PriceBD = 11200,
                UrlBD = "Emparedado.png"
            };

            await App.Database.SaveProductoModelsAsync(producto6);
            var producto7 = new ProductoModel
            {

                DescriptionBD = "Brioche a la plancha",
                PriceBD = 9800,
                UrlBD = "Brouwnie.png"
            };

            await App.Database.SaveProductoModelsAsync(producto7);




            this.ListViewSource = await App.Database.GetTodoProductModel();
        }

        #endregion

        #region Constructor
        public DetailViewModel()
        {
            LoadData();
        }
        #endregion

    }
}
