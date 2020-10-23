namespace RandomTools
{
	partial class MergeTextFiles
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
			this.label1 = new System.Windows.Forms.Label();
			this.tbDebug = new System.Windows.Forms.TextBox();
			this.tbDirectory = new System.Windows.Forms.TextBox();
			this.btnGet = new System.Windows.Forms.Button();
			this.btnSelect = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(11, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 13);
			this.label1.TabIndex = 7;
			this.label1.Text = "Directory:";
			// 
			// tbDebug
			// 
			this.tbDebug.Location = new System.Drawing.Point(14, 362);
			this.tbDebug.Multiline = true;
			this.tbDebug.Name = "tbDebug";
			this.tbDebug.ReadOnly = true;
			this.tbDebug.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.tbDebug.Size = new System.Drawing.Size(1115, 200);
			this.tbDebug.TabIndex = 5;
			// 
			// tbDirectory
			// 
			this.tbDirectory.Location = new System.Drawing.Point(69, 12);
			this.tbDirectory.Name = "tbDirectory";
			this.tbDirectory.Size = new System.Drawing.Size(500, 20);
			this.tbDirectory.TabIndex = 6;
			// 
			// btnGet
			// 
			this.btnGet.Location = new System.Drawing.Point(851, 10);
			this.btnGet.Name = "btnGet";
			this.btnGet.Size = new System.Drawing.Size(75, 23);
			this.btnGet.TabIndex = 3;
			this.btnGet.Text = "Get Data";
			this.btnGet.UseVisualStyleBackColor = true;
			this.btnGet.Click += new System.EventHandler(this.btnGet_Click);
			// 
			// btnSelect
			// 
			this.btnSelect.Location = new System.Drawing.Point(575, 10);
			this.btnSelect.Name = "btnSelect";
			this.btnSelect.Size = new System.Drawing.Size(75, 23);
			this.btnSelect.TabIndex = 4;
			this.btnSelect.Text = "Select";
			this.btnSelect.UseVisualStyleBackColor = true;
			this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(656, 15);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(56, 13);
			this.label2.TabIndex = 7;
			this.label2.Text = "Extension:";
			// 
			// MergeTextFiles
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1142, 574);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbDebug);
			this.Controls.Add(this.tbDirectory);
			this.Controls.Add(this.btnGet);
			this.Controls.Add(this.btnSelect);
			this.Name = "MergeTextFiles";
			this.Text = "MergeTextFiles";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox tbDebug;
		private System.Windows.Forms.TextBox tbDirectory;
		private System.Windows.Forms.Button btnGet;
		private System.Windows.Forms.Button btnSelect;
		private System.Windows.Forms.Label label2;
	}
}