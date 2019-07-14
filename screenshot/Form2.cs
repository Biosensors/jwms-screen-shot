using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace screenshot
{
	public partial class Form2 : Form
	{
		#region 热键及背景
		/// <summary>
		/// 向全局原子表添加一个字符串，并返回这个字符串的唯一标识符（原子ATOM）。
		/// </summary>
		/// <param name="lpString">自己设定的一个字符串</param>
		/// <returns></returns>
		[System.Runtime.InteropServices.DllImport("Kernel32.dll")]
		public static extern Int32 GlobalAddAtom(string lpString);

		/// <summary>
		/// 注册热键
		/// </summary>
		/// <param name="hWnd"></param>
		/// <param name="id"></param>
		/// <param name="fsModifiers"></param>
		/// <param name="vk"></param>
		/// <returns></returns>
		[System.Runtime.InteropServices.DllImport("user32.dll")]
		public static extern bool RegisterHotKey(IntPtr hWnd, int id, uint fsModifiers, Keys vk);
		

		/// <summary>
		/// 取消热键注册
		/// </summary>
		/// <param name="hWnd"></param>
		/// <param name="id"></param>
		/// <returns></returns>
		[System.Runtime.InteropServices.DllImport("user32.dll")]
		public static extern bool UnregisterHotKey(IntPtr hWnd, int id);

		/// <summary>
		/// 热键ID
		/// </summary>
		public int hotKeyId = 100;

		/// <summary>
		/// 热键模式:0=Ctrl + Alt + A, 1=Ctrl + Shift + A
		/// </summary>
		public int HotKeyMode = 0;

		/// <summary>
		/// 控制键的类型
		/// </summary>
		public enum KeyModifiers : uint
		{
			None = 0,
			Alt = 1,
			Control = 2,
			Shift = 4,
			Windows = 8
		}

		/// <summary>
		/// 用于保存截取的整个屏幕的图片
		/// </summary>		
		#endregion
		/// <summary>
		/// 用于保存截取的整个屏幕的图片
		/// </summary>
		protected Bitmap screenImage;
		private string[] sPictPathArr;
		private int iQtyForOneProduct=0;//图片数量

		private int iWindowHight = 0;
		private int iWindowWidth = 0;
		private int chkPreviewLeft = 0;
		private int chkAboveAllLeft = 0;
		private int btnCloseLeft = 0;
		public string sPath = "";

		/// <summary>
		/// 处理快捷键事件
		/// </summary>
		/// <param name="m"></param>
		protected override void WndProc(ref Message m)
		{
			//if (m.Msg == 0x0014)
			//{
			//    return; // 禁掉清除背景消息
			//}
			const int WM_HOTKEY = 0x0312;
			switch (m.Msg)
			{
				case WM_HOTKEY:
					//label1.Text = "Ctrl+Control+a " + DateTime.Now.ToString();
					if (iQtyForOneProduct >= 3)
					{
						lblInforMessage(Color.Red, "对该序号产品最多保留三张图片！");
						WriteLog("尝试多余三次的图片留存！");
						return;
					}
					else if (lblBarcode.Text == "")
					{
						lblInforMessage(Color.Red, "请先扫描产品序号！");
						return;
					}
					saveScreenShot();
					loadPict();
					break;
				default:
					break;
			}
			base.WndProc(ref m);
		}
		public Form2()
		{
			InitializeComponent();
		}

		private void ckhAboveAll_CheckedChanged(object sender, EventArgs e)
		{
			//this.TopMost()=
			if (ckhAboveAll.Checked)
				this.TopMost = true;
			else
				this.TopMost = false;
		}
		/// <summary>
		/// 触发器
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void timer1_Tick(object sender, EventArgs e)
		{
			if (textBox1.Focused == false)
			{
				textBox1.Focus();				
			}			
		}

		private void Form2_Load(object sender, EventArgs e)
		{
			WriteLog(">>>>>>>>>>>>>>登陆了系统>>>>>>>>>>>>>>");
			ckhAboveAll.Checked = true;

			lblInfor.Text = "";
			chkPreview.Checked = true;
			iWindowHight = this.Height;
			iWindowWidth = this.Width;
			chkPreviewLeft = chkPreview.Left;
			chkAboveAllLeft = ckhAboveAll.Left;
			btnCloseLeft = btnClose.Left;
			label1.ForeColor = Color.Red;

			sPath = getPathFromIniFile();
			txtPath.Text = sPath;
			sPictPathArr = new string[3];

			//注册快捷键
			//注：HotKeyId的合法取之范围是0x0000到0xBFFF之间，GlobalAddAtom函数得到的值在0xC000到0xFFFF之间，所以减掉0xC000来满足调用要求。
			this.hotKeyId = GlobalAddAtom("Screenshot") - 0xC000;
			if (this.hotKeyId == 0)
			{
				//如果获取失败，设定一个默认值；
				this.hotKeyId = 0xBFFE;
			}

			if (this.HotKeyMode == 0)
			{
				RegisterHotKey(Handle, hotKeyId, (uint)KeyModifiers.Control | (uint)KeyModifiers.Alt, Keys.A);
			}
			else
			{
				RegisterHotKey(Handle, hotKeyId, (uint)KeyModifiers.Control | (uint)KeyModifiers.Shift, Keys.A);
			}			
		}
		/// <summary>
		/// save path to ini file
		/// </summary>
		/// <param name="sPath"></param>
		private void setSavePathToIniFile(string sPath)
		{
			IniFiles ini = new IniFiles(Application.StartupPath + @"\config.ini");
			ini.IniWriteValue("生产工序截图存档", "pictPath", sPath);
			ini.IniWriteValue("生产工序截图存档", "date", DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss"));
		}
		private string getPathFromIniFile() 
		{
			IniFiles ini = new IniFiles(Application.StartupPath + @"\config.ini");
			//ini.IniWriteValue("工序数据留存", "pictPath", sPath);
			//ini.IniWriteValue("工序数据留存", "date", DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss"));
			return ini.IniReadValue("生产工序截图存档", "pictPath");
		}

		//private void addLog()
		//{
		//	IniFiles ini = new IniFiles(Application.StartupPath + @"\log.ini");
		//	ini.IniWriteValue("生产工序截图存档",  sPath);

		//}




		private void textBox1_TextChanged(object sender, EventArgs e)
		{
			//System.Diagnostics.Debug.Print( textBox1.Text + "/n");
		}

		private void textBox1_AcceptsTabChanged(object sender, EventArgs e)
		{
			//System.Diagnostics.Debug.Print("textBox1_AcceptsTabChanged");
		}

		private void textBox1_TabIndexChanged(object sender, EventArgs e)
		{
			//System.Diagnostics.Debug.Print("textBox1_TabIndexChanged ");
		}

		private void textBox1_TabStopChanged(object sender, EventArgs e)
		{
			//System.Diagnostics.Debug.Print("textBox1_TabStopChanged");
		}

		/// <summary>
		/// 设置消息
		/// </summary>
		private void lblInforMessage(Color foreColor,String sMsg)
		{
			lblInfor.ForeColor = foreColor;
			lblInfor.Text = sMsg;
			//lblInfor.Text = "对该序号产品最多保留三张图片！";
		}

		private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == 13)
			{
				if (textBox1.Text == "")
				{
					//if (iQtyForOneProduct >=3)
					//{
					//	lblInforMessage(Color.Red, "对该序号产品最多保留三张图片！");
					//	WriteLog("尝试多余三次的图片留存！");
					//	return;
					//}else if (lblBarcode.Text == "")
					//{
					//	lblInforMessage(Color.Red, "请先扫描产品序号！");
					//	return;
					//}					
					//saveScreenShot();
					//loadPict();					
				}
				else
				{
					barCodeScan();
					textBox1.Text = "";
					clrearPict();					
					lblInforMessage(Color.Black, "序号扫描成功！");
					WriteLog("扫描序号：" +lblBarcode.Text);
				}
			//	System.Diagnostics.Debug.Print("textBox1_KeyPress Enter Pressed!");
			}
			else
			{
				//System.Diagnostics.Debug.Print("textBox1_KeyPress " + e.KeyChar);
			}
		}
		/// <summary>
		/// 条码扫描
		/// </summary>
		private void barCodeScan()
		{
			lblBarcode.Text = textBox1.Text;
			iQtyForOneProduct = 0;//一个产品的图片数
		}

		private void saveScreenShot()
		{
			if (txtPath.Text == "")
			{
				//MessageBox.Show("请先设置保存的目录！","JWMS",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
				
				
				lblInforMessage(Color.Red, "请先设置保存的目录！");
				return;
			}

			try
			{
				iQtyForOneProduct++;
				copyScreen();
				ExecCutImage(true, false);
				WriteLog("保存图片成功：" +  sPictPathArr[iQtyForOneProduct - 1]);
			}
			catch(Exception e)
			{
				iQtyForOneProduct--;
				System.Diagnostics.Debug.Print("产生了错误： " + e.Message);
				lblInforMessage(Color.Red, "系统错误：" + e.Message);
				WriteLog("系统错误："+e.Message);
			}
			
		}

		private void button1_Click(object sender, EventArgs e)
		{
			//pictureBox2.LoadAsync("D:\\其他工作或项目\\2019年其他项目\\工序图片留样项目\\捆绑图片测试\\123\\20190403_155541 _截图.bmp");
		}

	

		private void chkPreview_CheckedChanged(object sender, EventArgs e)
		{
			if (iWindowHight == 0)
				return;

			if (chkPreview.Checked)
			{
				this.Height = iWindowHight ;
				this.Width = iWindowWidth;
				chkPreview.Left = chkPreviewLeft;
				ckhAboveAll.Left = chkAboveAllLeft;
				btnClose.Left = btnCloseLeft;
			}
			else
			{
				this.Height = iWindowHight - 180;
				this.Width = iWindowWidth - 70;
				//chkPreview.Left = chkPreviewLeft - 70;
				//ckhAboveAll.Left = chkAboveAllLeft - 70;
				btnClose.Left= btnClose.Left-70;

			}
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			WriteLog("<<<<<<<<<<<<<关闭了系统<<<<<<<<<<<<<");
			this.Close();
		}
		

		
		private void btnFolder_Click(object sender, EventArgs e)
		{
			btnFolder.Tag = "";
			FrmFolderSelection frmFolderSelection = new FrmFolderSelection();
			frmFolderSelection.Tag = sPath;
			frmFolderSelection.ShowDialog(this);
			
			if (btnFolder.Tag.ToString() != "")
			{
				txtPath.Text = btnFolder.Tag.ToString();
				sPath = btnFolder.Tag.ToString();
				setSavePathToIniFile(sPath);
				WriteLog("将目录设置为：" + sPath);
			}
			textBox1.Focus();

		}
		private void copyScreen()
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
			//Rectangle srcRect = new Rectangle();
			//srcRect.X = 2 + 100;
			//srcRect.Y = 2 + 100;
			//srcRect.Width = 1500;
			//srcRect.Height = 800;
			//Rectangle destRect = new Rectangle(0, 0, srcRect.Width, srcRect.Height);
			//Bitmap bmp = new Bitmap(srcRect.Width, srcRect.Height);
			Rectangle destRect = new Rectangle(0, 0, Screen.AllScreens[0].Bounds.Width, Screen.AllScreens[0].Bounds.Height);
			Bitmap bmp = new Bitmap(Screen.AllScreens[0].Bounds.Width, Screen.AllScreens[0].Bounds.Height);
			Graphics g = Graphics.FromImage(bmp);
			//g.DrawImage(this.screenImage, destRect, srcRect, GraphicsUnit.Pixel);
			g.DrawImage(this.screenImage, destRect);
			//bmp.Save("D:\\其他工作或项目\\2019年其他项目\\工序图片留样项目\\b.bmp", System.Drawing.Imaging.ImageFormat.Bmp);
			string sPictName = lblBarcode.Text+"_"+ DateTime.Now.ToString("yyMMddHHmmss") + "_" + iQtyForOneProduct + ".bmp";
			//bmp.Save(sPath + "\\" + sPictName, System.Drawing.Imaging.ImageFormat.Bmp);
			bmp.Save(sPath + "\\" + sPictName, System.Drawing.Imaging.ImageFormat.Jpeg);
			sPictPathArr[iQtyForOneProduct - 1] = sPath + "\\" + sPictName;						
			lblInforMessage(Color.Black, "图片[" + sPictName + "]保存成功！");
			//Clipboard.SetImage(bmp);

			//ExitCutImage(true);
		}
		/// <summary>
		/// Load picture to window controls
		/// </summary>
		private void loadPict()
		{
			
			if (iQtyForOneProduct == 0)
			{
				return;
			}
			switch (iQtyForOneProduct){
				case 1:
					pictureBox1.LoadAsync( sPictPathArr[0]);
					return;
				case 2:
					pictureBox2.LoadAsync( sPictPathArr[1]);
					return;
				case 3:
					pictureBox3.LoadAsync( sPictPathArr[2]);
					return;

			}
		//	pictureBox2.LoadAsync("D:\\其他工作或项目\\2019年其他项目\\工序图片留样项目\\捆绑图片测试\\123\\20190403_155541 _截图.bmp");
		}

		private void clrearPict()
		{
			pictureBox1.Image = null;
			pictureBox2.Image = null;
			pictureBox3.Image = null;
		}

		private void pictureBox1_Click(object sender, EventArgs e)
		{
			if (pictureBox1.Image == null){
				return;
			}
			FrmPictView frm = new FrmPictView(pictureBox1.Image);
			frm.ShowDialog(this);
			textBox1.Focus();
		}

		private void pictureBox2_Click(object sender, EventArgs e)
		{
			if (pictureBox2.Image == null)
			{
				return;
			}
			FrmPictView frm = new FrmPictView(pictureBox2.Image);
			frm.ShowDialog(this);
			textBox1.Focus();
		}

		private void pictureBox3_Click(object sender, EventArgs e)
		{
			if (pictureBox3.Image == null)
			{
				return;
			}
			FrmPictView frm = new FrmPictView(pictureBox2.Image);
			frm.ShowDialog(this);
			textBox1.Focus();
		}

		private void textBox1_Enter(object sender, EventArgs e)
		{
			textBox1.BackColor = Color.Green;
		}

		private void textBox1_Leave(object sender, EventArgs e)
		{
			textBox1.BackColor = Color.Gray;
		}
		/// <summary>
		        /// 写Txt日志 到当前程序根目录
		        /// </summary>
		        /// <param name="strLog"></param>
		public void WriteLog(string strLog)
		{
			strLog = DateTime.Now.ToString("yyyy-MM-dd HH-mm-ss") + "\t" + strLog;

			//string sFilePath = Environment.CurrentDirectory + "\\" + DateTime.Now.ToString("yyyyMM");
			string sFilePath = Application.StartupPath + "\\" + DateTime.Now.ToString("yyyyMM");
			//string sFileName = "生产工序截图存档" + DateTime.Now.ToString("dd") + ".log";
			string sFileName = "jwmsArchive.log";
			sFileName = sFilePath + "\\" + sFileName; //文件的绝对路径
			if (!Directory.Exists(sFilePath))//验证路径是否存在
			{
				Directory.CreateDirectory(sFilePath);
				//不存在则创建
			}
			FileStream fs;
			StreamWriter sw;
			if (File.Exists(sFileName))
			//验证文件是否存在，有则追加，无则创建
			{
				fs = new FileStream(sFileName, FileMode.Append, FileAccess.Write);
			}
			else
			{
				fs = new FileStream(sFileName, FileMode.Create, FileAccess.Write);
			}
			sw = new StreamWriter(fs);
			sw.WriteLine(strLog);
			sw.Close();
			fs.Close();
		}

		private void btnAbout_Click(object sender, EventArgs e)
		{
			FrmInfor frm = new FrmInfor();
			frm.ShowDialog(this);
			textBox1.Focus();
		}
	}
}
