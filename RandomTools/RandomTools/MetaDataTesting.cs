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
using Microsoft.WindowsAPICodePack.Dialogs;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Media.Imaging;
using RandomTools.BackendCode;
using Microsoft.WindowsAPICodePack.Taskbar;
using System.Windows.Forms.VisualStyles;

namespace RandomTools
{
	public partial class MetaDataTesting : Form
	{
		public DataSet dsAllFiles;


		public MetaDataTesting()
		{
			InitializeComponent();
			btnExecute.Enabled = false;
			cboFileList.Visible = false;
		}
		private void btnSelect_Click(object sender, EventArgs e)
		{
			tbDataPath.Clear();
			btnExecute.Enabled = false;
			if (tglDirOrFile.Checked == false)
			{
				GetDirectoryPath();
			}
			else 
			{
				GetFilePath();
			}

		}
		public void GetFilePath() 
		{
			btnExecute.Enabled = false;
			tbDataPath.Clear();
			tbDataPath.Enabled = true;
			CommonOpenFileDialog ofd = new CommonOpenFileDialog();
			ofd.IsFolderPicker = false;
			ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			CommonFileDialogResult result = ofd.ShowDialog();
			if (result != CommonFileDialogResult.Ok)
			{
				return;
			}
			string dirPath = ofd.FileName;
			if (!File.Exists(dirPath))
			{
				WriteToDebug("Selected file is invalid.");
				return;
			}
			tbDataPath.Text = dirPath;
			tbDataPath.Enabled = false;
			btnExecute.Enabled = true;



		}
		public void GetDirectoryPath() 
		{
			btnExecute.Enabled = false;
			tbDataPath.Clear();
			tbDataPath.Enabled = true;
			CommonOpenFileDialog ofd = new CommonOpenFileDialog();
			ofd.IsFolderPicker = true;
			ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			CommonFileDialogResult result = ofd.ShowDialog();
			if (result != CommonFileDialogResult.Ok)
			{
				return;
			}
			string dirPath = ofd.FileName;
			if (!Directory.Exists(dirPath))
			{
				WriteToDebug("Selected directory is invalid.");
				return;
			}
			tbDataPath.Text = dirPath;
			tbDataPath.Enabled = false;
			btnExecute.Enabled = true;
		}
		public void WriteToDebug(string MessageText, bool ClearFirst = false) 
		{
			if(ClearFirst == true) { tbDebug.Clear(); }
			string dispText = DateTime.Now.ToString("HH:mm:ss") + " -\t" + MessageText + "\r\n";
			tbDebug.AppendText(dispText);
			tbDebug.ScrollToCaret();
			Application.DoEvents();
		}
		private void btnExecute_Click(object sender, EventArgs e)
		{
			if (tglDirOrFile.Checked == false)
			{
				MainProcessDirectory();
			}
			else 
			{

				MainProcessFile();
			}
		}
		private void tglDirOrFile_CheckedChanged(object sender, EventArgs e)
		{
			btnExecute.Enabled = false;
			tbDataPath.Clear();
			if (tglDirOrFile.Checked == false)
			{
				lbType.Text = "Directory:";
			}
			else 
			{
				lbType.Text = "File:";
			}
			Application.DoEvents();
		}
		private void MainProcessFile()
		{
			string filePath = tbDataPath.Text;
			FileMetadata thisFile = new FileMetadata(filePath);
			if (thisFile.ErrorState == true)
			{
				WriteToDebug(thisFile.ErrorMessage);
				return;
			}
			dgvDisplay.DataSource = thisFile.MetaDataTable;
			
		}

		private void MainProcessDirectory() 
		{
			cboFileList.Visible = false;
			string dirName = tbDataPath.Text;
			dsAllFiles = new DataSet();
			DataTable dtFileList = new DataTable();
			dtFileList.Columns.Add("TableIndex", typeof(int));
			dtFileList.Columns.Add("TableName", typeof(string));
			string[] files = Directory.GetFiles(dirName);
			int tableNbr = 0;
			foreach (string file in files) 
			{
				try
				{
					DataTable thisTable = ProcessFile(file);
					dtFileList.Rows.Add(tableNbr, thisTable.TableName);
					dsAllFiles.Tables.Add(thisTable);
				}
				catch (Exception)
				{

				}
			}
			cboFileList.DisplayMember = "TableName";
			cboFileList.ValueMember = "TableIndex";
			cboFileList.DataSource = dtFileList;
			cboFileList.Visible = true;
		}

		private DataTable ProcessFile(string thisFile) 
		{
			DataTable dt = new DataTable();
			FileMetadata thisFileData = new FileMetadata(thisFile);
			if (thisFileData.ErrorState == true)
			{
				dt.Columns.Add("FileName", typeof(string));
				dt.Columns.Add("ErrorMessage", typeof(string));
				dt.Rows.Add(thisFile, thisFileData.ErrorMessage);
			}
			else 
			{
				dt = thisFileData.MetaDataTable;
			}
			return dt;

		}

		private void cboFileList_SelectedIndexChanged(object sender, EventArgs e)
		{
			int tableID = cboFileList.SelectedIndex;
			dgvDisplay.DataSource = dsAllFiles.Tables[tableID];
			Application.DoEvents();
		}
	}
}
