using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using SharpDX;
using SharpDX.DirectInput;

namespace RandomTools
{
	public partial class ReadButtons : Form
	{
		public ReadButtons()
		{
			InitializeComponent();
			DoSomething();
		}

		public void DoSomething() 
		{
			var x = new DirectInput();
			IList<DeviceInstance> z = x.GetDevices();
			foreach (DeviceInstance di in z) 
			{
				if (di.InstanceName.Contains("Arduino")) 
				{
					WriteToDebug(di.InstanceGuid + "|" + di.InstanceName + "|" + di.ProductName);
				}
			}

			
			int y = 1; if (y == 1) {  }; //this is just to provide a break point location.

			
		}

		

		public void WriteToDebug(string MessageText, bool ClearFirst = false) 
		{
			if (ClearFirst == true) { tbDebug.Clear(); }
			string dispText = DateTime.Now.ToString("HH:mm:ss") + " -\t" + MessageText + "\r\n";
			tbDebug.AppendText(dispText);
			tbDebug.ScrollToCaret();
			Application.DoEvents();	
		}


	}
}
