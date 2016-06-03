// ***********************************************************************
// Assembly         : OpenWinApp
// Author           : Mauricio Ospina - Cel: 3204958448 - ambrosio.mauro@gmail.com
// Created          : 02-05-2016
//
// Last Modified By : Mauricio Ospina
// Last Modified On : 05-25-2016
// ***********************************************************************
// <copyright file="RibbonRead.cs" company="Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR">
//     Copyright © Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR 2015
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace OpenWinApp
{
    using Microsoft.Office.Tools.Ribbon;
    using System;
    using System.Diagnostics;
    using System.Linq;
    using Outlook = Microsoft.Office.Interop.Outlook;

    /// <summary>
    /// Class RibbonRead.
    /// </summary>
    /// <seealso cref="Microsoft.Office.Tools.Ribbon.RibbonBase" />
    public partial class RibbonRead
    {
        /// <summary>
        /// Handles the Click event of the BtnOpenApp control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RibbonControlEventArgs" /> instance containing the event data.</param>
        private void BtnOpenApp_Click(object sender, RibbonControlEventArgs e)
        {
            Outlook.ExchangeUser UserAutenticate = this.LoadUserAutheticate();
            Outlook.MailItem mailItem = Globals.ThisAddIn.Application.ActiveInspector().CurrentItem as Outlook.MailItem;

            //// Utilizado para retornar EL GUID Transaction
            string strGUID = (null == mailItem.Subject || string.IsNullOrEmpty(mailItem.Subject)) ? "GUIDnull" : (mailItem.Subject.Split('<').Count() > 1 ? (mailItem.Subject.Split('<')[1].Split('>').Count() > 1 ? mailItem.Subject.Split('<')[1].Split('>')[0] : "GUIDnull") : "GUIDnull");

            //// Utilizado para retornar el cuerpo del correo actual
            string strBody = mailItem.Body;

            if (null != UserAutenticate)
            {
                ProcessStartInfo startInfo = new ProcessStartInfo();
                startInfo.FileName = @"C:\\Program Files (x86)\\ACNURWinApp\\WinApp.exe";
                startInfo.Arguments = UserAutenticate.Alias.Replace(" ", "_") + " " +
                                      UserAutenticate.FirstName.Replace(" ", "_") + " " +
                                      UserAutenticate.LastName.Replace(" ", "_") + " " +
                                      strGUID.Replace(" ", "_") + " " +
                                      UserAutenticate.PrimarySmtpAddress.Replace(" ", "_") + " " +
                                      strBody.Replace("\r\n", "|").Replace(" ", "_");

                Process.Start(startInfo).WaitForExit();
            }
        }

        /// <summary>
        /// Loads the user autheticate.
        /// </summary>
        /// <returns>Outlook.ExchangeUser.</returns>
        private Outlook.ExchangeUser LoadUserAutheticate()
        {
            var Application = new Outlook.Application();
            Outlook.AddressEntry addrEntry = Application.Session.CurrentUser.AddressEntry;

            if (addrEntry.Type == "EX")
            {
                Outlook.ExchangeUser currentUser = Application.Session.CurrentUser.AddressEntry.GetExchangeUser();

                if (currentUser != null)
                {
                    return currentUser;
                }
                else
                    return null;
            }
            else
                return null;
        }
    }
}
