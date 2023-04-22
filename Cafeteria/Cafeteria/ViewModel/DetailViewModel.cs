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

            var producto = new ProductoModel
            {

                DescriptionBD = "pan00",
                PriceBD = 5000,
                UrlBD = "PapoSinFondo.png"
            };

            //await App.Database.SaveProductoModelsAsync(producto);


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
