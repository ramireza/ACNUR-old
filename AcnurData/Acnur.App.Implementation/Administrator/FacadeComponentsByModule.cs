// ***********************************************************************
// Assembly         : Acnur.App.Implementation
// Author           : Mauricio Ospina - Cel: 3204958448 - ambrosio.mauro@gmail.com
// Created          : 04-30-2016
//
// Last Modified By : Mauricio Ospina - Cel: 3204958448 - ambrosio.mauro@gmail.com
// Last Modified On : 04-30-2016
// ***********************************************************************
// <copyright file="FacadeComponentsByModule.cs" company="Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR">
//     Copyright © Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR 2015
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Acnur.App.Implementation
{
    using Acnur.App.Entities;
    using Acnur.App.Interfaces;
    using Acnur.App.Repository;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Class FacadeComponentsByModule.
    /// </summary>
    /// <seealso cref="Acnur.App.Implementation.FacadeGeneric{Acnur.App.Entities.ComponentsByModule}" />
    /// <seealso cref="Acnur.App.Interfaces.IFacadeComponentsByModule" />
    public class FacadeComponentsByModule : FacadeGeneric<ComponentsByModule>, IFacadeComponentsByModule
    {
        /// <summary>
        /// Gets the name of the identifier components by module by component name and module.
        /// </summary>
        /// <param name="NameComponent">The name component.</param>
        /// <param name="NameModule">The name module.</param>
        /// <returns>System.Int32.</returns>
        public int GetIdComponentsByModuleByComponentNameAndModuleName(string NameComponent, string NameModule)
        {
            int Result = 0;

            List<ComponentsByModule> ListResult = RepositoryData.SearchInclude<ComponentsByModule>(reg => reg.Name.ToLower() == NameComponent.ToLower() && reg.Modules.ModuleName == NameModule, reg => reg.Modules);

            if (ListResult.Count() > 0)
            {
                Result = ListResult.First().IdComponentByModule;
            }

            return Result;
        }
    }
}
