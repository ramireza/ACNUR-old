using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace WinAdministrator.Views.UsersView
{
    public partial class UsersView : XtraUserControl
    {
        public UsersView()
        {
            InitializeComponent();
            if (!mvvmContext.IsDesignMode)
                InitBindings();
        }
        void InitBindings()
        {
            var fluentAPI = mvvmContext.OfType<WinAdministrator.ViewModels.UsersViewModel>();
            fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                usersViewBindingSource, x => x.Entity, x => x.Update());
            #region ModuleUser Detail Collection
            // We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(ModuleUserGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.UsersModuleUserDetails.SelectedEntity,
                    args => args.Row as Acnur.App.Repository.Data.ModuleUser,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
            // We want to proceed the Edit command when row double-clicked
            fluentAPI.WithEvent<RowClickEventArgs>(ModuleUserGridView, "RowClick")
                         .EventToCommand(
                             x => x.UsersModuleUserDetails.Edit(null), x => x.UsersModuleUserDetails.SelectedEntity,
                             args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
            //We want to show PopupMenu when row clicked by right button
            ModuleUserGridView.RowClick += (s, e) =>
            {
                if (e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right)
                {
                    ModuleUserPopUpMenu.ShowPopup(ModuleUserGridControl.PointToScreen(e.Location), s);
                }
            };
            // We want to show the UsersModuleUserDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
            fluentAPI.SetBinding(ModuleUserGridControl, g => g.DataSource, x => x.UsersModuleUserDetails.Entities);

            fluentAPI.BindCommand(bbiModuleUserNew, x => x.UsersModuleUserDetails.New());
            fluentAPI.BindCommand(bbiModuleUserEdit, x => x.UsersModuleUserDetails.Edit(null), x => x.UsersModuleUserDetails.SelectedEntity);
            fluentAPI.BindCommand(bbiModuleUserDelete, x => x.UsersModuleUserDetails.Delete(null), x => x.UsersModuleUserDetails.SelectedEntity);
            fluentAPI.BindCommand(bbiModuleUserRefresh, x => x.UsersModuleUserDetails.Refresh());
            #endregion
            #region OperationsModuleUser Detail Collection
            // We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(OperationsModuleUserGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.UsersOperationsModuleUserDetails.SelectedEntity,
                    args => args.Row as Acnur.App.Repository.Data.OperationsModuleUser,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
            // We want to proceed the Edit command when row double-clicked
            fluentAPI.WithEvent<RowClickEventArgs>(OperationsModuleUserGridView, "RowClick")
                         .EventToCommand(
                             x => x.UsersOperationsModuleUserDetails.Edit(null), x => x.UsersOperationsModuleUserDetails.SelectedEntity,
                             args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
            //We want to show PopupMenu when row clicked by right button
            OperationsModuleUserGridView.RowClick += (s, e) =>
            {
                if (e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right)
                {
                    OperationsModuleUserPopUpMenu.ShowPopup(OperationsModuleUserGridControl.PointToScreen(e.Location), s);
                }
            };
            // We want to show the UsersOperationsModuleUserDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
            fluentAPI.SetBinding(OperationsModuleUserGridControl, g => g.DataSource, x => x.UsersOperationsModuleUserDetails.Entities);

            fluentAPI.BindCommand(bbiOperationsModuleUserNew, x => x.UsersOperationsModuleUserDetails.New());
            fluentAPI.BindCommand(bbiOperationsModuleUserEdit, x => x.UsersOperationsModuleUserDetails.Edit(null), x => x.UsersOperationsModuleUserDetails.SelectedEntity);
            fluentAPI.BindCommand(bbiOperationsModuleUserDelete, x => x.UsersOperationsModuleUserDetails.Delete(null), x => x.UsersOperationsModuleUserDetails.SelectedEntity);
            fluentAPI.BindCommand(bbiOperationsModuleUserRefresh, x => x.UsersOperationsModuleUserDetails.Refresh());
            #endregion
            #region StepsFlowModuleUser Detail Collection
            // We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(StepsFlowModuleUserGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.UsersStepsFlowModuleUserDetails.SelectedEntity,
                    args => args.Row as Acnur.App.Repository.Data.StepsFlowModuleUser,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
            // We want to proceed the Edit command when row double-clicked
            fluentAPI.WithEvent<RowClickEventArgs>(StepsFlowModuleUserGridView, "RowClick")
                         .EventToCommand(
                             x => x.UsersStepsFlowModuleUserDetails.Edit(null), x => x.UsersStepsFlowModuleUserDetails.SelectedEntity,
                             args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
            //We want to show PopupMenu when row clicked by right button
            StepsFlowModuleUserGridView.RowClick += (s, e) =>
            {
                if (e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right)
                {
                    StepsFlowModuleUserPopUpMenu.ShowPopup(StepsFlowModuleUserGridControl.PointToScreen(e.Location), s);
                }
            };
            // We want to show the UsersStepsFlowModuleUserDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
            fluentAPI.SetBinding(StepsFlowModuleUserGridControl, g => g.DataSource, x => x.UsersStepsFlowModuleUserDetails.Entities);

            fluentAPI.BindCommand(bbiStepsFlowModuleUserNew, x => x.UsersStepsFlowModuleUserDetails.New());
            fluentAPI.BindCommand(bbiStepsFlowModuleUserEdit, x => x.UsersStepsFlowModuleUserDetails.Edit(null), x => x.UsersStepsFlowModuleUserDetails.SelectedEntity);
            fluentAPI.BindCommand(bbiStepsFlowModuleUserDelete, x => x.UsersStepsFlowModuleUserDetails.Delete(null), x => x.UsersStepsFlowModuleUserDetails.SelectedEntity);
            fluentAPI.BindCommand(bbiStepsFlowModuleUserRefresh, x => x.UsersStepsFlowModuleUserDetails.Refresh());
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
