﻿using Cafeteria.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

using System.Data.Common;
using Xamarin.Forms;
using GalaSoft.MvvmLight.Command;
using Cafeteria.Vistas;

namespace Cafeteria.ViewModel
{
    public class VentanaEmerProductViewModel:BaseViewModel
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
        public async void AgregarCompra()
        {

            if (CantidadTxt==0)
            {
                RespuestaTxt = "La cantidad de unidades debe ser mayor que 0";
            }
            else if (CantidadTxt >0 )
            {
                 
                var compra = new CarritoModel
                {
                    
                    DescriptionBD = DescripcionTxt,
                    PriceBD = PriceTxt,
                    UrlBD = UrlTxt,
                    CantidadBD = CantidadTxt,


                };

                await App.Database.SaveCompraModelsAsync(compra);
                //await Application.Current.MainPage.Navigation.PushAsync(new Detail());




            }


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
        public ICommand AgregarCompraCommand
        {
            get
            {
                return new RelayCommand(AgregarCompra);
            }
            set
            {

            }

        }




        #endregion

        #region Contructor
        public VentanaEmerProductViewModel(ProductoModel _producto)
        {

            ProductIdTx = _producto.ProductId;
            DescripcionTxt = _producto.DescriptionBD;
            PriceTxt = _producto.PriceBD;
            UrlTxt = _producto.UrlBD;
           

        }

        #endregion



    }
}
