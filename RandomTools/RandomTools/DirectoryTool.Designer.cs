namespace RandomTools
{
	partial class DirectoryTool
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
			this.btnSelect = new System.Windows.Forms.Button();
			this.tbDirectory = new System.Windows.Forms.TextBox();
			this.tbDebug = new System.Windows.Forms.TextBox();
			this.btnGet = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.tglSubDir = new JCS.ToggleSwitch();
			this.label2 = new System.Windows.Forms.Label();
			this.dgvDisplay = new System.Windows.Forms.DataGridView();
			this.btnSave = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).BeginInit();
			this.SuspendLayout();
			// 
			// btnSelect
			// 
			this.btnSelect.Location = new System.Drawing.Point(748, 10);
			this.btnSelect.Name = "btnSelect";
			this.btnSelect.Size = new System.Drawing.Size(75, 23);
			this.btnSelect.TabIndex = 0;
			this.btnSelect.Text = "Select";
			this.btnSelect.UseVisualStyleBackColor = true;
			this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
			// 
			// tbDirectory
			// 
			this.tbDirectory.Location = new System.Drawing.Point(70, 12);
			this.tbDirectory.Name = "tbDirectory";
			this.tbDirectory.Size = new System.Drawing.Size(500, 20);
			this.tbDirectory.TabIndex = 1;
			// 
			// tbDebug
			// 
			this.tbDebug.Location = new System.Drawing.Point(15, 362);
			this.tbDebug.Multiline = true;
			this.tbDebug.Name = "tbDebug";
			this.tbDebug.ReadOnly = true;
			this.tbDebug.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.tbDebug.Size = new System.Drawing.Size(1115, 200);
			this.tbDebug.TabIndex = 1;
			// 
			// btnGet
			// 
			this.btnGet.Location = new System.Drawing.Point(829, 10);
			this.btnGet.Name = "btnGet";
			this.btnGet.Size = new System.Drawing.Size(75, 23);
			this.btnGet.TabIndex = 0;
			this.btnGet.Text = "Get Data";
			this.btnGet.UseVisualStyleBackColor = true;
			this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Directory:";
			// 
			// tglSubDir
			// 
			this.tglSubDir.Location = new System.Drawing.Point(702, 12);
			this.tglSubDir.Name = "tglSubDir";
			this.tglSubDir.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tglSubDir.OffText = "N";
			this.tglSubDir.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tglSubDir.OnText = "Y";
			this.tglSubDir.Size = new System.Drawing.Size(40, 20);
			this.tglSubDir.Style = JCS.ToggleSwitch.ToggleSwitchStyle.IOS5;
			this.tglSubDir.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(576, 15);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(120, 13);
			this.label2.TabIndex = 2;
			this.label2.Text = "Include Sub-Directories:";
			// 
			// dgvDisplay
			// 
			this.dgvDisplay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDisplay.Location = new System.Drawing.Point(15, 38);
			this.dgvDisplay.Name = "dgvDisplay";
			this.dgvDisplay.Size = new System.Drawing.Size(1115, 318);
			this.dgvDisplay.TabIndex = 4;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(910, 10);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 0;
			this.btnSave.Text = "Save To File";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// DirectoryTool
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1142, 574);
			this.Controls.Add(this.dgvDisplay);
			this.Controls.Add(this.tglSubDir);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbDebug);
			this.Controls.Add(this.tbDirectory);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.btnGet);
			this.Controls.Add(this.btnSelect);
			this.Name = "DirectoryTool";
			this.Text = "DirectoryTool";
			((System.ComponentModel.ISupportInitialize)(this.dgvDisplay)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnSelect;
		private System.Windows.Forms.TextBox tbDirectory;
		private System.Windows.Forms.TextBox tbDebug;
		private System.Windows.Forms.Button btnGet;
		private System.Windows.Forms.Label label1;
		private JCS.ToggleSwitch tglSubDir;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dgvDisplay;
		private System.Windows.Forms.Button btnSave;
	}
}