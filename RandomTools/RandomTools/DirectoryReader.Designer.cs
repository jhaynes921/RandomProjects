namespace RandomTools
{
	partial class DirectoryReader
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
			this.dgvDisp = new System.Windows.Forms.DataGridView();
			this.tbFileName = new System.Windows.Forms.TextBox();
			this.btnSelect = new System.Windows.Forms.Button();
			this.tbDebug = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.btnLoad = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvDisp)).BeginInit();
			this.SuspendLayout();
			// 
			// dgvDisp
			// 
			this.dgvDisp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDisp.Location = new System.Drawing.Point(12, 43);
			this.dgvDisp.Name = "dgvDisp";
			this.dgvDisp.Size = new System.Drawing.Size(1100, 500);
			this.dgvDisp.TabIndex = 0;
			// 
			// tbFileName
			// 
			this.tbFileName.Location = new System.Drawing.Point(41, 12);
			this.tbFileName.Name = "tbFileName";
			this.tbFileName.Size = new System.Drawing.Size(500, 20);
			this.tbFileName.TabIndex = 1;
			// 
			// btnSelect
			// 
			this.btnSelect.Location = new System.Drawing.Point(547, 10);
			this.btnSelect.Name = "btnSelect";
			this.btnSelect.Size = new System.Drawing.Size(75, 23);
			this.btnSelect.TabIndex = 2;
			this.btnSelect.Text = "Select";
			this.btnSelect.UseVisualStyleBackColor = true;
			this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
			// 
			// tbDebug
			// 
			this.tbDebug.Location = new System.Drawing.Point(12, 549);
			this.tbDebug.Multiline = true;
			this.tbDebug.Name = "tbDebug";
			this.tbDebug.ReadOnly = true;
			this.tbDebug.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.tbDebug.Size = new System.Drawing.Size(1100, 200);
			this.tbDebug.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(9, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(26, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "File:";
			// 
			// btnLoad
			// 
			this.btnLoad.Location = new System.Drawing.Point(628, 10);
			this.btnLoad.Name = "btnLoad";
			this.btnLoad.Size = new System.Drawing.Size(75, 23);
			this.btnLoad.TabIndex = 2;
			this.btnLoad.Text = "Load";
			this.btnLoad.UseVisualStyleBackColor = true;
			this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
			// 
			// DirectoryReader
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1124, 761);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnLoad);
			this.Controls.Add(this.btnSelect);
			this.Controls.Add(this.tbDebug);
			this.Controls.Add(this.tbFileName);
			this.Controls.Add(this.dgvDisp);
			this.Name = "DirectoryReader";
			this.Text = "DirectoryReader";
			this.Load += new System.EventHandler(this.DirectoryReader_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvDisp)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgvDisp;
		private System.Windows.Forms.TextBox tbFileName;
		private System.Windows.Forms.Button btnSelect;
		private System.Windows.Forms.TextBox tbDebug;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnLoad;
	}
}