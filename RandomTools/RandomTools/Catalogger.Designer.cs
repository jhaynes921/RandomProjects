namespace RandomTools
{
	partial class Catalogger
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
			this.tbDirectory = new System.Windows.Forms.TextBox();
			this.tglIncludeSubdirectories = new JCS.ToggleSwitch();
			this.SuspendLayout();
			// 
			// btnExecute
			// 
			this.btnExecute.Location = new System.Drawing.Point(632, 42);
			this.btnExecute.Name = "btnExecute";
			this.btnExecute.Size = new System.Drawing.Size(75, 23);
			this.btnExecute.TabIndex = 0;
			this.btnExecute.Text = "Execute";
			this.btnExecute.UseVisualStyleBackColor = true;
			this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
			// 
			// tbDirectory
			// 
			this.tbDirectory.Location = new System.Drawing.Point(252, 95);
			this.tbDirectory.Name = "tbDirectory";
			this.tbDirectory.Size = new System.Drawing.Size(100, 22);
			this.tbDirectory.TabIndex = 1;
			// 
			// tglIncludeSubdirectories
			// 
			this.tglIncludeSubdirectories.Location = new System.Drawing.Point(525, 45);
			this.tglIncludeSubdirectories.Name = "tglIncludeSubdirectories";
			this.tglIncludeSubdirectories.OffFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tglIncludeSubdirectories.OffText = "N";
			this.tglIncludeSubdirectories.OnFont = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tglIncludeSubdirectories.OnText = "Y";
			this.tglIncludeSubdirectories.Size = new System.Drawing.Size(40, 20);
			this.tglIncludeSubdirectories.Style = JCS.ToggleSwitch.ToggleSwitchStyle.IOS5;
			this.tglIncludeSubdirectories.TabIndex = 2;
			// 
			// Catalogger
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tglIncludeSubdirectories);
			this.Controls.Add(this.tbDirectory);
			this.Controls.Add(this.btnExecute);
			this.Name = "Catalogger";
			this.Text = "Catalogger";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnExecute;
		private System.Windows.Forms.TextBox tbDirectory;
		private JCS.ToggleSwitch tglIncludeSubdirectories;
	}
}