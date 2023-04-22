using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Cafeteria.Models;
using SQLite.Net;
using Xamarin.Forms;

namespace Cafeteria
{
    public class DataContext : IDisposable
    {
        private SQLiteConnection cnn;

        public DataContext()
        {
            var configuracion = DependencyService.Get<IConfiguration>();
            cnn = new SQLiteConnection(configuracion.plataforma, Path.Combine(configuracion.directorio, "persona.db3"));
            cnn.CreateTable<PersonaModels>();


        }

        public void Dispose()
        {
            cnn.Dispose();
        }

        public void Insertar(PersonaModels modelo)
        {
            cnn.Insert(modelo);
        }
        public void Actualizar(PersonaModels modelo)
        {
            cnn.Update(modelo);
        }
        public void Eliminar(PersonaModels modelo)
        {
            cnn.Delete(modelo);
        }
        public PersonaModels Consultar(int id)
        {
            return cnn.Table<PersonaModels>().FirstOrDefault(p => p.IdPersona == id);
        }
        public List<PersonaModels> Consultar()
        {
            return cnn.Table<PersonaModels>().ToList();

        }
    }
}
