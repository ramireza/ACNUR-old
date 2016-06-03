// ***********************************************************************
// Assembly         : WinApp
// Author           : Mauricio Ospina - Cel: 3204958448 - ambrosio.mauro@gmail.com
// Created          : 02-17-2016
//
// Last Modified By : Mauricio Ospina
// Last Modified On : 02-25-2016
// ***********************************************************************
// <copyright file="ControlRequestEdit.cs" company="Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR">
//     Este producto fue desarrollado para Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR. Todos los derechos reservados.
// </copyright>
// <summary>Clase que contiene los métodos para la funcionalidad de la página principal de las solicitudes</summary>
// ***********************************************************************

/// <summary>
/// The WinApp namespace.
/// </summary>
namespace WinApp
{
    using Acnur.App.Aplication;
    using Acnur.App.Entities;
    using Acnur.App.Proxy;
    using DevExpress.XtraEditors;
    using DevExpress.XtraEditors.Controls;
    using DevExpress.XtraGrid.Views.Grid;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Windows.Forms;

    /// <summary>
    /// Class ControlRequestEdit.
    /// </summary>
    public partial class ControlRequestEdit : DevExpress.XtraEditors.XtraUserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ControlRequestEdit" /> class.
        /// </summary>
        public ControlRequestEdit()
        {
            InitializeComponent();
            LoadRequest();
            LoadEvents();
            LoadGoods();
            LoadServices();
        }

        /// <summary>
        /// Gets or sets the identifier request.
        /// </summary>
        /// <value>The identifier request.</value>
        public int IdRequest { get; set; }

        /// <summary>
        /// Loads the data.
        /// </summary>
        private void LoadRequest()
        {
            List<Request> ListRequest = new List<Request>();
            using (CustomerRequest client = new CustomerRequest()) { ListRequest = client.GetAll(false, "ParameterDetail").ToList(); }
            DataTableReader ReadRequest = Utilities.ConvertirListaTabla(ListRequest.Where(item => item.Active).ToList()).CreateDataReader();
            this.dsRequest.Request.Clear();
            this.dsRequest.Request.Load(ReadRequest);
        }

        /// <summary>
        /// Loads the events.
        /// </summary>
        private void LoadEvents()
        {
            List<Events> ListEvents = new List<Events>();
            using (CustomerEvents client = new CustomerEvents()) { ListEvents = client.GetAll(false, "ParameterDetail").ToList(); }
            DataTableReader ReadEvents = Utilities.ConvertirListaTabla(ListEvents.Where(item => item.Active).ToList()).CreateDataReader();
            this.dsRequest.Events.Clear();
            this.dsRequest.Events.Load(ReadEvents);
        }

        /// <summary>
        /// Loads the goods.
        /// </summary>
        private void LoadGoods()
        {
            List<Goods> ListGoods = new List<Goods>();
            using (CustomerGoods client = new CustomerGoods()) { ListGoods = client.GetAll(false, "ParameterDetail").ToList(); }
            DataTableReader ReadGoods = Utilities.ConvertirListaTabla(ListGoods.Where(item => item.Active).ToList()).CreateDataReader();
            this.dsRequest.Goods.Clear();
            this.dsRequest.Goods.Load(ReadGoods);
        }

        /// <summary>
        /// Loads the services.
        /// </summary>
        private void LoadServices()
        {
            List<Services> ListServices = new List<Services>();
            using (CustomerServices client = new CustomerServices()) { ListServices = client.GetAll(false, "ParameterDetail").ToList(); }
            DataTableReader ReadServices = Utilities.ConvertirListaTabla(ListServices.Where(item => item.Active).ToList()).CreateDataReader();
            this.dsRequest.Services.Clear();
            this.dsRequest.Services.Load(ReadServices);
        }

        /// <summary>
        /// Edits the request.
        /// </summary>
        /// <param name="edit">if set to <c>true</c> [edit].</param>
        private void EditRequest(bool edit)
        {
            FormRequest frm = new FormRequest(0);
            this.IdRequest = edit ? int.Parse(this.GrvRequest.GetFocusedDataRow()[0].ToString()) : 0;
            frm.InitData(this.FindForm(), this.IdRequest, edit);
            frm.ShowDialog();
        }

        /// <summary>
        /// Edits the goods.
        /// </summary>
        /// <param name="edit">if set to <c>true</c> [edit].</param>
        /// <param name="rowIndex">Index of the row.</param>
        private void EditGoods(bool edit, int rowIndex)
        {
            FormGoods frm = new FormGoods();
            DataRow rowRequest = this.GrvRequest.GetFocusedDataRow();
            this.IdRequest = int.Parse(rowRequest[0].ToString());
            DataRow row = edit ? dsRequest.Goods.Where(item => item.IdRequest == IdRequest).ElementAt(rowIndex) : null;
            frm.InitData(this.FindForm(), row, edit, rowRequest[0].ToString());
            frm.ShowDialog();
        }

