// ***********************************************************************
// Assembly         : Acnur.App.Interfaces
// Author           : Mauricio Ospina - Cel: 3204958448 - ambrosio.mauro@gmail.com
// Created          : 04-30-2016
//
// Last Modified By : Mauricio Ospina - Cel: 3204958448 - ambrosio.mauro@gmail.com
// Last Modified On : 04-30-2016
// ***********************************************************************
// <copyright file="IFacadeComponentsByModule.cs" company="Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR">
//     Copyright © Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR 2015
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Acnur.App.Interfaces
{
    using Acnur.App.Entities;
    using System.Collections.Generic;
    using System.ServiceModel;

    /// <summary>
    /// Interface IFacadeComponentsByModule
    /// </summary>
    /// <seealso cref="Acnur.App.Interfaces.IFacadeGeneric{Acnur.App.Entities.ComponentsByModule}" />
    public interface IFacadeComponentsByModule : IFacadeGeneric<ComponentsByModule>
    {
        /// <summary>
        /// Gets the name of the identifier components by module by component name and module.
        /// </summary>
        /// <param name="NameComponent">The name component.</param>
        /// <param name="NameModule">The name module.</param>
        /// <returns>System.Int32.</returns>
        int GetIdComponentsByModuleByComponentNameAndModuleName(string NameComponent, string NameModule);
    }
}
