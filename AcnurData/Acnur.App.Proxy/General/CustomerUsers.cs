// ***********************************************************************
// Assembly         : Acnur.App.Proxy
// Author           : Mauricio Ospina - Cel: 3204958448 - ambrosio.mauro@gmail.com
// Created          : 12-14-2015
//
// Last Modified By : Mauricio Ospina
// Last Modified On : 12-14-2015
// ***********************************************************************
// <copyright file="CustomerUsers.cs" company="Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR">
//     Copyright © Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR 2015
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Acnur.App.Proxy
{
    using Acnur.App.Entities;
    using Acnur.App.Interfaces;

    /// <summary>
    /// Class CustomerUsers.
    /// </summary>
    public class CustomerUsers : CustomerGenericFacade<IFacadeUsers, Users>, IFacadeUsers
    {
    }
}
