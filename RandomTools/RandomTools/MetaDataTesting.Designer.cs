namespace RandomTools
{
	partial class MetaDataTesting
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.btnExecute = new System.Windows.Forms.Button();
			this.tbDataPath = new System.Windows.Forms.TextBox();
			this.tbDebug = new System.Windows.Forms.TextBox();
			this.btnSelect = new System.Windows.Forms.Button();
			this.lbType = new System.Windows.Forms.Label();
			this.tglDirOrFile = new JCS.ToggleSwitch();
			this.label2 = new System.Windows.Forms.Label();
			this.dgvDisplay = new System.Windows.Forms.DataGridView();
			this.cboFileList = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).BeginInit();
			this.SuspendLayout();
			// 
			// btnExecute
			// 
			this.btnExecute.Location = new System.Drawing.Point(1001, 10);
			this.btnExecute.Name = "btnExecute";
			this.btnExecute.Size = new System.Drawing.Size(75, 23);
			this.btnExecute.TabIndex = 0;
			this.btnExecute.Text = "Execute";
			this.btnExecute.UseVisualStyleBackColor = true;
			this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
			// 
			// tbDataPath
			// 
			this.tbDataPath.Location = new System.Drawing.Point(67, 38);
			this.tbDataPath.Name = "tbDataPath";
			this.tbDataPath.Size = new System.Drawing.Size(500, 20);
			this.tbDataPath.TabIndex = 1;
			// 
			// tbDebug
			// 
			this.tbDebug.Location = new System.Drawing.Point(12, 482);
			this.tbDebug.Multiline = true;
			this.tbDebug.Name = "tbDebug";
			this.tbDebug.ReadOnly = true;
			this.tbDebug.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.tbDebug.Size = new System.Drawing.Size(1064, 200);
			this.tbDebug.TabIndex = 1;
			// 
			// btnSelect
			// 
			this.btnSelect.Location = new System.Drawing.Point(573, 36);
			this.btnSelect.Name = "btnSelect";
			this.btnSelect.Size = new System.Drawing.Size(75, 23);
			this.btnSelect.TabIndex = 0;
			this.btnSelect.Text = "Select";
			this.btnSelect.UseVisualStyleBackColor = true;
			this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
			// 
			// lbType
			// 
			this.lbType.AutoSize = true;
			this.lbType.Location = new System.Drawing.Point(9, 41);
			this.lbType.Name = "lbType";
			this.lbType.Size = new System.Drawing.Size(52, 13);
			this.lbType.TabIndex = 2;
			this.lbType.Text = "Directory:";
			// 
			// tglDirOrFile
			// 
			this.tglDirOrFile.Location = new System.Drawing.Point(12, 10);
			this.tglDirOrFile.Name = "tglDirOrFile";
			this.tglDirOrFile.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tglDirOrFile.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tglDirOrFile.Size = new System.Drawing.Size(40, 20);
			this.tglDirOrFile.Style = JCS.ToggleSwitch.ToggleSwitchStyle.IOS5;
			this.tglDirOrFile.TabIndex = 4;
			this.tglDirOrFile.CheckedChanged += new JCS.ToggleSwitch.CheckedChangedDelegate(this.tglDirOrFile_CheckedChanged);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(64, 15);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Directory or File";
			// 
			// dgvDisplay
			// 
			this.dgvDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDisplay.Location = new System.Drawing.Point(12, 64);
			this.dgvDisplay.Name = "dgvDisplay";
			this.dgvDisplay.Size = new System.Drawing.Size(1064, 412);
			this.dgvDisplay.TabIndex = 5;
			// 
			// cboFileList
			// 
			this.cboFileList.FormattingEnabled = true;
			this.cboFileList.Location = new System.Drawing.Point(662, 38);
			this.cboFileList.Name = "cboFileList";
			this.cboFileList.Size = new System.Drawing.Size(414, 21);
			this.cboFileList.TabIndex = 6;
			this.cboFileList.SelectedIndexChanged += new System.EventHandler(this.cboFileList_SelectedIndexChanged);
			// 
			// MetaDataTesting
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1088, 694);
			this.Controls.Add(this.cboFileList);
			this.Controls.Add(this.dgvDisplay);
			this.Controls.Add(this.tglDirOrFile);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.lbType);
			this.Controls.Add(this.tbDebug);
			this.Controls.Add(this.tbDataPath);
			this.Controls.Add(this.btnSelect);
			this.Controls.Add(this.btnExecute);
			this.Name = "MetaDataTesting";
			this.Text = "MetaDataTesting";
			((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnExecute;
		private System.Windows.Forms.TextBox tbDataPath;
		private System.Windows.Forms.TextBox tbDebug;
		private System.Windows.Forms.Button btnSelect;
		private System.Windows.Forms.Label lbType;
		private JCS.ToggleSwitch tglDirOrFile;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dgvDisplay;
		private System.Windows.Forms.ComboBox cboFileList;
	}
}