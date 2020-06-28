using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.IO;
using System;
using Projekt;

namespace UnitTestProject1
{
	
	[TestClass]
	public class UnitTest1
	{

		[TestMethod]
		public void TestMethod1()
		{
			
			int iloscdocelowa1 = 40;

			string RunningPath = AppDomain.CurrentDomain.BaseDirectory;
			string[] iloscfolderow1 = Directory.GetDirectories(string.Format("{0}Resources\\dbd\\", Path.GetFullPath(Path.Combine(RunningPath, @"..\..\"))));
			
			Assert.AreEqual(iloscdocelowa1, iloscfolderow1.Length,"Iloœæ plików nieprawid³owa ");


			



		}
	}
}
