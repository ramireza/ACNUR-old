// ***********************************************************************
// Assembly         : WinApp
// Author           : Alvaro Ramirez
// Created          : 30-05-2016
//
// Last Modified By :
// Last Modified On : 
// ***********************************************************************
// <copyright file="FormFocus" company="Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR">
//     Este producto fue desarrollado para Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR. Todos los derechos reservados.
// </copyright>
// <summary>Clase usada para la gestión del purchase</summary>
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
    using DevExpress.XtraBars.Navigation;
    using DevExpress.XtraEditors;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.IO;
    using System.Linq;
    using System.Web.UI.WebControls;

    using System.Windows.Forms;


    /// <summary>
    /// Class FormFocus.
    /// </summary>
    /// <seealso cref="DevExpress.XtraEditors.XtraForm" />

    public partial class FormFocus : DevExpress.XtraEditors.XtraForm
    {
        #region Constructs

        public FormFocus(int idFocus)
        {
            this.InitializeComponent();
            this.LoadComboBox();
            this.HandlerTabs(this.TabAnnexC);

            this.ControlFileSumission = new ControlFileUpLoad();
            this.PnlFileUpLoadSummisions.Controls.Add(this.ControlFileSumission);

            this.ControlFileFinancialReport = new ControlFileUpLoad();
            this.PnlFileUpLoadFinancialReport.Controls.Add(this.ControlFileFinancialReport);

            this.TxtAuthor.Text = Program.CurrentUserName;
            this.RIEditDelete.ButtonClick += RIEditDelete_ButtonClick;
            

            if (IdCycle > 0)
            {
                this.IdCycle = IdCycle;
                this.LoadCycle();
                this.ChkEdit.Checked = true;
            }

        }

        #endregion

        #region Properties

        /// <summary>
        /// Gets or sets the identifier Cycle.
        /// </summary>
        /// <value>The identifier Cycle.</value>
        public int IdCycle
        {
            get
            {
                return String.IsNullOrEmpty(this.LblIdCycle.Text) ? 0 : int.Parse(this.LblIdCycle.Text);
            }

            set
            {
                this.LblIdCycle.Text = value.ToString();
                if (value > 0) ;
                   // this.BtnRemoveAnnexC.Visible = true;
            }
        }

        /// <summary>
        /// Gets or sets the identifier Focus.
        /// </summary>
        /// <value>The identifier Focus.</value>
        public int IdFocus
        {
            get
            {
                return String.IsNullOrEmpty(this.LblIdFocus.Text) ? 0 : int.Parse(this.LblIdFocus.Text);
            }

            set
            {
                this.LblIdFocus.Text = value.ToString();
                if (value > 0) ;
                   // this.BtnRemoveAnnexC.Visible = true;
            }
        }

        /// <summary>
        /// Gets or sets the identifier lblIdSummision.
        /// </summary>
        /// <value>The identifier lblIdSummision.</value>
        public int IdSummision
        {
            get
            {
                return String.IsNullOrEmpty(this.lblIdSummision.Text) ? 0 : int.Parse(this.lblIdSummision.Text);
            }

            set
            {
                this.lblIdSummision.Text = value.ToString();
                if (value > 0)
                    this.BtnRemoveRequest.Visible = true;
            }
        }

        /// <summary>
        /// Gets or sets the identifier Cycle.
        /// </summary>
        /// <value>The identifier Cycle.</value>      
        public Cycle ObjCycle
        {
            get
            {
                Cycle item;

                if (this.IdCycle == 0)
                {
                    item = new Cycle();
                }
                else
                {
                    using (CustomerCycle client = new CustomerCycle())
                    {
                        item = client.GetByID(this.IdCycle);
                    }
                }
                
                item.Author = this.TxtAuthor.Text;
                item.IdOffice = this.CmbDutyStation.SelectedIndex == 0 ? (new CustomerParameterDetail()).GetParameterDetailsByParameter(TypeParameter.Default).First().IdParameterDetail : Convert.ToInt32(((ListItem)(this.CmbDutyStation.SelectedItem)).Value);
                item.IdUnit = this.CmbUnit.SelectedIndex == 0 ? (new CustomerParameterDetail()).GetParameterDetailsByParameter(TypeParameter.Default).First().IdParameterDetail : Convert.ToInt32(((ListItem)(this.CmbUnit.SelectedItem)).Value);
                item.Date = string.IsNullOrEmpty(this.DtpDate.Text) ? Utilities.CalculaFecha(this.DtpDate.Text) : this.DtpDate.DateTime;
                
                return item;

            }

            set
            {
                this.IdCycle = value.IdCycle;
                this.TxtAuthor.Text = value.Author;
                this.CmbDutyStation.SelectedItem = Utilities.GetItemComboBox(this.CmbDutyStation, value.IdOffice);
                this.CmbUnit.SelectedItem = Utilities.GetItemComboBox(this.CmbUnit, value.IdUnit);
                this.DtpDate.Text = value.Date == DateTime.MinValue ? string.Empty : value.Date.ToShortDateString();

            }
        }

        /// <summary>
        /// Gets or sets the object Focus.
        /// </summary>
        /// <value>The object Focus.</value>      
        public Focus ObjFocus
        {
            get
            {
                Focus item;

                if (this.IdFocus == 0)
                {
                    item = new Focus();
                }
                else
                {
                    using (CustomerFocus client = new CustomerFocus())
                    {
                        item = client.GetByID(this.IdFocus);
                    }
                }

                item.IdFocus = this.IdFocus;
                item.IdRightsGroup = this.CmbRigthsGroup.SelectedIndex == 0 ? (new CustomerParameterDetail()).GetParameterDetailsByParameter(TypeParameter.Default).First().IdParameterDetail : Convert.ToInt32(((ListItem)(this.CmbRigthsGroup.SelectedItem)).Value);
                item.IdObjective = this.CmbObjetive.SelectedIndex == 0 ? (new CustomerParameterDetail()).GetParameterDetailsByParameter(TypeParameter.Default).First().IdParameterDetail : Convert.ToInt32(((ListItem)(this.CmbObjetive.SelectedItem)).Value);
                item.IdOutputGroup = this.CmbOutputGroup.SelectedIndex == 0 ? (new CustomerParameterDetail()).GetParameterDetailsByParameter(TypeParameter.Default).First().IdParameterDetail : Convert.ToInt32(((ListItem)(this.CmbOutputGroup.SelectedItem)).Value);
                item.IdCostCenterDescription = this.CmbCostCenterDescription.SelectedIndex == 0 ? (new CustomerParameterDetail()).GetParameterDetailsByParameter(TypeParameter.Default).First().IdParameterDetail : Convert.ToInt32(((ListItem)(this.CmbCostCenterDescription.SelectedItem)).Value);
                item.Site = this.TxtSite.Text;
                item.ImplementerMSRP = this.TxtImplemeterMSRP.Text;
                item.Implementer = this.TxtImplementer.Text;
                item.Unit = this.TxtUnit.Text;
                item.USDTotal = this.TxtTotal.Text;
               

                return item;

            }

            set
            {
                this.IdFocus = value.IdFocus;
                this.CmbRigthsGroup.Text = value.IdRightsGroup.ToString();
                this.CmbObjetive.Text = value.IdObjective.ToString();
                this.CmbOutputGroup.Text = value.IdOutputGroup.ToString();
                this.CmbCostCenterDescription.Text = value.IdCostCenterDescription.ToString();
                this.TxtSite.Text = value.Site;
                this.TxtImplemeterMSRP.Text = value.ImplementerMSRP;
                this.TxtImplementer.Text = value.Implementer;
                this.TxtUnit.Text = value.Unit;
                this.TxtTotal.Text = value.USDTotal;
            }
        }

        /// <summary>
        /// Gets or sets the identifier lblIdSummision.
        /// </summary>
        /// <value>The identifier lblIdSummision.</value>
        /// 
        public Summision ObjSummision
        {
            get
            {
                Summision item;

                if (this.IdSummision == 0)
                {
                    item = new Summision();
                }
                else
                {
                    using (CustomerSummision client = new CustomerSummision())
                    {
                        item = client.GetByID(this.IdSummision);
                    }
                }

                item.IdFocus = this.IdFocus;
                item.ProjectTitle = this.TxtProjectTitle.Text;
                item.IdProjectlocationDepartament = this.CmbProjectDepartment.SelectedIndex == 0 ? (new CustomerParameterDetail()).GetParameterDetailsByParameter(TypeParameter.Default).First().IdParameterDetail : Convert.ToInt32(((ListItem)(this.CmbProjectDepartment.SelectedItem)).Value);
                item.IdProjectlocationMunicipality = this.CmbProjectMunicipality.SelectedIndex == 0 ? (new CustomerParameterDetail()).GetParameterDetailsByParameter(TypeParameter.Default).First().IdParameterDetail : Convert.ToInt32(((ListItem)(this.CmbProjectMunicipality.SelectedItem)).Value);
                item.IdProjectlocationSubMunicipality = this.CmbProjectSubMunicipality.SelectedIndex == 0 ? (new CustomerParameterDetail()).GetParameterDetailsByParameter(TypeParameter.Default).First().IdParameterDetail : Convert.ToInt32(((ListItem)(this.CmbProjectSubMunicipality.SelectedItem)).Value);
                item.IdImplementationMechanism = 1;
                item.IdStrategy = 1;
                item.Donor = this.TxtDonnor.Text;
                item.IdTypePopulation = this.CmbProjectDepartment.SelectedIndex == 0 ? (new CustomerParameterDetail()).GetParameterDetailsByParameter(TypeParameter.Default).First().IdParameterDetail : Convert.ToInt32(((ListItem)(this.CmbProjectDepartment.SelectedItem)).Value); ;
                item.WomenBetween0And4  = int.Parse(this.spinFemale_0_4.Text) ;
                item.WomenBetween5And11  = int.Parse(this.spinFemale_0_4.Text);
                item.WomenBetween12And17 = int.Parse(this.spinFemale_0_4.Text);
                item.WomenBetween18And59 = int.Parse(this.spinFemale_0_4.Text);
                item.WomenBetween60AndMore = int.Parse(this.spinFemale_0_4.Text);
                item.MenBetween0And4 = int.Parse(this.spinFemale_0_4.Text);
                item.MenBetween5And11 = int.Parse(this.spinFemale_0_4.Text);
                item.MenBetween12And17 = int.Parse(this.spinFemale_0_4.Text);
                item.MenBetween18And59 = int.Parse(this.spinFemale_0_4.Text);
                item.MenBetween60AndMore = int.Parse(this.spinFemale_0_4.Text);
                item.TotalFamilies = int.Parse(this.spinFemale_0_4.Text);
                item.TotalPeople = int.Parse(this.spinFemale_0_4.Text);
                item.PercentageOfIndigenous = int.Parse(this.spinFemale_0_4.Text);
                item.PercentageOfAfricanDescent = int.Parse(this.spinFemale_0_4.Text);
                item.PercentageOfOtherPeople = int.Parse(this.spinFemale_0_4.Text);
                item.OtherPeople = "";//int.Parse(this.spinFemale_0_4.Text);
                 item.IdTypeSummision = this.CmbProjectDepartment.SelectedIndex == 0 ? (new CustomerParameterDetail()).GetParameterDetailsByParameter(TypeParameter.Default).First().IdParameterDetail : Convert.ToInt32(((ListItem)(this.CmbProjectDepartment.SelectedItem)).Value); ;
                 item.IdCathegorySummision = this.CmbProjectDepartment.SelectedIndex == 0 ? (new CustomerParameterDetail()).GetParameterDetailsByParameter(TypeParameter.Default).First().IdParameterDetail : Convert.ToInt32(((ListItem)(this.CmbProjectDepartment.SelectedItem)).Value); ;
                 item.IdSubCathegorySummision = this.CmbProjectDepartment.SelectedIndex == 0 ? (new CustomerParameterDetail()).GetParameterDetailsByParameter(TypeParameter.Default).First().IdParameterDetail : Convert.ToInt32(((ListItem)(this.CmbProjectDepartment.SelectedItem)).Value); ;
                 item.NarrativeDescriptionOfTheDirectBeneficiaries = "";

                this.LoadFiles(ControlFileSumission, TypeComponent.Summision);


                return item;


            }

            set
            {

                this.IdSummision = value.IdSummision;

                //this.TxtRequesterPerson.Text = value.RequesterPerson;
                //this.TxtDutyStation.Text = value.DutyStation;
                //this.DtpRequestDate.Text = value.RequestDate == DateTime.MinValue ? string.Empty : value.RequestDate.ToShortDateString();
                //this.CmbRequesterUnit.SelectedItem = Utilities.GetItemComboBox(this.CmbRequesterUnit, value.IdRequestUnit);
                //this.TxtResponsible.Text = value.Responsible;
                //this.MemoBackground.Text = value.BackgroundRationale;
                //this.TxtDeliveryLocation.Text = value.DeliveryLocation;
                //this.DteEstimateDeliveryDateRequest.Text = value.EstimatedDeliveryDate == DateTime.MinValue ? string.Empty : value.EstimatedDeliveryDate.ToShortDateString();
            }
        }

        /// <summary>
        /// The control file sumission
        /// </summary>
        ControlFileUpLoad ControlFileSumission;

        /// <summary>
        /// The control file FinancialReports
        /// </summary>
        ControlFileUpLoad ControlFileFinancialReport;

        /// <summary>
        /// Gets or sets the identifier sumission.
        /// </summary>
        /// <value>The identifier sumission.</value>

        /// Gets or sets the data focus.
        /// </summary>
        /// <value>The data focus.</value>
        public string DataFocus
        {
            get { return this.LblIdCycle.Text; }
            set { this.LblIdCycle.Text = value; }
        }

        #endregion

        #region Init Focus

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
        /// <param name="idRequest">The identifier request.</param>
        /// <param name="edit">The edit.</param>
        public void InitData(Form frm, int idRequest, Boolean edit)
        {
            this.InitLocation(frm);

            if (edit)
            {
                this.LoadCycle();
            }

            this.ChkEdit.Checked = edit;
        }

        /// <summary>
        /// Carga todos los datos del Cycle.
        /// </summary>
        /// <param name="idRequest"></param>
        public void LoadCycle()
        {

            //// Consulta trayendo los focus filtrados por el id cycle
                List<Focus> ListFocus = new List<Focus>();

            //// Activa todos los eventos relacionados
            using (CustomerFocus client = new CustomerFocus())
            {
                ListFocus = client.Search(item => item.IdCycle == this.IdCycle, false, null).ToList();
            }

            List<ListFocus> ListaFocus = new List<ListFocus>();

            ListFocus.ForEach(delegate(Focus item)
            {
                ListaFocus.Add(this.LoadFocus(item));
            });

            this.BindGrid(ListaFocus);
        }

        /// <summary>
        /// Carga todos los datos del Cycle.
        /// </summary>
        /// <param name="idRequest"></param>
        public void LoadCyclebyID(int IdCycle)
        {   
            
            this.IdCycle = IdCycle;
            List<ListCycle> ListSource = new List<ListCycle>();

            if (this.IdCycle > 0)
            {
                
                using (CustomerCycle client = new CustomerCycle())
                {
                    this.ObjCycle = client.GetByID(this.IdCycle);
                }
                
                //// Consulta trayendo los focus filtrados por el id cycle

                List<Focus> ListFocus = new List<Focus>();

                //// Activa todos los eventos relacionados
                using (CustomerFocus client = new CustomerFocus())
                {
                    ListFocus = client.Search(item => item.IdCycle == IdCycle, false, null).ToList();
                }

                List<ListFocus> ListaFocus = new List<ListFocus>();

                ListFocus.ForEach(delegate(Focus item)
                {
                    ListaFocus.Add(this.LoadFocus(item));
                });

                this.BindGrid(ListaFocus);
             }
        }
        /// <summary>
        /// Loads the Focus.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns>ListRequest.</returns>
        private ListFocus LoadFocus(Focus item)
        {

            return new ListFocus()
            {
                Id = item.IdFocus,
                RightsGroup = item.IdRightsGroup.ToString(),
                OutputGroup = item.IdOutputGroup.ToString(),
                Objective = item.IdObjective.ToString(),
                Type = TypeComponent.Focus.ToString(),
                CostCenter = item.IdCostCenterMSRP.ToString(),
                Description = item.Description.ToString(),
                Site = item.Site.ToString(),
                Implementer = item.Implementer.ToString(),
                ImplementerMSRP = item.ImplementerMSRP.ToString(),
                Unit= item.Unit.ToString(),
                Total = item.Total.ToString(),
                 Active = item.Active.Value
            };
        }

        #endregion

        #region Utilitys

        /// <summary>
        /// Loads the ComboBox.
        /// </summary>
        private void LoadComboBox()
        {
            using (CustomerParameterDetail customer = new CustomerParameterDetail())
            {
                Utilities.SeleccionarValorXDefectoDDLId(this.CmbDutyStation, customer.GetParameterDetailsByParameter(TypeParameter.Office), 0, true, true);
                Utilities.SeleccionarValorXDefectoDDLId(this.CmbUnit, customer.GetParameterDetailsByParameter(TypeParameter.Unit), 0, true, true);
                Utilities.SeleccionarValorXDefectoDDLId(this.CmbProjectDepartment, customer.GetParameterDetailsByParameter(TypeParameter.Departamen), 0, true, true);
                Utilities.SeleccionarValorXDefectoDDLId(this.CmbProjectMunicipality, customer.GetParameterDetailsByParameter(TypeParameter.Municipality), 0, true, true);
                Utilities.SeleccionarValorXDefectoDDLId(this.CmbProjectSubMunicipality, customer.GetParameterDetailsByParameter(TypeParameter.SubMunicipality), 0, true, true);
                Utilities.SeleccionarValorXDefectoDDLId(this.CmbQuadeannialPlan, customer.GetParameterDetailsByParameter(TypeParameter.ReportForYearPlan), 0, true, true);
                Utilities.SeleccionarValorXDefectoDDLId(this.CmbUNDAF, customer.GetParameterDetailsByParameter(TypeParameter.ReportUNDAF), 0, true, true);
                Utilities.SeleccionarValorXDefectoDDLId(this.CmbPRR, customer.GetParameterDetailsByParameter(TypeParameter.ReportPRR), 0, true, true);
                Utilities.SeleccionarValorXDefectoDDLId(this.Cmb4W, customer.GetParameterDetailsByParameter(TypeParameter.Report4W), 0, true, true);
              }
            ///CARGA CMBCYCLE PARA PRUEBAS///
                //// Consulta trayendo los focus filtrados por el id cycle
                List<Cycle> ListCycle = new List<Cycle>();
                /// Activa todos los eventos relacionados
                using (CustomerCycle client = new CustomerCycle())
                {
                    ListCycle = client.Search(item => item.IdCycle !=0, false, null).ToList();
                }

                List<int> ListCycles = new List<int>();

                ListCycle.ForEach(delegate(Cycle item)
                {
                    ListCycles.Add(item.IdCycle);
                    CMBCYCLE.Properties.Items.Add(item.IdCycle);
            });
             
        }

        /// <summary>
        /// Ocultars the tabs.
        /// </summary>
        /// <param name="Tab">The tab.</param>
        private void HandlerTabs(TabNavigationPage Tab)
        {
            this.TabAnnexC.Hide();
            this.TabProjectInfo.Hide();
            this.TabAnnexCImporter.Hide();


            this.TabAnnexC.PageVisible = false;
            this.TabProjectInfo.PageVisible = false;
            this.TabAnnexCImporter.PageVisible = false;


            Tab.PageVisible = true;
            Tab.Show();
        }

        /// <summary>
        /// Refreshes the grid add.
        /// </summary>
        /// <param name="item">The item.</param>
        private void RefreshGridAdd(ListFocus item)
        {
            List<ListFocus> listExist = null != this.GrcFocus.DataSource ? (List<ListFocus>)this.GrcFocus.DataSource : new List<ListFocus>();

            if (listExist.Exists(e => e.Id == item.Id && e.Type == item.Type))
            {
                ListFocus remove = listExist.First(e => e.Id == item.Id && e.Type == item.Type);
                listExist.Remove(remove);
            }

            listExist.Add(item);
            this.BindGrid(listExist);
        }

        /// <summary>
        /// Refreshes the grid remove.
        /// </summary>
        /// <param name="item">The item.</param>
        private void RefreshGridRemove(ListFocus item)
        {
            List<ListFocus> listExist = null != this.GrcFocus.DataSource ? (List<ListFocus>)this.GrcFocus.DataSource : new List<ListFocus>();
            listExist.RemoveAll(e => e.Type == item.Type && e.Id == item.Id);
            this.BindGrid(listExist);
        }

        /// <summary>
        /// Binds the grid.
        /// </summary>
        /// <param name="listExist">The list exist.</param>
        private void BindGrid(List<ListFocus> listExist)
        {
            this.GrcFocus.DataSource = null;
            this.GrcFocus.Refresh();
            this.GrcFocus.DataSource = listExist;
            this.GrvFocus.UpdateCurrentRow();
        }

        /// <summary>
        /// Loads the body purchase.
        /// </summary>
        /// <returns>System.String.</returns>
        internal string LoadBodyFocus()
        {
            return this.DataFocus;
        }

        /// <summary>
        /// Saves the files.
        /// </summary>
        /// <param name="controlFile">The control file goods.</param>
        /// <param name="type">The type.</param>
        private void SaveFiles(ControlFileUpLoad controlFile, TypeComponent type)
        {
            DataTable dt = (DataTable)controlFile.GrcFilesFileUpload.DataSource;
            int IdTable = type == TypeComponent.Summision ? this.IdSummision : this.IdFocus;
            int IdDefecto = (new CustomerParameterDetail()).GetParameterDetailsByParameter(TypeParameter.Default).First().IdParameterDetail;
            int IdCompByModule = (new CustomerComponentsByModule()).GetIdComponentsByModuleByComponentNameAndModuleName(type.ToString(), TypeModule.Focus.ToString());

            using (CustomerAttachments customer = new CustomerAttachments())
            {
                foreach (DataRow item in dt.Rows)
                {
                    Attachments File = new Attachments();
                    File.IdInformation = IdTable;
                    File.AttachmentName = item[1].ToString();
                    File.Description = item[2].ToString();
                    File.IdAttachmentType = IdDefecto;
                    File.IdAttachmentCondition = IdDefecto;
                    File.IdComponentByModule = IdCompByModule;
                    File.Attachment = (byte[])item.ItemArray[3];

                    //// Si es un archivo nuevo, los adiciona
                    if (Convert.ToInt32(item[0]) == 0)
                    {
                        customer.Add(File);
                        item[0] = File.IdAttachment;
                        controlFile.GrvFilesFileUpload.UpdateCurrentRow();
                    }
                }
            }

            controlFile.GrcFilesFileUpload.DataSource = null;
        }

        /// <summary>
        /// Loads the files.
        /// </summary>
        /// <param name="controlFile">The control file.</param>
        /// <param name="type">The type.</param>
        private void LoadFiles(ControlFileUpLoad controlFile, TypeComponent type)
        {
            //// Limpia las fuentes de datos para colocar los archivos del componente
            controlFile.GrcFilesFileUpload.DataSource = controlFile.SourceFiles = this.ControlFileSumission.CreateTable();

            int IdTable = type == TypeComponent.Summision ? this.IdSummision : this.IdSummision;

            if (IdTable > 0)
            {
                int IdCompByModule = (new CustomerComponentsByModule()).GetIdComponentsByModuleByComponentNameAndModuleName(type.ToString(), TypeModule.Focus.ToString());
                List<Attachments> ListResult = new List<Attachments>();

                using (CustomerAttachments customer = new CustomerAttachments())
                {
                    ListResult = customer.GetAttachmentsByIdModule(IdCompByModule, IdTable);
                }

                if (ListResult.Count() > 0)
                {
                    controlFile.GrcFilesFileUpload.DataSource = controlFile.SourceFiles = this.LoadSourceFiles(ListResult, (DataTable)controlFile.GrcFilesFileUpload.DataSource);
                }
            }
        }

        /// <summary>
        /// Loads the source files.
        /// </summary>
        /// <param name="ListResult">The list result.</param>
        /// <param name="dataTable">The data table.</param>
        /// <returns>DataTable.</returns>
        private DataTable LoadSourceFiles(List<Attachments> ListResult, DataTable dataTable)
        {
            ListResult.ForEach(delegate(Attachments file)
            {
                object[] values = new object[] { file.IdAttachment, file.AttachmentName, file.Description, file.Attachment };
                dataTable.Rows.Add(values);
            });

            return dataTable;
        }

        #endregion

        #region Event Buttons

        /// <summary>
        /// Load Summision
        /// </summary>
        /// <param name="item"></param>
        /// <returns></returns>
        private ListFocus LoadSummision(Focus item)
        {
            return new ListFocus()
            {

                // Description = item.Pillar,
                // Id = item.IdFocus,
                // Type = TypeComponent.Summision.ToString(),
                //// Active = item.act
            };
        }

        /// <summary>
        /// BtnSelectFileFocus - Change from tabAnnexC to TabAnnexcImporter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSelectFileFocus_Click(object sender, EventArgs e)
        {
            this.HandlerTabs(this.TabAnnexCImporter);
        }

        /// <summary>
        /// BtnAnnexCImporterCancel_Click - Retur to the TabAnnexC.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnAnnexCImporterCancel_Click(object sender, EventArgs e)
        {
            GrcImportFocus.DataSource = null;
            this.txtFileNameImport.Text = "";
            LblContainedRecordsonFile.Text = "";
            this.HandlerTabs(this.TabAnnexC);
        }

        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnSelectFileAnnexc_Click(object sender, EventArgs e)
        {
            OpenFileDialog openfiledialog1 = new OpenFileDialog();

            if (openfiledialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                GrcImportFocus.DataSource = ImportExceltoGrid.OpenFile(openfiledialog1.FileName);
                this.txtFileNameImport.Text = openfiledialog1.FileName;
                LblContainedRecordsonFile.Text = this.GrvImportFocus.RowCount.ToString();

                if (this.GrvImportFocus.RowCount == 0)
                {
                    MessageBox.Show("No Records to be Imported");
                   
                }
                else
                {
                     this.BtnAnnexCImporter.Enabled = true;
                }
            }
        }

        /// <summary>
        /// Validates the Cycle.
        /// </summary>
        private void ValidateCycle()
        {
            if (this.IdCycle == 0)
            {
                using (CustomerCycle client = new CustomerCycle())
                {
                    this.IdCycle = client.Add(this.ObjCycle).IdCycle;
                    this.ChkEdit.Checked = true;
                }
            }
        }

        /// <summary>
        /// BtnImportAnnexc - Runs along the GrvImportFocus Gridview content and add each records to the FOCUS table.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnImportAnnexc_Click(object sender, EventArgs e)
        {
            int records = 0;
            this.HandlerTabs(this.TabAnnexC);

            using (CustomerCycle clientcycle = new CustomerCycle())
            {
                Cycle itemCycle = new Cycle();

                itemCycle.Author = this.TxtAuthor.Text;
                itemCycle.IdOffice = this.CmbDutyStation.SelectedIndex == 0 ? (new CustomerParameterDetail()).GetParameterDetailsByParameter(TypeParameter.Default).First().IdParameterDetail : Convert.ToInt32(((ListItem)(this.CmbDutyStation.SelectedItem)).Value);
                itemCycle.IdUnit = this.CmbUnit.SelectedIndex == 0 ? (new CustomerParameterDetail()).GetParameterDetailsByParameter(TypeParameter.Default).First().IdParameterDetail : Convert.ToInt32(((ListItem)(this.CmbUnit.SelectedItem)).Value);
                itemCycle.Date = string.IsNullOrEmpty(this.DtpDate.Text) ? Utilities.CalculaFecha(this.DtpDate.Text) : this.DtpDate.DateTime;

                // Guarda en tabla Cycle
                this.IdCycle = clientcycle.Add(itemCycle).IdCycle;

                this.LblIdCycle.Text = (itemCycle.IdCycle).ToString();

                using (CustomerFocus clientfocus = new CustomerFocus())

                    //recorre las filas en el DataGrid
                    for (int fila = 0; fila <= this.GrvImportFocus.RowCount - 1; ++fila)
                    {
                        Focus itemFocus = new Focus();
                        {
                            itemFocus.IdCycle = this.IdCycle;
                            itemFocus.IdPlanningYear = Convert.ToInt32(this.GrvImportFocus.GetRowCellValue(fila, "Planning Year"));
                            itemFocus.Operation = this.GrvImportFocus.GetRowCellValue(fila, "Operation").ToString();
                            itemFocus.Plan = this.GrvImportFocus.GetRowCellValue(fila, "Plan").ToString();
                            itemFocus.IdPopulationGroup = Convert.ToInt32(this.GrvImportFocus.GetRowCellValue(fila, "Population Group"));
                            itemFocus.IdGoal = Convert.ToInt32(this.GrvImportFocus.GetRowCellValue(fila, "Goal"));
                            itemFocus.IdRightsGroup = Convert.ToInt32(this.GrvImportFocus.GetRowCellValue(fila, "Population Group"));
                            itemFocus.IdObjective = Convert.ToInt32(this.GrvImportFocus.GetRowCellValue(fila, "Objective"));
                            itemFocus.IdType = Convert.ToInt32(this.GrvImportFocus.GetRowCellValue(fila, "Type"));
                            itemFocus.IdOutputGroup = Convert.ToInt32(this.GrvImportFocus.GetRowCellValue(fila, "OutputGroup"));
                            itemFocus.DonorRestr = this.GrvImportFocus.GetRowCellValue(fila, "Donor Restr").ToString();
                            itemFocus.IdCostCenterDescription = Convert.ToInt32(this.GrvImportFocus.GetRowCellValue(fila, "Cost Center Description"));
                            itemFocus.IdCostCenterMSRP = Convert.ToInt32(this.GrvImportFocus.GetRowCellValue(fila, "Cost Center MSRP"));
                            itemFocus.Implementer = this.GrvImportFocus.GetRowCellValue(fila, "Implementer").ToString();
                            itemFocus.ImplementerMSRP = this.GrvImportFocus.GetRowCellValue(fila, "Implementer MSRP").ToString();
                            itemFocus.Situation = this.GrvImportFocus.GetRowCellValue(fila, "Situation").ToString();
                            itemFocus.SituationMSRP = this.GrvImportFocus.GetRowCellValue(fila, "Situation MSRP").ToString(); ;
                            itemFocus.Pillar = this.GrvImportFocus.GetRowCellValue(fila, "Pillar").ToString();
                            itemFocus.SituationDescription = this.GrvImportFocus.GetRowCellValue(fila, "Situation Description").ToString();
                            itemFocus.Account = this.GrvImportFocus.GetRowCellValue(fila, "Account").ToString();
                            itemFocus.Site = this.GrvImportFocus.GetRowCellValue(fila, "Site").ToString();
                            itemFocus.Qty = this.GrvImportFocus.GetRowCellValue(fila, "Qty").ToString();
                            itemFocus.Unit = this.GrvImportFocus.GetRowCellValue(fila, "Unit").ToString();
                            itemFocus.Currency = this.GrvImportFocus.GetRowCellValue(fila, "Currency").ToString();
                            itemFocus.Unitcost = this.GrvImportFocus.GetRowCellValue(fila, "Unit cost").ToString();
                            itemFocus.Total = this.GrvImportFocus.GetRowCellValue(fila, "Total").ToString();
                            itemFocus.USDTotal = this.GrvImportFocus.GetRowCellValue(fila, "USD Total").ToString();
                            itemFocus.Description = this.GrvImportFocus.GetRowCellValue(fila, "Description").ToString();
                            //itemFocus.IdReportFourYearPlan = 1;
                            //itemFocus.IdReportUNDAF = 2;
                            //itemFocus.IdReportPRR = 3;
                            //itemFocus.IdReport4W = 4;
                            itemFocus.Active = false;
                            //itemFocus.IdReportTechnicalAssistance = 1;

                            //Guarda en tabala Focus
                            clientfocus.Add(itemFocus);
                        }

                        records = fila + 1;
                    }
            }

            // Despues de Importar
            MessageBox.Show((records) + " Records Imported");
            this.LblImportedFile.Text = this.txtFileNameImport.Text;
            this.BtnSelectFileFocus.Text = "Selected File";
            this.BtnSelectFileFocus.Enabled = false;
            this.ChkEdit.Checked = true;
            this.LoadCycle();       
     
        }

               /// <summary>
        /// BtnUpdateProject
        /// Update the project information
        /// </summary>
        private void BtnUpdateProject_Click(object sender, EventArgs e)
        {
            {

                //// Valida 
                bool ret = this.ValidationProviderEditFocus.Validate();

                if (ret)
                {
                    this.ValidateCycle();

                    using (CustomerFocus client = new CustomerFocus())
                    {
                        if (this.IdFocus == 0)
                        {
                            this.IdFocus = client.Add(this.ObjFocus).IdFocus;
                        }
                        else
                        {
                            client.Update(this.ObjFocus);
                        }
                    }
                    using (CustomerSummision client = new CustomerSummision())
                    {
                        if (this.IdSummision == 0)
                        {
                            this.IdSummision = client.Add(this.ObjSummision).IdFocus;
                        }
                        else
                        {
                            client.Update(this.ObjSummision);
                        }
                    }

                    this.RefreshGridAdd(this.LoadFocus(this.ObjFocus));
                    this.HandlerTabs(this.TabAnnexC);
                    this.SaveFiles(this.ControlFileFinancialReport, TypeComponent.Goods);
                }

                this.DialogResult = DialogResult.None;
            }
        } /// <summary>
        
        /// BtnCancelProject_Click - Retur to the TabAnnexC..
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BtnCancelProject_Click(object sender, EventArgs e)
        {
            this.HandlerTabs(this.TabAnnexC);
        }
        #endregion

        #region Event Delete and edit

        /// <summary>
        /// Handles the ButtonClick event of the RIEditDelete control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DevExpress.XtraEditors.Controls.ButtonPressedEventArgs" /> instance containing the event data.</param>
        private void RIEditDelete_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //// Obtiene los parámetros del Id y cual de los procesos quiere borrar
            int Id = (int)this.GrvFocus.GetListSourceRowCellValue(this.GrvFocus.GetFocusedDataSourceRowIndex(), this.ColId);
            string Process = this.GrvFocus.GetListSourceRowCellValue(this.GrvFocus.GetFocusedDataSourceRowIndex(), this.ColType).ToString();
            TypeComponent Type = (TypeComponent)Enum.Parse(typeof(TypeComponent), Process);

            //// Valida si esta editanto o eliminando
            if (e.Button.Index == 1)
            {
                DialogResult = XtraMessageBox.Show(" Really you want to delete the record ? ", "Confirmation", MessageBoxButtons.YesNo);
            }

            if (DialogResult == DialogResult.No)
            {
                DialogResult = DialogResult.None;
                return;
            }

            switch (Type)
            {
                case TypeComponent.Focus:
                    switch (e.Button.Index)
                    {
                        case 0:
                            using (CustomerFocus client = new CustomerFocus())
                            {
                                this.IdFocus = Id;
                                this.ObjFocus = client.GetByID(Id);
                                this.LblIdFocus.Text = this.IdFocus.ToString();
                            }

                            this.HandlerTabs(this.TabProjectInfo);
                            break;
                        case 1:
                            Focus focus;
                            using (CustomerFocus client = new CustomerFocus())
                            {
                                focus = client.GetByID(Id);
                                client.Delete(Id);
                            }
                            this.RemoveFiles(TypeComponent.Focus, this.IdFocus);
                            this.RefreshGridRemove(this.LoadFocus(focus));
                            break;
                    }
                  break;
            }

            DialogResult = DialogResult.None;
        }

        /// <summary>
        /// Removes the files.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <param name="idInformation">The identifier information.</param>
        private void RemoveFiles(TypeComponent type, int idInformation)
        {
            int IdCompByModule = (new CustomerComponentsByModule()).GetIdComponentsByModuleByComponentNameAndModuleName(type.ToString(), TypeModule.Purchase.ToString());

            using (CustomerAttachments customer = new CustomerAttachments())
            {
                customer.RemoveFilesCurrent(IdCompByModule, idInformation);
            }
        }



        #endregion

        private void BtnCancelAnnecC_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Handles the Click event of the BtnOKAnnexC_Click control.
        /// </summary>
        /// <param name="sender">BtnOKAnnexC_Click.</param>
        /// <param name="e"> <see cref="EventArgs" /> BtnOKAnnexC_Click.</param>
        private void BtnOKAnnexC_Click(object sender, EventArgs e)
        {  
            //// Valida 
            bool ret = this.ValidationProviderCycle.Validate();

            //// Guarda en base de datos el registro
            if (ret)
            {
                        Cycle Cyc = this.ObjCycle;
                        Cyc.Active = true;

                using (CustomerCycle client = new CustomerCycle())
                {
                    if (!this.ChkEdit.Checked)
                    {

                         MessageBox.Show("0 records to save");
                        //this.IdCycle = client.Add(Cyc).IdCycle;
                    }
                    else
                    {
                        client.Update(Cyc);
                    
                

                List<Focus> ListFocus = new List<Focus>();

                //// Activa todos los eventos relacionados
                using (CustomerFocus clientF = new CustomerFocus())
                {
                    ListFocus = clientF.Search(item => item.IdCycle == Cyc.IdCycle, false, null).ToList();
                    ListFocus.ForEach(item => clientF.Activate(item.IdFocus));
                }

                
                //// Guarda la información en la session y retorna el correo
                using (CustomerSession customer = new CustomerSession())
                {
                    this.DataFocus = customer.SaveSessionProgrameCycle(Program.CurrentMail, Program.CurrentGUID, this.IdCycle, ListFocus);
                }
                }
                }
            }

            this.DialogResult = ret ? DialogResult.OK : DialogResult.None;
        }

        
        
        
        
        /// <summary>
        /// TEST CMBCYCLE////
        /// </summary> DELETE AFTER TESTS
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CMBCYCLE_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.IdCycle = Convert.ToInt32(CMBCYCLE.SelectedItem);
            LoadCyclebyID(this.IdCycle);
                     
            
               
            this.ChkEdit.Checked = true;
        }
        }



       

 
    }
