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
			this.button_Statistika = new System.Windows.Forms.Button();
			this.button_DezurniDoktor = new System.Windows.Forms.Button();
			this.button_ZakaziPregled = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
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
			this.button_KontaktCentar.Location = new System.Drawing.Point(10, 229);
			this.button_KontaktCentar.Name = "button_KontaktCentar";
			this.button_KontaktCentar.Size = new System.Drawing.Size(189, 47);
			this.button_KontaktCentar.TabIndex = 12;
			this.button_KontaktCentar.Text = "Kontakt centar";
			this.button_KontaktCentar.UseVisualStyleBackColor = true;
			this.button_KontaktCentar.Click += new System.EventHandler(this.KontaktCentar);
			// 
			// button_ONama
			// 
			this.button_ONama.Location = new System.Drawing.Point(234, 229);
			this.button_ONama.Name = "button_ONama";
			this.button_ONama.Size = new System.Drawing.Size(189, 47);
			this.button_ONama.TabIndex = 13;
			this.button_ONama.Text = "O nama";
			this.button_ONama.UseVisualStyleBackColor = true;
			this.button_ONama.Click += new System.EventHandler(this.ONama);
			// 
			// button_InfoCentar
			// 
			this.button_InfoCentar.Location = new System.Drawing.Point(451, 229);
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
			this.button_Odjava.Location = new System.Drawing.Point(451, 414);
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
			// button_Statistika
			// 
			this.button_Statistika.Location = new System.Drawing.Point(234, 330);
			this.button_Statistika.Name = "button_Statistika";
			this.button_Statistika.Size = new System.Drawing.Size(186, 47);
			this.button_Statistika.TabIndex = 19;
			this.button_Statistika.Text = "Statistika";
			this.button_Statistika.UseVisualStyleBackColor = true;
			this.button_Statistika.Click += new System.EventHandler(this.Statistika);
			// 
			// button_DezurniDoktor
			// 
			this.button_DezurniDoktor.Location = new System.Drawing.Point(10, 330);
			this.button_DezurniDoktor.Name = "button_DezurniDoktor";
			this.button_DezurniDoktor.Size = new System.Drawing.Size(189, 47);
			this.button_DezurniDoktor.TabIndex = 18;
			this.button_DezurniDoktor.Text = "Dežurni doktor";
			this.button_DezurniDoktor.UseVisualStyleBackColor = true;
			this.button_DezurniDoktor.Click += new System.EventHandler(this.DezurniDoktor);
			// 
			// button_ZakaziPregled
			// 
			this.button_ZakaziPregled.Location = new System.Drawing.Point(451, 330);
			this.button_ZakaziPregled.Name = "button_ZakaziPregled";
			this.button_ZakaziPregled.Size = new System.Drawing.Size(186, 47);
			this.button_ZakaziPregled.TabIndex = 20;
			this.button_ZakaziPregled.Text = "Zakaži pregled";
			this.button_ZakaziPregled.UseVisualStyleBackColor = true;
			this.button_ZakaziPregled.Click += new System.EventHandler(this.Button_ZakaziPregledClick);
			// 
			// label2
			// 
			this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
			this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label2.Location = new System.Drawing.Point(578, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(101, 73);
			this.label2.TabIndex = 40;
			// 
			// label4
			// 
			this.label4.Image = ((System.Drawing.Image)(resources.GetObject("label4.Image")));
			this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label4.Location = new System.Drawing.Point(0, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(67, 73);
			this.label4.TabIndex = 41;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.RoyalBlue;
			this.ClientSize = new System.Drawing.Size(679, 473);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button_ZakaziPregled);
			this.Controls.Add(this.button_Statistika);
			this.Controls.Add(this.button_DezurniDoktor);
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
		private System.Windows.Forms.Button button_Statistika;
		private System.Windows.Forms.Button button_DezurniDoktor;
		private System.Windows.Forms.Button button_ZakaziPregled;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label4;
	}
}
