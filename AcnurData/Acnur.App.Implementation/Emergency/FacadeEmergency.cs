// ***********************************************************************
// Assembly         : Acnur.App.Implementation
// Author           : Mauricio Ospina - Cel: 3204958448 - ambrosio.mauro@gmail.com
// Created          : 12-11-2015
//
// Last Modified By : Mauricio Ospina
// Last Modified On : 12-05-2015
// ***********************************************************************
// <copyright file="FacadeEmergencia.cs" company="Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR">
//     Este producto fue desarrollado para Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR. Todos los derechos reservados.
// </copyright>
// <summary>Clase que define los métodos utilizados por Emergencias.</summary>
// ***********************************************************************

/// <summary>
/// The Implementation namespace.
/// </summary>
namespace Acnur.App.Implementation
{
    using Acnur.App.Entities;
    using Acnur.App.Interfaces;

    /// <summary>
    /// Class FacadeEmergency.
    /// </summary>
    public class FacadeEmergency : FacadeGeneric<GeneralInformationEmergency>, IFacadeEmergency
    {
    }
}
