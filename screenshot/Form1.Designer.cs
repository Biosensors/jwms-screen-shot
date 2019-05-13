namespace screenshot
{
	partial class Form1
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.button4 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.textBox_saveDir = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(269, 12);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(90, 22);
			this.button4.TabIndex = 15;
			this.button4.Text = "部分截屏";
			this.button4.UseVisualStyleBackColor = true;
			this.button4.Click += new System.EventHandler(this.button4_Click);
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(416, 98);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(55, 23);
			this.button3.TabIndex = 14;
			this.button3.Text = "浏览";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// textBox_saveDir
			// 
			this.textBox_saveDir.Location = new System.Drawing.Point(98, 98);
			this.textBox_saveDir.Name = "textBox_saveDir";
			this.textBox_saveDir.ReadOnly = true;
			this.textBox_saveDir.Size = new System.Drawing.Size(311, 21);
			this.textBox_saveDir.TabIndex = 13;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(15, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(77, 12);
			this.label2.TabIndex = 12;
			this.label2.Text = "当前分辨率：";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(15, 101);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 12);
			this.label1.TabIndex = 11;
			this.label1.Text = "保存路径：";
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(141, 12);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(90, 22);
			this.button2.TabIndex = 10;
			this.button2.Text = "全屏截图";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(98, 57);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(261, 21);
			this.textBox1.TabIndex = 9;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(15, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(80, 22);
			this.button1.TabIndex = 8;
			this.button1.Text = "查看屏幕分辨率";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(499, 140);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.textBox_saveDir);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button1);
			this.Name = "Form1";
			this.Text = "JWMS 截屏测试";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button4;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.TextBox textBox_saveDir;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button button1;
	}
}

