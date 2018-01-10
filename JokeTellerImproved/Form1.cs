using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JokeTellerImproved
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		public string RandomSetup()
		{
			Random rnd = new Random();
			int jokeNumber = rnd.Next(1, 6);
			string setup = "";

			switch (jokeNumber)
			{
				case 1:
					setup = "Why did the Chicken cross the road?";
					break;
				case 2:
					setup = "Who shot the sherrif?";
					break;
				case 3:
					setup = "I almost had a 3some last night.";
					break;
				case 4:
					setup = "What's black, white, and read all over?";
					break;
				default:
					setup = "Where am I?";
					break;
			}
			return txtJoke.Text= setup;
		}

		public string Punchline(string setup)
		{
			setup = txtJoke.Text;
			string punchLine = "";

			switch (setup)
			{
				case "Why did the Chicken cross the road?":
					punchLine = "To get to the other side!";
					break;
				case "Who shot the sherrif?":
					punchLine = "Certainly not Bob Marley!";
					break;
				case "I almost had a 3some last night.":
					punchLine = "I just needed two more people!";
					break;
				case "What's black, white, and read all over?":
					punchLine = "A newspaper!";
					break;
				default:
					punchLine = "How the hell should I know?";
					break;
			}
			return txtJoke.Text = punchLine;
		}
		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void btnSetup_Click(object sender, EventArgs e)
		{
			RandomSetup();
			btnPunchline.Enabled = true;
		}

		private void btnPunchline_Click(object sender, EventArgs e)
		{
			Punchline(txtJoke.Text);
			btnPunchline.Enabled = false;
		}

		private void btnExit_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			txtJoke.Text = "";
			btnPunchline.Enabled = false;
		}
	}
}
