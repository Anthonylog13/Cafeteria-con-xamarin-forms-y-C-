using System;
using System.Collections.Generic;
using System.Text;
using SQLite.Net.Interop;

namespace Cafeteria
{
    public interface IConfiguration
    {
       string directorio { get; }
        ISQLitePlatform plataforma { get; }

        

    }
}
