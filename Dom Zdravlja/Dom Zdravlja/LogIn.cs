/*
 * Created by SharpDevelop.
 * User: Petrovici
 * Date: 08.12.2018
 * Time: 23:44
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data;
using System.Globalization;


namespace Dom_Zdravlja
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class LogIn : Form
	{
		
		public LogIn()
		{
			InitializeComponent();
			
		}
		
		void Provera_Korisnika(String BrojKartona, String Lozinka)
		{
			using(SQLiteConnection konekcija = new SQLiteConnection("Data Source=Baza.db; Version=3;"))
			{
				konekcija.Open();
            
	            int broj_korisnika = 0;
 
	            string sql = "select Brojkartona, Lozinka from Korisnici WHERE BrojKartona= '" + BrojKartona + "'";
	            using(SQLiteCommand komanda = new SQLiteCommand(sql, konekcija))
	            {
	            	using(SQLiteDataReader reader = komanda.ExecuteReader())
	            	{
	            		while (reader.Read())
	            		{
	            			broj_korisnika+=1;
	            			break;
	            		}
	            		if(broj_korisnika==0)
						{
							MessageBox.Show("Nepostojeći nalog. Morate da se registrujete.");
							txt_BrojKartona.Clear();
							txt_Lozinka.Clear();
						}
		            	else
		            	{
		            		MessageBox.Show("Uspešno ste se ulogovali.");
		            		MainForm main = new MainForm();
							main.Show();
							this.Hide();
		            	} 		            	
	            	}
	            }
	            
	            
			}
		}
		
		
		void Log_In(object sender, EventArgs e)
		{
			
			Provera_Korisnika(txt_BrojKartona.Text, txt_Lozinka.Text);
			
		}
						
		void Registruj_se(object sender, EventArgs e)
		{
			Button b2 = (Button) this.Controls ["RegistrujSe"];
			RegistrujSe registruj_se = new RegistrujSe();
			registruj_se.Show();
			this.Hide();
		}
		
		
		
		void LogInFormClosing(object sender, FormClosingEventArgs e)
		{
			string poruka="Da li ste sigurni da želite da zatvorite aplikaciju?";
			string caption="Provera";
			MessageBoxButtons buttons=MessageBoxButtons.YesNo;
			DialogResult dialog;
			dialog=MessageBox.Show(poruka, caption, buttons);
			
			if(dialog==DialogResult.Yes)
			{
				Application.Exit();	
			}
			else
			{
				e.Cancel=true;
			}
		}
		
		
	}
}
