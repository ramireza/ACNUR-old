// ***********************************************************************
// Assembly         : WinApp
// Author           : Mauricio Ospina - Cel: 3204958448 - ambrosio.mauro@gmail.com
// Created          : 02-18-2016
//
// Last Modified By : Mauricio Ospina
// Last Modified On : 02-25-2016
// ***********************************************************************
// <copyright file="FormGoods.cs" company="Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR">
//     Este producto fue desarrollado para Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR. Todos los derechos reservados.
// </copyright>
// <summary>Clase con los métodos de los bienes relacionados en la solicitud</summary>
// ***********************************************************************

/// <summary>
/// The WinApp namespace.
/// </summary>
namespace WinApp
{
    using Acnur.App.Aplication;
    using Acnur.App.Aplication.Enumerators;
    using Acnur.App.Entities;
    using Acnur.App.Proxy;
    using DevExpress.XtraEditors;
    using System;
    using System.Data;
    using System.Linq;
    using System.Web.UI.WebControls;
    using System.Windows.Forms;

    /// <summary>
    /// Class FormGoods.
    /// </summary>
    public partial class FormGoods : DevExpress.XtraEditors.XtraForm
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormGoods" /> class.
        /// </summary>
        public FormGoods()
        {
            InitializeComponent();
            this.LoadComboBox();
        }

        /// <summary>
        /// Gets or sets the identifier goods.
        /// </summary>
        /// <value>The identifier goods.</value>
        public string IdGoods
        {
            get
            {
                return String.IsNullOrEmpty(this.LblIdGoods.Text) ? "0" : this.LblIdGoods.Text;
            }

            set
            {
                this.LblIdGoods.Text = value;
            }
        }

        /// <summary>
        /// Gets or sets the identifier request.
        /// </summary>
        /// <value>The identifier request.</value>
        public string IdRequest
        {
            get
            {
                return String.IsNullOrEmpty(this.LblIdRequest.Text) ? "0" : this.LblIdRequest.Text;
            }

            set
            {
                this.LblIdRequest.Text = value;
            }
        }

        /// <summary>
        /// Initializes the location.
        /// </summary>
        /// <param name="frm">The FRM.</param>
        private void InitLocation(Form frm)
        {
            this.Top = frm.Top + (frm.Height - this.Height) / 2;
            this.Left = frm.Left + (frm.Width - this.Width) / 2;
        }

        /// <summary>
        /// Initializes the data.
        /// </summary>
        /// <param name="frm">The FRM.</param>
        /// <param name="row">The row.</param>
        /// <param name="edit">The edit.</param>
        /// <param name="idRequest">The identifier request.</param>
        public void InitData(Form frm, DataRow row, Boolean edit, string idRequest)
        {
            this.InitLocation(frm);
            this.IdRequest = idRequest;

            if (edit)
            {
                this.IdGoods = row[0].ToString();
                ((ListItem)(this.CmbUnitMeasure.EditValue)).Value = row[2].ToString();
                ((ListItem)(this.CmbUnitMeasure.EditValue)).Text = row[18].ToString();
                this.SpinQuantity.Text = row[3].ToString();
                this.TxtDescription.Text = row[4].ToString();
                this.TxtManufactureBrand.Text = row[5].ToString();
                this.TxtModel.Text = row[6].ToString();
                this.TxtReference.Text = row[7].ToString();
                this.TxtDimensions.Text = row[8].ToString();
                this.TxtColor.Text = row[9].ToString();
                this.TxtCapacity.Text = row[10].ToString();
                this.TxtPower.Text = row[11].ToString();
                this.TxtOther.Text = row[12].ToString();
                this.TxtPlaceDelivery.Text = row[13].ToString();
                this.TxtContactPersonGoods.Text = row[14].ToString();
                this.DteExpectedDeliveryGoods.Text = Convert.ToDateTime(row[15]).ToShortDateString();
                this.MemoObservationsGoods.Text = row[16].ToString();
            }

            this.ChkEdit.Checked = edit;
        }

        /// <summary>
        /// Handles the Click event of the BtnOk control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void BtnOk_Click(object sender, EventArgs e)
        {
            //// Valida 
            bool ret = this.ValidationProviderEditGoods.Validate();

            //// Guarda en base de datos el registro
            if (ret)
            {
                Goods item = new Goods();

                item.IdRequest = int.Parse(this.IdRequest);
                item.IdUnitMeasure = Convert.ToInt32(((ListItem)(this.CmbUnitMeasure.EditValue)).Value);
                item.Quantity = int.Parse(this.SpinQuantity.Text);
                item.Description = this.TxtDescription.Text;
                item.ManufacturerBrand = this.TxtManufactureBrand.Text;
                item.Model = this.TxtModel.Text;
                item.Reference = this.TxtReference.Text;
                item.Dimensions = this.TxtDimensions.Text;
                item.Color = this.TxtColor.Text;
                item.Capacity = this.TxtCapacity.Text;
                item.Power = this.TxtPower.Text;
                item.Other = this.TxtOther.Text;
                item.PlaceDelivery = this.TxtPlaceDelivery.Text;
                item.ContactPerson = this.TxtContactPersonGoods.Text;
                item.ExpectedDeliveryDate = this.DteExpectedDeliveryGoods.DateTime;
                item.Observations = this.MemoObservationsGoods.Text;
                item.Active = true;

                using (CustomerGoods client = new CustomerGoods())
                {
                    if (this.ChkEdit.Checked)
                    {
                        item.IdGoods = int.Parse(this.IdGoods);
                        client.Update(item);
                    }
                    else
                    {
                        client.Add(item);
                    }
                }
            }

            //// Cierra ventana y refresca los parámetros
            this.DialogResult = ret ? DialogResult.OK : DialogResult.None;
        }

        /// <summary>
        /// Loads the ComboBox.
        /// </summary>
        private void LoadComboBox()
        {
            using (CustomerParameterDetail client = new CustomerParameterDetail())
            {
                Utilities.SeleccionarValorXDefectoDDLId(this.CmbUnitMeasure, client.GetParameterDetailsByParameter(TypeParameter.Unit), 0, true, true);
            }
        }

        /// <summary>
        /// Handles the Click event of the BtnRemove control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        private void BtnRemove_Click(object sender, EventArgs e)
        {
            DialogResult = XtraMessageBox.Show(" Really you want to delete the record ? ", "Confirmation", MessageBoxButtons.YesNo);
            int Id = int.Parse(this.IdGoods);

            if (DialogResult == System.Windows.Forms.DialogResult.Yes)
            {
                using (CustomerGoods client = new CustomerGoods())
                {
                    client.Delete(Id);
                }

                DialogResult = System.Windows.Forms.DialogResult.OK;
            }
        }
    }
}