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
	public partial class Cataloger : Form
	{
		public Cataloger()
		{
			InitializeComponent();
			FillDriveCBO();
		}

		public void FillDriveCBO()
		{
			DataTable dt = new DataTable();
			dt.Columns.Add("DriveLetter", typeof(string));
			dt.Columns.Add("DriveDescription", typeof(string));

			DriveInfo[] drives = DriveInfo.GetDrives();
			foreach (DriveInfo drive in drives)
			{

				string driveLetter = drive.Name;
				string driveLabel = drive.VolumeLabel;
				bool isReady = drive.IsReady;
				var driveFormat = drive.DriveFormat;
				var p = drive.DriveType;
				var rootDir = drive.RootDirectory;
				string dispMember = driveLetter + " (" + driveLabel + ")";
				dt.Rows.Add(driveLetter, dispMember);

			}

			cboDrives.DisplayMember = "DriveDescription";
			cboDrives.ValueMember = "DriveLetter";
			cboDrives.DataSource = dt;
		}	 




	}
}
