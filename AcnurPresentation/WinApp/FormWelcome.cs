// ***********************************************************************
// Assembly         : WinApp
// Author           : Mauricio Ospina - Cel: 3204958448 - ambrosio.mauro@gmail.com
// Created          : 02-05-2016
//
// Last Modified By : Mauricio Ospina
// Last Modified On : 05-25-2016
// ***********************************************************************
// <copyright file="Welcome.cs" company="Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR">
//     Este producto fue desarrollado para Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR. Todos los derechos reservados.
// </copyright>
// <summary>Clase usada para el despliegue</summary>
// ***********************************************************************

namespace WinApp
{
    using Acnur.App.Aplication;
    using Acnur.App.Aplication.Enumerators;
    using Acnur.App.Entities;
    using Acnur.App.Proxy;
    using DevExpress.XtraEditors;
    using System;
    using System.Collections.Generic;
    using System.Diagnostics;
    using System.IO;
    using System.Linq;
    using System.Reflection;
    using System.Runtime.InteropServices;
    using WinApp.Properties;
    using Outlook = Microsoft.Office.Interop.Outlook;

    /// <summary>
    /// Class FormWelcome.
    /// </summary>
    /// <seealso cref="DevExpress.XtraEditors.XtraForm" />
    public partial class FormWelcome : XtraForm
    {
        /// <summary>
        /// Sets the data purchase.
        /// </summary>
        /// <value>The data purchase.</value>
        public string DataPurchase
        {
            get { return this.MemoDataPurchase.Text; }
            set { this.MemoDataPurchase.Text = value; }
        }
        public string DataFocus
        {
            get { return this.MemoDataFocus.Text; }
            set { this.MemoDataFocus.Text = value; }
        }
        /// <summary>
        /// Gets or sets the data body.
        /// </summary>
        /// <value>The data body.</value>
        public string DataBody { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="FormWelcome" /> class.
        /// </summary>
        /// <param name="args">The arguments.</param>
        public FormWelcome(string[] args)
        {
            InitializeComponent();

            ////===================================================================
            //// Instrucción permite realizar la prueba sin la conexión al AddIns 
            //// se debe retirar en el ambiente de producción
            ////===================================================================
            //// 
            if (args.Length == 0 || null == args[0])
            {
                Program.CurrentUser = "ramireza";
                Program.CurrentUserName = "Alvaro Ramirez";
                Program.CurrentGUID = "32aa0aab-e961-4ac2-8521-d7d66d5e8258";
                Program.CurrentMail = "ramireza@unhcr.org";
            }
            ////===================================================================

            if (string.IsNullOrEmpty(Program.CurrentUser) || null == Program.CurrentUser)
            {
                if (args.Length > 0)
                {
                    Program.CurrentUser = args[0];
                    Program.CurrentUserName = args[1].ToString().Replace('_', ' ') + " " + args[2].ToString().Replace('_', ' ');
                    Program.CurrentGUID = args[3] == "GUIDnull" ? string.Empty : args[3];
                    Program.CurrentMail = args[4];
                    this.DataBody = args[5].Replace("|", "<br>").Replace('_', ' ');
                }
            }
            
            try
            {
                this.LoadMenu(args);
            }
            catch (Exception ex)
            {
                XtraMessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        /// Loads the menu.
        /// </summary>
        /// <param name="args">The arguments.</param>
        protected void LoadMenu(string[] args)
        {
            //// Instanciamos la lista a usar
            List<Modules> List = new List<Modules>();

            //// Conexión con el próxy
            using (CustomerModules client = new CustomerModules())
            {
                //// Obtiene la lista de modulos
                List = client.GetModulesByUser(Program.CurrentUser);
            }

            if (List.Count > 0)
            {
                //// Carga el combo
                this.LoadComboBox();


                if (string.IsNullOrEmpty(Program.CurrentGUID))
                {
                    //// Genera el nuevo GUID
                    Program.CurrentGUID = Guid.NewGuid().ToString();
                }

                //// Recorre la lista y adjunta la imagen que se va a mostrar al usuario
                List.ForEach(delegate(Modules mod)
                {
                    if (mod.ModuleName == TypeModule.Purchase.ToString())
                    {
                        mod.Picture = Resources.MenuPurchase;
                    }
                    if (mod.ModuleName == TypeModule.Administration.ToString())
                    {
                        mod.Picture = Resources.MenuAdmin;
                    }
                    if (mod.ModuleName == TypeModule.Focus.ToString())
                    {
                        mod.Picture = Resources.MenuPurchase;
                    }
                });

                //// Despliega los datos
                this.GrcMenu.DataSource = List;
            }

            else
            {
                XtraMessageBox.Show("You do not have privileges to enter. Please consult administrator");
                this.BtnFinalize.Visible = false;
            }
        }

        /// <summary>
        /// Handles the Click event of the RiPictureMenu control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void RiPictureMenu_Click(object sender, EventArgs e)
        {
            string Menu = CrvMenu.GetRowCellValue(CrvMenu.FocusedRowHandle, ColName).ToString();
            TypeModule MenuType = (TypeModule)Enum.Parse(typeof(TypeModule), Menu);

            switch (MenuType)
            {
                case TypeModule.Administration:
                    //// Abre la aplicación del administrador
                    System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
                    startInfo.FileName = @"C:\\Program Files (x86)\\ACNURWinApp\\WinAdministrator.exe";
                    System.Diagnostics.Process.Start(startInfo).WaitForExit();
                    break;

                case TypeModule.Purchase:

                    //// Validamos si viene el GUID para poder extraer el id request
                    int IdRequest = 0;
                    if (!string.IsNullOrEmpty(Program.CurrentGUID))
                    {
                        using (CustomerSessionComponentsByModule client = new CustomerSessionComponentsByModule())
                        {
                            IdRequest = client.GetIdPurchase(Program.CurrentGUID);
                        }
                    }

                   //// Instanciamos el form request
                    FormRequest request = new FormRequest(IdRequest);
                    request.ShowDialog();
                    this.DataPurchase += request.LoadBodyPurchase();
                    break;

                case TypeModule.Focus:

                    //// Validamos si viene el GUID para poder extraer el id request
                    int IdFocus = 0;
                    if (!string.IsNullOrEmpty(Program.CurrentGUID))
                    {
                        using (CustomerSessionComponentsByModule client = new CustomerSessionComponentsByModule())
                        {
                            IdFocus = client.GetIdCycle(Program.CurrentGUID);
                        }
                    }
                    //// Instanciamos el form request
                    FormFocus focus = new FormFocus(IdFocus);
                    focus.ShowDialog();
                    this.DataFocus  += focus.LoadBodyFocus ();
                    break;

                default:
                    break;
            }
        }

        /// <summary>
        /// BTNs the finalize_ click.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        private void BtnFinalize_Click(object sender, EventArgs e)
        {
            //// Valida que se haya seleccionado un item en la lista Process Group
            bool ret = this.ValidationProviderWelcome.Validate();

            if (ret)
            {
                //// Valida que hayan datos para enviar
                if (this.ValidateInformationForSend())
                {
                    try
                    {
                        Outlook.Application outlookApp = null;

                        if (Process.GetProcessesByName("OUTLOOK").Count() > 0)
                        {
                            //// Si encuentra que la aplicación de outlook ya esta abierta
                            outlookApp = Marshal.GetActiveObject("Outlook.Application") as Outlook.Application;
                        }
                        else
                        {
                            // Si no, crea una nueva isntancia de Outlook 
                            outlookApp = new Outlook.Application();
                            Outlook.NameSpace nameSpace = outlookApp.GetNamespace("MAPI");
                            nameSpace.Logon("", "", Missing.Value, Missing.Value);
                            nameSpace = null;
                        }

                        //// Obtiene el correo que se esta tramitando en ese instante
                        Outlook._MailItem oMailItem = (Outlook._MailItem)outlookApp.ActiveInspector().CurrentItem as Outlook._MailItem;

                        //// Adiciona el Subject
                        oMailItem.Subject = ((System.Web.UI.WebControls.ListItem)(this.CmbProcessGroup.SelectedItem)).Text + " <" + Program.CurrentGUID + ">";

                        //// Obtiene la sesión y la actualiza colocandole el process group y el body del mail que s eva a enviar
                        using (CustomerSession client = new CustomerSession())
                        {
                            List<Sessions> ListSession = client.Search(ses => ses.GUID == Program.CurrentGUID, false, null).ToList();

                            if (ListSession.Count > 0)
                            {
                                Sessions Session = ListSession.First();
                                Session.IdProcessGroup = Convert.ToInt32(((System.Web.UI.WebControls.ListItem)(this.CmbProcessGroup.SelectedItem)).Value);
                                Session.BodyMail = this.DataPurchase;
                                Session.Subject = oMailItem.Subject;
                                client.Update(Session);
                            }
                        }

                        //// Coloca el string en el cuerpo del correo
                        oMailItem.HTMLBody = this.DataPurchase + "<br>" + this.DataBody;

                        //// Muestra mailbox
                        oMailItem.Display(true);

                        //// Cierra la aplicación
                        this.Close();
                        Program.CloseApplication();
                    }
                    catch (Exception objEx)
                    {
                        XtraMessageBox.Show(objEx.Message);
                    }
                }
            }
        }

        /// <summary>
        /// Validates the information for send.
        /// </summary>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        private bool ValidateInformationForSend()
        {
            bool valid = false;

            if (string.IsNullOrEmpty(this.DataPurchase))
            {
                if (string.IsNullOrEmpty(this.DataFocus))
                    XtraMessageBox.Show("No information to be sent");
                else
                    valid = true;
            }
            return valid;
        }

        /// <summary>
        /// Loads the ComboBox.
        /// </summary>
        private void LoadComboBox()
        {
            using (CustomerParameterDetail customer = new CustomerParameterDetail())
            {
                Utilities.SeleccionarValorXDefectoDDLId(this.CmbProcessGroup, customer.GetParameterDetailsByParameter(TypeParameter.ProcessGroup), 0, true, true);
            }
        }
    }
}