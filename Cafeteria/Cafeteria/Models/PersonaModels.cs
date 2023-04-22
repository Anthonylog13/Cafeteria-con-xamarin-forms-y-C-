using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;
using SQLite;

namespace Cafeteria.Models
{
    public class PersonaModels
    {
        [PrimaryKey, AutoIncrement]
        [MaxLength(20)]
        public int IdPersona { get; set; }
        [MaxLength(20)]
        public string NameBD { get; set; }
        [MaxLength(10)]
        public string PhoneBD { get; set; }
        [MaxLength(20)]
        public string EmailBD { get; set; }
        [MaxLength(20)]
        public string PasswordBD { get; set; }
        [MaxLength(20)]
        public DateTime BirthdayBD { get; set; }
        [MaxLength(20)]
        public string GeneroBD { get; set; }



    }

}


