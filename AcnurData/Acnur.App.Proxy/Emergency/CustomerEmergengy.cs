// ***********************************************************************
// Assembly         : Acnur.App.Proxy
// Author           : Mauricio Ospina - Cel: 3204958448 - ambrosio.mauro@gmail.com
// Created          : 12-10-2015
//
// Last Modified By : Mauricio Ospina
// Last Modified On : 12-10-2015
// ***********************************************************************
// <copyright file="ClienteEmergencia.cs" company="Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR">
//     Este producto fue desarrollado para Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR. Todos los derechos reservados.
// </copyright>
// <summary>Proxy del Servicio de Detalle Parámetro</summary>
// ***********************************************************************

namespace Acnur.App.Proxy
{
    using Acnur.App.Interfaces;
    using Acnur.App.Entities;

    public class CustomerEmergengy : CustomerGenericFacade<IFacadeEmergency, GeneralInformationEmergency>, IFacadeEmergency
    {
    }
}
