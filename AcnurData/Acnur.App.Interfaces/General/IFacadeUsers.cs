// ***********************************************************************
// Assembly         : Acnur.App.Interfaces
// Author           : Mauricio Ospina - Cel: 3204958448 - ambrosio.mauro@gmail.com
// Created          : 12-14-2015
//
// Last Modified By : Mauricio Ospina
// Last Modified On : 12-14-2015
// ***********************************************************************
// <copyright file="IFacadeUsers.cs" company="Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR">
//     Copyright © Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR 2015
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Acnur.App.Interfaces
{
    using Acnur.App.Entities;
    using System.ServiceModel;

    /// <summary>
    /// Interface IFacadeUsers
    /// </summary>
    [ServiceContract]
    public interface IFacadeUsers : IFacadeGeneric<Users>
    {
    }
}
