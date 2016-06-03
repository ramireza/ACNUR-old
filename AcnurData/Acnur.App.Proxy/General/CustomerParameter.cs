// ***********************************************************************
// Assembly         : Acnur.App.Proxy
// Author           : Mauricio Ospina - Cel: 3204958448 - ambrosio.mauro@gmail.com
// Created          : 23-10-2015
//
// Last Modified By : Mauricio Ospina
// Last Modified On : 23-10-2015
// ***********************************************************************
// <copyright file="ClienteParametro.cs" company="Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR">
//     Este producto fue desarrollado para Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR. Todos los derechos reservados.
// </copyright>
// <summary>Proxy del servicio parámetros</summary>
// ***********************************************************************

namespace Acnur.App.Proxy
{
    using Acnur.App.Entities;
    using Acnur.App.Interfaces;

    public class CustomerParameter : CustomerGenericFacade<IFacadeParameter, Parameter>, IFacadeParameter
    {        
    }
}
