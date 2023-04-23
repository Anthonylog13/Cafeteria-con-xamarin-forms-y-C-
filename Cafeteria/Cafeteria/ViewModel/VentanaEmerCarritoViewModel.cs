using Cafeteria.Models;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace Cafeteria.ViewModel
{
    internal class VentanaEmerCarritoViewModel: BaseViewModel
    {
        #region atributes
        private int ProductId;
        private string Description;
        private decimal Price;
        private string Url;
        private int Cantidad;
        private string Respuesta;

        #endregion
        #region Properties
        public int ProductIdTx
        {
            get { return this.ProductId; }
            set { SetValue(ref this.ProductId, value); }
        }
        public string RespuestaTxt
        {
            get { return this.Respuesta; }
            set { SetValue(ref this.Respuesta, value); }
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

        #endregion
        #region Methods
        public void Aumentar()
        {
            CantidadTxt += 1;
            RespuestaTxt = "";
        }
        public void Disminuir()
        {
            if (CantidadTxt > 0)
            {
                CantidadTxt -= 1;
                RespuestaTxt = "";
            }

        }
        public async void SaveMethod()
        {

            if (CantidadTxt == 0)
            {
                RespuestaTxt = "La cantidad de unidades debe ser mayor que 0";
            }
            else if (CantidadTxt > 0)
            {

                var carro = new CarritoModel
                {
                    ProductId = ProductIdTx,
                    DescriptionBD = DescripcionTxt,
                    PriceBD = PriceTxt,
                    UrlBD = UrlTxt,
                    CantidadBD = CantidadTxt,


                };
                await App.Database.SaveCarritoModelsAsync(carro);
                await App.Current.MainPage.Navigation.PushAsync(new Vistas.CarritoDeCompras());




            }


        }

        

        private async void DeleteMethod()
        {
            var carrito = new CarritoModel
            {
                ProductId = ProductIdTx,
                DescriptionBD = DescripcionTxt,
                PriceBD = PriceTxt,
                UrlBD = UrlTxt,
                CantidadBD = CantidadTxt,
            };
            await App.Database.DeleteCarritoModelsAsync(carrito);
            await App.Current.MainPage.Navigation.PushAsync(new Vistas.CarritoDeCompras());
        }

        #endregion

        #region Commands
        public ICommand AumentarCommand
        {
            get
            {
                return new RelayCommand(Aumentar);
            }
            set
            {

            }

        }
        public ICommand DisminuirCommand
        {
            get
            {
                return new RelayCommand(Disminuir);
            }
            set
            {

            }

        }
        public ICommand SaveCommand
        {
            get
            {
                return new RelayCommand(SaveMethod);
            }


        }
        public ICommand DeleteCommand
        {
            get
            {
                return new RelayCommand(DeleteMethod);
            }


        }




        #endregion

        #region Contructor
        public VentanaEmerCarritoViewModel(CarritoModel _carrito)
        {

            ProductIdTx = _carrito.ProductId;
            DescripcionTxt = _carrito.DescriptionBD;
            PriceTxt = _carrito.PriceBD;
            UrlTxt = _carrito.UrlBD;
            CantidadTxt = _carrito.CantidadBD;


        }

        #endregion
    }
}
