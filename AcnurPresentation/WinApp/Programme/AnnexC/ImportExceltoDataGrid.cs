using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections;
using System.Xml;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;


namespace WinApp
{
    /// <summary>
    /// ImportExceltoGrid
    /// Import all the data from an excel file to a datatable than can be used in a devexpress datagrid
    /// Created by:  Alvaro Ramirez
    /// </summary>
    public class ImportExceltoGrid
    {
        public static object OpenFile(string fileName)
        {
            var fullFileName = string.Format("{0}\\{1}", Directory.GetCurrentDirectory(), fileName);
            var connectionString = "";

                if (!File.Exists(fileName))
                {
                    System.Windows.Forms.MessageBox.Show("File not found");
                    return null;
                }
               
                if (fileName.Substring(fileName.LastIndexOf('.')).ToLower() == ".xlsx")
                    connectionString = string.Format("Provider=Microsoft.ACE.OLEDB.12.0; data source={0}; Extended Properties=Excel 12.0", fileName);
                else
                    connectionString = string.Format("Provider=Microsoft.Jet.OLEDB.4.0; data source={0}; Extended Properties=Excel 8.0;", fileName);
            try
            {      
                var adapter = new OleDbDataAdapter("select * from [FOCUS$]", connectionString);
                var ds = new DataSet();
                string tableName = "excelData";

                adapter.Fill(ds, tableName);

                DataTable data = ds.Tables[tableName];
                return data;
           
            } 
            catch (IOException  e)
            {
                MessageBox.Show("Excel File is Open. Close the file and try again! {0}" + e.Source);
                return new object();
            }
            catch (System.Data.OleDb.OleDbException e)
            {
                MessageBox.Show("Excel File is Open. Close the file and try again! {0}" + e.Source);
                return new object();
            }
               
        }
    }

    
}
        