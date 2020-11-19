namespace RandomTools
{
	partial class MemClear
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
			this.btnClear = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(12, 12);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(150, 23);
			this.btnClear.TabIndex = 0;
			this.btnClear.Text = "Clear Standby RAM";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// MemClear
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnClear);
			this.Name = "MemClear";
			this.Text = "MemClear";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnClear;
	}
}