using System;
using System.Collections.Generic;
using GoodReads_NetWrapper;
using GoodReads_NetWrapper.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace GoodReads_NetWrapper_Test
{
    /// <summary>
    ///This is a test class for GoodReadsTest and is intended
    ///to contain all GoodReadsTest Unit Tests
    ///</summary>
    [TestClass()]
    public class GoodReadsTest
    {
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
        //You can use the following additional attributes as you write your tests:
        //
        //Use ClassInitialize to run code before running the first test in the class
        //[ClassInitialize()]
        //public static void MyClassInitialize(TestContext testContext)
        //{
        //}
        //
        //Use ClassCleanup to run code after all tests in a class have run
        //[ClassCleanup()]
        //public static void MyClassCleanup()
        //{
        //}
        //
        //Use TestInitialize to run code before running each test
        //[TestInitialize()]
        //public void MyTestInitialize()
        //{
        //}
        //
        //Use TestCleanup to run code after each test has run
        //[TestCleanup()]
        //public void MyTestCleanup()
        //{
        //}
        //

        #endregion Additional test attributes

        /// <summary>
        ///A test for GetBookID
        ///</summary>
        [TestMethod()]
        public void GetBookIDTestMatch()
        {
            string DeveloperKey = DevelopersKey.Key;
            GoodReads target = new GoodReads(DeveloperKey);
            string isbn = "0345451325";
            long expected = 60229;
            long actual;
            actual = target.GetBookID(isbn);
            Assert.AreEqual(expected, actual);
        }

        /// <summary>
        ///A test for GetBookReveiwCounts
        ///</summary>
        [TestMethod()]
        public void GetBookReveiwCountsTest()
        {
            string DeveloperKey = DevelopersKey.Key;
            GoodReads target = new GoodReads(DeveloperKey);
            List<string> isbns = new List<string>(new string[] { "0345451325" });
            int expected = 60229;
            List<ReviewCount> actual;
            actual = target.GetBookReviewCounts(isbns);
            Assert.AreEqual(expected, actual[0].id);
        }
    }
}