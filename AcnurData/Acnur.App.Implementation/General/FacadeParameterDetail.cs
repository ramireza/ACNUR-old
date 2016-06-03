// ***********************************************************************
// Assembly         : Acnur.App.Implementation
// Author           : Mauricio Ospina - Cel: 3204958448 - ambrosio.mauro@gmail.com
// Created          : 05-11-2015
//
// Last Modified By : Mauricio Ospina
// Last Modified On : 05-11-2015
// ***********************************************************************
// <copyright file="FacadeParameterDetail.cs" company="Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR">
//     Este producto fue desarrollado para Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR. Todos los derechos reservados.
// </copyright>
// <summary>Clase que define los métodos utilizados por Detalle Parámetro.</summary>
// ***********************************************************************

namespace Acnur.App.Implementation
{
    using System.Collections.Generic;
    using System.Linq;
    using Acnur.App.Aplication.Enumerators;
    using Acnur.App.Interfaces;
    using Acnur.App.Entities;
    using Acnur.App.Repository;

    public class FacadeParameterDetail : FacadeGeneric<ParameterDetail>, IFacadeParameterDetail
    {
        /// <summary>
        /// Trae la lista de detalle parámetros x el tipo de parámetro. Para ser cargado en la operación. Por esta razón carga los activos.
        /// </summary>
        /// <param name="parameter">tipo de parámetro.</param>
        /// <returns>Lista de ParameterDetail.</returns>
        public List<ParameterDetail> GetParameterDetailsByParameter(TypeParameter parameter)
        {
            int idParametro = (int)parameter;
            return RepositoryData.Search<ParameterDetail>(det => det.IdParameter == idParametro && det.Active, false, null).OrderBy(det => det.Name).ToList();
        }

        /// <summary>
        /// Trae la lista de detalle parámetros x el tipo de parámetro y el id detalleparametro padre.
        /// </summary>
        /// <param name="parameter">tipo de parámetro.</param>
        /// <param name="idParameterDetailFather">The identifier parameter detail father.</param>
        /// <returns>Lista de DetalleParametro.</returns>
        public List<ParameterDetail> GetDetailParameterByParameterDetailFather(TypeParameter parameter, int idParameterDetailFather)
        {
            int idParametro = (int)parameter;
            List<ParameterDetail> funcionesRetorno = RepositoryData.Search<ParameterDetail>(det => det.IdParameter == idParametro && det.IdParameterDetailFather == idParameterDetailFather, false, null);
            return funcionesRetorno;
        }
    }
}
