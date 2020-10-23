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
using System.Windows.Shapes;
using System.Runtime.InteropServices;
using System.Threading;
using System.Security;
using System.CodeDom;

namespace RandomTools
{
	public partial class DirectoryReader : Form
	{
		#region Startup processes
		public DirectoryReader()
		{
			InitializeComponent();
			btnLoad.Visible = false;
		}
		private void DirectoryReader_Load(object sender, EventArgs e)
		{

		}
		#endregion

		#region Control Interactions
		private void btnSelect_Click(object sender, EventArgs e)
		{
			tbFileName.Enabled = true;
			btnLoad.Visible = false;
			OpenFileDialog ofd = new OpenFileDialog();
			ofd.Filter = "Text Files|*.txt|All Files|*.*";
			ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			DialogResult result = ofd.ShowDialog();
			if (result != DialogResult.OK) { return; }
			string selectedFile = ofd.FileName;
			if (!File.Exists(selectedFile))
			{
				WriteToDebug("File does not exist.");
				btnLoad.Visible = false;
				return;
			}
			tbFileName.Text = selectedFile;
			tbFileName.Enabled = false;
			btnLoad.Visible = true;
		}
		private void btnLoad_Click(object sender, EventArgs e)
		{
			string selectedFile = tbFileName.Text;
			if (FileExistence() == false) { return; }
			ProcessData(selectedFile);
		}
		#endregion

		#region Process File
		public void ProcessData(string selectedFile)
		{

			List<string> fileLines = LoadData(selectedFile);
			if (fileLines[0].Substring(0, 6) == "ERROR!") { WriteToDebug("No data was found."); return; }
			ProcessLines(fileLines);


		}
		public void ProcessLines(List<string> fileLines)
		{
			List<ParsedFileLine> ParsedLines = new List<ParsedFileLine>();
			int lineCount = 0;
			foreach (string line in fileLines) 
			{
				lineCount++;
				ParsedFileLine thisLine = new ParsedFileLine(line,lineCount);
				if (thisLine.ErrorState == false)
				{
					if (thisLine.LineType == LineContentType.DirectoryLine) { ParsedLines.Add(thisLine); }
					if (thisLine.LineType == LineContentType.FileDataLine) { ParsedLines.Add(thisLine); }
				}
			}
		}
		public List<string> LoadData(string fileName)
		{
			List<string> fileLines = new List<string>();
			int lineCount = 0;
			using (StreamReader sr = new StreamReader(fileName))
			{
				string thisLine;
				while ((thisLine = sr.ReadLine()) != null)
				{
					lineCount++;
					fileLines.Add(thisLine.Trim());
				}
			}

			if (fileLines.Count < 1)
			{
				string nodata = "ERROR!: No Data was found";
				fileLines.Add(nodata);
			}
			return fileLines;
		}
		#endregion

		#region Create Table
		public void ParseToTable(List<ParsedFileLine> ParsedLines) 
		{
		
		
		}

		public DataTable CreateOutputTable() 
		{
			DataTable dt = new DataTable();
			dt.Columns.Add("LineNumber", typeof(int));
			dt.Columns.Add("OrigLineNumber", typeof(int));
			dt.Columns.Add("Directory", typeof(string));
			dt.Columns.Add("FileName", typeof(string));
			dt.Columns.Add("Extension", typeof(string));
			dt.Columns.Add("FileDate", typeof(DateTime));
			dt.Columns.Add("FileSize", typeof(long));
			string inputFileName = tbFileName.Text;
			FileInfo fi = new FileInfo(inputFileName);
			string tblName = fi.Name;
			dt.TableName = tblName;
			return dt;
		}
		#endregion



		#region Other Stuff
		public void WriteToDebug(string MessageText, bool ClearFirst = false)
		{
			if (ClearFirst == true) { tbDebug.Clear(); }
			string dispText = DateTime.Now.ToString("HH:mm:ss") + " -\t" + MessageText + "\r\n\r\n";
			tbDebug.AppendText(dispText);
			tbDebug.ScrollToCaret();
			Application.DoEvents();
		}
		public bool FileExistence()
		{
			string selectedFile = tbFileName.Text;
			if (!File.Exists(selectedFile)) { WriteToDebug("File does not exist."); return false; }
			return true;
		}
		#endregion
	}

