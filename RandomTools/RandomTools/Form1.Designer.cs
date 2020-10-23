namespace RandomTools
{
	partial class Form1
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
			this.tbRename = new System.Windows.Forms.Button();
			this.tbDirectory = new System.Windows.Forms.TextBox();
			this.lstFrom = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.tbDebug = new System.Windows.Forms.TextBox();
			this.tbRenamePrefix = new System.Windows.Forms.TextBox();
			this.btnSelect = new System.Windows.Forms.Button();
			this.btnListFiles = new System.Windows.Forms.Button();
			this.btnMoveToSelected = new System.Windows.Forms.Button();
			this.lstTo = new System.Windows.Forms.ListBox();
			this.btnMoveBack = new System.Windows.Forms.Button();
			this.btnAddAll = new System.Windows.Forms.Button();
			this.btnRemoveAll = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// tbRename
			// 
			this.tbRename.Location = new System.Drawing.Point(373, 357);
			this.tbRename.Name = "tbRename";
			this.tbRename.Size = new System.Drawing.Size(75, 23);
			this.tbRename.TabIndex = 0;
			this.tbRename.Text = "Do Rename";
			this.tbRename.UseVisualStyleBackColor = true;
			this.tbRename.Click += new System.EventHandler(this.tbRename_Click);
			// 
			// tbDirectory
			// 
			this.tbDirectory.Location = new System.Drawing.Point(86, 12);
			this.tbDirectory.Name = "tbDirectory";
			this.tbDirectory.Size = new System.Drawing.Size(400, 20);
			this.tbDirectory.TabIndex = 1;
			// 
			// lstFrom
			// 
			this.lstFrom.FormattingEnabled = true;
			this.lstFrom.Location = new System.Drawing.Point(12, 38);
			this.lstFrom.Name = "lstFrom";
			this.lstFrom.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.lstFrom.Size = new System.Drawing.Size(274, 316);
			this.lstFrom.TabIndex = 2;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 363);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "File Directory:";
			// 
			// tbDebug
			// 
			this.tbDebug.Location = new System.Drawing.Point(12, 440);
			this.tbDebug.Multiline = true;
			this.tbDebug.Name = "tbDebug";
			this.tbDebug.ReadOnly = true;
			this.tbDebug.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.tbDebug.Size = new System.Drawing.Size(1044, 186);
			this.tbDebug.TabIndex = 1;
			// 
			// tbRenamePrefix
			// 
			this.tbRenamePrefix.Location = new System.Drawing.Point(89, 360);
			this.tbRenamePrefix.Name = "tbRenamePrefix";
			this.tbRenamePrefix.Size = new System.Drawing.Size(197, 20);
			this.tbRenamePrefix.TabIndex = 1;
			// 
			// btnSelect
			// 
			this.btnSelect.Location = new System.Drawing.Point(492, 10);
			this.btnSelect.Name = "btnSelect";
			this.btnSelect.Size = new System.Drawing.Size(75, 23);
			this.btnSelect.TabIndex = 0;
			this.btnSelect.Text = "Select";
			this.btnSelect.UseVisualStyleBackColor = true;
			this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
			// 
			// btnListFiles
			// 
			this.btnListFiles.Location = new System.Drawing.Point(573, 10);
			this.btnListFiles.Name = "btnListFiles";
			this.btnListFiles.Size = new System.Drawing.Size(75, 23);
			this.btnListFiles.TabIndex = 0;
			this.btnListFiles.Text = "List Files";
			this.btnListFiles.UseVisualStyleBackColor = true;
			this.btnListFiles.Click += new System.EventHandler(this.btnListFiles_Click);
			// 
			// btnMoveToSelected
			// 
			this.btnMoveToSelected.Location = new System.Drawing.Point(292, 38);
			this.btnMoveToSelected.Name = "btnMoveToSelected";
			this.btnMoveToSelected.Size = new System.Drawing.Size(75, 23);
			this.btnMoveToSelected.TabIndex = 0;
			this.btnMoveToSelected.Text = ">";
			this.btnMoveToSelected.UseVisualStyleBackColor = true;
			this.btnMoveToSelected.Click += new System.EventHandler(this.btnMoveToSelected_Click);
			// 
			// lstTo
			// 
			this.lstTo.FormattingEnabled = true;
			this.lstTo.Location = new System.Drawing.Point(373, 38);
			this.lstTo.Name = "lstTo";
			this.lstTo.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
			this.lstTo.Size = new System.Drawing.Size(294, 316);
			this.lstTo.TabIndex = 4;
			// 
			// btnMoveBack
			// 
			this.btnMoveBack.Location = new System.Drawing.Point(292, 96);
			this.btnMoveBack.Name = "btnMoveBack";
			this.btnMoveBack.Size = new System.Drawing.Size(75, 23);
			this.btnMoveBack.TabIndex = 0;
			this.btnMoveBack.Text = "<";
			this.btnMoveBack.UseVisualStyleBackColor = true;
			this.btnMoveBack.Click += new System.EventHandler(this.btnMoveBack_Click);
			// 
			// btnAddAll
			// 
			this.btnAddAll.Location = new System.Drawing.Point(292, 67);
			this.btnAddAll.Name = "btnAddAll";
			this.btnAddAll.Size = new System.Drawing.Size(75, 23);
			this.btnAddAll.TabIndex = 0;
			this.btnAddAll.Text = ">>";
			this.btnAddAll.UseVisualStyleBackColor = true;
			this.btnAddAll.Click += new System.EventHandler(this.btnAddAll_Click);
			// 
			// btnRemoveAll
			// 
			this.btnRemoveAll.Location = new System.Drawing.Point(292, 125);
			this.btnRemoveAll.Name = "btnRemoveAll";
			this.btnRemoveAll.Size = new System.Drawing.Size(75, 23);
			this.btnRemoveAll.TabIndex = 0;
			this.btnRemoveAll.Text = "<<";
			this.btnRemoveAll.UseVisualStyleBackColor = true;
			this.btnRemoveAll.Click += new System.EventHandler(this.btnRemoveAll_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1068, 638);
			this.Controls.Add(this.lstTo);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.lstFrom);
			this.Controls.Add(this.tbDebug);
			this.Controls.Add(this.tbRenamePrefix);
			this.Controls.Add(this.tbDirectory);
			this.Controls.Add(this.btnSelect);
			this.Controls.Add(this.btnListFiles);
			this.Controls.Add(this.btnMoveToSelected);
			this.Controls.Add(this.btnRemoveAll);
			this.Controls.Add(this.btnAddAll);
			this.Controls.Add(this.btnMoveBack);
			this.Controls.Add(this.tbRename);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button tbRename;
		private System.Windows.Forms.TextBox tbDirectory;
		private System.Windows.Forms.ListBox lstFrom;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbDebug;
		private System.Windows.Forms.TextBox tbRenamePrefix;
		private System.Windows.Forms.Button btnSelect;
		private System.Windows.Forms.Button btnListFiles;
		private System.Windows.Forms.Button btnMoveToSelected;
		private System.Windows.Forms.ListBox lstTo;
		private System.Windows.Forms.Button btnMoveBack;
		private System.Windows.Forms.Button btnAddAll;
		private System.Windows.Forms.Button btnRemoveAll;
	}
}

