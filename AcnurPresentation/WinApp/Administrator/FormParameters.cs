// ***********************************************************************
// Assembly         : WinApp
// Author           : Mauricio Ospina - Cel: 3204958448 - ambrosio.mauro@gmail.com
// Created          : 02-11-2016
//
// Last Modified By : Mauricio Ospina
// Last Modified On : 02-12-2016
// ***********************************************************************
// <copyright file="Parameters.cs" company="Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR">
//     Este producto fue desarrollado para Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR. Todos los derechos reservados.
// </copyright>
// <summary>Clase usada para la edición de los parámetros</summary>
// ***********************************************************************

namespace WinApp
{
    using Acnur.App.Aplication;
    using Acnur.App.Entities;
    using Acnur.App.Proxy;
    using System;
    using System.Data;
    using System.Linq;
    using System.Web.UI.WebControls;
    using System.Windows.Forms;

    /// <summary>
    /// Class Parameters.
    /// </summary>
    public partial class FormParameters : DevExpress.XtraEditors.XtraForm
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormParameters"/> class.
        /// </summary>
        public FormParameters()
        {
            this.InitializeComponent();
            this.LoadComboBox();
        }

        /// <summary>
        /// Gets or sets the identifier parameter detail.
        /// </summary>
        /// <value>The identifier parameter detail.</value>
        public string IdParameterDetail
        {
            get
            {
                return String.IsNullOrEmpty(this.LblIdParameterDetalle.Text) ? "0" : this.LblIdParameterDetalle.Text;
            }

            set
            {
                this.LblIdParameterDetalle.Text = value;
            }
        }

        /// <summary>
        /// Initializes the location.
        /// </summary>
        /// <param name="frm">The FRM.</param>
        private void InitLocation(Form frm)
        {
            this.Top = frm.Top + (frm.Height - this.Height) / 2;
            this.Left = frm.Left + (frm.Width - this.Width) / 2;
        }

        /// <summary>
        /// Initializes the data.
        /// </summary>
        /// <param name="frm">The FRM.</param>
        /// <param name="grid">The grid.</param>
        /// <param name="view">The view.</param>
        /// <param name="row">The row.</param>
        public void InitData(Form frm, DataRow row, Boolean edit)
        {
            this.InitLocation(frm);

            if (edit)
            {
                this.IdParameterDetail = row[1].ToString();
                ((ListItem)(this.CmbParameterType.EditValue)).Value = row[2].ToString();
                ((ListItem)(this.CmbParameterType.EditValue)).Text = row[0].ToString();
                this.TxtParameterName.Text = row[4].ToString();
                this.MemoDefinition.Text = row[5].ToString();
                this.ChkActive.Checked = !string.IsNullOrEmpty(row[9].ToString()) ? Convert.ToBoolean(row[9].ToString()) : false;
            }

            this.ChkEdit.Checked = edit;
        }

        /// <summary>
        /// Handles the Click event of the BtnOk control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnOk_Click(object sender, EventArgs e)
        {
            //// Valida 
            bool ret = this.ValidationProviderEdit.Validate();

            //// Guarda en base de datos el registro
            if (ret)
            {
                ParameterDetail item = new ParameterDetail();

                item.IdParameter = Convert.ToInt32(((ListItem)(this.CmbParameterType.EditValue)).Value);
                item.Name = this.TxtParameterName.Text;
                item.Definition = this.MemoDefinition.Text;
                item.Value1 = string.Empty;
                item.Value2 = string.Empty;
                item.Ordinal = 0;
                item.Active = this.ChkActive.Checked;

                using (CustomerParameterDetail client = new CustomerParameterDetail())
                {
                    if (this.ChkEdit.Checked)
                    {
                        item.IdParameterDetail = int.Parse(this.IdParameterDetail);
                        client.Update(item);
                    }
                    else
                    {
                        client.Add(item);
                    }
                }
            }

            //// Cierra ventana y refresca los parámetros
            this.DialogResult = ret ? DialogResult.OK : DialogResult.None;
        }

        /// <summary>
        /// Loads the ComboBox.
        /// </summary>
        private void LoadComboBox()
        {
            using (CustomerParameter client = new CustomerParameter())
            {
                //// Filtra los parámetros por los que si se pueden editar
                Utilities.LlenarLista(this.CmbParameterType, client.GetAll(false, null).Where(item => item.Editable == true).ToList());
            }

        }
    }
}