	public class ParsedFileLine
	{
		public int LineNumber { get; set; }
		public string FullLineText { get; set; }
		public string DirectoryPath { get; set; }
		public string FileName { get; set; }
		public string FileNameOnly { get; set; }
		public string FileExtension { get; set; }
		public long FileSize { get; set; }
		public DateTime FileDate { get; set; }
		public LineContentType LineType { get; set; }
		public bool ErrorState { get; set; }
		public string ErrorMessage { get; set; }
		public ParsedFileLine() { }
		public ParsedFileLine(string IncomingLine, int LineNbr) 
		{
			FullLineText = IncomingLine;
			ErrorState = false;
			ErrorMessage = "No Errors.";
			LineType = DetermineLineType(IncomingLine);
			if (LineType == LineContentType.DirectoryLine) { ParseDirectoryLine(IncomingLine); }
			if (LineType == LineContentType.FileDataLine) { ParseFileDataLine(IncomingLine); }
		
		}

		public LineContentType DetermineLineType(string lineText) 
		{
			LineContentType detectedType = LineContentType.Unclassified;
			if (FullLineText.Contains("Directory of "))
			{
				detectedType = LineContentType.DirectoryLine;
				return detectedType;
			}
			string datePart;
			try
			{
				if (lineText.Length < 10) { }
				datePart = lineText.Trim().Substring(0, 10);
				DateTime testDate;
				if (DateTime.TryParse(datePart, out testDate))
				{
					detectedType = LineContentType.FileDataLine;
					return detectedType;
				}
				else 
				{
					detectedType = LineContentType.OtherLine;
				}
			}
			catch (Exception)
			{
				detectedType = LineContentType.OtherLine;
			}
			
			return detectedType;
		}

		public void ParseDirectoryLine(string lineText) 
		{
			lineText = lineText.Replace("Directory of", "");
			lineText = lineText.Trim();
			DirectoryPath = lineText;
			
		}
		public void ParseFileDataLine(string lineText) 
		{
			try
			{

				lineText = lineText.Trim();
				string strFileDate = lineText.Substring(0, 10);
				string strFileTime = lineText.Substring(12, 8);

				DateTime _fileDate;
				if (!DateTime.TryParse(strFileDate + " " + strFileTime, out _fileDate)) { _fileDate = new DateTime(1900, 1, 1, 0, 0, 0); }
				FileDate = _fileDate;
				if (lineText.Substring(24, 5) == "<DIR>") 
				{
					LineType = LineContentType.FileListDirectoryLine;
					return;
				}
				string strFileLen = lineText.Substring(22, 16);
				strFileLen = strFileLen.Replace(",", "");
				strFileLen.Trim();
				long _fileSize;
				if (!long.TryParse(strFileLen, out _fileSize)) { _fileSize = -1; }
				FileSize = _fileSize;
				int lineLength = lineText.Length;
				string fullName = lineText.Substring(39, lineLength - 39);
				FileName = fullName;
				bool hasDot = false;
				if (fullName.Contains(".")) { hasDot = true; }
				else 
				{
					FileNameOnly = fullName;
					FileExtension = "n/a";
					return;
				}
				if (hasDot == true)
				{
					string[] parts = fullName.Split('.');
					int partLen = parts.Length - 1;
					string ext = parts[partLen];
					FileExtension = ext;
					StringBuilder sb = new StringBuilder();
					for (int i = 0; i < partLen; i++) 
					{
						sb.Append(parts[i]);
						if(i <partLen - 1) { sb.Append("."); }
					}
					FileNameOnly = sb.ToString();

				}

			}
			catch (Exception ex)
			{
				ErrorState = true;
				ErrorMessage = ex.ToString();
			}

		}



	}

	public enum LineContentType
	{
		FileDataLine,
		DirectoryLine,
		FileListDirectoryLine,
		OtherLine,
		Unclassified
	}

}


