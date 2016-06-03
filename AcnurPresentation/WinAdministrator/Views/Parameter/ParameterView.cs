using System;
using System.Linq;
using System.Collections.Generic;
using DevExpress.XtraEditors;
using DevExpress.Utils.MVVM;
using DevExpress.Utils.MVVM.Services;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Base;

namespace WinAdministrator.Views.ParameterView
{
    public partial class ParameterView : XtraUserControl
    {
        public ParameterView()
        {
            InitializeComponent();
            if (!mvvmContext.IsDesignMode)
                InitBindings();
        }
        void InitBindings()
        {
            var fluentAPI = mvvmContext.OfType<WinAdministrator.ViewModels.ParameterViewModel>();
            fluentAPI.WithEvent(this, "Load").EventToCommand(x => x.OnLoaded());
            fluentAPI.SetObjectDataSourceBinding(
                parameterViewBindingSource, x => x.Entity, x => x.Update());
            #region ParameterDetail Detail Collection
            // We want to synchronize the ViewModel.SelectedEntity and the GridView.FocusedRowRandle in two-way manner
            fluentAPI.WithEvent<GridView, FocusedRowObjectChangedEventArgs>(ParameterDetailGridView, "FocusedRowObjectChanged")
                .SetBinding(x => x.ParameterParameterDetailDetails.SelectedEntity,
                    args => args.Row as Acnur.App.Repository.Data.ParameterDetail,
                    (gView, entity) => gView.FocusedRowHandle = gView.FindRow(entity));
            // We want to proceed the Edit command when row double-clicked
            fluentAPI.WithEvent<RowClickEventArgs>(ParameterDetailGridView, "RowClick")
                         .EventToCommand(
                             x => x.ParameterParameterDetailDetails.Edit(null), x => x.ParameterParameterDetailDetails.SelectedEntity,
                             args => (args.Clicks == 2) && (args.Button == System.Windows.Forms.MouseButtons.Left));
            //We want to show PopupMenu when row clicked by right button
            ParameterDetailGridView.RowClick += (s, e) =>
            {
                if (e.Clicks == 1 && e.Button == System.Windows.Forms.MouseButtons.Right)
                {
                    ParameterDetailPopUpMenu.ShowPopup(ParameterDetailGridControl.PointToScreen(e.Location), s);
                }
            };
            // We want to show the ParameterParameterDetailDetails collection in grid and react on this collection external changes (Reload, server-side Filtering)
            fluentAPI.SetBinding(ParameterDetailGridControl, g => g.DataSource, x => x.ParameterParameterDetailDetails.Entities);

            fluentAPI.BindCommand(bbiParameterDetailNew, x => x.ParameterParameterDetailDetails.New());
            fluentAPI.BindCommand(bbiParameterDetailEdit, x => x.ParameterParameterDetailDetails.Edit(null), x => x.ParameterParameterDetailDetails.SelectedEntity);
            fluentAPI.BindCommand(bbiParameterDetailDelete, x => x.ParameterParameterDetailDetails.Delete(null), x => x.ParameterParameterDetailDetails.SelectedEntity);
            fluentAPI.BindCommand(bbiParameterDetailRefresh, x => x.ParameterParameterDetailDetails.Refresh());
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
