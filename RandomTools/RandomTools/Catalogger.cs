using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RandomTools
{
	public partial class Catalogger : Form
	{

		#region Class Variables
		public DataTable dtFileData;
		public DataTable dtErrorData;
		public int CatalogedFiles;
		public int ErroredFiles;
		public int ProcessedFiles;
		public int ProcessedDirectories;
		public int CataloggedDirectories;
		public int ErroredDirectories;
		public List<string> SubDirectoriesToCatalog;
		#endregion
		public Catalogger()
		{
			InitializeComponent();
			//tbDirectory.Text = "D:\\AP";
			tbDirectory.Text = "H:\\John\\Astronomy\\HH\\CAL TIF";
		}

		private void btnExecute_Click(object sender, EventArgs e)
		{
			InitializeClassVariables();
			string initialDir = tbDirectory.Text;
			if (!Directory.Exists(initialDir))
			{
				//handle error
				return;
			}
			if (tglIncludeSubdirectories.Checked == true)
			{
				GetSubDirectories(initialDir);
				foreach (string dir in SubDirectoriesToCatalog) { GetDirectoryContents(dir); }
			}
			else 
			{
				GetDirectoryContents(initialDir);
			}
		}

		public void InitializeClassVariables() 
		{
			dtFileData = CreateFileTable();
			dtErrorData = CreateErrorTable();
			CatalogedFiles = 0;
			ErroredFiles = 0;
			ProcessedFiles = 0;
			ProcessedDirectories = 0;
			CataloggedDirectories = 0;
			ErroredDirectories = 0;
			SubDirectoriesToCatalog = new List<string>();
		}


		public void GetDirectoryContents(string dirName) 
		{
			string[] files = Directory.GetFiles(dirName);
			foreach (string file in files) { ProcessFileToTable(file); }
		}


		



		public void GetSubDirectories(string dirName) 
		{
			string[] dirList = Directory.GetDirectories(dirName);
			foreach (string dir in dirList) { SubDirectoriesToCatalog.Add(dir); }
			foreach (string dir in SubDirectoriesToCatalog) { GetSubDirectories(dir); }

		}

		#region Initialize Tables
		public DataTable CreateErrorTable() 
		{
			DataTable dt = new DataTable();
			dt.TableName = "ERRORS";
			dt.Columns.Add("ErrorTime", typeof(DateTime));
			dt.Columns.Add("ErrorMessage", typeof(string));
			dt.Columns.Add("File", typeof(string));
			dt.Columns.Add("FullException", typeof(string));
			dt.Columns.Add("ProcessName", typeof(string));
			dt.Columns.Add("ErrorNotes", typeof(string));
			return dt;
		}
		public DataTable CreateFileTable() 
		{
			DataTable dt = new DataTable();
			dt.Columns.Add("FullPath", typeof(string));
			dt.Columns.Add("FileName", typeof(string));
			dt.Columns.Add("NameOnly", typeof(string));
			dt.Columns.Add("Extension", typeof(string));
			dt.Columns.Add("DirectoryPath", typeof(string));
			dt.Columns.Add("ContainingDirectoryName", typeof(string));
			dt.Columns.Add("FileSize", typeof(long));
			dt.Columns.Add("CreatedDate", typeof(DateTime));
			dt.Columns.Add("LastModified", typeof(DateTime));
			dt.Columns.Add("LastAccessed", typeof(DateTime));
			dt.Columns.Add("IsReadOnly", typeof(bool));
			dt.Columns.Add("CataologDate", typeof(DateTime));
			//dt.Columns.Add("x", typeof(string));
			return dt;
		}
		#endregion

		public void ProcessFileToTable(string filePath) 
		{
			ProcessedFiles++;
			try
			{
				DataRow dr = dtFileData.NewRow();
				FileInfo fi = new FileInfo(filePath);
				string containingDir = Path.GetFileName(Path.GetDirectoryName(filePath));
				dr["FullPath"] = filePath;
				dr["FileName"] = fi.Name;
				dr["NameOnly"] = Path.GetFileNameWithoutExtension(filePath);
				dr["Extension"] = fi.Extension;
				dr["DirectoryPath"] = fi.DirectoryName;
				dr["ContainingDirectoryName"] = Path.GetFileName(Path.GetDirectoryName(filePath));
				dr["FileSize"] = fi.Length;
				dr["CreatedDate"] = fi.CreationTimeUtc;
				dr["LastModified"] = fi.LastWriteTimeUtc;
				dr["LastAccessed"] = fi.LastAccessTimeUtc;
				dr["IsReadOnly"] = fi.IsReadOnly;
				dr["CatalogDate"] = DateTime.Now;
				dtFileData.Rows.Add(dr);
				CatalogedFiles++;
			}
			catch (Exception ex)
			{
				WriteToErrorTable(ex.Message, "ProcessFileToTable()", filePath, "File process failed.", ex);
				ErroredFiles++;
			}

		}

		public void WriteToErrorTable(string errorMessage, string processName = "", string fileName = "", string errorNotes = "", Exception ex = null) 
		{
			DataRow dr = dtErrorData.NewRow();
			dr["ErrorTime"] = DateTime.Now;
			dr["ErrorMessage"] = errorMessage;
			dr["File"] = fileName;
			dr["FullException"] = ex.ToString();
			dr["ProcessName"] = processName;
			dr["ErrorNotes"] = errorNotes;
		}
		

	}
}
