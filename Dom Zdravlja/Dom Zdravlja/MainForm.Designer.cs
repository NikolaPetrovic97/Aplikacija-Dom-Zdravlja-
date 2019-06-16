/*
 * Created by SharpDevelop.
 * User: Petrovici
 * Date: 17.12.2018
 * Time: 17:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Dom_Zdravlja
{
	partial class LogIn
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Label label_Dom_Zdravlja;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label_BrojKartona;
		private System.Windows.Forms.Label label_Lozinka;
		private System.Windows.Forms.TextBox txt_BrojKartona;
		private System.Windows.Forms.TextBox txt_Lozinka;
		private System.Windows.Forms.Button button_Prijavi_se;
		private System.Windows.Forms.Button button_Registruj_se;
		private System.Windows.Forms.Label label2;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
			this.label_Dom_Zdravlja = new System.Windows.Forms.Label();
			this.button_Registruj_se = new System.Windows.Forms.Button();
			this.button_Prijavi_se = new System.Windows.Forms.Button();
			this.txt_Lozinka = new System.Windows.Forms.TextBox();
			this.txt_BrojKartona = new System.Windows.Forms.TextBox();
			this.label_Lozinka = new System.Windows.Forms.Label();
			this.label_BrojKartona = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label_Dom_Zdravlja
			// 
			this.label_Dom_Zdravlja.Dock = System.Windows.Forms.DockStyle.Top;
			this.label_Dom_Zdravlja.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_Dom_Zdravlja.Image = ((System.Drawing.Image)(resources.GetObject("label_Dom_Zdravlja.Image")));
			this.label_Dom_Zdravlja.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.label_Dom_Zdravlja.Location = new System.Drawing.Point(0, 0);
			this.label_Dom_Zdravlja.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label_Dom_Zdravlja.Name = "label_Dom_Zdravlja";
			this.label_Dom_Zdravlja.Size = new System.Drawing.Size(664, 65);
			this.label_Dom_Zdravlja.TabIndex = 5;
			this.label_Dom_Zdravlja.Text = "Dom Zdravlja Velika Plana";
			this.label_Dom_Zdravlja.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button_Registruj_se
			// 
			this.button_Registruj_se.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_Registruj_se.Image = ((System.Drawing.Image)(resources.GetObject("button_Registruj_se.Image")));
			this.button_Registruj_se.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button_Registruj_se.Location = new System.Drawing.Point(474, 277);
			this.button_Registruj_se.Name = "button_Registruj_se";
			this.button_Registruj_se.Size = new System.Drawing.Size(152, 63);
			this.button_Registruj_se.TabIndex = 24;
			this.button_Registruj_se.Text = "Registruj se";
			this.button_Registruj_se.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button_Registruj_se.UseVisualStyleBackColor = true;
			this.button_Registruj_se.Click += new System.EventHandler(this.Registruj_se);
			// 
			// button_Prijavi_se
			// 
			this.button_Prijavi_se.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_Prijavi_se.Image = ((System.Drawing.Image)(resources.GetObject("button_Prijavi_se.Image")));
			this.button_Prijavi_se.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.button_Prijavi_se.Location = new System.Drawing.Point(117, 287);
			this.button_Prijavi_se.Name = "button_Prijavi_se";
			this.button_Prijavi_se.Size = new System.Drawing.Size(117, 37);
			this.button_Prijavi_se.TabIndex = 23;
			this.button_Prijavi_se.Text = "Prijavi se";
			this.button_Prijavi_se.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.button_Prijavi_se.UseVisualStyleBackColor = true;
			this.button_Prijavi_se.Click += new System.EventHandler(this.Log_In);
			// 
			// txt_Lozinka
			// 
			this.txt_Lozinka.BackColor = System.Drawing.SystemColors.Window;
			this.txt_Lozinka.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
			this.txt_Lozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_Lozinka.Location = new System.Drawing.Point(143, 213);
			this.txt_Lozinka.Multiline = true;
			this.txt_Lozinka.Name = "txt_Lozinka";
			this.txt_Lozinka.PasswordChar = '#';
			this.txt_Lozinka.Size = new System.Drawing.Size(191, 29);
			this.txt_Lozinka.TabIndex = 22;
			// 
			// txt_BrojKartona
			// 
			this.txt_BrojKartona.BackColor = System.Drawing.SystemColors.Window;
			this.txt_BrojKartona.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txt_BrojKartona.Location = new System.Drawing.Point(143, 171);
			this.txt_BrojKartona.Multiline = true;
			this.txt_BrojKartona.Name = "txt_BrojKartona";
			this.txt_BrojKartona.Size = new System.Drawing.Size(191, 29);
			this.txt_BrojKartona.TabIndex = 21;
			// 
			// label_Lozinka
			// 
			this.label_Lozinka.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_Lozinka.Location = new System.Drawing.Point(28, 212);
			this.label_Lozinka.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label_Lozinka.Name = "label_Lozinka";
			this.label_Lozinka.Size = new System.Drawing.Size(88, 29);
			this.label_Lozinka.TabIndex = 20;
			this.label_Lozinka.Text = "Lozinka:";
			// 
			// label_BrojKartona
			// 
			this.label_BrojKartona.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_BrojKartona.Location = new System.Drawing.Point(1, 171);
			this.label_BrojKartona.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label_BrojKartona.Name = "label_BrojKartona";
			this.label_BrojKartona.Size = new System.Drawing.Size(122, 30);
			this.label_BrojKartona.TabIndex = 19;
			this.label_BrojKartona.Text = "Broj Kartona:";
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(15, 109);
			this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(572, 36);
			this.label1.TabIndex = 18;
			this.label1.Text = "Ukoliko ste naš pacijent, ulogujte se.  A, ukoliko niste, registrujte se.";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label2
			// 
			this.label2.Image = ((System.Drawing.Image)(resources.GetObject("label2.Image")));
			this.label2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.label2.Location = new System.Drawing.Point(561, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(101, 73);
			this.label2.TabIndex = 26;
			// 
			// LogIn
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.RoyalBlue;
			this.ClientSize = new System.Drawing.Size(664, 392);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.button_Registruj_se);
			this.Controls.Add(this.button_Prijavi_se);
			this.Controls.Add(this.txt_Lozinka);
			this.Controls.Add(this.txt_BrojKartona);
			this.Controls.Add(this.label_Lozinka);
			this.Controls.Add(this.label_BrojKartona);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.label_Dom_Zdravlja);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "LogIn";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Dom Zdravlja";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LogInFormClosing);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
