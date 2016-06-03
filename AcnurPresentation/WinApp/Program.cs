// ***********************************************************************
// Assembly         : WinApp
// Author           : Mauricio Ospina - Cel: 3204958448 - ambrosio.mauro@gmail.com
// Created          : 03-22-2016
//
// Last Modified By : Mauricio Ospina - Cel: 3204958448 - ambrosio.mauro@gmail.com
// Last Modified On : 05-25-2016
// ***********************************************************************
// <copyright file="Program.cs" company="Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR">
//     Copyright © Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR 2015
// </copyright>
// <summary></summary>
// ***********************************************************************
namespace WinApp
{
    using DevExpress.LookAndFeel;
    using System;
    using System.Diagnostics;
    using System.Linq;
    using System.Windows.Forms;

    /// <summary>
    /// Class Program.
    /// </summary>
    static class Program
    {
        #region Properties User

        /// <summary>
        /// The current user
        /// Usuario autenticado
        /// </summary>
        public static string CurrentUser;

        /// <summary>
        /// Gets or sets the name of the current user.
        /// Nombre y apellido del usuario autenticado
        /// </summary>
        /// <value>The name of the current user.</value>
        public static string CurrentUserName { get; set; }

        /// <summary>
        /// Gets or sets the current identifier.
        /// Se refiere a el ID del correo del cuál esta llegando
        /// </summary>
        /// <value>The current identifier.</value>
        public static string CurrentId { get; set; }

        /// <summary>
        /// Gets or sets the current mail.
        /// Correo electrónico del usuario autenticado
        /// </summary>
        /// <value>The current mail.</value>
        public static string CurrentMail { get; set; }

        /// <summary>
        /// Gets or sets the unique identifier transaction.
        /// Identificador de la ifnoramción enlazada
        /// </summary>
        /// <value>The unique identifier transaction.</value>
        public static string CurrentGUID { get; set; }

        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// <param name="args">The arguments.</param>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ////=============================================================================
            //// Utilizado para validar los parámetros que estan saliendo y llegando
            ////=============================================================================
            ////MessageBox.Show("se han pasado " + args.Length.ToString() + " argumentos");
            ////string str = string.Empty;
            ////args.ToList().ForEach(item => str += item + ", ");
            ////MessageBox.Show("se ha pasado el argumento: " + str);
            ////==============================================================================

            DevExpress.Skins.SkinManager.EnableFormSkins();
            DevExpress.UserSkins.BonusSkins.Register();
            UserLookAndFeel.Default.SetSkinStyle("DevExpress Style");

            if (!IsExecutingApplication())
            {
                Application.Run(new FormWelcome(args));
            }
        }

        /// <summary>
        /// Determines whether [is executing application].
        /// </summary>
        /// <returns><c>true</c> if [is executing application]; otherwise, <c>false</c>.</returns>
        private static bool IsExecutingApplication()
        {
            //// Proceso actual
            Process currentProcess = Process.GetCurrentProcess();

            //// Matriz de procesos
            Process[] processes = Process.GetProcesses();

            //// Recorremos los procesos en ejecución
            foreach (Process p in processes)
            {
                if (p.Id != currentProcess.Id)
                {
                    if (p.ProcessName == currentProcess.ProcessName)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Closes the application.
        /// </summary>
        public static void CloseApplication()
        {
            //// Proceso actual
            Process currentProcess = Process.GetCurrentProcess();

            //// Cierrra el proceso
            currentProcess.Close();
        }   
    }
}