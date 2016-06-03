// ***********************************************************************
// Assembly         : Acnur.App.Interfaces
// Author           : Mauricio Ospina - Cel: 3204958448 - ambrosio.mauro@gmail.com
// Created          : 04-16-2016
//
// Last Modified By : Mauricio Ospina
// Last Modified On : 04-23-2016
// ***********************************************************************
// <copyright file="IFacadeAttachments.cs" company="Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR">
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
    /// Interface IFacadeAttachments
    /// </summary>
    /// <seealso cref="Acnur.App.Interfaces.IFacadeGeneric{Acnur.App.Entities.Attachments}" />
    [ServiceContract]
    public interface IFacadeAttachments : IFacadeGeneric<Attachments>
    {
        /// <summary>
        /// Gets the attachments by identifier module.
        /// </summary>
        /// <param name="IdModule">The identifier module.</param>
        /// <param name="IdRegister">The identifier register.</param>
        /// <returns>List Attachments.</returns>
        [OperationContract]
        List<Attachments> GetAttachmentsByIdModule(int IdModule, int IdRegister);

        /// <summary>
        /// Removes the files current.
        /// </summary>
        /// <param name="idComponentByModule">The identifier component by module.</param>
        /// <param name="idInformation">The identifier information.</param>
        [OperationContract]
        void RemoveFilesCurrent(int idComponentByModule, int idInformation);
    }
}
