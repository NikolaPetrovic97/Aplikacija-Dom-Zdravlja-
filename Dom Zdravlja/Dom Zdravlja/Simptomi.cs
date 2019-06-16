/*
 * Created by SharpDevelop.
 * User: Petrovici
 * Date: 20.12.2018
 * Time: 00:40
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
	/// Description of Simptomi.
	/// </summary>
	public partial class Simptomi : Form
	{
		public Simptomi()
		{
			
			InitializeComponent();
			
			
			
		}
		
		void Pregledao()
		{
			Random r=new Random();
			int rnd=r.Next(1, 53);
			using(SQLiteConnection konekcija=new SQLiteConnection("Data Source=Baza.db; Version=3;"))
			{
				konekcija.Open();
				if(rnd==1)
				{
					string sql="select DR, Ime, Prezime from Doktori WHERE ID='1'";
					using(SQLiteCommand komanda=new SQLiteCommand(sql, konekcija))
					{
						using(SQLiteDataReader reader = komanda.ExecuteReader())
	            		{
	            			if (reader.HasRows)
	            			{
			              	  DataTable dt = new DataTable();
			              	  dt.Load(reader);
			               	  dataSql2.DataSource = dt;
			               	  
	            			}
	            			
				
						}
					}
				}
				if(rnd==2)
				{
					string sql="select DR, Ime, Prezime from Doktori WHERE ID='2'";
					using(SQLiteCommand komanda=new SQLiteCommand(sql, konekcija))
					{
						using(SQLiteDataReader reader = komanda.ExecuteReader())
	            		{
	            			if (reader.HasRows)
	            			{
			              	  DataTable dt = new DataTable();
			              	  dt.Load(reader);
			               	  dataSql2.DataSource = dt;
			               	  
	            			}
	            			
				
						}
					}
				}
				if(rnd==3)
				{
					string sql="select DR, Ime, Prezime from Doktori WHERE ID='3'";
					using(SQLiteCommand komanda=new SQLiteCommand(sql, konekcija))
					{
						using(SQLiteDataReader reader = komanda.ExecuteReader())
	            		{
	            			if (reader.HasRows)
	            			{
			              	  DataTable dt = new DataTable();
			              	  dt.Load(reader);
			               	  dataSql2.DataSource = dt;
			               	  
	            			}
	            			
				
						}
					}
				}
				if(rnd==4)
				{
					string sql="select DR, Ime, Prezime from Doktori WHERE ID='4'";
					using(SQLiteCommand komanda=new SQLiteCommand(sql, konekcija))
					{
						using(SQLiteDataReader reader = komanda.ExecuteReader())
	            		{
	            			if (reader.HasRows)
	            			{
			              	  DataTable dt = new DataTable();
			              	  dt.Load(reader);
			               	  dataSql2.DataSource = dt;
			               	  
	            			}
	            			
				
						}
					}
				}
				if(rnd==5)
				{
					string sql="select DR, Ime, Prezime from Doktori WHERE ID='5'";
					using(SQLiteCommand komanda=new SQLiteCommand(sql, konekcija))
					{
						using(SQLiteDataReader reader = komanda.ExecuteReader())
	            		{
	            			if (reader.HasRows)
	            			{
			              	  DataTable dt = new DataTable();
			              	  dt.Load(reader);
			               	  dataSql2.DataSource = dt;
			               	  
	            			}
	            			
				
						}
					}
				}
				if(rnd==6)
				{
					string sql="select DR, Ime, Prezime from Doktori WHERE ID='6'";
					using(SQLiteCommand komanda=new SQLiteCommand(sql, konekcija))
					{
						using(SQLiteDataReader reader = komanda.ExecuteReader())
	            		{
	            			if (reader.HasRows)
	            			{
			              	  DataTable dt = new DataTable();
			              	  dt.Load(reader);
			               	  dataSql2.DataSource = dt;
			               	  
	            			}
	            			
				
						}
					}
				}
				if(rnd==7)
				{
					string sql="select DR, Ime, Prezime from Doktori WHERE ID='7'";
					using(SQLiteCommand komanda=new SQLiteCommand(sql, konekcija))
					{
						using(SQLiteDataReader reader = komanda.ExecuteReader())
	            		{
	            			if (reader.HasRows)
	            			{
			              	  DataTable dt = new DataTable();
			              	  dt.Load(reader);
			               	  dataSql2.DataSource = dt;
			               	  
	            			}
	            			
				
						}
					}
				}if(rnd==8)
				{
					string sql="select DR, Ime, Prezime from Doktori WHERE ID='8'";
					using(SQLiteCommand komanda=new SQLiteCommand(sql, konekcija))
					{
						using(SQLiteDataReader reader = komanda.ExecuteReader())
	            		{
	            			if (reader.HasRows)
	            			{
			              	  DataTable dt = new DataTable();
			              	  dt.Load(reader);
			               	  dataSql2.DataSource = dt;
			               	  
	            			}
	            			
				
						}
					}
				}
				if(rnd==9)
				{
					string sql="select DR, Ime, Prezime from Doktori WHERE ID='9'";
					using(SQLiteCommand komanda=new SQLiteCommand(sql, konekcija))
					{
						using(SQLiteDataReader reader = komanda.ExecuteReader())
	            		{
	            			if (reader.HasRows)
	            			{
			              	  DataTable dt = new DataTable();
			              	  dt.Load(reader);
			               	  dataSql2.DataSource = dt;
			               	  
	            			}
	            			
				
						}
					}
				}if(rnd==10)
				{
					string sql="select DR, Ime, Prezime from Doktori WHERE ID='10'";
					using(SQLiteCommand komanda=new SQLiteCommand(sql, konekcija))
					{
						using(SQLiteDataReader reader = komanda.ExecuteReader())
	            		{
	            			if (reader.HasRows)
	            			{
			              	  DataTable dt = new DataTable();
			              	  dt.Load(reader);
			               	  dataSql2.DataSource = dt;
			               	  
	            			}
	            			
				
						}
					}
				}
				if(rnd==11)
				{
					string sql="select DR, Ime, Prezime from Doktori WHERE ID='11'";
					using(SQLiteCommand komanda=new SQLiteCommand(sql, konekcija))
					{
						using(SQLiteDataReader reader = komanda.ExecuteReader())
	            		{
	            			if (reader.HasRows)
	            			{
			              	  DataTable dt = new DataTable();
			              	  dt.Load(reader);
			               	  dataSql2.DataSource = dt;
			               	  
	            			}
	            			
				
						}
					}
				}
				if(rnd==12)
				{
					string sql="select DR, Ime, Prezime from Doktori WHERE ID='12'";
					using(SQLiteCommand komanda=new SQLiteCommand(sql, konekcija))
					{
						using(SQLiteDataReader reader = komanda.ExecuteReader())
	            		{
	            			if (reader.HasRows)
	            			{
			              	  DataTable dt = new DataTable();
			              	  dt.Load(reader);
			               	  dataSql2.DataSource = dt;
			               	  
	            			}
	            			
				
						}
					}
				}
				if(rnd==13)
				{
					string sql="select DR, Ime, Prezime from Doktori WHERE ID='13'";
					using(SQLiteCommand komanda=new SQLiteCommand(sql, konekcija))
					{
						using(SQLiteDataReader reader = komanda.ExecuteReader())
	            		{
	            			if (reader.HasRows)
	            			{
			              	  DataTable dt = new DataTable();
			              	  dt.Load(reader);
			               	  dataSql2.DataSource = dt;
			               	  
	            			}
	            			
				
						}
					}
				}
				if(rnd==14)
				{
					string sql="select DR, Ime, Prezime from Doktori WHERE ID='14'";
					using(SQLiteCommand komanda=new SQLiteCommand(sql, konekcija))
					{
						using(SQLiteDataReader reader = komanda.ExecuteReader())
	            		{
	            			if (reader.HasRows)
	            			{
			              	  DataTable dt = new DataTable();
			              	  dt.Load(reader);
			               	  dataSql2.DataSource = dt;
			               	  
	            			}
	            			
				
						}
					}
				}
				if(rnd==15)
				{
					string sql="select DR, Ime, Prezime from Doktori WHERE ID='15'";
					using(SQLiteCommand komanda=new SQLiteCommand(sql, konekcija))
					{
						using(SQLiteDataReader reader = komanda.ExecuteReader())
	            		{
	            			if (reader.HasRows)
	            			{
			              	  DataTable dt = new DataTable();
			              	  dt.Load(reader);
			               	  dataSql2.DataSource = dt;
			               	  
	            			}
	            			
				
						}
					}
				}
				if(rnd==16)
				{
					string sql="select DR, Ime, Prezime from Doktori WHERE ID='16'";
					using(SQLiteCommand komanda=new SQLiteCommand(sql, konekcija))
					{
						using(SQLiteDataReader reader = komanda.ExecuteReader())
	            		{
	            			if (reader.HasRows)
	            			{
			              	  DataTable dt = new DataTable();
			              	  dt.Load(reader);
			               	  dataSql2.DataSource = dt;
			               	  
	            			}
	            			
				
						}
					}
				}
				if(rnd==17)
				{
					string sql="select DR, Ime, Prezime from Doktori WHERE ID='17'";
					using(SQLiteCommand komanda=new SQLiteCommand(sql, konekcija))
					{
						using(SQLiteDataReader reader = komanda.ExecuteReader())
	            		{
	            			if (reader.HasRows)
	            			{
			              	  DataTable dt = new DataTable();
			              	  dt.Load(reader);
			               	  dataSql2.DataSource = dt;
			               	  
	            			}
	            			
				
						}
					}
				}
				if(rnd==18)
				{
					string sql="select DR, Ime, Prezime from Doktori WHERE ID='18'";
					using(SQLiteCommand komanda=new SQLiteCommand(sql, konekcija))
					{
						using(SQLiteDataReader reader = komanda.ExecuteReader())
	            		{
	            			if (reader.HasRows)
	            			{
			              	  DataTable dt = new DataTable();
			              	  dt.Load(reader);
			               	  dataSql2.DataSource = dt;
			               	  
	            			}
	            			
				
						}
					}
				}
				if(rnd==19)
				{
					string sql="select DR, Ime, Prezime from Doktori WHERE ID='19'";
					using(SQLiteCommand komanda=new SQLiteCommand(sql, konekcija))
					{
						using(SQLiteDataReader reader = komanda.ExecuteReader())
	            		{
	            			if (reader.HasRows)
	            			{
			              	  DataTable dt = new DataTable();
			              	  dt.Load(reader);
			               	  dataSql2.DataSource = dt;
			               	  
	            			}
	            			
				
						}
					}
				}
				if(rnd==20)
				{
					string sql="select DR, Ime, Prezime from Doktori WHERE ID='20'";
					using(SQLiteCommand komanda=new SQLiteCommand(sql, konekcija))
					{
						using(SQLiteDataReader reader = komanda.ExecuteReader())
	            		{
	            			if (reader.HasRows)
	            			{
			              	  DataTable dt = new DataTable();
			              	  dt.Load(reader);
			               	  dataSql2.DataSource = dt;
			               	  
	            			}
	            			
				
						}
					}
				}
				if(rnd==21)
				{
					string sql="select DR, Ime, Prezime from Doktori WHERE ID='21'";
					using(SQLiteCommand komanda=new SQLiteCommand(sql, konekcija))
					{
						using(SQLiteDataReader reader = komanda.ExecuteReader())
	            		{
	            			if (reader.HasRows)
	            			{
			              	  DataTable dt = new DataTable();
			              	  dt.Load(reader);
			               	  dataSql2.DataSource = dt;
			               	  
	            			}
	            			
				
						}
					}
				}
				if(rnd==22)
				{
					string sql="select DR, Ime, Prezime from Doktori WHERE ID='22'";
					using(SQLiteCommand komanda=new SQLiteCommand(sql, konekcija))
					{
						using(SQLiteDataReader reader = komanda.ExecuteReader())
	            		{
	            			if (reader.HasRows)
	            			{
			              	  DataTable dt = new DataTable();
			              	  dt.Load(reader);
			               	  dataSql2.DataSource = dt;
			               	  
	            			}
	            			
				
						}
					}
				}
				if(rnd==23)
				{
					string sql="select DR, Ime, Prezime from Doktori WHERE ID='23'";
					using(SQLiteCommand komanda=new SQLiteCommand(sql, konekcija))
					{
						using(SQLiteDataReader reader = komanda.ExecuteReader())
	            		{
	            			if (reader.HasRows)
	            			{
			              	  DataTable dt = new DataTable();
			              	  dt.Load(reader);
			               	  dataSql2.DataSource = dt;
			               	  
	            			}
	            			
				
						}
					}
				}
				if(rnd==24)
				{
					string sql="select DR, Ime, Prezime from Doktori WHERE ID='24'";
					using(SQLiteCommand komanda=new SQLiteCommand(sql, konekcija))
					{
						using(SQLiteDataReader reader = komanda.ExecuteReader())
	            		{
	            			if (reader.HasRows)
	            			{
			              	  DataTable dt = new DataTable();
			              	  dt.Load(reader);
			               	  dataSql2.DataSource = dt;
			               	  
	            			}
	            			
				
						}
					}
				}
				if(rnd==25)
				{
					string sql="select DR, Ime, Prezime from Doktori WHERE ID='25'";
					using(SQLiteCommand komanda=new SQLiteCommand(sql, konekcija))
					{
						using(SQLiteDataReader reader = komanda.ExecuteReader())
	            		{
	            			if (reader.HasRows)
	            			{
			              	  DataTable dt = new DataTable();
			              	  dt.Load(reader);
			               	  dataSql2.DataSource = dt;
			               	  
	            			}
	            			
				
						}
					}
				}
				if(rnd==26)
				{
					string sql="select DR, Ime, Prezime from Doktori WHERE ID='26'";
					using(SQLiteCommand komanda=new SQLiteCommand(sql, konekcija))
					{
						using(SQLiteDataReader reader = komanda.ExecuteReader())
	            		{
	            			if (reader.HasRows)
	            			{
			              	  DataTable dt = new DataTable();
			              	  dt.Load(reader);
			               	  dataSql2.DataSource = dt;
			               	  
	            			}
	            			
				
						}
					}
				}
				if(rnd==27)
				{
					string sql="select DR, Ime, Prezime from Doktori WHERE ID='27'";
					using(SQLiteCommand komanda=new SQLiteCommand(sql, konekcija))
					{
						using(SQLiteDataReader reader = komanda.ExecuteReader())
	            		{
	            			if (reader.HasRows)
	            			{
			              	  DataTable dt = new DataTable();
			              	  dt.Load(reader);
			               	  dataSql2.DataSource = dt;
			               	  
	            			}
	            			
				
						}
					}
				}
				if(rnd==28)
				{
					string sql="select DR, Ime, Prezime from Doktori WHERE ID='28'";
					using(SQLiteCommand komanda=new SQLiteCommand(sql, konekcija))
					{
						using(SQLiteDataReader reader = komanda.ExecuteReader())
	            		{
	            			if (reader.HasRows)
	            			{
			              	  DataTable dt = new DataTable();
			              	  dt.Load(reader);
			               	  dataSql2.DataSource = dt;
			               	  
	            			}
	            			
				
						}
					}
				}
				if(rnd==29)
				{
					string sql="select DR, Ime, Prezime from Doktori WHERE ID='29'";
					using(SQLiteCommand komanda=new SQLiteCommand(sql, konekcija))
					{
						using(SQLiteDataReader reader = komanda.ExecuteReader())
	            		{
	            			if (reader.HasRows)
	            			{
			              	  DataTable dt = new DataTable();
			              	  dt.Load(reader);
			               	  dataSql2.DataSource = dt;
			               	  
	            			}
	            			
				
						}
					}
				}
				if(rnd==30)
				{
					string sql="select DR, Ime, Prezime from Doktori WHERE ID='3='";
					using(SQLiteCommand komanda=new SQLiteCommand(sql, konekcija))
					{
						using(SQLiteDataReader reader = komanda.ExecuteReader())
	            		{
	            			if (reader.HasRows)
	            			{
			              	  DataTable dt = new DataTable();
			              	  dt.Load(reader);
			               	  dataSql2.DataSource = dt;
			               	  
	            			}
	            			
				
						}
					}
				}
				if(rnd==31)
				{
					string sql="select DR, Ime, Prezime from Doktori WHERE ID='31'";
					using(SQLiteCommand komanda=new SQLiteCommand(sql, konekcija))
					{
						using(SQLiteDataReader reader = komanda.ExecuteReader())
	            		{
	            			if (reader.HasRows)
	            			{
			              	  DataTable dt = new DataTable();
			              	  dt.Load(reader);
			               	  dataSql2.DataSource = dt;
			               	  
	            			}
	            			
				
						}
					}
				}
				if(rnd==32)
				{
					string sql="select DR, Ime, Prezime from Doktori WHERE ID='32'";
					using(SQLiteCommand komanda=new SQLiteCommand(sql, konekcija))
					{
						using(SQLiteDataReader reader = komanda.ExecuteReader())
	            		{
	            			if (reader.HasRows)
	            			{
			              	  DataTable dt = new DataTable();
			              	  dt.Load(reader);
			               	  dataSql2.DataSource = dt;
			               	  
	            			}
	            			
				
						}
					}
				}
				if(rnd==33)
				{
					string sql="select DR, Ime, Prezime from Doktori WHERE ID='33'";
					using(SQLiteCommand komanda=new SQLiteCommand(sql, konekcija))
					{
						using(SQLiteDataReader reader = komanda.ExecuteReader())
	            		{
	            			if (reader.HasRows)
	            			{
			              	  DataTable dt = new DataTable();
			              	  dt.Load(reader);
			               	  dataSql2.DataSource = dt;
			               	  
	            			}
	            			
				
						}
					}
				}
				if(rnd==34)
				{
					string sql="select DR, Ime, Prezime from Doktori WHERE ID='34'";
					using(SQLiteCommand komanda=new SQLiteCommand(sql, konekcija))
					{
						using(SQLiteDataReader reader = komanda.ExecuteReader())
	            		{
	            			if (reader.HasRows)
	            			{
			              	  DataTable dt = new DataTable();
			              	  dt.Load(reader);
			               	  dataSql2.DataSource = dt;
			               	  
	            			}
	            			
				
						}
					}
				}
				if(rnd==35)
				{
					string sql="select DR, Ime, Prezime from Doktori WHERE ID='35'";
					using(SQLiteCommand komanda=new SQLiteCommand(sql, konekcija))
					{
						using(SQLiteDataReader reader = komanda.ExecuteReader())
	            		{
	            			if (reader.HasRows)
	            			{
			              	  DataTable dt = new DataTable();
			              	  dt.Load(reader);
			               	  dataSql2.DataSource = dt;
			               	  
	            			}
	            			
				
						}
					}
				}
				if(rnd==36)
				{
					string sql="select DR, Ime, Prezime from Doktori WHERE ID='36'";
					using(SQLiteCommand komanda=new SQLiteCommand(sql, konekcija))
					{
						using(SQLiteDataReader reader = komanda.ExecuteReader())
	            		{
	            			if (reader.HasRows)
	            			{
			              	  DataTable dt = new DataTable();
			              	  dt.Load(reader);
			               	  dataSql2.DataSource = dt;
			               	  
	            			}
	            			
				
						}
					}
				}
				if(rnd==37)
				{
					string sql="select DR, Ime, Prezime from Doktori WHERE ID='37'";
					using(SQLiteCommand komanda=new SQLiteCommand(sql, konekcija))
					{
						using(SQLiteDataReader reader = komanda.ExecuteReader())
	            		{
	            			if (reader.HasRows)
	            			{
			              	  DataTable dt = new DataTable();
			              	  dt.Load(reader);
			               	  dataSql2.DataSource = dt;
			               	  
	            			}
	            			
				
						}
					}
				}
				if(rnd==38)
				{
					string sql="select DR, Ime, Prezime from Doktori WHERE ID='38'";
					using(SQLiteCommand komanda=new SQLiteCommand(sql, konekcija))
					{
						using(SQLiteDataReader reader = komanda.ExecuteReader())
	            		{
	            			if (reader.HasRows)
	            			{
			              	  DataTable dt = new DataTable();
			              	  dt.Load(reader);
			               	  dataSql2.DataSource = dt;
			               	  
	            			}
	            			
				
						}
					}
				}
				if(rnd==39)
				{
					string sql="select DR, Ime, Prezime from Doktori WHERE ID='39'";
					using(SQLiteCommand komanda=new SQLiteCommand(sql, konekcija))
					{
						using(SQLiteDataReader reader = komanda.ExecuteReader())
	            		{
	            			if (reader.HasRows)
	            			{
			              	  DataTable dt = new DataTable();
			              	  dt.Load(reader);
			               	  dataSql2.DataSource = dt;
			               	  
	            			}
	            			
				
						}
					}
				}
				if(rnd==40)
				{
					string sql="select DR, Ime, Prezime from Doktori WHERE ID='40'";
					using(SQLiteCommand komanda=new SQLiteCommand(sql, konekcija))
					{
						using(SQLiteDataReader reader = komanda.ExecuteReader())
	            		{
	            			if (reader.HasRows)
	            			{
			              	  DataTable dt = new DataTable();
			              	  dt.Load(reader);
			               	  dataSql2.DataSource = dt;
			               	  
	            			}
	            			
				
						}
					}
				}
				if(rnd==41)
				{
					string sql="select DR, Ime, Prezime from Doktori WHERE ID='41'";
					using(SQLiteCommand komanda=new SQLiteCommand(sql, konekcija))
					{
						using(SQLiteDataReader reader = komanda.ExecuteReader())
	            		{
	            			if (reader.HasRows)
	            			{
			              	  DataTable dt = new DataTable();
			              	  dt.Load(reader);
			               	  dataSql2.DataSource = dt;
			               	  
	            			}
	            			
				
						}
					}
				}
				if(rnd==42)
				{
					string sql="select DR, Ime, Prezime from Doktori WHERE ID='42'";
					using(SQLiteCommand komanda=new SQLiteCommand(sql, konekcija))
					{
						using(SQLiteDataReader reader = komanda.ExecuteReader())
	            		{
	            			if (reader.HasRows)
	            			{
			              	  DataTable dt = new DataTable();
			              	  dt.Load(reader);
			               	  dataSql2.DataSource = dt;
			               	  
	            			}
	            			
				
						}
					}
				}
				if(rnd==43)
				{
					string sql="select DR, Ime, Prezime from Doktori WHERE ID='43'";
					using(SQLiteCommand komanda=new SQLiteCommand(sql, konekcija))
					{
						using(SQLiteDataReader reader = komanda.ExecuteReader())
	            		{
	            			if (reader.HasRows)
	            			{
			              	  DataTable dt = new DataTable();
			              	  dt.Load(reader);
			               	  dataSql2.DataSource = dt;
			               	  
	            			}
	            			
				
						}
					}
				}
				if(rnd==44)
				{
					string sql="select DR, Ime, Prezime from Doktori WHERE ID='44'";
					using(SQLiteCommand komanda=new SQLiteCommand(sql, konekcija))
					{
						using(SQLiteDataReader reader = komanda.ExecuteReader())
	            		{
	            			if (reader.HasRows)
	            			{
			              	  DataTable dt = new DataTable();
			              	  dt.Load(reader);
			               	  dataSql2.DataSource = dt;
			               	  
	            			}
	            			
				
						}
					}
				}
				if(rnd==45)
				{
					string sql="select DR, Ime, Prezime from Doktori WHERE ID='45'";
					using(SQLiteCommand komanda=new SQLiteCommand(sql, konekcija))
					{
						using(SQLiteDataReader reader = komanda.ExecuteReader())
	            		{
	            			if (reader.HasRows)
	            			{
			              	  DataTable dt = new DataTable();
			              	  dt.Load(reader);
			               	  dataSql2.DataSource = dt;
			               	  
	            			}
	            			
				
						}
					}
				}
				if(rnd==46)
				{
					string sql="select DR, Ime, Prezime from Doktori WHERE ID='46'";
					using(SQLiteCommand komanda=new SQLiteCommand(sql, konekcija))
					{
						using(SQLiteDataReader reader = komanda.ExecuteReader())
	            		{
	            			if (reader.HasRows)
	            			{
			              	  DataTable dt = new DataTable();
			              	  dt.Load(reader);
			               	  dataSql2.DataSource = dt;
			               	  
	            			}
	            			
				
						}
					}
				}
				if(rnd==47)
				{
					string sql="select DR, Ime, Prezime from Doktori WHERE ID='47'";
					using(SQLiteCommand komanda=new SQLiteCommand(sql, konekcija))
					{
						using(SQLiteDataReader reader = komanda.ExecuteReader())
	            		{
	            			if (reader.HasRows)
	            			{
			              	  DataTable dt = new DataTable();
			              	  dt.Load(reader);
			               	  dataSql2.DataSource = dt;
			               	  
	            			}
	            			
				
						}
					}
				}
				if(rnd==48)
				{
					string sql="select DR, Ime, Prezime from Doktori WHERE ID='48'";
					using(SQLiteCommand komanda=new SQLiteCommand(sql, konekcija))
					{
						using(SQLiteDataReader reader = komanda.ExecuteReader())
	            		{
	            			if (reader.HasRows)
	            			{
			              	  DataTable dt = new DataTable();
			              	  dt.Load(reader);
			               	  dataSql2.DataSource = dt;
			               	  
	            			}
	            			
				
						}
					}
				}
				if(rnd==49)
				{
					string sql="select DR, Ime, Prezime from Doktori WHERE ID='49'";
					using(SQLiteCommand komanda=new SQLiteCommand(sql, konekcija))
					{
						using(SQLiteDataReader reader = komanda.ExecuteReader())
	            		{
	            			if (reader.HasRows)
	            			{
			              	  DataTable dt = new DataTable();
			              	  dt.Load(reader);
			               	  dataSql2.DataSource = dt;
			               	  
	            			}
	            			
				
						}
					}
				}
				if(rnd==50)
				{
					string sql="select DR, Ime, Prezime from Doktori WHERE ID='50'";
					using(SQLiteCommand komanda=new SQLiteCommand(sql, konekcija))
					{
						using(SQLiteDataReader reader = komanda.ExecuteReader())
	            		{
	            			if (reader.HasRows)
	            			{
			              	  DataTable dt = new DataTable();
			              	  dt.Load(reader);
			               	  dataSql2.DataSource = dt;
			               	  
	            			}
	            			
				
						}
					}
				}
				if(rnd==51)
				{
					string sql="select DR, Ime, Prezime from Doktori WHERE ID='51'";
					using(SQLiteCommand komanda=new SQLiteCommand(sql, konekcija))
					{
						using(SQLiteDataReader reader = komanda.ExecuteReader())
	            		{
	            			if (reader.HasRows)
	            			{
			              	  DataTable dt = new DataTable();
			              	  dt.Load(reader);
			               	  dataSql2.DataSource = dt;
			               	  
	            			}
	            			
				
						}
					}
				}
				if(rnd==52)
				{
					string sql="select DR, Ime, Prezime from Doktori WHERE ID='52'";
					using(SQLiteCommand komanda=new SQLiteCommand(sql, konekcija))
					{
						using(SQLiteDataReader reader = komanda.ExecuteReader())
	            		{
	            			if (reader.HasRows)
	            			{
			              	  DataTable dt = new DataTable();
			              	  dt.Load(reader);
			               	  dataSql2.DataSource = dt;
			               	  
	            			}
	            			
				
						}
					}
				}
				if(rnd==53)
				{
					string sql="select DR, Ime, Prezime from Doktori WHERE ID='53'";
					using(SQLiteCommand komanda=new SQLiteCommand(sql, konekcija))
					{
						using(SQLiteDataReader reader = komanda.ExecuteReader())
	            		{
	            			if (reader.HasRows)
	            			{
			              	  DataTable dt = new DataTable();
			              	  dt.Load(reader);
			               	  dataSql2.DataSource = dt;
			               	  
	            			}
	            			
				
						}
					}
				}
				
				
				
				
			}
			
		}
		
		
		void Posalji(object sender, EventArgs e)
		{
			using(SQLiteConnection konekcija=new SQLiteConnection("Data Source=Baza.db; Version=3;"))
			{
				konekcija.Open();
				
				CheckBox box1=(CheckBox) this.Controls["checkBox1"];
				CheckBox box2=(CheckBox) this.Controls["checkBox2"];
				CheckBox box3=(CheckBox) this.Controls["checkBox3"];
				CheckBox box4=(CheckBox) this.Controls["checkBox4"];
				CheckBox box5=(CheckBox) this.Controls["checkBox5"];
				CheckBox box6=(CheckBox) this.Controls["checkBox6"];
				CheckBox box7=(CheckBox) this.Controls["checkBox7"];
				CheckBox box8=(CheckBox) this.Controls["checkBox8"];
				CheckBox box9=(CheckBox) this.Controls["checkBox9"];
				CheckBox box10=(CheckBox) this.Controls["checkBox10"];
				CheckBox box11=(CheckBox) this.Controls["checkBox11"];
				CheckBox box12=(CheckBox) this.Controls["checkBox12"];
				CheckBox box13=(CheckBox) this.Controls["checkBox13"];
				CheckBox box14=(CheckBox) this.Controls["checkBox14"];
				CheckBox box15=(CheckBox) this.Controls["checkBox15"];
				CheckBox box16=(CheckBox) this.Controls["checkBox16"];
				CheckBox box17=(CheckBox) this.Controls["checkBox17"];
				CheckBox box18=(CheckBox) this.Controls["checkBox18"];
				
				if(checkBox1.Checked == true)
				{
					string sql="select * from Dijagnoza WHERE Dijagnoza='Kašalj'";
					using(SQLiteCommand komanda = new SQLiteCommand(sql, konekcija))
					{
						using(SQLiteDataReader reader = komanda.ExecuteReader())
	            		{
	            			if (reader.HasRows)
	            			{
			              	  DataTable dt = new DataTable();
			              	  dt.Load(reader);
			               	  dataSql.DataSource = dt;
			               	  Pregledao();
			               	  
	            			}
				
						}
					}

					checkBox1.Checked=false;
				}
				else if(checkBox2.Checked == true)
				{
					string sql="select * from Dijagnoza WHERE Dijagnoza='Kijavica'";
					using(SQLiteCommand komanda = new SQLiteCommand(sql, konekcija))
					{
						using(SQLiteDataReader reader = komanda.ExecuteReader())
	            		{
	            			if (reader.HasRows)
	            			{
			              	  DataTable dt = new DataTable();
			              	  dt.Load(reader);
			               	  dataSql.DataSource = dt;
			               	  Pregledao();
	            			}
				
						}
					}
					checkBox2.Checked=false;
				}
				else if(checkBox3.Checked == true)
				{
					string sql="select * from Dijagnoza WHERE Dijagnoza='Grip'";
					using(SQLiteCommand komanda = new SQLiteCommand(sql, konekcija))
					{
						using(SQLiteDataReader reader = komanda.ExecuteReader())
	            		{
	            			if (reader.HasRows)
	            			{
			              	  DataTable dt = new DataTable();
			              	  dt.Load(reader);
			               	  dataSql.DataSource = dt;
			               	  Pregledao();
	            			}
				
						}
					}
					checkBox3.Checked=false;
				}
				else if(checkBox4.Checked == true)
				{
					string sql="select * from Dijagnoza WHERE Dijagnoza='Dijareja'";
					using(SQLiteCommand komanda = new SQLiteCommand(sql, konekcija))
					{
						using(SQLiteDataReader reader = komanda.ExecuteReader())
	            		{
	            			if (reader.HasRows)
	            			{
			              	  DataTable dt = new DataTable();
			              	  dt.Load(reader);
			               	  dataSql.DataSource = dt;
			               	  Pregledao();
	            			}
				
						}
					}
					checkBox4.Checked=false;
				}
				else if(checkBox5.Checked == true)
				{
					string sql="select * from Dijagnoza WHERE Dijagnoza='Migrena'";
					using(SQLiteCommand komanda = new SQLiteCommand(sql, konekcija))
					{
						using(SQLiteDataReader reader = komanda.ExecuteReader())
	            		{
	            			if (reader.HasRows)
	            			{
			              	  DataTable dt = new DataTable();
			              	  dt.Load(reader);
			               	  dataSql.DataSource = dt;
			               	  Pregledao();
	            			}
				
						}
					}
					checkBox5.Checked=false;
				}
				else if(checkBox6.Checked == true)
				{
					string sql="select * from Dijagnoza WHERE Dijagnoza='Bronhitis'";
					using(SQLiteCommand komanda = new SQLiteCommand(sql, konekcija))
					{
						using(SQLiteDataReader reader = komanda.ExecuteReader())
	            		{
	            			if (reader.HasRows)
	            			{
			              	  DataTable dt = new DataTable();
			              	  dt.Load(reader);
			               	  dataSql.DataSource = dt;
			               	  Pregledao();
	            			}
				
						}
					}
					checkBox6.Checked=false;
				}
				else if(checkBox7.Checked == true)
				{
					string sql="select * from Dijagnoza WHERE Dijagnoza='Stomačni virus'";
					using(SQLiteCommand komanda = new SQLiteCommand(sql, konekcija))
					{
						using(SQLiteDataReader reader = komanda.ExecuteReader())
	            		{
	            			if (reader.HasRows)
	            			{
			              	  DataTable dt = new DataTable();
			              	  dt.Load(reader);
			               	  dataSql.DataSource = dt;
			               	  Pregledao();
	            			}
				
						}
					}
					checkBox7.Checked=false;
				}
				else if(checkBox8.Checked == true)
				{
					string sql="select * from Dijagnoza WHERE Dijagnoza='Upala grla'";
					using(SQLiteCommand komanda = new SQLiteCommand(sql, konekcija))
					{
						using(SQLiteDataReader reader = komanda.ExecuteReader())
	            		{
	            			if (reader.HasRows)
	            			{
			              	  DataTable dt = new DataTable();
			              	  dt.Load(reader);
			               	  dataSql.DataSource = dt;
			               	  Pregledao();
	            			}
				
						}
					}
					checkBox8.Checked=false;
				}
				else if(checkBox9.Checked == true)
				{
					string sql="select * from Dijagnoza WHERE Dijagnoza='Bronhitis'";
					using(SQLiteCommand komanda = new SQLiteCommand(sql, konekcija))
					{
						using(SQLiteDataReader reader = komanda.ExecuteReader())
	            		{
	            			if (reader.HasRows)
	            			{
			              	  DataTable dt = new DataTable();
			              	  dt.Load(reader);
			               	  dataSql.DataSource = dt;
			               	  Pregledao();
	            			}
				
						}
					}
					checkBox9.Checked=false;
				}
				else if(checkBox10.Checked == true)
				{
					string sql="select * from Dijagnoza WHERE Dijagnoza='Upala krajnika'";
					using(SQLiteCommand komanda = new SQLiteCommand(sql, konekcija))
					{
						using(SQLiteDataReader reader = komanda.ExecuteReader())
	            		{
	            			if (reader.HasRows)
	            			{
			              	  DataTable dt = new DataTable();
			              	  dt.Load(reader);
			               	  dataSql.DataSource = dt;
			               	  Pregledao();
	            			}
				
						}
					}
					checkBox10.Checked=false;
				}
				else if(checkBox11.Checked == true)
				{
					string sql="select * from Dijagnoza WHERE Dijagnoza='Upala uha'";
					using(SQLiteCommand komanda = new SQLiteCommand(sql, konekcija))
					{
						using(SQLiteDataReader reader = komanda.ExecuteReader())
	            		{
	            			if (reader.HasRows)
	            			{
			              	  DataTable dt = new DataTable();
			              	  dt.Load(reader);
			               	  dataSql.DataSource = dt;
			               	  Pregledao();
	            			}
				
						}
					}
					checkBox11.Checked=false;
				}
				else if(checkBox12.Checked == true)
				{
					string sql="select * from Dijagnoza WHERE Dijagnoza='Alergija'";
					using(SQLiteCommand komanda = new SQLiteCommand(sql, konekcija))
					{
						using(SQLiteDataReader reader = komanda.ExecuteReader())
	            		{
	            			if (reader.HasRows)
	            			{
			              	  DataTable dt = new DataTable();
			              	  dt.Load(reader);
			               	  dataSql.DataSource = dt;
			               	  Pregledao();
	            			}
				
						}
					}
					checkBox12.Checked=false;
				}
				else if(checkBox13.Checked == true)
				{
					string sql="select * from Dijagnoza WHERE Dijagnoza='Gorušica'";
					using(SQLiteCommand komanda = new SQLiteCommand(sql, konekcija))
					{
						using(SQLiteDataReader reader = komanda.ExecuteReader())
	            		{
	            			if (reader.HasRows)
	            			{
			              	  DataTable dt = new DataTable();
			              	  dt.Load(reader);
			               	  dataSql.DataSource = dt;
			               	  Pregledao();
	            			}
				
						}
					}
					checkBox13.Checked=false;
				}
				else if(checkBox14.Checked == true)
				{
					string sql="select * from Dijagnoza WHERE Dijagnoza='Pritisak'";
					using(SQLiteCommand komanda = new SQLiteCommand(sql, konekcija))
					{
						using(SQLiteDataReader reader = komanda.ExecuteReader())
	            		{
	            			if (reader.HasRows)
	            			{
			              	  DataTable dt = new DataTable();
			              	  dt.Load(reader);
			               	  dataSql.DataSource = dt;
			               	  Pregledao();
	            			}
				
						}
					}
					checkBox14.Checked=false;
				}
				else if(checkBox15.Checked == true)
				{
					string sql="select * from Dijagnoza WHERE Dijagnoza='Astma'";
					using(SQLiteCommand komanda = new SQLiteCommand(sql, konekcija))
					{
						using(SQLiteDataReader reader = komanda.ExecuteReader())
	            		{
	            			if (reader.HasRows)
	            			{
			              	  DataTable dt = new DataTable();
			              	  dt.Load(reader);
			               	  dataSql.DataSource = dt;
			               	  Pregledao();
	            			}
				
						}
					}
					checkBox15.Checked=false;
				}
				else if(checkBox16.Checked == true)
				{
					string sql="select * from Dijagnoza WHERE Dijagnoza='Stomačni virus'";
					using(SQLiteCommand komanda = new SQLiteCommand(sql, konekcija))
					{
						using(SQLiteDataReader reader = komanda.ExecuteReader())
	            		{
	            			if (reader.HasRows)
	            			{
			              	  DataTable dt = new DataTable();
			              	  dt.Load(reader);
			               	  dataSql.DataSource = dt;
			               	  Pregledao();
	            			}
				
						}
					}
					checkBox16.Checked=false;
				}
				else if(checkBox17.Checked == true)
				{
					string sql="select * from Dijagnoza WHERE Dijagnoza='Šećer'";
					using(SQLiteCommand komanda = new SQLiteCommand(sql, konekcija))
					{
						using(SQLiteDataReader reader = komanda.ExecuteReader())
	            		{
	            			if (reader.HasRows)
	            			{
			              	  DataTable dt = new DataTable();
			              	  dt.Load(reader);
			               	  dataSql.DataSource = dt;
			               	  Pregledao();
	            			}
				
						}
					}
					checkBox17.Checked=false;
				}
				else if(checkBox18.Checked == true)
				{
					string sql="select * from Dijagnoza WHERE Dijagnoza='Upala sinusa'";
					using(SQLiteCommand komanda = new SQLiteCommand(sql, konekcija))
					{
						using(SQLiteDataReader reader = komanda.ExecuteReader())
	            		{
	            			if (reader.HasRows)
	            			{
			              	  DataTable dt = new DataTable();
			              	  dt.Load(reader);
			               	  dataSql.DataSource = dt;
			               	  Pregledao();
	            			}
				
						}
					}
					checkBox18.Checked=false;
				}
				else
				{
					MessageBox.Show("Morate izabrati neku od opcija.");
				}
			}
		}
				
				
		void Back(object sender, EventArgs e)
		{
			MainForm main = new MainForm();
			main.Show();
			this.Hide();
		}		
				
				
		void SimptomiFormClosing(object sender, FormClosingEventArgs e)
		{
			MainForm main = new MainForm();
			main.Show();
			this.Hide();
		}
		
		
	
	}
	
}
		
