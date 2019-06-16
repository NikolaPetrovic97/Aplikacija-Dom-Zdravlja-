/*
 * Created by SharpDevelop.
 * User: Petrovici
 * Date: 20.12.2018
 * Time: 00:53
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Dom_Zdravlja
{
	partial class KontaktCentar
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label_Dom_Zdravlja;
		private System.Windows.Forms.Label lbl_Kontakt;
		private System.Windows.Forms.Button button_Back;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KontaktCentar));
			this.label_Dom_Zdravlja = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.lbl_Kontakt = new System.Windows.Forms.Label();
			this.button_Back = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// label_Dom_Zdravlja
			// 
			this.label_Dom_Zdravlja.Dock = System.Windows.Forms.DockStyle.Top;
			this.label_Dom_Zdravlja.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_Dom_Zdravlja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label_Dom_Zdravlja.Location = new System.Drawing.Point(0, 0);
			this.label_Dom_Zdravlja.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label_Dom_Zdravlja.Name = "label_Dom_Zdravlja";
			this.label_Dom_Zdravlja.Size = new System.Drawing.Size(1046, 65);
			this.label_Dom_Zdravlja.TabIndex = 27;
			this.label_Dom_Zdravlja.Text = "Kontakt:";
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(492, 29);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(530, 446);
			this.pictureBox1.TabIndex = 30;
			this.pictureBox1.TabStop = false;
			// 
			// lbl_Kontakt
			// 
			this.lbl_Kontakt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Kontakt.Location = new System.Drawing.Point(13, 69);
			this.lbl_Kontakt.Name = "lbl_Kontakt";
			this.lbl_Kontakt.Size = new System.Drawing.Size(473, 258);
			this.lbl_Kontakt.TabIndex = 32;
			this.lbl_Kontakt.Text = resources.GetString("lbl_Kontakt.Text");
			// 
			// button_Back
			// 
			this.button_Back.Image = ((System.Drawing.Image)(resources.GetObject("button_Back.Image")));
			this.button_Back.Location = new System.Drawing.Point(41, 413);
			this.button_Back.Name = "button_Back";
			this.button_Back.Size = new System.Drawing.Size(83, 82);
			this.button_Back.TabIndex = 33;
			this.button_Back.UseVisualStyleBackColor = true;
			this.button_Back.Click += new System.EventHandler(this.Back);
			// 
			// KontaktCentar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.RoyalBlue;
			this.ClientSize = new System.Drawing.Size(1046, 507);
			this.Controls.Add(this.button_Back);
			this.Controls.Add(this.lbl_Kontakt);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.label_Dom_Zdravlja);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "KontaktCentar";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Dom Zdravlja";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KontaktCentarFormClosing);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
