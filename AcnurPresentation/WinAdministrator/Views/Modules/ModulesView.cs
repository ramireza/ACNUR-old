using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace WinAdministrator.Views.ModulesView
{
    public partial class ModulesView : XtraUserControl
    {
        public ModulesView()
        {
            InitializeComponent();
            if (!mvvmContext.IsDesignMode)
                InitBindings();
        }
        void InitBindings()
        {
            var fluentAPI = mvvmContext.OfType<WinAdministrator.ViewModels.ModulesViewModel>();
            fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                modulesViewBindingSource, x => x.Entity, x => x.Update());
            #region ComponentsByModule Detail Collection
            // We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(ComponentsByModuleGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.ModulesComponentsByModuleDetails.SelectedEntity,
                    args => args.Row as Acnur.App.Repository.Data.ComponentsByModule,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
            // We want to proceed the Edit command when row double-clicked
            fluentAPI.WithEvent<RowClickEventArgs>(ComponentsByModuleGridView, "RowClick")
                         .EventToCommand(
                             x => x.ModulesComponentsByModuleDetails.Edit(null), x => x.ModulesComponentsByModuleDetails.SelectedEntity,
                             args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
            //We want to show PopupMenu when row clicked by right button
            ComponentsByModuleGridView.RowClick += (s, e) =>
            {
                if (e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right)
                {
                    ComponentsByModulePopUpMenu.ShowPopup(ComponentsByModuleGridControl.PointToScreen(e.Location), s);
                }
            };
            // We want to show the ModulesComponentsByModuleDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
            fluentAPI.SetBinding(ComponentsByModuleGridControl, g => g.DataSource, x => x.ModulesComponentsByModuleDetails.Entities);

            fluentAPI.BindCommand(bbiComponentsByModuleNew, x => x.ModulesComponentsByModuleDetails.New());
            fluentAPI.BindCommand(bbiComponentsByModuleEdit, x => x.ModulesComponentsByModuleDetails.Edit(null), x => x.ModulesComponentsByModuleDetails.SelectedEntity);
            fluentAPI.BindCommand(bbiComponentsByModuleDelete, x => x.ModulesComponentsByModuleDetails.Delete(null), x => x.ModulesComponentsByModuleDetails.SelectedEntity);
            fluentAPI.BindCommand(bbiComponentsByModuleRefresh, x => x.ModulesComponentsByModuleDetails.Refresh());
            #endregion
            #region ModuleUser Detail Collection
            // We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(ModuleUserGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.ModulesModuleUserDetails.SelectedEntity,
                    args => args.Row as Acnur.App.Repository.Data.ModuleUser,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
            // We want to proceed the Edit command when row double-clicked
            fluentAPI.WithEvent<RowClickEventArgs>(ModuleUserGridView, "RowClick")
                         .EventToCommand(
                             x => x.ModulesModuleUserDetails.Edit(null), x => x.ModulesModuleUserDetails.SelectedEntity,
                             args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
            //We want to show PopupMenu when row clicked by right button
            ModuleUserGridView.RowClick += (s, e) =>
            {
                if (e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right)
                {
                    ModuleUserPopUpMenu.ShowPopup(ModuleUserGridControl.PointToScreen(e.Location), s);
                }
            };
            // We want to show the ModulesModuleUserDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
            fluentAPI.SetBinding(ModuleUserGridControl, g => g.DataSource, x => x.ModulesModuleUserDetails.Entities);

            fluentAPI.BindCommand(bbiModuleUserNew, x => x.ModulesModuleUserDetails.New());
            fluentAPI.BindCommand(bbiModuleUserEdit, x => x.ModulesModuleUserDetails.Edit(null), x => x.ModulesModuleUserDetails.SelectedEntity);
            fluentAPI.BindCommand(bbiModuleUserDelete, x => x.ModulesModuleUserDetails.Delete(null), x => x.ModulesModuleUserDetails.SelectedEntity);
            fluentAPI.BindCommand(bbiModuleUserRefresh, x => x.ModulesModuleUserDetails.Refresh());
            #endregion
            #region OperationsModule Detail Collection
            // We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(OperationsModuleGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.ModulesOperationsModuleDetails.SelectedEntity,
                    args => args.Row as Acnur.App.Repository.Data.OperationsModule,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
            // We want to proceed the Edit command when row double-clicked
            fluentAPI.WithEvent<RowClickEventArgs>(OperationsModuleGridView, "RowClick")
                         .EventToCommand(
                             x => x.ModulesOperationsModuleDetails.Edit(null), x => x.ModulesOperationsModuleDetails.SelectedEntity,
                             args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
            //We want to show PopupMenu when row clicked by right button
            OperationsModuleGridView.RowClick += (s, e) =>
            {
                if (e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right)
                {
                    OperationsModulePopUpMenu.ShowPopup(OperationsModuleGridControl.PointToScreen(e.Location), s);
                }
            };
            // We want to show the ModulesOperationsModuleDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
            fluentAPI.SetBinding(OperationsModuleGridControl, g => g.DataSource, x => x.ModulesOperationsModuleDetails.Entities);

            fluentAPI.BindCommand(bbiOperationsModuleNew, x => x.ModulesOperationsModuleDetails.New());
            fluentAPI.BindCommand(bbiOperationsModuleEdit, x => x.ModulesOperationsModuleDetails.Edit(null), x => x.ModulesOperationsModuleDetails.SelectedEntity);
            fluentAPI.BindCommand(bbiOperationsModuleDelete, x => x.ModulesOperationsModuleDetails.Delete(null), x => x.ModulesOperationsModuleDetails.SelectedEntity);
            fluentAPI.BindCommand(bbiOperationsModuleRefresh, x => x.ModulesOperationsModuleDetails.Refresh());
            #endregion
            #region StepsFlowModule Detail Collection
            // We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(StepsFlowModuleGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.ModulesStepsFlowModuleDetails.SelectedEntity,
                    args => args.Row as Acnur.App.Repository.Data.StepsFlowModule,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
            // We want to proceed the Edit command when row double-clicked
            fluentAPI.WithEvent<RowClickEventArgs>(StepsFlowModuleGridView, "RowClick")
                         .EventToCommand(
                             x => x.ModulesStepsFlowModuleDetails.Edit(null), x => x.ModulesStepsFlowModuleDetails.SelectedEntity,
                             args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
            //We want to show PopupMenu when row clicked by right button
            StepsFlowModuleGridView.RowClick += (s, e) =>
            {
                if (e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right)
                {
                    StepsFlowModulePopUpMenu.ShowPopup(StepsFlowModuleGridControl.PointToScreen(e.Location), s);
                }
            };
            // We want to show the ModulesStepsFlowModuleDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
            fluentAPI.SetBinding(StepsFlowModuleGridControl, g => g.DataSource, x => x.ModulesStepsFlowModuleDetails.Entities);

            fluentAPI.BindCommand(bbiStepsFlowModuleNew, x => x.ModulesStepsFlowModuleDetails.New());
            fluentAPI.BindCommand(bbiStepsFlowModuleEdit, x => x.ModulesStepsFlowModuleDetails.Edit(null), x => x.ModulesStepsFlowModuleDetails.SelectedEntity);
            fluentAPI.BindCommand(bbiStepsFlowModuleDelete, x => x.ModulesStepsFlowModuleDetails.Delete(null), x => x.ModulesStepsFlowModuleDetails.SelectedEntity);
            fluentAPI.BindCommand(bbiStepsFlowModuleRefresh, x => x.ModulesStepsFlowModuleDetails.Refresh());
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
