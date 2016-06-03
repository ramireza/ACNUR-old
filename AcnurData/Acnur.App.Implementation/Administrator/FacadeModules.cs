// ***********************************************************************
// Assembly         : Acnur.App.Implementation
// Author           : Mauricio Ospina - Cel: 3204958448 - ambrosio.mauro@gmail.com
// Created          : 03-15-2016
//
// Last Modified By : Mauricio Ospina
// Last Modified On : 04-23-2016
// ***********************************************************************
// <copyright file="FacadeModules.cs" company="Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR">
//     Copyright © Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR 2015
// </copyright>
// <summary></summary>
// ***********************************************************************

/// <summary>
/// The Implementation namespace.
/// </summary>
namespace Acnur.App.Implementation
{
    using Acnur.App.Entities;
    using Acnur.App.Interfaces;
    using Acnur.App.Repository;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Class FacadeModules.
    /// </summary>
    /// <seealso cref="Acnur.App.Implementation.FacadeGeneric{Acnur.App.Entities.Modules}" />
    /// <seealso cref="Acnur.App.Interfaces.IFacadeModules" />
    public class FacadeModules : FacadeGeneric<Modules>, IFacadeModules
    {
        /// <summary>
        /// Gets the modules by user.
        /// </summary>
        /// <param name="userName">Name of the user.</param>
        /// <returns>List of Modules.</returns>
        public List<Modules> GetModulesByUser(string userName)
        {
            List<Modules> ResultList = new List<Modules>();

            List<ModuleUser> ListWithUsers = RepositoryData.SearchInclude<ModuleUser>(mod => mod.Users.UserName.ToLower() == userName.ToLower(), mod => mod.Modules, mod => mod.Users);
            ResultList = ListWithUsers.Select(mod => mod.Modules).Distinct().ToList();

            ResultList = ResultList.Distinct().ToList();

            return ResultList;
        }
    }
}
