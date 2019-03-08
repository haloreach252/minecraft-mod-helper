using System;
using System.IO;
using System.Windows.Forms;

namespace MinecraftModHelperGUI
{
	public partial class Form2 : Form
	{
		public Form2()
		{
			InitializeComponent();
		}

		string modId;
		string assetPath;
		string blockPath;
		string newBlock;

		private void GenerateButton_Click(object sender, EventArgs e)
		{
			string blockName = BlockNameTextBox.Text;

			using(StreamWriter sw = File.CreateText(assetPath + "/blockstates/" + blockName + ".json"))
			{
				sw.WriteLine("{");
				sw.WriteLine("	\"variants\": {");
				sw.WriteLine("		\"normal\": { \"model\": \"" + modId + ":" + blockName + "\" }");
				sw.WriteLine("	}");
				sw.WriteLine("}");
			}

			using (StreamWriter sw = File.CreateText(assetPath + "/models/block/" + blockName + ".json"))
			{
				sw.WriteLine("{");
				sw.WriteLine("	\"parent\": \"block/cube_all\",");
				sw.WriteLine("	\"textures\": {");
				sw.WriteLine("		\"all\": \"" + modId + ":" + "blocks/" + blockName + "\"");
				sw.WriteLine("	}");
				sw.WriteLine("}");
			}

			using(StreamWriter sw = File.CreateText(assetPath + "/models/item/" + blockName + ".json"))
			{
				sw.WriteLine("{");
				sw.WriteLine("	\"parent\": \"" + modId + ":block/" + blockName + "\"");
				sw.WriteLine("}");
			}

			if (VaultBlockRadio.Checked)
				newBlock = "	public static final Block " + blockName.ToUpper() + " = new VaultBlockBase(\"" + blockName + "\", Material.IRON);" + "\n";
			else if(RegularBlockRadio.Checked)
				newBlock = "	public static final Block " + blockName.ToUpper() + " = new BlockBase(\"" + blockName + "\", Material.IRON);" + "\n";
			string[] blockStrings = File.ReadAllLines(blockPath);
			blockStrings[blockStrings.Length - 2] = newBlock;
			File.WriteAllLines(blockPath, blockStrings);

			Close();

		}

		private void groupBox2_Enter(object sender, EventArgs e)
		{

		}

		public void SetNeededVariables(string modid, string assetpath, string blockpath)
		{
			modId = modid;
			assetPath = assetpath;
			blockPath = blockpath;
		}

	}
}
