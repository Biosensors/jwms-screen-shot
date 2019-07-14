namespace screenshot
{
	partial class FrmFolderSelection
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.button3 = new System.Windows.Forms.Button();
			this.textBox_saveDir = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button3
			// 
			this.button3.Location = new System.Drawing.Point(398, 10);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(31, 23);
			this.button3.TabIndex = 17;
			this.button3.Text = "...";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// textBox_saveDir
			// 
			this.textBox_saveDir.Location = new System.Drawing.Point(12, 12);
			this.textBox_saveDir.Name = "textBox_saveDir";
			this.textBox_saveDir.Size = new System.Drawing.Size(371, 21);
			this.textBox_saveDir.TabIndex = 16;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(299, 58);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(56, 26);
			this.button1.TabIndex = 18;
			this.button1.Text = "确定";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(361, 58);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(56, 26);
			this.button2.TabIndex = 19;
			this.button2.Text = "取消";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// FrmFolderSelection
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(441, 96);
			this.ControlBox = false;
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.textBox_saveDir);
			this.Name = "FrmFolderSelection";
			this.ShowInTaskbar = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "设定存放目录：";
			this.Load += new System.EventHandler(this.FrmFolderSelection_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.TextBox textBox_saveDir;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
	}
}