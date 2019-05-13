namespace screenshot
{
	partial class Form2
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
			this.ckhAboveAll = new System.Windows.Forms.CheckBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.lblBarcode = new System.Windows.Forms.Label();
			this.lblInfor = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.chkPreview = new System.Windows.Forms.CheckBox();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnFolder = new System.Windows.Forms.Button();
			this.txtPath = new System.Windows.Forms.TextBox();
			this.btnAbout = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			this.SuspendLayout();
			// 
			// ckhAboveAll
			// 
			this.ckhAboveAll.AutoSize = true;
			this.ckhAboveAll.Location = new System.Drawing.Point(362, 18);
			this.ckhAboveAll.Name = "ckhAboveAll";
			this.ckhAboveAll.Size = new System.Drawing.Size(72, 16);
			this.ckhAboveAll.TabIndex = 1;
			this.ckhAboveAll.TabStop = false;
			this.ckhAboveAll.Text = "窗口置顶";
			this.ckhAboveAll.UseVisualStyleBackColor = true;
			this.ckhAboveAll.CheckedChanged += new System.EventHandler(this.ckhAboveAll_CheckedChanged);
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.SystemColors.Control;
			this.textBox1.Location = new System.Drawing.Point(70, 9);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(34, 21);
			this.textBox1.TabIndex = 0;
			this.textBox1.AcceptsTabChanged += new System.EventHandler(this.textBox1_AcceptsTabChanged);
			this.textBox1.TabIndexChanged += new System.EventHandler(this.textBox1_TabIndexChanged);
			this.textBox1.TabStopChanged += new System.EventHandler(this.textBox1_TabStopChanged);
			this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			this.textBox1.Enter += new System.EventHandler(this.textBox1_Enter);
			this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
			this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Enabled = false;
			this.label1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.Location = new System.Drawing.Point(12, 11);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 16);
			this.label1.TabIndex = 0;
			this.label1.Text = "条码：";
			// 
			// lblBarcode
			// 
			this.lblBarcode.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.lblBarcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.lblBarcode.Enabled = false;
			this.lblBarcode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblBarcode.Font = new System.Drawing.Font("Arial", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblBarcode.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.lblBarcode.Location = new System.Drawing.Point(108, 3);
			this.lblBarcode.Name = "lblBarcode";
			this.lblBarcode.Size = new System.Drawing.Size(208, 30);
			this.lblBarcode.TabIndex = 2;
			this.lblBarcode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// lblInfor
			// 
			this.lblInfor.AutoSize = true;
			this.lblInfor.Font = new System.Drawing.Font("宋体", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.lblInfor.Location = new System.Drawing.Point(7, 56);
			this.lblInfor.Name = "lblInfor";
			this.lblInfor.Size = new System.Drawing.Size(63, 14);
			this.lblInfor.TabIndex = 3;
			this.lblInfor.Text = "lblInfor";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Location = new System.Drawing.Point(4, 83);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(173, 163);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 4;
			this.pictureBox1.TabStop = false;
			this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
			// 
			// pictureBox2
			// 
			this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox2.Location = new System.Drawing.Point(183, 83);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(173, 163);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox2.TabIndex = 5;
			this.pictureBox2.TabStop = false;
			this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
			// 
			// pictureBox3
			// 
			this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox3.Location = new System.Drawing.Point(362, 83);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(173, 163);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox3.TabIndex = 6;
			this.pictureBox3.TabStop = false;
			this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
			// 
			// chkPreview
			// 
			this.chkPreview.AutoSize = true;
			this.chkPreview.Location = new System.Drawing.Point(362, -1);
			this.chkPreview.Name = "chkPreview";
			this.chkPreview.Size = new System.Drawing.Size(72, 16);
			this.chkPreview.TabIndex = 7;
			this.chkPreview.TabStop = false;
			this.chkPreview.Text = "显示预览";
			this.chkPreview.UseVisualStyleBackColor = true;
			this.chkPreview.CheckedChanged += new System.EventHandler(this.chkPreview_CheckedChanged);
			// 
			// btnClose
			// 
			this.btnClose.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnClose.Location = new System.Drawing.Point(510, 0);
			this.btnClose.Margin = new System.Windows.Forms.Padding(1);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(27, 27);
			this.btnClose.TabIndex = 8;
			this.btnClose.TabStop = false;
			this.btnClose.Text = "X";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnFolder
			// 
			this.btnFolder.Location = new System.Drawing.Point(362, 35);
			this.btnFolder.Name = "btnFolder";
			this.btnFolder.Size = new System.Drawing.Size(41, 21);
			this.btnFolder.TabIndex = 9;
			this.btnFolder.TabStop = false;
			this.btnFolder.Text = "目录";
			this.btnFolder.UseVisualStyleBackColor = true;
			this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
			// 
			// txtPath
			// 
			this.txtPath.BackColor = System.Drawing.SystemColors.Window;
			this.txtPath.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.txtPath.Location = new System.Drawing.Point(4, 39);
			this.txtPath.Name = "txtPath";
			this.txtPath.ReadOnly = true;
			this.txtPath.Size = new System.Drawing.Size(352, 14);
			this.txtPath.TabIndex = 10;
			this.txtPath.TabStop = false;
			this.txtPath.Text = "c:\\";
			this.txtPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
			// 
			// btnAbout
			// 
			this.btnAbout.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnAbout.Location = new System.Drawing.Point(481, 0);
			this.btnAbout.Margin = new System.Windows.Forms.Padding(1);
			this.btnAbout.Name = "btnAbout";
			this.btnAbout.Size = new System.Drawing.Size(27, 27);
			this.btnAbout.TabIndex = 11;
			this.btnAbout.TabStop = false;
			this.btnAbout.Text = "i";
			this.btnAbout.UseVisualStyleBackColor = true;
			this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
			// 
			// Form2
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.ClientSize = new System.Drawing.Size(538, 253);
			this.ControlBox = false;
			this.Controls.Add(this.btnAbout);
			this.Controls.Add(this.txtPath);
			this.Controls.Add(this.btnFolder);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.chkPreview);
			this.Controls.Add(this.pictureBox3);
			this.Controls.Add(this.pictureBox2);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.lblInfor);
			this.Controls.Add(this.lblBarcode);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.ckhAboveAll);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Form2";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "JWMS生产工序截图存档";
			this.Load += new System.EventHandler(this.Form2_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox ckhAboveAll;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblBarcode;
		private System.Windows.Forms.Label lblInfor;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.CheckBox chkPreview;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.Button btnFolder;
		private System.Windows.Forms.TextBox txtPath;
		private System.Windows.Forms.Button btnAbout;
	}
}