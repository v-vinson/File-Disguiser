namespace Disguiser
{
	partial class MainWindow
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.btnSelectSourceFile = new System.Windows.Forms.Button();
			this.txtSourceFileName = new System.Windows.Forms.TextBox();
			this.btnSelectPicFile = new System.Windows.Forms.Button();
			this.txtPicFileName = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnCreate = new System.Windows.Forms.Button();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.cbEncrypt = new System.Windows.Forms.CheckBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.cbNoUnblock = new System.Windows.Forms.CheckBox();
			this.btnSelectEncryptFile = new System.Windows.Forms.Button();
			this.txtEncryptFileName = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.cbDecrypt = new System.Windows.Forms.CheckBox();
			this.btnDecrypt = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.tabControl.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl
			// 
			this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tabControl.Controls.Add(this.tabPage1);
			this.tabControl.Controls.Add(this.tabPage2);
			this.tabControl.Location = new System.Drawing.Point(7, 7);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(420, 128);
			this.tabControl.TabIndex = 1;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.cbNoUnblock);
			this.tabPage1.Controls.Add(this.textBox1);
			this.tabPage1.Controls.Add(this.label3);
			this.tabPage1.Controls.Add(this.cbEncrypt);
			this.tabPage1.Controls.Add(this.btnSelectSourceFile);
			this.tabPage1.Controls.Add(this.txtSourceFileName);
			this.tabPage1.Controls.Add(this.btnSelectPicFile);
			this.tabPage1.Controls.Add(this.txtPicFileName);
			this.tabPage1.Controls.Add(this.label2);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Controls.Add(this.btnCreate);
			this.tabPage1.Location = new System.Drawing.Point(4, 26);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(412, 98);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "伪装";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// btnSelectSourceFile
			// 
			this.btnSelectSourceFile.Location = new System.Drawing.Point(346, 35);
			this.btnSelectSourceFile.Name = "btnSelectSourceFile";
			this.btnSelectSourceFile.Size = new System.Drawing.Size(60, 23);
			this.btnSelectSourceFile.TabIndex = 7;
			this.btnSelectSourceFile.Text = "浏览";
			this.btnSelectSourceFile.UseVisualStyleBackColor = true;
			this.btnSelectSourceFile.Click += new System.EventHandler(this.btnSelectSourceFile_Click);
			// 
			// txtSourceFileName
			// 
			this.txtSourceFileName.Location = new System.Drawing.Point(78, 35);
			this.txtSourceFileName.Name = "txtSourceFileName";
			this.txtSourceFileName.ReadOnly = true;
			this.txtSourceFileName.Size = new System.Drawing.Size(262, 23);
			this.txtSourceFileName.TabIndex = 6;
			// 
			// btnSelectPicFile
			// 
			this.btnSelectPicFile.Location = new System.Drawing.Point(346, 6);
			this.btnSelectPicFile.Name = "btnSelectPicFile";
			this.btnSelectPicFile.Size = new System.Drawing.Size(60, 23);
			this.btnSelectPicFile.TabIndex = 5;
			this.btnSelectPicFile.Text = "浏览";
			this.btnSelectPicFile.UseVisualStyleBackColor = true;
			this.btnSelectPicFile.Click += new System.EventHandler(this.btnSelectPicFile_Click);
			// 
			// txtPicFileName
			// 
			this.txtPicFileName.Location = new System.Drawing.Point(78, 6);
			this.txtPicFileName.Name = "txtPicFileName";
			this.txtPicFileName.ReadOnly = true;
			this.txtPicFileName.Size = new System.Drawing.Size(262, 23);
			this.txtPicFileName.TabIndex = 4;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(6, 38);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(68, 17);
			this.label2.TabIndex = 3;
			this.label2.Text = "源文件路径";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(6, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 17);
			this.label1.TabIndex = 2;
			this.label1.Text = "图片路径";
			// 
			// btnCreate
			// 
			this.btnCreate.Location = new System.Drawing.Point(304, 64);
			this.btnCreate.Name = "btnCreate";
			this.btnCreate.Size = new System.Drawing.Size(102, 29);
			this.btnCreate.TabIndex = 1;
			this.btnCreate.Text = "生成";
			this.btnCreate.UseVisualStyleBackColor = true;
			this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.label7);
			this.tabPage2.Controls.Add(this.btnDecrypt);
			this.tabPage2.Controls.Add(this.textBox2);
			this.tabPage2.Controls.Add(this.label6);
			this.tabPage2.Controls.Add(this.cbDecrypt);
			this.tabPage2.Controls.Add(this.btnSelectEncryptFile);
			this.tabPage2.Controls.Add(this.txtEncryptFileName);
			this.tabPage2.Controls.Add(this.label5);
			this.tabPage2.Location = new System.Drawing.Point(4, 26);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(412, 98);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "解封";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// cbEncrypt
			// 
			this.cbEncrypt.AutoSize = true;
			this.cbEncrypt.Location = new System.Drawing.Point(178, 66);
			this.cbEncrypt.Name = "cbEncrypt";
			this.cbEncrypt.Size = new System.Drawing.Size(51, 21);
			this.cbEncrypt.TabIndex = 8;
			this.cbEncrypt.Text = "加密";
			this.cbEncrypt.UseVisualStyleBackColor = true;
			this.cbEncrypt.CheckedChanged += new System.EventHandler(this.cbEncrypt_CheckedChanged);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(6, 67);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(56, 17);
			this.label3.TabIndex = 9;
			this.label3.Text = "加密密钥";
			// 
			// textBox1
			// 
			this.textBox1.Enabled = false;
			this.textBox1.Location = new System.Drawing.Point(78, 64);
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.Size = new System.Drawing.Size(94, 23);
			this.textBox1.TabIndex = 10;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(298, 135);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(129, 17);
			this.label4.TabIndex = 2;
			this.label4.Text = "Made by Vin   V1.0.0";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// cbNoUnblock
			// 
			this.cbNoUnblock.AutoSize = true;
			this.cbNoUnblock.Location = new System.Drawing.Point(235, 66);
			this.cbNoUnblock.Name = "cbNoUnblock";
			this.cbNoUnblock.Size = new System.Drawing.Size(63, 21);
			this.cbNoUnblock.TabIndex = 11;
			this.cbNoUnblock.Text = "免解封";
			this.cbNoUnblock.UseVisualStyleBackColor = true;
			this.cbNoUnblock.CheckedChanged += new System.EventHandler(this.cbNoUnblock_CheckedChanged);
			// 
			// btnSelectEncryptFile
			// 
			this.btnSelectEncryptFile.Location = new System.Drawing.Point(346, 6);
			this.btnSelectEncryptFile.Name = "btnSelectEncryptFile";
			this.btnSelectEncryptFile.Size = new System.Drawing.Size(60, 23);
			this.btnSelectEncryptFile.TabIndex = 10;
			this.btnSelectEncryptFile.Text = "浏览";
			this.btnSelectEncryptFile.UseVisualStyleBackColor = true;
			this.btnSelectEncryptFile.Click += new System.EventHandler(this.btnSelectEncryptFile_Click);
			// 
			// txtEncryptFileName
			// 
			this.txtEncryptFileName.Location = new System.Drawing.Point(78, 6);
			this.txtEncryptFileName.Name = "txtEncryptFileName";
			this.txtEncryptFileName.ReadOnly = true;
			this.txtEncryptFileName.Size = new System.Drawing.Size(262, 23);
			this.txtEncryptFileName.TabIndex = 9;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 10);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(56, 17);
			this.label5.TabIndex = 8;
			this.label5.Text = "文件路径";
			// 
			// textBox2
			// 
			this.textBox2.Enabled = false;
			this.textBox2.Location = new System.Drawing.Point(78, 35);
			this.textBox2.Name = "textBox2";
			this.textBox2.ReadOnly = true;
			this.textBox2.Size = new System.Drawing.Size(94, 23);
			this.textBox2.TabIndex = 13;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(6, 38);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(56, 17);
			this.label6.TabIndex = 12;
			this.label6.Text = "加密密钥";
			// 
			// cbDecrypt
			// 
			this.cbDecrypt.AutoSize = true;
			this.cbDecrypt.Location = new System.Drawing.Point(178, 37);
			this.cbDecrypt.Name = "cbDecrypt";
			this.cbDecrypt.Size = new System.Drawing.Size(51, 21);
			this.cbDecrypt.TabIndex = 11;
			this.cbDecrypt.Text = "解密";
			this.cbDecrypt.UseVisualStyleBackColor = true;
			this.cbDecrypt.CheckedChanged += new System.EventHandler(this.cbDecrypt_CheckedChanged);
			// 
			// btnDecrypt
			// 
			this.btnDecrypt.Location = new System.Drawing.Point(346, 35);
			this.btnDecrypt.Name = "btnDecrypt";
			this.btnDecrypt.Size = new System.Drawing.Size(60, 57);
			this.btnDecrypt.TabIndex = 14;
			this.btnDecrypt.Text = "解封";
			this.btnDecrypt.UseVisualStyleBackColor = true;
			this.btnDecrypt.Click += new System.EventHandler(this.btnDecrypt_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(6, 67);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(318, 17);
			this.label7.TabIndex = 15;
			this.label7.Text = "免解封伪装文件直接将.jpg后缀改回原文件的格式即可还原";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(8, 135);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(200, 17);
			this.label8.TabIndex = 3;
			this.label8.Text = "本软件完全免费，禁止用于商业用途";
			this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(434, 155);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.tabControl);
			this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.MaximizeBox = false;
			this.Name = "MainWindow";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "文件伪装器";
			this.tabControl.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.Button btnCreate;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnSelectSourceFile;
		private System.Windows.Forms.TextBox txtSourceFileName;
		private System.Windows.Forms.Button btnSelectPicFile;
		private System.Windows.Forms.TextBox txtPicFileName;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.CheckBox cbEncrypt;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.CheckBox cbNoUnblock;
		private System.Windows.Forms.Button btnSelectEncryptFile;
		private System.Windows.Forms.TextBox txtEncryptFileName;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.CheckBox cbDecrypt;
		private System.Windows.Forms.Button btnDecrypt;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
	}
}

