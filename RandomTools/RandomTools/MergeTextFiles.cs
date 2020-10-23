using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;


namespace RandomTools
{
	public partial class MergeTextFiles : Form
	{
		public MergeTextFiles()
		{
			InitializeComponent();
		}

		private void btnSelect_Click(object sender, EventArgs e)
		{
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
		}

		private void FillExtensionCbo() 
		{
			
		
		}



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

		private void btnGet_Click(object sender, EventArgs e)
		{
			//do main process
		}

		private void MainProcess() 
		{
			string dirName = tbDirectory.Text;
			if (!Directory.Exists(dirName)) { WriteToDebug("Directory does not exist, aborting."); return; }

			


		
		}




	}
}
