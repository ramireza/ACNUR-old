// ***********************************************************************
// Assembly         : WinApp
// Author           : Mauricio Ospina - Cel: 3204958448 - ambrosio.mauro@gmail.com
// Created          : 02-17-2016
//
// Last Modified By : Mauricio Ospina
// Last Modified On : 04-30-2016
// ***********************************************************************
// <copyright file="FormRequest.cs" company="Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR">
//     Este producto fue desarrollado para Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR. Todos los derechos reservados.
// </copyright>
// <summary>Clase usada para la gestión del purchase</summary>
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
    using DevExpress.XtraBars.Navigation;
    using DevExpress.XtraEditors;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.IO;
    using System.Linq;
    using System.Web.UI.WebControls;
    using System.Windows.Forms;

    /// <summary>
    /// Class FormRequest.
    /// </summary>
    /// <seealso cref="DevExpress.XtraEditors.XtraForm" />
    public partial class FormRequest : DevExpress.XtraEditors.XtraForm
    {
        #region Constructs

        /// <summary>
        /// Initializes a new instance of the <see cref="FormRequest" /> class.
        /// </summary>
        public FormRequest(int idRequest)
        {
            this.InitializeComponent();
            this.LoadComboBox();
            this.HandlerTabs(this.TabRequest);

            this.ControlFileGoods = new ControlFileUpLoad();
            this.PnlFileUpLoadGoods.Controls.Add(this.ControlFileGoods);

            this.ControlFileServices = new ControlFileUpLoad();
            this.PnlFileUpLoadServices.Controls.Add(this.ControlFileServices);

            this.ControlFileEvents = new ControlFileUpLoad();
            this.PnlFileUpLoadEvents.Controls.Add(this.ControlFileEvents);

            this.TxtRequesterPerson.Text = Program.CurrentUserName;
            this.RIEditDelete.ButtonClick += RIEditDelete_ButtonClick;

            if (idRequest > 0)
            {
                this.IdRequest = idRequest;
                this.LoadPurchase(this.IdRequest);
                this.ChkEdit.Checked = true;
            }
        }

        #endregion

        #region Properties

        /// <summary>
        /// The control file goods
        /// </summary>
        ControlFileUpLoad ControlFileGoods;

        /// <summary>
        /// The control file services
        /// </summary>
        ControlFileUpLoad ControlFileServices;

        /// <summary>
        /// The control file events
        /// </summary>
        ControlFileUpLoad ControlFileEvents;

        /// <summary>
        /// Gets or sets the identifier request.
        /// </summary>
        /// <value>The identifier request.</value>
        public int IdRequest
        {
            get
            {
                return String.IsNullOrEmpty(this.LblIdRequest.Text) ? 0 : int.Parse(this.LblIdRequest.Text);
            }

            set
            {
                this.LblIdRequest.Text = value.ToString();
                if (value > 0)
                    this.BtnRemoveRequest.Visible = true;
            }
        }

        /// <summary>
        /// Gets or sets the identifier goods.
        /// </summary>
        /// <value>The identifier goods.</value>
        public int IdGoods
        {
            get
            {
                return (null != this.LblIdGoods.Text && !string.IsNullOrEmpty(this.LblIdGoods.Text)) ? int.Parse(this.LblIdGoods.Text) : 0;
            }

            set
            {
                this.LblIdGoods.Text = value.ToString();
            }
        }

        /// <summary>
        /// Gets or sets the identifier events.
        /// </summary>
        /// <value>The identifier events.</value>
        public int IdEvents
        {
            get
            {
                return (null != this.LblIdEvent.Text && !string.IsNullOrEmpty(this.LblIdEvent.Text)) ? int.Parse(this.LblIdEvent.Text) : 0;
            }

            set
            {
                this.LblIdEvent.Text = value.ToString();
            }
        }

        /// <summary>
        /// Gets or sets the identifier services.
        /// </summary>
        /// <value>The identifier services.</value>
        public int IdServices
        {
            get
            {
                return (null != this.LblIdServices.Text && !string.IsNullOrEmpty(this.LblIdServices.Text)) ? int.Parse(this.LblIdServices.Text) : 0;
            }

            set
            {
                this.LblIdServices.Text = value.ToString();
            }
        }

        /// <summary>
        /// Gets or sets the object request.
        /// </summary>
        /// <value>The object request.</value>
        public Request ObjRequest
        {
            get
            {
                Request item;

                if (this.IdRequest == 0)
                {
                    item = new Request();
                }
                else
                {
                    using (CustomerRequest client = new CustomerRequest())
                    {
                        item = client.GetByID(this.IdRequest);
                    }
                }

                item.RequesterPerson = this.TxtRequesterPerson.Text;
                item.DutyStation = this.TxtDutyStation.Text;
                item.RequestDate = string.IsNullOrEmpty(this.DtpRequestDate.Text) ? Utilities.CalculaFecha(this.DtpRequestDate.Text) : this.DtpRequestDate.DateTime;
                item.IdRequestUnit = this.CmbRequesterUnit.SelectedIndex == 0 ? (new CustomerParameterDetail()).GetParameterDetailsByParameter(TypeParameter.Default).First().IdParameterDetail : Convert.ToInt32(((ListItem)(this.CmbRequesterUnit.SelectedItem)).Value);
                item.Responsible = this.TxtResponsible.Text;
                item.BackgroundRationale = this.MemoBackground.Text;
                item.DeliveryLocation = this.TxtDeliveryLocation.Text;
                item.EstimatedDeliveryDate = string.IsNullOrEmpty(this.DteEstimateDeliveryDateRequest.Text) ? Utilities.CalculaFecha(this.DteEstimateDeliveryDateRequest.Text) : this.DteEstimateDeliveryDateRequest.DateTime;

                return item;
            }

            set
            {
                this.IdRequest = value.IdRequest;
                this.TxtRequesterPerson.Text = value.RequesterPerson;
                this.TxtDutyStation.Text = value.DutyStation;
                this.DtpRequestDate.Text = value.RequestDate == DateTime.MinValue ? string.Empty : value.RequestDate.ToShortDateString();
                this.CmbRequesterUnit.SelectedItem = Utilities.GetItemComboBox(this.CmbRequesterUnit, value.IdRequestUnit);
                this.TxtResponsible.Text = value.Responsible;
                this.MemoBackground.Text = value.BackgroundRationale;
                this.TxtDeliveryLocation.Text = value.DeliveryLocation;
                this.DteEstimateDeliveryDateRequest.Text = value.EstimatedDeliveryDate == DateTime.MinValue ? string.Empty : value.EstimatedDeliveryDate.ToShortDateString();
            }
        }

        /// <summary>
        /// Gets or sets the object goods.
        /// </summary>
        /// <value>The object goods.</value>
        public Goods ObjGoods
        {
            get
            {
                Goods item;

                if (this.IdGoods == 0)
                {
                    item = new Goods();
                }
                else
                {
                    using (CustomerGoods client = new CustomerGoods())
                    {
                        item = client.GetByID(this.IdGoods);
                    }
                }

                item.IdRequest = this.IdRequest;
                item.Quantity = (!string.IsNullOrEmpty(this.SpinQuantity.Text) && Utilities.EsNumerico(this.SpinQuantity.Text)) ? Convert.ToInt32(this.SpinQuantity.Text) : 0;
                item.IdUnitMeasure = Convert.ToInt32(((ListItem)(this.CmbUnitMeasure.SelectedItem)).Value);
                item.Description = this.TxtDescription.Text;
                item.ManufacturerBrand = this.TxtManufactureBrand.Text;
                item.Model = this.TxtModel.Text;
                item.Reference = this.TxtReference.Text;
                item.Dimensions = this.TxtDimensions.Text;
                item.Color = this.TxtColor.Text;
                item.Capacity = this.TxtCapacity.Text;
                item.Power = this.TxtPower.Text;
                item.Other = this.TxtOther.Text;
                item.PlaceDelivery = this.TxtPlaceDelivery.Text;
                item.ContactPerson = this.TxtContactPersonGoods.Text;
                item.ExpectedDeliveryDate = this.DteExpectedDeliveryGoods.DateTime;
                item.Observations = this.MemoObservationsGoods.Text;

                return item;
            }

            set
            {
                this.IdGoods = value.IdGoods;
                this.SpinQuantity.Text = value.Quantity.ToString();

                if (value.IdUnitMeasure.HasValue)
                    this.CmbUnitMeasure.SelectedItem = Utilities.GetItemComboBox(this.CmbUnitMeasure, value.IdUnitMeasure.Value);
                else
                    this.CmbUnitMeasure.SelectedIndex = 0;

                this.TxtDescription.Text = value.Description;
                this.TxtManufactureBrand.Text = value.ManufacturerBrand;
                this.TxtModel.Text = value.Model;
                this.TxtReference.Text = value.Reference;
                this.TxtDimensions.Text = value.Dimensions;
                this.TxtColor.Text = value.Color;
                this.TxtCapacity.Text = value.Capacity;
                this.TxtPower.Text = value.Power;
                this.TxtOther.Text = value.Other;
                this.TxtPlaceDelivery.Text = value.PlaceDelivery;
                this.TxtContactPersonGoods.Text = value.ContactPerson;
                this.DteExpectedDeliveryGoods.Text = value.ExpectedDeliveryDate != DateTime.MinValue ? value.ExpectedDeliveryDate.ToShortDateString() : string.Empty;
                this.MemoObservationsGoods.Text = value.Observations;

                this.LoadFiles(ControlFileGoods, TypeComponent.Goods);
            }
        }

        /// <summary>
        /// Gets or sets the object services.
        /// </summary>
        /// <value>The object services.</value>
        public Services ObjServices
        {
            get
            {
                Services item;

                if (this.IdServices == 0)
                {
                    item = new Services();
                }
                else
                {
                    using (CustomerServices client = new CustomerServices())
                    {
                        item = client.GetByID(this.IdServices);
                    }
                }

                item.IdRequest = this.IdRequest;
                item.Context = this.TxtShortDescription.Text;
                item.NumberDays = (Utilities.EsNumerico(this.SpinNumberDays.Text) && !string.IsNullOrEmpty(this.SpinNumberDays.Text)) ? Convert.ToInt32(this.SpinNumberDays.Text) : 0;
                item.HoursDay = (Utilities.EsNumerico(this.SpinHoursDays.Text) && !string.IsNullOrEmpty(this.SpinHoursDays.Text)) ? Convert.ToInt32(this.SpinHoursDays.Text) : 0;
                item.IdServiceType = this.CmbType.SelectedIndex == 0 ? (new CustomerParameterDetail()).GetParameterDetailsByParameter(TypeParameter.Default).First().IdParameterDetail : Convert.ToInt32(((ListItem)(this.CmbType.SelectedItem)).Value);
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

                return item;
            }

            set
            {
                this.IdServices = value.IdService;
                this.TxtShortDescription.Text = value.Context;
                this.SpinNumberDays.Text = value.NumberDays.ToString();
                this.SpinHoursDays.Text = value.HoursDay.ToString();

                if (value.IdServiceType > 0)
                    this.CmbType.SelectedItem = Utilities.GetItemComboBox(this.CmbType, value.IdServiceType);
                else
                    this.CmbType.SelectedIndex = 0;

                this.TxtDescriptionTechnical.Text = value.Description;
                this.TxtWhereServiceRequired.Text = value.ServiceLocation;
                this.MemoPleaseProvide.Text = value.Specifications;
                this.MemoWhatAreProducts.Text = value.ServiceResult;
                this.DteExpectableDeliverableDate.Text = value.ExpectedDeliveryDate != DateTime.MinValue ? value.ExpectedDeliveryDate.ToShortDateString() : string.Empty;
                this.DtePriorDeliverableDate.Text = value.PriorDeliveryDate != DateTime.MinValue ? value.PriorDeliveryDate.ToShortDateString() : string.Empty;
                this.TxtDeliveryLocationService.Text = value.DeliveryPlace;
                this.TxtContactPersonServices.Text = value.ContactPerson;
                this.DteExpectedDeliveryDate.Text = value.AlternativeDeliveryDate == DateTime.MinValue ? string.Empty : value.AlternativeDeliveryDate.ToShortDateString();
                this.MemoObservationsServices.Text = value.Observations;

                this.LoadFiles(ControlFileServices, TypeComponent.Services);
            }
        }

        /// <summary>
        /// Gets or sets the object events.
        /// </summary>
        /// <value>The object events.</value>
        public Events ObjEvents
        {
            get
            {
                Events item;

                if (this.IdEvents == 0)
                {
                    item = new Events();
                }
                else
                {
                    using (CustomerEvents client = new CustomerEvents())
                    {
                        item = client.GetByID(this.IdEvents);
                    }
                }

                item.IdRequest = this.IdRequest;
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
                item.IdAccommodationType = this.CmbAccomodationType.SelectedIndex == 0 ? (new CustomerParameterDetail()).GetParameterDetailsByParameter(TypeParameter.Default).First().IdParameterDetail : Convert.ToInt32(((ListItem)(this.CmbAccomodationType.SelectedItem)).Value);
                item.Breakfast = this.ChkBreakFast.Checked;
                item.CoffeBreakAM = this.ChkCoffeBreakAM.Checked;
                item.CoffeBreakPM = this.ChkCoffeBreakPM.Checked;
                item.Dinner = this.ChkDinner.Checked;
                item.Lunch = this.ChkLunch.Checked;

                return item;
            }

            set
            {
                this.IdEvents = value.IdEvent;
                this.TxtNameEvent.Text = value.EventName;
                this.DteStarDate.Text = value.StartDate == DateTime.MinValue ? string.Empty : value.StartDate.ToShortDateString();
                this.DteEndDate.Text = value.EndDate == DateTime.MinValue ? string.Empty : value.EndDate.ToShortDateString();
                this.TimeStartTime.EditValue = value.StartTime;
                this.TimeEndTime.EditValue = value.EndTime;
                this.SpinNumberParticipants.Text = value.NumberParticipants.ToString();
                this.ChkVideoBeam.Checked = value.VideoBeam;
                this.ChkFlipchart.Checked = value.Flipchart;
                this.SpinQttyFlipchart.Text = value.FlipchartQuantity.ToString();
                this.ChkInternet.Checked = value.Internet;
                this.SpinBandwithMin.Text = value.MinimumBandwith.ToString();
                this.ChkRentedComputers.Checked = value.RentedComputers;
                this.SpinQttyRentedComputers.Text = value.RentedComputerQuantity.ToString();
                this.TxtSpecificationRentedComputers.Text = value.ComputerSpecifications;
                this.ChkMicrophoneAmplification.Checked = value.MicrophoneAmplification;
                this.TxtSpecificationMicrophoneAmplification.Text = value.MicrophoneSpecifications;
                this.ChkSimultaneousTranslation.Checked = value.SimultaneusTranslation;
                this.TxtLanguage.Text = value.Language;
                this.MemoOtherResource.Text = value.OtherResources;
                this.SpinNumberPassengers.Text = value.NumberPassengers.ToString();
                this.TxtOrigin.Text = value.Origin;
                this.TxtDestination.Text = value.Destination;
                this.SpinNumberRooms.Text = value.NumberRooms.ToString();

                if (value.IdAccommodationType > 0)
                    this.CmbAccomodationType.SelectedItem = Utilities.GetItemComboBox(this.CmbAccomodationType, value.IdAccommodationType);
                else
                    this.CmbAccomodationType.SelectedIndex = 0;

                this.ChkBreakFast.Checked = value.Breakfast;
                this.ChkCoffeBreakAM.Checked = value.CoffeBreakAM;
                this.ChkCoffeBreakPM.Checked = value.CoffeBreakPM;
                this.ChkDinner.Checked = value.Dinner;
                this.ChkLunch.Checked = value.Lunch;

                this.LoadFiles(ControlFileEvents, TypeComponent.Events);
            }
        }

        /// <summary>
        /// Gets or sets the data purchase.
        /// </summary>
        /// <value>The data purchase.</value>
        public string DataPurchase
        {
            get { return this.LblDataPurchase.Text; }
            set { this.LblDataPurchase.Text = value; }
        }

        #endregion

        #region Init Request

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
        /// <param name="idRequest">The identifier request.</param>
        /// <param name="edit">The edit.</param>
        public void InitData(Form frm, int idRequest, Boolean edit)
        {
            this.InitLocation(frm);

            if (edit)
            {
                this.LoadPurchase(idRequest);
            }

            this.ChkEdit.Checked = edit;
        }

        public void LoadPurchase(int idRequest)
        {
            this.IdRequest = idRequest;
            List<ListRequest> ListSource = new List<ListRequest>();

            if (this.IdRequest > 0)
            {
                using (CustomerRequest client = new CustomerRequest())
                {
                    this.ObjRequest = client.GetByID(this.IdRequest);
                }

                using (CustomerGoods client = new CustomerGoods())
                {
                    client.Search(good => good.IdRequest == idRequest, false, null).ToList().ForEach(item => ListSource.Add(this.LoadGoods(item)));
                }

                using (CustomerServices client = new CustomerServices())
                {
                    client.Search(service => service.IdRequest == idRequest, false, null).ToList().ForEach(item => ListSource.Add(this.LoadServices(item)));
                }

                using (CustomerEvents client = new CustomerEvents())
                {
                    client.Search(events => events.IdRequest == idRequest, false, null).ToList().ForEach(item => ListSource.Add(this.LoadEvents(item)));
                }
            }

            this.GrcPurchase.DataSource = ListSource;
        }

        #endregion

        #region Events Buttons Add

        /// <summary>
        /// Handles the Click event of the BtnOkGoods control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void BtnOkGoods_Click(object sender, EventArgs e)
        {
            //// Valida 
            bool ret = this.ValidationProviderEditGoods.Validate();

            if (ret)
            {
                this.ValidateRequest();

                using (CustomerGoods client = new CustomerGoods())
                {
                    if (this.IdGoods == 0)
                    {
                        this.IdGoods = client.Add(this.ObjGoods).IdGoods;
                    }
                    else
                    {
                        client.Update(this.ObjGoods);
                    }
                }

                this.RefreshGridAdd(this.LoadGoods(this.ObjGoods));
                this.HandlerTabs(this.TabRequest);
                this.SaveFiles(this.ControlFileGoods, TypeComponent.Goods);
            }

            this.DialogResult = DialogResult.None;
        }

        /// <summary>
        /// Loads the goods.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns>ListRequest.</returns>
        private ListRequest LoadGoods(Goods item)
        {
            return new ListRequest()
            {
                Description = item.Description,
                Id = item.IdGoods,
                Type = TypeComponent.Goods.ToString(),
                Active = item.Active
            };
        }

        /// <summary>
        /// Handles the Click event of the BtnOkServices control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void BtnOkServices_Click(object sender, EventArgs e)
        {
            //// Valida 
            bool ret = this.ValidationProviderEditServices.Validate();

            if (ret)
            {
                this.ValidateRequest();

                using (CustomerServices client = new CustomerServices())
                {
                    if (this.IdServices == 0)
                    {
                        this.IdServices = client.Add(this.ObjServices).IdService;
                    }
                    else
                    {
                        client.Update(this.ObjServices);
                    }
                }

                this.RefreshGridAdd(this.LoadServices(this.ObjServices));
                this.HandlerTabs(this.TabRequest);
                this.SaveFiles(this.ControlFileServices, TypeComponent.Services);
            }

            this.DialogResult = DialogResult.None;
        }

        /// <summary>
        /// Loads the services.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns>ListRequest.</returns>
        private ListRequest LoadServices(Services item)
        {
            return new ListRequest()
            {
                Description = item.Context,
                Id = item.IdService,
                Type = TypeComponent.Services.ToString(),
                Active = item.Active
            };
        }

        /// <summary>
        /// Handles the Click event of the BtnOkEvents control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void BtnOkEvents_Click(object sender, EventArgs e)
        {
            //// Valida 
            bool ret = this.ValidationProviderEditEvents.Validate();

            if (ret)
            {
                this.ValidateRequest();

                using (CustomerEvents client = new CustomerEvents())
                {
                    if (this.IdEvents == 0)
                    {
                        this.IdEvents = client.Add(this.ObjEvents).IdEvent;
                    }
                    else
                    {
                        client.Update(this.ObjEvents);
                    }
                }

                this.RefreshGridAdd(this.LoadEvents(this.ObjEvents));
                this.HandlerTabs(this.TabRequest);
                this.SaveFiles(this.ControlFileEvents, TypeComponent.Events);
            }

            this.DialogResult = DialogResult.None;
        }

        /// <summary>
        /// Loads the events.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns>ListRequest.</returns>
        private ListRequest LoadEvents(Events item)
        {
            return new ListRequest()
            {
                Description = item.EventName,
                Id = item.IdEvent,
                Type = TypeComponent.Events.ToString(),
                Active = item.Active
            };
        }

        /// <summary>
        /// Validates the request.
        /// </summary>
        private void ValidateRequest()
        {
            if (this.IdRequest == 0)
            {
                using (CustomerRequest client = new CustomerRequest())
                {
                    this.IdRequest = client.Add(this.ObjRequest).IdRequest;
                    this.ChkEdit.Checked = true;
                }
            }
        }

        /// <summary>
        /// Handles the Click event of the BtnOkRequest control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void BtnOkRequest_Click(object sender, EventArgs e)
        {
            //// Valida 
            bool ret = this.ValidationProviderEditPurchase.Validate();

            //// Guarda en base de datos el registro
            if (ret)
            {
                Request req = this.ObjRequest;
                req.Active = true;

                using (CustomerRequest client = new CustomerRequest())
                {
                    if (this.ChkEdit.Checked)
                    {
                        client.Update(req);
                    }
                    else
                    {
                        this.IdRequest = client.Add(req).IdRequest;
                    }
                }

                List<Events> ListEvents = new List<Events>();

                //// Activa todos los eventos relacionados
                using (CustomerEvents client = new CustomerEvents())
                {
                    ListEvents = client.Search(item => item.IdRequest == req.IdRequest, false, null).ToList();
                    ListEvents.ForEach(item => client.Activate(item.IdEvent));
                }

                List<Goods> ListGoods = new List<Goods>();

                //// Activa todos lo bienes relacionados
                using (CustomerGoods client = new CustomerGoods())
                {
                    ListGoods = client.Search(item => item.IdRequest == req.IdRequest, false, null).ToList();
                    ListGoods.ForEach(item => client.Activate(item.IdGoods));
                }

                List<Services> ListServices = new List<Services>();

                //// Activa todos los servicios relacinados
                using (CustomerServices client = new CustomerServices())
                {
                    ListServices = client.Search(item => item.IdRequest == req.IdRequest, false, null).ToList();
                    ListServices.ForEach(item => client.Activate(item.IdService));
                }

                //// Guarda la información en la session y retorna el correo
                using (CustomerSession customer = new CustomerSession())
                {
                    this.DataPurchase = customer.SaveSessionPurchase(Program.CurrentMail, Program.CurrentGUID, this.IdRequest, ListGoods, ListEvents, ListServices);
                }

            }

            this.DialogResult = ret ? DialogResult.OK : DialogResult.None;
        }

        #endregion

        #region Events Button Remove

        /// <summary>
        /// Handles the Click event of the BtnRemoveRequest control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void BtnRemoveRequest_Click(object sender, EventArgs e)
        {
            if (this.IdRequest > 0)
            {
                DialogResult = XtraMessageBox.Show("Really you want to delete the record ?. All goods, services and related events are deleted ? ", "Confirmation", MessageBoxButtons.YesNo);
                int Id = this.IdRequest;

                if (DialogResult == System.Windows.Forms.DialogResult.Yes)
                {
                    using (CustomerEvents client = new CustomerEvents())
                    {
                        client.Search(item => item.IdRequest == Id, false, null).ToList().ForEach(item => client.Delete(item.IdEvent));
                    }

                    using (CustomerGoods client = new CustomerGoods())
                    {
                        client.Search(item => item.IdRequest == Id, false, null).ToList().ForEach(item => client.Delete(item.IdGoods));
                    }

                    using (CustomerServices client = new CustomerServices())
                    {
                        client.Search(item => item.IdRequest == Id, false, null).ToList().ForEach(item => client.Delete(item.IdService));
                    }

                    using (CustomerRequest client = new CustomerRequest())
                    {
                        client.Delete(Id);
                    }

                    DialogResult = DialogResult.OK;
                }
                else
                {
                    DialogResult = DialogResult.None;
                }
            }
            else
            {
                DialogResult = DialogResult.None;
            }
        }

        /// <summary>
        /// Handles the Click event of the BtnRemoveGoods control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void BtnRemoveGoods_Click(object sender, EventArgs e)
        {
            if (this.IdGoods > 0)
            {
                DialogResult = XtraMessageBox.Show(" Really you want to delete the record ? ", "Confirmation", MessageBoxButtons.YesNo);

                if (DialogResult == System.Windows.Forms.DialogResult.Yes)
                {
                    Goods good;

                    using (CustomerGoods client = new CustomerGoods())
                    {
                        good = client.GetByID(this.IdGoods);
                        client.Delete(this.IdGoods);
                    }

                    this.RefreshGridRemove(this.LoadGoods(good));
                    this.HandlerTabs(this.TabRequest);
                }
                else
                {
                    DialogResult = DialogResult.None;
                }
            }
            else
            {
                DialogResult = DialogResult.None;
            }
        }

        /// <summary>
        /// Handles the Click event of the BtnRemoveServices control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void BtnRemoveServices_Click(object sender, EventArgs e)
        {
            if (this.IdServices > 0)
            {
                DialogResult = XtraMessageBox.Show(" Really you want to delete the record ? ", "Confirmation", MessageBoxButtons.YesNo);

                if (DialogResult == System.Windows.Forms.DialogResult.Yes)
                {
                    Services service;

                    using (CustomerServices client = new CustomerServices())
                    {
                        service = client.GetByID(this.IdServices);
                        client.Delete(this.IdServices);
                    }

                    this.RefreshGridRemove(this.LoadServices(service));
                    this.HandlerTabs(this.TabRequest);
                }
                else
                {
                    DialogResult = DialogResult.None;
                }
            }
            else
            {
                DialogResult = DialogResult.None;
            }
        }

        /// <summary>
        /// Handles the Click event of the BtnRemoveEvents control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void BtnRemoveEvents_Click(object sender, EventArgs e)
        {
            if (this.IdEvents > 0)
            {
                DialogResult = XtraMessageBox.Show(" Really you want to delete the record ? ", "Confirmation", MessageBoxButtons.YesNo);

                if (DialogResult == System.Windows.Forms.DialogResult.Yes)
                {
                    Events events;

                    using (CustomerEvents client = new CustomerEvents())
                    {
                        events = client.GetByID(this.IdEvents);
                        client.Delete(this.IdEvents);
                    }

                    this.RefreshGridRemove(this.LoadEvents(events));
                    this.HandlerTabs(this.TabRequest);
                }
                else
                {
                    DialogResult = DialogResult.None;
                }
            }
            else
            {
                DialogResult = DialogResult.None;
            }
        }

        #endregion

        #region Events Buttons Redirect

        /// <summary>
        /// Handles the Click event of the BtnGoods control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void BtnGoods_Click(object sender, EventArgs e)
        {
            this.HandlerTabs(this.TabGoods);
            this.ControlFileGoods.GrcFilesFileUpload.DataSource = this.ControlFileGoods.SourceFiles = this.ControlFileGoods.CreateTable();
            this.ObjGoods = new Goods();
            this.DialogResult = DialogResult.None;
        }

        /// <summary>
        /// Handles the Click event of the BtnServices control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void BtnServices_Click(object sender, EventArgs e)
        {
            this.HandlerTabs(this.TabServices);
            this.ControlFileServices.GrcFilesFileUpload.DataSource = this.ControlFileServices.SourceFiles = this.ControlFileServices.CreateTable();
            this.ObjServices = new Services();
            this.DialogResult = DialogResult.None;
        }

        /// <summary>
        /// Handles the Click event of the BtnEvents control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void BtnEvents_Click(object sender, EventArgs e)
        {
            this.HandlerTabs(this.TabEvents);
            this.ControlFileEvents.GrcFilesFileUpload.DataSource = this.ControlFileEvents.SourceFiles = this.ControlFileEvents.CreateTable();
            this.ObjEvents = new Events();
            this.DialogResult = DialogResult.None;
        }

        /// <summary>
        /// Handles the Click event of the BtnPurchaseGoods control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void BtnPurchaseRequest_Click(object sender, EventArgs e)
        {
            this.HandlerTabs(this.TabRequest);
            this.DialogResult = DialogResult.None;
        }

        #endregion

        #region Utilitys

        /// <summary>
        /// Loads the ComboBox.
        /// </summary>
        private void LoadComboBox()
        {
            using (CustomerParameterDetail customer = new CustomerParameterDetail())
            {
                Utilities.SeleccionarValorXDefectoDDLId(this.CmbUnitMeasure, customer.GetParameterDetailsByParameter(TypeParameter.UnitMeasure), 0, true, true);
                Utilities.SeleccionarValorXDefectoDDLId(this.CmbType, customer.GetParameterDetailsByParameter(TypeParameter.ServiceType), 0, true, true);
                Utilities.SeleccionarValorXDefectoDDLId(this.CmbRequesterUnit, customer.GetParameterDetailsByParameter(TypeParameter.Unit), 0, true, true);
                Utilities.SeleccionarValorXDefectoDDLId(this.CmbAccomodationType, customer.GetParameterDetailsByParameter(TypeParameter.AccommodationType), 0, true, true);
            }
        }

        /// <summary>
        /// Ocultars the tabs.
        /// </summary>
        /// <param name="Tab">The tab.</param>
        private void HandlerTabs(TabNavigationPage Tab)
        {
            this.TabGoods.Hide();
            this.TabServices.Hide();
            this.TabEvents.Hide();
            this.TabRequest.Hide();

            this.TabGoods.PageVisible = false;
            this.TabServices.PageVisible = false;
            this.TabEvents.PageVisible = false;
            this.TabRequest.PageVisible = false;

            Tab.PageVisible = true;
            Tab.Show();
        }

        /// <summary>
        /// Refreshes the grid add.
        /// </summary>
        /// <param name="item">The item.</param>
        private void RefreshGridAdd(ListRequest item)
        {
            List<ListRequest> listExist = null != this.GrcPurchase.DataSource ? (List<ListRequest>)this.GrcPurchase.DataSource : new List<ListRequest>();

            if (listExist.Exists(e => e.Id == item.Id && e.Type == item.Type))
            {
                ListRequest remove = listExist.First(e => e.Id == item.Id && e.Type == item.Type);
                listExist.Remove(remove);
            }

            listExist.Add(item);
            this.BindGrid(listExist);
        }

        /// <summary>
        /// Refreshes the grid remove.
        /// </summary>
        /// <param name="item">The item.</param>
        private void RefreshGridRemove(ListRequest item)
        {
            List<ListRequest> listExist = null != this.GrcPurchase.DataSource ? (List<ListRequest>)this.GrcPurchase.DataSource : new List<ListRequest>();
            listExist.RemoveAll(e => e.Type == item.Type && e.Id == item.Id);
            this.BindGrid(listExist);
        }

        /// <summary>
        /// Binds the grid.
        /// </summary>
        /// <param name="listExist">The list exist.</param>
        private void BindGrid(List<ListRequest> listExist)
        {
            this.GrcPurchase.DataSource = null;
            this.GrcPurchase.Refresh();
            this.GrcPurchase.DataSource = listExist;
            this.GrvPurchase.UpdateCurrentRow();
        }

        /// <summary>
        /// Loads the body purchase.
        /// </summary>
        /// <returns>System.String.</returns>
        internal string LoadBodyPurchase()
        {
            return this.DataPurchase;
        }

        /// <summary>
        /// Saves the files.
        /// </summary>
        /// <param name="controlFile">The control file goods.</param>
        /// <param name="type">The type.</param>
        private void SaveFiles(ControlFileUpLoad controlFile, TypeComponent type)
        {
            DataTable dt = (DataTable)controlFile.GrcFilesFileUpload.DataSource;
            int IdTable = type == TypeComponent.Goods ? this.IdGoods : (type == TypeComponent.Events ? this.IdEvents : (type == TypeComponent.Services ? this.IdServices : this.IdRequest));
            int IdDefecto = (new CustomerParameterDetail()).GetParameterDetailsByParameter(TypeParameter.Default).First().IdParameterDetail;
            int IdCompByModule = (new CustomerComponentsByModule()).GetIdComponentsByModuleByComponentNameAndModuleName(type.ToString(), TypeModule.Purchase.ToString());

            using (CustomerAttachments customer = new CustomerAttachments())
            {
                foreach (DataRow item in dt.Rows)
                {
                    Attachments File = new Attachments();
                    File.IdInformation = IdTable;
                    File.AttachmentName = item[1].ToString();
                    File.Description = item[2].ToString();
                    File.IdAttachmentType = IdDefecto;
                    File.IdAttachmentCondition = IdDefecto;
                    File.IdComponentByModule = IdCompByModule;
                    File.Attachment = (byte[])item.ItemArray[3];

                    //// Si es un archivo nuevo, los adiciona
                    if (Convert.ToInt32(item[0]) == 0)
                    {
                        customer.Add(File);
                        item[0] = File.IdAttachment;
                        controlFile.GrvFilesFileUpload.UpdateCurrentRow();
                    }
                }
            }

            controlFile.GrcFilesFileUpload.DataSource = null;
        }

        /// <summary>
        /// Loads the files.
        /// </summary>
        /// <param name="controlFile">The control file.</param>
        /// <param name="type">The type.</param>
        private void LoadFiles(ControlFileUpLoad controlFile, TypeComponent type)
        {
            //// Limpia las fuentes de datos para colocar los archivos del componente
            controlFile.GrcFilesFileUpload.DataSource = controlFile.SourceFiles = this.ControlFileEvents.CreateTable();

            int IdTable = type == TypeComponent.Goods ? this.IdGoods : (type == TypeComponent.Events ? this.IdEvents : (type == TypeComponent.Services ? this.IdServices : this.IdRequest));

            if (IdTable > 0)
            {
                int IdCompByModule = (new CustomerComponentsByModule()).GetIdComponentsByModuleByComponentNameAndModuleName(type.ToString(), TypeModule.Purchase.ToString());
                List<Attachments> ListResult = new List<Attachments>();

                using (CustomerAttachments customer = new CustomerAttachments())
                {
                    ListResult = customer.GetAttachmentsByIdModule(IdCompByModule, IdTable);
                }

                if (ListResult.Count() > 0)
                {
                    controlFile.GrcFilesFileUpload.DataSource = controlFile.SourceFiles = this.LoadSourceFiles(ListResult, (DataTable)controlFile.GrcFilesFileUpload.DataSource);
                }
            }
        }

        /// <summary>
        /// Loads the source files.
        /// </summary>
        /// <param name="ListResult">The list result.</param>
        /// <param name="dataTable">The data table.</param>
        /// <returns>DataTable.</returns>
        private DataTable LoadSourceFiles(List<Attachments> ListResult, DataTable dataTable)
        {
            ListResult.ForEach(delegate(Attachments file)
            {
                object[] values = new object[] { file.IdAttachment, file.AttachmentName, file.Description, file.Attachment };
                dataTable.Rows.Add(values);
            });

            return dataTable;
        }

        #endregion

        #region Event Delete and edit

        /// <summary>
        /// Handles the ButtonClick event of the RIEditDelete control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DevExpress.XtraEditors.Controls.ButtonPressedEventArgs" /> instance containing the event data.</param>
        private void RIEditDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //// Obtiene los parámetros del Id y cual de los procesos quiere borrar
            int Id = (int)this.GrvPurchase.GetListSourceRowCellValue(this.GrvPurchase.GetFocusedDataSourceRowIndex(), this.ColId);
            string Process = this.GrvPurchase.GetListSourceRowCellValue(this.GrvPurchase.GetFocusedDataSourceRowIndex(), this.ColType).ToString();
            TypeComponent Type = (TypeComponent)Enum.Parse(typeof(TypeComponent), Process);

            //// Valida si esta editanto o eliminando
            if (e.Button.Index == 1)
            {
                DialogResult = XtraMessageBox.Show(" Really you want to delete the record ? ", "Confirmation", MessageBoxButtons.YesNo);
            }

            if (DialogResult == DialogResult.No)
            {
                DialogResult = DialogResult.None;
                return;
            }

            switch (Type)
            {
                case TypeComponent.Goods:
                    switch (e.Button.Index)
                    {
                        case 0:
                            using (CustomerGoods client = new CustomerGoods())
                            {
                                this.IdGoods = Id;
                                this.ObjGoods = client.GetByID(Id);
                            }

                            this.HandlerTabs(this.TabGoods);
                            break;
                        case 1:
                            Goods good;
                            using (CustomerGoods client = new CustomerGoods())
                            {
                                good = client.GetByID(Id);
                                client.Delete(Id);
                            }
                            this.RemoveFiles(TypeComponent.Goods, this.IdGoods);
                            this.RefreshGridRemove(this.LoadGoods(good));
                            break;
                    }
                    break;
                case TypeComponent.Services:
                    switch (e.Button.Index)
                    {
                        case 0:
                            using (CustomerServices client = new CustomerServices())
                            {
                                this.IdServices = Id;
                                this.ObjServices = client.GetByID(Id);
                            }

                            this.HandlerTabs(this.TabServices);
                            break;
                        case 1:
                            Services service;
                            using (CustomerServices client = new CustomerServices())
                            {
                                service = client.GetByID(Id);
                                client.Delete(Id);
                            }
                            this.RemoveFiles(TypeComponent.Services, this.IdServices);
                            this.RefreshGridRemove(this.LoadServices(service));
                            break;
                    }
                    break;
                case TypeComponent.Events:
                    switch (e.Button.Index)
                    {
                        case 0:
                            using (CustomerEvents client = new CustomerEvents())
                            {
                                this.IdEvents = Id;
                                this.ObjEvents = client.GetByID(Id);
                            }

                            this.HandlerTabs(this.TabEvents);
                            break;
                        case 1:
                            Events events;
                            using (CustomerEvents client = new CustomerEvents())
                            {
                                events = client.GetByID(Id);
                                client.Delete(Id);
                            }
                            this.RemoveFiles(TypeComponent.Events, this.IdEvents);
                            this.RefreshGridRemove(this.LoadEvents(events));
                            break;
                    }
                    break;
            }

            DialogResult = DialogResult.None;
        }

        /// <summary>
        /// Removes the files.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="idInformation">The identifier information.</param>
        private void RemoveFiles(TypeComponent type, int idInformation)
        {
            int IdCompByModule = (new CustomerComponentsByModule()).GetIdComponentsByModuleByComponentNameAndModuleName(type.ToString(), TypeModule.Purchase.ToString());

            using (CustomerAttachments customer = new CustomerAttachments())
            {
                customer.RemoveFilesCurrent(IdCompByModule, idInformation);
            }
        }

        #endregion

        #region Validations

        /// <summary>
        /// Handles the SelectedIndexChanged event of the CmbType control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void CmbType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.CmbType.SelectedIndex > 0)
            {
                this.ValidationProviderEditServices.SetValidationRule(this.TxtDescriptionTechnical, Utilities.ValidationRuleNotEmpty());
            }
            else
            {
                Utilities.ValidationRemoveRule(this.ValidationProviderEditServices, this.TxtDescriptionTechnical);
            }
        }

        /// <summary>
        /// Handles the EditValueChanged event of the MemoWhatAreProducts control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void MemoWhatAreProducts_EditValueChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(this.MemoWhatAreProducts.Text.Trim()) && !string.IsNullOrEmpty(this.MemoWhatAreProducts.Text.Trim()))
            {
                this.ValidationProviderEditServices.SetValidationRule(this.DtePriorDeliverableDate, Utilities.ValidationRuleNotEmpty());
            }
            else
            {
                Utilities.ValidationRemoveRule(this.ValidationProviderEditServices, this.DtePriorDeliverableDate);
            }
        }

        /// <summary>
        /// Handles the CheckedChanged event of the ChkFlipchart control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void ChkFlipchart_CheckedChanged(object sender, EventArgs e)
        {
            if (this.ChkFlipchart.Checked)
            {
                this.ValidationProviderEditEvents.SetValidationRule(this.SpinQttyFlipchart, Utilities.ValidationRuleBetween(1, 1000));
            }
            else
            {
                Utilities.ValidationRemoveRule(this.ValidationProviderEditEvents, this.SpinQttyFlipchart);
            }
        }

        /// <summary>
        /// Handles the CheckedChanged event of the ChkInternet control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void ChkInternet_CheckedChanged(object sender, EventArgs e)
        {
            if (this.ChkInternet.Checked)
            {
                this.ValidationProviderEditEvents.SetValidationRule(this.SpinBandwithMin, Utilities.ValidationRuleBetween(1, 1000));
            }
            else
            {
                Utilities.ValidationRemoveRule(this.ValidationProviderEditEvents, this.SpinBandwithMin);
            }
        }

        /// <summary>
        /// Handles the CheckedChanged event of the ChkRentedComputers control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void ChkRentedComputers_CheckedChanged(object sender, EventArgs e)
        {
            if (this.ChkRentedComputers.Checked)
            {
                this.ValidationProviderEditEvents.SetValidationRule(this.SpinQttyRentedComputers, Utilities.ValidationRuleBetween(1, 100));
                this.ValidationProviderEditEvents.SetValidationRule(this.TxtSpecificationRentedComputers, Utilities.ValidationRuleNotEmpty());
            }
            else
            {
                Utilities.ValidationRemoveRule(this.ValidationProviderEditEvents, this.SpinQttyRentedComputers);
                Utilities.ValidationRemoveRule(this.ValidationProviderEditEvents, this.TxtSpecificationRentedComputers);
            }
        }

        /// <summary>
        /// Handles the CheckedChanged event of the ChkMicrophoneAmplification control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void ChkMicrophoneAmplification_CheckedChanged(object sender, EventArgs e)
        {
            if (this.ChkMicrophoneAmplification.Checked)
            {
                this.ValidationProviderEditEvents.SetValidationRule(this.TxtSpecificationMicrophoneAmplification, Utilities.ValidationRuleNotEmpty());
            }
            else
            {
                Utilities.ValidationRemoveRule(this.ValidationProviderEditEvents, this.TxtSpecificationMicrophoneAmplification);
            }
        }

        /// <summary>
        /// Handles the CheckedChanged event of the ChkSimultaneousTranslation control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void ChkSimultaneousTranslation_CheckedChanged(object sender, EventArgs e)
        {
            if (this.ChkSimultaneousTranslation.Checked)
            {
                this.ValidationProviderEditEvents.SetValidationRule(this.TxtLanguage, Utilities.ValidationRuleNotEmpty());
            }
            else
            {
                Utilities.ValidationRemoveRule(this.ValidationProviderEditEvents, this.TxtLanguage);
            }
        }

        /// <summary>
        /// Handles the EditValueChanged event of the SpinNumberPassengers control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void SpinNumberPassengers_EditValueChanged(object sender, EventArgs e)
        {
            if (this.SpinNumberPassengers.Value > 0)
            {
                this.ValidationProviderEditEvents.SetValidationRule(this.TxtOrigin, Utilities.ValidationRuleNotEmpty());
                this.ValidationProviderEditEvents.SetValidationRule(this.TxtDestination, Utilities.ValidationRuleNotEmpty());
            }
            else
            {
                Utilities.ValidationRemoveRule(this.ValidationProviderEditEvents, this.TxtOrigin);
                Utilities.ValidationRemoveRule(this.ValidationProviderEditEvents, this.TxtDestination);
            }
        }

        /// <summary>
        /// Handles the EditValueChanged event of the SpinNumberRooms control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void SpinNumberRooms_EditValueChanged(object sender, EventArgs e)
        {
            if (this.SpinNumberPassengers.Value > 0)
            {
                this.ValidationProviderEditEvents.SetValidationRule(this.CmbAccomodationType, Utilities.ValidationRuleSelectCombo());
            }
            else
            {
                Utilities.ValidationRemoveRule(this.ValidationProviderEditEvents, this.CmbAccomodationType);
            }
        }

        #endregion
    }
}