// ***********************************************************************
// Assembly         : WinApp
// Author           : Christian ospina
// Created          : 03-18-2016
//
// Last Modified By : Christian ospina
// Last Modified On : 04-30-2016
// ***********************************************************************
// <copyright file="ControlFileUpLoad.cs" company="Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR">
//     Copyright © Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR 2015
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace WinApp
{
    using Acnur.App.Proxy;
    using DevExpress.XtraEditors;
    using DevExpress.XtraEditors.Controls;
    using DevExpress.XtraGrid;
    using DevExpress.XtraGrid.Views.Grid;
    using System;
    using System.Data;

    /// <summary>
    /// Class ControlFileUpLoad.
    /// </summary>
    /// <seealso cref="DevExpress.XtraEditors.XtraUserControl" />
    public partial class ControlFileUpLoad : DevExpress.XtraEditors.XtraUserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ControlFileUpLoad" /> class.
        /// </summary>
        public ControlFileUpLoad()
        {
            InitializeComponent();
            DataTable table = CreateTable();
            GrcFiles.DataSource = table;
            helper = new UploadHelper(table);
            helper.CurrentFileChanged += helper_CurrentFileChanged;
            RIButtonFiles.ButtonClick += RIButtonFiles_ButtonClick;
        }

        /// <summary>
        /// Gets or sets the identifier attachment file.
        /// </summary>
        /// <value>The identifier attachment file.</value>
        public int IdAttachmentFile { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="ControlFileUpLoad" /> is flat.
        /// </summary>
        /// <value><c>true</c> if flat; otherwise, <c>false</c>.</value>
        public bool Flat { get; set; }

        /// <summary>
        /// Sets the source files.
        /// </summary>
        /// <value>The source files.</value>
        public DataTable SourceFiles { set { helper.DataSource = value; } }

        /// <summary>
        /// The helper
        /// </summary>
        UploadHelper helper;
        /// <summary>
        /// Gets the grid files.
        /// </summary>
        /// <value>The grid files.</value>
        public GridControl GrcFilesFileUpload { get { return GrcFiles; } }

        /// <summary>
        /// Gets the GRV files file upload.
        /// </summary>
        /// <value>The GRV files file upload.</value>
        public GridView GrvFilesFileUpload { get { return GrvFiles; } }

        /// <summary>
        /// Gets the current file.
        /// </summary>
        /// <value>The current file.</value>
        public UploadedFile CurrentFile
        {
            get { return helper == null ? null : helper.CurrentFile; }
        }

        /// <summary>
        /// Handles the CurrentFileChanged event of the helper control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        void helper_CurrentFileChanged(object sender, EventArgs e)
        {
            UpdateHyperLink();
        }

        /// <summary>
        /// The table
        /// </summary>
        DataTable tbl;
        /// <summary>
        /// Creates the table.
        /// </summary>
        /// <returns>DataTable.</returns>
        public DataTable CreateTable()
        {
            tbl = new DataTable();
            tbl.Columns.Add("IdAttachment", typeof(int));
            tbl.Columns.Add("AttachmentName", typeof(string));
            tbl.Columns.Add("Description", typeof(string));
            tbl.Columns.Add("Attachment", typeof(object));

            return tbl;
        }

        /// <summary>
        /// Updates the hyper link.
        /// </summary>
        void UpdateHyperLink()
        {
            if (helper.CurrentFile == null)
            {
                HplFileTemp.Enabled = false;
                HplFileTemp.Text = "No file chosen";
            }
            else
            {
                HplFileTemp.Enabled = true;
                HplFileTemp.Text = String.Format("{0} ({1})", CurrentFile.FullPath, CurrentFile.FileSize);
            }
        }

        /// <summary>
        /// Gets the focused file.
        /// </summary>
        /// <returns>UploadedFile.</returns>
        UploadedFile GetFocusedFile()
        {
            DataRow dataRow = GrvFiles.GetFocusedDataRow();

            if (dataRow == null)
            {
                return null;
            }

            if (null != dataRow["IdAttachment"] && !string.IsNullOrEmpty(dataRow["IdAttachment"].ToString()) && Convert.ToInt32(dataRow["IdAttachment"]) > 0)
            {
                int Id = Convert.ToInt32(dataRow["IdAttachment"]);
                Acnur.App.Entities.Attachments Item;

                using (CustomerAttachments customer = new CustomerAttachments())
                {
                    Item = customer.GetByID(Id);
                }

                dataRow["Attachment"] = Item.Attachment;
                dataRow["AttachmentName"] = Item.AttachmentName;
                GrvFiles.UpdateCurrentRow();
            }

            return new UploadedFile((byte[])dataRow["Attachment"], (string)dataRow["AttachmentName"]);
        }

        /// <summary>
        /// Handles the ButtonClick event of the RIButtonFiles control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="DevExpress.XtraEditors.Controls.ButtonPressedEventArgs" /> instance containing the event data.</param>
        void RIButtonFiles_ButtonClick(object sender, ButtonPressedEventArgs e)
        {
            if (!Flat)
            {
                switch (e.Button.Index)
                {
                    case 0:
                        try
                        {
                            Flat = true;
                            UploadedFile file = GetFocusedFile();
                            if (file != null)
                                file.OpenFile();
                        }
                        catch (Exception ex)
                        {
                            XtraMessageBox.Show(ex.Message.Replace(@"C:\tmp\", string.Empty));
                        }
                        break;
                    case 1:
                        helper.PostNewFile(GrvFiles.GetFocusedDataSourceRowIndex());
                        GrvFiles.UpdateCurrentRow();
                        break;
                    case 2:
                        Flat = true;
                        DataRow dataRow = GrvFiles.GetFocusedDataRow();

                        if (null != dataRow)
                        {
                            int Id = (null != dataRow[0] && !string.IsNullOrEmpty(dataRow[0].ToString())) ? Convert.ToInt32(dataRow[0]) : 0;

                            if (Id > 0)
                            {
                                using (CustomerAttachments customer = new CustomerAttachments())
                                {
                                    customer.Delete(Id);
                                }
                            }

                            helper.DataSource.Rows.Remove(dataRow);
                            this.GrvFiles.UpdateCurrentRow();
                        }
                        break;
                }
            }
            else
                Flat = false;
        }

        /// <summary>
        /// Handles the Click event of the btOpenFile control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btOpenFile_Click(object sender, EventArgs e)
        {
            helper.ChooseFile();
        }

        /// <summary>
        /// Handles the Click event of the btUploadFile control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        private void btUploadFile_Click(object sender, EventArgs e)
        {
            if (null != CurrentFile)
            {
                CurrentFile.IdAttachmentFile = this.IdAttachmentFile;
                CurrentFile.Description = this.TxtDescription.Text;
            }

            helper.UploadFile();
            this.TxtDescription.Text = string.Empty;
            this.GrcFilesFileUpload.DataSource = helper.DataSource;
        }
    }
}
