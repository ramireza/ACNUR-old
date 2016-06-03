// ***********************************************************************
// Assembly         : Acnur.App.Proxy
// Author           : Mauricio Ospina - Cel: 3204958448 - ambrosio.mauro@gmail.com
// Created          : 03-17-2016
//
// Last Modified By : Mauricio Ospina
// Last Modified On : 04-23-2016
// ***********************************************************************
// <copyright file="CustomerModules.cs" company="Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR">
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
    /// Class CustomerModules.
    /// </summary>
    /// <seealso cref="Acnur.App.Proxy.CustomerGenericFacade{Acnur.App.Interfaces.IFacadeModules,Acnur.App.Entities.Modules}" />
    /// <seealso cref="Acnur.App.Interfaces.IFacadeModules" />
    public class CustomerModules : CustomerGenericFacade<IFacadeModules, Modules>, IFacadeModules
    {
        /// <summary>
        /// Gets the modules by user.
        /// </summary>
        /// <param name="userName">Name of the user.</param>
        /// <returns>List of Modules.</returns>
        public List<Modules> GetModulesByUser(string userName)
        {
            return this.Channel.GetModulesByUser(userName);
        }
    }
}
