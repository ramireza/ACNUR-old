// ***********************************************************************
// Assembly         : Acnur.App.Interfaces
// Author           : Mauricio Ospina - Cel: 3204958448 - ambrosio.mauro@gmail.com
// Created          : 12-11-2015
//
// Last Modified By : Mauricio Ospina
// Last Modified On : 12-11-2015
// ***********************************************************************
// <copyright file="IFacadeEmergencia.cs" company="Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR">
//     Este producto fue desarrollado para Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR. Todos los derechos reservados.
// </copyright>
// <summary>Interface tipo contrato para la clase de la tabla que guarda las emergencias</summary>
// ***********************************************************************

namespace Acnur.App.Interfaces
{
    using System.ServiceModel;
    using Acnur.App.Entities;

    [ServiceContract]
    public interface IFacadeEmergency : IFacadeGeneric<GeneralInformationEmergency>
    {

    }
}
