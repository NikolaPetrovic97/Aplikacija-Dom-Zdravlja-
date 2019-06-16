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
	/// Description of Doktori.
	/// </summary>
	public partial class Doktori : Form
	{
		public Doktori()
		{
			
			InitializeComponent();
			DrawTable();
		}
			void DrawTable()
			{
				using(SQLiteConnection konekcija=new SQLiteConnection("Data Source=Baza.db; Version=3;"))
				{
					konekcija.Open();
					string sql="select * from Doktori";
					using(SQLiteCommand komanda = new SQLiteCommand(sql, konekcija))
					{
	            		using(SQLiteDataReader reader = komanda.ExecuteReader())
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
		void DoktoriFormClosing(object sender, FormClosingEventArgs e)
		{
			MainForm main = new MainForm();
			main.Show();
			this.Hide();
		}
		
	}
}
