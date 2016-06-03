// ***********************************************************************
// Assembly         : Acnur.App.Implementation
// Author           : Mauricio Ospina - Cel: 3204958448 - ambrosio.mauro@gmail.com
// Created          : 05-23-2016
//
// Last Modified By : Mauricio Ospina - Cel: 3204958448 - ambrosio.mauro@gmail.com
// Last Modified On : 05-24-2016
// ***********************************************************************
// <copyright file="FacadeSession.cs" company="Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR">
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
    using Acnur.App.Aplication.Enumerators;
    using System.Linq;

    /// <summary>
    /// Class FacadeSession.
    /// </summary>
    /// <seealso cref="Acnur.App.Implementation.FacadeGeneric{Acnur.App.Entities.Sessions}" />
    /// <seealso cref="Acnur.App.Interfaces.IFacadeSession" />
    public class FacadeSession : FacadeGeneric<Sessions>, IFacadeSession
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
        /// <exception cref="System.NotImplementedException"></exception>
        public string SaveSessionPurchase(string sourceMail, string guidTransaction, int idRequest, List<Goods> listGoods, List<Events> listEvents, List<Services> listServices)
        {
            //// Declaración de las variables a usar
            string result = string.Empty;
            Sessions session;

            //// Obtiene las sesiones que coinciden con el guid enviado. En téoría debe ser uno
            List<Sessions> ListSessions = this.Search(ses => ses.GUID == guidTransaction, false, null).ToList();

            if (ListSessions.Count > 0)
            {
                //// Carga la variable de la sesión
                session = ListSessions.First();
            }
            else
            {
                //// Guarda la sesión
                session = new Sessions()
                {
                    GUID = guidTransaction,
                    SourceEmail = sourceMail
                };

                session = this.Add(session);
            }

            /// Guarda todos los componentes del purchase en la sesión
            RepositoryData.Add<SessionComponentsByModule>(new SessionComponentsByModule() { IdSession = session.IdSession, IdComponentByModule = (int)TypeComponent.Request, IdInformation = idRequest });
            listGoods.ForEach(good => RepositoryData.Add<SessionComponentsByModule>(new SessionComponentsByModule() { IdSession = session.IdSession, IdComponentByModule = (int)TypeComponent.Goods, IdInformation = good.IdGoods }));
            listEvents.ForEach(even => RepositoryData.Add<SessionComponentsByModule>(new SessionComponentsByModule() { IdSession = session.IdSession, IdComponentByModule = (int)TypeComponent.Events, IdInformation = even.IdEvent }));
            listServices.ForEach(service => RepositoryData.Add<SessionComponentsByModule>(new SessionComponentsByModule() { IdSession = session.IdSession, IdComponentByModule = (int)TypeComponent.Services, IdInformation = service.IdService }));

            //// Realiza la consulta del request para armar el cuerpo del correo 
            List<Request> listRequest = RepositoryData.Search<Request>(req => req.IdRequest == idRequest, false, null);

            listRequest.ForEach(delegate(Request req)
            {
                result = @"A continuación se relaciona(n) la(s) siguiente(s) solicitud(es). Por favor ingrese a la aplicación por medio del icono de ACNUR ubicado en la parte superior derecha de su computador. En caso de no tener acceso, por favor comunicarse con el administrador del sistema.<br><br><b>Request:</b><br><br>" + req.BackgroundRationale + "<br><b>Delivery Location:</b> " + req.DeliveryLocation + "<br><b>Estimated Delivery Date:</b> " + req.EstimatedDeliveryDate.ToLongDateString() + "<br><br>";
            });

            //// Valida si tiene eventos y los relaciona en el cuerpo del correo
            if (listEvents.Count > 0)
            {
                result += @"<b>Events:</b><br><br>";
                listEvents.ForEach(delegate(Events item)
                {
                    result += @"Event Name: " + item.EventName + "<br><b>Start Date: </b>" + item.StartDate.ToShortDateString() + "<br><b>End Date: </b>" + item.EndDate.ToShortDateString() + "<br><br>";
                });
            }

            //// Valida si tiene bienes y los relaciona en el cuerpo del correo
            if (listGoods.Count > 0)
            {
                result += @"<b>Goods:</b><br><br>";
                listGoods.ForEach(delegate(Goods item)
                {
                    result += @"<b>Description: </b>" + item.Description + "<br><b>Place Delivery: </b>" + item.PlaceDelivery + "<br><b>Contact Person: </b>" + item.ContactPerson + "<br><b>Expected Delivery Date: </b>" + item.ExpectedDeliveryDate.ToLongDateString() + "<br><br>";
                });
            }

            //// Valida si tiene servicios y los relaciona en el cuerpo del correo
            if (listServices.Count > 0)
            {
                result += @"<b>Services:</b><br><br>";
                listServices.ForEach(delegate(Services item)
                {
                    result += @"<b>Description: </b>" + item.Description + "<br><b>Context: </b>" + item.Context + "<br><br>";
                });
            }

            return result;
        }
    }
}
