// ***********************************************************************
// Assembly         : WinApp
// Author           : Mauricio Ospina - Cel: 3204958448 - ambrosio.mauro@gmail.com
// Created          : 02-18-2016
//
// Last Modified By : Mauricio Ospina
// Last Modified On : 02-25-2016
// ***********************************************************************
// <copyright file="FormEvents.cs" company="Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR">
//     Este producto fue desarrollado para Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR. Todos los derechos reservados.
// </copyright>
// <summary></summary>
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
    /// Class FormEvents.
    /// </summary>
    public partial class FormEvents : DevExpress.XtraEditors.XtraForm
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormEvents" /> class.
        /// </summary>
        public FormEvents()
        {
            InitializeComponent();
            this.LoadComboBox();
        }

        /// <summary>
        /// Gets or sets the identifier event.
        /// </summary>
        /// <value>The identifier event.</value>
        public string IdEvent
        {
            get
            {
                return String.IsNullOrEmpty(this.LblIdEvent.Text) ? "0" : this.LblIdEvent.Text;
            }

            set
            {
                this.LblIdEvent.Text = value;
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
                this.IdEvent = row[0].ToString();
                ((ListItem)(this.CmbAccomodationType.EditValue)).Value = row[2].ToString();
                ((ListItem)(this.CmbAccomodationType.EditValue)).Text = row[32].ToString();
                this.TxtNameEvent.Text = row[3].ToString();
                this.DteStarDate.Text = Convert.ToDateTime(row[4]).ToShortDateString();
                this.DteEndDate.Text = Convert.ToDateTime(row[5]).ToShortDateString();
                this.TimeStartTime.EditValue = row[6].ToString();
                this.TimeEndTime.EditValue = row[7].ToString();
                this.SpinNumberParticipants.Text = row[8].ToString();
                this.ChkVideoBeam.Checked = Convert.ToBoolean(row[9].ToString());
                this.ChkFlipchart.Checked = Convert.ToBoolean(row[10].ToString());
                this.SpinQttyFlipchart.Text = row[11].ToString();
                this.ChkInternet.Checked = Convert.ToBoolean(row[12].ToString());
                this.SpinBandwithMin.Text = row[13].ToString();
                this.ChkRentedComputers.Checked = Convert.ToBoolean(row[14].ToString());
                this.SpinQttyRentedComputers.Text = row[15].ToString();
                this.TxtSpecificationRentedComputers.Text = row[16].ToString(); ;
                this.ChkMicrophoneAmplification.Checked = Convert.ToBoolean(row[17].ToString());
                this.TxtSpecificationMicrophoneAmplification.Text = row[18].ToString();
                this.ChkSimultaneousTranslation.Checked = Convert.ToBoolean(row[19].ToString());
                this.TxtLanguage.Text = row[20].ToString();
                this.MemoOtherResource.Text = row[21].ToString();
                this.SpinNumberPassengers.Text = row[22].ToString();
                this.TxtOrigin.Text = row[23].ToString();
                this.TxtDestination.Text = row[24].ToString();
                this.SpinNumberRooms.Text = row[25].ToString();
                this.ChkBreakFast.Checked = Convert.ToBoolean(row[26].ToString());
                this.ChkCoffeBreakAM.Checked = Convert.ToBoolean(row[27].ToString());
                this.ChkLunch.Checked = Convert.ToBoolean(row[28].ToString());
                this.ChkCoffeBreakPM.Checked = Convert.ToBoolean(row[29].ToString());
                this.ChkDinner.Checked = Convert.ToBoolean(row[30].ToString());
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
            bool ret = this.ValidationProviderEditEvents.Validate();

            //// Guarda en base de datos el registro
            if (ret)
            {
                Events item = new Events();

                item.IdRequest = int.Parse(this.IdRequest);
                item.IdAccommodationType = Convert.ToInt32(((ListItem)(this.CmbAccomodationType.EditValue)).Value);
                item.EventName = this.TxtNameEvent.Text;
                item.StartDate = this.DteStarDate.DateTime;
                item.EndDate = this.DteEndDate.DateTime;
                item.StartTime = this.TimeStartTime.Time.TimeOfDay;
                item.EndTime = this.TimeEndTime.Time.TimeOfDay;
                item.NumberParticipants = int.Parse(this.SpinNumberParticipants.Text);
                item.VideoBeam = this.ChkVideoBeam.Checked;
                item.Flipchart = this.ChkFlipchart.Checked;
                item.FlipchartQuantity = int.Parse(this.SpinQttyFlipchart.Text);
                item.Internet = this.ChkInternet.Checked;
                item.MinimumBandwith = int.Parse(this.SpinBandwithMin.Text);
                item.RentedComputers = this.ChkRentedComputers.Checked;
                item.RentedComputerQuantity = int.Parse(this.SpinQttyRentedComputers.Text);
                item.ComputerSpecifications = this.TxtSpecificationRentedComputers.Text;
                item.MicrophoneAmplification = this.ChkMicrophoneAmplification.Checked;
                item.MicrophoneSpecifications = this.TxtSpecificationMicrophoneAmplification.Text;
                item.SimultaneusTranslation = this.ChkSimultaneousTranslation.Checked;
                item.Language = this.TxtLanguage.Text;
                item.OtherResources = this.MemoOtherResource.Text;
                item.NumberPassengers = int.Parse(this.SpinNumberPassengers.Text);
                item.Origin = this.TxtOrigin.Text;
                item.Destination = this.TxtDestination.Text;
                item.NumberRooms = int.Parse(this.SpinNumberRooms.Text);
                item.Breakfast = this.ChkBreakFast.Checked;
                item.CoffeBreakAM = this.ChkCoffeBreakAM.Checked;
                item.Lunch = this.ChkLunch.Checked;
                item.CoffeBreakPM = this.ChkCoffeBreakPM.Checked;
                item.Dinner = this.ChkDinner.Checked;
                item.Active = true;

                using (CustomerEvents client = new CustomerEvents())
                {
                    if (this.ChkEdit.Checked)
                    {
                        item.IdEvent = int.Parse(this.IdEvent);
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
                Utilities.SeleccionarValorXDefectoDDLId(this.CmbAccomodationType, client.GetParameterDetailsByParameter(TypeParameter.AccommodationType), 0, true, true);
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
            int Id = int.Parse(this.IdEvent);

            if (DialogResult == System.Windows.Forms.DialogResult.Yes)
            {
                using (CustomerEvents client = new CustomerEvents())
                {
                    client.Delete(Id);
                }

                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }
    }
}