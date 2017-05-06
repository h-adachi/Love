using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Runner
{
	public partial class Form1 : Form
	{
		private readonly string mExtention = ".love";
		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			textBoxLovePath.Text = Properties.Settings.Default.LovePath;
			textBoxAppPath.Text = Properties.Settings.Default.AppPath;
		}

		private void Form1_FormClosed(object sender, FormClosedEventArgs e)
		{
			Properties.Settings.Default.LovePath = textBoxLovePath.Text;
			Properties.Settings.Default.AppPath = textBoxAppPath.Text;
			Properties.Settings.Default.Save();
		}

		private void buttonLovePath_Click(object sender, EventArgs e)
		{
			var dlg = new FolderBrowserDialog();
			if (dlg.ShowDialog() != DialogResult.OK) return;

			textBoxLovePath.Text = dlg.SelectedPath;
		}

		private void buttonAppPath_Click(object sender, EventArgs e)
		{
			var dlg = new FolderBrowserDialog();
			if (dlg.ShowDialog() != DialogResult.OK) return;

			textBoxAppPath.Text = dlg.SelectedPath;
		}

		private void buttonRun_Click(object sender, EventArgs e)
		{
			string lovePath = Path.Combine(textBoxLovePath.Text, "love.exe");
			string appPath = textBoxAppPath.Text;
			if(!File.Exists(lovePath) || !Directory.Exists(appPath))
			{
				// 実行不可
				return;
			}

			// 同名のloveファイルが存在した場合削除
			string rootPath = Path.GetDirectoryName(appPath);
			string appName = Path.GetFileNameWithoutExtension(appPath) + mExtention;
			string outputFile = Path.Combine(rootPath, appName);
			if (File.Exists(outputFile))
			{
				// 本来実行中か否かを見るべきかと思うが運用回避
				File.Delete(outputFile);
			}

			// appPathをzipで圧縮
			System.IO.Compression.ZipFile.CreateFromDirectory(
				appPath,
				outputFile,
				System.IO.Compression.CompressionLevel.Fastest
				, false);

			// love経由で起動
			System.Diagnostics.Process.Start(lovePath, outputFile);
		}
	}
}
