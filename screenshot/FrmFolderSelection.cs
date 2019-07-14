using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace screenshot
{
	public partial class FrmFolderSelection : Form
	{
		public FrmFolderSelection()
		{
			InitializeComponent();
		}

		private void button3_Click(object sender, EventArgs e)
		{
			FolderBrowserDialog fbd = new FolderBrowserDialog();
			fbd.Description = "请选择屏幕截图的保存目录：";
			fbd.ShowNewFolderButton = true;
			fbd.RootFolder = Environment.SpecialFolder.MyComputer;
			fbd.SelectedPath = textBox_saveDir.Text;
			if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				textBox_saveDir.Text = fbd.SelectedPath;
				
			}
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (textBox_saveDir.Text == "")
			{
				MessageBox.Show("请选择目录！","JWMS");
				return;
			}
			Form parent1 = (Form)this.Owner;
			parent1.Controls["btnFolder"].Tag = textBox_saveDir.Text;
			this.Hide();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void FrmFolderSelection_Load(object sender, EventArgs e)
		{
			textBox_saveDir.Text = this.Tag.ToString();
		}
	}
}
