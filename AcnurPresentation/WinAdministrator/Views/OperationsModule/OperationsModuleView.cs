using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace WinAdministrator.Views.OperationsModuleView
{
    public partial class OperationsModuleView : XtraUserControl
    {
        public OperationsModuleView()
        {
            InitializeComponent();
            if (!mvvmContext.IsDesignMode)
                InitBindings();
        }
        void InitBindings()
        {
            var fluentAPI = mvvmContext.OfType<WinAdministrator.ViewModels.OperationsModuleViewModel>();
            fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                operationsModuleViewBindingSource, x => x.Entity, x => x.Update());
            #region OperationsModuleUser Detail Collection
            // We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(OperationsModuleUserGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.OperationsModuleOperationsModuleUserDetails.SelectedEntity,
                    args => args.Row as Acnur.App.Repository.Data.OperationsModuleUser,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
            // We want to proceed the Edit command when row double-clicked
            fluentAPI.WithEvent<RowClickEventArgs>(OperationsModuleUserGridView, "RowClick")
                         .EventToCommand(
                             x => x.OperationsModuleOperationsModuleUserDetails.Edit(null), x => x.OperationsModuleOperationsModuleUserDetails.SelectedEntity,
                             args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
            //We want to show PopupMenu when row clicked by right button
            OperationsModuleUserGridView.RowClick += (s, e) =>
            {
                if (e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right)
                {
                    OperationsModuleUserPopUpMenu.ShowPopup(OperationsModuleUserGridControl.PointToScreen(e.Location), s);
                }
            };
            // We want to show the OperationsModuleOperationsModuleUserDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
            fluentAPI.SetBinding(OperationsModuleUserGridControl, g => g.DataSource, x => x.OperationsModuleOperationsModuleUserDetails.Entities);

            fluentAPI.BindCommand(bbiOperationsModuleUserNew, x => x.OperationsModuleOperationsModuleUserDetails.New());
            fluentAPI.BindCommand(bbiOperationsModuleUserEdit, x => x.OperationsModuleOperationsModuleUserDetails.Edit(null), x => x.OperationsModuleOperationsModuleUserDetails.SelectedEntity);
            fluentAPI.BindCommand(bbiOperationsModuleUserDelete, x => x.OperationsModuleOperationsModuleUserDetails.Delete(null), x => x.OperationsModuleOperationsModuleUserDetails.SelectedEntity);
            fluentAPI.BindCommand(bbiOperationsModuleUserRefresh, x => x.OperationsModuleOperationsModuleUserDetails.Refresh());
            #endregion
            // Binding for Modules LookUp editor
            fluentAPI.SetBinding(ModulesLookUpEdit.Properties, p => p.DataSource, x => x.LookUpModules.Entities);
            // Binding for Operations LookUp editor
            fluentAPI.SetBinding(OperationsLookUpEdit.Properties, p => p.DataSource, x => x.LookUpOperations.Entities);
            fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[0]), x => x.Save());
            fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[1]), x => x.SaveAndClose());
            fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[2]), x => x.SaveAndNew());
            fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[3]), x => x.Reset());
            fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[4]), x => x.Delete());
            fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelCloseButton.Buttons[0]), x => x.Close());
        }
    }
}
