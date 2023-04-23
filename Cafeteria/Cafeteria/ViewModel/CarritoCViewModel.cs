using Cafeteria.Models;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Cafeteria.ViewModel
{
    public class CarritoCViewModel: BaseViewModel
    {
        #region atributes
        public object listViewSource;
        private int ProductId;
        private string Description;
        private decimal Price;
        private string Url;
        private int Cantidad;

        #endregion
        #region properties
        public int ProductIdTx
        {
            get { return this.ProductId; }
            set { SetValue(ref this.ProductId, value); }
        }
        public int CantidadTxt
        {
            get { return this.Cantidad; }
            set { SetValue(ref this.Cantidad, value); }
        }
        public string DescripcionTxt
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
        #region methods
        public async Task LoadData()
        {


            this.ListViewSource = await App.Database.GetTodoCarritoModel();
        }

        #endregion
        #region commads

        #endregion
        #region construct
        public CarritoCViewModel()
        {
            LoadData();
        }
        #endregion

    }
}
