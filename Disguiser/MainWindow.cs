using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Disguiser
{
	public partial class MainWindow : Form
	{
		private string picFileName = null;
		private string sourceFileName = null;
		private string targetFileName = null;
		private string encryptFileName = null;

		public MainWindow()
		{
			InitializeComponent();
		}

		private void btnCreate_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(picFileName) && !string.IsNullOrEmpty(sourceFileName)) 
			{
				try
				{
					byte[] picFileBytes;

					using (var picFileStream = ConvertImage(picFileName, ImageFormat.Jpeg))
					{
						picFileBytes = new byte[picFileStream.Length];
						picFileStream.Read(picFileBytes, 0, picFileBytes.Length);
					}

					var sourceFileBytes = File.ReadAllBytes(sourceFileName);

					var targetFileBytes = new byte[picFileBytes.Length + sourceFileBytes.Length];
					picFileBytes.CopyTo(targetFileBytes, 0);
					sourceFileBytes.CopyTo(targetFileBytes, picFileBytes.Length - 1);

					var targetFileDialog = new SaveFileDialog
					{
						Filter = "*.jpg|*.jpg",
						FileName = "target"
					};

					if (targetFileDialog.ShowDialog() == DialogResult.OK)
					{
						targetFileName = targetFileDialog.FileName;

						if (!string.IsNullOrEmpty(targetFileName))
						{
							File.WriteAllBytes(targetFileName, targetFileBytes);

							if (!cbNoUnblock.Checked)
							{
								File.AppendAllText(targetFileName, string.Format("\r\n<PicLength>{0}</PicLength>\r\n<SourceFileLength>{1}</SourceFileLength>\r\n<SourceFileFormat>{2}</SourceFileFormat>", picFileBytes.Length, sourceFileBytes.Length, sourceFileName.Split('.').Last()));
							}

							MessageBox.Show("生成成功", "提示");
						}
					}

					targetFileDialog.Dispose();
				}
				catch (Exception ex)
				{
					MessageBox.Show("发生错误: " + ex.Message, "提示");
				}
			}
			else
			{
				MessageBox.Show("未选择图片或源文件", "提示");
			}
		}

		private void btnSelectPicFile_Click(object sender, EventArgs e)
		{
			var picFileDialog = new OpenFileDialog
			{
				Title = "选择图片",
				Filter = "(*.jpg,*.png,*.jpeg,*.bmp,*.gif)|*.jpg;*.png;*.jpeg;*.bmp;*.gif|全部文件(*.*)|*.*"
			};

			if (picFileDialog.ShowDialog() == DialogResult.OK)
			{
				picFileName = picFileDialog.FileName;
				txtPicFileName.Text = picFileName;
			}

			picFileDialog.Dispose();
		}

		private void btnSelectSourceFile_Click(object sender, EventArgs e)
		{
			var sourceFileDialog = new OpenFileDialog
			{
				Title = "选择需要伪装的文件",
				Filter = "全部文件(*.*)|*.*"
			};

			if (sourceFileDialog.ShowDialog() == DialogResult.OK)
			{
				sourceFileName = sourceFileDialog.FileName;
				txtSourceFileName.Text = sourceFileName;
			}

			sourceFileDialog.Dispose();
		}

		private Stream ConvertImage(string originalFileName, ImageFormat format)
		{
			var image = Image.FromFile(originalFileName);

			var stream = new MemoryStream();
			image.Save(stream, format);
			stream.Position = 0;
			return stream;
		}

		private void cbEncrypt_CheckedChanged(object sender, EventArgs e)
		{
			if (cbEncrypt.Checked) 
			{
				MessageBox.Show("普通版无法使用该功能", "提示");
				cbEncrypt.Checked = false;
			}
		}

		private void cbNoUnblock_CheckedChanged(object sender, EventArgs e)
		{
			if (cbNoUnblock.Checked)
			{
				MessageBox.Show("注意:\r\n只有rar、zip等文件支持免解封伪装，若要解封，直接将伪装文件的.jpg后缀改回原文件的格式即可", "提示");
			}
		}

		private void btnSelectEncryptFile_Click(object sender, EventArgs e)
		{
			var encryptFileDialog = new OpenFileDialog
			{
				Title = "选伪装文件",
				Filter = "*.jpg|*.jpg|全部文件(*.*)|*.*"
			};

			if (encryptFileDialog.ShowDialog() == DialogResult.OK)
			{
				encryptFileName = encryptFileDialog.FileName;
				txtEncryptFileName.Text = encryptFileName;
			}

			encryptFileDialog.Dispose();
		}

		private void cbDecrypt_CheckedChanged(object sender, EventArgs e)
		{
			if (cbDecrypt.Checked)
			{
				MessageBox.Show("普通版无法使用该功能", "提示");
				cbDecrypt.Checked = false;
			}
		}

		private void btnDecrypt_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(encryptFileName))
			{
				try
				{
					var encryptFileLines = File.ReadAllLines(encryptFileName);
					string picLengthMatch = Regex.Match(encryptFileLines[encryptFileLines.Length - 3], @">\d*</").Value;
					string sourceFileLengthMatch = Regex.Match(encryptFileLines[encryptFileLines.Length - 2], @">\d*</").Value;
					string fileFormatMatch = Regex.Match(encryptFileLines[encryptFileLines.Length - 1], @">\w*</").Value;

					var picLengthStr = Regex.Match(picLengthMatch, @"\d+").Value;
					int picLength = Convert.ToInt32(picLengthStr);
					var sourceFileLengthStr = Regex.Match(sourceFileLengthMatch, @"\d+").Value;
					int sourceFileLength = Convert.ToInt32(sourceFileLengthStr);

					string fileFormat = Regex.Match(fileFormatMatch, @"\w+").Value;

					var encryptFileBytes = File.ReadAllBytes(encryptFileName);
					var decryptFileBytes = new byte[sourceFileLength];
					Array.Copy(encryptFileBytes, picLength - 1, decryptFileBytes, 0, sourceFileLength);

					var decryptFileName = encryptFileName.Replace(encryptFileName.Split('.').Last(), fileFormat);
					File.WriteAllBytes(decryptFileName, decryptFileBytes);

					MessageBox.Show("解封成功，解封文件已在伪装文件目录下生成", "提示");
				}
				catch (Exception ex)
				{
					MessageBox.Show("发生错误: " + ex.Message + "\r\n请检查需要解封的文件是否正确", "提示");
				}
			}
			else
			{
				MessageBox.Show("未选择文件", "提示");
			}
		}
	}
}
