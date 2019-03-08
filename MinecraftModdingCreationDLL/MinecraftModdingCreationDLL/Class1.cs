using System;
using System.IO;
using System.Collections.Generic;

namespace MinecraftCreator
{
	public class Info
	{
		public static string ModName { get; private set; }
		public static string ModID { get; private set; }
		public static string AssetPath { get; private set; }
		public static string BlockPath { get; private set; }
		public static string ItemPath { get; private set; }

		public void SetValues(string modname, string modid, string assetpath, string blockpath, string itempath)
		{
			ModName = modname;
			ModID = modid;
			AssetPath = assetpath;
			BlockPath = blockpath;
			ItemPath = itempath;
		}
	}

	public class Setup
	{
		public void Start(string filePath)
		{
			DirectoryInfo moddingDir = Directory.CreateDirectory(filePath + "/" + Info.ModName);
			
		}
	}

    public class CreateItem
	{
		string modId;
		string assetPath;
		string itemPath;
		string templatePath = @".\templates\ItemTemplate.txt";
		List<string> tags = new List<string>
		{
			"modid",
			"itemname"
		};

		List<string> items = new List<string>();

		public void CreateNewItem(string itemName)
		{
			modId = Info.ModID;
			assetPath = Info.AssetPath;
			itemPath = Info.ItemPath;

			using (StreamWriter sw = File.CreateText(assetPath + "/models/item/" + itemName + ".json"))
			{
				sw.WriteLine("{");
				sw.WriteLine("	\"parent\": \"item/generated\",");
				sw.WriteLine("	\"textures\": {");
				sw.WriteLine("		\"layer0\": \"" + modId + ":items/" + itemName + "\"");
				sw.WriteLine("	}");
				sw.WriteLine("}");
			}

			items.Add("	public static final Item " + itemName.ToUpper() + " = new ItemBase(\"" + itemName + "\");" + "\n");
		}
	}

	public class CreateBlock
	{

	}

}
