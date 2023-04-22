using Cafeteria.Models;
using GalaSoft.MvvmLight.Command;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using static Xamarin.Essentials.Permissions;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Cafeteria.ViewModel
{
    public class VentanaEmerViewModel : BaseViewModel
    {
        #region Atributes
        private int IdPersona;
        private string name;
        private DateTime birthday;
        private string phone;
        private string password;
        private string email;
        private string genero;
        #endregion

        #region Properties
        public int IdPersonaTxt
        {
            get { return this.IdPersona; }
            set { SetValue(ref this.IdPersona, value); }
        }
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

        #region Methods
        private async void SaveMethod()
        {
          
                if (string.IsNullOrEmpty(this.NameTxt))
                {
                    await Application.Current.MainPage.DisplayAlert(
                        "Error",
                        "Debes introducir el nombre.",
                        "Accept");
                    return;
                }



                if (this.BirthdayTxt == DateTime.MinValue)
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
                if (string.IsNullOrEmpty(this.EmailTxt))
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

            var humanoide = new PersonaModels
            {
                IdPersona= IdPersonaTxt,
                NameBD = NameTxt.ToLower(),
                BirthdayBD = BirthdayTxt.Date,
                PhoneBD = PhoneTxt,
                EmailBD = EmailTxt.ToLower(),
                PasswordBD = PasswordTxt.ToLower(),
                GeneroBD = GeneroTxt.ToLower()

            };
            await App.Database.SavePersonaModelsAsync (humanoide);
            await App.Current.MainPage.Navigation.PushAsync(new Vistas.Perfil());


        }

        private async void DeleteMethod()
        {
            var persona = new PersonaModels
            {
                IdPersona = IdPersonaTxt,
                NameBD = NameTxt.ToLower(),
                BirthdayBD = BirthdayTxt.Date,
                PhoneBD = PhoneTxt,
                EmailBD = EmailTxt.ToLower(),
                PasswordBD = PasswordTxt.ToLower(),
                GeneroBD = GeneroTxt.ToLower()
            };
            await App.Database.DeletePersonaModelsAsync(persona);
            await App.Current.MainPage.Navigation.PushAsync(new Vistas.Perfil());
        }
        #endregion

        #region Construdctor
        public VentanaEmerViewModel(PersonaModels _persona)
        {
            IdPersonaTxt = _persona.IdPersona;
            NameTxt = _persona.NameBD;
            BirthdayTxt = _persona.BirthdayBD;
            PhoneTxt = _persona.PhoneBD;
            EmailTxt = _persona.EmailBD;
            PasswordTxt = _persona.PasswordBD;
            GeneroTxt = _persona.GeneroBD;

        }


        #endregion
    }
}