        /// <summary>
        /// Edits the events.
        /// </summary>
        /// <param name="edit">if set to <c>true</c> [edit].</param>
        /// <param name="rowIndex">Index of the row.</param>
        private void EditEvents(bool edit, int rowIndex)
        {
            FormEvents frm = new FormEvents();
            DataRow rowRequest = this.GrvRequest.GetFocusedDataRow();
            this.IdRequest = int.Parse(rowRequest[0].ToString());
            DataRow row = edit ? dsRequest.Events.Where(item => item.IdRequest == IdRequest).ElementAt(rowIndex) : null;
            frm.InitData(this.FindForm(), row, edit, rowRequest[0].ToString());
            frm.ShowDialog();
        }

        /// <summary>
        /// Edits the services.
        /// </summary>
        /// <param name="edit">if set to <c>true</c> [edit].</param>
        /// <param name="rowIndex">Index of the row.</param>
        private void EditServices(bool edit, int rowIndex)
        {
            FormServices frm = new FormServices();
            DataRow rowRequest = this.GrvRequest.GetFocusedDataRow();
            this.IdRequest = int.Parse(rowRequest[0].ToString());
            DataRow row = edit ? dsRequest.Services.Where(item => item.IdRequest == IdRequest).ElementAt(rowIndex) : null;
            frm.InitData(this.FindForm(), row, edit, rowRequest[0].ToString());
            frm.ShowDialog();
        }

        /// <summary>
        /// Handles the Click event of the GrControlRequest_EmbeddedNavigator control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="NavigatorButtonClickEventArgs" /> instance containing the event data.</param>
        private void GrControlRequest_EmbeddedNavigator_Click(object sender, NavigatorButtonClickEventArgs e)
        {
            if (e.Button.ButtonType == NavigatorButtonType.Edit || e.Button.ButtonType == NavigatorButtonType.Append || e.Button.ButtonType == NavigatorButtonType.Remove)
            {
                if (e.Button.ButtonType == NavigatorButtonType.Edit)
                {
                    this.EditRequest(true);

                }
                if (e.Button.ButtonType == NavigatorButtonType.Append)
                {
                    this.EditRequest(false);
                }
                if (e.Button.ButtonType == NavigatorButtonType.Remove)
                {
                    XtraMessageBox.AllowCustomLookAndFeel = true;
                    DialogResult dialogResult = XtraMessageBox.Show(" Really you want to delete the record ? ", "Confirmation", MessageBoxButtons.YesNo);

                    if (dialogResult == System.Windows.Forms.DialogResult.Yes)
                    {
                        DataRow row = this.GrvRequest.GetFocusedDataRow();
                        int IdRequest = int.Parse(row[1].ToString());

                        using (CustomerRequest client = new CustomerRequest())
                        {
                            client.Inactivate(IdRequest);
                        }
                    }
                }

                this.LoadRequest();
                this.LoadGoods();
                this.LoadServices();
                this.LoadEvents();

                e.Handled = true;
            }
        }

        /// <summary>
        /// Handles the MasterRowExpanded event of the GrViewRequest control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DevExpress.XtraGrid.Views.Grid.CustomMasterRowEventArgs" /> instance containing the event data.</param>
        private void GrViewRequest_MasterRowExpanded(object sender, DevExpress.XtraGrid.Views.Grid.CustomMasterRowEventArgs e)
        {
            //GridView view = sender as GridView;

            //if (view != null)
            //{
            //    GridView detailView = view.GetDetailView(e.RowHandle, e.RelationIndex) as GridView;
            //    if (detailView != null) detailView.ExpandGroupRow(-1);
            //}
        }

        /// <summary>
        /// Handles the RowClick event of the GrvGoods control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RowClickEventArgs" /> instance containing the event data.</param>
        private void GrvGoods_RowClick(object sender, RowClickEventArgs e)
        {
            this.EditGoods(true, e.RowHandle);
            this.LoadGoods();
        }

        /// <summary>
        /// Handles the RowClick event of the GrvServices control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RowClickEventArgs" /> instance containing the event data.</param>
        private void GrvServices_RowClick(object sender, RowClickEventArgs e)
        {
            this.EditServices(true, e.RowHandle);
            this.LoadServices();
        }

        /// <summary>
        /// Handles the RowClick event of the GrvEvents control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="RowClickEventArgs"/> instance containing the event data.</param>
        private void GrvEvents_RowClick(object sender, RowClickEventArgs e)
        {
            this.EditEvents(true, e.RowHandle);
            this.LoadEvents();
        }        
    }
}
