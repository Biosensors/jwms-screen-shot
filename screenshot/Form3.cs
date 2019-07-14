using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace screenshot
{
	public partial class Form3 : Form
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
		protected Bitmap screenImage;
		#endregion

		public Form3()
		{
			InitializeComponent();
		}

		private void Form3_Load(object sender, EventArgs e)
		{
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
					label1.Text = "Ctrl+Control+a " + DateTime.Now.ToString();
					break;
				default:
					break;
			}
			base.WndProc(ref m);
		}

		private void label1_Click(object sender, EventArgs e)
		{

		}
	}
}
