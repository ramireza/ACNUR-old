namespace WinAdministrator.Views.ComponentsByModuleView
{
    partial class ComponentsByModuleView
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
            this.components = new System.ComponentModel.Container();
            this.dataLayoutControl1 = new DevExpress.XtraDataLayout.DataLayoutControl();
            this.IdComponentByModuleTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.componentsByModuleViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.NameTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.ModulesLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.ModulesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ModulesLookUpEditView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColModuleName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DescriptionTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.AttachmentsTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.SessionComponentsByModuleTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForIdComponentByModule = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForName = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForIdModule = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForDescription = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForAttachments = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForSessionComponentsByModule = new DevExpress.XtraLayout.LayoutControlItem();
            this.windowsUIButtonPanelCloseButton = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.windowsUIButtonPanelMain = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.labelControl = new DevExpress.XtraEditors.LabelControl();
            this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IdComponentByModuleTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentsByModuleViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModulesLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModulesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModulesLookUpEditView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescriptionTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttachmentsTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SessionComponentsByModuleTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIdComponentByModule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIdModule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAttachments)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSessionComponentsByModule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.AllowCustomization = false;
            this.dataLayoutControl1.Controls.Add(this.IdComponentByModuleTextEdit);
            this.dataLayoutControl1.Controls.Add(this.NameTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ModulesLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.DescriptionTextEdit);
            this.dataLayoutControl1.Controls.Add(this.AttachmentsTextEdit);
            this.dataLayoutControl1.Controls.Add(this.SessionComponentsByModuleTextEdit);
            this.dataLayoutControl1.DataSource = this.componentsByModuleViewBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(45, 30);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(979, 678);
            this.dataLayoutControl1.TabIndex = 0;
            // 
            // IdComponentByModuleTextEdit
            // 
            this.IdComponentByModuleTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.componentsByModuleViewBindingSource, "IdComponentByModule", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.IdComponentByModuleTextEdit.Location = new System.Drawing.Point(12, 12);
            this.IdComponentByModuleTextEdit.Name = "IdComponentByModuleTextEdit";
            this.IdComponentByModuleTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.IdComponentByModuleTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.IdComponentByModuleTextEdit.Properties.Mask.EditMask = "N0";
            this.IdComponentByModuleTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.IdComponentByModuleTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.IdComponentByModuleTextEdit.Properties.ReadOnly = true;
            this.IdComponentByModuleTextEdit.Size = new System.Drawing.Size(955, 20);
            this.IdComponentByModuleTextEdit.StyleController = this.dataLayoutControl1;
            this.IdComponentByModuleTextEdit.TabIndex = 4;
            this.IdComponentByModuleTextEdit.Visible = false;
            // 
            // componentsByModuleViewBindingSource
            // 
            this.componentsByModuleViewBindingSource.DataSource = typeof(Acnur.App.Repository.Data.ComponentsByModule);
            // 
            // NameTextEdit
            // 
            this.NameTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.componentsByModuleViewBindingSource, "Name", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.NameTextEdit.Location = new System.Drawing.Point(100, 36);
            this.NameTextEdit.Name = "NameTextEdit";
            this.NameTextEdit.Size = new System.Drawing.Size(867, 20);
            this.NameTextEdit.StyleController = this.dataLayoutControl1;
            this.NameTextEdit.TabIndex = 5;
            // 
            // ModulesLookUpEdit
            // 
            this.ModulesLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.componentsByModuleViewBindingSource, "IdModule", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ModulesLookUpEdit.Location = new System.Drawing.Point(100, 60);
            this.ModulesLookUpEdit.Name = "ModulesLookUpEdit";
            this.ModulesLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ModulesLookUpEdit.Properties.DataSource = this.ModulesBindingSource;
            this.ModulesLookUpEdit.Properties.DisplayMember = "ModuleName";
            this.ModulesLookUpEdit.Properties.ValueMember = "IdModule";
            this.ModulesLookUpEdit.Properties.View = this.ModulesLookUpEditView;
            this.ModulesLookUpEdit.Size = new System.Drawing.Size(867, 20);
            this.ModulesLookUpEdit.StyleController = this.dataLayoutControl1;
            this.ModulesLookUpEdit.TabIndex = 6;
            // 
            // ModulesBindingSource
            // 
            this.ModulesBindingSource.DataSource = typeof(Acnur.App.Repository.Data.Modules);
            // 
            // ModulesLookUpEditView
            // 
            this.ModulesLookUpEditView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColModuleName});
            this.ModulesLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.ModulesLookUpEditView.Name = "ModulesLookUpEditView";
            this.ModulesLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.ModulesLookUpEditView.OptionsView.ShowGroupPanel = false;
            // 
            // ColModuleName
            // 
            this.ColModuleName.Caption = "Module Name";
            this.ColModuleName.FieldName = "ModuleName";
            this.ColModuleName.Name = "ColModuleName";
            this.ColModuleName.Visible = true;
            this.ColModuleName.VisibleIndex = 0;
            // 
            // DescriptionTextEdit
            // 
            this.DescriptionTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.componentsByModuleViewBindingSource, "Description", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.DescriptionTextEdit.Location = new System.Drawing.Point(100, 84);
            this.DescriptionTextEdit.Name = "DescriptionTextEdit";
            this.DescriptionTextEdit.Size = new System.Drawing.Size(867, 20);
            this.DescriptionTextEdit.StyleController = this.dataLayoutControl1;
            this.DescriptionTextEdit.TabIndex = 7;
            // 
            // AttachmentsTextEdit
            // 
            this.AttachmentsTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.componentsByModuleViewBindingSource, "Attachments", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.AttachmentsTextEdit.Location = new System.Drawing.Point(12, 108);
            this.AttachmentsTextEdit.Name = "AttachmentsTextEdit";
            this.AttachmentsTextEdit.Size = new System.Drawing.Size(955, 20);
            this.AttachmentsTextEdit.StyleController = this.dataLayoutControl1;
            this.AttachmentsTextEdit.TabIndex = 8;
            this.AttachmentsTextEdit.Visible = false;
            // 
            // SessionComponentsByModuleTextEdit
            // 
            this.SessionComponentsByModuleTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.componentsByModuleViewBindingSource, "SessionComponentsByModule", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.SessionComponentsByModuleTextEdit.Location = new System.Drawing.Point(12, 132);
            this.SessionComponentsByModuleTextEdit.Name = "SessionComponentsByModuleTextEdit";
            this.SessionComponentsByModuleTextEdit.Size = new System.Drawing.Size(955, 20);
            this.SessionComponentsByModuleTextEdit.StyleController = this.dataLayoutControl1;
            this.SessionComponentsByModuleTextEdit.TabIndex = 9;
            this.SessionComponentsByModuleTextEdit.Visible = false;
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
            this.ItemForIdComponentByModule,
            this.ItemForName,
            this.ItemForIdModule,
            this.ItemForDescription,
            this.ItemForAttachments,
            this.ItemForSessionComponentsByModule});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(959, 658);
            // 
            // ItemForIdComponentByModule
            // 
            this.ItemForIdComponentByModule.Control = this.IdComponentByModuleTextEdit;
            this.ItemForIdComponentByModule.Location = new System.Drawing.Point(0, 0);
            this.ItemForIdComponentByModule.Name = "ItemForIdComponentByModule";
            this.ItemForIdComponentByModule.Size = new System.Drawing.Size(959, 24);
            this.ItemForIdComponentByModule.Text = "Id Component By Module";
            this.ItemForIdComponentByModule.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForIdComponentByModule.TextVisible = false;
            this.ItemForIdComponentByModule.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // ItemForName
            // 
            this.ItemForName.Control = this.NameTextEdit;
            this.ItemForName.Location = new System.Drawing.Point(0, 24);
            this.ItemForName.Name = "ItemForName";
            this.ItemForName.Size = new System.Drawing.Size(959, 24);
            this.ItemForName.Text = "Component Name";
            this.ItemForName.TextSize = new System.Drawing.Size(85, 13);
            // 
            // ItemForIdModule
            // 
            this.ItemForIdModule.Control = this.ModulesLookUpEdit;
            this.ItemForIdModule.Location = new System.Drawing.Point(0, 48);
            this.ItemForIdModule.Name = "ItemForIdModule";
            this.ItemForIdModule.Size = new System.Drawing.Size(959, 24);
            this.ItemForIdModule.Text = "Module Name";
            this.ItemForIdModule.TextSize = new System.Drawing.Size(85, 13);
            // 
            // ItemForDescription
            // 
            this.ItemForDescription.Control = this.DescriptionTextEdit;
            this.ItemForDescription.Location = new System.Drawing.Point(0, 72);
            this.ItemForDescription.Name = "ItemForDescription";
            this.ItemForDescription.Size = new System.Drawing.Size(959, 24);
            this.ItemForDescription.Text = "Description";
            this.ItemForDescription.TextSize = new System.Drawing.Size(85, 13);
            // 
            // ItemForAttachments
            // 
            this.ItemForAttachments.Control = this.AttachmentsTextEdit;
            this.ItemForAttachments.Location = new System.Drawing.Point(0, 96);
            this.ItemForAttachments.Name = "ItemForAttachments";
            this.ItemForAttachments.Size = new System.Drawing.Size(959, 24);
            this.ItemForAttachments.Text = "Attachments";
            this.ItemForAttachments.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForAttachments.TextVisible = false;
            this.ItemForAttachments.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // ItemForSessionComponentsByModule
            // 
            this.ItemForSessionComponentsByModule.Control = this.SessionComponentsByModuleTextEdit;
            this.ItemForSessionComponentsByModule.Location = new System.Drawing.Point(0, 120);
            this.ItemForSessionComponentsByModule.Name = "ItemForSessionComponentsByModule";
            this.ItemForSessionComponentsByModule.Size = new System.Drawing.Size(959, 538);
            this.ItemForSessionComponentsByModule.Text = "Session Components By Module";
            this.ItemForSessionComponentsByModule.TextSize = new System.Drawing.Size(0, 0);
            this.ItemForSessionComponentsByModule.TextVisible = false;
            this.ItemForSessionComponentsByModule.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
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
            this.labelControl.Text = "Components By Module";
            // 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(WinAdministrator.ViewModels.ComponentsByModuleViewModel);
            // 
            // ComponentsByModuleView
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
            this.Name = "ComponentsByModuleView";
            this.Size = new System.Drawing.Size(1024, 768);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IdComponentByModuleTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.componentsByModuleViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NameTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModulesLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModulesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModulesLookUpEditView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DescriptionTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AttachmentsTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SessionComponentsByModuleTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIdComponentByModule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIdModule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForAttachments)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForSessionComponentsByModule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraDataLayout.DataLayoutControl dataLayoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.Utils.MVVM.MVVMContext mvvmContext;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanelCloseButton;
        private DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel windowsUIButtonPanelMain;
        private DevExpress.XtraEditors.LabelControl labelControl;
        private System.Windows.Forms.BindingSource componentsByModuleViewBindingSource;
        private DevExpress.XtraEditors.GridLookUpEdit ModulesLookUpEdit;
        private System.Windows.Forms.BindingSource ModulesBindingSource;
        private DevExpress.XtraEditors.TextEdit IdComponentByModuleTextEdit;
        private DevExpress.XtraEditors.TextEdit NameTextEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView ModulesLookUpEditView;
        private DevExpress.XtraEditors.TextEdit DescriptionTextEdit;
        private DevExpress.XtraEditors.TextEdit AttachmentsTextEdit;
        private DevExpress.XtraEditors.TextEdit SessionComponentsByModuleTextEdit;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForIdComponentByModule;
        private DevExpress.XtraLayout.LayoutControlItem ItemForName;
        private DevExpress.XtraLayout.LayoutControlItem ItemForIdModule;
        private DevExpress.XtraLayout.LayoutControlItem ItemForDescription;
        private DevExpress.XtraLayout.LayoutControlItem ItemForAttachments;
        private DevExpress.XtraLayout.LayoutControlItem ItemForSessionComponentsByModule;
        private DevExpress.XtraGrid.Columns.GridColumn ColModuleName;

    }
}
