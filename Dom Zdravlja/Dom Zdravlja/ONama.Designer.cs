/*
 * Created by SharpDevelop.
 * User: Petrovici
 * Date: 20.12.2018
 * Time: 00:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Dom_Zdravlja
{
	partial class ONama
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ONama));
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Left;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(1063, 642);
			this.label1.TabIndex = 0;
			this.label1.Text = resources.GetString("label1.Text");
			// 
			// ONama
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.RoyalBlue;
			this.ClientSize = new System.Drawing.Size(1061, 642);
			this.Controls.Add(this.label1);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "ONama";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Dom Zdravlja";
			this.ResumeLayout(false);

		}
	}
}
