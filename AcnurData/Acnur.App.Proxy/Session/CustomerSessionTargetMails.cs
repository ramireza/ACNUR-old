// ***********************************************************************
// Assembly         : Acnur.App.Proxy
// Author           : Mauricio Ospina - Cel: 3204958448 - ambrosio.mauro@gmail.com
// Created          : 05-23-2016
//
// Last Modified By : Mauricio Ospina - Cel: 3204958448 - ambrosio.mauro@gmail.com
// Last Modified On : 05-23-2016
// ***********************************************************************
// <copyright file="CustomerSessionTargetMails.cs" company="Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR">
//     Copyright © Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR 2015
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Acnur.App.Proxy
{
    using Acnur.App.Interfaces;
    using Acnur.App.Entities;

    /// <summary>
    /// Class CustomerSessionTargetMails.
    /// </summary>
    /// <seealso cref="Acnur.App.Proxy.CustomerGenericFacade{Acnur.App.Interfaces.IFacadeSessionTargetMails,Acnur.App.Entities.SessionTargetMails}" />
    /// <seealso cref="Acnur.App.Interfaces.IFacadeSessionTargetMails" />
    public class CustomerSessionTargetMails : CustomerGenericFacade<IFacadeSessionTargetMails, SessionTargetMails>, IFacadeSessionTargetMails
    {
    }
}
