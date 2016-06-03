// ***********************************************************************
// Assembly         : Acnur.App.Interfaces
// Author           : Mauricio Ospina - Cel: 3204958448 - ambrosio.mauro@gmail.com
// Created          : 03-15-2016
//
// Last Modified By : Mauricio Ospina
// Last Modified On : 03-15-2016
// ***********************************************************************
// <copyright file="IFacadeModules.cs" company="Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR">
//     Copyright © Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR 2015
// </copyright>
// <summary></summary>
// ***********************************************************************

/// <summary>
/// The Interfaces namespace.
/// </summary>
namespace Acnur.App.Interfaces
{
    using Acnur.App.Entities;
    using System.Collections.Generic;
    using System.ServiceModel;

    /// <summary>
    /// Interface IFacadeModules
    /// </summary>
    [ServiceContract]
    public interface IFacadeModules : IFacadeGeneric<Modules>
    {
        /// <summary>
        /// Gets the modules by user.
        /// </summary>
        /// <param name="userName">Name of the user.</param>
        /// <returns>List of Modules.</returns>
        [OperationContract]
        List<Modules> GetModulesByUser(string userName);
    }
}
