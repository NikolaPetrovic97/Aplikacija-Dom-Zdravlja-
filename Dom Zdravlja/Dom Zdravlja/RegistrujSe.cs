/*
 * Created by SharpDevelop.
 * User: Petrovici
 * Date: 17.12.2018
 * Time: 17:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Globalization;
using System.Data.SQLite;
using System.Data;

namespace Dom_Zdravlja
{
	/// <summary>
	/// Description of Registruj_se.
	/// </summary>
	public partial class RegistrujSe : Form
	{
		
		public RegistrujSe()
		{
			
			InitializeComponent();
		}
		
		

		void DodajKarton()
		{
			Random r=new Random();
			
			using(SQLiteConnection konekcija=new SQLiteConnection("Data Source=Baza.db; Version=3;"))
			{
				konekcija.Open();
				MessageBox.Show("Vas broj kartona je: " + " " + r.Next(0, 10000).ToString());
				string sql="insert into Korisnici(BrojKartona)" + "value(r)";
				using(SQLiteCommand komanda=new SQLiteCommand(sql, konekcija))
				{
					komanda.ExecuteNonQuery();
				}
			}
		}
		
		void Registracija()
		{
			try
			{
				using(SQLiteConnection konekcija=new SQLiteConnection("Data Source=Baza.db; Version=3;"))
				{
					konekcija.Open();
					string sql="insert into Korisnici(Ime, Prezime, JMBG, BrojLicneKarte, BrojZdravstveneKnjizice, DatumRodjenja, MestoRodjenja, Drzavljanstvo, NacionalnaPripadnost, Adresa, BrojTelefona, Email, Pol, Lozinka)" +
					" values('"+ this.txt_Ime.Text +"', '"+ this.txt_Prezime.Text +"', '"+ this.txt_JMBG.Text +"', '"+ this.txt_BrojLicneKarte.Text +"', '"+ this.txt_BrojZdravstveneKnjizice.Text +"', '"+ this.dateTimePicker1.Text
					+"', '"+ this.txt_MestoRodjenja.Text +"',  '"+ this.txt_Drzavljanstvo.Text +"',  '"+ this.txt_NacionalnaPripadnost.Text +"',  '"+ this.txt_Adresa.Text +"', '"+ this.txt_BrojTelefona.Text +"',  '"+ this.txt_Email.Text +"', '"+ this.txt_Pol.Text +"', '"+ this.txt_Lozinka.Text + "');";
					using(SQLiteCommand komanda=new SQLiteCommand(sql, konekcija))
					{
							komanda.ExecuteNonQuery();
					}
				}
			}
			catch(Exception)
			{
				
			}
		}
			
		
		
		
		
		void Registruj_se(object sender, EventArgs e)
		{
			if(txt_Ime.Text=="")
			{
				MessageBox.Show("Polje Ime mora biti popunjeno.");
			}
			else if(txt_Prezime.Text=="")
			{
				MessageBox.Show("Polje Prezime mora biti popunjeno.");
			}
			else if(txt_JMBG.Text=="")
			{	
				MessageBox.Show("Polje JMBG mora biti popunjeno.");
			}
			else if(System.Text.RegularExpressions.Regex.IsMatch(txt_JMBG.Text, "[^0-9]"))
			{
				MessageBox.Show("U polje JMBG možete uneti samo brojeve.");
				txt_JMBG.Clear();
			}
			else if(txt_JMBG.TextLength<13 || txt_JMBG.TextLength>13)
			{
				MessageBox.Show("JMBG mora biti dužine 13 broja.");
			}
			else if(txt_BrojLicneKarte.Text=="")
			{
				MessageBox.Show("Polje Broj Lične Karte mora biti popunjeno.");
			}
			else if(System.Text.RegularExpressions.Regex.IsMatch(txt_BrojLicneKarte.Text, "[^0-9]"))
			{
				MessageBox.Show("U polje Broj Lične Karte možete uneti samo brojeve.");
				txt_BrojLicneKarte.Clear();
			}
			else if(txt_BrojZdravstveneKnjizice.Text=="")
			{
				MessageBox.Show("Polje Broj Zdravstvene Knjižice mora biti popunjeno.");
			}
			else if(System.Text.RegularExpressions.Regex.IsMatch(txt_BrojZdravstveneKnjizice.Text, "[^0-9]"))
			{
				MessageBox.Show("U polje Broj Zdravstvene Knjižice možete uneti samo brojeve");
				txt_BrojZdravstveneKnjizice.Clear();
			}
			else if(txt_MestoRodjenja.Text=="")
			{
				MessageBox.Show("Polje Mesto Rođenja mora biti popunjeno.");
			}
			else if(txt_Drzavljanstvo.Text=="")
			{
				MessageBox.Show("Polje Državljanstvo mora biti popunjeno.");
			}
			else if(txt_NacionalnaPripadnost.Text=="")
			{
				MessageBox.Show("Polje Nacionalna Pripadnost mora biti popunjeno.");
			}
			else if(txt_Adresa.Text=="")
			{
				MessageBox.Show("Polje Adresa mora biti popunjeno.");
			}
			else if(txt_BrojTelefona.Text=="")
			{
				MessageBox.Show("Polje Broj Telefona mora biti popunjeno.");
			}
			else if(System.Text.RegularExpressions.Regex.IsMatch(txt_BrojTelefona.Text, "[^0-9]"))
			{
				MessageBox.Show("U polje Broj Telefona možete uneti samo brojeve.");
				txt_BrojTelefona.Clear();
			}
			else if(txt_Email.Text=="")
			{
				MessageBox.Show("Polje E-mail mora biti popunjeno.");
			}
			else if(txt_Pol.Text=="")
			{
				MessageBox.Show("Morate uneti Vaš pol");
			}
			else if(txt_Lozinka.Text=="")
			{
				MessageBox.Show("Morate uneti lozinku.");
			}
			else
			{		
				MessageBox.Show("Uspešno ste se registrovali.");
				DodajKarton();
				LogIn log_in = new LogIn();
				log_in.Show();
				this.Hide();
				Registracija();
			}
						
					
				
							
			
		}
		
		
		void Back(object sender, EventArgs e)
		{
			LogIn log_in = new LogIn();
			log_in.Show();
			this.Hide();
		}
		
		
		void RegistrujSeFormClosing(object sender, FormClosingEventArgs e)
		{
			LogIn log_in = new LogIn();
			log_in.Show();
			this.Hide();
			
		}
	
	}
}
			
			
		




		
		

