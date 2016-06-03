// ***********************************************************************
// Assembly         : WinApp
// Author           : Christian ospina
// Created          : 03-18-2016
//
// Last Modified By : Christian ospina
// Last Modified On : 03-21-2016
// ***********************************************************************
// <copyright file="UploadHelper.cs" company="Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR">
//     Copyright © Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR 2015
// </copyright>
// <summary></summary>
// ***********************************************************************

namespace WinApp
{
    using System;
    using System.Data;
    using System.Windows.Forms;

    /// <summary>
    /// Class UploadHelper.
    /// </summary>
    public class UploadHelper
    {
        public event EventHandler CurrentFileChanged;

        /// <summary>
        /// The _ data source
        /// </summary>
        private DataTable _DataSource;

        /// <summary>
        /// Gets or sets the data source.
        /// </summary>
        /// <value>The data source.</value>
        public DataTable DataSource
        {
            get { return _DataSource; }
            set { _DataSource = value; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadHelper" /> class.
        /// </summary>
        /// <param name="dataSource">The data source.</param>
        public UploadHelper(DataTable dataSource)
        {
            _DataSource = dataSource;
        }

        /// <summary>
        /// The _ current file
        /// </summary>
        private UploadedFile _CurrentFile;

        /// <summary>
        /// Gets or sets the current file.
        /// </summary>
        /// <value>The current file.</value>
        public UploadedFile CurrentFile
        {
            get { return _CurrentFile; }
            set { _CurrentFile = value; OnCurrentFileChanged(); }
        }

        /// <summary>
        /// Called when [current file changed].
        /// </summary>
        private void OnCurrentFileChanged()
        {
            if (CurrentFileChanged != null)
            {
                CurrentFileChanged(this, EventArgs.Empty);
            }
        }

        /// <summary>
        /// Uploads the file.
        /// </summary>
        public void UploadFile()
        {
            UploadFile(-1);
        }

        /// <summary>
        /// Uploads the file.
        /// </summary>
        /// <param name="dataSourceRowIndex">Index of the data source row.</param>
        public void UploadFile(int dataSourceRowIndex)
        {
            if (CurrentFile != null)
            {
                object[] values = new object[] { this.CurrentFile.IdAttachmentFile, this.CurrentFile.FileName, this.CurrentFile.Description, this.CurrentFile.FileContent };
                
                if (dataSourceRowIndex == -1)
                {
                    DataSource.Rows.Add(values);
                }
                else
                {
                    DataSource.Rows[dataSourceRowIndex].ItemArray = values;
                }
            }

            CurrentFile = null;
        }

        /// <summary>
        /// Chooses the file.
        /// </summary>
        public void ChooseFile()
        {
            if (CurrentFile != null)
            {
                MessageBox.Show(String.Format("Please upload the {0} file", CurrentFile.FileName));
                return;
            }

            OpenFileDialog fd = new OpenFileDialog();

            if (fd.ShowDialog() == DialogResult.OK)
            {
                CurrentFile = new UploadedFile(fd.FileName);
            }

        }

        /// <summary>
        /// Posts the new file.
        /// </summary>
        /// <param name="dataSourceRowIndex">Index of the data source row.</param>
        public void PostNewFile(int dataSourceRowIndex)
        {
            ChooseFile();
            UploadFile(dataSourceRowIndex);
        }
    }
}
