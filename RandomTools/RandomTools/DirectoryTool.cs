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
using System.Threading;

namespace RandomTools
{
	public partial class DirectoryTool : Form
	{
		public DirectoryTool()
		{
			InitializeComponent();
		}

		#region Control Interactions

		private void btnSelect_Click(object sender, EventArgs e)
		{
			SelectDirectory();
		}

		private void btnGet_Click(object sender, EventArgs e)
		{
			GetData();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{

		}

		#endregion

		#region Control Responses
		private void SelectDirectory() 
		{
			tbDirectory.Enabled = true;
			btnGet.Enabled = false;
			btnSave.Enabled = false;
			CommonOpenFileDialog ofd = new CommonOpenFileDialog();
			ofd.IsFolderPicker = true;
			ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			CommonFileDialogResult result = ofd.ShowDialog();
			if (result != CommonFileDialogResult.Ok) { return; }
			string dirName = ofd.FileName;
			if (!Directory.Exists(dirName)) 
			{
				WriteToDebug("Directory doesn't exist, aborting.");
				return;
			}
			tbDirectory.Text = dirName;
			tbDirectory.Enabled = false;
			btnGet.Enabled = true;
		}

		private void GetData() 
		{
			string dirName = tbDirectory.Text;
			if (!Directory.Exists(dirName)) 
			{
				WriteToDebug("Specified directory is invalid.  Aborting.");
				tbDirectory.Enabled = true;
				tbDirectory.Clear();
				btnGet.Enabled = false;
				btnSave.Enabled = false;
				return;
			}

			bool getSubDirs = tglSubDir.Checked;

		}
		#endregion

		#region Primary Methods
		private void ProcessDirectory(string dirName) 
		{ 
			
		}

		#endregion


		#region Common Methods

		public void WriteToDebug(string MessageText, bool ClearFirst = false)
		{
			if (ClearFirst == true) { tbDebug.Clear(); }
			string dispText = DateTime.Now.ToString("HH:mm:ss") + " -\t" + MessageText + "\r\n";
			tbDebug.AppendText(dispText);
			tbDebug.ScrollToCaret();
			Application.DoEvents();
		}

		#endregion


	}

	public class FileEntry 
	{
		public string FileName { get; set; }
	}

}
