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

namespace FIleStuff
{
	public partial class FileInfoDisplay : Form
	{
		public FileInfoDisplay()
		{
			InitializeComponent();
		}

		private void FileInfoDisplay_Load(object sender, EventArgs e)
		{

		}

		void Main(string directoryName)
		{
			DataTable dtFileList = CreateFileTable();
			string[] files = Directory.GetFiles(directoryName);
			foreach (string file in files)
			{
				FileInfo fi = new FileInfo(file);

				string fileName = Path.GetFileName(file);
				string dirName = fi.DirectoryName;
				string fileExt = fi.Extension;
				string fullName = fi.FullName;
				DateTime creationTime = fi.CreationTimeUtc;
				DateTime lastAccessed = fi.LastAccessTimeUtc;
				DateTime lastWritten = fi.LastWriteTimeUtc;
				bool isReadOnly = fi.IsReadOnly;
				long fileSize = fi.Length;
				string name = fi.Name;

				dtFileList.Rows.Add(fileName, dirName, fileExt, fullName, creationTime, lastAccessed, lastWritten, isReadOnly, fileSize, name);

			}

			dgvDisplayData.DataSource = dtFileList;

		}

		public DataTable CreateFileTable()
		{
			DataTable dt = new DataTable();
			dt.Columns.Add("fileName", typeof(string));
			dt.Columns.Add("dirName", typeof(string));
			dt.Columns.Add("fileExt", typeof(string));
			dt.Columns.Add("fullName", typeof(string));
			dt.Columns.Add("creationTime", typeof(DateTime));
			dt.Columns.Add("lastAccessed", typeof(DateTime));
			dt.Columns.Add("lastWritten", typeof(DateTime));
			dt.Columns.Add("isReadOnly", typeof(bool));
			dt.Columns.Add("fileSize", typeof(long));
			dt.Columns.Add("name", typeof(string));


			return dt;
		}



		void WriteToDebug(string msgText, bool clearFirst = false)
		{
			if (clearFirst == true) { tbDebug.Clear(); }

			string timeStamp = DateTime.Now.ToString("HH:mm:ss");
			string dispText = timeStamp + " -\t" + msgText + Environment.NewLine;
			tbDebug.AppendText(dispText);
			tbDebug.ScrollToCaret();



		}



		private void btnExecute_Click(object sender, EventArgs e)
		{
			string dirName = tbDirectory.Text;
			if (!Directory.Exists(dirName)) { WriteToDebug("Specified directory does not exist. Aborting.");return; }
			Main(dirName);
		}


		void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (e.ColumnIndex == 7)
			{
				if (e.Value is bool)
				{
					bool value = (bool)e.Value;
					e.Value = (value) ? "Yes" : "No";
					e.FormattingApplied = true;
				}
			}
		}

		public string Format(string format, object arg, IFormatProvider formatProvider)
		{
			if (arg == null)
			{
				return string.Empty;
			}

			bool value = (bool)arg;
			switch (format ?? string.Empty)
			{
				case "YesNo":
					{
						return (value) ? "Yes" : "No";
					}
				case "OnOff":
					{
						return (value) ? "On" : "Off";
					}
				default:
					{
						return value.ToString();//true/false
					}
			}
		}
	}

}

