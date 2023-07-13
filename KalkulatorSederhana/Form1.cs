using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KalkulatorSederhana
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		
		private void btnTambah_Click(object sender, EventArgs e)
		{
			int angka1 = Int32.Parse(txt1.Text);
			int angka2 = Int32.Parse(txt2.Text);
			int hasil = angka1 + angka2;

			txt3.Text = hasil.ToString();
		}

		private void btnKurang_Click(object sender, EventArgs e)
		{
			int angka1 = Int32.Parse(txt1.Text);
			int angka2 = Int32.Parse(txt2.Text);
			int hasil = angka1 - angka2;

			txt3.Text = hasil.ToString();
		}

		private void btnKali_Click(object sender, EventArgs e)
		{
			int angka1 = Int32.Parse(txt1.Text);
			int angka2 = Int32.Parse(txt2.Text);
			int hasil = angka1 * angka2;

			txt3.Text = hasil.ToString();
		}

		private void btnBagi_Click(object sender, EventArgs e)
		{
			double angka1 = double.Parse(txt1.Text);
			double angka2 = double.Parse(txt2.Text);
			double hasil = angka1 / angka2;

			txt3.Text = hasil.ToString();
			MessageBox.Show(hasil.ToString());
		}

		private void btnReset_Click(object sender, EventArgs e)
		{
			txt1.Text = "";
			txt2.Text = "";
			txt3.Text = "";

		}

		
	}
}
