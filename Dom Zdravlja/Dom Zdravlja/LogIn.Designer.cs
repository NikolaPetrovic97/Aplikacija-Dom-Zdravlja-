/*
 * Created by SharpDevelop.
 * User: Petrovici
 * Date: 08.12.2018
 * Time: 23:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Dom_Zdravlja
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button button_Simptomi;
		private System.Windows.Forms.Button button_IstorijaBolesti;
		private System.Windows.Forms.Button buttonDoktori;
		private System.Windows.Forms.Button button_KontaktCentar;
		private System.Windows.Forms.Button button_ONama;
		private System.Windows.Forms.Button button_InfoCentar;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button_Odjava;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.label3 = new System.Windows.Forms.Label();
			this.button_Simptomi = new System.Windows.Forms.Button();
			this.button_IstorijaBolesti = new System.Windows.Forms.Button();
			this.buttonDoktori = new System.Windows.Forms.Button();
			this.button_KontaktCentar = new System.Windows.Forms.Button();
			this.button_ONama = new System.Windows.Forms.Button();
			this.button_InfoCentar = new System.Windows.Forms.Button();
			this.button_Odjava = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label3
			// 
			this.label3.Dock = System.Windows.Forms.DockStyle.Top;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(0, 0);
			this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(679, 56);
			this.label3.TabIndex = 8;
			this.label3.Text = "Dom Zdravlja Velika Plana";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button_Simptomi
			// 
			this.button_Simptomi.Location = new System.Drawing.Point(10, 135);
			this.button_Simptomi.Name = "button_Simptomi";
			this.button_Simptomi.Size = new System.Drawing.Size(189, 47);
			this.button_Simptomi.TabIndex = 9;
			this.button_Simptomi.Text = "Simptomi";
			this.button_Simptomi.UseVisualStyleBackColor = true;
			this.button_Simptomi.Click += new System.EventHandler(this.Simptomi);
			// 
			// button_IstorijaBolesti
			// 
			this.button_IstorijaBolesti.Location = new System.Drawing.Point(231, 133);
			this.button_IstorijaBolesti.Name = "button_IstorijaBolesti";
			this.button_IstorijaBolesti.Size = new System.Drawing.Size(189, 47);
			this.button_IstorijaBolesti.TabIndex = 10;
			this.button_IstorijaBolesti.Text = "Istorija bolesti";
			this.button_IstorijaBolesti.UseVisualStyleBackColor = true;
			this.button_IstorijaBolesti.Click += new System.EventHandler(this.IstorijaBolesti);
			// 
			// buttonDoktori
			// 
			this.buttonDoktori.Location = new System.Drawing.Point(451, 134);
			this.buttonDoktori.Name = "buttonDoktori";
			this.buttonDoktori.Size = new System.Drawing.Size(189, 47);
			this.buttonDoktori.TabIndex = 11;
			this.buttonDoktori.Text = "Doktori";
			this.buttonDoktori.UseVisualStyleBackColor = true;
			this.buttonDoktori.Click += new System.EventHandler(this.Doktori);
			// 
			// button_KontaktCentar
			// 
			this.button_KontaktCentar.Location = new System.Drawing.Point(6, 228);
			this.button_KontaktCentar.Name = "button_KontaktCentar";
			this.button_KontaktCentar.Size = new System.Drawing.Size(189, 47);
			this.button_KontaktCentar.TabIndex = 12;
			this.button_KontaktCentar.Text = "Kontakt centar";
			this.button_KontaktCentar.UseVisualStyleBackColor = true;
			this.button_KontaktCentar.Click += new System.EventHandler(this.KontaktCentar);
			// 
			// button_ONama
			// 
			this.button_ONama.Location = new System.Drawing.Point(234, 227);
			this.button_ONama.Name = "button_ONama";
			this.button_ONama.Size = new System.Drawing.Size(189, 47);
			this.button_ONama.TabIndex = 13;
			this.button_ONama.Text = "O nama";
			this.button_ONama.UseVisualStyleBackColor = true;
			this.button_ONama.Click += new System.EventHandler(this.ONama);
			// 
			// button_InfoCentar
			// 
			this.button_InfoCentar.Location = new System.Drawing.Point(452, 229);
			this.button_InfoCentar.Name = "button_InfoCentar";
			this.button_InfoCentar.Size = new System.Drawing.Size(189, 47);
			this.button_InfoCentar.TabIndex = 14;
			this.button_InfoCentar.Text = "Info centar";
			this.button_InfoCentar.UseVisualStyleBackColor = true;
			this.button_InfoCentar.Click += new System.EventHandler(this.InfoCentar);
			// 
			// button_Odjava
			// 
			this.button_Odjava.Image = ((System.Drawing.Image)(resources.GetObject("button_Odjava.Image")));
			this.button_Odjava.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button_Odjava.Location = new System.Drawing.Point(474, 350);
			this.button_Odjava.Name = "button_Odjava";
			this.button_Odjava.Size = new System.Drawing.Size(189, 47);
			this.button_Odjava.TabIndex = 16;
			this.button_Odjava.Text = "Odjava";
			this.button_Odjava.UseVisualStyleBackColor = true;
			this.button_Odjava.Click += new System.EventHandler(this.Odjava);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(15, 74);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(370, 41);
			this.label1.TabIndex = 17;
			this.label1.Text = "Izaberite neku od ponuđenih opcija: ";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.RoyalBlue;
			this.ClientSize = new System.Drawing.Size(679, 423);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button_Odjava);
			this.Controls.Add(this.button_InfoCentar);
			this.Controls.Add(this.button_ONama);
			this.Controls.Add(this.button_KontaktCentar);
			this.Controls.Add(this.buttonDoktori);
			this.Controls.Add(this.button_IstorijaBolesti);
			this.Controls.Add(this.button_Simptomi);
			this.Controls.Add(this.label3);
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.HelpButton = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(6);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Dom Zdravlja";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainFormFormClosing);
			this.ResumeLayout(false);

		}
	}
}
