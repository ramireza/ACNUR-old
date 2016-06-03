// ***********************************************************************
// Assembly         : Acnur.App.Implementation
// Author           : Mauricio Ospina - Cel: 3204958448 - ambrosio.mauro@gmail.com
// Created          : 04-16-2016
//
// Last Modified By : Mauricio Ospina
// Last Modified On : 04-30-2016
// ***********************************************************************
// <copyright file="FacadeAttachments.cs" company="Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR">
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

    /// <summary>
    /// Class FacadeAttachments.
    /// </summary>
    /// <seealso cref="Acnur.App.Implementation.FacadeGeneric{Acnur.App.Entities.Attachments}" />
    /// <seealso cref="Acnur.App.Interfaces.IFacadeAttachments" />
    public class FacadeAttachments : FacadeGeneric<Attachments>, IFacadeAttachments
    {
        /// <summary>
        /// Gets the attachments by identifier module.
        /// </summary>
        /// <param name="idComponentByModule">The identifier module.</param>
        /// <param name="idInformation">The identifier register.</param>
        /// <returns>List Attachments.</returns>
        public List<Attachments> GetAttachmentsByIdModule(int idComponentByModule, int idInformation)
        {
            List<Attachments> ResultList = RepositoryData.Search<Attachments>(adj => adj.IdComponentByModule == idComponentByModule && adj.IdInformation == idInformation, false, null);
            return ResultList;
        }

        /// <summary>
        /// Removes the files current.
        /// </summary>
        /// <param name="idComponentByModule">The identifier component by module.</param>
        /// <param name="idInformation">The identifier information.</param>
        public void RemoveFilesCurrent(int idComponentByModule, int idInformation)
        {
            List<Attachments> ResultList = RepositoryData.Search<Attachments>(adj => adj.IdComponentByModule == idComponentByModule && adj.IdInformation == idInformation, false, null);
            ResultList.ForEach(adj => this.Delete(adj.IdAttachment));
        }
    }
}
