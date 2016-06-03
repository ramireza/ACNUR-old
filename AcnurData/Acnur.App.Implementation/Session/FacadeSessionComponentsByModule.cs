// ***********************************************************************
// Assembly         : Acnur.App.Implementation
// Author           : Mauricio Ospina - Cel: 3204958448 - ambrosio.mauro@gmail.com
// Created          : 05-23-2016
//
// Last Modified By : Mauricio Ospina - Cel: 3204958448 - ambrosio.mauro@gmail.com
// Last Modified On : 05-23-2016
// ***********************************************************************
// <copyright file="FacadeSessionComponentsByModule.cs" company="Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR">
//     Copyright © Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR 2015
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace Acnur.App.Implementation
{
    using Acnur.App.Aplication.Enumerators;
    using Acnur.App.Entities;
    using Acnur.App.Interfaces;
    using Acnur.App.Repository;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Class FacadeSessionComponentsByModule.
    /// </summary>
    /// <seealso cref="Acnur.App.Implementation.FacadeGeneric{Acnur.App.Entities.SessionComponentsByModule}" />
    /// <seealso cref="Acnur.App.Interfaces.IFacadeSessionComponentsByModule" />
    public class FacadeSessionComponentsByModule : FacadeGeneric<SessionComponentsByModule>, IFacadeSessionComponentsByModule
    {
        public int GetIdPurchase(string strGUID)
        {
            int IdPurchase = 0;
            List<Sessions> ListaSessions = RepositoryData.Search<Sessions>(ses => ses.GUID == strGUID, false, null).ToList();
            Sessions sesion = new Sessions();

            if (ListaSessions.Count > 0)
            {
                sesion = ListaSessions.First();
            }

            List<SessionComponentsByModule> ListaComponent = RepositoryData.Search<SessionComponentsByModule>(ses => ses.IdSession == sesion.IdSession, false, null).ToList();

            ListaComponent.ForEach(delegate(SessionComponentsByModule item)
            {
                if (item.IdComponentByModule == (int)TypeComponent.Request)
                {
                    IdPurchase = item.IdInformation;
                }
            });

            return IdPurchase;
        }
    }
}
