// ***********************************************************************
// Assembly         : Defensoria.Sisat.Proxy
// Author           : Mauricio Ospina - Cel: 3204958448 - ambrosio.mauro@gmail.com
// Created          : 19-10-2015
//
// Last Modified By : Mauricio Ospina
// Last Modified On : 05-14-2016
// ***********************************************************************
// <copyright file="ClienteGenerico.cs" company="Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR">
//     Este producto fue desarrollado para Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR. Todos los derechos reservados.
// </copyright>
// <summary>Proxy de servicios genericos para operaciones basicas de entidades</summary>
// ***********************************************************************

namespace Acnur.App.Proxy
{
    using System;
    using System.Collections.Generic;
    using System.ServiceModel;
    using System.ServiceModel.Channels;
    using System.ServiceModel.Configuration;
    using Acnur.App.Aplication.Error;
    using Acnur.App.Aplication.Enumerators;
    using Acnur.App.Interfaces;

    /// <summary>
    /// Clase Cliente que consume los servicios genericos
    /// </summary>
    /// <typeparam name="TService">Contrato de servicio a consumir</typeparam>
    /// <typeparam name="TEntity">Entidad que recibe y retorna el servicio</typeparam>
    /// <seealso cref="System.IDisposable" />
    /// <seealso cref="Acnur.App.Interfaces.IFacadeGeneric{TEntity}" />
    public abstract class CustomerGenericFacade<TService, TEntity> : IDisposable, IFacadeGeneric<TEntity>
            where TService : class
            where TEntity : class, new()
    {
        #region Propiedades

        /// <summary>
        /// Channel del cliente que consume los servicios
        /// </summary>
        /// <value>The channel.</value>
        protected TService Channel
        {
            get
            {
                return this.channel;
            }
        }

        #endregion

        #region Atributos

        /// <summary>
        /// Atributo que sirve para realizar mapeada del servicio
        /// </summary>
        private TService channel;

        /// <summary>
        /// Atributo que sirve para realizar sincronización del servicio
        /// </summary>
        public readonly static object sync = new object();

        #endregion

        #region Constructores y Destructores

        /// <summary>
        /// Constructor Cliente
        /// </summary>
        protected CustomerGenericFacade()
        {
            string assembly = "Acnur.App.Implementation";
            string nombre = assembly + "." + typeof(TService).Name.Substring(1);

            this.channel = (TService)Activator.CreateInstance(assembly, nombre).Unwrap();
        }

        /// <summary>
        /// Finalizes an instance of the GenericClientBase class.
        /// </summary>
        ~CustomerGenericFacade()
        {
        }

        #endregion

        #region IDisposable

        /// <summary>
        /// Metodo para hacer Dispose del Canal
        /// </summary>
        public void Dispose()
        {
        }

        #endregion

        #region Métodos Públicos

        /// <summary>
        /// Método que devuelve toda la colección de entidades de tipo TabFuncion que se encuentran registradas.
        /// </summary>
        /// <param name="lazyLoad">Tipo de consulta</param>
        /// <param name="children">Entidades hijas a incluir</param>
        /// <returns>Colección de entidades de tipo TabFuncion que se encuentran registradas.</returns>
        public IList<TEntity> GetAll(bool lazyLoad, params string[] children)
        {
            IFacadeGeneric<TEntity> canal = (IFacadeGeneric<TEntity>)this.Channel;
            return canal.GetAll(lazyLoad, children);
        }

        /// <summary>
        /// Searches the specified criteria.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <param name="lazyLoad">if set to <c>true</c> [lazy load].</param>
        /// <param name="children">The children.</param>
        /// <returns>IList&lt;TEntity&gt;.</returns>
        public IList<TEntity> Search(System.Linq.Expressions.Expression<Func<TEntity, bool>> criteria, bool lazyLoad, params string[] children)
        {
            IFacadeGeneric<TEntity> canal = (IFacadeGeneric<TEntity>)this.Channel;
            return canal.Search(criteria, lazyLoad, children);
        }

        /// <summary>
        /// Método que realiza el registro de una nueva entidad de tipo TabFuncion.
        /// </summary>
        /// <param name="entity">Entidad que se va a ingresar.</param>
        /// <returns>Valor booleano. True si la registro se pudo realizar. De lo contrario False.</returns>
        public TEntity Add(TEntity entity)
        {
            IFacadeGeneric<TEntity> canal = (IFacadeGeneric<TEntity>)this.Channel;
            return canal.Add(entity);
        }

        /// <summary>
        /// Método que realiza el registro de los cambios de la entidad de tipo TabFuncion.
        /// </summary>
        /// <param name="entity">Entidad que se va a actualizar.</param>
        /// <returns>Valor booleano. True si la actualización se pudo realizar. De lo contrario False.</returns>
        public bool Update(TEntity entity)
        {
            IFacadeGeneric<TEntity> canal = (IFacadeGeneric<TEntity>)this.Channel;
            return canal.Update(entity);
        }

        /// <summary>
        /// Método que devuelve la entidad que tiene asociada al identificador especificado.
        /// </summary>
        /// <param name="id">Identificador la entidad que se quiere devolver.</param>
        /// <returns>Entidad que tiene asociada al identificador especificado.</returns>
        public TEntity GetByID(int id)
        {
            IFacadeGeneric<TEntity> canal = (IFacadeGeneric<TEntity>)this.Channel;
            return canal.GetByID(id);
        }

        /// <summary>
        /// Método que elimina la entidad que tiene asociada al identificador especificado.
        /// </summary>
        /// <param name="id">Identificador la entidad que se quiere eliminar.</param>
        /// <returns>Valor booleano. True si la eliminación se pudo realizar. De lo contrario False.</returns>
        public bool Delete(int id)
        {
            IFacadeGeneric<TEntity> canal = (IFacadeGeneric<TEntity>)this.Channel;
            return canal.Delete(id);
        }

        /// <summary>
        /// Método que inactiva la entidad que tiene asociada al identificador especificado.
        /// </summary>
        /// <param name="id">Identificador la entidad que se quiere inactivar.</param>
        /// <returns>Valor booleano. True si la inactivación se pudo realizar. De lo contrario False.</returns>
        public bool Inactivate(int id)
        {
            IFacadeGeneric<TEntity> canal = (IFacadeGeneric<TEntity>)this.Channel;
            return canal.Inactivate(id);
        }

        /// <summary>
        /// Método que inactiva la entidad que tiene asociada al identificador especificado.
        /// </summary>
        /// <param name="id">Identificador la entidad que se quiere inactivar.</param>
        /// <returns>Valor booleano. True si la inactivación se pudo realizar. De lo contrario False.</returns>
        public bool Activate(int id)
        {
            IFacadeGeneric<TEntity> canal = (IFacadeGeneric<TEntity>)this.Channel;
            return canal.Activate(id);
        }

        /// <summary>
        /// Campara 2 entidades de tipo TabUsuario.
        /// </summary>
        /// <param name="entity">Entidad a comparar.</param>
        /// <param name="id">Identificador para la entidad a ser comparada.</param>
        /// <returns>Valor booleano. True si son iguales. De lo contrario False.</returns>
        public bool Compare(TEntity entity, int id)
        {
            IFacadeGeneric<TEntity> canal = (IFacadeGeneric<TEntity>)this.Channel;
            return canal.Compare(entity, id);
        }

        #endregion        
    }
}
