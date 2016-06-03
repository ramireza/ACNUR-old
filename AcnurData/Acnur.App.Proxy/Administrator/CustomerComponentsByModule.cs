// ***********************************************************************
// Assembly         : Acnur.App.Proxy
// Author           : Mauricio Ospina - Cel: 3204958448 - ambrosio.mauro@gmail.com
// Created          : 04-30-2016
//
// Last Modified By : Mauricio Ospina - Cel: 3204958448 - ambrosio.mauro@gmail.com
// Last Modified On : 04-30-2016
// ***********************************************************************
// <copyright file="CustomerComponentsByModule.cs" company="Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR">
//     Copyright © Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR 2015
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Acnur.App.Proxy
{
    using Acnur.App.Interfaces;
    using Acnur.App.Entities;
    using System.Collections.Generic;

    /// <summary>
    /// Class CustomerComponentsByModule.
    /// </summary>
    /// <seealso cref="Acnur.App.Proxy.CustomerGenericFacade{Acnur.App.Interfaces.IFacadeComponentsByModule,Acnur.App.Entities.ComponentsByModule}" />
    /// <seealso cref="Acnur.App.Interfaces.IFacadeComponentsByModule" />
    public class CustomerComponentsByModule : CustomerGenericFacade<IFacadeComponentsByModule, ComponentsByModule>, IFacadeComponentsByModule
    {
        /// <summary>
        /// Gets the name of the identifier components by module by component name and module.
        /// </summary>
        /// <param name="NameComponent">The name component.</param>
        /// <param name="NameModule">The name module.</param>
        /// <returns>System.Int32.</returns>
        public int GetIdComponentsByModuleByComponentNameAndModuleName(string NameComponent, string NameModule)
        {
            return this.Channel.GetIdComponentsByModuleByComponentNameAndModuleName(NameComponent, NameModule);
        }
    }
}
