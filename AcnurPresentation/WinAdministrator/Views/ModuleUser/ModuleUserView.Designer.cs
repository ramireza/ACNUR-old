namespace WinAdministrator.Views.ModuleUserView
{
    partial class ModuleUserView
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
            this.IdModuleUserTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.moduleUserViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ModulesLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.ModulesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ModulesLookUpEditView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColModule = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UsersLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.UsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UsersLookUpEditView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForIdModuleUser = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForIdModule = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForIdUser = new DevExpress.XtraLayout.LayoutControlItem();
            this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            this.windowsUIButtonPanelCloseButton = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.windowsUIButtonPanelMain = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.labelControl = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IdModuleUserTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduleUserViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModulesLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModulesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModulesLookUpEditView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersLookUpEditView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIdModuleUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIdModule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIdUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.AllowCustomization = false;
            this.dataLayoutControl1.Controls.Add(this.IdModuleUserTextEdit);
            this.dataLayoutControl1.Controls.Add(this.ModulesLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.UsersLookUpEdit);
            this.dataLayoutControl1.DataSource = this.moduleUserViewBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(45, 30);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(979, 678);
            this.dataLayoutControl1.TabIndex = 0;
            // 
            // IdModuleUserTextEdit
            // 
            this.IdModuleUserTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.moduleUserViewBindingSource, "IdModuleUser", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.IdModuleUserTextEdit.Location = new System.Drawing.Point(87, 12);
            this.IdModuleUserTextEdit.Name = "IdModuleUserTextEdit";
            this.IdModuleUserTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.IdModuleUserTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.IdModuleUserTextEdit.Properties.Mask.EditMask = "N0";
            this.IdModuleUserTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.IdModuleUserTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.IdModuleUserTextEdit.Size = new System.Drawing.Size(880, 20);
            this.IdModuleUserTextEdit.StyleController = this.dataLayoutControl1;
            this.IdModuleUserTextEdit.TabIndex = 4;
            // 
            // moduleUserViewBindingSource
            // 
            this.moduleUserViewBindingSource.DataSource = typeof(Acnur.App.Repository.Data.ModuleUser);
            // 
            // ModulesLookUpEdit
            // 
            this.ModulesLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.moduleUserViewBindingSource, "IdModule", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.ModulesLookUpEdit.Location = new System.Drawing.Point(87, 36);
            this.ModulesLookUpEdit.Name = "ModulesLookUpEdit";
            this.ModulesLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ModulesLookUpEdit.Properties.DataSource = this.ModulesBindingSource;
            this.ModulesLookUpEdit.Properties.DisplayMember = "ModuleName";
            this.ModulesLookUpEdit.Properties.ValueMember = "IdModule";
            this.ModulesLookUpEdit.Properties.View = this.ModulesLookUpEditView;
            this.ModulesLookUpEdit.Size = new System.Drawing.Size(880, 20);
            this.ModulesLookUpEdit.StyleController = this.dataLayoutControl1;
            this.ModulesLookUpEdit.TabIndex = 5;
            // 
            // ModulesBindingSource
            // 
            this.ModulesBindingSource.DataSource = typeof(Acnur.App.Repository.Data.Modules);
            // 
            // ModulesLookUpEditView
            // 
            this.ModulesLookUpEditView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColModule});
            this.ModulesLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.ModulesLookUpEditView.Name = "ModulesLookUpEditView";
            this.ModulesLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.ModulesLookUpEditView.OptionsView.ShowGroupPanel = false;
            // 
            // ColModule
            // 
            this.ColModule.Caption = "Module Name";
            this.ColModule.FieldName = "ModuleName";
            this.ColModule.Name = "ColModule";
            this.ColModule.Visible = true;
            this.ColModule.VisibleIndex = 0;
            // 
            // UsersLookUpEdit
            // 
            this.UsersLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.moduleUserViewBindingSource, "IdUser", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.UsersLookUpEdit.Location = new System.Drawing.Point(87, 60);
            this.UsersLookUpEdit.Name = "UsersLookUpEdit";
            this.UsersLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.UsersLookUpEdit.Properties.DataSource = this.UsersBindingSource;
            this.UsersLookUpEdit.Properties.DisplayMember = "UserName";
            this.UsersLookUpEdit.Properties.ValueMember = "IdUser";
            this.UsersLookUpEdit.Properties.View = this.UsersLookUpEditView;
            this.UsersLookUpEdit.Size = new System.Drawing.Size(880, 20);
            this.UsersLookUpEdit.StyleController = this.dataLayoutControl1;
            this.UsersLookUpEdit.TabIndex = 6;
            // 
            // UsersBindingSource
            // 
            this.UsersBindingSource.DataSource = typeof(Acnur.App.Repository.Data.Users);
            // 
            // UsersLookUpEditView
            // 
            this.UsersLookUpEditView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColUserName});
            this.UsersLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.UsersLookUpEditView.Name = "UsersLookUpEditView";
            this.UsersLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.UsersLookUpEditView.OptionsView.ShowGroupPanel = false;
            // 
            // ColUserName
            // 
            this.ColUserName.Caption = "User Name";
            this.ColUserName.FieldName = "UserName";
            this.ColUserName.Name = "ColUserName";
            this.ColUserName.Visible = true;
            this.ColUserName.VisibleIndex = 0;
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
            this.ItemForIdModuleUser,
            this.ItemForIdModule,
            this.ItemForIdUser});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(959, 658);
            // 
            // ItemForIdModuleUser
            // 
            this.ItemForIdModuleUser.Control = this.IdModuleUserTextEdit;
            this.ItemForIdModuleUser.Location = new System.Drawing.Point(0, 0);
            this.ItemForIdModuleUser.Name = "ItemForIdModuleUser";
            this.ItemForIdModuleUser.Size = new System.Drawing.Size(959, 24);
            this.ItemForIdModuleUser.Text = "Id Module User";
            this.ItemForIdModuleUser.TextSize = new System.Drawing.Size(72, 13);
            this.ItemForIdModuleUser.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // ItemForIdModule
            // 
            this.ItemForIdModule.Control = this.ModulesLookUpEdit;
            this.ItemForIdModule.Location = new System.Drawing.Point(0, 24);
            this.ItemForIdModule.Name = "ItemForIdModule";
            this.ItemForIdModule.Size = new System.Drawing.Size(959, 24);
            this.ItemForIdModule.Text = "Module";
            this.ItemForIdModule.TextSize = new System.Drawing.Size(72, 13);
            // 
            // ItemForIdUser
            // 
            this.ItemForIdUser.Control = this.UsersLookUpEdit;
            this.ItemForIdUser.Location = new System.Drawing.Point(0, 48);
            this.ItemForIdUser.Name = "ItemForIdUser";
            this.ItemForIdUser.Size = new System.Drawing.Size(959, 610);
            this.ItemForIdUser.Text = "User";
            this.ItemForIdUser.TextSize = new System.Drawing.Size(72, 13);
            // 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(WinAdministrator.ViewModels.ModuleUserViewModel);
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
            this.labelControl.Text = "Module User";
            // 
            // ModuleUserView
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
            this.Name = "ModuleUserView";
            this.Size = new System.Drawing.Size(1024, 768);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IdModuleUserTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.moduleUserViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModulesLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModulesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ModulesLookUpEditView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersLookUpEditView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIdModuleUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIdModule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIdUser)).EndInit();
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
        private System.Windows.Forms.BindingSource moduleUserViewBindingSource;
        private DevExpress.XtraEditors.GridLookUpEdit ModulesLookUpEdit;
        private System.Windows.Forms.BindingSource ModulesBindingSource;
        private DevExpress.XtraEditors.GridLookUpEdit UsersLookUpEdit;
        private System.Windows.Forms.BindingSource UsersBindingSource;
        private DevExpress.XtraEditors.TextEdit IdModuleUserTextEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView ModulesLookUpEditView;
        private DevExpress.XtraGrid.Views.Grid.GridView UsersLookUpEditView;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForIdModuleUser;
        private DevExpress.XtraLayout.LayoutControlItem ItemForIdModule;
        private DevExpress.XtraLayout.LayoutControlItem ItemForIdUser;
        private DevExpress.XtraGrid.Columns.GridColumn ColModule;
        private DevExpress.XtraGrid.Columns.GridColumn ColUserName;

    }
}
