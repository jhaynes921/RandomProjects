namespace FIleStuff
{
	partial class FileInfoDisplay
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
			this.tbDirectory = new System.Windows.Forms.TextBox();
			this.tbDebug = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.dgvDisplayData = new System.Windows.Forms.DataGridView();
			this.btnExecute = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgvDisplayData)).BeginInit();
			this.SuspendLayout();
			// 
			// tbDirectory
			// 
			this.tbDirectory.Location = new System.Drawing.Point(133, 15);
			this.tbDirectory.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tbDirectory.Name = "tbDirectory";
			this.tbDirectory.Size = new System.Drawing.Size(665, 22);
			this.tbDirectory.TabIndex = 0;
			this.tbDirectory.Text = "D:\\Dropbox\\_AAA\\AP\\xxxxxxx";
			// 
			// tbDebug
			// 
			this.tbDebug.Location = new System.Drawing.Point(20, 558);
			this.tbDebug.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.tbDebug.Multiline = true;
			this.tbDebug.Name = "tbDebug";
			this.tbDebug.ReadOnly = true;
			this.tbDebug.Size = new System.Drawing.Size(1315, 122);
			this.tbDebug.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(16, 18);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "DIrectory:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(84, 292);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(0, 17);
			this.label2.TabIndex = 2;
			// 
			// dgvDisplayData
			// 
			this.dgvDisplayData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvDisplayData.Location = new System.Drawing.Point(20, 47);
			this.dgvDisplayData.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.dgvDisplayData.Name = "dgvDisplayData";
			this.dgvDisplayData.Size = new System.Drawing.Size(1316, 503);
			this.dgvDisplayData.TabIndex = 3;
			this.dgvDisplayData.CellFormatting += dataGridView1_CellFormatting;
			// 
			// btnExecute
			// 
			this.btnExecute.Location = new System.Drawing.Point(1261, 12);
			this.btnExecute.Name = "btnExecute";
			this.btnExecute.Size = new System.Drawing.Size(75, 23);
			this.btnExecute.TabIndex = 4;
			this.btnExecute.Text = "Get Info";
			this.btnExecute.UseVisualStyleBackColor = true;
			this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
			// 
			// FileInfoDisplay
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1352, 695);
			this.Controls.Add(this.btnExecute);
			this.Controls.Add(this.dgvDisplayData);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbDebug);
			this.Controls.Add(this.tbDirectory);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "FileInfoDisplay";
			this.Text = "FileInfoDIsplay";
			this.Load += new System.EventHandler(this.FileInfoDisplay_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvDisplayData)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox tbDirectory;
		private System.Windows.Forms.TextBox tbDebug;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.DataGridView dgvDisplayData;
		private System.Windows.Forms.Button btnExecute;
	}
}

