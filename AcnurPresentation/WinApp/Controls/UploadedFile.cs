// ***********************************************************************
// Assembly         : WinApp
// Author           : Christian ospina
// Created          : 03-18-2016
//
// Last Modified By : Christian ospina
// Last Modified On : 03-18-2016
// ***********************************************************************
// <copyright file="UploadedFile.cs" company="Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR">
//     Copyright © Alto Comisionado de las Naciones Unidas para los Refugiados - ACNUR 2015
// </copyright>
// <summary></summary>
// ***********************************************************************


namespace WinApp
{
    using System.Diagnostics;
    using System.IO;

    /// <summary>
    /// Class UploadedFile.
    /// </summary>
    public class UploadedFile
    {
        /// <summary>
        /// The temporary directory
        /// </summary>
        public static string tempDirectory = "C:\\tmp\\";

        /// <summary>
        /// The _ file name
        /// </summary>
        private string _FileName;

        /// <summary>
        /// Gets the name of the file.
        /// </summary>
        /// <value>The name of the file.</value>
        public string FileName
        {
            get { return _FileName; }
        }

        /// <summary>
        /// The _ full path
        /// </summary>
        private string _FullPath;

        /// <summary>
        /// Gets or sets the full path.
        /// </summary>
        /// <value>The full path.</value>
        public string FullPath
        {
            get { return _FullPath; }
            set { _FullPath = value; }
        }

        /// <summary>
        /// Gets the size of the file.
        /// </summary>
        /// <value>The size of the file.</value>
        public long FileSize
        {
            get { return FileContent.Length; }
        }

        /// <summary>
        /// Gets or sets the identifier attachment file.
        /// </summary>
        /// <value>The identifier attachment file.</value>
        public int IdAttachmentFile { get; set; }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>The description.</value>
        public string Description { get; set; }

        /// <summary>
        /// The _ file
        /// </summary>
        private byte[] _File;

        /// <summary>
        /// Gets the content of the file.
        /// </summary>
        /// <value>The content of the file.</value>
        public byte[] FileContent
        {
            get { return _File; }
        }

        /// <summary>
        /// Reads the file.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        private void ReadFile(string filePath)
        {
            using (FileStream stream = new FileStream(filePath, FileMode.Open))
            {
                _File = new byte[stream.Length];
                stream.Read(FileContent, 0, (int)stream.Length);
                stream.Close();
            }
        }

        /// <summary>
        /// Reads the write stream.
        /// </summary>
        /// <param name="buffer">The buffer.</param>
        /// <param name="writeStream">The write stream.</param>
        private static void ReadWriteStream(byte[] buffer, Stream writeStream)
        {
            writeStream.Write(buffer, 0, buffer.Length);
            writeStream.Close();
        }

        /// <summary>
        /// Gets the content.
        /// </summary>
        /// <param name="fileContent">Content of the file.</param>
        /// <returns>System.Byte[].</returns>
        private byte[] GetContent(FileStream fileContent)
        {
            byte[] result = new byte[FileSize];
            fileContent.Read(result, 0, (int)FileSize);
            fileContent.Close();
            return result;
        }

        /// <summary>
        /// Writes the file.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        /// <param name="content">The content.</param>
        private static void WriteFile(string filePath, byte[] content)
        {
            using (FileStream writeStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                ReadWriteStream(content, writeStream);
                writeStream.Close();
            }
        }

        /// <summary>
        /// Opens the file.
        /// </summary>
        public void OpenFile()
        {
            Process.Start(FullPath);
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadedFile"/> class.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        public UploadedFile(string filePath)
        {
            ReadFile(filePath);
            _FileName = Path.GetFileName(filePath);
            _FullPath = filePath;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadedFile"/> class.
        /// </summary>
        /// <param name="content">The content.</param>
        /// <param name="fileName">Name of the file.</param>
        public UploadedFile(byte[] content, string fileName)
        {
            _FullPath = tempDirectory + fileName;
            WriteFile(FullPath, content);
            _FileName = fileName;
        }
    }
}
