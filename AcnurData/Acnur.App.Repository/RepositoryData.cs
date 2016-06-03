namespace Acnur.App.Repository
{
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Transactions;
    using Acnur.App.Aplication.Enumerators;
    using Acnur.App.Aplication.Error;

    /// <summary>
    /// Clase para exponer metodos genericos de B.D.
    /// </summary>
    [ExceptionHandlingAttribute(ExceptionManager.Infraestructura)]
    public class RepositoryData : IDisposable
    {
        #region "Constructores"

        /// <summary>
        /// Initializes a new instance of the <see cref="RepositoryData"/> class.
        /// Constructor de repositorio
        /// </summary>
        /// <param name="transaccional">Si es verdadero el repositorio permite transacciones</param>
        public RepositoryData(bool transaccional)
        {
            this.Audit = true;

            if (transaccional)
            {
                this.ContextTransaction = new App.Entities.ACNUREntities();
            }
        }

        #endregion "Constructores"

        #region "Propiedades"

        /// <summary>
        /// Gets or sets
        /// Contexto para transacciones
        /// </summary>
        /// <value>The context transaction.</value>
        public App.Entities.ACNUREntities ContextTransaction { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="RepositoryData"/> is auditar.
        /// Propiedad para realizar el forzado de evitar la auditoría
        /// </summary>
        /// <value><c>true</c> if auditar; otherwise, <c>false</c>.</value>
        public bool Audit { get; set; }

        #endregion "Propiedades"

        #region "Metodos Public Static"

        /// <summary>
        /// Método que obtiene una entidad por su nombre y object
        /// </summary>
        /// <param name="entidad">Parametroi tipo Objet de entidad a consulotar</param>
        /// <returns>Retorna object de entidad a consultar</returns>
        public static object GetEntityXObject(object entidad)
        {

            using (App.Entities.ACNUREntities contexto = new App.Entities.ACNUREntities())
            {
                System.Data.Entity.Core.EntityKey keyEnt = ((System.Data.Entity.Infrastructure.IObjectContextAdapter)contexto).ObjectContext.CreateEntityKey(entidad.GetType().Name, entidad);
                return ((System.Data.Entity.Infrastructure.IObjectContextAdapter)contexto).ObjectContext.GetObjectByKey(keyEnt);
            }
        }

        /// <summary>
        /// Returna todas las entidades de un tipo dado
        /// </summary>
        /// <typeparam name="TEntity">Tipo de Entidad</typeparam>
        /// <param name="lazyLoad">Tipo de consulta</param>
        /// <param name="navigationChildren">Entidades hijas que se incluiran como parte del resultado</param>
        /// <returns>Collecion de Entidades</returns>
        public static List<TEntity> GetAll<TEntity>(bool lazyLoad, params string[] navigationChildren) where TEntity : class
        {
            using (App.Entities.ACNUREntities contexto = new App.Entities.ACNUREntities())
            {
                System.Data.Entity.DbSet<TEntity> entity = contexto.Set<TEntity>();

                if (lazyLoad == true)
                {
                    return GetProperties<TEntity>().Aggregate<string, System.Data.Entity.Infrastructure.DbQuery<TEntity>>(entity, (current, child) => current.Include(child)).ToList();
                }
                else if (navigationChildren == null || navigationChildren.Length == 0)
                {
                    return entity.ToList();
                }
                else
                {
                    return navigationChildren.Aggregate<string, System.Data.Entity.Infrastructure.DbQuery<TEntity>>(entity, (current, child) => current.Include(child)).ToList();
                }
            }
        }

        /// <summary>
        /// Returna las entidades de un tipo dado, basado en una expresion lambda
        /// </summary>
        /// <typeparam name="TEntity">Tipo de la entidad</typeparam>
        /// <param name="criteria">Expresion Lambda para la busqueda</param>
        /// <param name="lazyLoad">Tipo de consulta</param>
        /// <param name="navigationChildren">Entidades hijas que se incluiran como parte del resultado</param>
        /// <returns>Collecion de Entidades</returns>
        public static List<TEntity> Search<TEntity>(Expression<Func<TEntity, bool>> criteria, bool lazyLoad, params string[] navigationChildren) where TEntity : class
        {
            using (App.Entities.ACNUREntities contexto = new App.Entities.ACNUREntities())
            {
                System.Data.Entity.DbSet<TEntity> entity = contexto.Set<TEntity>();

                if (lazyLoad == true)
                {
                    return GetProperties<TEntity>().Aggregate<string, System.Data.Entity.Infrastructure.DbQuery<TEntity>>(entity, (current, child) => current.Include(child)).Where(criteria).ToList();
                }
                else if (navigationChildren == null || navigationChildren.Length == 0)
                {
                    return entity.Where(criteria).ToList();
                }
                else
                {
                    return navigationChildren.Aggregate<string, System.Data.Entity.Infrastructure.DbQuery<TEntity>>(entity, (current, child) => current.Include(child)).Where(criteria).ToList();
                }
            }
        }

        /// <summary>
        /// Returna las entidades de un tipo dado, basado en una expresion lambda
        /// </summary>
        /// <typeparam name="TEntity">Tipo de la entidad</typeparam>
        /// <param name="criteria">Expresion Lambda para la busqueda</param>
        /// <param name="includes">Inclusion de hijos</param>
        /// <returns>Collecion de Entidades</returns>
        public static List<TEntity> SearchInclude<TEntity>(Expression<Func<TEntity, bool>> criteria, params Expression<Func<TEntity, object>>[] includes) where TEntity : class
        {
            using (App.Entities.ACNUREntities contexto = new App.Entities.ACNUREntities())
            {
                DbQuery<TEntity> query = contexto.Set<TEntity>();
                IQueryable<TEntity> consulta = null;

                foreach (Expression<Func<TEntity, object>> incluir in includes)
                {
                    if (consulta == null)
                    {
                        consulta = query.Include(incluir);
                    }
                    else
                    {
                        consulta = consulta.Include(incluir);
                    }
                }

                if (consulta == null)
                {
                    consulta = query.Where(criteria);
                }
                else
                {
                    consulta = consulta.Where(criteria);
                }


                return consulta.ToList();
            }
        }

        /// <summary>
        /// Returna la primera entidad o la por defecto, basado en una expresion lambda
        /// </summary>
        /// <typeparam name="TEntity">Tipo de la entidad</typeparam>
        /// <param name="criteria">Expresion Lambda para la busqueda</param>
        /// <param name="lazyLoad">Tipo de consulta</param>
        /// <param name="navigationChildren">Entidades hijas que se incluiran como parte del resultado</param>
        /// <returns>Entidad retorno</returns>
        public static TEntity First<TEntity>(Expression<Func<TEntity, bool>> criteria, bool lazyLoad, params string[] navigationChildren) where TEntity : class
        {
            using (App.Entities.ACNUREntities contexto = new App.Entities.ACNUREntities())
            {
                System.Data.Entity.DbSet<TEntity> entity = contexto.Set<TEntity>();

                if (lazyLoad == true)
                {
                    return RepositoryData.GetProperties<TEntity>().Aggregate<string, System.Data.Entity.Infrastructure.DbQuery<TEntity>>(entity, (current, child) => current.Include(child)).Where(criteria).FirstOrDefault();
                }
                else if (navigationChildren == null || navigationChildren.Length == 0)
                {
                    return entity.Where(criteria).FirstOrDefault();
                }
                else
                {
                    return navigationChildren.Aggregate<string, System.Data.Entity.Infrastructure.DbQuery<TEntity>>(entity, (current, child) => current.Include(child)).Where(criteria).FirstOrDefault();
                }
            }
        }

        /// <summary>
        /// Retorna el máximo de una propiedad de un entity
        /// </summary>
        /// <typeparam name="TEntity">Entidad que tiene la propiedad deseada</typeparam>
        /// <typeparam name="TResult">Tipo de dato de la propiedad</typeparam>
        /// <param name="parametro">Consulta con la seleccion de la propiedad</param>
        /// <param name="filtro">Filtro de la entidad no es obligatorio</param>
        /// <returns>Retorna el maximo de una propiedad</returns>
        public static TResult Max<TEntity, TResult>(Func<TEntity, TResult> parametro, Func<TEntity, bool> filtro = null) where TEntity : class
        {
            TResult retorno;

            using (App.Entities.ACNUREntities contexto = new App.Entities.ACNUREntities())
            {
                System.Data.Entity.DbSet<TEntity> entity = contexto.Set<TEntity>();

                if (entity.Count() > 0)
                {
                    if (filtro == null)
                    {
                        retorno = entity.Max(parametro);
                        return retorno;
                    }
                    else
                    {
                        if (entity.Where(filtro).Count() > 0)
                        {
                            retorno = entity.Where(filtro).Max(parametro);
                            return retorno;
                        }
                    }
                }
            }

            return default(TResult);
        }

        /// <summary>
        /// Retorna el máximo de una propiedad de un entity
        /// </summary>
        /// <typeparam name="TEntity">Entidad que tiene la propiedad deseada</typeparam>
        /// <param name="parametro">Consulta con la seleccion de la propiedad</param>
        /// <param name="filtro">Filtro de la entidad no es obligatorio</param>
        /// <returns>Retorna el maximo de una propiedad</returns>
        public static decimal Sum<TEntity>(Func<TEntity, decimal> parametro, Expression<Func<TEntity, bool>> filtro = null) where TEntity : class
        {
            decimal retorno = 0;

            using (App.Entities.ACNUREntities contexto = new App.Entities.ACNUREntities())
            {
                System.Data.Entity.DbSet<TEntity> entity = contexto.Set<TEntity>();

                if (entity.Count() > 0)
                {
                    if (filtro == null)
                    {
                        retorno = entity.Sum(parametro);
                        return retorno;
                    }
                    else
                    {
                        retorno = entity.Where(filtro).Sum(parametro);
                        return retorno;
                    }
                }
            }

            return retorno;
        }

        /// <summary>
        /// Realiza una consulta que permite seleccionar columnas especificas
        /// </summary>
        /// <typeparam name="TEntity">Entidad de consulta</typeparam>
        /// <typeparam name="TResult">Resultado de la consulta</typeparam>
        /// <param name="filtro">Filtro de busqueda</param>
        /// <param name="select">Seleecion de datos</param>
        /// <returns>Lista de columnas seleccionadas</returns>
        public static List<TResult> SearchSelect<TEntity, TResult>(Expression<Func<TEntity, bool>> filtro, Func<TEntity, TResult> select) where TEntity : class
        {
            using (App.Entities.ACNUREntities contexto = new App.Entities.ACNUREntities())
            {
                System.Data.Entity.DbSet<TEntity> entity = contexto.Set<TEntity>();
                return entity.Where(filtro).Select(select).ToList();
            }
        }

        /// <summary>
        /// Trae una entidad por su identificador
        /// </summary>
        /// <typeparam name="TEntity">Tipo de Entidad</typeparam>
        /// <param name="id">Identificador de registro de la entidad</param>
        /// <returns>Entidad Consultada</returns>
        public static TEntity GetById<TEntity>(int id) where TEntity : class
        {
            using (App.Entities.ACNUREntities contexto = new App.Entities.ACNUREntities())
            {
                System.Data.Entity.DbSet<TEntity> objectSet = contexto.Set<TEntity>();
                return objectSet.Find(id);
            }
        }

        /// <summary>
        /// Actualiza un objeto entidad
        /// </summary>
        /// <typeparam name="TEntity">Tipo de la entidad</typeparam>
        /// <param name="entity">Entidad para actualizar</param>
        /// <returns>Resultado de la accion</returns>
        ////[AuditLog(AuditEnumerators.Update)]
        public static bool Update<TEntity>(TEntity entity) where TEntity : class
        {
            using (App.Entities.ACNUREntities contexto = new App.Entities.ACNUREntities())
            {
                DbEntityEntry entry = contexto.Entry(entity);
                if (entry.State == System.Data.Entity.EntityState.Detached)
                {
                    contexto.Set<TEntity>().Attach(entity);
                }

                entry.State = System.Data.Entity.EntityState.Modified;
                contexto.SaveChanges();
            }

            return true;
        }

        /// <summary>
        /// Adiciona una entidad al repositorio
        /// </summary>
        /// <typeparam name="TEntity">Tipo de la entidad</typeparam>
        /// <param name="entity">Entidad a adicionar</param>
        /// <returns>Resultado de la accion</returns>
        ////[AuditLog(AuditEnumerators.Add)]
        public static bool Add<TEntity>(TEntity entity) where TEntity : class
        {
            using (App.Entities.ACNUREntities contexto = new App.Entities.ACNUREntities())
            {
                contexto.Set<TEntity>().Add(entity);
                contexto.SaveChanges();
            }

            return true;
        }

        /// <summary>
        /// Marca una entidad para ser eliminada fisicamente dentro del repositorio
        /// </summary>
        /// <typeparam name="TEntity">Tipo de la entidad</typeparam>
        /// <param name="entity">Entidad a eliminar</param>
        /// <returns>Resultado de la accion</returns>
        ////[AuditLog(AuditEnumerators.Delete)]
        public static bool Delete<TEntity>(TEntity entity) where TEntity : class
        {
            using (App.Entities.ACNUREntities contexto = new App.Entities.ACNUREntities())
            {
                contexto.Entry<TEntity>(entity).State = System.Data.Entity.EntityState.Deleted;
                contexto.SaveChanges();
            }

            return true;
        }

        /// <summary>
        /// Activa un objeto entidad
        /// </summary>
        /// <typeparam name="TEntity">Tipo de la entidad</typeparam>
        /// <param name="entity">Entidad a activar</param>
        /// <param name="criteria">Expresion Lambda para identificar las entitidades a activar</param>
        /// <returns>Resultado de la accion</returns>
        public static bool Activate<TEntity>(TEntity entity, Expression<Func<TEntity, bool>> criteria) where TEntity : class
        {
            RepositoryData.ChangeStatus((TEntity)entity, true);
            return RepositoryData.IsDuplicate<TEntity>(criteria) ? false : RepositoryData.Update(entity);
        }

        /// <summary>
        /// Compara un objeto entidad
        /// </summary>
        /// <typeparam name="TEntity">Tipo de la entidad</typeparam>
        /// <param name="entity">Entidad a comparar</param>
        /// <param name="id">Identificador del registro a comparar</param>
        /// <returns>Resultado de la accion</returns>
        public static bool Compare<TEntity>(TEntity entity, int id) where TEntity : class
        {
            using (App.Entities.ACNUREntities contexto = new App.Entities.ACNUREntities())
            {
                System.Data.Entity.DbSet<TEntity> entitySet = contexto.Set<TEntity>();
                TEntity entityBD = entitySet.Find(id);

                var propsBD = entityBD.GetType().GetProperties();

                foreach (var propBD in propsBD)
                {
                    if (!propBD.Name.Equals("UsuarioCreacion") || !propBD.Name.Equals("FechaCreacion") || !propBD.Name.Equals("UsuarioModificacion") || !propBD.Name.Equals("FechaModificacion"))
                    {
                        var props = entityBD.GetType().GetProperties();

                        foreach (var prop in props)
                        {
                            if (prop.Name.Equals(propBD.Name))
                            {
                                if (prop.GetValue(entity, null).Equals(propBD.GetValue(entityBD, null)))
                                {
                                    break;
                                }
                                else
                                {
                                    return false;
                                }
                            }
                        }
                    }
                }
            }

            return true;
        }

        /// <summary>
        /// Verifica si ya existeun objeto entidad en BD
        /// </summary>
        /// <typeparam name="TEntity">Tipo de la entidad</typeparam>
        /// <param name="criteria">Expresion Lambda para identificar las entitidades a buscar</param>
        /// <returns>Resultado de la accion</returns>
        public static bool IsDuplicate<TEntity>(Expression<Func<TEntity, bool>> criteria) where TEntity : class
        {
            List<TEntity> list = RepositoryData.Search<TEntity>(criteria, false);
            return (list == null || list.Count == 0) ? false : true;
        }

        /// <summary>
        /// Obtiene el siguiente Id de una entidad
        /// </summary>
        /// <typeparam name="TEntity">Tipo de la entidad</typeparam>
        /// <param name="criteria">Expresion Lambda para identificar el Id de la entidad</param>
        /// <returns>Siguiente Id</returns>
        public static int NextId<TEntity>(Expression<Func<TEntity, int>> criteria) where TEntity : class
        {
            using (App.Entities.ACNUREntities contexto = new App.Entities.ACNUREntities())
            {
                return contexto.Set<TEntity>().OrderByDescending(criteria).Select(criteria).FirstOrDefault() + 1;
            }
        }

        /// <summary>
        /// Cambia el estado de una entidad
        /// </summary>
        /// <typeparam name="TEntity">Tipo de la entidad</typeparam>
        /// <param name="entity">Entidad a modificar</param>
        /// <param name="state">Estado al que cambia la entidad</param>
        /// <returns>Entidad con el nuevo estado</returns>
        public static TEntity ChangeStatus<TEntity>(TEntity entity, bool state) where TEntity : class
        {
            var props = entity.GetType().GetProperties();

            foreach (var prop in props)
            {
                if (prop.Name.Equals("Estado"))
                {
                    prop.SetValue(entity, state, null);
                }

                if (prop.Name.Equals("Activo"))
                {
                    prop.SetValue(entity, state, null);
                }

                if (prop.Name.Equals("Active"))
                {
                    prop.SetValue(entity, state, null);
                }
            }

            return entity;
        }

        #endregion "Metodos Public Static"

        #region "Metodos Publicos"

        /// <summary>
        /// Returna las entidades de un tipo dado, basado en una expresion lambda
        /// </summary>
        /// <typeparam name="TEntity">Tipo de la entidad</typeparam>
        /// <param name="criteria">Expresion Lambda para la busqueda</param>
        /// <param name="lazyLoad">Tipo de consulta</param>
        /// <param name="navigationChildren">Entidades hijas que se incluiran como parte del resultado</param>
        /// <returns>Collecion de Entidades</returns>
        public List<TEntity> FindTransaction<TEntity>(Expression<Func<TEntity, bool>> criteria, bool lazyLoad, params string[] navigationChildren) where TEntity : class
        {
            System.Data.Entity.DbSet<TEntity> entity = this.ContextTransaction.Set<TEntity>();

            if (lazyLoad == true)
            {
                return GetProperties<TEntity>().Aggregate<string, System.Data.Entity.Infrastructure.DbQuery<TEntity>>(entity, (current, child) => current.Include(child)).Where(criteria).ToList();
            }
            else if (navigationChildren == null || navigationChildren.Length == 0)
            {
                return entity.Where(criteria).ToList();
            }
            else
            {
                return navigationChildren.Aggregate<string, System.Data.Entity.Infrastructure.DbQuery<TEntity>>(entity, (current, child) => current.Include(child)).Where(criteria).ToList();
            }
        }

        /// <summary>
        /// Actualiza un objeto entidad
        /// </summary>
        /// <typeparam name="TEntity">Tipo de la entidad</typeparam>
        /// <param name="entity">Entidad para actualizar</param>
        /// <returns>Resultado de la accion</returns>
        ////[AuditLog(AuditEnumerators.Update)]
        public bool UpdateTransaction<TEntity>(TEntity entity) where TEntity : class
        {
            DbEntityEntry entry = this.ContextTransaction.Entry(entity);
            if (entry.State == System.Data.Entity.EntityState.Detached)
            {
                this.ContextTransaction.Set<TEntity>().Attach(entity);
            }

            entry.State = System.Data.Entity.EntityState.Modified;

            return true;
        }

        /// <summary>
        /// Adiciona una entidad al repositorio
        /// </summary>
        /// <typeparam name="TEntity">Tipo de la entidad</typeparam>
        /// <param name="entity">Entidad a adicionar</param>
        /// <returns>Resultado de la accion</returns>
        ////[AuditLog(AuditEnumerators.Add)]
        public bool AddTransaction<TEntity>(TEntity entity) where TEntity : class
        {
            this.ContextTransaction.Set<TEntity>().Add(entity);
            return true;
        }

        /// <summary>
        /// Marca una entidad para ser eliminada fisicamente dentro del repositorio
        /// </summary>
        /// <typeparam name="TEntity">Tipo de la entidad</typeparam>
        /// <param name="entity">Entidad a eliminar</param>
        /// <returns>Resultado de la accion</returns>
        ////[AuditLog(AuditEnumerators.Delete)]
        public bool DeleteTransaction<TEntity>(TEntity entity) where TEntity : class
        {
            this.ContextTransaction.Entry<TEntity>(entity).State = System.Data.Entity.EntityState.Deleted;
            return true;
        }

        /// <summary>
        /// Guarda la información como una transacción
        /// </summary>
        /// <returns>Resultado de la accion si todo queda bien</returns>
        ////[AuditLog(AuditEnumerators.CommitTransaction)]
        public bool CommitTransaction()
        {
            this.ContextTransaction.SaveChanges();
            return true;
        }

        /// <summary>
        /// Libera los recursos de contexto y alcance
        /// </summary>
        public void Dispose()
        {
            this.Dispose(true);
        }

        #endregion "Metodos Publicos"

        #region "Metodos Protected"

        /// <summary>
        /// Libero el contexto y la transaccion abierta
        /// </summary>
        /// <param name="dispossing">Indica si se debe o no liberar recursos</param>
        protected virtual void Dispose(bool dispossing)
        {
            if (dispossing && this.ContextTransaction != null)
            {
                this.ContextTransaction.Dispose();
            }
        }

        #endregion "Metodos Protected"

        #region "Metodos Privados Estaticos"

        /// <summary>
        /// Obtiene un arreglo con las propiedades de navegacion de la entidad
        /// </summary>
        /// <typeparam name="TEntity">Entidad a evaluar</typeparam>
        /// <returns>Arreglo con las propiedades de navegacion de la entidad</returns>
        private static string[] GetProperties<TEntity>() where TEntity : class
        {
            ArrayList children = new ArrayList();

            var props = typeof(TEntity).GetProperties();
            foreach (var prop in props)
            {
                if ((prop.PropertyType.IsClass && !prop.PropertyType.IsArray && prop.PropertyType.Name != "String") || prop.PropertyType.Name.Contains("ICollection"))
                {
                    children.Add(prop.Name);
                }
            }

            return (string[])children.ToArray(typeof(string));
        }

        #endregion "Metodos Privados Estaticos"
    }
}

