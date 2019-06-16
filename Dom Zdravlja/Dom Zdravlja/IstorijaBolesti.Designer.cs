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
	partial class IstorijaBolesti
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.DataGridView dataSql;
		private System.Windows.Forms.Label lbl_Istorija;
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IstorijaBolesti));
			this.dataSql = new System.Windows.Forms.DataGridView();
			this.lbl_Istorija = new System.Windows.Forms.Label();
			this.button_Back = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataSql)).BeginInit();
			this.SuspendLayout();
			// 
			// dataSql
			// 
			this.dataSql.AllowUserToAddRows = false;
			this.dataSql.AllowUserToDeleteRows = false;
			this.dataSql.BackgroundColor = System.Drawing.SystemColors.Window;
			this.dataSql.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataSql.Location = new System.Drawing.Point(19, 60);
			this.dataSql.Name = "dataSql";
			this.dataSql.ReadOnly = true;
			this.dataSql.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dataSql.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dataSql.Size = new System.Drawing.Size(507, 45);
			this.dataSql.TabIndex = 7;
			// 
			// lbl_Istorija
			// 
			this.lbl_Istorija.Dock = System.Windows.Forms.DockStyle.Top;
			this.lbl_Istorija.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Istorija.Location = new System.Drawing.Point(0, 0);
			this.lbl_Istorija.Name = "lbl_Istorija";
			this.lbl_Istorija.Size = new System.Drawing.Size(550, 40);
			this.lbl_Istorija.TabIndex = 8;
			this.lbl_Istorija.Text = "Istorija Bolesti";
			this.lbl_Istorija.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// button_Back
			// 
			this.button_Back.Image = ((System.Drawing.Image)(resources.GetObject("button_Back.Image")));
			this.button_Back.Location = new System.Drawing.Point(250, 173);
			this.button_Back.Name = "button_Back";
			this.button_Back.Size = new System.Drawing.Size(51, 43);
			this.button_Back.TabIndex = 17;
			this.button_Back.UseVisualStyleBackColor = true;
			this.button_Back.Click += new System.EventHandler(this.Back);
			// 
			// IstorijaBolesti
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.RoyalBlue;
			this.ClientSize = new System.Drawing.Size(550, 222);
			this.Controls.Add(this.button_Back);
			this.Controls.Add(this.lbl_Istorija);
			this.Controls.Add(this.dataSql);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "IstorijaBolesti";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Dom Zdravlja";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.IstorijaBolestiFormClosing);
			((System.ComponentModel.ISupportInitialize)(this.dataSql)).EndInit();
			this.ResumeLayout(false);

		}
	}
}
