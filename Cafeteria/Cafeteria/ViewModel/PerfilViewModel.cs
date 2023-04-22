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
    public class PerfilViewModel : BaseViewModel
    {
        #region Attributes
        public object listViewSource;
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

        public object ListViewSource { get { return this.listViewSource; } set { SetValue(ref this.listViewSource, value); } }

        public string Filter { get; set; }
        public List<PersonaModels> MyProducts { get; set; }


        #endregion

        #region Methods
        public async Task LoadData()
        {
            

            this.ListViewSource = await App.Database.GetTodoModel();
        }
        public void RefreshList()
        {

            if (!string.IsNullOrEmpty(this.Filter))
            {

                var MyList = this.MyProducts.Select(p => new PerfilViewModel
                {
                    IdPersona = p.IdPersona,
                    name = p.NameBD,
                    birthday = p.BirthdayBD,
                    phone = p.PhoneBD,
                    email = p.EmailBD,
                    password = p.PasswordBD,
                    genero = p.GeneroBD

                }).Where(p => p.name.ToLower().Contains(this.Filter.ToLower())).ToList();

                this.ListViewSource = new ObservableCollection<PerfilViewModel>(MyList.OrderBy(p => p.name));

            }
           
        }



        #endregion

      

        #region Constructor
        public PerfilViewModel()
        {
            LoadData();
        }
        #endregion

    }
}
