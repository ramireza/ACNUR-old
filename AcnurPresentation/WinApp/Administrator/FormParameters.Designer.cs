namespace WinApp
{
    partial class FormParameters
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
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule1 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule conditionValidationRule2 = new DevExpress.XtraEditors.DXErrorProvider.ConditionValidationRule();
            this.BtnOk = new DevExpress.XtraEditors.SimpleButton();
            this.BtnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.ValidationProviderEdit = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider();
            this.TxtParameterName = new DevExpress.XtraEditors.TextEdit();
            this.CmbParameterType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.LblParameterName = new DevExpress.XtraEditors.LabelControl();
            this.LblParameter = new DevExpress.XtraEditors.LabelControl();
            this.LblDefinition = new DevExpress.XtraEditors.LabelControl();
            this.ChkActive = new DevExpress.XtraEditors.CheckEdit();
            this.MemoDefinition = new DevExpress.XtraEditors.MemoEdit();
            this.LblIdParameterDetalle = new DevExpress.XtraEditors.LabelControl();
            this.ChkEdit = new DevExpress.XtraEditors.CheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ValidationProviderEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtParameterName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbParameterType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChkActive.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemoDefinition.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChkEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnOk
            // 
            this.BtnOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.BtnOk.Location = new System.Drawing.Point(245, 287);
            this.BtnOk.Name = "BtnOk";
            this.BtnOk.Size = new System.Drawing.Size(75, 30);
            this.BtnOk.TabIndex = 4;
            this.BtnOk.Text = "&OK";
            this.BtnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnCancel.Location = new System.Drawing.Point(330, 287);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(75, 30);
            this.BtnCancel.TabIndex = 5;
            this.BtnCancel.Text = "&Cancel";
            // 
            // ValidationProviderEdit
            // 
            this.ValidationProviderEdit.ValidationMode = DevExpress.XtraEditors.DXErrorProvider.ValidationMode.Manual;
            // 
            // TxtParameterName
            // 
            this.ValidationProviderEdit.SetIconAlignment(this.TxtParameterName, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.TxtParameterName.Location = new System.Drawing.Point(29, 88);
            this.TxtParameterName.Name = "TxtParameterName";
            this.TxtParameterName.Size = new System.Drawing.Size(376, 20);
            this.TxtParameterName.TabIndex = 1;
            this.TxtParameterName.ToolTip = "Ingrese el nombre del parámetro";
            this.TxtParameterName.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            conditionValidationRule1.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.IsNotBlank;
            conditionValidationRule1.ErrorText = "This value is required";
            conditionValidationRule1.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            this.ValidationProviderEdit.SetValidationRule(this.TxtParameterName, conditionValidationRule1);
            // 
            // CmbParameterType
            // 
            this.ValidationProviderEdit.SetIconAlignment(this.CmbParameterType, System.Windows.Forms.ErrorIconAlignment.MiddleRight);
            this.CmbParameterType.Location = new System.Drawing.Point(29, 34);
            this.CmbParameterType.Name = "CmbParameterType";
            this.CmbParameterType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CmbParameterType.Size = new System.Drawing.Size(376, 20);
            this.CmbParameterType.TabIndex = 0;
            this.CmbParameterType.ToolTip = "Tipo de parámetro";
            this.CmbParameterType.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            conditionValidationRule2.ConditionOperator = DevExpress.XtraEditors.DXErrorProvider.ConditionOperator.NotEquals;
            conditionValidationRule2.ErrorText = "Please choose a value";
            conditionValidationRule2.ErrorType = DevExpress.XtraEditors.DXErrorProvider.ErrorType.Warning;
            conditionValidationRule2.Value1 = "Seleccione por favor...";
            this.ValidationProviderEdit.SetValidationRule(this.CmbParameterType, conditionValidationRule2);
            // 
            // LblParameterName
            // 
            this.LblParameterName.Location = new System.Drawing.Point(29, 68);
            this.LblParameterName.Name = "LblParameterName";
            this.LblParameterName.Size = new System.Drawing.Size(83, 13);
            this.LblParameterName.TabIndex = 3;
            this.LblParameterName.Text = "Parameter Name ";
            // 
            // LblParameter
            // 
            this.LblParameter.Location = new System.Drawing.Point(29, 14);
            this.LblParameter.Name = "LblParameter";
            this.LblParameter.Size = new System.Drawing.Size(77, 13);
            this.LblParameter.TabIndex = 4;
            this.LblParameter.Text = "Parameter Type";
            // 
            // LblDefinition
            // 
            this.LblDefinition.Location = new System.Drawing.Point(29, 126);
            this.LblDefinition.Name = "LblDefinition";
            this.LblDefinition.Size = new System.Drawing.Size(45, 13);
            this.LblDefinition.TabIndex = 5;
            this.LblDefinition.Text = "Definition";
            // 
            // ChkActive
            // 
            this.ChkActive.EditValue = true;
            this.ChkActive.Location = new System.Drawing.Point(29, 247);
            this.ChkActive.Name = "ChkActive";
            this.ChkActive.Properties.Caption = "Active";
            this.ChkActive.Size = new System.Drawing.Size(75, 19);
            this.ChkActive.TabIndex = 3;
            // 
            // MemoDefinition
            // 
            this.MemoDefinition.Location = new System.Drawing.Point(29, 145);
            this.MemoDefinition.Name = "MemoDefinition";
            this.MemoDefinition.Size = new System.Drawing.Size(376, 96);
            this.MemoDefinition.TabIndex = 2;
            this.MemoDefinition.ToolTip = "Ingrese la definición del parámetro ingresado";
            this.MemoDefinition.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information;
            // 
            // LblIdParameterDetalle
            // 
            this.LblIdParameterDetalle.Location = new System.Drawing.Point(29, 287);
            this.LblIdParameterDetalle.Name = "LblIdParameterDetalle";
            this.LblIdParameterDetalle.Size = new System.Drawing.Size(0, 13);
            this.LblIdParameterDetalle.TabIndex = 6;
            this.LblIdParameterDetalle.Visible = false;
            // 
            // ChkEdit
            // 
            this.ChkEdit.Location = new System.Drawing.Point(29, 273);
            this.ChkEdit.Name = "ChkEdit";
            this.ChkEdit.Properties.Caption = "";
            this.ChkEdit.Size = new System.Drawing.Size(0, 19);
            this.ChkEdit.TabIndex = 7;
            this.ChkEdit.Visible = false;
            // 
            // Parameters
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 340);
            this.Controls.Add(this.ChkEdit);
            this.Controls.Add(this.LblIdParameterDetalle);
            this.Controls.Add(this.MemoDefinition);
            this.Controls.Add(this.ChkActive);
            this.Controls.Add(this.CmbParameterType);
            this.Controls.Add(this.LblDefinition);
            this.Controls.Add(this.LblParameter);
            this.Controls.Add(this.LblParameterName);
            this.Controls.Add(this.TxtParameterName);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnOk);
            this.LookAndFeel.SkinName = "The Asphalt World";
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(373, 200);
            this.Name = "Parameters";
            this.Padding = new System.Windows.Forms.Padding(10);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.ValidationProviderEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtParameterName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CmbParameterType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChkActive.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemoDefinition.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ChkEdit.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraEditors.SimpleButton BtnOk;
        private DevExpress.XtraEditors.SimpleButton BtnCancel;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider ValidationProviderEdit;
        private DevExpress.XtraEditors.TextEdit TxtParameterName;
        private DevExpress.XtraEditors.LabelControl LblParameterName;
        private DevExpress.XtraEditors.LabelControl LblParameter;
        private DevExpress.XtraEditors.LabelControl LblDefinition;
        private DevExpress.XtraEditors.ComboBoxEdit CmbParameterType;
        private DevExpress.XtraEditors.CheckEdit ChkActive;
        private DevExpress.XtraEditors.MemoEdit MemoDefinition;
        private DevExpress.XtraEditors.LabelControl LblIdParameterDetalle;
        private DevExpress.XtraEditors.CheckEdit ChkEdit;
    }
}