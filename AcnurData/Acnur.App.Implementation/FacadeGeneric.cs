namespace Acnur.App.Implementation
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using Acnur.App.Interfaces;
    using Acnur.App.Repository;

    /// <summary>
    /// Métodos genéricos utilizados por la lógica de negocios.
    /// </summary>
    /// <typeparam name="TEntity">Tipo de la entidad que va a ser procesada por la el método.</typeparam>
    public class FacadeGeneric<TEntity> : IFacadeGeneric<TEntity> where TEntity : class
    {
        /// <summary>
        /// Método que devuelve todos los registros de la entidad especificada.
        /// </summary>
        /// <param name="lazyLoad">Tipo de consulta</param>
        /// <param name="children">Entidades hijas a incluir</param>
        /// <returns>Colección de las entidades del tipo especificado.</returns>
        public IList<TEntity> GetAll(bool lazyLoad, params string[] children)
        {
            return RepositoryData.GetAll<TEntity>(lazyLoad, children);
        }

        /// <summary>
        /// Searches the specified criteria.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <param name="lazyLoad">if set to <c>true</c> [lazy load].</param>
        /// <param name="children">The children.</param>
        /// <returns>IList&lt;TEntity&gt;.</returns>
        public IList<TEntity> Search(Expression<Func<TEntity, bool>> criteria, bool lazyLoad, params string[] children)
        {
            return RepositoryData.Search<TEntity>(criteria, lazyLoad, children);
        }

        /// <summary>
        /// Adiciona una entidad al repositorio
        /// </summary>
        /// <param name="entity">Entidad a adicionar</param>
        /// <returns>Resultado de la acción</returns>
        public TEntity Add(TEntity entity)
        {
            RepositoryData.Add(entity);
            return entity;
        }

        /// <summary>
        /// Actualiza un objeto entidad
        /// </summary>
        /// <param name="entity">Entidad para actualizar</param>
        /// <returns>Resultado de la acción</returns>
        public bool Update(TEntity entity)
        {
            return RepositoryData.Update(entity);
        }

        /// <summary>
        /// Método que devuelve la entidad que tiene asociada al identificador especificado.
        /// </summary>
        /// <param name="id">Identificador la entidad que se quiere devolver.</param>
        /// <returns>Entidad que tiene asociada al identificador especificado.</returns>
        public TEntity GetByID(int id)
        {
            return RepositoryData.GetById<TEntity>(id);
        }

        /// <summary>
        /// Método que elimina la entidad que tiene asociada al identificador especificado.
        /// </summary>
        /// <param name="id">Identificador la entidad que se quiere eliminar.</param>
        /// <returns>Valor booleano. True si la eliminación se pudo realizar. De lo contrario False.</returns>
        public bool Delete(int id)
        {
            TEntity entidad = this.GetByID(id);
            return this.Eliminar(entidad);
        }

        /// <summary>
        /// Marca una entidad para ser eliminada físicamente dentro del repositorio
        /// </summary>
        /// <param name="entidad">Entidad a eliminar</param>
        /// <returns>Resultado de la acción</returns>
        public bool Eliminar(TEntity entidad)
        {
            return RepositoryData.Delete(entidad);
        }

        /// <summary>
        /// Método que inactiva la entidad que tiene asociada al identificador especificado.
        /// </summary>
        /// <param name="id">Identificador la entidad que se quiere inactivar.</param>
        /// <returns>Valor booleano. True si la inactivación se pudo realizar. De lo contrario False.</returns>
        public bool Inactivate(int id)
        {
            TEntity entity = this.GetByID(id);
            RepositoryData.ChangeStatus(entity, false);
            this.Update(entity);
            return true;
        }

        /// <summary>
        /// Método que Aciva la entidad que tiene asociada al identificador especificado.
        /// </summary>
        /// <param name="id">Identificador la entidad que se quiere Activar.</param>
        /// <returns>Valor booleano. True si la Activación se pudo realizar. De lo contrario False.</returns>
        public bool Activate(int id)
        {
            TEntity entity = this.GetByID(id);
            RepositoryData.ChangeStatus(entity, true);
            this.Update(entity);
            return true;
        }

        /// <summary>
        /// Compara un objeto entidad
        /// </summary>
        /// <param name="entity">Entidad a comparar</param>
        /// <param name="id">Identificador de la entidad del tipo especificado que va a ser comparada</param>
        /// <returns>Resultado de la accion</returns>
        public bool Compare(TEntity entity, int id)
        {
            return RepositoryData.Compare(entity, id);
        }

        /// <summary>
        /// Actualiza un objeto entidad
        /// </summary>
        /// <param name="criteria">Expresion Lambda para identificar las entitidades a buscar</param>
        /// <param name="entity">Entidad para actualizar</param>
        /// <returns>Resultado de la accion</returns>
        public bool Editar(Expression<Func<TEntity, bool>> criteria, TEntity entity)
        {
            return RepositoryData.IsDuplicate<TEntity>(criteria) == false ? this.Update(entity) : false;
        }

        /// <summary>
        /// Adiciona una entidad al repositorio
        /// </summary>
        /// <param name="criteria">Expresion Lambda para identificar las entitidades a buscar</param>
        /// <param name="entity">Entidad a adicionar</param>
        /// <returns>Resultado de la accion</returns>
        public TEntity Guardar(Expression<Func<TEntity, bool>> criteria, TEntity entity)
        {
            if (!RepositoryData.IsDuplicate<TEntity>(criteria))
            {
                this.Add(entity);
            }
            return entity;
        }

        /// <summary>
        /// Método que devuelve todos los registros de la entidad especificada.
        /// </summary>
        /// <param name="criteria">Criterio de búsqueda</param>
        /// <param name="lazyLoad">Tipo de consulta</param>
        /// <param name="children">Entidades hijas a incluir</param>
        /// <returns>Colección de las entidades del tipo especificado.</returns>
        public IList<TEntity> TraerxCriterio(Expression<Func<TEntity, bool>> criteria, bool lazyLoad, params string[] children)
        {
            return RepositoryData.Search(criteria, lazyLoad, children);
        }
    }
}