using System;
using System.IO;
using System.Windows.Forms;

namespace MinecraftModHelperGUI
{
	public partial class Form3 : Form
	{
		public Form3()
		{
			InitializeComponent();
		}

		string modId;
		string assetPath;
		string itemPath;
		string newItem;

		private void GenerateButton_Click(object sender, EventArgs e)
		{
			string itemName = ItemNameBox.Text;

			using (StreamWriter sw = File.CreateText(assetPath + "/models/item/" + itemName + ".json"))
			{
				sw.WriteLine("{");
				sw.WriteLine("	\"parent\": \"item/generated\",");
				sw.WriteLine("	\"textures\": {");
				sw.WriteLine("		\"layer0\": \"" + modId + ":items/" + itemName + "\"");
				sw.WriteLine("	}");
				sw.WriteLine("}");
			}

			newItem = "	public static final Item " + itemName.ToUpper() + " = new ItemBase(\"" + itemName + "\");" + "\n";
			string[] itemStrings = File.ReadAllLines(itemPath);
			itemStrings[itemStrings.Length - 2] = newItem;
			File.WriteAllLines(itemPath, itemStrings);

			Close();
		}

		public void SetNeededVariables(string modid, string assetpath, string itempath)
		{
			modId = modid;
			assetPath = assetpath;
			itemPath = itempath;
		}

	}
}
