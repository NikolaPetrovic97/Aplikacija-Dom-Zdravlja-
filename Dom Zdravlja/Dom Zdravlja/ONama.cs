/*
 * Created by SharpDevelop.
 * User: Petrovici
 * Date: 20.12.2018
 * Time: 00:54
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Dom_Zdravlja
{
	/// <summary>
	/// Description of ONama.
	/// </summary>
	public partial class ONama : Form
	{
		public ONama()
		{
			
			InitializeComponent();
			
			
		}
		void ONamaFormClosing(object sender, FormClosingEventArgs e)
		{
			MainForm main = new MainForm();
			main.Show();
			this.Hide();
		}
	}
}
