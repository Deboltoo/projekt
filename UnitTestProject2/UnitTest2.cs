using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;
using Projekt;
using System.Data;

namespace UnitTestProject2
{
	[TestClass]
	public class UnitTest2
	{
		[TestMethod]
		public void TestMethod1()
		{

			string[] nazwyfolderow = new string[40]
			{
				"AceVisconti",
				"AdamFrancis",
				"AshWilliams",
				"BillOverbeck",
				"Cannibal",
				"ClaudetteMorel",
				"Clown",
				"DavidKing",
				"DavidTapp",
				"Deathslinger",
				"Demogorgon",
				"Doctor",
				"DwightFairfield",
				"FengMin",
				"GhostFace",
				"Hag",
				"Hillbilly",
				"Huntress",
				"JakePark",
				"JaneRomero",
				"JeffJohansen",
				"KateDenson",
				"LaurieStrode",
				"Legion",
				"MegThomas",
				"NancyWheeler",
				"NeaKarlsson",
				"Nightmare",
				"Nurse",
				"Oni",
				"Pig",
				"Plague",
				"QuentinSmith",
				"Shape",
				"Spirit",
				"SteveHarrington",
				"Trapper",
				"Wraith",
				"YuiKimura",
				"ZarinaKassir"
			};
			string[] czescciala = new string[3]
			{
				"_Head",
				"_Torso",
				"_Nogi"
			};

			Random r = new Random();
			int i = r.Next(nazwyfolderow.Length);
			string randomnazwafolderu = nazwyfolderow[i];

			int a = r.Next(czescciala.Length);
			string randomnazwaciala = czescciala[a];

			string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
			string randomfolder = Path.GetDirectoryName(string.Format("{0}Resources\\dbd\\" + randomnazwafolderu + "\\" + randomnazwaciala + "1", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\"))));
			string randomplik = Path.Combine(randomfolder + randomnazwaciala + "1");
			string jakijest = Path.GetFileName(randomplik);
			string docelowy = randomnazwafolderu + randomnazwaciala + "1";


			Assert.AreEqual(docelowy, jakijest, "Nie udalo sie znaleŸæ pliku");

		}
	}
}
