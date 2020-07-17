namespace FIleStuff
{
	partial class Cataloger
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
			this.cboDrives = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// cboDrives
			// 
			this.cboDrives.FormattingEnabled = true;
			this.cboDrives.Location = new System.Drawing.Point(153, 95);
			this.cboDrives.Name = "cboDrives";
			this.cboDrives.Size = new System.Drawing.Size(121, 24);
			this.cboDrives.TabIndex = 0;
			// 
			// Cataloger
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.cboDrives);
			this.Name = "Cataloger";
			this.Text = "Cataloger";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ComboBox cboDrives;
	}
}