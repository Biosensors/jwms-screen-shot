using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace screenshot
{
	public partial class FrmPictView : Form
	{
		
		public FrmPictView()
		{
			InitializeComponent();
		}
		public FrmPictView(Image image)
		{
			InitializeComponent();
			pictureBox1.Image = image;


			pictureBox1.Left = 0;
			pictureBox1.Top = 0;

			pictureBox1.Width = (int)(Screen.AllScreens[0].Bounds.Width * 0.8);

			pictureBox1.Height = (int)(pictureBox1.Width * ((float)pictureBox1.Image.Height / pictureBox1.Image.Width));

			this.Width = pictureBox1.Width + 20;
			this.Height = pictureBox1.Height + 50;
		}

		private void FrmPictView_Load(object sender, EventArgs e)
		{
			
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void FrmPictView_Resize(object sender, EventArgs e)
		{
			//pictureBox1.Height = this.Height;
			//pictureBox1.Width = this.Width;

		}
	}
}
