/*
 * Created by SharpDevelop.
 * User: Petrovici
 * Date: 20.12.2018
 * Time: 00:52
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Dom_Zdravlja
{
	partial class Doktori
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DataGridView dataSql;
		private System.Windows.Forms.Label lbl_Doktori;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Doktori));
			this.dataSql = new System.Windows.Forms.DataGridView();
			this.lbl_Doktori = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataSql)).BeginInit();
			this.SuspendLayout();
			// 
			// dataSql
			// 
			this.dataSql.AllowUserToAddRows = false;
			this.dataSql.AllowUserToDeleteRows = false;
			this.dataSql.BackgroundColor = System.Drawing.SystemColors.Window;
			this.dataSql.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataSql.Location = new System.Drawing.Point(12, 45);
			this.dataSql.Name = "dataSql";
			this.dataSql.ReadOnly = true;
			this.dataSql.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dataSql.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dataSql.Size = new System.Drawing.Size(487, 606);
			this.dataSql.TabIndex = 6;
			// 
			// lbl_Doktori
			// 
			this.lbl_Doktori.Dock = System.Windows.Forms.DockStyle.Top;
			this.lbl_Doktori.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Doktori.Location = new System.Drawing.Point(0, 0);
			this.lbl_Doktori.Name = "lbl_Doktori";
			this.lbl_Doktori.Size = new System.Drawing.Size(511, 38);
			this.lbl_Doktori.TabIndex = 7;
			this.lbl_Doktori.Text = "Naši doktori:";
			// 
			// Doktori
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.RoyalBlue;
			this.ClientSize = new System.Drawing.Size(511, 672);
			this.Controls.Add(this.lbl_Doktori);
			this.Controls.Add(this.dataSql);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Doktori";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Dom Zdravlja";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DoktoriFormClosing);
			((System.ComponentModel.ISupportInitialize)(this.dataSql)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
