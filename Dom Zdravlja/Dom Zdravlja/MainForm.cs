﻿/*
 * Created by SharpDevelop.
 * User: Petrovici
 * Date: 17.12.2018
 * Time: 17:25
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Dom_Zdravlja
{
	/// <summary>
	/// Description of Log_in.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			
			InitializeComponent();
			
			
		}
		void Simptomi(object sender, EventArgs e)
		{
			Button button_Simptomi = (Button) this.Controls ["Simptomi"];
			Simptomi simptomi = new Simptomi();
			simptomi.Show();
			this.Hide();
		}
		void IstorijaBolesti(object sender, EventArgs e)
		{
			Button button_IstorijaBolesti = (Button) this.Controls ["IstorijaBolesti"];
			IstorijaBolesti istorija_bolesti = new IstorijaBolesti();
			istorija_bolesti.Show();
			this.Hide();
		}
		void Doktori(object sender, EventArgs e)
		{
			Button button_Doktori = (Button) this.Controls ["Doktori"];
			Doktori doktori = new Doktori();
			doktori.Show();
			this.Hide();
		}
		void KontaktCentar(object sender, EventArgs e)
		{
			Button button_KontaktCentar = (Button) this.Controls ["KontaktCentar"];
			KontaktCentar kontakt_centar = new KontaktCentar();
			kontakt_centar.Show();
			this.Hide();
		}
		void ONama(object sender, EventArgs e)
		{
			Button button_ONama = (Button) this.Controls ["ONama"];
			ONama o_nama = new ONama();
			o_nama.Show();
			this.Hide();
		}
		void InfoCentar(object sender, EventArgs e)
		{
			Button button_InfoCentar = (Button) this.Controls ["InfoCentar"];
			InfoCentar info_centar = new InfoCentar();
			info_centar.Show();
			this.Hide();
		}
		 public void Odjava(object sender, EventArgs e)
		{
			Button button_Odjava = (Button) this.Controls ["LogIn"];
			LogIn log_in = new LogIn();
			log_in.Show();
			this.Hide();
		}
		void MainFormFormClosing(object sender, FormClosingEventArgs e)
		{
			LogIn log_in = new LogIn();
			log_in.Show();
			this.Hide();
		}
		
		
	}
}