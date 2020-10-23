using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using System.Windows.Interop;
using Shell32;


namespace RandomTools.BackendCode
{
	public class FileMetadata
	{
		public string FileName { get; set; }
		public DataTable MetaDataTable { get; set; }
		public bool ErrorState { get; set; }
		public string ErrorMessage { get; set; }

		public FileMetadata(string filePath)
		{
			FileName = filePath;
			if (!File.Exists(FileName)) 
			{
				ErrorState = true;
				ErrorMessage = "File does not exist.";
				return;
			}
			CreateDataTable();
			ExtractInitialData();
			ExtractExtendedData();
			ErrorState = false;
			ErrorMessage = "No Errors";
		}

		private void CreateDataTable() 
		{
			DataTable dt = new DataTable();
			dt.Columns.Add("PropertyType", typeof(string));
			dt.Columns.Add("PropertyName", typeof(string));
			dt.Columns.Add("PropertyValue", typeof(string));
			string nameOnly = Path.GetFileNameWithoutExtension(FileName);
			dt.TableName = "MetaData_" + nameOnly;
			MetaDataTable = dt;
		}
		private void ExtractInitialData() 
		{
			FileInfo fi = new FileInfo(FileName);
			string fullName = fi.FullName;
			string name = fi.Name;
			string directoryName = fi.DirectoryName;
			bool isReadOnly = fi.IsReadOnly;
			string readOnly;
			if (isReadOnly == true) { readOnly = "True"; } else { readOnly = "False"; }

			string utcCreationTime = fi.CreationTimeUtc.ToString("yyyy-MM-dd HH:mm:ss");
			string extension = fi.Extension;
			string utcLastAccessed = fi.LastAccessTimeUtc.ToString("yyyy-MM-dd HH:mm:ss");
			string utcLastWrite = fi.LastWriteTimeUtc.ToString("yyyy-MM-dd HH:mm:ss");
			string FileLength = fi.Length.ToString("N0");

			MetaDataTable.Rows.Add("BasicData", "Full Name", fullName);
			MetaDataTable.Rows.Add("BasicData", "Name", name);
			MetaDataTable.Rows.Add("BasicData", "Directory Name", directoryName);
			MetaDataTable.Rows.Add("BasicData", "Is Read Only", readOnly);
			MetaDataTable.Rows.Add("BasicData", "UTC Creation Time", utcCreationTime);
			MetaDataTable.Rows.Add("BasicData", "UTC Last Access Time", utcLastAccessed);
			MetaDataTable.Rows.Add("BasicData", "UTC Last Write Time", utcLastWrite);
			MetaDataTable.Rows.Add("BasicData", "File Extension", extension);
			MetaDataTable.Rows.Add("BasicData", "File Length Bytes", FileLength);
			MetaDataTable.AcceptChanges();
		}

		private void ExtractExtendedData() 
		{

			//Dictionary<int, KeyValuePair<string, string>> metadataProperties = GetFileProperties();
			List<KeyValuePair<string, string>> propertyList = GetExtendedDataProperties();
			foreach (KeyValuePair<string, string> property in propertyList) 
			{
				MetaDataTable.Rows.Add("ExtendedData", property.Key, property.Value);
				MetaDataTable.AcceptChanges();
			}
		}

		public List<KeyValuePair<string, string>> GetExtendedDataProperties() 
		{
			List<KeyValuePair<string, string>> properties = new List<KeyValuePair<string, string>>();
			try
			{
				Shell Shell = new Shell();
				Folder Folder = Shell.NameSpace(Path.GetDirectoryName(FileName));
				FolderItem File = Folder.ParseName(Path.GetFileName(FileName));
				int Keys = Folder.GetDetailsOf(File, 0).Count();
				for(int i = 0; i<=Keys; i++)
				{
					string CurrentKey = Folder.GetDetailsOf(null/* TODO Change to default(_) if this is not a reference type */, i);
					string CurrentValue = Folder.GetDetailsOf(File, i);
					if (CurrentValue != "")
					{
						KeyValuePair<string, string> thisProperty;
						if (CurrentKey.Trim() == "" || CurrentKey == null)
						{
							string keyName = "UnnamedKey_" + i.ToString();
							thisProperty = new KeyValuePair<string, string>(keyName, CurrentValue);
							properties.Add(thisProperty);
						}
						else
						{
							thisProperty = new KeyValuePair<string, string>(CurrentKey, CurrentValue);
							properties.Add(thisProperty);
						}
					}
					else
					{
						KeyValuePair<string, string> thisProperty = new KeyValuePair<string, string>(CurrentKey, "<Empty>");
						properties.Add(thisProperty);
					}
				}
			}
			catch (Exception ex)
			{
				ErrorMessage = ex.ToString();
				ErrorState = true;
				return null;
			}

			return properties;
	
		}
		public Dictionary<int, KeyValuePair<string, string>> GetFileProperties()
		{
			Dictionary<int, KeyValuePair<string, string>> Properties = new Dictionary<int, KeyValuePair<string, string>>();
			try
			{
				Shell Shell = new Shell();
				Folder Folder = Shell.NameSpace(Path.GetDirectoryName(FileName));
				FolderItem File = Folder.ParseName(Path.GetFileName(FileName));
				int Index;
				int Keys = Folder.GetDetailsOf(File, 0).Count();
				for (Index = 0; Index <= Keys - 1; Index++)
				{
					string CurrentKey = Folder.GetDetailsOf(null/* TODO Change to default(_) if this is not a reference type */, Index);
					string CurrentValue = Folder.GetDetailsOf(File, Index);
					if (CurrentValue != "")
						Properties.Add(Index, new KeyValuePair<string, string>(CurrentKey, CurrentValue));
				}
			}
			catch (Exception ex)
			{
				ErrorMessage = ex.ToString();
				ErrorState = true;
				return null;
			}
			return Properties;
		}


	}
}
