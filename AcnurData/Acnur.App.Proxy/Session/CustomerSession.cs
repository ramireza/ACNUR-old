// ***********************************************************************
// Assembly         : Acnur.App.Proxy
// Author           : Mauricio Ospina - Cel: 3204958448 - ambrosio.mauro@gmail.com
// Created          : 05-23-2016
//
// Last Modified By : Mauricio Ospina - Cel: 3204958448 - ambrosio.mauro@gmail.com
// Last Modified On : 05-23-2016
// ***********************************************************************
// <copyright file="CustomerSession.cs" company="Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR">
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
    /// Class CustomerSession.
    /// </summary>
    /// <seealso cref="Acnur.App.Proxy.CustomerGenericFacade{Acnur.App.Interfaces.IFacadeSession,Acnur.App.Entities.Sessions}" />
    /// <seealso cref="Acnur.App.Interfaces.IFacadeSession" />
    public class CustomerSession : CustomerGenericFacade<IFacadeSession, Sessions>, IFacadeSession
    {
        /// <summary>
        /// Saves the session.
        /// </summary>
        /// <param name="sourceMail">The source mail.</param>
        /// <param name="guidTransaction">The unique identifier transaction.</param>
        /// <param name="idRequest">The identifier request.</param>
        /// <param name="listGoods">The list goods.</param>
        /// <param name="listEvents">The list events.</param>
        /// <param name="listServices">The list services.</param>
        /// <returns>System.String.</returns>
        public string SaveSessionPurchase(string sourceMail, string guidTransaction, int idRequest, List<Goods> listGoods, List<Events> listEvents, List<Services> listServices)
        {
            return this.Channel.SaveSessionPurchase(sourceMail, guidTransaction, idRequest, listGoods, listEvents, listServices);
        }
    }
}
