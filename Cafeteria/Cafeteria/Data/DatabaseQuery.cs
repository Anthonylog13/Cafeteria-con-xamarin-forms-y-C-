using Cafeteria.Models;
using Cafeteria.Vistas;
using SQLite;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;

namespace Cafeteria.Data
{
    public class DatabaseQuery
    {
        readonly SQLiteAsyncConnection _database;
        public DatabaseQuery(string dbPath)
        {
            _database = new SQLiteAsyncConnection(dbPath);
            _database.CreateTableAsync<PersonaModels>().Wait();
            _database.CreateTableAsync<ProductoModel>().Wait();
            _database.CreateTableAsync<CarritoModel>().Wait();
        }
        #region CRUD

        //Busqueda  de informacion
        public Task<List<PersonaModels>> GetPersonaModels()
        {
            return _database.QueryAsync<PersonaModels>("Select * from PersonaModels");
        }

        //Insertar y actualizar
        public Task<int> SavePersonaModelsAsync(PersonaModels persona)
        {
            if(persona.IdPersona != 0)
            {
                return _database.UpdateAsync(persona);
            }
            else
            {
                return _database.InsertAsync(persona);
            }
        }
        public Task<int> SaveCarritoModelsAsync(CarritoModel carrito)
        {
            if (carrito.ProductId != 0)
            {
                return _database.UpdateAsync(carrito);
            }
            else
            {
                return _database.InsertAsync(carrito);
            }
        }

        public Task<int> SaveProductoModelsAsync(ProductoModel producto)
        {
            if (producto.ProductId != 0)
            {
                return _database.UpdateAsync(producto);
            }
            else
            {
                return _database.InsertAsync(producto);
            }
        }

        public Task<int> SaveCompraModelsAsync(CarritoModel compra)
        {
            if (compra.ProductId != 0)
            {
                return _database.UpdateAsync(compra);
            }
            else
            {
                return _database.InsertAsync(compra);
            }
        }

        // Eliminar

        public Task<int> DeletePersonaModelsAsync (PersonaModels persona)
        {
            return _database.DeleteAsync(persona);
        }
        public Task<int> DeleteCarritoModelsAsync(CarritoModel carrito)
        {
            return _database.DeleteAsync(carrito);
        }

        public Task<List<PersonaModels>> GetPersonaModelsValidate(string email, string password)
        {
            return _database.QueryAsync<PersonaModels>("SELECT * FROM PersonaModels WHERE EmailBD = '" + email + "' AND PasswordBD = '" + password + "'");

        }
        public Task<List<PersonaModels>> GetCorreoyContraPersonaModelsValidate(string email,string phone)
        {
            return _database.QueryAsync<PersonaModels>("SELECT * FROM PersonaModels WHERE EmailBD = '" + email + "' OR PhoneBD = '" + phone + "'");

        }
        public Task<List<ProductoModel>> GetProductModelsValidate(int ProductId, string DescriptionTxt)
        {
            return _database.QueryAsync<ProductoModel>("SELECT * FROM ProductoModel WHERE ProductId = '" + ProductId + "' && DescriptionBD = '" + DescriptionTxt + "'");

        }

        public  Task<List<PersonaModels>> GetTodoModel()
        {
            return _database.Table<PersonaModels>().ToListAsync();
        }

        public Task<List<ProductoModel>> GetTodoProductModel()
        {
            return _database.Table<ProductoModel>().ToListAsync();
        }
        public Task<List<CarritoModel>> GetTodoCarritoModel()
        {
            return _database.Table<CarritoModel>().ToListAsync();
        }

        public Task<List<CarritoModel>> SetTodoCarritoModel()
        {
            return _database.QueryAsync<CarritoModel>("DELETE  FROM CarritoModel");


        }
        public Task<List<ProductoModel>> SetTodoProductoModel()
        {
            return _database.QueryAsync<ProductoModel>("DELETE  FROM ProductoModel ");


        }



        #endregion

    }
}
