/*
 * Created by SharpDevelop.
 * User: Petrovici
 * Date: 20.12.2018
 * Time: 00:52
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data;

namespace Dom_Zdravlja
{
	/// <summary>
	/// Description of IstorijaBolesti.
	/// </summary>
	public partial class IstorijaBolesti : Form
	{
		public IstorijaBolesti()
		{
			
			InitializeComponent();
			DrawTable();
			
		}
		
		void DrawTable()
		{
			using(SQLiteConnection konekcija=new SQLiteConnection("Data Source=Baza.db; Version=3;"))
			{
				konekcija.Open();
				string sql="select Ime, Prezime, IstorijaBolesti from Korisnici WHERE BrojKartona= 'IT-02-29/2016'";
				using(SQLiteCommand komanda=new SQLiteCommand(sql, konekcija))
				{
					using(SQLiteDataReader reader=komanda.ExecuteReader())
					{
						if (reader.HasRows)
	            			{
			              	  DataTable dt = new DataTable();
			              	  dt.Load(reader);
			               	  dataSql.DataSource = dt;
	            			}
					}
				}
			}
		}
		
		void Back(object sender, EventArgs e)
		{
			MainForm main = new MainForm();
			main.Show();
			this.Hide();
		}
		
		void IstorijaBolestiFormClosing(object sender, FormClosingEventArgs e)
		{
			MainForm main = new MainForm();
			main.Show();
			this.Hide();
		}
		
	}
}
