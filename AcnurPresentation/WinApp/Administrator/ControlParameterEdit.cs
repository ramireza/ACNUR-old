// ***********************************************************************
// Assembly         : WinApp
// Author           : Mauricio Ospina - Cel: 3204958448 - ambrosio.mauro@gmail.com
// Created          : 02-11-2016
//
// Last Modified By : Mauricio Ospina
// Last Modified On : 02-17-2016
// ***********************************************************************
// <copyright file="ParameterEdit.cs" company="Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR">
//     Este producto fue desarrollado para Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR. Todos los derechos reservados.
// </copyright>
// <summary>Clase usada para la edición de los parámetros</summary>
// ***********************************************************************

/// <summary>
/// The WinApp namespace.
/// </summary>
namespace WinApp
{
    using Acnur.App.Aplication;
    using Acnur.App.Entities;
    using Acnur.App.Proxy;
    using DevExpress.XtraEditors;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Windows.Forms;

    /// <summary>
    /// Class ParameterEdit.
    /// </summary>
    public partial class ControlParameterEdit : DevExpress.XtraEditors.XtraUserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ControlParameterEdit" /> class.
        /// </summary>
        public ControlParameterEdit()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Handles the Load event of the ParameterEdit control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs" /> instance containing the event data.</param>
        private void ParameterEdit_Load(object sender, System.EventArgs e)
        {
            this.LoadData();
        }

        /// <summary>
        /// Loads the data.
        /// </summary>
        private void LoadData()
        {
            List<ParameterDetail> ListDetails = new List<ParameterDetail>();

            using (CustomerParameterDetail client = new CustomerParameterDetail())
            {
                ListDetails = client.GetAll(false, "Parameter").ToList();
            }

            ListDetails = ListDetails.Where(item => item.Parameter.Editable == true).ToList();
            this.GrControlParameter.DataSource = Utilities.ConvertirListaTabla(ListDetails);
        }

        /// <summary>
        /// Edits the record.
        /// </summary>
        /// <param name="edit">if set to <c>true</c> [edit.</param>
        /// <returns><c>true</c> if XXXX, <c>false</c> otherwise.</returns>
        private void EditRecord(bool edit)
        {
            FormParameters frm = new FormParameters();
            DataRow row = edit ? this.GrViewParameter.GetFocusedDataRow() : null;
            frm.InitData(this.FindForm(), row, edit);
            frm.ShowDialog();
        }

        /// <summary>
        /// Handles the Click event of the GrControlParameter_EmbeddedNavigator control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DevExpress.XtraEditors.NavigatorButtonClickEventArgs" /> instance containing the event data.</param>
        private void GrControlParameter_EmbeddedNavigator_Click(object sender, NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == NavigatorButtonType.Edit || e.Button.ButtonType == NavigatorButtonType.Append || e.Button.ButtonType == NavigatorButtonType.Remove)
            {
                if (e.Button.ButtonType == NavigatorButtonType.Edit)
                {
                    this.EditRecord(true);

                }
                if (e.Button.ButtonType == NavigatorButtonType.Append)
                {
                    this.EditRecord(false);
                }
                if (e.Button.ButtonType == NavigatorButtonType.Remove)
                {
                    XtraMessageBox.AllowCustomLookAndFeel = true;
                    DialogResult dialogResult = XtraMessageBox.Show(" Really you want to delete the record ? ", "Confirmation", MessageBoxButtons.YesNo);

                    if (dialogResult == System.Windows.Forms.DialogResult.Yes)
                    {
                        DataRow row = this.GrViewParameter.GetFocusedDataRow();
                        int IdParameterDetail = int.Parse(row[1].ToString());

                        using (CustomerParameterDetail client = new CustomerParameterDetail())
                        {
                            client.Inactivate(IdParameterDetail);
                        }
                    }
                }

                this.LoadData();
                e.Handled = true;
            }
        }
    }
}
