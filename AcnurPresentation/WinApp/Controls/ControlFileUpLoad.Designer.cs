namespace WinApp
{
    partial class ControlFileUpLoad
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
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            this.FileWatcher = new System.IO.FileSystemWatcher();
            this.PnlChooseFile = new DevExpress.XtraEditors.PanelControl();
            this.LblDescription = new DevExpress.XtraEditors.LabelControl();
            this.TxtDescription = new DevExpress.XtraEditors.TextEdit();
            this.BtnOpenFile = new DevExpress.XtraEditors.SimpleButton();
            this.BtnUploadFile = new DevExpress.XtraEditors.SimpleButton();
            this.HplFileTemp = new DevExpress.XtraEditors.HyperLinkEdit();
            this.GrcFiles = new DevExpress.XtraGrid.GridControl();
            this.GrvFiles = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ColFileName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RIButtonFiles = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.ColSize = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.FileWatcher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PnlChooseFile)).BeginInit();
            this.PnlChooseFile.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.HplFileTemp.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrcFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrvFiles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RIButtonFiles)).BeginInit();
            this.SuspendLayout();
            // 
            // FileWatcher
            // 
            this.FileWatcher.EnableRaisingEvents = true;
            this.FileWatcher.SynchronizingObject = this;
            // 
            // PnlChooseFile
            // 
            this.PnlChooseFile.Controls.Add(this.LblDescription);
            this.PnlChooseFile.Controls.Add(this.TxtDescription);
            this.PnlChooseFile.Controls.Add(this.BtnOpenFile);
            this.PnlChooseFile.Controls.Add(this.BtnUploadFile);
            this.PnlChooseFile.Controls.Add(this.HplFileTemp);
            this.PnlChooseFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlChooseFile.Location = new System.Drawing.Point(0, 0);
            this.PnlChooseFile.Name = "PnlChooseFile";
            this.PnlChooseFile.Size = new System.Drawing.Size(897, 55);
            this.PnlChooseFile.TabIndex = 2;
            // 
            // LblDescription
            // 
            this.LblDescription.Location = new System.Drawing.Point(252, 12);
            this.LblDescription.Name = "LblDescription";
            this.LblDescription.Size = new System.Drawing.Size(60, 13);
            this.LblDescription.TabIndex = 4;
            this.LblDescription.Text = "Description: ";
            // 
            // TxtDescription
            // 
            this.TxtDescription.Location = new System.Drawing.Point(313, 9);
            this.TxtDescription.Name = "TxtDescription";
            this.TxtDescription.Properties.MaxLength = 4000;
            this.TxtDescription.Size = new System.Drawing.Size(574, 20);
            this.TxtDescription.TabIndex = 3;
            // 
            // BtnOpenFile
            // 
            this.BtnOpenFile.Location = new System.Drawing.Point(5, 7);
            this.BtnOpenFile.Name = "BtnOpenFile";
            this.BtnOpenFile.Size = new System.Drawing.Size(111, 23);
            this.BtnOpenFile.TabIndex = 0;
            this.BtnOpenFile.Text = "Choose file..";
            this.BtnOpenFile.Click += new System.EventHandler(this.btOpenFile_Click);
            // 
            // BtnUploadFile
            // 
            this.BtnUploadFile.Location = new System.Drawing.Point(134, 7);
            this.BtnUploadFile.Name = "BtnUploadFile";
            this.BtnUploadFile.Size = new System.Drawing.Size(111, 23);
            this.BtnUploadFile.TabIndex = 2;
            this.BtnUploadFile.Text = "Upload Now";
            this.BtnUploadFile.Click += new System.EventHandler(this.btUploadFile_Click);
            // 
            // HplFileTemp
            // 
            this.HplFileTemp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.HplFileTemp.Location = new System.Drawing.Point(2, 35);
            this.HplFileTemp.Name = "HplFileTemp";
            this.HplFileTemp.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.HplFileTemp.Size = new System.Drawing.Size(893, 18);
            this.HplFileTemp.TabIndex = 1;
            // 
            // GrcFiles
            // 
            this.GrcFiles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GrcFiles.Location = new System.Drawing.Point(0, 55);
            this.GrcFiles.MainView = this.GrvFiles;
            this.GrcFiles.Name = "GrcFiles";
            this.GrcFiles.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.RIButtonFiles});
            this.GrcFiles.Size = new System.Drawing.Size(897, 107);
            this.GrcFiles.TabIndex = 3;
            this.GrcFiles.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.GrvFiles});
            // 
            // GrvFiles
            // 
            this.GrvFiles.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[ ]{
            this.ColFileName,
            this.ColSize});
            this.GrvFiles.GridControl = this.GrcFiles;
            this.GrvFiles.Name = "GrvFiles";
            this.GrvFiles.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom;
            this.GrvFiles.OptionsView.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowAlways;
            this.GrvFiles.OptionsView.ShowGroupPanel = false;
            // 
            // ColFileName
            // 
            this.ColFileName.Caption = "File Name";
            this.ColFileName.ColumnEdit = this.RIButtonFiles;
            this.ColFileName.FieldName = "AttachmentName";
            this.ColFileName.Name = "ColFileName";
            this.ColFileName.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.ColFileName.OptionsColumn.ReadOnly = true;
            this.ColFileName.Visible = true;
            this.ColFileName.VisibleIndex = 0;
            this.ColFileName.Width = 571;
            // 
            // RIButtonFiles
            // 
            this.RIButtonFiles.AutoHeight = false;
            this.RIButtonFiles.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Open", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, "", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "Upload new file..", -1, true, false, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject2, "", null, null, true),
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Delete, "Delete", -1, true, true, false, DevExpress.XtraEditors.ImageLocation.MiddleCenter, null, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject3, "", null, null, true)});
            this.RIButtonFiles.Name = "RIButtonFiles";
            this.RIButtonFiles.ReadOnly = true;
            this.RIButtonFiles.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.RIButtonFiles_ButtonClick);
            // 
            // ColSize
            // 
            this.ColSize.Caption = "Description";
            this.ColSize.FieldName = "Description";
            this.ColSize.Name = "ColSize";
            this.ColSize.OptionsColumn.AllowEdit = false;
            this.ColSize.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.ColSize.OptionsColumn.ReadOnly = true;
            this.ColSize.UnboundType = DevExpress.Data.UnboundColumnType.String;
            this.ColSize.Visible = true;
            this.ColSize.VisibleIndex = 1;
            this.ColSize.Width = 400;
            // 
            // ControlFileUpLoad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GrcFiles);
            this.Controls.Add(this.PnlChooseFile);
            this.Name = "ControlFileUpLoad";
            this.Size = new System.Drawing.Size(897, 162);
            ((System.ComponentModel.ISupportInitialize)(this.FileWatcher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PnlChooseFile)).EndInit();
            this.PnlChooseFile.ResumeLayout(false);
            this.PnlChooseFile.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.HplFileTemp.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrcFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GrvFiles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RIButtonFiles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.IO.FileSystemWatcher FileWatcher;
        private DevExpress.XtraEditors.PanelControl PnlChooseFile;
        private DevExpress.XtraEditors.SimpleButton BtnUploadFile;
        private DevExpress.XtraEditors.HyperLinkEdit HplFileTemp;
        private DevExpress.XtraEditors.SimpleButton BtnOpenFile;
        private DevExpress.XtraGrid.GridControl GrcFiles;
        private DevExpress.XtraGrid.Views.Grid.GridView GrvFiles;
        private DevExpress.XtraGrid.Columns.GridColumn ColFileName;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit RIButtonFiles;
        private DevExpress.XtraGrid.Columns.GridColumn ColSize;
        private DevExpress.XtraEditors.LabelControl LblDescription;
        private DevExpress.XtraEditors.TextEdit TxtDescription;
    }
}
