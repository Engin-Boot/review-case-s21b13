using Microsoft.VisualStudio.TestTools.UnitTesting;
using SenderFile;

namespace SenderTest
{
	[TestClass]
	public class SenderFileTest
	{
		[TestMethod]
		public void CkeckingFileExistenceForWrongPath()
		{
			string path= "C:/Users/king/Desktop/CaseStudy/review-report.csv";
			bool WrongPath=ReadingCSVFile.CheckCSVPathExistOrNot(path);
			Assert.AreEqual(WrongPath, false);
			
		}
		[TestMethod]
		public void CkeckingFileExistenceForRightPath()
		{
			string path = "C:/Users/king/Desktop/CaseStudy/review-case-s21b13/review-report.csv";
			bool RightPath = ReadingCSVFile.CheckCSVPathExistOrNot(path);
			Assert.IsTrue(RightPath);
		}
	}
}
