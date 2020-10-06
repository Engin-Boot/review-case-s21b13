using Microsoft.VisualStudio.TestTools.UnitTesting;
using ReceiverModule;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReceiverTest
{
	[TestClass]
	public class ReceiverFileTest
	{
		[TestMethod]
		public void CheckWritingToCsvFileIsSuccessful()
		{
			Dictionary<String, int> __wordAndWordFrequency = new Dictionary<String, int>();
			__wordAndWordFrequency.Add("Deepak", 6);
			__wordAndWordFrequency.Add("varshita", 8);
			bool Result = WritingToCSVFile.RedirectingToCsvFile(__wordAndWordFrequency);
			Assert.IsTrue(Result);
		}
		[TestMethod]
		public void CheckWritingToCsvFileIsUnsuccessful()
		{
			Dictionary<String, int> __wordAndWordFrequency = new Dictionary<String, int>();
			bool Result = WritingToCSVFile.RedirectingToCsvFile(__wordAndWordFrequency);
			Assert.IsFalse(Result);
		}
	}
}
