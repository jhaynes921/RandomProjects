using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.WindowsAPICodePack.Dialogs;
using System.IO;

namespace RandomTools
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnSelect_Click(object sender, EventArgs e)
		{
			btnListFiles.Enabled = false;
			tbDirectory.Enabled = true;
			CommonOpenFileDialog ofd = new CommonOpenFileDialog();
			ofd.IsFolderPicker = true;
			string dirName = tbDirectory.Text;
			if (!Directory.Exists(dirName) || tbDirectory.Text == "")
			{
				dirName = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
			}
			else
			{
				tbDirectory.Text = dirName;
			}
			ofd.InitialDirectory = dirName;
			CommonFileDialogResult result = ofd.ShowDialog();
			if (result != CommonFileDialogResult.Ok) { return; }
			dirName = ofd.FileName;
			if (!Directory.Exists(dirName)) { WriteToDebug("Selected directory \"" + dirName + "\" does not exist."); return; }
			tbDirectory.Text = dirName;
			tbDirectory.Enabled = false;
			btnListFiles.Enabled = true;
		}



		


		public void WriteToDebug(string MessageText, bool ClearFirst = false)
		{
			if (ClearFirst == true) { tbDebug.Clear(); }
			string dispText = DateTime.Now.ToString("HH:mm:ss") + " -\t" + MessageText + "\r\n";
			tbDebug.AppendText(dispText);
			tbDebug.ScrollToCaret();
			Application.DoEvents();
		}

		private void btnListFiles_Click(object sender, EventArgs e)
		{
			ListFiles();
		}

		private void ListFiles()
		{
			lstFrom.Items.Clear();
			lstTo.Items.Clear();
			string dirPath = tbDirectory.Text;
			string[] files = Directory.GetFiles(dirPath);
			foreach (string f in files)
			{
				string fileNameOnly = Path.GetFileName(f);
				lstFrom.Items.Add(fileNameOnly);
			}
		}



		private void btnMoveToSelected_Click(object sender, EventArgs e)
		{
			while (lstFrom.SelectedItems.Count > 0)
			{
				string item = (string)lstFrom.SelectedItems[0];
				lstTo.Items.Add(item);
				lstFrom.Items.Remove(item);
			}
		}

		private void btnMoveBack_Click(object sender, EventArgs e)
		{
			while (lstTo.SelectedItems.Count > 0)
			{
				string item = (string)lstTo.SelectedItems[0];
				lstFrom.Items.Add(item);
				lstTo.Items.Remove(item);
			}
		}

		private void btnAddAll_Click(object sender, EventArgs e)
		{
			lstTo.Items.AddRange(lstFrom.Items);
			lstFrom.Items.Clear();
		}

		private void btnRemoveAll_Click(object sender, EventArgs e)
		{
			lstFrom.Items.AddRange(lstTo.Items);
			lstTo.Items.Clear();
		}

		private void tbRename_Click(object sender, EventArgs e)
		{
			int i = 0;
			string baseName;
			if (tbRename.Text.Trim().Length > 0) { baseName = tbRenamePrefix.Text.Trim() + "_"; } else { baseName = ""; }
			string dirPath = tbDirectory.Text;
			foreach (string item in lstTo.Items)
			{
				i++;
				string fullPath = Path.Combine(dirPath, item);
				string ext = Path.GetExtension(item);
				string newName = baseName +i.ToString("0000") + ext;
				string newPath = Path.Combine(dirPath, newName);
				try
				{
					File.Move(fullPath, newPath);
				}
				catch (Exception ex)
				{
					WriteToDebug(ex.Message);
				}
			}

			lstFrom.Items.Clear();
			lstTo.Items.Clear();
			ListFiles();

		}
	}
}
