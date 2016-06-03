namespace WinAdministrator.Views.OperationsModuleUserView
{
    partial class OperationsModuleUserView
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
            this.IdOperationModuleUserTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.OperationsModuleLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.OperationsModuleLookUpEditView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.UsersLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.UsersLookUpEditView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForIdOperationModuleUser = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForIdOperationModule = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForIdUser = new DevExpress.XtraLayout.LayoutControlItem();
            this.windowsUIButtonPanelCloseButton = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.windowsUIButtonPanelMain = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.labelControl = new DevExpress.XtraEditors.LabelControl();
            this.operationsModuleUserViewBindingSource = new System.Windows.Forms.BindingSource();
            this.OperationsModuleBindingSource = new System.Windows.Forms.BindingSource();
            this.UsersBindingSource = new System.Windows.Forms.BindingSource();
            this.ColOperationName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColModuleName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext();
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IdOperationModuleUserTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OperationsModuleLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OperationsModuleLookUpEditView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersLookUpEditView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIdOperationModuleUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIdOperationModule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIdUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationsModuleUserViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OperationsModuleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.AllowCustomization = false;
            this.dataLayoutControl1.Controls.Add(this.IdOperationModuleUserTextEdit);
            this.dataLayoutControl1.Controls.Add(this.OperationsModuleLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.UsersLookUpEdit);
            this.dataLayoutControl1.DataSource = this.operationsModuleUserViewBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(45, 30);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(979, 678);
            this.dataLayoutControl1.TabIndex = 0;
            // 
            // IdOperationModuleUserTextEdit
            // 
            this.IdOperationModuleUserTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.operationsModuleUserViewBindingSource, "IdOperationModuleUser", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.IdOperationModuleUserTextEdit.Location = new System.Drawing.Point(138, 12);
            this.IdOperationModuleUserTextEdit.Name = "IdOperationModuleUserTextEdit";
            this.IdOperationModuleUserTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.IdOperationModuleUserTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.IdOperationModuleUserTextEdit.Properties.Mask.EditMask = "N0";
            this.IdOperationModuleUserTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.IdOperationModuleUserTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.IdOperationModuleUserTextEdit.Size = new System.Drawing.Size(829, 20);
            this.IdOperationModuleUserTextEdit.StyleController = this.dataLayoutControl1;
            this.IdOperationModuleUserTextEdit.TabIndex = 4;
            // 
            // OperationsModuleLookUpEdit
            // 
            this.OperationsModuleLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.operationsModuleUserViewBindingSource, "IdOperationModule", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.OperationsModuleLookUpEdit.Location = new System.Drawing.Point(138, 36);
            this.OperationsModuleLookUpEdit.Name = "OperationsModuleLookUpEdit";
            this.OperationsModuleLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.OperationsModuleLookUpEdit.Properties.DataSource = this.OperationsModuleBindingSource;
            this.OperationsModuleLookUpEdit.Properties.DisplayMember = "Modules.ModuleName";
            this.OperationsModuleLookUpEdit.Properties.ValueMember = "IdOperationModule";
            this.OperationsModuleLookUpEdit.Properties.View = this.OperationsModuleLookUpEditView;
            this.OperationsModuleLookUpEdit.Size = new System.Drawing.Size(829, 20);
            this.OperationsModuleLookUpEdit.StyleController = this.dataLayoutControl1;
            this.OperationsModuleLookUpEdit.TabIndex = 5;
            // 
            // OperationsModuleLookUpEditView
            // 
            this.OperationsModuleLookUpEditView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColOperationName,
            this.ColModuleName});
            this.OperationsModuleLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.OperationsModuleLookUpEditView.Name = "OperationsModuleLookUpEditView";
            this.OperationsModuleLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.OperationsModuleLookUpEditView.OptionsView.ShowGroupPanel = false;
            // 
            // UsersLookUpEdit
            // 
            this.UsersLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.operationsModuleUserViewBindingSource, "IdUser", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.UsersLookUpEdit.Location = new System.Drawing.Point(138, 60);
            this.UsersLookUpEdit.Name = "UsersLookUpEdit";
            this.UsersLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.UsersLookUpEdit.Properties.DataSource = this.UsersBindingSource;
            this.UsersLookUpEdit.Properties.DisplayMember = "UserName";
            this.UsersLookUpEdit.Properties.ValueMember = "IdUser";
            this.UsersLookUpEdit.Properties.View = this.UsersLookUpEditView;
            this.UsersLookUpEdit.Size = new System.Drawing.Size(829, 20);
            this.UsersLookUpEdit.StyleController = this.dataLayoutControl1;
            this.UsersLookUpEdit.TabIndex = 6;
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
            this.ItemForIdOperationModuleUser,
            this.ItemForIdOperationModule,
            this.ItemForIdUser});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(959, 658);
            // 
            // ItemForIdOperationModuleUser
            // 
            this.ItemForIdOperationModuleUser.Control = this.IdOperationModuleUserTextEdit;
            this.ItemForIdOperationModuleUser.Location = new System.Drawing.Point(0, 0);
            this.ItemForIdOperationModuleUser.Name = "ItemForIdOperationModuleUser";
            this.ItemForIdOperationModuleUser.Size = new System.Drawing.Size(959, 24);
            this.ItemForIdOperationModuleUser.Text = "Id Operation Module User";
            this.ItemForIdOperationModuleUser.TextSize = new System.Drawing.Size(123, 13);
            this.ItemForIdOperationModuleUser.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // ItemForIdOperationModule
            // 
            this.ItemForIdOperationModule.Control = this.OperationsModuleLookUpEdit;
            this.ItemForIdOperationModule.Location = new System.Drawing.Point(0, 24);
            this.ItemForIdOperationModule.Name = "ItemForIdOperationModule";
            this.ItemForIdOperationModule.Size = new System.Drawing.Size(959, 24);
            this.ItemForIdOperationModule.Text = "Operation Module";
            this.ItemForIdOperationModule.TextSize = new System.Drawing.Size(123, 13);
            // 
            // ItemForIdUser
            // 
            this.ItemForIdUser.Control = this.UsersLookUpEdit;
            this.ItemForIdUser.Location = new System.Drawing.Point(0, 48);
            this.ItemForIdUser.Name = "ItemForIdUser";
            this.ItemForIdUser.Size = new System.Drawing.Size(959, 610);
            this.ItemForIdUser.Text = "User";
            this.ItemForIdUser.TextSize = new System.Drawing.Size(123, 13);
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
            this.labelControl.Text = "Operations Module User";
            // 
            // operationsModuleUserViewBindingSource
            // 
            this.operationsModuleUserViewBindingSource.DataSource = typeof(Acnur.App.Repository.Data.OperationsModuleUser);
            // 
            // OperationsModuleBindingSource
            // 
            this.OperationsModuleBindingSource.DataSource = typeof(Acnur.App.Repository.Data.OperationsModule);
            // 
            // UsersBindingSource
            // 
            this.UsersBindingSource.DataSource = typeof(Acnur.App.Repository.Data.Users);
            // 
            // ColOperationName
            // 
            this.ColOperationName.Caption = "Operation Name";
            this.ColOperationName.FieldName = "Operations.Name";
            this.ColOperationName.Name = "ColOperationName";
            this.ColOperationName.Visible = true;
            this.ColOperationName.VisibleIndex = 0;
            // 
            // ColModuleName
            // 
            this.ColModuleName.Caption = "Module Name";
            this.ColModuleName.FieldName = "Modules.ModuleName";
            this.ColModuleName.Name = "ColModuleName";
            this.ColModuleName.Visible = true;
            this.ColModuleName.VisibleIndex = 1;
            // 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(WinAdministrator.ViewModels.OperationsModuleUserViewModel);
            // 
            // OperationsModuleUserView
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
            this.Name = "OperationsModuleUserView";
            this.Size = new System.Drawing.Size(1024, 768);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IdOperationModuleUserTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OperationsModuleLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OperationsModuleLookUpEditView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersLookUpEditView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIdOperationModuleUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIdOperationModule)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIdUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.operationsModuleUserViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OperationsModuleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersBindingSource)).EndInit();
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
        private System.Windows.Forms.BindingSource operationsModuleUserViewBindingSource;
        private DevExpress.XtraEditors.GridLookUpEdit OperationsModuleLookUpEdit;
        private System.Windows.Forms.BindingSource OperationsModuleBindingSource;
        private DevExpress.XtraEditors.GridLookUpEdit UsersLookUpEdit;
        private System.Windows.Forms.BindingSource UsersBindingSource;
        private DevExpress.XtraEditors.TextEdit IdOperationModuleUserTextEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView OperationsModuleLookUpEditView;
        private DevExpress.XtraGrid.Columns.GridColumn ColOperationName;
        private DevExpress.XtraGrid.Columns.GridColumn ColModuleName;
        private DevExpress.XtraGrid.Views.Grid.GridView UsersLookUpEditView;
        private DevExpress.XtraGrid.Columns.GridColumn ColUserName;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForIdOperationModuleUser;
        private DevExpress.XtraLayout.LayoutControlItem ItemForIdOperationModule;
        private DevExpress.XtraLayout.LayoutControlItem ItemForIdUser;

    }
}
