using DandS.RequestReply;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace RequestReply.Tests.ValueTypeTests
{
	/// <summary>
	/// Summary description for ValueTypeRequestTests
	/// </summary>
	[TestClass]
	public class ValueTypeRequestTests
	{
		string sessionChainId	= "session chain id";
		string requestChainId	= Guid.NewGuid().ToString();

		int nbrOfInfoItems	= 0;
		int nbrOfWarnings	= 0;
		int nbrOfErrors		= 0;

		public ValueTypeRequestTests()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		private TestContext testContextInstance;

		/// <summary>
		///Gets or sets the test context which provides
		///information about and functionality for the current test run.
		///</summary>
		public TestContext TestContext
		{
			get
			{
				return testContextInstance;
			}
			set
			{
				testContextInstance = value;
			}
		}

		#region Additional test attributes
		//
		// You can use the following additional attributes as you write your tests:
		//
		// Use ClassInitialize to run code before running the first test in the class
		// [ClassInitialize()]
		// public static void MyClassInitialize(TestContext testContext) { }
		//
		// Use ClassCleanup to run code after all tests in a class have run
		// [ClassCleanup()]
		// public static void MyClassCleanup() { }
		//
		// Use TestInitialize to run code before running each test 
		// [TestInitialize()]
		// public void MyTestInitialize() { }
		//
		// Use TestCleanup to run code after each test has run
		// [TestCleanup()]
		// public void MyTestCleanup() { }
		//
		#endregion

		private Reply<TestObjectWithProperties> TestIntRequestMethod(Request<int> request)
		{
			var rplyData	= new TestObjectWithProperties();
			var rply		= new Reply<TestObjectWithProperties>();
			rply.ReplyData	= rplyData;
			for (int i = 0; i < nbrOfInfoItems; i++)
			{
				rply.AddOpStatusItem(rply.InfoItems, new OpStatusItem("property:" +  i.ToString(), "property:" +  i.ToString(), "code:" + i.ToString(), "msg: " + i.ToString(), false));
			}
			for (int i = 0; i < nbrOfWarnings; i++)
			{
				rply.AddOpStatusItem(rply.Warnings, new OpStatusItem("property:" +  i.ToString(), "property:" +  i.ToString(), "code:" + i.ToString(), "msg: " + i.ToString(), false));
			}
			for (int i = 0; i < nbrOfErrors; i++)
			{
				rply.AddOpStatusItem(rply.Errors, new OpStatusItem("property:" +  i.ToString(), "property:" +  i.ToString(), "code:" + i.ToString(), "msg: " + i.ToString(), false));
			}
			return rply;
		}

		[TestMethod]
		public void IntRequestWithErrorsSucceeds()
		{
			nbrOfErrors = 1;
			nbrOfInfoItems = 1;
			nbrOfWarnings = 1;

			var testRqst	= new Request<int>(sessionChainId, requestChainId);
			var testRply	= TestIntRequestMethod(testRqst);
			Assert.IsTrue(testRply.HasInfoItems);
			Assert.IsTrue(testRply.HasWarnings);
			Assert.IsFalse(testRply.IsSuccessful);
		}

		[TestMethod]
		public void IntRequestWithOutErrorsSucceeds()
		{
			nbrOfErrors = 0;
			nbrOfInfoItems = 1;
			nbrOfWarnings = 1;

			var testRqst	= new Request<int>(sessionChainId, requestChainId);
			var testRply	= TestIntRequestMethod(testRqst);
			Assert.IsTrue(testRply.HasInfoItems);
			Assert.IsTrue(testRply.HasWarnings);
			Assert.IsTrue(testRply.IsSuccessful);
		}
	}
}
