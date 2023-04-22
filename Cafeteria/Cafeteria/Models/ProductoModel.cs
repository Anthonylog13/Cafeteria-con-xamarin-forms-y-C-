using SQLite;
using System;
using System.Collections.Generic;
using System.Text;


namespace Cafeteria.Models
{
    public class ProductoModel
    {
        [PrimaryKey, AutoIncrement]
        public int ProductId { get; set; }
        public string DescriptionBD { get; set; }    
        public Decimal PriceBD{ get; set; }
        public string UrlBD { get; set;}

      
    }
}
