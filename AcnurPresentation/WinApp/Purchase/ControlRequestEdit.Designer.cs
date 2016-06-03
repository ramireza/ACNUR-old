namespace WinApp
{
    partial class ControlRequestEdit
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>

        private void InitializeComponent()
        {
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode2 = new DevExpress.XtraGrid.GridLevelNode();
            DevExpress.XtraGrid.GridLevelNode gridLevelNode3 = new DevExpress.XtraGrid.GridLevelNode();
            this.GrvGoods = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColIdGoods = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColIdRequestGoods = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColPlaceDelivery = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColContactPerson = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColExpectedDeliveryDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GrControlRequest = new DevExpress.XtraGrid.GridControl();
            this.GrvServices = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColIdService = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColIdRequestServices = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColContext = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColNumberDays = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColDescriptionServices = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColServiceLocation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GrvEvents = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColIdEvent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColIdRequestEvent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColEventName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColStartDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColStartTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColEndDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColEndTime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.GrvRequest = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColIdRequest = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColIdRequestUnit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColInit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColRequestUnitName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColDutyStation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColRequestDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColResponsible = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColBackgroundRationale = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RIMemoExBackgroundRationale = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.ColDeliveryLocation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColEstimatedDeliveryDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RIDteEstimatedDeliveryDate = new DevExpress.XtraEditors.Repository.RepositoryItemDateEdit();
            this.RIChkActive = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.GrvGoods)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrControlRequest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrvServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrvEvents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrvRequest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RIMemoExBackgroundRationale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RIDteEstimatedDeliveryDate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RIDteEstimatedDeliveryDate.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RIChkActive)).BeginInit();
            this.SuspendLayout();
            // 
            // GrvGoods
            // 
            this.GrvGoods.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.GrvGoods.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GrvGoods.ColumnPanelRowHeight = 0;
            this.GrvGoods.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColIdGoods,
            this.ColIdRequestGoods,
            this.ColQuantity,
            this.ColDescription,
            this.ColPlaceDelivery,
            this.ColContactPerson,
            this.ColExpectedDeliveryDate});
            this.GrvGoods.FixedLineWidth = 1;
            this.GrvGoods.GridControl = this.GrControlRequest;
            this.GrvGoods.Name = "GrvGoods";
            this.GrvGoods.OptionsView.AllowHtmlDrawHeaders = true;
            this.GrvGoods.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateAllContent;
            this.GrvGoods.OptionsView.ColumnAutoWidth = false;
            this.GrvGoods.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.GrvGoods_RowClick);
            // 
            // ColIdGoods
            // 
            this.ColIdGoods.FieldName = "IdGoods";
            this.ColIdGoods.Name = "ColIdGoods";
            this.ColIdGoods.OptionsColumn.ReadOnly = true;
            // 
            // ColIdRequestGoods
            // 
            this.ColIdRequestGoods.FieldName = "IdRequest";
            this.ColIdRequestGoods.Name = "ColIdRequestGoods";
            this.ColIdRequestGoods.OptionsColumn.ReadOnly = true;
            // 
            // ColQuantity
            // 
            this.ColQuantity.Caption = "Quantity";
            this.ColQuantity.FieldName = "Quantity";
            this.ColQuantity.Name = "ColQuantity";
            this.ColQuantity.OptionsColumn.ReadOnly = true;
            this.ColQuantity.Visible = true;
            this.ColQuantity.VisibleIndex = 0;
            this.ColQuantity.Width = 70;
            // 
            // ColDescription
            // 
            this.ColDescription.Caption = "Description";
            this.ColDescription.FieldName = "Description";
            this.ColDescription.Name = "ColDescription";
            this.ColDescription.OptionsColumn.ReadOnly = true;
            this.ColDescription.Visible = true;
            this.ColDescription.VisibleIndex = 1;
            this.ColDescription.Width = 330;
            // 
            // ColPlaceDelivery
            // 
            this.ColPlaceDelivery.Caption = "Place Delivery";
            this.ColPlaceDelivery.FieldName = "PlaceDelivery";
            this.ColPlaceDelivery.Name = "ColPlaceDelivery";
            this.ColPlaceDelivery.OptionsColumn.ReadOnly = true;
            this.ColPlaceDelivery.Visible = true;
            this.ColPlaceDelivery.VisibleIndex = 2;
            this.ColPlaceDelivery.Width = 250;
            // 
            // ColContactPerson
            // 
            this.ColContactPerson.Caption = "Contact Person";
            this.ColContactPerson.FieldName = "ContactPerson";
            this.ColContactPerson.Name = "ColContactPerson";
            this.ColContactPerson.OptionsColumn.ReadOnly = true;
            this.ColContactPerson.Visible = true;
            this.ColContactPerson.VisibleIndex = 3;
            this.ColContactPerson.Width = 250;
            // 
            // ColExpectedDeliveryDate
            // 
            this.ColExpectedDeliveryDate.Caption = "Delivery Date";
            this.ColExpectedDeliveryDate.FieldName = "ExpectedDeliveryDate";
            this.ColExpectedDeliveryDate.Name = "ColExpectedDeliveryDate";
            this.ColExpectedDeliveryDate.OptionsColumn.ReadOnly = true;
            this.ColExpectedDeliveryDate.Visible = true;
            this.ColExpectedDeliveryDate.VisibleIndex = 4;
            this.ColExpectedDeliveryDate.Width = 80;
            // 
            // GrControlRequest
            // 
            this.GrControlRequest.DataMember = "Request";
            this.GrControlRequest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrControlRequest.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.GrControlRequest.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.GrControlRequest.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.GrControlRequest_EmbeddedNavigator_Click);
            gridLevelNode1.LevelTemplate = this.GrvGoods;
            gridLevelNode1.RelationName = "Goods";
            gridLevelNode2.LevelTemplate = this.GrvServices;
            gridLevelNode2.RelationName = "Services";
            gridLevelNode3.LevelTemplate = this.GrvEvents;
            gridLevelNode3.RelationName = "Events";
            this.GrControlRequest.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1,
            gridLevelNode2,
            gridLevelNode3});
            this.GrControlRequest.Location = new System.Drawing.Point(0, 0);
            this.GrControlRequest.MainView = this.GrvRequest;
            this.GrControlRequest.Name = "GrControlRequest";
            this.GrControlRequest.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.RIChkActive,
            this.RIMemoExBackgroundRationale,
            this.RIDteEstimatedDeliveryDate});
            this.GrControlRequest.Size = new System.Drawing.Size(1100, 350);
            this.GrControlRequest.TabIndex = 0;
            this.GrControlRequest.UseEmbeddedNavigator = true;
            this.GrControlRequest.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GrvServices,
            this.GrvEvents,
            this.GrvRequest,
            this.GrvGoods});
            // 
            // GrvServices
            // 
            this.GrvServices.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.GrvServices.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GrvServices.ColumnPanelRowHeight = 0;
            this.GrvServices.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColIdService,
            this.ColIdRequestServices,
            this.ColContext,
            this.ColNumberDays,
            this.ColDescriptionServices,
            this.ColServiceLocation});
            this.GrvServices.FixedLineWidth = 1;
            this.GrvServices.GridControl = this.GrControlRequest;
            this.GrvServices.Name = "GrvServices";
            this.GrvServices.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateAllContent;
            this.GrvServices.OptionsView.ColumnAutoWidth = false;
            this.GrvServices.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.GrvServices_RowClick);
            // 
            // ColIdService
            // 
            this.ColIdService.FieldName = "IdService";
            this.ColIdService.Name = "ColIdService";
            this.ColIdService.OptionsColumn.ReadOnly = true;
            // 
            // ColIdRequestServices
            // 
            this.ColIdRequestServices.FieldName = "IdRequest";
            this.ColIdRequestServices.Name = "ColIdRequestServices";
            this.ColIdRequestServices.OptionsColumn.ReadOnly = true;
            // 
            // ColContext
            // 
            this.ColContext.Caption = "Context";
            this.ColContext.FieldName = "Context";
            this.ColContext.Name = "ColContext";
            this.ColContext.OptionsColumn.ReadOnly = true;
            this.ColContext.Visible = true;
            this.ColContext.VisibleIndex = 0;
            this.ColContext.Width = 242;
            // 
            // ColNumberDays
            // 
            this.ColNumberDays.Caption = "Number Days";
            this.ColNumberDays.FieldName = "NumberDays";
            this.ColNumberDays.Name = "ColNumberDays";
            this.ColNumberDays.OptionsColumn.ReadOnly = true;
            this.ColNumberDays.Visible = true;
            this.ColNumberDays.VisibleIndex = 1;
            this.ColNumberDays.Width = 76;
            // 
            // ColDescriptionServices
            // 
            this.ColDescriptionServices.Caption = "Description";
            this.ColDescriptionServices.FieldName = "Description";
            this.ColDescriptionServices.Name = "ColDescriptionServices";
            this.ColDescriptionServices.OptionsColumn.ReadOnly = true;
            this.ColDescriptionServices.Visible = true;
            this.ColDescriptionServices.VisibleIndex = 2;
            this.ColDescriptionServices.Width = 332;
            // 
            // ColServiceLocation
            // 
            this.ColServiceLocation.Caption = "Service Location";
            this.ColServiceLocation.FieldName = "ServiceLocation";
            this.ColServiceLocation.Name = "ColServiceLocation";
            this.ColServiceLocation.OptionsColumn.ReadOnly = true;
            this.ColServiceLocation.Visible = true;
            this.ColServiceLocation.VisibleIndex = 3;
            this.ColServiceLocation.Width = 350;
            // 
            // GrvEvents
            // 
            this.GrvEvents.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.GrvEvents.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GrvEvents.ColumnPanelRowHeight = 0;
            this.GrvEvents.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColIdEvent,
            this.ColIdRequestEvent,
            this.ColEventName,
            this.ColStartDate,
            this.ColStartTime,
            this.ColEndDate,
            this.ColEndTime});
            this.GrvEvents.FixedLineWidth = 1;
            this.GrvEvents.GridControl = this.GrControlRequest;
            this.GrvEvents.Name = "GrvEvents";
            this.GrvEvents.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateAllContent;
            this.GrvEvents.OptionsView.ColumnAutoWidth = false;
            this.GrvEvents.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.GrvEvents_RowClick);
            // 
            // ColIdEvent
            // 
            this.ColIdEvent.FieldName = "IdEvent";
            this.ColIdEvent.Name = "ColIdEvent";
            this.ColIdEvent.OptionsColumn.ReadOnly = true;
            // 
            // ColIdRequestEvent
            // 
            this.ColIdRequestEvent.FieldName = "IdRequest";
            this.ColIdRequestEvent.Name = "ColIdRequestEvent";
            this.ColIdRequestEvent.OptionsColumn.ReadOnly = true;
            // 
            // ColEventName
            // 
            this.ColEventName.Caption = "Even tName";
            this.ColEventName.FieldName = "EventName";
            this.ColEventName.Name = "ColEventName";
            this.ColEventName.OptionsColumn.ReadOnly = true;
            this.ColEventName.Visible = true;
            this.ColEventName.VisibleIndex = 0;
            this.ColEventName.Width = 520;
            // 
            // ColStartDate
            // 
            this.ColStartDate.Caption = "Start Date";
            this.ColStartDate.FieldName = "StartDate";
            this.ColStartDate.Name = "ColStartDate";
            this.ColStartDate.OptionsColumn.ReadOnly = true;
            this.ColStartDate.Visible = true;
            this.ColStartDate.VisibleIndex = 1;
            this.ColStartDate.Width = 120;
            // 
            // ColStartTime
            // 
            this.ColStartTime.Caption = "Start Time";
            this.ColStartTime.FieldName = "StartTime";
            this.ColStartTime.Name = "ColStartTime";
            this.ColStartTime.OptionsColumn.ReadOnly = true;
            this.ColStartTime.Visible = true;
            this.ColStartTime.VisibleIndex = 3;
            this.ColStartTime.Width = 120;
            // 
            // ColEndDate
            // 
            this.ColEndDate.Caption = "End Date";
            this.ColEndDate.FieldName = "EndDate";
            this.ColEndDate.Name = "ColEndDate";
            this.ColEndDate.OptionsColumn.ReadOnly = true;
            this.ColEndDate.Visible = true;
            this.ColEndDate.VisibleIndex = 2;
            this.ColEndDate.Width = 120;
            // 
            // ColEndTime
            // 
            this.ColEndTime.Caption = "End Time";
            this.ColEndTime.FieldName = "EndTime";
            this.ColEndTime.Name = "ColEndTime";
            this.ColEndTime.OptionsColumn.ReadOnly = true;
            this.ColEndTime.Visible = true;
            this.ColEndTime.VisibleIndex = 4;
            this.ColEndTime.Width = 120;
            // 
            // GrvRequest
            // 
            this.GrvRequest.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.GrvRequest.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GrvRequest.ColumnPanelRowHeight = 0;
            this.GrvRequest.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColIdRequest,
            this.ColIdRequestUnit,
            this.ColInit,
            this.ColRequestUnitName,
            this.ColDutyStation,
            this.ColRequestDate,
            this.ColResponsible,
            this.ColBackgroundRationale,
            this.ColDeliveryLocation,
            this.ColEstimatedDeliveryDate});
            this.GrvRequest.FixedLineWidth = 1;
            this.GrvRequest.GridControl = this.GrControlRequest;
            this.GrvRequest.Name = "GrvRequest";
            this.GrvRequest.OptionsDetail.AllowExpandEmptyDetails = true;
            this.GrvRequest.OptionsDetail.AllowOnlyOneMasterRowExpanded = true;
            this.GrvRequest.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateAllContent;
            this.GrvRequest.OptionsView.ColumnAutoWidth = false;
            this.GrvRequest.RowHeight = 25;
            this.GrvRequest.ViewCaption = "Request";
            this.GrvRequest.MasterRowExpanded += new DevExpress.XtraGrid.Views.Grid.CustomMasterRowEventHandler(this.GrViewRequest_MasterRowExpanded);
            // 
            // ColIdRequest
            // 
            this.ColIdRequest.FieldName = "IdRequest";
            this.ColIdRequest.Name = "ColIdRequest";
            this.ColIdRequest.OptionsColumn.ReadOnly = true;
            // 
            // ColIdRequestUnit
            // 
            this.ColIdRequestUnit.FieldName = "IdRequestUnit";
            this.ColIdRequestUnit.Name = "ColIdRequestUnit";
            this.ColIdRequestUnit.OptionsColumn.ReadOnly = true;
            // 
            // ColInit
            // 
            this.ColInit.Name = "ColInit";
            this.ColInit.OptionsColumn.ReadOnly = true;
            this.ColInit.Visible = true;
            this.ColInit.VisibleIndex = 0;
            this.ColInit.Width = 30;
            // 
            // ColRequestUnitName
            // 
            this.ColRequestUnitName.Caption = "Request Unit";
            this.ColRequestUnitName.FieldName = "RequestUnit";
            this.ColRequestUnitName.Name = "ColRequestUnitName";
            this.ColRequestUnitName.OptionsColumn.ReadOnly = true;
            this.ColRequestUnitName.Visible = true;
            this.ColRequestUnitName.VisibleIndex = 1;
            this.ColRequestUnitName.Width = 150;
            // 
            // ColDutyStation
            // 
            this.ColDutyStation.Caption = "Duty Station";
            this.ColDutyStation.FieldName = "DutyStation";
            this.ColDutyStation.Name = "ColDutyStation";
            this.ColDutyStation.OptionsColumn.ReadOnly = true;
            this.ColDutyStation.Visible = true;
            this.ColDutyStation.VisibleIndex = 2;
            this.ColDutyStation.Width = 185;
            // 
            // ColRequestDate
            // 
            this.ColRequestDate.Caption = "Request Date";
            this.ColRequestDate.FieldName = "RequestDate";
            this.ColRequestDate.Name = "ColRequestDate";
            this.ColRequestDate.OptionsColumn.ReadOnly = true;
            this.ColRequestDate.Visible = true;
            this.ColRequestDate.VisibleIndex = 3;
            this.ColRequestDate.Width = 77;
            // 
            // ColResponsible
            // 
            this.ColResponsible.Caption = "Responsible";
            this.ColResponsible.FieldName = "Responsible";
            this.ColResponsible.Name = "ColResponsible";
            this.ColResponsible.OptionsColumn.ReadOnly = true;
            this.ColResponsible.Visible = true;
            this.ColResponsible.VisibleIndex = 4;
            this.ColResponsible.Width = 188;
            // 
            // ColBackgroundRationale
            // 
            this.ColBackgroundRationale.Caption = "Background Rationale";
            this.ColBackgroundRationale.ColumnEdit = this.RIMemoExBackgroundRationale;
            this.ColBackgroundRationale.FieldName = "BackgroundRationale";
            this.ColBackgroundRationale.Name = "ColBackgroundRationale";
            this.ColBackgroundRationale.OptionsColumn.ReadOnly = true;
            this.ColBackgroundRationale.Visible = true;
            this.ColBackgroundRationale.VisibleIndex = 5;
            this.ColBackgroundRationale.Width = 122;
            // 
            // RIMemoExBackgroundRationale
            // 
            this.RIMemoExBackgroundRationale.AutoHeight = false;
            this.RIMemoExBackgroundRationale.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.RIMemoExBackgroundRationale.Name = "RIMemoExBackgroundRationale";
            this.RIMemoExBackgroundRationale.ReadOnly = true;
            // 
            // ColDeliveryLocation
            // 
            this.ColDeliveryLocation.Caption = "Delivery Location";
            this.ColDeliveryLocation.FieldName = "DeliveryLocation";
            this.ColDeliveryLocation.Name = "ColDeliveryLocation";
            this.ColDeliveryLocation.OptionsColumn.ReadOnly = true;
            this.ColDeliveryLocation.Visible = true;
            this.ColDeliveryLocation.VisibleIndex = 6;
            this.ColDeliveryLocation.Width = 196;
            // 
            // ColEstimatedDeliveryDate
            // 
            this.ColEstimatedDeliveryDate.Caption = "Estimated Delivery Date";
            this.ColEstimatedDeliveryDate.ColumnEdit = this.RIDteEstimatedDeliveryDate;
            this.ColEstimatedDeliveryDate.FieldName = "EstimatedDeliveryDate";
            this.ColEstimatedDeliveryDate.Name = "ColEstimatedDeliveryDate";
            this.ColEstimatedDeliveryDate.OptionsColumn.ReadOnly = true;
            this.ColEstimatedDeliveryDate.Visible = true;
            this.ColEstimatedDeliveryDate.VisibleIndex = 7;
            this.ColEstimatedDeliveryDate.Width = 125;
            // 
            // RIDteEstimatedDeliveryDate
            // 
            this.RIDteEstimatedDeliveryDate.AutoHeight = false;
            this.RIDteEstimatedDeliveryDate.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.RIDteEstimatedDeliveryDate.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.RIDteEstimatedDeliveryDate.Name = "RIDteEstimatedDeliveryDate";
            this.RIDteEstimatedDeliveryDate.ReadOnly = true;
            // 
            // RIChkActive
            // 
            this.RIChkActive.AutoHeight = false;
            this.RIChkActive.Name = "RIChkActive";
            this.RIChkActive.ReadOnly = true;
            // 
            // ControlRequestEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GrControlRequest);
            this.Name = "ControlRequestEdit";
            this.Size = new System.Drawing.Size(1100, 350);
            ((System.ComponentModel.ISupportInitialize)(this.GrvGoods)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrControlRequest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrvServices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrvEvents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrvRequest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RIMemoExBackgroundRationale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RIDteEstimatedDeliveryDate.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RIDteEstimatedDeliveryDate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RIChkActive)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GrControlRequest;
        private DevExpress.XtraGrid.Views.Grid.GridView GrvRequest;
        private DevExpress.XtraGrid.Columns.GridColumn ColDutyStation;
        private DevExpress.XtraGrid.Columns.GridColumn ColRequestDate;
        private DevExpress.XtraGrid.Columns.GridColumn ColResponsible;
        private DevExpress.XtraGrid.Columns.GridColumn ColIdRequest;
        private DevExpress.XtraGrid.Columns.GridColumn ColIdRequestUnit;
        private DevExpress.XtraGrid.Columns.GridColumn ColBackgroundRationale;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit RIChkActive;
        private DevExpress.XtraGrid.Columns.GridColumn ColRequestUnitName;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit RIMemoExBackgroundRationale;
        private DevExpress.XtraGrid.Columns.GridColumn ColDeliveryLocation;
        private DevExpress.XtraGrid.Columns.GridColumn ColEstimatedDeliveryDate;
        private DevExpress.XtraEditors.Repository.RepositoryItemDateEdit RIDteEstimatedDeliveryDate;
        private DevExpress.XtraGrid.Views.Grid.GridView GrvGoods;
        private DevExpress.XtraGrid.Views.Grid.GridView GrvServices;
        private DevExpress.XtraGrid.Views.Grid.GridView GrvEvents;
        private DevExpress.XtraGrid.Columns.GridColumn ColQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn ColIdGoods;
        private DevExpress.XtraGrid.Columns.GridColumn ColIdRequestGoods;
        private DevExpress.XtraGrid.Columns.GridColumn ColDescription;
        private DevExpress.XtraGrid.Columns.GridColumn ColPlaceDelivery;
        private DevExpress.XtraGrid.Columns.GridColumn ColContactPerson;
        private DevExpress.XtraGrid.Columns.GridColumn ColExpectedDeliveryDate;
        private DevExpress.XtraGrid.Columns.GridColumn ColIdService;
        private DevExpress.XtraGrid.Columns.GridColumn ColIdRequestServices;
        private DevExpress.XtraGrid.Columns.GridColumn ColContext;
        private DevExpress.XtraGrid.Columns.GridColumn ColNumberDays;
        private DevExpress.XtraGrid.Columns.GridColumn ColDescriptionServices;
        private DevExpress.XtraGrid.Columns.GridColumn ColServiceLocation;
        private DevExpress.XtraGrid.Columns.GridColumn ColIdEvent;
        private DevExpress.XtraGrid.Columns.GridColumn ColIdRequestEvent;
        private DevExpress.XtraGrid.Columns.GridColumn ColEventName;
        private DevExpress.XtraGrid.Columns.GridColumn ColStartDate;
        private DevExpress.XtraGrid.Columns.GridColumn ColEndDate;
        private DevExpress.XtraGrid.Columns.GridColumn ColInit;
        private DSRequest dsRequest;
        private DevExpress.XtraGrid.Columns.GridColumn ColStartTime;
        private DevExpress.XtraGrid.Columns.GridColumn ColEndTime;
    }
}
