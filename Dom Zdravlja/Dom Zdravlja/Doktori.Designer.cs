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
		private System.Windows.Forms.Label label_Pretraga;
		private System.Windows.Forms.TextBox txt_Pretraga;
		private System.Windows.Forms.Button button_Pretrazi;
		
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
			this.lbl_Doktori = new System.Windows.Forms.Label();
			this.dataSql = new System.Windows.Forms.DataGridView();
			this.label_Pretraga = new System.Windows.Forms.Label();
			this.txt_Pretraga = new System.Windows.Forms.TextBox();
			this.button_Pretrazi = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataSql)).BeginInit();
			this.SuspendLayout();
			// 
			// lbl_Doktori
			// 
			this.lbl_Doktori.Dock = System.Windows.Forms.DockStyle.Top;
			this.lbl_Doktori.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_Doktori.Location = new System.Drawing.Point(0, 0);
			this.lbl_Doktori.Name = "lbl_Doktori";
			this.lbl_Doktori.Size = new System.Drawing.Size(583, 38);
			this.lbl_Doktori.TabIndex = 7;
			this.lbl_Doktori.Text = "Naši doktori:";
			// 
			// dataSql
			// 
			this.dataSql.AllowUserToAddRows = false;
			this.dataSql.AllowUserToDeleteRows = false;
			this.dataSql.BackgroundColor = System.Drawing.SystemColors.Window;
			this.dataSql.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataSql.Location = new System.Drawing.Point(12, 103);
			this.dataSql.Name = "dataSql";
			this.dataSql.ReadOnly = true;
			this.dataSql.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
			this.dataSql.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dataSql.Size = new System.Drawing.Size(554, 525);
			this.dataSql.TabIndex = 6;
			// 
			// label_Pretraga
			// 
			this.label_Pretraga.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_Pretraga.Location = new System.Drawing.Point(12, 48);
			this.label_Pretraga.Name = "label_Pretraga";
			this.label_Pretraga.Size = new System.Drawing.Size(88, 31);
			this.label_Pretraga.TabIndex = 8;
			this.label_Pretraga.Text = "Pretraga:";
			// 
			// txt_Pretraga
			// 
			this.txt_Pretraga.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_Pretraga.Location = new System.Drawing.Point(106, 48);
			this.txt_Pretraga.Name = "txt_Pretraga";
			this.txt_Pretraga.Size = new System.Drawing.Size(312, 29);
			this.txt_Pretraga.TabIndex = 10;
			this.txt_Pretraga.TextChanged += new System.EventHandler(this.Txt_PretragaTextChanged);
			// 
			// button_Pretrazi
			// 
			this.button_Pretrazi.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_Pretrazi.Location = new System.Drawing.Point(442, 41);
			this.button_Pretrazi.Name = "button_Pretrazi";
			this.button_Pretrazi.Size = new System.Drawing.Size(104, 38);
			this.button_Pretrazi.TabIndex = 20;
			this.button_Pretrazi.Text = "Pretraži";
			this.button_Pretrazi.UseVisualStyleBackColor = true;
			this.button_Pretrazi.Click += new System.EventHandler(this.Button_PretraziClick);
			// 
			// Doktori
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.RoyalBlue;
			this.ClientSize = new System.Drawing.Size(583, 640);
			this.Controls.Add(this.button_Pretrazi);
			this.Controls.Add(this.txt_Pretraga);
			this.Controls.Add(this.label_Pretraga);
			this.Controls.Add(this.lbl_Doktori);
			this.Controls.Add(this.dataSql);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Doktori";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Dom Zdravlja";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DoktoriFormClosing);
			((System.ComponentModel.ISupportInitialize)(this.dataSql)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
