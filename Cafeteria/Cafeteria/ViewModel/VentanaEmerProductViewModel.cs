using Cafeteria.Models;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

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

        #endregion
        #region Properties
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

        #endregion
        #region Methods
        public void Aumentar()
        {
            CantidadTxt += 1;
        }
        public void Disminuir()
        {
            if (CantidadTxt > 0)
            {
                CantidadTxt -= 1;
            }
           
        }
        public void AgregarCompra()
        {
           
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
