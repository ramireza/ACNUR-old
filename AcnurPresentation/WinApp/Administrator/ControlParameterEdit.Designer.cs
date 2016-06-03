namespace WinApp
{
    partial class ControlParameterEdit
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
            this.GrControlParameter = new DevExpress.XtraGrid.GridControl();
            this.GrViewParameter = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColIdParameterDetail = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColIdParameter = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColParameterType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColDefinition = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ColActive = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RIChkActive = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.GrControlParameter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrViewParameter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RIChkActive)).BeginInit();
            this.SuspendLayout();
            // 
            // GrControlParameter
            // 
            this.GrControlParameter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrControlParameter.EmbeddedNavigator.Appearance.Options.UseTextOptions = true;
            this.GrControlParameter.EmbeddedNavigator.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.GrControlParameter.EmbeddedNavigator.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.GrControlParameter.EmbeddedNavigator.Buttons.CancelEdit.Visible = false;
            this.GrControlParameter.EmbeddedNavigator.Buttons.EndEdit.Visible = false;
            this.GrControlParameter.EmbeddedNavigator.ButtonClick += new DevExpress.XtraEditors.NavigatorButtonClickEventHandler(this.GrControlParameter_EmbeddedNavigator_Click);
            this.GrControlParameter.Location = new System.Drawing.Point(0, 0);
            this.GrControlParameter.MainView = this.GrViewParameter;
            this.GrControlParameter.Name = "GrControlParameter";
            this.GrControlParameter.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.RIChkActive});
            this.GrControlParameter.Size = new System.Drawing.Size(911, 350);
            this.GrControlParameter.TabIndex = 4;
            this.GrControlParameter.UseEmbeddedNavigator = true;
            this.GrControlParameter.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GrViewParameter});
            // 
            // GrViewParameter
            // 
            this.GrViewParameter.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ColIdParameterDetail,
            this.ColIdParameter,
            this.ColParameterType,
            this.ColName,
            this.ColDefinition,
            this.ColActive});
            this.GrViewParameter.GridControl = this.GrControlParameter;
            this.GrViewParameter.Name = "GrViewParameter";
            this.GrViewParameter.OptionsView.ShowFooter = true;
            // 
            // ColIdParameterDetail
            // 
            this.ColIdParameterDetail.FieldName = "IdParameterDetail";
            this.ColIdParameterDetail.Name = "ColIdParameterDetail";
            // 
            // ColIdParameter
            // 
            this.ColIdParameter.FieldName = "IdParameter";
            this.ColIdParameter.Name = "ColIdParameter";
            // 
            // ColParameterType
            // 
            this.ColParameterType.Caption = "Parameter Type";
            this.ColParameterType.FieldName = "ParameterType";
            this.ColParameterType.Name = "ColParameterType";
            this.ColParameterType.Visible = true;
            this.ColParameterType.VisibleIndex = 0;
            this.ColParameterType.Width = 180;
            // 
            // ColName
            // 
            this.ColName.Caption = "Name";
            this.ColName.FieldName = "Name";
            this.ColName.Name = "ColName";
            this.ColName.Visible = true;
            this.ColName.VisibleIndex = 1;
            this.ColName.Width = 177;
            // 
            // ColDefinition
            // 
            this.ColDefinition.Caption = "Definition";
            this.ColDefinition.FieldName = "Definition";
            this.ColDefinition.Name = "ColDefinition";
            this.ColDefinition.Visible = true;
            this.ColDefinition.VisibleIndex = 2;
            this.ColDefinition.Width = 469;
            // 
            // ColActive
            // 
            this.ColActive.Caption = "Active";
            this.ColActive.ColumnEdit = this.RIChkActive;
            this.ColActive.FieldName = "Active";
            this.ColActive.Name = "ColActive";
            this.ColActive.Visible = true;
            this.ColActive.VisibleIndex = 3;
            this.ColActive.Width = 66;
            // 
            // RIChkActive
            // 
            this.RIChkActive.AutoHeight = false;
            this.RIChkActive.Name = "RIChkActive";
            this.RIChkActive.ReadOnly = true;
            // 
            // ParameterEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GrControlParameter);
            this.Name = "ParameterEdit";
            this.Size = new System.Drawing.Size(911, 350);
            this.Load += new System.EventHandler(this.ParameterEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.GrControlParameter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrViewParameter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RIChkActive)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl GrControlParameter;
        private DevExpress.XtraGrid.Views.Grid.GridView GrViewParameter;
        private DevExpress.XtraGrid.Columns.GridColumn ColParameterType;
        private DevExpress.XtraGrid.Columns.GridColumn ColName;
        private DevExpress.XtraGrid.Columns.GridColumn ColDefinition;
        private DevExpress.XtraGrid.Columns.GridColumn ColIdParameterDetail;
        private DevExpress.XtraGrid.Columns.GridColumn ColIdParameter;
        private DevExpress.XtraGrid.Columns.GridColumn ColActive;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit RIChkActive;
    }
}
