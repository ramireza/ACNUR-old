// ***********************************************************************
// Assembly         : Acnur.App.Contratos
// Author           : Mauricio Ospina - Cel: 3204958448 - ambrosio.mauro@gmail.com
// Created          : 19-10-2015
//
// Last Modified By : Mauricio Ospina
// Last Modified On : 19-10-2015
// ***********************************************************************
// <copyright file="IFacadeGenerico.cs" company="Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR">
//     Este producto fue desarrollado para Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR. Todos los derechos reservados.
// </copyright>
// <summary>Interface que define los métodos genéricos utilizados por la lógica de negocios.</summary>
// ***********************************************************************

namespace Acnur.App.Interfaces
{
    using System;
    using System.Collections.Generic;
    using System.Linq.Expressions;
    using System.ServiceModel;

    [ServiceContract]
    public interface IFacadeGeneric<TEntity> where TEntity : class
    {
        /// <summary>
        /// Método que devuelve todos los registros de la entidad especificada.
        /// </summary>
        /// <param name="lazyLoad">Tipo de consulta</param>
        /// <param name="children">Entidades hijas a incluir</param>
        /// <returns>Colección de las entidades del tipo especificado.</returns>
        [OperationContract]
        IList<TEntity> GetAll(bool lazyLoad, params string[] children);

        /// <summary>
        /// Searches the specified criteria.
        /// </summary>
        /// <param name="criteria">The criteria.</param>
        /// <param name="lazyLoad">if set to <c>true</c> [lazy load].</param>
        /// <param name="children">The children.</param>
        /// <returns>IList&lt;TEntity&gt;.</returns>
        [OperationContract]
        IList<TEntity> Search(Expression<Func<TEntity, bool>> criteria, bool lazyLoad, params string[] children);

        /// <summary>
        /// Método que realiza ingreso de la entidad especificada.
        /// </summary>
        /// <param name="entity">Entidad que se va a ingresar.</param>
        /// <returns>Valor booleano. True si la registro se pudo realizar. De lo contrario False.</returns>
        [OperationContract]
        TEntity Add(TEntity entity);

        /// <summary>
        /// Método que realiza el registro de los cambios de la entidad especificada
        /// </summary>
        /// <param name="entity">Entidad que se va a actualizar.</param>
        /// <returns>Valor booleano. True si la actualización se pudo realizar. De lo contrario False.</returns>
        [OperationContract]
        bool Update(TEntity entity);

        /// <summary>
        /// Método que devuelve la entidad que tiene asociada al identificador especificado.
        /// </summary>
        /// <param name="id">Identificador la entidad que se quiere devolver.</param>
        /// <returns>Entidad que tiene asociada al identificador especificado.</returns>
        [OperationContract]
        TEntity GetByID(int id);

        /// <summary>
        /// Método que elimina la entidad que tiene asociada al identificador especificado.
        /// </summary>
        /// <param name="id">Identificador la entidad que se quiere eliminar.</param>
        /// <returns>Valor booleano. True si la eliminación se pudo realizar. De lo contrario False.</returns>
        [OperationContract]
        bool Delete(int id);

        /// <summary>
        /// Método que inactiva la entidad que tiene asociada al identificador especificado.
        /// </summary>
        /// <param name="id">Identificador la entidad que se quiere inactivar.</param>
        /// <returns>Valor booleano. True si la inactivación se pudo realizar. De lo contrario False.</returns>
        [OperationContract]
        bool Inactivate(int id);

        /// <summary>
        /// Método que Activa la entidad que tiene asociada al identificador especificado.
        /// </summary>
        /// <param name="id">Identificador la entidad que se quiere Activar.</param>
        /// <returns>Valor booleano. True si la Activación se pudo realizar. De lo contrario False.</returns>
        [OperationContract]
        bool Activate(int id);

        /// <summary>
        /// Campara 2 entidades del tipo especificado.
        /// </summary>
        /// <param name="entity">Entidad a comparar.</param>
        /// <param name="id">Identificador para la entidad de BD a ser comparada.</param>
        /// <returns>Valor booleano. True si son iguales. De lo contrario False.</returns>
        [OperationContract]
        bool Compare(TEntity entity, int id);
    }
}
