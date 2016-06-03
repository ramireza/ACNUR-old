namespace WinAdministrator.Views.OperationsView
{
    partial class OperationsView
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
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.IdOperationTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.operationsViewBindingSource = new System.Windows.Forms.BindingSource();
            this.NameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.OperationsModuleXtraUserControl = new DevExpress.XtraEditors.XtraUserControl();
            this.OperationsModuleGridControl = new DevExpress.XtraGrid.GridControl();
            this.OperationsModuleBindingSource = new System.Windows.Forms.BindingSource();
            this.OperationsModuleGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdOperationModule = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdOperation = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdModule = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModules = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOperations = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOperationsModuleUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForIdOperation = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForName = new DevExpress.XtraLayout.LayoutControlItem();
            this.tabbedControlGroup1 = new DevExpress.XtraLayout.TabbedControlGroup();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForOperationsModule = new DevExpress.XtraLayout.LayoutControlItem();
            this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext();
            this.windowsUIButtonPanelCloseButton = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.windowsUIButtonPanelMain = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.labelControl = new DevExpress.XtraEditors.LabelControl();
            this.OperationsModuleBarManager = new DevExpress.XtraBars.BarManager();
            this.OperationsModuleBar = new DevExpress.XtraBars.Bar();
            this.bbiOperationsModuleNew = new DevExpress.XtraBars.BarButtonItem();
            this.bbiOperationsModuleEdit = new DevExpress.XtraBars.BarButtonItem();
            this.bbiOperationsModuleDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiOperationsModuleRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.OperationsModulePopUpMenu = new DevExpress.XtraBars.PopupMenu();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IdOperationTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationsViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameTextEdit.Properties)).BeginInit();
            this.OperationsModuleXtraUserControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OperationsModuleGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OperationsModuleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OperationsModuleGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIdOperation)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForOperationsModule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OperationsModuleBarManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OperationsModulePopUpMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.AllowCustomization = false;
            this.dataLayoutControl1.Controls.Add(this.IdOperationTextEdit);
            this.dataLayoutControl1.Controls.Add(this.NameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.OperationsModuleXtraUserControl);
            this.dataLayoutControl1.DataSource = this.operationsViewBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(45, 30);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(979, 678);
            this.dataLayoutControl1.TabIndex = 0;
            // 
            // IdOperationTextEdit
            // 
            this.IdOperationTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.operationsViewBindingSource, "IdOperation", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.IdOperationTextEdit.Location = new System.Drawing.Point(76, 12);
            this.IdOperationTextEdit.Name = "IdOperationTextEdit";
            this.IdOperationTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.IdOperationTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.IdOperationTextEdit.Properties.Mask.EditMask = "N0";
            this.IdOperationTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.IdOperationTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.IdOperationTextEdit.Size = new System.Drawing.Size(891, 20);
            this.IdOperationTextEdit.StyleController = this.dataLayoutControl1;
            this.IdOperationTextEdit.TabIndex = 4;
            // 
            // operationsViewBindingSource
            // 
            this.operationsViewBindingSource.DataSource = typeof(Acnur.App.Repository.Data.Operations);
            // 
            // NameTextEdit
            // 
            this.NameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.operationsViewBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.NameTextEdit.Location = new System.Drawing.Point(76, 36);
            this.NameTextEdit.Name = "NameTextEdit";
            this.NameTextEdit.Size = new System.Drawing.Size(891, 20);
            this.NameTextEdit.StyleController = this.dataLayoutControl1;
            this.NameTextEdit.TabIndex = 5;
            // 
            // OperationsModuleXtraUserControl
            // 
            this.OperationsModuleXtraUserControl.Controls.Add(this.OperationsModuleGridControl);
            this.OperationsModuleXtraUserControl.Controls.Add(this.barDockControlLeft);
            this.OperationsModuleXtraUserControl.Controls.Add(this.barDockControlRight);
            this.OperationsModuleXtraUserControl.Controls.Add(this.barDockControlBottom);
            this.OperationsModuleXtraUserControl.Controls.Add(this.barDockControlTop);
            this.OperationsModuleXtraUserControl.Location = new System.Drawing.Point(24, 95);
            this.OperationsModuleXtraUserControl.MinimumSize = new System.Drawing.Size(100, 100);
            this.OperationsModuleXtraUserControl.Name = "OperationsModuleXtraUserControl";
            this.OperationsModuleXtraUserControl.Size = new System.Drawing.Size(928, 556);
            this.OperationsModuleXtraUserControl.TabIndex = 6;
            // 
            // OperationsModuleGridControl
            // 
            this.OperationsModuleGridControl.DataSource = this.OperationsModuleBindingSource;
            this.OperationsModuleGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.OperationsModuleGridControl.Location = new System.Drawing.Point(0, 26);
            this.OperationsModuleGridControl.MainView = this.OperationsModuleGridView;
            this.OperationsModuleGridControl.Name = "OperationsModuleGridControl";
            this.OperationsModuleGridControl.Size = new System.Drawing.Size(928, 530);
            this.OperationsModuleGridControl.TabIndex = 0;
            this.OperationsModuleGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.OperationsModuleGridView});
            // 
            // OperationsModuleBindingSource
            // 
            this.OperationsModuleBindingSource.DataSource = typeof(Acnur.App.Repository.Data.OperationsModule);
            // 
            // OperationsModuleGridView
            // 
            this.OperationsModuleGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdOperationModule,
            this.colIdOperation,
            this.colIdModule,
            this.colModules,
            this.colOperations,
            this.colOperationsModuleUser});
            this.OperationsModuleGridView.GridControl = this.OperationsModuleGridControl;
            this.OperationsModuleGridView.Name = "OperationsModuleGridView";
            this.OperationsModuleGridView.OptionsBehavior.Editable = false;
            this.OperationsModuleGridView.OptionsBehavior.ReadOnly = true;
            this.OperationsModuleGridView.OptionsView.ShowGroupPanel = false;
            // 
            // colIdOperationModule
            // 
            this.colIdOperationModule.FieldName = "IdOperationModule";
            this.colIdOperationModule.Name = "colIdOperationModule";
            // 
            // colIdOperation
            // 
            this.colIdOperation.FieldName = "IdOperation";
            this.colIdOperation.Name = "colIdOperation";
            // 
            // colIdModule
            // 
            this.colIdModule.FieldName = "IdModule";
            this.colIdModule.Name = "colIdModule";
            // 
            // colModules
            // 
            this.colModules.FieldName = "Modules";
            this.colModules.Name = "colModules";
            this.colModules.Visible = true;
            this.colModules.VisibleIndex = 0;
            // 
            // colOperations
            // 
            this.colOperations.FieldName = "Operations";
            this.colOperations.Name = "colOperations";
            // 
            // colOperationsModuleUser
            // 
            this.colOperationsModuleUser.FieldName = "OperationsModuleUser";
            this.colOperationsModuleUser.Name = "colOperationsModuleUser";
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 26);
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 530);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(928, 26);
            this.barDockControlRight.Size = new System.Drawing.Size(0, 530);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 556);
            this.barDockControlBottom.Size = new System.Drawing.Size(928, 0);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Size = new System.Drawing.Size(928, 26);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup2});
            this.layoutControlGroup1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup1.Name = "Root";
            this.layoutControlGroup1.Size = new System.Drawing.Size(979, 678);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.AllowDrawBackground = false;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForIdOperation,
            this.ItemForName,
            this.tabbedControlGroup1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(959, 658);
            // 
            // ItemForIdOperation
            // 
            this.ItemForIdOperation.Control = this.IdOperationTextEdit;
            this.ItemForIdOperation.Location = new System.Drawing.Point(0, 0);
            this.ItemForIdOperation.Name = "ItemForIdOperation";
            this.ItemForIdOperation.Size = new System.Drawing.Size(959, 24);
            this.ItemForIdOperation.Text = "Id Operation";
            this.ItemForIdOperation.TextSize = new System.Drawing.Size(61, 13);
            this.ItemForIdOperation.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // ItemForName
            // 
            this.ItemForName.Control = this.NameTextEdit;
            this.ItemForName.Location = new System.Drawing.Point(0, 24);
            this.ItemForName.Name = "ItemForName";
            this.ItemForName.Size = new System.Drawing.Size(959, 24);
            this.ItemForName.Text = "Name";
            this.ItemForName.TextSize = new System.Drawing.Size(61, 13);
            // 
            // tabbedControlGroup1
            // 
            this.tabbedControlGroup1.Location = new System.Drawing.Point(0, 48);
            this.tabbedControlGroup1.Name = "autoGroupForTabs";
            this.tabbedControlGroup1.SelectedTabPage = this.layoutControlGroup3;
            this.tabbedControlGroup1.SelectedTabPageIndex = 0;
            this.tabbedControlGroup1.Size = new System.Drawing.Size(959, 610);
            this.tabbedControlGroup1.TabPages.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlGroup3});
            this.tabbedControlGroup1.Text = "Tabs";
            this.tabbedControlGroup1.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // layoutControlGroup3
            // 
            this.layoutControlGroup3.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ItemForOperationsModule});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "autoGroupForOperationsModule";
            this.layoutControlGroup3.Size = new System.Drawing.Size(932, 560);
            this.layoutControlGroup3.Text = "OperationsModule";
            // 
            // ItemForOperationsModule
            // 
            this.ItemForOperationsModule.Control = this.OperationsModuleXtraUserControl;
            this.ItemForOperationsModule.Location = new System.Drawing.Point(0, 0);
            this.ItemForOperationsModule.Name = "ItemForOperationsModule";
            this.ItemForOperationsModule.Size = new System.Drawing.Size(932, 560);
            this.ItemForOperationsModule.StartNewLine = true;
            this.ItemForOperationsModule.Text = "Operations Module";
            this.ItemForOperationsModule.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForOperationsModule.TextVisible = false;
            // 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(WinAdministrator.ViewModels.OperationsViewModel);
            // 
            // windowsUIButtonPanelCloseButton
            // 
            this.windowsUIButtonPanelCloseButton.ButtonInterval = 0;
            this.windowsUIButtonPanelCloseButton.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("", null, "Backward;Size32x32;GrayScaled")});
            this.windowsUIButtonPanelCloseButton.ContentAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.windowsUIButtonPanelCloseButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.windowsUIButtonPanelCloseButton.ForeColor = System.Drawing.Color.Gray;
            this.windowsUIButtonPanelCloseButton.Location = new System.Drawing.Point(0, 0);
            this.windowsUIButtonPanelCloseButton.MaximumSize = new System.Drawing.Size(45, 0);
            this.windowsUIButtonPanelCloseButton.MinimumSize = new System.Drawing.Size(45, 0);
            this.windowsUIButtonPanelCloseButton.Name = "windowsUIButtonPanelCloseButton";
            this.windowsUIButtonPanelCloseButton.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.windowsUIButtonPanelCloseButton.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.windowsUIButtonPanelCloseButton.Size = new System.Drawing.Size(45, 708);
            this.windowsUIButtonPanelCloseButton.TabIndex = 2;
            this.windowsUIButtonPanelCloseButton.Text = "windowsUIButtonPanel1";
            // 
            // windowsUIButtonPanelMain
            // 
            this.windowsUIButtonPanelMain.AppearanceButton.Hovered.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.windowsUIButtonPanelMain.AppearanceButton.Hovered.FontSizeDelta = -1;
            this.windowsUIButtonPanelMain.AppearanceButton.Hovered.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(130)))), ((int)(((byte)(130)))));
            this.windowsUIButtonPanelMain.AppearanceButton.Hovered.Options.UseBackColor = true;
            this.windowsUIButtonPanelMain.AppearanceButton.Hovered.Options.UseFont = true;
            this.windowsUIButtonPanelMain.AppearanceButton.Hovered.Options.UseForeColor = true;
            this.windowsUIButtonPanelMain.AppearanceButton.Normal.FontSizeDelta = -1;
            this.windowsUIButtonPanelMain.AppearanceButton.Normal.Options.UseFont = true;
            this.windowsUIButtonPanelMain.AppearanceButton.Pressed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.windowsUIButtonPanelMain.AppearanceButton.Pressed.FontSizeDelta = -1;
            this.windowsUIButtonPanelMain.AppearanceButton.Pressed.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(159)))), ((int)(((byte)(159)))));
            this.windowsUIButtonPanelMain.AppearanceButton.Pressed.Options.UseBackColor = true;
            this.windowsUIButtonPanelMain.AppearanceButton.Pressed.Options.UseFont = true;
            this.windowsUIButtonPanelMain.AppearanceButton.Pressed.Options.UseForeColor = true;
            this.windowsUIButtonPanelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.windowsUIButtonPanelMain.Buttons.AddRange(new DevExpress.XtraEditors.ButtonPanel.IBaseButton[] {
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Save", null, "Save;Size32x32;GrayScaled"),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Save And Close", null, "SaveAndClose;Size32x32;GrayScaled"),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Save And New", null, "SaveAndNew;Size32x32;GrayScaled"),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Reset Changes", null, "Reset;Size32x32;GrayScaled"),
            new DevExpress.XtraBars.Docking2010.WindowsUIButton("Delete", null, "Edit/Delete;Size32x32;GrayScaled")});
            this.windowsUIButtonPanelMain.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.windowsUIButtonPanelMain.EnableImageTransparency = true;
            this.windowsUIButtonPanelMain.ForeColor = System.Drawing.Color.White;
            this.windowsUIButtonPanelMain.Location = new System.Drawing.Point(0, 708);
            this.windowsUIButtonPanelMain.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.windowsUIButtonPanelMain.MaximumSize = new System.Drawing.Size(0, 60);
            this.windowsUIButtonPanelMain.MinimumSize = new System.Drawing.Size(60, 60);
            this.windowsUIButtonPanelMain.Name = "windowsUIButtonPanelMain";
            this.windowsUIButtonPanelMain.Size = new System.Drawing.Size(1024, 60);
            this.windowsUIButtonPanelMain.TabIndex = 3;
            this.windowsUIButtonPanelMain.Text = "windowsUIButtonPanelMain";
            this.windowsUIButtonPanelMain.UseButtonBackgroundImages = false;
            // 
            // labelControl
            // 
            this.labelControl.AllowHtmlString = true;
            this.labelControl.Appearance.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelControl.Appearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(140)))));
            this.labelControl.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.labelControl.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Vertical;
            this.labelControl.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelControl.Location = new System.Drawing.Point(45, 0);
            this.labelControl.Name = "labelControl";
            this.labelControl.Padding = new System.Windows.Forms.Padding(10, 5, 0, 0);
            this.labelControl.Size = new System.Drawing.Size(979, 30);
            this.labelControl.TabIndex = 1;
            this.labelControl.Text = "Operations";
            // 
            // OperationsModuleBarManager
            // 
            this.OperationsModuleBarManager.AllowCustomization = false;
            this.OperationsModuleBarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.OperationsModuleBar});
            this.OperationsModuleBarManager.DockControls.Add(this.barDockControlTop);
            this.OperationsModuleBarManager.DockControls.Add(this.barDockControlBottom);
            this.OperationsModuleBarManager.DockControls.Add(this.barDockControlLeft);
            this.OperationsModuleBarManager.DockControls.Add(this.barDockControlRight);
            this.OperationsModuleBarManager.Form = this.OperationsModuleXtraUserControl;
            this.OperationsModuleBarManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbiOperationsModuleNew,
            this.bbiOperationsModuleEdit,
            this.bbiOperationsModuleDelete,
            this.bbiOperationsModuleRefresh});
            this.OperationsModuleBarManager.MainMenu = this.OperationsModuleBar;
            this.OperationsModuleBarManager.MaxItemId = 4;
            // 
            // OperationsModuleBar
            // 
            this.OperationsModuleBar.BarName = "OperationsModule";
            this.OperationsModuleBar.DockCol = 0;
            this.OperationsModuleBar.DockRow = 0;
            this.OperationsModuleBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.OperationsModuleBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiOperationsModuleNew),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiOperationsModuleEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiOperationsModuleDelete),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiOperationsModuleRefresh)});
            this.OperationsModuleBar.OptionsBar.AllowQuickCustomization = false;
            this.OperationsModuleBar.OptionsBar.DrawDragBorder = false;
            this.OperationsModuleBar.Text = "OperationsModule";
            // 
            // bbiOperationsModuleNew
            // 
            this.bbiOperationsModuleNew.Caption = "New";
            this.bbiOperationsModuleNew.Id = 0;
            this.bbiOperationsModuleNew.ImageUri.Uri = "New";
            this.bbiOperationsModuleNew.Name = "bbiOperationsModuleNew";
            this.bbiOperationsModuleNew.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // bbiOperationsModuleEdit
            // 
            this.bbiOperationsModuleEdit.Caption = "Edit";
            this.bbiOperationsModuleEdit.Id = 1;
            this.bbiOperationsModuleEdit.ImageUri.Uri = "Edit";
            this.bbiOperationsModuleEdit.Name = "bbiOperationsModuleEdit";
            this.bbiOperationsModuleEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // bbiOperationsModuleDelete
            // 
            this.bbiOperationsModuleDelete.Caption = "Delete";
            this.bbiOperationsModuleDelete.Id = 2;
            this.bbiOperationsModuleDelete.ImageUri.Uri = "Delete";
            this.bbiOperationsModuleDelete.Name = "bbiOperationsModuleDelete";
            this.bbiOperationsModuleDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // bbiOperationsModuleRefresh
            // 
            this.bbiOperationsModuleRefresh.Caption = "Refresh";
            this.bbiOperationsModuleRefresh.Id = 3;
            this.bbiOperationsModuleRefresh.ImageUri.Uri = "Refresh";
            this.bbiOperationsModuleRefresh.Name = "bbiOperationsModuleRefresh";
            this.bbiOperationsModuleRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // OperationsModulePopUpMenu
            // 
            this.OperationsModulePopUpMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiOperationsModuleNew),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiOperationsModuleEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiOperationsModuleDelete),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiOperationsModuleRefresh)});
            this.OperationsModulePopUpMenu.Manager = this.OperationsModuleBarManager;
            this.OperationsModulePopUpMenu.Name = "OperationsModulePopUpMenu";
            // 
            // OperationsView
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.dataLayoutControl1);
            this.Controls.Add(this.labelControl);
            this.Controls.Add(this.windowsUIButtonPanelCloseButton);
            this.Controls.Add(this.windowsUIButtonPanelMain);
            this.Name = "OperationsView";
            this.Size = new System.Drawing.Size(1024, 768);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IdOperationTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationsViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameTextEdit.Properties)).EndInit();
            this.OperationsModuleXtraUserControl.ResumeLayout(false);
            this.OperationsModuleXtraUserControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OperationsModuleGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OperationsModuleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OperationsModuleGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIdOperation)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForOperationsModule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OperationsModuleBarManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OperationsModulePopUpMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.Utils.MVVM.MVVMContext mvvmContext;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanelCloseButton;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanelMain;
        private DevExpress.XtraEditors.LabelControl labelControl;
        private System.Windows.Forms.BindingSource operationsViewBindingSource;
        private DevExpress.XtraGrid.GridControl OperationsModuleGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView OperationsModuleGridView;
        private DevExpress.XtraBars.BarManager OperationsModuleBarManager;
        private DevExpress.XtraBars.Bar OperationsModuleBar;
        private DevExpress.XtraEditors.XtraUserControl OperationsModuleXtraUserControl;
        private DevExpress.XtraBars.PopupMenu OperationsModulePopUpMenu;
        private DevExpress.XtraBars.BarButtonItem bbiOperationsModuleNew;
        private DevExpress.XtraBars.BarButtonItem bbiOperationsModuleEdit;
        private DevExpress.XtraBars.BarButtonItem bbiOperationsModuleDelete;
        private DevExpress.XtraBars.BarButtonItem bbiOperationsModuleRefresh;
        private DevExpress.XtraEditors.TextEdit IdOperationTextEdit;
        private DevExpress.XtraEditors.TextEdit NameTextEdit;
        private System.Windows.Forms.BindingSource OperationsModuleBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdOperationModule;
        private DevExpress.XtraGrid.Columns.GridColumn colIdOperation;
        private DevExpress.XtraGrid.Columns.GridColumn colIdModule;
        private DevExpress.XtraGrid.Columns.GridColumn colModules;
        private DevExpress.XtraGrid.Columns.GridColumn colOperations;
        private DevExpress.XtraGrid.Columns.GridColumn colOperationsModuleUser;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForIdOperation;
        private DevExpress.XtraLayout.LayoutControlItem ItemForName;
        private DevExpress.XtraLayout.TabbedControlGroup tabbedControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem ItemForOperationsModule;

    }
}
