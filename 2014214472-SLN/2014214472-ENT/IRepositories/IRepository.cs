using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace _2014214472_ENT.IRepositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        //Metodos estandar que toda tabla debe tener
        //Se programan de manera generica para no duplicar codigo por cada una
        //CRUD

        //Creadores
        //Agrega un registro al repositorio (SQL Server) a la tabla TEntity
        void Add(TEntity entity);
        //Agrega un grupo de registros al repositorio (SQL Server) a la tabla TEntity
        void AddRange(IEnumerable<TEntity> entities);

        //Lectores
        //Obtiene el registro con PK = Id de la tabla TEntity
        TEntity Get(int Id);
        //Obtiene todos los registros de la tabla TEntity
        IEnumerable<TEntity> GetAll();
        //Obtiene todos los registros de la tabla TEntity que cumplan con la condicion predicate
        //(expresion lambda con parametro de entrada a TEntity
        //y devolvera una expresion booleana. Si esa expresion es True para un registro,
        //entonces dicho registro se agrega a la lista de registros a devolver a la aplicacion).
        IEnumerator<TEntity> Find(Expression<Func<TEntity, bool>> predicate);

        //Actualizaciones
        //Actualiza un registro al repositorio (SQL Server) a la tabla TEntity
        void Update(TEntity entity);
        //Actualiza un grupo de registros al repositorio (SQL Server) a la tabla TEntity
        void UpdateRange(IEnumerable<TEntity> entities);

        //Eliminadores
        //Elimina un registro al repositorio (SQL Server) a la tabla TEntity
        void Delete(TEntity entity);
        //Elimina un grupo de registros al repositorio (SQL Server) a la tabla TEntity
        void DeleteRange(IEnumerable<TEntity> entities);

    }
}
