using System;
using System.Windows.Forms;
using System.IO;

namespace MinecraftModHelperGUI
{
	public partial class Form1 : Form
	{

		string assetPath;
		string modId;
		string blockFilePath;
		string itemFilePath;

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			
		}

		private void button1_Click(object sender, EventArgs e)
		{
			var form2 = new Form2();
			form2.Show();
			form2.SetNeededVariables(modId, assetPath, blockFilePath);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			var form3 = new Form3();
			form3.Show();
			form3.SetNeededVariables(modId, assetPath, itemFilePath);
		}

		private void NeededSubmitButton_Click(object sender, EventArgs e)
		{
			modId = ModIDBox.Text;
			assetPath = AssetPathBox.Text;
			blockFilePath = BlockFilePath.Text;
			itemFilePath = ItemFilePathBox.Text;
		}

		private void ConfigFilePathButton_Click(object sender, EventArgs e)
		{
			if (File.Exists(ConfigFilePathBox.Text))
			{
				string[] config = File.ReadAllLines(ConfigFilePathBox.Text);
				modId = config[0];
				assetPath = config[1];
				blockFilePath = config[2];
				itemFilePath = config[3];

				ModIDBox.Text = modId;
				AssetPathBox.Text = assetPath;
				BlockFilePath.Text = blockFilePath;
				ItemFilePathBox.Text = itemFilePath;
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			if (!File.Exists(ConfigFilePathBox.Text))
			{
				modId = ModIDBox.Text;
				assetPath = AssetPathBox.Text;
				blockFilePath = BlockFilePath.Text;
				itemFilePath = ItemFilePathBox.Text;
				using (StreamWriter sw = File.CreateText(ConfigFilePathBox.Text))
				{
					sw.WriteLine(modId);
					sw.WriteLine(assetPath);
					sw.WriteLine(blockFilePath);
					sw.WriteLine(itemFilePath);
				}
			}
			else
			{
				modId = ModIDBox.Text;
				assetPath = AssetPathBox.Text;
				blockFilePath = BlockFilePath.Text;
				itemFilePath = ItemFilePathBox.Text;
				string[] config = File.ReadAllLines(ConfigFilePathBox.Text);
				config[0] = modId;
				config[1] = assetPath;
				config[2] = blockFilePath;
				config[3] = itemFilePath;
				File.WriteAllLines(ConfigFilePathBox.Text, config);
			}
		}
	}
}
