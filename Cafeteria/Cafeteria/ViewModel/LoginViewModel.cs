using Cafeteria.Models;
using Cafeteria.Vistas;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace Cafeteria.ViewModel
{
    public class LoginViewModel:BaseViewModel
    {
        #region Attributes
        private string email;
        private string password;
        #endregion

        #region Properties
        public string EmailTxt
        {
            get { return this.email; }
            set { SetValue(ref this.email, value); }
        }

        public string PasswordTxt
        {
            get { return this.password; }
            set { SetValue(ref this.password, value); }
        }
        #endregion

        #region Commands
        public ICommand LoginCommand
        {
            get
            {
                return new RelayCommand(Login);
            }
            set
            {

            }

        }



        #endregion

        #region Methods
        public async void Login()
        {
            if (string.IsNullOrEmpty(this.email))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Debes introducir el correo.",
                    "Accept");
                return;
            }
            if (string.IsNullOrEmpty(this.password))
            {
                await Application.Current.MainPage.DisplayAlert(
                    "Error",
                    "Debes introducir la contraseña.",
                    "Accept");
                return;
            }

            List<PersonaModels> e = App.Database.GetPersonaModelsValidate(email, password).Result;

            if (e.Count == 0)
            {
                await Application.Current.MainPage.DisplayAlert(
                    "error",
                    "Correo o contraseña incorrecta.",
                    "OK");
            }
            else if (e.Count > 0)
            {
                await Application.Current.MainPage.Navigation.PushAsync(new Menuinicial());




            }


        }

        #endregion

        #region Constructor

        #endregion



    }
}
