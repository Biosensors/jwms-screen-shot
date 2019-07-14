using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace screenshot
{
	public partial class Form1 : Form
	{
		/// <summary>
		/// 用于保存截取的整个屏幕的图片
		/// </summary>
		protected Bitmap screenImage;

		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			textBox1.Text = "windth:" + Screen.AllScreens[0].Bounds.Width + "  Hight:" + Screen.AllScreens[0].Bounds.Height;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			load_1();
			ExecCutImage(true, false);
		}

		private void load_1()
		{
			Bitmap bkImage = new Bitmap(Screen.AllScreens[0].Bounds.Width, Screen.AllScreens[0].Bounds.Height);
			Graphics g = Graphics.FromImage(bkImage);
			g.CopyFromScreen(new Point(0, 0), new Point(0, 0), Screen.AllScreens[0].Bounds.Size, CopyPixelOperation.SourceCopy);
			screenImage = (Bitmap)bkImage.Clone();
		}
		/// <summary>
		/// 执行截图,将选定区域的图片保存到剪贴板
		/// </summary>
		/// <param name="saveToDisk">
		/// 是否将图片保存到磁盘
		/// </param>
		private void ExecCutImage(bool saveToDisk, bool uploadImage) //bool saveToDisk = false, bool uploadImage = false
		{
			// 如果图片获取区域不可见,则退出保存图片过程
			//if (!this.lbl_CutImage.Visible) { return; }
			Rectangle srcRect = new Rectangle();
			srcRect.X = 2 + 100;
			srcRect.Y = 2 + 100;
			srcRect.Width = 1500;
			srcRect.Height = 800;
			//Rectangle destRect = new Rectangle(0, 0, srcRect.Width, srcRect.Height);
			//Bitmap bmp = new Bitmap(srcRect.Width, srcRect.Height);
			Rectangle destRect = new Rectangle(0, 0, Screen.AllScreens[0].Bounds.Width, Screen.AllScreens[0].Bounds.Height);
			Bitmap bmp = new Bitmap(Screen.AllScreens[0].Bounds.Width, Screen.AllScreens[0].Bounds.Height);
			Graphics g = Graphics.FromImage(bmp);
			g.DrawImage(this.screenImage, destRect, srcRect, GraphicsUnit.Pixel);
			//bmp.Save("D:\\其他工作或项目\\2019年其他项目\\工序图片留样项目\\b.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
			bmp.Save(textBox_saveDir.Text + "\\" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + " _截图.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
			//Clipboard.SetImage(bmp);

			//ExitCutImage(true);
		}

		private void Form2_Load(object sender, EventArgs e)
		{

		}
		/// <summary>
		/// 浏览按钮事件处理程序
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
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
		//部分截图
		private void button4_Click(object sender, EventArgs e)
		{
			load_1();
			ExecCutImage_parital(true, false);
		}
		/// <summary>
		/// 执行截图,将选定区域的图片保存到剪贴板
		/// </summary>
		/// <param name="saveToDisk">
		/// 是否将图片保存到磁盘
		/// </param>
		private void ExecCutImage_parital(bool saveToDisk, bool uploadImage) //bool saveToDisk = false, bool uploadImage = false
		{
			// 如果图片获取区域不可见,则退出保存图片过程
			//if (!this.lbl_CutImage.Visible) { return; }
			Rectangle srcRect = new Rectangle();
			srcRect.X = 2 + 100;
			srcRect.Y = 2 + 100;
			srcRect.Width = 1500;
			srcRect.Height = 800;
			//Rectangle destRect = new Rectangle(0, 0, srcRect.Width, srcRect.Height);
			//Bitmap bmp = new Bitmap(srcRect.Width, srcRect.Height);
			Rectangle destRect = new Rectangle(2, 2, Screen.AllScreens[0].Bounds.Width - 10, Screen.AllScreens[0].Bounds.Height - 10);
			Bitmap bmp = new Bitmap(Screen.AllScreens[0].Bounds.Width - 10 - 2, Screen.AllScreens[0].Bounds.Height - 10 - 2);
			Graphics g = Graphics.FromImage(bmp);
			g.DrawImage(this.screenImage, destRect, srcRect, GraphicsUnit.Pixel);
			//bmp.Save("D:\\其他工作或项目\\2019年其他项目\\工序图片留样项目\\b.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
			bmp.Save(textBox_saveDir.Text + "\\" + DateTime.Now.ToString("yyyyMMdd_HHmmss") + " _截图.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
			//Clipboard.SetImage(bmp);

			//ExitCutImage(true);
		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		
	}
}
