// ***********************************************************************
// Assembly         : Acnur.App.Aplication
// Author           : Mauricio Ospina - Cel: 3204958448 - ambrosio.mauro@gmail.com
// Created          : 19-10-2015
//
// Last Modified By : Mauricio Ospina
// Last Modified On : 19-10-2015
// ***********************************************************************
// <copyright file="Acceso.cs" company="Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR">
//     Este producto fue desarrollado para Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR. Todos los derechos reservados.
// </copyright>
// <summary>Archivo de clase para manejar roles y permisos de aplicacion.</summary>
// ***********************************************************************

namespace Acnur.App.Aplication.Security
{
    using System.Web;
    using Acnur.App.Entities;
    using Outlook = Microsoft.Office.Interop.Outlook;

    public static class Access
    {
        /// <summary>
        /// Código interno de la session de usuario
        /// </summary>
        private const string SesionSeguridadUsuario = "STR_SESSION_SEGURIDAD_USUARIO";

        /// <summary>
        /// Funcion para retornar el usuario de la sesion actual
        /// </summary>
        /// <returns>El usaurio completo de la sesion actual</returns>
        public static Users Usuario()
        {
            Users usuario = new Users();

            var Application = new Outlook.Application();
            Outlook.AddressEntry addrEntry = Application.Session.CurrentUser.AddressEntry;

            if (addrEntry.Type == "EX")
            {
                Outlook.ExchangeUser currentUser = Application.Session.CurrentUser.AddressEntry.GetExchangeUser();

                if (currentUser != null)
                {
                    usuario.IdUser = int.Parse(currentUser.ID);
                    usuario.UserName = currentUser.Name;
                    usuario.Name = currentUser.FirstName;
                    usuario.LastName = currentUser.LastName;
                    //usuario.IdUserType = (int)currentUser.AddressEntryUserType;
                    usuario.Mail = currentUser.Address;

                }
            }

            return usuario;
        }
    }
}
