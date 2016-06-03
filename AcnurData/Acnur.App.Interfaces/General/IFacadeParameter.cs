// ***********************************************************************
// Assembly         : Acnur.App.Interfaces
// Author           : Mauricio Ospina - Cel: 3204958448 - ambrosio.mauro@gmail.com
// Created          : 04-11-2015
//
// Last Modified By : Mauricio Ospina
// Last Modified On : 12-05-2015
// ***********************************************************************
// <copyright file="IFacadeParametro.cs" company="Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR">
//     Este producto fue desarrollado para Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR. Todos los derechos reservados.
// </copyright>
// <summary>Interface tipo contrato para el servicio de la tabla Parámetro</summary>
// ***********************************************************************

namespace Acnur.App.Interfaces
{
    using Acnur.App.Entities;
    using System.ServiceModel;

    /// <summary>
    /// Interface IFacadeParameter
    /// </summary>
    [ServiceContract]
    public interface IFacadeParameter : IFacadeGeneric<Parameter>
    {
        
    }
}
