/*
 * Created by SharpDevelop.
 * User: Petrovici
 * Date: 20.12.2018
 * Time: 00:53
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
	/// Description of KontaktCentar.
	/// </summary>
	public partial class KontaktCentar : Form
	{
		public KontaktCentar()
		{
			
			InitializeComponent();
			
			
			
		}
		
		void Back(object sender, EventArgs e)
		{
			MainForm main = new MainForm();
			main.Show();
			this.Hide();
		}
		
		
		void KontaktCentarFormClosing(object sender, FormClosingEventArgs e)
		{
			MainForm main = new MainForm();
			main.Show();
			this.Hide();
		}
		
	}
}
