// ***********************************************************************
// Assembly         : OpenWinApp
// Author           : Mauricio Ospina - Cel: 3204958448 - ambrosio.mauro@gmail.com
// Created          : 05-14-2016
//
// Last Modified By : Mauricio Ospina - Cel: 3204958448 - ambrosio.mauro@gmail.com
// Last Modified On : 05-25-2016
// ***********************************************************************
// <copyright file="ThisAddIn.cs" company="Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR">
//     Copyright © Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR 2015
// </copyright>
// <summary></summary>
// ***********************************************************************
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using Outlook = Microsoft.Office.Interop.Outlook;
using Office = Microsoft.Office.Core;
using System.Diagnostics;

namespace OpenWinApp
{
    /// <summary>
    /// Class ThisAddIn.
    /// </summary>
    /// <seealso cref="Microsoft.Office.Tools.Outlook.OutlookAddInBase" />
    public partial class ThisAddIn
    {
        /// <summary>
        /// The outlook application
        /// </summary>
        public Outlook.Application OutlookApplication;
        /// <summary>
        /// The outlook inspectors
        /// </summary>
        public Outlook.Inspectors OutlookInspectors;
        /// <summary>
        /// The outlook inspector
        /// </summary>
        public Outlook.Inspector OutlookInspector;
        /// <summary>
        /// The outlook mail item
        /// </summary>
        public Outlook.MailItem OutlookMailItem;

        /// <summary>
        /// Handles the Startup event of the ThisAddIn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void ThisAddIn_Startup(object sender, System.EventArgs e)
        {
            OutlookApplication = this.Application as Outlook.Application;
            OutlookInspectors = OutlookApplication.Inspectors;
            OutlookInspectors.NewInspector += new Microsoft.Office.Interop.Outlook.InspectorsEvents_NewInspectorEventHandler(OutlookInspectors_NewInspector);
            OutlookApplication.ItemSend += new Microsoft.Office.Interop.Outlook.ApplicationEvents_11_ItemSendEventHandler(OutlookApplication_ItemSend);
        }

        /// <summary>
        /// Handles the Shutdown event of the ThisAddIn control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void ThisAddIn_Shutdown(object sender, System.EventArgs e)
        {
        }

        /// <summary>
        /// Outlooks the inspectors_ new inspector.
        /// </summary>
        /// <param name="Inspector">The inspector.</param>
        void OutlookInspectors_NewInspector(Microsoft.Office.Interop.Outlook.Inspector Inspector)
        {
            OutlookInspector = (Outlook.Inspector)Inspector;
            if (Inspector.CurrentItem is Outlook.MailItem)
            {
                OutlookMailItem = (Outlook.MailItem)Inspector.CurrentItem;
            }

        }

        /// <summary>
        /// Outlooks the application_ item send.
        /// </summary>
        /// <param name="Item">The item.</param>
        /// <param name="Cancel">if set to <c>true</c> [cancel].</param>
        void OutlookApplication_ItemSend(object Item, ref bool Cancel)
        {
            //// Obtiene el GUID desde el asunto 
            string strGUID = (null == OutlookMailItem.Subject || string.IsNullOrEmpty(OutlookMailItem.Subject)) ? string.Empty : (OutlookMailItem.Subject.Split('<').Count() > 1 ? (OutlookMailItem.Subject.Split('<')[1].Split('>').Count() > 1 ? OutlookMailItem.Subject.Split('<')[1].Split('>')[0] : string.Empty) : string.Empty);

            //// Valida que no venga vacío y que sea consistente con la cantidad de caracteres de un dato GUID
            if (!string.IsNullOrEmpty(strGUID) && (strGUID.Length > 35))
            {
                using (Acnur.App.Proxy.CustomerSession client = new Acnur.App.Proxy.CustomerSession())
                {
                    List<Acnur.App.Entities.Sessions> ListSessions = client.Search(ses => ses.GUID == strGUID, false, null).ToList();

                    if (ListSessions.Count > 0)
                    {
                        Acnur.App.Entities.Sessions session = ListSessions.First();
                        session.Send = true;
                        client.Update(session);
                    }
                }
            }
        }

        #region Código generado por VSTO

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InternalStartup()
        {
            this.Startup += new System.EventHandler(ThisAddIn_Startup);
            this.Shutdown += new System.EventHandler(ThisAddIn_Shutdown);
        }

        #endregion
    }
}
