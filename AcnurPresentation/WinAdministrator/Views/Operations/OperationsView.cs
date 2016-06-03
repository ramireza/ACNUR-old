using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace WinAdministrator.Views.OperationsView
{
    public partial class OperationsView : XtraUserControl
    {
        public OperationsView()
        {
            InitializeComponent();
            if (!mvvmContext.IsDesignMode)
                InitBindings();
        }
        void InitBindings()
        {
            var fluentAPI = mvvmContext.OfType<WinAdministrator.ViewModels.OperationsViewModel>();
            fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                operationsViewBindingSource, x => x.Entity, x => x.Update());
            #region OperationsModule Detail Collection
            // We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(OperationsModuleGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.OperationsOperationsModuleDetails.SelectedEntity,
                    args => args.Row as Acnur.App.Repository.Data.OperationsModule,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
            // We want to proceed the Edit command when row double-clicked
            fluentAPI.WithEvent<RowClickEventArgs>(OperationsModuleGridView, "RowClick")
                         .EventToCommand(
                             x => x.OperationsOperationsModuleDetails.Edit(null), x => x.OperationsOperationsModuleDetails.SelectedEntity,
                             args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
            //We want to show PopupMenu when row clicked by right button
            OperationsModuleGridView.RowClick += (s, e) =>
            {
                if (e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right)
                {
                    OperationsModulePopUpMenu.ShowPopup(OperationsModuleGridControl.PointToScreen(e.Location), s);
                }
            };
            // We want to show the OperationsOperationsModuleDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
            fluentAPI.SetBinding(OperationsModuleGridControl, g => g.DataSource, x => x.OperationsOperationsModuleDetails.Entities);

            fluentAPI.BindCommand(bbiOperationsModuleNew, x => x.OperationsOperationsModuleDetails.New());
            fluentAPI.BindCommand(bbiOperationsModuleEdit, x => x.OperationsOperationsModuleDetails.Edit(null), x => x.OperationsOperationsModuleDetails.SelectedEntity);
            fluentAPI.BindCommand(bbiOperationsModuleDelete, x => x.OperationsOperationsModuleDetails.Delete(null), x => x.OperationsOperationsModuleDetails.SelectedEntity);
            fluentAPI.BindCommand(bbiOperationsModuleRefresh, x => x.OperationsOperationsModuleDetails.Refresh());
            #endregion
            fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[0]), x => x.Save());
            fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[1]), x => x.SaveAndClose());
            fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[2]), x => x.SaveAndNew());
            fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[3]), x => x.Reset());
            fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelMain.Buttons[4]), x => x.Delete());
            fluentAPI.BindCommand(((DevExpress.Utils.MVVM.ISupportCommandBinding)windowsUIButtonPanelCloseButton.Buttons[0]), x => x.Close());
        }
    }
}
