using Cafeteria.Models;
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
    public class ViewModelRegistrarse : BaseViewModel
    {
        #region Attributes
        private string name;
        private DateTime birthday;
        private string phone;
        private string password;
        private string email;
        private string genero;
        #endregion

        #region Properties
        public string NameTxt
        {
            get { return this.name; }
            set { SetValue(ref this.name, value); }
        }

        public DateTime BirthdayTxt
        {
            get { return this.birthday; }
            set { SetValue(ref this.birthday, value); }
        }
        public string PhoneTxt
        {
            get { return this.phone; }
            set { SetValue(ref this.phone, value); }
        }
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

        public string GeneroTxt
        {
            get { return this.genero; }
            set { SetValue(ref this.genero, value); }
        }





        #endregion
        #region Commands
        public ICommand RegisterCommand
        {
            get
            {
                return new RelayCommand(RegisterMethod);
            }
            set
            {

            }

        }


        #endregion
        #region Methods

             
            private async void RegisterMethod()

            {
            
                if (string.IsNullOrEmpty(this.NameTxt))
                {
                    await Application.Current.MainPage.DisplayAlert(
                        "Error",
                        "Debes introducir el nombre.",
                        "Accept");
                    return;
                }

                
              
                 if (this.BirthdayTxt==DateTime.MinValue)
                {
                    await Application.Current.MainPage.DisplayAlert
                    (
                        "Error",
                        "Debes introducir la fecha de nacimiento.",
                        "Accept"
                    );

                    return;
                }

                  if (string.IsNullOrEmpty(this.PhoneTxt))
                {
                    await Application.Current.MainPage.DisplayAlert
                    (
                        "Error",
                        "Debes introducir un número de celular.",
                        "Accept"
                    );
                    return;
                }
                   if (string.IsNullOrEmpty(this.EmailTxt) )
                {
                    await Application.Current.MainPage.DisplayAlert
                    (
                        "Error",
                        "Debes introducir un correo.",
                        "Accept"
                    );
                    return;
                }

                    if (string.IsNullOrEmpty(this.PasswordTxt))
                {
                    await Application.Current.MainPage.DisplayAlert
                    (
                        "Error",
                        "Debes introducir una contraseña.",
                        "Accept"
                    );
                    return;
                }
                       if (string.IsNullOrEmpty(this.GeneroTxt))
                {
                    await Application.Current.MainPage.DisplayAlert
                    (
                        "Error",
                        "Debes introducir un genero.",
                        "Accept"
                    );
                    return;
                }
            List<PersonaModels> e = App.Database.GetCorreoyContraPersonaModelsValidate(email, phone).Result;

            if (e.Count == 0)
            {
                var persona = new PersonaModels
                {
                    NameBD = NameTxt.ToLower(),
                    BirthdayBD = BirthdayTxt,
                    PhoneBD = PhoneTxt,
                    EmailBD = EmailTxt.ToLower(),
                    PasswordBD = PasswordTxt.ToLower(),
                    GeneroBD = GeneroTxt.ToLower()

                };

                await App.Database.SavePersonaModelsAsync(persona);

                await Application.Current.MainPage.DisplayAlert("Completado", "Bienvenido" + "  " + name.ToString(), "OK");



                await Application.Current.MainPage.Navigation.PushAsync(new IniciarSesion());
            }
            else if (e.Count > 0)
            {
                await Application.Current.MainPage.DisplayAlert(
                      "error",
                      "Ya hay una cuenta registrada.",
                      "OK");
                await Application.Current.MainPage.Navigation.PushAsync(new IniciarSesion());


            }

               
            }
        }

        #endregion

    }

