namespace WinAdministrator.Views.StepsFlowView
{
    partial class StepsFlowView
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
            this.IdStepFlowTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.stepsFlowViewBindingSource = new System.Windows.Forms.BindingSource();
            this.NameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.StepsFlowModuleXtraUserControl = new DevExpress.XtraEditors.XtraUserControl();
            this.StepsFlowModuleGridControl = new DevExpress.XtraGrid.GridControl();
            this.StepsFlowModuleBindingSource = new System.Windows.Forms.BindingSource();
            this.StepsFlowModuleGridView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIdStepFlowModule = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdStepFlow = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIdModule = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSequence = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colModules = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStepsFlow = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colStepsFlowModuleUser = new DevExpress.XtraGrid.Columns.GridColumn();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForIdStepFlow = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForName = new DevExpress.XtraLayout.LayoutControlItem();
            this.tabbedControlGroup1 = new DevExpress.XtraLayout.TabbedControlGroup();
            this.layoutControlGroup3 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForStepsFlowModule = new DevExpress.XtraLayout.LayoutControlItem();
            this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext();
            this.windowsUIButtonPanelCloseButton = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.windowsUIButtonPanelMain = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.labelControl = new DevExpress.XtraEditors.LabelControl();
            this.StepsFlowModuleBarManager = new DevExpress.XtraBars.BarManager();
            this.StepsFlowModuleBar = new DevExpress.XtraBars.Bar();
            this.bbiStepsFlowModuleNew = new DevExpress.XtraBars.BarButtonItem();
            this.bbiStepsFlowModuleEdit = new DevExpress.XtraBars.BarButtonItem();
            this.bbiStepsFlowModuleDelete = new DevExpress.XtraBars.BarButtonItem();
            this.bbiStepsFlowModuleRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.StepsFlowModulePopUpMenu = new DevExpress.XtraBars.PopupMenu();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IdStepFlowTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepsFlowViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameTextEdit.Properties)).BeginInit();
            this.StepsFlowModuleXtraUserControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StepsFlowModuleGridControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StepsFlowModuleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StepsFlowModuleGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIdStepFlow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForStepsFlowModule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StepsFlowModuleBarManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StepsFlowModulePopUpMenu)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.AllowCustomization = false;
            this.dataLayoutControl1.Controls.Add(this.IdStepFlowTextEdit);
            this.dataLayoutControl1.Controls.Add(this.NameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.StepsFlowModuleXtraUserControl);
            this.dataLayoutControl1.DataSource = this.stepsFlowViewBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(45, 30);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(979, 678);
            this.dataLayoutControl1.TabIndex = 0;
            // 
            // IdStepFlowTextEdit
            // 
            this.IdStepFlowTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.stepsFlowViewBindingSource, "IdStepFlow", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.IdStepFlowTextEdit.Location = new System.Drawing.Point(75, 12);
            this.IdStepFlowTextEdit.Name = "IdStepFlowTextEdit";
            this.IdStepFlowTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.IdStepFlowTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.IdStepFlowTextEdit.Properties.Mask.EditMask = "N0";
            this.IdStepFlowTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.IdStepFlowTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.IdStepFlowTextEdit.Size = new System.Drawing.Size(892, 20);
            this.IdStepFlowTextEdit.StyleController = this.dataLayoutControl1;
            this.IdStepFlowTextEdit.TabIndex = 4;
            // 
            // stepsFlowViewBindingSource
            // 
            this.stepsFlowViewBindingSource.DataSource = typeof(Acnur.App.Repository.Data.StepsFlow);
            // 
            // NameTextEdit
            // 
            this.NameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.stepsFlowViewBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.NameTextEdit.Location = new System.Drawing.Point(75, 36);
            this.NameTextEdit.Name = "NameTextEdit";
            this.NameTextEdit.Size = new System.Drawing.Size(892, 20);
            this.NameTextEdit.StyleController = this.dataLayoutControl1;
            this.NameTextEdit.TabIndex = 5;
            // 
            // StepsFlowModuleXtraUserControl
            // 
            this.StepsFlowModuleXtraUserControl.Controls.Add(this.StepsFlowModuleGridControl);
            this.StepsFlowModuleXtraUserControl.Controls.Add(this.barDockControlLeft);
            this.StepsFlowModuleXtraUserControl.Controls.Add(this.barDockControlRight);
            this.StepsFlowModuleXtraUserControl.Controls.Add(this.barDockControlBottom);
            this.StepsFlowModuleXtraUserControl.Controls.Add(this.barDockControlTop);
            this.StepsFlowModuleXtraUserControl.Location = new System.Drawing.Point(24, 95);
            this.StepsFlowModuleXtraUserControl.MinimumSize = new System.Drawing.Size(100, 100);
            this.StepsFlowModuleXtraUserControl.Name = "StepsFlowModuleXtraUserControl";
            this.StepsFlowModuleXtraUserControl.Size = new System.Drawing.Size(928, 556);
            this.StepsFlowModuleXtraUserControl.TabIndex = 6;
            // 
            // StepsFlowModuleGridControl
            // 
            this.StepsFlowModuleGridControl.DataSource = this.StepsFlowModuleBindingSource;
            this.StepsFlowModuleGridControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StepsFlowModuleGridControl.Location = new System.Drawing.Point(0, 26);
            this.StepsFlowModuleGridControl.MainView = this.StepsFlowModuleGridView;
            this.StepsFlowModuleGridControl.Name = "StepsFlowModuleGridControl";
            this.StepsFlowModuleGridControl.Size = new System.Drawing.Size(928, 530);
            this.StepsFlowModuleGridControl.TabIndex = 0;
            this.StepsFlowModuleGridControl.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.StepsFlowModuleGridView});
            // 
            // StepsFlowModuleBindingSource
            // 
            this.StepsFlowModuleBindingSource.DataSource = typeof(Acnur.App.Repository.Data.StepsFlowModule);
            // 
            // StepsFlowModuleGridView
            // 
            this.StepsFlowModuleGridView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIdStepFlowModule,
            this.colIdStepFlow,
            this.colIdModule,
            this.colSequence,
            this.colModules,
            this.colStepsFlow,
            this.colStepsFlowModuleUser});
            this.StepsFlowModuleGridView.GridControl = this.StepsFlowModuleGridControl;
            this.StepsFlowModuleGridView.Name = "StepsFlowModuleGridView";
            this.StepsFlowModuleGridView.OptionsBehavior.Editable = false;
            this.StepsFlowModuleGridView.OptionsBehavior.ReadOnly = true;
            this.StepsFlowModuleGridView.OptionsView.ShowGroupPanel = false;
            // 
            // colIdStepFlowModule
            // 
            this.colIdStepFlowModule.FieldName = "IdStepFlowModule";
            this.colIdStepFlowModule.Name = "colIdStepFlowModule";
            this.colIdStepFlowModule.Visible = true;
            this.colIdStepFlowModule.VisibleIndex = 0;
            // 
            // colIdStepFlow
            // 
            this.colIdStepFlow.FieldName = "IdStepFlow";
            this.colIdStepFlow.Name = "colIdStepFlow";
            // 
            // colIdModule
            // 
            this.colIdModule.FieldName = "IdModule";
            this.colIdModule.Name = "colIdModule";
            // 
            // colSequence
            // 
            this.colSequence.FieldName = "Sequence";
            this.colSequence.Name = "colSequence";
            this.colSequence.Visible = true;
            this.colSequence.VisibleIndex = 1;
            // 
            // colModules
            // 
            this.colModules.FieldName = "Modules";
            this.colModules.Name = "colModules";
            this.colModules.Visible = true;
            this.colModules.VisibleIndex = 2;
            // 
            // colStepsFlow
            // 
            this.colStepsFlow.FieldName = "StepsFlow";
            this.colStepsFlow.Name = "colStepsFlow";
            // 
            // colStepsFlowModuleUser
            // 
            this.colStepsFlowModuleUser.FieldName = "StepsFlowModuleUser";
            this.colStepsFlowModuleUser.Name = "colStepsFlowModuleUser";
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
            this.ItemForIdStepFlow,
            this.ItemForName,
            this.tabbedControlGroup1});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(959, 658);
            // 
            // ItemForIdStepFlow
            // 
            this.ItemForIdStepFlow.Control = this.IdStepFlowTextEdit;
            this.ItemForIdStepFlow.Location = new System.Drawing.Point(0, 0);
            this.ItemForIdStepFlow.Name = "ItemForIdStepFlow";
            this.ItemForIdStepFlow.Size = new System.Drawing.Size(959, 24);
            this.ItemForIdStepFlow.Text = "Id Step Flow";
            this.ItemForIdStepFlow.TextSize = new System.Drawing.Size(60, 13);
            this.ItemForIdStepFlow.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // ItemForName
            // 
            this.ItemForName.Control = this.NameTextEdit;
            this.ItemForName.Location = new System.Drawing.Point(0, 24);
            this.ItemForName.Name = "ItemForName";
            this.ItemForName.Size = new System.Drawing.Size(959, 24);
            this.ItemForName.Text = "Name";
            this.ItemForName.TextSize = new System.Drawing.Size(60, 13);
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
            this.ItemForStepsFlowModule});
            this.layoutControlGroup3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup3.Name = "autoGroupForStepsFlowModule";
            this.layoutControlGroup3.Size = new System.Drawing.Size(932, 560);
            this.layoutControlGroup3.Text = "StepsFlowModule";
            // 
            // ItemForStepsFlowModule
            // 
            this.ItemForStepsFlowModule.Control = this.StepsFlowModuleXtraUserControl;
            this.ItemForStepsFlowModule.Location = new System.Drawing.Point(0, 0);
            this.ItemForStepsFlowModule.Name = "ItemForStepsFlowModule";
            this.ItemForStepsFlowModule.Size = new System.Drawing.Size(932, 560);
            this.ItemForStepsFlowModule.StartNewLine = true;
            this.ItemForStepsFlowModule.Text = "Steps Flow Module";
            this.ItemForStepsFlowModule.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForStepsFlowModule.TextVisible = false;
            // 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(WinAdministrator.ViewModels.StepsFlowViewModel);
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
            this.labelControl.Text = "Steps Flow";
            // 
            // StepsFlowModuleBarManager
            // 
            this.StepsFlowModuleBarManager.AllowCustomization = false;
            this.StepsFlowModuleBarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.StepsFlowModuleBar});
            this.StepsFlowModuleBarManager.DockControls.Add(this.barDockControlTop);
            this.StepsFlowModuleBarManager.DockControls.Add(this.barDockControlBottom);
            this.StepsFlowModuleBarManager.DockControls.Add(this.barDockControlLeft);
            this.StepsFlowModuleBarManager.DockControls.Add(this.barDockControlRight);
            this.StepsFlowModuleBarManager.Form = this.StepsFlowModuleXtraUserControl;
            this.StepsFlowModuleBarManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.bbiStepsFlowModuleNew,
            this.bbiStepsFlowModuleEdit,
            this.bbiStepsFlowModuleDelete,
            this.bbiStepsFlowModuleRefresh});
            this.StepsFlowModuleBarManager.MainMenu = this.StepsFlowModuleBar;
            this.StepsFlowModuleBarManager.MaxItemId = 4;
            // 
            // StepsFlowModuleBar
            // 
            this.StepsFlowModuleBar.BarName = "StepsFlowModule";
            this.StepsFlowModuleBar.DockCol = 0;
            this.StepsFlowModuleBar.DockRow = 0;
            this.StepsFlowModuleBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.StepsFlowModuleBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiStepsFlowModuleNew),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiStepsFlowModuleEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiStepsFlowModuleDelete),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiStepsFlowModuleRefresh)});
            this.StepsFlowModuleBar.OptionsBar.AllowQuickCustomization = false;
            this.StepsFlowModuleBar.OptionsBar.DrawDragBorder = false;
            this.StepsFlowModuleBar.Text = "StepsFlowModule";
            // 
            // bbiStepsFlowModuleNew
            // 
            this.bbiStepsFlowModuleNew.Caption = "New";
            this.bbiStepsFlowModuleNew.Id = 0;
            this.bbiStepsFlowModuleNew.ImageUri.Uri = "New";
            this.bbiStepsFlowModuleNew.Name = "bbiStepsFlowModuleNew";
            this.bbiStepsFlowModuleNew.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // bbiStepsFlowModuleEdit
            // 
            this.bbiStepsFlowModuleEdit.Caption = "Edit";
            this.bbiStepsFlowModuleEdit.Id = 1;
            this.bbiStepsFlowModuleEdit.ImageUri.Uri = "Edit";
            this.bbiStepsFlowModuleEdit.Name = "bbiStepsFlowModuleEdit";
            this.bbiStepsFlowModuleEdit.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // bbiStepsFlowModuleDelete
            // 
            this.bbiStepsFlowModuleDelete.Caption = "Delete";
            this.bbiStepsFlowModuleDelete.Id = 2;
            this.bbiStepsFlowModuleDelete.ImageUri.Uri = "Delete";
            this.bbiStepsFlowModuleDelete.Name = "bbiStepsFlowModuleDelete";
            this.bbiStepsFlowModuleDelete.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // bbiStepsFlowModuleRefresh
            // 
            this.bbiStepsFlowModuleRefresh.Caption = "Refresh";
            this.bbiStepsFlowModuleRefresh.Id = 3;
            this.bbiStepsFlowModuleRefresh.ImageUri.Uri = "Refresh";
            this.bbiStepsFlowModuleRefresh.Name = "bbiStepsFlowModuleRefresh";
            this.bbiStepsFlowModuleRefresh.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // StepsFlowModulePopUpMenu
            // 
            this.StepsFlowModulePopUpMenu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiStepsFlowModuleNew),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiStepsFlowModuleEdit),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiStepsFlowModuleDelete),
            new DevExpress.XtraBars.LinkPersistInfo(this.bbiStepsFlowModuleRefresh)});
            this.StepsFlowModulePopUpMenu.Manager = this.StepsFlowModuleBarManager;
            this.StepsFlowModulePopUpMenu.Name = "StepsFlowModulePopUpMenu";
            // 
            // StepsFlowView
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
            this.Name = "StepsFlowView";
            this.Size = new System.Drawing.Size(1024, 768);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IdStepFlowTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepsFlowViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameTextEdit.Properties)).EndInit();
            this.StepsFlowModuleXtraUserControl.ResumeLayout(false);
            this.StepsFlowModuleXtraUserControl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StepsFlowModuleGridControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StepsFlowModuleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StepsFlowModuleGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIdStepFlow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabbedControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForStepsFlowModule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StepsFlowModuleBarManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StepsFlowModulePopUpMenu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.Utils.MVVM.MVVMContext mvvmContext;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanelCloseButton;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanelMain;
        private DevExpress.XtraEditors.LabelControl labelControl;
        private System.Windows.Forms.BindingSource stepsFlowViewBindingSource;
        private DevExpress.XtraGrid.GridControl StepsFlowModuleGridControl;
        private DevExpress.XtraGrid.Views.Grid.GridView StepsFlowModuleGridView;
        private DevExpress.XtraBars.BarManager StepsFlowModuleBarManager;
        private DevExpress.XtraBars.Bar StepsFlowModuleBar;
        private DevExpress.XtraEditors.XtraUserControl StepsFlowModuleXtraUserControl;
        private DevExpress.XtraBars.PopupMenu StepsFlowModulePopUpMenu;
        private DevExpress.XtraBars.BarButtonItem bbiStepsFlowModuleNew;
        private DevExpress.XtraBars.BarButtonItem bbiStepsFlowModuleEdit;
        private DevExpress.XtraBars.BarButtonItem bbiStepsFlowModuleDelete;
        private DevExpress.XtraBars.BarButtonItem bbiStepsFlowModuleRefresh;
        private DevExpress.XtraEditors.TextEdit IdStepFlowTextEdit;
        private DevExpress.XtraEditors.TextEdit NameTextEdit;
        private System.Windows.Forms.BindingSource StepsFlowModuleBindingSource;
        private DevExpress.XtraGrid.Columns.GridColumn colIdStepFlowModule;
        private DevExpress.XtraGrid.Columns.GridColumn colIdStepFlow;
        private DevExpress.XtraGrid.Columns.GridColumn colIdModule;
        private DevExpress.XtraGrid.Columns.GridColumn colSequence;
        private DevExpress.XtraGrid.Columns.GridColumn colModules;
        private DevExpress.XtraGrid.Columns.GridColumn colStepsFlow;
        private DevExpress.XtraGrid.Columns.GridColumn colStepsFlowModuleUser;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForIdStepFlow;
        private DevExpress.XtraLayout.LayoutControlItem ItemForName;
        private DevExpress.XtraLayout.TabbedControlGroup tabbedControlGroup1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup3;
        private DevExpress.XtraLayout.LayoutControlItem ItemForStepsFlowModule;

    }
}
