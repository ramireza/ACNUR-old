namespace WinApp
{
    partial class FormWelcome
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormWelcome));
            this.LookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.GrcMenu = new DevExpress.XtraGrid.GridControl();
            this.CrvMenu = new DevExpress.XtraGrid.Views.Card.CardView();
            this.ColName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColImageMenu = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RiPictureMenu = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.BtnFinalize = new DevExpress.XtraEditors.SimpleButton();
            this.MemoDataPurchase = new DevExpress.XtraEditors.MemoEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.CmbProcessGroup = new DevExpress.XtraEditors.ComboBoxEdit();
            this.LblGUID = new DevExpress.XtraEditors.LabelControl();
            this.ValidationProviderWelcome = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.GrcMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CrvMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RiPictureMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemoDataPurchase.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbProcessGroup.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValidationProviderWelcome)).BeginInit();
            this.SuspendLayout();
            // 
            // LookAndFeel
            // 
            this.LookAndFeel.LookAndFeel.SkinName = "Liquid Sky";
            // 
            // GrcMenu
            // 
            this.GrcMenu.Location = new System.Drawing.Point(2, 42);
            this.GrcMenu.MainView = this.CrvMenu;
            this.GrcMenu.Name = "GrcMenu";
            this.GrcMenu.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.RiPictureMenu});
            this.GrcMenu.Size = new System.Drawing.Size(673, 330);
            this.GrcMenu.TabIndex = 6;
            this.GrcMenu.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.CrvMenu});
            // 
            // CrvMenu
            // 
            this.CrvMenu.Appearance.CardCaption.Font = new System.Drawing.Font("Tahoma", 8.5F, System.Drawing.FontStyle.Bold);
            this.CrvMenu.Appearance.CardCaption.ForeColor = System.Drawing.Color.SlateGray;
            this.CrvMenu.Appearance.CardCaption.Options.UseFont = true;
            this.CrvMenu.Appearance.CardCaption.Options.UseForeColor = true;
            this.CrvMenu.Appearance.CardCaption.Options.UseTextOptions = true;
            this.CrvMenu.Appearance.CardCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.CrvMenu.CardCaptionFormat = "{1}";
            this.CrvMenu.CardWidth = 300;
            this.CrvMenu.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColName,
            this.ColImageMenu});
            this.CrvMenu.FocusedCardTopFieldIndex = 0;
            this.CrvMenu.GridControl = this.GrcMenu;
            this.CrvMenu.MaximumCardColumns = 3;
            this.CrvMenu.MaximumCardRows = 3;
            this.CrvMenu.Name = "CrvMenu";
            this.CrvMenu.OptionsBehavior.AutoHorzWidth = true;
            this.CrvMenu.OptionsBehavior.FieldAutoHeight = true;
            this.CrvMenu.OptionsView.ShowCardExpandButton = false;
            this.CrvMenu.OptionsView.ShowFieldCaptions = false;
            this.CrvMenu.OptionsView.ShowQuickCustomizeButton = false;
            this.CrvMenu.VertScrollVisibility = DevExpress.XtraGrid.Views.Base.ScrollVisibility.Auto;
            // 
            // ColName
            // 
            this.ColName.AppearanceCell.Options.UseTextOptions = true;
            this.ColName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near;
            this.ColName.FieldName = "ModuleName";
            this.ColName.Name = "ColName";
            // 
            // ColImageMenu
            // 
            this.ColImageMenu.ColumnEdit = this.RiPictureMenu;
            this.ColImageMenu.CustomizationCaption = "{1}";
            this.ColImageMenu.FieldName = "Picture";
            this.ColImageMenu.Name = "ColImageMenu";
            this.ColImageMenu.OptionsColumn.ShowCaption = false;
            this.ColImageMenu.Visible = true;
            this.ColImageMenu.VisibleIndex = 0;
            // 
            // RiPictureMenu
            // 
            this.RiPictureMenu.AccessibleName = "";
            this.RiPictureMenu.CustomHeight = 110;
            this.RiPictureMenu.Name = "RiPictureMenu";
            this.RiPictureMenu.PictureAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.RiPictureMenu.Click += new System.EventHandler(this.RiPictureMenu_Click);
            // 
            // BtnFinalize
            // 
            this.BtnFinalize.Appearance.Options.UseTextOptions = true;
            this.BtnFinalize.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.BtnFinalize.Location = new System.Drawing.Point(578, 379);
            this.BtnFinalize.Name = "BtnFinalize";
            this.BtnFinalize.Size = new System.Drawing.Size(97, 30);
            this.BtnFinalize.TabIndex = 7;
            this.BtnFinalize.Text = "Finalize";
            this.BtnFinalize.Click += new System.EventHandler(this.BtnFinalize_Click);
            // 
            // MemoDataPurchase
            // 
            this.MemoDataPurchase.Location = new System.Drawing.Point(2, 378);
            this.MemoDataPurchase.Name = "MemoDataPurchase";
            this.MemoDataPurchase.Size = new System.Drawing.Size(11, 10);
            this.MemoDataPurchase.TabIndex = 8;
            this.MemoDataPurchase.Visible = false;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(2, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(73, 13);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "Process Group:";
            // 
            // CmbProcessGroup
            // 
            this.ValidationProviderWelcome.SetIconAlignment(this.CmbProcessGroup, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.CmbProcessGroup.Location = new System.Drawing.Point(81, 9);
            this.CmbProcessGroup.Name = "CmbProcessGroup";
            this.CmbProcessGroup.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CmbProcessGroup.Size = new System.Drawing.Size(153, 20);
            this.CmbProcessGroup.TabIndex = 11;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.NotContains;
            conditionValidationRule1.ErrorText = "Please choose a value";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            conditionValidationRule1.Value1 = "Seleccione por favor...";
            this.ValidationProviderWelcome.SetValidationRule(this.CmbProcessGroup, conditionValidationRule1);
            // 
            // LblGUID
            // 
            this.LblGUID.Location = new System.Drawing.Point(42, 379);
            this.LblGUID.Name = "LblGUID";
            this.LblGUID.Size = new System.Drawing.Size(3, 13);
            this.LblGUID.TabIndex = 12;
            this.LblGUID.Text = " ";
            this.LblGUID.Visible = false;
            // 
            // ValidationProviderWelcome
            // 
            this.ValidationProviderWelcome.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
            // 
            // FormWelcome
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(678, 418);
            this.Controls.Add(this.LblGUID);
            this.Controls.Add(this.BtnFinalize);
            this.Controls.Add(this.CmbProcessGroup);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.MemoDataPurchase);
            this.Controls.Add(this.GrcMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormWelcome";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.GrcMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CrvMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RiPictureMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemoDataPurchase.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbProcessGroup.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ValidationProviderWelcome)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel LookAndFeel;
        private DevExpress.XtraGrid.GridControl GrcMenu;
        private DevExpress.XtraGrid.Views.Card.CardView CrvMenu;
        private DevExpress.XtraGrid.Columns.GridColumn ColName;
        private DevExpress.XtraGrid.Columns.GridColumn ColImageMenu;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit RiPictureMenu;
        private DevExpress.XtraEditors.SimpleButton BtnFinalize;
        private DevExpress.XtraEditors.MemoEdit MemoDataPurchase;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit CmbProcessGroup;
        private DevExpress.XtraEditors.LabelControl LblGUID;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider ValidationProviderWelcome;
    }
}
