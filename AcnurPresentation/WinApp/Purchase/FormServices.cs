// ***********************************************************************
// Assembly         : WinApp
// Author           : Mauricio Ospina - Cel: 3204958448 - ambrosio.mauro@gmail.com
// Created          : 02-18-2016
//
// Last Modified By : Mauricio Ospina
// Last Modified On : 02-25-2016
// ***********************************************************************
// <copyright file="FormServices.cs" company="Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR">
//     Este producto fue desarrollado para Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR. Todos los derechos reservados.
// </copyright>
// <summary>Clase con los métodos de los servicios de la solicitud</summary>
// ***********************************************************************

/// <summary>
/// The WinApp namespace.
/// </summary>
namespace WinApp
{
    using Acnur.App.Aplication;
    using Acnur.App.Aplication.Enumerators;
    using Acnur.App.Entities;
    using Acnur.App.Proxy;
    using DevExpress.XtraEditors;
    using System;
    using System.Data;
    using System.Linq;
    using System.Web.UI.WebControls;
    using System.Windows.Forms;

    /// <summary>
    /// Class FormServices.
    /// </summary>
    public partial class FormServices : DevExpress.XtraEditors.XtraForm
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormServices" /> class.
        /// </summary>
        public FormServices()
        {
            InitializeComponent();
            this.LoadComboBox();
        }

        /// <summary>
        /// Gets or sets the identifier goods.
        /// </summary>
        /// <value>The identifier goods.</value>
        public string IdServices
        {
            get
            {
                return String.IsNullOrEmpty(this.LblIdServices.Text) ? "0" : this.LblIdServices.Text;
            }

            set
            {
                this.LblIdServices.Text = value;
            }
        }

        /// <summary>
        /// Gets or sets the identifier request.
        /// </summary>
        /// <value>The identifier request.</value>
        public string IdRequest
        {
            get
            {
                return String.IsNullOrEmpty(this.LblIdRequest.Text) ? "0" : this.LblIdRequest.Text;
            }

            set
            {
                this.LblIdRequest.Text = value;
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
        /// <param name="row">The row.</param>
        /// <param name="edit">The edit.</param>
        /// <param name="idRequest">The identifier request.</param>
        public void InitData(Form frm, DataRow row, Boolean edit, string idRequest)
        {
            this.InitLocation(frm);
            this.IdRequest = idRequest;

            if (edit)
            {
                this.IdServices = row[0].ToString();
                ((ListItem)(this.CmbType.EditValue)).Value = row[1].ToString();
                ((ListItem)(this.CmbType.EditValue)).Text = row[17].ToString();
                this.TxtShortDescription.Text = row[3].ToString();
                this.SpinNumberDays.Text = row[4].ToString();
                this.SpinHoursDays.Text = row[5].ToString();
                this.TxtDescriptionTechnical.Text = row[6].ToString();
                this.TxtWhereServiceRequired.Text = row[7].ToString();
                this.MemoPleaseProvide.Text = row[8].ToString();
                this.MemoWhatAreProducts.Text = row[9].ToString();
                this.DteExpectableDeliverableDate.Text = Convert.ToDateTime(row[10]).ToShortDateString();
                this.DtePriorDeliverableDate.Text = Convert.ToDateTime(row[11]).ToShortDateString();
                this.TxtDeliveryLocationService.Text = row[12].ToString();
                this.TxtContactPersonServices.Text = row[13].ToString();
                this.DteExpectedDeliveryDate.Text = Convert.ToDateTime(row[14]).ToShortDateString();
                this.MemoObservationsServices.Text = row[15].ToString();
            }

            this.ChkEdit.Checked = edit;
        }

        /// <summary>
        /// Handles the Click event of the BtnOk control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void BtnOk_Click(object sender, EventArgs e)
        {
            //// Valida 
            bool ret = this.ValidationProviderEditServices.Validate();

            //// Guarda en base de datos el registro
            if (ret)
            {
                Services item = new Services();

                item.IdRequest = int.Parse(this.IdRequest);
                item.IdServiceType = Convert.ToInt32(((ListItem)(this.CmbType.EditValue)).Value);
                item.Context = this.TxtShortDescription.Text;
                item.NumberDays = int.Parse(this.SpinNumberDays.Text);
                item.HoursDay = int.Parse(this.SpinHoursDays.Text);
                item.Description = this.TxtDescriptionTechnical.Text;
                item.ServiceLocation = this.TxtWhereServiceRequired.Text;
                item.Specifications = this.MemoPleaseProvide.Text;
                item.ServiceResult = this.MemoWhatAreProducts.Text;
                item.ExpectedDeliveryDate = this.DteExpectableDeliverableDate.DateTime;
                item.PriorDeliveryDate = this.DtePriorDeliverableDate.DateTime;
                item.DeliveryPlace = this.TxtDeliveryLocationService.Text;
                item.ContactPerson = this.TxtContactPersonServices.Text;
                item.AlternativeDeliveryDate = this.DteExpectedDeliveryDate.DateTime;
                item.Observations = this.MemoObservationsServices.Text;
                item.Active = true;

                using (CustomerServices client = new CustomerServices())
                {
                    if (this.ChkEdit.Checked)
                    {
                        item.IdService = int.Parse(this.IdServices);
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
            using (CustomerParameterDetail client = new CustomerParameterDetail())
            {
                Utilities.SeleccionarValorXDefectoDDLId(this.CmbType, client.GetParameterDetailsByParameter(TypeParameter.ServiceType), 0, true, true);
            }
        }

        /// <summary>
        /// Handles the Click event of the BtnRemove control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnRemove_Click(object sender, EventArgs e)
        {
            DialogResult = XtraMessageBox.Show(" Really you want to delete the record ? ", "Confirmation", MessageBoxButtons.YesNo);
            int Id = int.Parse(this.IdServices);

            if (DialogResult == System.Windows.Forms.DialogResult.Yes)
            {
                using (CustomerServices client = new CustomerServices())
                {
                    client.Delete(Id);
                }

                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }
    }
}