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
					string sql="select ID, Ime, Prezime, Specijalnost from Doktori";
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
			
	
		void Button_PretraziClick(object sender, EventArgs e)
		{
			using(SQLiteConnection konekcija=new SQLiteConnection("Data Source=Baza.db; Version=3;"))
				{
					konekcija.Open();
					if (txt_Pretraga.Text=="1")
					{
						string sql="select ID, Ime, Prezime, Specijalnost from Doktori where ID=1";
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
					
					
					else if (txt_Pretraga.Text=="2")
					{
						string sql="select ID, Ime, Prezime, Specijalnost from Doktori where ID=2";
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
					
					
					else if (txt_Pretraga.Text=="3")
					{
						string sql="select ID, Ime, Prezime, Specijalnost from Doktori where ID=3";
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
					
					
					else if (txt_Pretraga.Text=="4")
					{
						string sql="select ID, Ime, Prezime, Specijalnost from Doktori where ID=4";
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
					
					
					else if (txt_Pretraga.Text=="5")
					{
						string sql="select ID, Ime, Prezime, Specijalnost from Doktori where ID=5";
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
					
					
					else if (txt_Pretraga.Text=="6")
					{
						string sql="select ID, Ime, Prezime, Specijalnost from Doktori where ID=6";
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
					
					
					else if (txt_Pretraga.Text=="7")
					{
						string sql="select ID, Ime, Prezime, Specijalnost from Doktori where ID=7";
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
					
					
					else if (txt_Pretraga.Text=="8")
					{
						string sql="select ID, Ime, Prezime, Specijalnost from Doktori where ID=8";
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
					
					
					else if (txt_Pretraga.Text=="9")
					{
						string sql="select ID, Ime, Prezime, Specijalnost from Doktori where ID=9";
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
					
					
					else if (txt_Pretraga.Text=="10")
					{
						string sql="select ID, Ime, Prezime, Specijalnost from Doktori where ID=10";
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
					
					
					else if (txt_Pretraga.Text=="11")
					{
						string sql="select ID, Ime, Prezime, Specijalnost from Doktori where ID=11";
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
					
					
					else if (txt_Pretraga.Text=="12")
					{
						string sql="select ID, Ime, Prezime, Specijalnost from Doktori where ID=12";
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
					
					
					else if (txt_Pretraga.Text=="13")
					{
						string sql="select ID, Ime, Prezime, Specijalnost from Doktori where ID=13";
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
					
					
					else if (txt_Pretraga.Text=="14")
					{
						string sql="select ID, Ime, Prezime, Specijalnost from Doktori where ID=14";
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
					
					
					else if (txt_Pretraga.Text=="15")
					{
						string sql="select ID, Ime, Prezime, Specijalnost from Doktori where ID=15";
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
					
					
					else if (txt_Pretraga.Text=="16")
					{
						string sql="select ID, Ime, Prezime, Specijalnost from Doktori where ID=16";
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
					
					
					else if (txt_Pretraga.Text=="17")
					{
						string sql="select ID, Ime, Prezime, Specijalnost from Doktori where ID=17";
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
					
					
					else if (txt_Pretraga.Text=="18")
					{
						string sql="select ID, Ime, Prezime, Specijalnost from Doktori where ID=18";
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
					
					
					else if (txt_Pretraga.Text=="19")
					{
						string sql="select ID, Ime, Prezime, Specijalnost from Doktori where ID=19";
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
					
					
					
					else if (txt_Pretraga.Text=="20")
					{
						string sql="select ID, Ime, Prezime, Specijalnost from Doktori where ID=20";
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
					
					
					else if (txt_Pretraga.Text=="21")
					{
						string sql="select ID, Ime, Prezime, Specijalnost from Doktori where ID=21";
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
					
					
					else if (txt_Pretraga.Text=="22")
					{
						string sql="select ID, Ime, Prezime, Specijalnost from Doktori where ID=22";
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
					
					
					else if (txt_Pretraga.Text=="23")
					{
						string sql="select ID, Ime, Prezime, Specijalnost from Doktori where ID=23";
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
					
					
					else if (txt_Pretraga.Text=="24")
					{
						string sql="select ID, Ime, Prezime, Specijalnost from Doktori where ID=24";
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
					
					
					else if (txt_Pretraga.Text=="25")
					{
						string sql="select ID, Ime, Prezime, Specijalnost from Doktori where ID=25";
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
					
					
					else if (txt_Pretraga.Text=="26")
					{
						string sql="select ID, Ime, Prezime, Specijalnost from Doktori where ID=26";
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
					
					
					
					else if (txt_Pretraga.Text=="27")
					{
						string sql="select ID, Ime, Prezime, Specijalnost from Doktori where ID=27";
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
					
					
					else if (txt_Pretraga.Text=="28")
					{
						string sql="select ID, Ime, Prezime, Specijalnost from Doktori where ID=28";
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
					
					
					else if (txt_Pretraga.Text=="29")
					{
						string sql="select ID, Ime, Prezime, Specijalnost from Doktori where ID=29";
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
					
					
					else if (txt_Pretraga.Text=="30")
					{
						string sql="select ID, Ime, Prezime, Specijalnost from Doktori where ID=30";
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
					
					
					else if (txt_Pretraga.Text=="31")
					{
						string sql="select ID, Ime, Prezime, Specijalnost from Doktori where ID=31";
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
					
					
					else if (txt_Pretraga.Text=="32")
					{
						string sql="select ID, Ime, Prezime, Specijalnost from Doktori where ID=32";
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
					
					
					else if (txt_Pretraga.Text=="33")
					{
						string sql="select ID, Ime, Prezime, Specijalnost from Doktori where ID=33";
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
					
					
					else if (txt_Pretraga.Text=="34")
					{
						string sql="select ID, Ime, Prezime, Specijalnost from Doktori where ID=34";
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
					
					
					else if (txt_Pretraga.Text=="35")
					{
						string sql="select ID, Ime, Prezime, Specijalnost from Doktori where ID=35";
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
					
					
					else if (txt_Pretraga.Text=="36")
					{
						string sql="select ID, Ime, Prezime, Specijalnost from Doktori where ID=36";
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
					
					
					else if (txt_Pretraga.Text=="37")
					{
						string sql="select ID, Ime, Prezime, Specijalnost from Doktori where ID=37";
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
					
					
					else if (txt_Pretraga.Text=="38")
					{
						string sql="select ID, Ime, Prezime, Specijalnost from Doktori where ID=38";
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
					
					
					else if (txt_Pretraga.Text=="39")
					{
						string sql="select ID, Ime, Prezime, Specijalnost from Doktori where ID=39";
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
					
					
					else if (txt_Pretraga.Text=="40")
					{
						string sql="select ID, Ime, Prezime, Specijalnost from Doktori where ID=40";
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
					
					
					else if (txt_Pretraga.Text=="41")
					{
						string sql="select ID, Ime, Prezime, Specijalnost from Doktori where ID=41";
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
					
					
					else if (txt_Pretraga.Text=="42")
					{
						string sql="select ID, Ime, Prezime, Specijalnost from Doktori where ID=42";
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
					
					
					else if (txt_Pretraga.Text=="43")
					{
						string sql="select ID, Ime, Prezime, Specijalnost from Doktori where ID=43";
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
					
					
					else if (txt_Pretraga.Text=="44")
					{
						string sql="select ID, Ime, Prezime, Specijalnost from Doktori where ID=44";
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
					
					
					else if (txt_Pretraga.Text=="45")
					{
						string sql="select ID, Ime, Prezime, Specijalnost from Doktori where ID=45";
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
					
					
					else if (txt_Pretraga.Text=="46")
					{
						string sql="select ID, Ime, Prezime, Specijalnost from Doktori where ID=46";
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
					
					
					else if (txt_Pretraga.Text=="47")
					{
						string sql="select ID, Ime, Prezime, Specijalnost from Doktori where ID=47";
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
					
					
					else if (txt_Pretraga.Text=="48")
					{
						string sql="select ID, Ime, Prezime, Specijalnost from Doktori where ID=48";
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
					
					
					else if (txt_Pretraga.Text=="49")
					{
						string sql="select ID, Ime, Prezime, Specijalnost from Doktori where ID=49";
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
					
					
					else if (txt_Pretraga.Text=="50")
					{
						string sql="select ID, Ime, Prezime, Specijalnost from Doktori where ID=50";
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
					
					
					else if (txt_Pretraga.Text=="51")
					{
						string sql="select ID, Ime, Prezime, Specijalnost from Doktori where ID=51";
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
					
					
					else if (txt_Pretraga.Text=="52")
					{
						string sql="select ID, Ime, Prezime, Specijalnost from Doktori where ID=52";
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
					
					else
					{
						MessageBox.Show("Nepostojeći unos.");
					}
					
			}
		}
					
					
		void Txt_PretragaTextChanged(object sender, EventArgs e)
		{
			using(SQLiteConnection konekcija=new SQLiteConnection("Data Source=Baza.db; Version=3;"))
				{
					konekcija.Open();
					string sql="select ID, Ime, Prezime, Specijalnost from Doktori WHERE Ime LIKE '%" + txt_Pretraga.Text + "%' or Prezime LIKE '%" + txt_Pretraga.Text + "%'";
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


