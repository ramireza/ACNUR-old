// ***********************************************************************
// Assembly         : Acnur.App.Proxy
// Author           : Mauricio Ospina - Cel: 3204958448 - ambrosio.mauro@gmail.com
// Created          : 23-10-2015
//
// Last Modified By : Mauricio Ospina
// Last Modified On : 23-10-2015
// ***********************************************************************
// <copyright file="ClienteParameterDetail.cs" company="Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR">
//     Este producto fue desarrollado para Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR. Todos los derechos reservados.
// </copyright>
// <summary>Proxy del Servicio de Detalle Parámetro</summary>
// ***********************************************************************

namespace Acnur.App.Proxy
{
    using Acnur.App.Aplication.Enumerators;
    using Acnur.App.Entities;
    using Acnur.App.Interfaces;
    using System.Collections.Generic;

    public class CustomerParameterDetail : CustomerGenericFacade<IFacadeParameterDetail, ParameterDetail>, IFacadeParameterDetail
    {
        /// <summary>
        /// Trae la lista de detalle parámetros x el tipo de parámetro. 
        /// Para ser cargado en la operación. Por esta razón carga los activos.
        /// </summary>
        /// <param name="parametro">tipo de parámetro.</param>
        /// <returns>Lista de ParameterDetail.</returns>
        public List<ParameterDetail> GetParameterDetailsByParameter(TypeParameter parametro)
        {
            return this.Channel.GetParameterDetailsByParameter(parametro);
        }

        /// <summary>
        /// Trae la lista de detalle parámetros x el tipo de parámetro.
        /// </summary>
        /// <param name="parametro">tipo de parámetro.</param>
        /// <param name="detalle parametro padre">detalle parametro padre.</param>
        /// <returns>Lista de DetalleParametro.</returns>
        public List<ParameterDetail> GetDetailParameterByParameterDetailFather(TypeParameter parametro, int idDetalleParametroPadre)
        {
            return this.Channel.GetDetailParameterByParameterDetailFather(parametro, idDetalleParametroPadre);
        }
    }
}
