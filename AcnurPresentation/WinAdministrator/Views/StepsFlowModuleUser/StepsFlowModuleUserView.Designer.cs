namespace WinAdministrator.Views.StepsFlowModuleUserView
{
    partial class StepsFlowModuleUserView
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
            this.IdStepFlowModuleUserTextEdit = new DevExpress.XtraEditors.TextEdit();
            this.stepsFlowModuleUserViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.StepsFlowModuleLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.StepsFlowModuleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.StepsFlowModuleLookUpEditView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColSequence = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UsersLookUpEdit = new DevExpress.XtraEditors.GridLookUpEdit();
            this.UsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.UsersLookUpEditView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ItemForIdStepFlowModuleUser = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForIdStepFlowModule = new DevExpress.XtraLayout.LayoutControlItem();
            this.ItemForIdUser = new DevExpress.XtraLayout.LayoutControlItem();
            this.windowsUIButtonPanelCloseButton = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.windowsUIButtonPanelMain = new DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel();
            this.labelControl = new DevExpress.XtraEditors.LabelControl();
            this.ColUserName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColModule = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColStepFlow = new DevExpress.XtraGrid.Columns.GridColumn();
            this.mvvmContext = new DevExpress.Utils.MVVM.MVVMContext(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).BeginInit();
            this.dataLayoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IdStepFlowModuleUserTextEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepsFlowModuleUserViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StepsFlowModuleLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StepsFlowModuleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StepsFlowModuleLookUpEditView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersLookUpEditView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIdStepFlowModuleUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIdStepFlowModule)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIdUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mvvmContext)).BeginInit();
            this.SuspendLayout();
            // 
            // dataLayoutControl1
            // 
            this.dataLayoutControl1.AllowCustomization = false;
            this.dataLayoutControl1.Controls.Add(this.IdStepFlowModuleUserTextEdit);
            this.dataLayoutControl1.Controls.Add(this.StepsFlowModuleLookUpEdit);
            this.dataLayoutControl1.Controls.Add(this.UsersLookUpEdit);
            this.dataLayoutControl1.DataSource = this.stepsFlowModuleUserViewBindingSource;
            this.dataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataLayoutControl1.Location = new System.Drawing.Point(45, 30);
            this.dataLayoutControl1.Name = "dataLayoutControl1";
            this.dataLayoutControl1.Root = this.layoutControlGroup1;
            this.dataLayoutControl1.Size = new System.Drawing.Size(979, 678);
            this.dataLayoutControl1.TabIndex = 0;
            // 
            // IdStepFlowModuleUserTextEdit
            // 
            this.IdStepFlowModuleUserTextEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.stepsFlowModuleUserViewBindingSource, "IdStepFlowModuleUser", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.IdStepFlowModuleUserTextEdit.Location = new System.Drawing.Point(137, 12);
            this.IdStepFlowModuleUserTextEdit.Name = "IdStepFlowModuleUserTextEdit";
            this.IdStepFlowModuleUserTextEdit.Properties.Appearance.Options.UseTextOptions = true;
            this.IdStepFlowModuleUserTextEdit.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.IdStepFlowModuleUserTextEdit.Properties.Mask.EditMask = "N0";
            this.IdStepFlowModuleUserTextEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.IdStepFlowModuleUserTextEdit.Properties.Mask.UseMaskAsDisplayFormat = true;
            this.IdStepFlowModuleUserTextEdit.Size = new System.Drawing.Size(830, 20);
            this.IdStepFlowModuleUserTextEdit.StyleController = this.dataLayoutControl1;
            this.IdStepFlowModuleUserTextEdit.TabIndex = 4;
            // 
            // stepsFlowModuleUserViewBindingSource
            // 
            this.stepsFlowModuleUserViewBindingSource.DataSource = typeof(Acnur.App.Repository.Data.StepsFlowModuleUser);
            // 
            // StepsFlowModuleLookUpEdit
            // 
            this.StepsFlowModuleLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.stepsFlowModuleUserViewBindingSource, "IdStepFlowModule", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.StepsFlowModuleLookUpEdit.Location = new System.Drawing.Point(137, 36);
            this.StepsFlowModuleLookUpEdit.Name = "StepsFlowModuleLookUpEdit";
            this.StepsFlowModuleLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.StepsFlowModuleLookUpEdit.Properties.DataSource = this.StepsFlowModuleBindingSource;
            this.StepsFlowModuleLookUpEdit.Properties.DisplayMember = "StepsFlow.Name";
            this.StepsFlowModuleLookUpEdit.Properties.ValueMember = "IdStepFlowModule";
            this.StepsFlowModuleLookUpEdit.Properties.View = this.StepsFlowModuleLookUpEditView;
            this.StepsFlowModuleLookUpEdit.Size = new System.Drawing.Size(830, 20);
            this.StepsFlowModuleLookUpEdit.StyleController = this.dataLayoutControl1;
            this.StepsFlowModuleLookUpEdit.TabIndex = 5;
            // 
            // StepsFlowModuleBindingSource
            // 
            this.StepsFlowModuleBindingSource.DataSource = typeof(Acnur.App.Repository.Data.StepsFlowModule);
            // 
            // StepsFlowModuleLookUpEditView
            // 
            this.StepsFlowModuleLookUpEditView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColModule,
            this.ColStepFlow,
            this.ColSequence});
            this.StepsFlowModuleLookUpEditView.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.StepsFlowModuleLookUpEditView.Name = "StepsFlowModuleLookUpEditView";
            this.StepsFlowModuleLookUpEditView.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.StepsFlowModuleLookUpEditView.OptionsView.ShowGroupPanel = false;
            // 
            // ColSequence
            // 
            this.ColSequence.Caption = "Sequence";
            this.ColSequence.FieldName = "Sequence";
            this.ColSequence.Name = "ColSequence";
            this.ColSequence.Visible = true;
            this.ColSequence.VisibleIndex = 2;
            // 
            // UsersLookUpEdit
            // 
            this.UsersLookUpEdit.DataBindings.Add(new System.Windows.Forms.Binding("EditValue", this.stepsFlowModuleUserViewBindingSource, "IdUser", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.UsersLookUpEdit.Location = new System.Drawing.Point(137, 60);
            this.UsersLookUpEdit.Name = "UsersLookUpEdit";
            this.UsersLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.UsersLookUpEdit.Properties.DataSource = this.UsersBindingSource;
            this.UsersLookUpEdit.Properties.DisplayMember = "UserName";
            this.UsersLookUpEdit.Properties.ValueMember = "IdUser";
            this.UsersLookUpEdit.Properties.View = this.UsersLookUpEditView;
            this.UsersLookUpEdit.Size = new System.Drawing.Size(830, 20);
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
            this.ItemForIdStepFlowModuleUser,
            this.ItemForIdStepFlowModule,
            this.ItemForIdUser});
            this.layoutControlGroup2.Location = new System.Drawing.Point(0, 0);
            this.layoutControlGroup2.Name = "autoGeneratedGroup0";
            this.layoutControlGroup2.Size = new System.Drawing.Size(959, 658);
            // 
            // ItemForIdStepFlowModuleUser
            // 
            this.ItemForIdStepFlowModuleUser.Control = this.IdStepFlowModuleUserTextEdit;
            this.ItemForIdStepFlowModuleUser.Location = new System.Drawing.Point(0, 0);
            this.ItemForIdStepFlowModuleUser.Name = "ItemForIdStepFlowModuleUser";
            this.ItemForIdStepFlowModuleUser.Size = new System.Drawing.Size(959, 24);
            this.ItemForIdStepFlowModuleUser.Text = "Id Step Flow Module User";
            this.ItemForIdStepFlowModuleUser.TextSize = new System.Drawing.Size(122, 13);
            this.ItemForIdStepFlowModuleUser.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never;
            // 
            // ItemForIdStepFlowModule
            // 
            this.ItemForIdStepFlowModule.Control = this.StepsFlowModuleLookUpEdit;
            this.ItemForIdStepFlowModule.Location = new System.Drawing.Point(0, 24);
            this.ItemForIdStepFlowModule.Name = "ItemForIdStepFlowModule";
            this.ItemForIdStepFlowModule.Size = new System.Drawing.Size(959, 24);
            this.ItemForIdStepFlowModule.Text = "Step Flow Module";
            this.ItemForIdStepFlowModule.TextSize = new System.Drawing.Size(122, 13);
            // 
            // ItemForIdUser
            // 
            this.ItemForIdUser.Control = this.UsersLookUpEdit;
            this.ItemForIdUser.Location = new System.Drawing.Point(0, 48);
            this.ItemForIdUser.Name = "ItemForIdUser";
            this.ItemForIdUser.Size = new System.Drawing.Size(959, 610);
            this.ItemForIdUser.Text = "User";
            this.ItemForIdUser.TextSize = new System.Drawing.Size(122, 13);
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
            this.labelControl.Text = "Steps Flow Module User";
            // 
            // ColUserName
            // 
            this.ColUserName.FieldName = "UserName";
            this.ColUserName.Name = "ColUserName";
            this.ColUserName.Visible = true;
            this.ColUserName.VisibleIndex = 0;
            // 
            // ColModule
            // 
            this.ColModule.Caption = "Module Name";
            this.ColModule.FieldName = "Modules.ModuleName";
            this.ColModule.Name = "ColModule";
            this.ColModule.Visible = true;
            this.ColModule.VisibleIndex = 0;
            // 
            // ColStepFlow
            // 
            this.ColStepFlow.Caption = "Step Flow";
            this.ColStepFlow.FieldName = "StepsFlow.Name";
            this.ColStepFlow.Name = "ColStepFlow";
            this.ColStepFlow.Visible = true;
            this.ColStepFlow.VisibleIndex = 1;
            // 
            // mvvmContext
            // 
            this.mvvmContext.ContainerControl = this;
            this.mvvmContext.ViewModelType = typeof(WinAdministrator.ViewModels.StepsFlowModuleUserViewModel);
            // 
            // StepsFlowModuleUserView
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
            this.Name = "StepsFlowModuleUserView";
            this.Size = new System.Drawing.Size(1024, 768);
            ((System.ComponentModel.ISupportInitialize)(this.dataLayoutControl1)).EndInit();
            this.dataLayoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IdStepFlowModuleUserTextEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stepsFlowModuleUserViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StepsFlowModuleLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StepsFlowModuleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StepsFlowModuleLookUpEditView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsersLookUpEditView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIdStepFlowModuleUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ItemForIdStepFlowModule)).EndInit();
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
        private System.Windows.Forms.BindingSource stepsFlowModuleUserViewBindingSource;
        private DevExpress.XtraEditors.GridLookUpEdit StepsFlowModuleLookUpEdit;
        private System.Windows.Forms.BindingSource StepsFlowModuleBindingSource;
        private DevExpress.XtraEditors.GridLookUpEdit UsersLookUpEdit;
        private System.Windows.Forms.BindingSource UsersBindingSource;
        private DevExpress.XtraEditors.TextEdit IdStepFlowModuleUserTextEdit;
        private DevExpress.XtraGrid.Views.Grid.GridView StepsFlowModuleLookUpEditView;
        private DevExpress.XtraGrid.Views.Grid.GridView UsersLookUpEditView;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem ItemForIdStepFlowModuleUser;
        private DevExpress.XtraLayout.LayoutControlItem ItemForIdStepFlowModule;
        private DevExpress.XtraLayout.LayoutControlItem ItemForIdUser;
        private DevExpress.XtraGrid.Columns.GridColumn ColModule;
        private DevExpress.XtraGrid.Columns.GridColumn ColStepFlow;
        private DevExpress.XtraGrid.Columns.GridColumn ColSequence;
        private DevExpress.XtraGrid.Columns.GridColumn ColUserName;

    }
}
