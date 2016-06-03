// ***********************************************************************
// Assembly         : Acnur.App.Proxy
// Author           : Mauricio Ospina - Cel: 3204958448 - ambrosio.mauro@gmail.com
// Created          : 04-16-2016
//
// Last Modified By : Mauricio Ospina
// Last Modified On : 04-23-2016
// ***********************************************************************
// <copyright file="CustomerAttachments.cs" company="Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR">
//     Copyright © Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR 2015
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Acnur.App.Proxy
{
    using Acnur.App.Entities;
    using Acnur.App.Interfaces;
    using System.Collections.Generic;

    /// <summary>
    /// Class CustomerAttachments.
    /// </summary>
    /// <seealso cref="Acnur.App.Proxy.CustomerGenericFacade{Acnur.App.Interfaces.IFacadeAttachments,Acnur.App.Entities.Attachments}" />
    /// <seealso cref="Acnur.App.Interfaces.IFacadeAttachments" />
    public class CustomerAttachments : CustomerGenericFacade<IFacadeAttachments, Attachments>, IFacadeAttachments
    {
        /// <summary>
        /// Gets the attachments by identifier module.
        /// </summary>
        /// <param name="idModule">The identifier module.</param>
        /// <param name="idRegister">The identifier register.</param>
        /// <returns>System.Collections.Generic.List&lt;Attachments&gt;.</returns>
        public List<Attachments> GetAttachmentsByIdModule(int idModule, int idRegister)
        {
            return this.Channel.GetAttachmentsByIdModule(idModule, idRegister);
        }

        /// <summary>
        /// Removes the files current.
        /// </summary>
        /// <param name="idComponentByModule">The identifier component by module.</param>
        /// <param name="idInformation">The identifier information.</param>
        public void RemoveFilesCurrent(int idComponentByModule, int idInformation)
        {
            this.Channel.RemoveFilesCurrent(idComponentByModule, idInformation);
        }
    }
}
