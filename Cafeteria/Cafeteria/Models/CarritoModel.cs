using System;
using System.Collections.Generic;
using System.Text;
using SQLite;

namespace Cafeteria.Models
{
    public class CarritoModel
    {
        [PrimaryKey, AutoIncrement]
        public int ProductId { get; set; }
        public string DescriptionBD { get; set; }
        public Decimal PriceBD { get; set; }
        public string UrlBD { get; set; }
        public int CantidadBD { get; set; }

    }
}
