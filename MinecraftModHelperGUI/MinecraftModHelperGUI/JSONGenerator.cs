using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.IO;

namespace MinecraftModHelperGUI
{
	class JSONGenerator
	{
		string blockModelPath;
		string blockstateModelPath;
		string itemModelPath;
		string modid;

		string localAppPath;
		bool configExists = false;

		List<string> allowedItemStrings;
		List<string> allowedBlockStrings;

		public void Init()
		{
			allowedBlockStrings = new List<string>();
			allowedItemStrings = new List<string>();

			AddItemValues();
			AddBlockValues();

			localAppPath = AppDomain.CurrentDomain.BaseDirectory;

			if (ConfigurationManager.AppSettings["exists"].ToString() == "DONT_TOUCH")
				configExists = true;

			if (configExists)
			{
				Console.WriteLine("Add new settings? (Y/N)");
				string ans = Console.ReadLine();
				if (ans == "y" || ans == "Y")
				{
					Console.WriteLine("Block Model Path?");
					blockModelPath = @Console.ReadLine();
					Console.WriteLine("\nBlockstate Model Path");
					blockstateModelPath = @Console.ReadLine();
					Console.WriteLine("\nItem Model Path");
					itemModelPath = @Console.ReadLine();
					Console.WriteLine("\nMod ID?");
					modid = Console.ReadLine();

					ConfigurationManager.AppSettings.Set("blockModelPath", blockModelPath);
					ConfigurationManager.AppSettings.Set("blockstateModelPath", blockstateModelPath);
					ConfigurationManager.AppSettings.Set("itemModelPath", itemModelPath);
					ConfigurationManager.AppSettings.Set("modId", modid);
				}
				else
				{
					blockModelPath = ConfigurationManager.AppSettings["blockModelPath"].ToString();
					blockstateModelPath = ConfigurationManager.AppSettings["blockstateModelPath"].ToString();
					itemModelPath = ConfigurationManager.AppSettings["itemModelPath"].ToString();
					modid = ConfigurationManager.AppSettings["modId"].ToString();
				}
			}
			else
			{
				Console.WriteLine("Block Model Path?");
				blockModelPath = @Console.ReadLine();
				Console.WriteLine("\nBlockstate Model Path");
				blockstateModelPath = @Console.ReadLine();
				Console.WriteLine("\nItem Model Path");
				itemModelPath = @Console.ReadLine();
				Console.WriteLine("\nMod ID?");
				modid = Console.ReadLine();

				ConfigurationManager.AppSettings.Set("blockModelPath", blockModelPath);
				ConfigurationManager.AppSettings.Set("blockstateModelPath", blockstateModelPath);
				ConfigurationManager.AppSettings.Set("itemModelPath", itemModelPath);
				ConfigurationManager.AppSettings.Set("modId", modid);

			}

			Start();

		}

		void Start()
		{
			Console.WriteLine("\nBlock or Item?");
			string choice = Console.ReadLine();
			if (allowedBlockStrings.Contains(choice))
			{
				RunBlock();
			}
			else if (allowedItemStrings.Contains(choice))
			{
				RunItem();
			}
			else
			{
				Console.WriteLine("\nUnrecognized type, please try again");
				Console.ReadKey();
				Start();
			}
		}

		public void RunBlock()
		{
			Console.WriteLine("\nBlock name?");
			string blockName = Console.ReadLine();

			if (blockName == "debug")
			{
				blockModelPath = @"C:\Users\Nathan\Desktop\Debug\block";
				Console.WriteLine(blockModelPath + "TEST");
				blockstateModelPath = @"C:\Users\Nathan\Desktop\Debug\blockstate";
				itemModelPath = @"C:\Users\Nathan\Desktop\Debug\item";
			}

			using (StreamWriter sw = File.CreateText(blockModelPath + "/" + blockName + ".json"))
			{
				sw.WriteLine("{");
				sw.WriteLine("	\"parent\": \"block/cube_all\",");
				sw.WriteLine("	\"textures\": {");
				sw.WriteLine("		\"all\": \"" + modid + ":" + "blocks/" + blockName + "\"");
				sw.WriteLine("	}");
				sw.WriteLine("}");
			}

			using (StreamWriter sw = File.CreateText(blockstateModelPath + "/" + blockName + ".json"))
			{
				sw.WriteLine("{");
				sw.WriteLine("	\"variants\": {");
				sw.WriteLine("		\"normal\": { \"model\": \"" + modid + ":" + blockName + "\" }");
				sw.WriteLine("	}");
				sw.WriteLine("}");
			}

			using (StreamWriter sw = File.CreateText(itemModelPath + "/" + blockName + ".json"))
			{
				sw.WriteLine("{");
				sw.WriteLine("	\"parent\": \"" + modid + ":block/" + blockName + "\"");
				sw.WriteLine("}");
			}

			Console.WriteLine("\nCompleted, restart? (Y/N)");
			string restart = Console.ReadLine();
			if (restart == "Y" || restart == "y")
				Start();
		}

		public void RunItem()
		{
			Console.WriteLine("\nItem Name?");
			string itemName = Console.ReadLine();

			if (itemName == "debug")
			{
				blockModelPath = @"C:\Users\Nathan\Desktop\Debug\block";
				blockstateModelPath = @"C:\Users\Nathan\Desktop\Debug\blockstate";
				itemModelPath = @"C:\Users\Nathan\Desktop\Debug\item";
			}

			using (StreamWriter sw = File.CreateText(itemModelPath + "/" + itemName + ".json"))
			{
				sw.WriteLine("{");
				sw.WriteLine("	\"parent\": \"item/generated\",");
				sw.WriteLine("	\"textures\": {");
				sw.WriteLine("		\"layer0\": \"" + modid + ":items/" + itemName + "\"");
				sw.WriteLine("	}");
				sw.WriteLine("}");
			}

			Console.WriteLine("\nCompleted, restart? (Y/N)");
			string restart = Console.ReadLine();
			if (restart == "Y" || restart == "y")
				Start();
		}

		void AddItemValues()
		{
			allowedItemStrings.Add("Item");
			allowedItemStrings.Add("item");
			allowedItemStrings.Add("I");
			allowedItemStrings.Add("i");
		}

		void AddBlockValues()
		{
			allowedBlockStrings.Add("Block");
			allowedBlockStrings.Add("block");
			allowedBlockStrings.Add("B");
			allowedBlockStrings.Add("b");
		}
	}
}
