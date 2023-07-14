using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quisioner
{
	public partial class MyQuiz : Form
	{
		public MyQuiz()
		{
			InitializeComponent();
			lblResult.Visible = false;
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			txtName.Text = ""; 
			rbtnMale.Checked = false; rbtnFemale.Checked = false;
			cmboxOccupation.SelectedIndex = -1;
			ckboxCsharp.Checked = false; ckboxCplus.Checked = false;
			ckboxJava.Checked = false; ckboxPython.Checked = false;
			lblResult.Visible = false;

		}

		private void btnSend_Click(object sender, EventArgs e)
		{
			string hasil = ""; string name = txtName.Text; string gender = "";
			string occupation = cmboxOccupation.Text; string skill = "";

			if (rbtnMale.Checked)
			{
				gender = "Male";
			} else if (rbtnFemale.Checked)
			{
				gender = "Female";
			} else
			{
				MessageBox.Show("Please Choose Your Gender.");
			}

			if (String.IsNullOrEmpty(occupation))
			{
				MessageBox.Show("Please Choose Your current Occupation.");
			}

			if (ckboxCsharp.Checked)
			{
				skill += "C#, ";
			}

			if (ckboxCplus.Checked)
			{
				skill += "C++, ";
			}

			if (ckboxJava.Checked)
			{
				skill += "Java, ";
			}

			if (ckboxPython.Checked)
			{
				skill += "Python, ";
			}

			if (String.IsNullOrEmpty(skill))
			{
				MessageBox.Show("Please Choose Your Programming Skill");
			}

			if (!String.IsNullOrEmpty(name) || !String.IsNullOrEmpty(gender) || !String.IsNullOrEmpty(occupation) || !String.IsNullOrEmpty(skill) )
			{
				hasil = "Name: " + name + "\n";
				hasil += "Gender: " + gender + "\n";
				hasil += "Occupation: " + occupation + "\n";
				hasil += "Programming Skills: " + skill + "\n";

				lblResult.Visible = true;
				lblResult.Text = hasil;
			}




		}
	}
}
