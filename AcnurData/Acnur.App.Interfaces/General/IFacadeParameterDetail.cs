// ***********************************************************************
// Assembly         : Acnur.App.Interfaces
// Author           : Mauricio Ospina - Cel: 3204958448 - ambrosio.mauro@gmail.com
// Created          : 23-10-2015
//
// Last Modified By : Mauricio Ospina
// Last Modified On : 23-10-2015
// ***********************************************************************
// <copyright file="IFacadeParameterDetail.cs" company="Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR">
//     Este producto fue desarrollado para Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR. Todos los derechos reservados.
// </copyright>
// <summary>Interface tipo contrato para la clase de la tabla Detalle Parámetro</summary>
// ***********************************************************************

namespace Acnur.App.Interfaces
{
    using Acnur.App.Aplication.Enumerators;
    using Acnur.App.Entities;
    using System.Collections.Generic;
    using System.ServiceModel;

    [ServiceContract]
    public interface IFacadeParameterDetail : IFacadeGeneric<ParameterDetail>
    {
        /// <summary>
        /// Trae la lista de detalle parámetros x el tipo de parámetro.
        /// Para ser cargado en la operación. Por esta razón carga los activos.
        /// </summary>
        /// <param name="parameter">The parameter.</param>
        /// <returns>Lista de ParameterDetail.</returns>
        [OperationContract]
        List<ParameterDetail> GetParameterDetailsByParameter(TypeParameter parameter);

        /// <summary>
        /// Trae la lista de detalle parámetros x el tipo de parámetro.
        /// </summary>
        /// <param name="parameter">The parameter.</param>
        /// <param name="idParameterDetailFather">The identifier parameter detail father.</param>
        /// <returns>Lista de ParameterDetail.</returns>
        [OperationContract]
        List<ParameterDetail> GetDetailParameterByParameterDetailFather(TypeParameter parameter, int idParameterDetailFather);
    }
}
